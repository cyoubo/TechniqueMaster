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
using TechniqueMaster.Module_Technique.Componet.Adapter;
using TechniqueMaster.Module_Technique.Controller;
using PS.Plot.FrameBasic.Module_Common.Interface;
using PS.Plot.FrameBasic.Module_SupportLibs.DevExpressionTools;
using TechniqueMaster.Module_Technique.Componet.Enum;
using PS.Plot.FrameBasic.Module_Common.Component;
using PS.Plot.FrameBasic.Module_System.DevExpressionTools;
using PS.Plot.FrameBasic.Module_Common.Utils;

namespace TechniqueMaster.Module_Technique.View.UControl
{
    public partial class UC_TechniqueMission : DevExpress.XtraEditors.XtraUserControl,IInitialUI,IValidateInput2
    {
        private TB_TechniqueMissionBuilder builder;
        private TB_TechniqueMissionAdapter adapter;
        private TechniqueMisssionController controller;
        private GridControlHelper gridHelper;
        private RadioGroupHelper rgHelper;

        public UC_TechniqueMission()
        {
            InitializeComponent();
        }

        private void UC_TechniqueMission_Load(object sender, EventArgs e)
        {
            onCreateComponet();
            onInitialUI();
        }

        public void onCreateComponet()
        {
            builder = new TB_TechniqueMissionBuilder();
            adapter = new TB_TechniqueMissionAdapter();
            controller = new TechniqueMisssionController();
            gridHelper = new GridControlHelper(this.gridView_Mission,gridControl_Mission);
            rgHelper = new RadioGroupHelper(this.rg_Status);
        }

        public void onInitialUI()
        {
            cmb_Tech.Properties.Items.Clear();
            foreach (var item in new TechniqueController().TravleAllEntities())
                cmb_Tech.Properties.Items.Add(item);
            if (cmb_Tech.Properties.Items.Count > 0)
                cmb_Tech.SelectedIndex = 0;

            onFillMissionTableGrid();
            onFillInputValue();
            onSetInputEnable(false);
        }

        private void onFillMissionTableGrid()
        {
            if (adapter != null)
                adapter.NotifyClearTable();

            if (cmb_Tech.SelectedIndex != -1)
                adapter.Initial(controller.QueryEntriesByTechniquID(TechniqueController.ExtractID(cmb_Tech.SelectedItem)), builder);
            else
                adapter.Initial(builder);

            adapter.NotifyfreshDataTable();
            gridHelper.GridControl.DataSource = adapter.ResultTable;
            gridHelper.SetAllColumnEditable(false);
            gridHelper.SetAllColumnVisible(false);

            gridHelper.SetColunmOption(builder.Op_Delete, true, true);
            gridHelper.SetColunmOption(builder.Op_Edit, true, true);
            gridHelper.SetColunmOption(builder.Name, false, true);
            gridHelper.SetCellResposity(builder.Op_Delete, repo_HLE_Delete);
            gridHelper.SetCellResposity(builder.Op_Edit, repo_HLE_Edit);
            gridHelper.SetColMaxWidth(builder.Op_Delete, 40);
            gridHelper.SetColMaxWidth(builder.Op_Edit, 40);
        }

        private void onFillInputValue()
        {
            if (controller.CurrentID == 0)
            {
                tv_Discr.Text = "";
                tv_Name.Text = "";
                DateE_CreateDate.DateTime = DateTime.Now.Date;
                dateE_Finish.Text = "";
                rgHelper.FillRadioButtonByEnum(MissionStatusEnum.Create);
            }
            else
            {
                tv_Discr.Text = controller.Entry.Description;
                tv_Name.Text = controller.Entry.Name;
                DateE_CreateDate.DateTime = DateTime.Parse(controller.Entry.CreateDate);
                if (string.IsNullOrEmpty(controller.Entry.FinishDate) == false)
                    dateE_Finish.DateTime = DateTime.Parse(controller.Entry.FinishDate);
                else
                    dateE_Finish.Text = "";

                rgHelper.FillRadioButtonByEnum(MissionStatusEnum.Create);
                rgHelper.SelectItemByEnumDescription(controller.Entry.Status);
            }
        }

        public void onExtractInputValue()
        {
            controller.Entry.CreateDate = controller.FormatDate(DateE_CreateDate.DateTime.Date);
            controller.Entry.Name = tv_Name.Text;
            controller.Entry.Description = tv_Discr.Text;
            controller.Entry.Status = rgHelper.GetSelectItemDescription();
            controller.Entry.TechniqueID = TechniqueController.ExtractID(cmb_Tech.SelectedItem);
            if (string.IsNullOrEmpty(dateE_Finish.Text) == false)
                controller.Entry.FinishDate = controller.FormatDate(dateE_Finish.DateTime.Date);
        }

        public Validator onValidateInputValue()
        {
            Validator validator = new Validator();
            validator.NotNullFinishValidate(tv_Name.Text, builder.Name);
            validator.NotNullFinishValidate(DateE_CreateDate.Text, builder.CreateDate);
            if (rgHelper.GetSelectItemAsEnum<MissionStatusEnum>() == MissionStatusEnum.Finish)
                validator.NotNullFinishValidate(dateE_Finish.Text, builder.FinishDate);
            return validator;
        }

        public void onSetInputEnable(bool isEnable)
        {
            tv_Discr.Enabled = isEnable;
            dateE_Finish.Enabled = isEnable;
            DateE_CreateDate.Enabled = isEnable;
            tv_Name.Enabled = isEnable;
            rg_Status.Enabled = isEnable;
            btn_Sure.Enabled = isEnable;
        }

        private void btn_NewMission_Click(object sender, EventArgs e)
        {
            controller.CurrentID = 0;
            controller.LoadEntry();
            onFillInputValue();
            onSetInputEnable(true);
        }

        private void btn_Sure_Click(object sender, EventArgs e)
        {
            Validator validator = onValidateInputValue();
            if (validator.IsValidate == false)
            {
                MessageBoxHelper.ShowInputErrorDialog(validator.ErrorMessage);
                return;
            }

            onExtractInputValue();

            if (controller.CurrentID == 0)
                MessageBoxHelper.ShowCreateStateDialog(controller.InsertEntry());
            else
                MessageBoxHelper.ShowUpdateStateDialog(controller.UpdateEntryByID());

            controller.CurrentID = 0;
            controller.LoadEntry();

            onFillMissionTableGrid();
            onFillInputValue();
            onSetInputEnable(false);
        }

        private void repo_HLE_Delete_Click(object sender, EventArgs e)
        {
            int currentMissionID = gridHelper.getFocuseRowCellValue_Int(builder.ID);
            //先判断是否有下属的日志

            //执行删除操作
            if (controller.DeleteEntryByID(currentMissionID))
            {
                MessageBoxHelper.ShowDeleteStateDialog(true);
                controller.CurrentID = 0;
                controller.LoadEntry();
                onFillInputValue();
                onFillMissionTableGrid();
            }
            else
                MessageBoxHelper.ShowDeleteStateDialog(false);
        }

        private void repo_HLE_Edit_Click(object sender, EventArgs e)
        {
            controller.CurrentID = gridHelper.getFocuseRowCellValue_Int(builder.ID);
            controller.LoadEntry();
            onFillInputValue();
            onSetInputEnable(true);
        }

        private void cmb_Tech_SelectedIndexChanged(object sender, EventArgs e)
        {
            onFillMissionTableGrid();
        }
    }
}
