using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using PS.Plot.FrameBasic.Module_Common.Interface;
using TechniqueMaster.Module_Technique.Controller;
using PS.Plot.FrameBasic.Module_Common.Component;
using PS.Plot.FrameBasic.Module_System.DevExpressionTools;

namespace TechniqueMaster.Module_Technique.View.Frm
{
    public partial class Frm_TechniqueLogEdit : DevExpress.XtraEditors.XtraForm,IInitialUI,IValidateInput2
    {
        public int LogID { get; set; }

        private TechniqueLogController controller;

        public Frm_TechniqueLogEdit()
        {
            InitializeComponent();
        }

        private void Frm_TechniqueLogEdit_Load(object sender, EventArgs e)
        {
            onCreateComponet();
            onInitialUI();
        }

        public void onCreateComponet()
        {
            controller = new Controller.TechniqueLogController();
            controller.CurrentID = LogID;
            controller.LoadEntry();
        }

        public void onInitialUI()
        {
            tv_Context.Text = controller.Entry.Context;
            tv_MissionName.Text = new TechniqueMisssionController().QueryEntryByID((int)controller.Entry.MissionID).Name;
            tv_URL.Text = controller.Entry.LogUrl;
            dateE_Date.DateTime = DateTime.Parse(controller.Entry.Date);

            tv_Context.Properties.ReadOnly = IsReadOnly;
            tv_MissionName.Properties.ReadOnly = IsReadOnly;
            tv_URL.Properties.ReadOnly = IsReadOnly;
            dateE_Date.ReadOnly = IsReadOnly;
        }

        public void onExtractInputValue()
        {
            controller.Entry.Date = controller.FormatDate(dateE_Date.DateTime.Date);
            controller.Entry.Context = tv_Context.Text;
            controller.Entry.LogUrl = tv_URL.Text;
        }

        public Validator onValidateInputValue()
        {
            Validator validator = new Validator();
            validator.NotNullFinishValidate(tv_Context.Text, "日志内容");
            return validator;
        }

        private void btn_sure_Click(object sender, EventArgs e)
        {
            Validator validtor = onValidateInputValue();
            if (validtor.IsValidate == false)
            {
                MessageBoxHelper.ShowInputErrorDialog(validtor.ErrorMessage);
                return;
            }

            onExtractInputValue();

            if (controller.UpdateEntryByID())
            {
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                Close();
            }
            else
                MessageBoxHelper.ShowUpdateStateDialog(false);
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (controller.DeleteEntry())
            {
                MessageBoxHelper.ShowDeleteStateDialog(true);
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                Close();
            }
            else
                MessageBoxHelper.ShowDeleteStateDialog(false);

        }

        public bool IsReadOnly { get; set; }
    }
}