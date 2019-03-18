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
using TechniqueMaster.Module_TechniqueBomb.Controller;
using PS.Plot.FrameBasic.Module_Common.Interface;
using PS.Plot.FrameBasic.Module_SupportLibs.DevExpressionTools;
using PS.Plot.FrameBasic.Module_Common.Component;
using PS.Plot.FrameBasic.Module_System.DevExpressionTools;
using TechniqueMaster.Module_TechniqueBomb.Componet.Adapter;
using TechniqueMaster.Module_TechniqueBomb.View.Frm;

namespace TechniqueMaster.Module_TechniqueBomb.View.UControl
{
    public partial class UC_TechniqueMissionEdit : DevExpress.XtraEditors.XtraUserControl,IInitialUI,IValidateInput2
    {
        private TechniqueMissionController controller;
        private GridControlHelper gridHelper;
        private TB_TechniqueMissionBuilder builder;
        private TB_TechniqueMissionAdapter adapter;
        
        
        public UC_TechniqueMissionEdit()
        {
            InitializeComponent();
        }

        private void UC_TechniqueMissionEdit_Load(object sender, EventArgs e)
        {
            onCreateComponet();
            onInitialUI();
        }

        public void onCreateComponet()
        {
            controller = new TechniqueMissionController();
            gridHelper = new GridControlHelper(this.gridView1, this.gridControl1);
            controller.LoadEntry();

            builder = new TB_TechniqueMissionBuilder();
            adapter = new TB_TechniqueMissionAdapter();
            adapter.Initial(builder);
        }

        public void onInitialUI()
        {
            this.cmb_Technique.Properties.Items.Clear();
            foreach (var item in new TechniqueController().Travels())
                this.cmb_Technique.Properties.Items.Add(item.ConvertToComboxItem());
            if (cmb_Technique.Properties.Items.Count > 0)
                cmb_Technique.SelectedIndex = 0;

            tv_Name.Text = "";
            tv_Description.Text = "";
            dateE_Create.DateTime = DateTime.Now.Date;

            adapter.NotifyfreshDataTable(controller.Travels());
            gridHelper.GridControl.DataSource = adapter.ResultTable;

            gridHelper.SetAllColumnEditable(false);
            gridHelper.SetColunmOption(builder.ObjectID, false, false);
            gridHelper.SetColunmOption(builder.TechniqueID, false, false);
            gridHelper.SetColMaxWidth(builder.Op_Delete, 80);
            gridHelper.SetColMaxWidth(builder.Op_Edit, 80);
            gridHelper.SetColMaxWidth(builder.Op_UpdateState, 120);
            gridHelper.SetColMaxWidth(builder.CreateDate, 120);
            gridHelper.SetColMaxWidth(builder.FinishDate, 120);

            gridHelper.Group(builder.TechinqueName);
            gridHelper.GridView.GroupFormat = "{1}";
            gridHelper.GridView.ExpandAllGroups();

            gridHelper.SetCellResposity(builder.Op_UpdateState, repo_HLE_UpdateState);
        }

        public void onExtractInputValue()
        {
            controller.Entry.Name = tv_Name.Text;
            controller.Entry.Description = tv_Description.Text;
            controller.Entry.CreateDate = dateE_Create.DateTime.Date;
            controller.Entry.TechniqueID = (cmb_Technique.SelectedItem as ComboxItem).Tag;
        }

        public Validator onValidateInputValue()
        {
            Validator validator = new Validator();
            validator.NotNullFinishValidate(tv_Name.Text, "任务名称");
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

            if (string.IsNullOrEmpty(controller.CurrentObjectID))
            {
                if (controller.InsertEntry())
                {
                    this.onInitialUI();
                    this.controller.ReleaseEntry();
                }
                else
                    MessageBoxHelper.ShowSaveStateDialog(false);
            }
            else
            {
                if (controller.UpdateEntry())
                {
                    this.onInitialUI();
                    this.controller.ReleaseEntry();
                }
                else
                    MessageBoxHelper.ShowUpdateStateDialog(false);
            }

        }

        private void repo_HLE_Delete_Click(object sender, EventArgs e)
        {
            string currentID = gridHelper.getFocuseRowCellValue_String(builder.ObjectID);
            if (controller.ExistSubLog(currentID))
            {
                MessageBoxHelper.ShowErrorDialog("请删除下属任务日志后重试");
                return;
            }

            if (controller.DeleteByObjectID(currentID))
            {
                this.onInitialUI();
                this.controller.ReleaseEntry();
            }
            else
                MessageBoxHelper.ShowDeleteStateDialog(false);
        }

        private void repo_HLE_Edit_Click(object sender, EventArgs e)
        {

        }

        private void repo_HLE_UpdateState_Click(object sender, EventArgs e)
        {
            Frm_TechniqueMissionStateUpdate frm = new Frm_TechniqueMissionStateUpdate();
            frm.SetCurrentTechniqueOID(gridHelper.getFocuseRowCellValue_String(builder.ObjectID));
            if (frm.ShowDialog() == DialogResult.OK)
            {
                this.onInitialUI();
            }
        }
    }
}
