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
using PS.Plot.FrameBasic.Module_SupportLibs.DevExpressionTools;
using TechniqueMaster.Module_Technique.Controller;
using PS.Plot.FrameBasic.Module_Common.Interface;
using PS.Plot.FrameBasic.Module_Common.Component;
using PS.Plot.FrameBasic.Module_System.DevExpressionTools;
using PS.Plot.FrameBasic.Module_Common.Utils;
using TechniqueMaster.Module_Technique.Componet.Enum;

namespace TechniqueMaster.Module_Technique.View.UControl
{
    public partial class UC_TechniqueRegisterEdit : DevExpress.XtraEditors.XtraUserControl,IInitialUI,IValidateInput2
    {
        private TB_TechniqueRegisterBuilder builder;
        private TB_TechniqueRegisterAdapter adapter;
        private GridControlHelper gridHelper;
        private TechniqueRegisterController controller;

        public UC_TechniqueRegisterEdit()
        {
            InitializeComponent();
        }

        private void UC_TechniqueRegisterEdit_Load(object sender, EventArgs e)
        {
            onCreateComponet();
            onInitialUI();
        }

        public void onCreateComponet()
        {
            builder = new TB_TechniqueRegisterBuilder();
            adapter = new TB_TechniqueRegisterAdapter();
            gridHelper = new GridControlHelper(gridView1, gridControl1);
            controller = new TechniqueRegisterController();
            controller.CurrentID = 0;
            controller.LoadEntry();
        }

        public void onInitialUI()
        {
            cmb_Tech.Properties.Items.Clear();
            foreach (var item in new TechniqueController().TravleAllEntities())
                cmb_Tech.Properties.Items.Add(item);
            if (cmb_Tech.Properties.Items.Count > 0)
            {
                cmb_Tech.SelectedIndex = 0;
                onRefreshRegistTable(TechniqueController.ExtractID(cmb_Tech.SelectedItem));
            }

            onFillInputValue();
        }

        private void onRefreshRegistTable(long targetID)
        {
            if (adapter != null)
                adapter.NotifyClearTable();

            adapter.Initial(controller.QueryEntryByTechniqueID(targetID), builder);
            adapter.NotifyfreshDataTable();
            gridHelper.GridControl.DataSource = adapter.ResultTable;
        }

        private void onFillInputValue()
        {
            tv_Intro.Text = controller.Entry.Introspection;
            tv_Reason.Text = controller.Entry.Reason;
            tv_Status.Text = new EnumUtils().GetEnumdescriptionByValue(typeof(TechniqueStatusEnum), (int)controller.Entry.TechniqueStatue);
            tv_Summary.Text = controller.Entry.Summary;
            if(string.IsNullOrEmpty(controller.Entry.Date) == false)
                dateE_Date.DateTime = DateTime.Parse(controller.Entry.Date);

            btn_Sure.Enabled = false;
        }

        public void onExtractInputValue()
        {
            controller.Entry.Summary = tv_Summary.Text;
            controller.Entry.Reason = tv_Reason.Text;
            controller.Entry.Introspection = tv_Intro.Text;
            controller.Entry.Date = controller.FormatDate(dateE_Date.DateTime.Date);
        }

        public Validator onValidateInputValue()
        {
            Validator validator = new Validator();
            return validator;
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

            if (controller.UpdateEntryByID())
            {
                onRefreshRegistTable(TechniqueController.ExtractID(cmb_Tech.SelectedItem));
                controller.CurrentID = 0;
                controller.LoadEntry();
                onFillInputValue();
                MessageBoxHelper.ShowUpdateStateDialog(true);
            }
            else
                MessageBoxHelper.ShowUpdateStateDialog(false);

        }

        private void repo_HLE_Edit_Click(object sender, EventArgs e)
        {
            int currentRegistID = gridHelper.getFocuseRowCellValue_Int(builder.ID);
            controller.CurrentID = currentRegistID;
            controller.LoadEntry();
            onFillInputValue();
            btn_Sure.Enabled = true;
        }

        private void repo_HLE_Delete_Click(object sender, EventArgs e)
        {
            int currentRegistID = gridHelper.getFocuseRowCellValue_Int(builder.ID);
            if (controller.DeleteEntryByID(currentRegistID))
            {
                controller.CurrentID = 0;
                controller.LoadEntry();
                onInitialUI();
                MessageBoxHelper.ShowDeleteStateDialog(true);
            }
            else
                MessageBoxHelper.ShowDeleteStateDialog(false);
        }
    }
}
