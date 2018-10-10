using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using PS.Plot.FrameBasic.Module_Common.Interface;
using TechniqueMaster.Module_Technique.Componet.Adapter;
using TechniqueMaster.Module_Technique.Controller;
using PS.Plot.FrameBasic.Module_SupportLibs.DevExpressionTools;
using PS.Plot.FrameBasic.Module_Common.Component;
using PS.Plot.FrameBasic.Module_System.DevExpressionTools;
using TechniqueMaster.Module_Technique.Componet.Enum;

namespace TechniqueMaster.Module_Technique.View.UControl
{
    public partial class UC_TechniqueLogEdit : DevExpress.XtraEditors.XtraUserControl,IInitialUI,IValidateInput2
    {
        private TB_TechniqueLogBuilder builder;
        private TB_TechniqueLogAdapter adapter;
        private TechniqueLogController controller;
        private GridControlHelper gridHelper;

        public UC_TechniqueLogEdit()
        {
            InitializeComponent();
        }

        private void UC_TechniqueLogEdit_Load(object sender, EventArgs e)
        {
            onCreateComponet();
            onInitialUI();
        }

        public void onCreateComponet()
        {
            builder = new TB_TechniqueLogBuilder();
            adapter = new TB_TechniqueLogAdapter();
            controller = new TechniqueLogController();
            gridHelper = new GridControlHelper(gridView_Misssion, gridControl_Misssion);
            controller.LoadEntry();
        }

        public void onInitialUI()
        {
            this.calendar_DataPicker.DateTime = DateTime.Now.Date;

            this.cmb_Tech.Properties.Items.Clear();
            foreach (var item in new TechniqueController().TravleUnFinishEntities())
                this.cmb_Tech.Properties.Items.Add(item);
            if (cmb_Tech.Properties.Items.Count > 0)
                cmb_Tech.SelectedIndex = 0;
            
            this.dateE_Date.DateTime = DateTime.Now.Date;
            onRefreshLogTable();
        }

        private void onRefreshLogTable()
        {
            if (adapter != null)
                adapter.NotifyClearTable();

            adapter.Initial(controller.QueryEntryByDate(this.dateE_Date.DateTime.Date), builder);
            adapter.NotifyfreshDataTable();
            gridHelper.GridControl.DataSource = adapter.ResultTable;

            gridHelper.SetAllColumnEditable(false);
            gridHelper.SetCellResposity(builder.Op_Delete, repo_HLE_Delete);
            gridHelper.SetCellResposity(builder.Op_Edit, repo_HLE_Edit);
            gridHelper.setColunmsVisual(false, builder.ID, builder.MissionID);
        }


        private void cmb_Tech_SelectedIndexChanged(object sender, EventArgs e)
        {
            long currentTechID = TechniqueController.ExtractID(cmb_Tech.SelectedItem);
            this.cmb_Mission.Properties.Items.Clear();
            foreach (var item in new TechniqueMisssionController().QueryEntriesByTechniquIDWithUnFinishState(currentTechID))
                this.cmb_Mission.Properties.Items.Add(item);
            if (cmb_Mission.Properties.Items.Count > 0)
                cmb_Mission.SelectedIndex = 0;
        }

        private void dateE_Date_EditValueChanged(object sender, EventArgs e)
        {
            onRefreshLogTable();
        }

        private void btn_sure_Click(object sender, EventArgs e)
        {
            Validator validator = onValidateInputValue();
            if (validator.IsValidate == false)
            {
                MessageBoxHelper.ShowInputErrorDialog(validator.ErrorMessage);
                return;
            }

            onExtractInputValue();

            if (controller.CurrentID == 0)
            {
                if (controller.InsertEntry())
                {
                    new TechniqueMisssionController().ShiftMissionStatus(TechniqueMisssionController.ExtractID(cmb_Mission.SelectedItem), MissionStatusEnum.Running, calendar_DataPicker.DateTime);
                    new TechniqueController().ShiftTechStatus(TechniqueController.ExtractID(cmb_Tech.SelectedItem), TechniqueStatusEnum.Start, calendar_DataPicker.DateTime);
                }
                else
                    MessageBoxHelper.ShowCreateStateDialog(false);
            }
            else
            {
                MessageBoxHelper.ShowUpdateStateDialog(controller.UpdateEntryByID());
                cmb_Mission.Enabled = true;
                cmb_Tech.Enabled = true;
            }
            
            this.dateE_Date.DateTime = calendar_DataPicker.DateTime;
            onRefreshLogTable();
        }

        public void onExtractInputValue()
        {
            controller.Entry.Date = controller.FormatDate(calendar_DataPicker.DateTime.Date);
            controller.Entry.Context = tv_Context.Text;
            controller.Entry.LogUrl = tv_URL.Text;
            controller.Entry.MissionID = TechniqueMisssionController.ExtractID(cmb_Mission.SelectedItem);
        }

        public Validator onValidateInputValue()
        {
            Validator validator = new Validator();
            validator.NotNullFinishValidate(tv_Context.Text, builder.Context);
            return validator;
        }

        private void repo_HLE_Delete_Click(object sender, EventArgs e)
        {
            int currentLogID = gridHelper.getFocuseRowCellValue_Int(builder.ID);
            if (controller.DeleteEntryByID(currentLogID))
            {
                onRefreshLogTable();
            }
            else
                MessageBoxHelper.ShowDeleteStateDialog(false);
        }

        private void repo_HLE_Edit_Click(object sender, EventArgs e)
        {
            int currentLogID = gridHelper.getFocuseRowCellValue_Int(builder.ID);
            controller.CurrentID = currentLogID;
            controller.LoadEntry();

            tv_Context.Text = controller.Entry.Context;
            tv_URL.Text = controller.Entry.LogUrl;
            //把技术名和任务名显示到cmb控件中
            ControlAPI.SelectedComboxItemByText(this.cmb_Mission, gridHelper.getFocuseRowCellValue_String(builder.MissionName));
            ControlAPI.SelectedComboxItemByText(this.cmb_Tech, gridHelper.getFocuseRowCellValue_String(builder.TechName));
            //防止跨类别更新日志
            cmb_Mission.Enabled = false;
            cmb_Tech.Enabled = false;
        }
    }
}
