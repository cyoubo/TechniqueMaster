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

namespace TechniqueMaster.Module_Technique.View.UControl
{
    public partial class UC_TechniqueLogEdit : DevExpress.XtraEditors.XtraUserControl,IInitialUI
    {
        private TB_TechniqueLogBuilder builder;
        private TB_TechniqueLogAdapter adapter;
        private TechniqueLogController controller;
        private GridControlHelper gridHelper;

        public UC_TechniqueLogEdit()
        {
            InitializeComponent();
        }

        public void onCreateComponet()
        {
            builder = new TB_TechniqueLogBuilder();
            adapter = new TB_TechniqueLogAdapter();
            controller = new TechniqueLogController();
            gridHelper = new GridControlHelper(gridView_Misssion, gridControl_Misssion);
        }

        public void onInitialUI()
        {
            throw new NotImplementedException();
        }

        private void UC_TechniqueLogEdit_Load(object sender, EventArgs e)
        {
            onCreateComponet();
            onInitialUI();
        }

        private void cmb_Tech_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmb_Mission_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_sure_Click(object sender, EventArgs e)
        {

        }

        private void dateE_Date_EditValueChanged(object sender, EventArgs e)
        {

        }




    }
}
