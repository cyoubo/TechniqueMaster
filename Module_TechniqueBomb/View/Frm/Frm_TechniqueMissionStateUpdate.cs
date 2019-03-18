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
using TechniqueMaster.Module_TechniqueBomb.Controller;
using PS.Plot.FrameBasic.Module_SupportLibs.DevExpressionTools;
using PS.Plot.FrameBasic.Module_System.DevExpressionTools;
using cn.bmob.io;

namespace TechniqueMaster.Module_TechniqueBomb.View.Frm
{
    public partial class Frm_TechniqueMissionStateUpdate : DevExpress.XtraEditors.XtraForm
    {
        private TechniqueMissionController controller;
        private RadioGroupHelper radioHelper;

        public Frm_TechniqueMissionStateUpdate()
        {
            InitializeComponent();
            controller = new TechniqueMissionController();
        }

        public void SetCurrentTechniqueOID(string objId)
        {
            controller.CurrentObjectID = objId;
            controller.LoadEntry();
        }

        private void Frm_TechniqueMissionStateUpdate_Load(object sender, EventArgs e)
        {
            radioHelper = new RadioGroupHelper(this.radioGroup1);
            radioHelper.FillRadioButtonByArray(TechniqueMissionController.StatesArrays());
            radioHelper.Radiogroup.SelectedIndex = controller.Entry.IsInvailDate() ? 0 : 1;

            tv_Name.Text = controller.Entry.Name;
            dateE_Finish.DateTime = controller.Entry.IsInvailDate() ? DateTime.Now.Date : DateTime.Parse(controller.Entry.FinishDate.iso).Date;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (radioHelper.Radiogroup.SelectedIndex == 0)
                controller.Entry.InvalidateFinishDate();
            else
                controller.Entry.FinishDate = dateE_Finish.DateTime.Date;

            if (controller.UpdateEntry())
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
                MessageBoxHelper.ShowUpdateStateDialog(false);
        }

    }
}