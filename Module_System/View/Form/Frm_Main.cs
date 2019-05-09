using DevExpress.XtraBars.Ribbon;
using PS.Plot.FrameBasic.Module_Common.Interface;
using PS.Plot.FrameBasic.Module_SupportLibs.DevExpressionTools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TechniqueMaster.Module_TechniqueBomb.BombCloud;
using TechniqueMaster.Module_TechniqueBomb.TestCast;
using TechniqueMaster.Module_TechniqueBomb.View.UControl;

namespace TechniqueMaster
{
    public partial class Frm_Main : RibbonForm, IInitialUI
    {
        private TabControlHelper tabhelper;
        
        public Frm_Main()
        {
            InitializeComponent();
        }

        private void Frm_Main_Load(object sender, EventArgs e)
        {
            onCreateComponet();
            onInitialUI();
        }

        public void onCreateComponet()
        {
            tabhelper = new TabControlHelper(tab_Control);
            tabhelper.RegistCloseEventListener();

            BmobIntance.Create().InitialBomb();
        }

        public void onInitialUI()
        {
            this.Text = "技能学习助手";
            this.ShowIcon = false;
            tabhelper.ClearTabPage();
        }

        private void barBtn_UC_TechniqueLog_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            UC_TechniqueLogEdit uc = new UC_TechniqueLogEdit();
            tabhelper.AddorShowTabPage(barBtn_UC_TechniqueLog.Caption, uc);
        }

        private void barBtn_UC_TechniqueCategoryEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            UC_TechniqueCategoryEdit uc = new UC_TechniqueCategoryEdit();
            tabhelper.AddorShowTabPage(barBtn_UC_TechniqueCategoryEdit.Caption, uc);
        }

        private void barBtn_UC_TechniqueEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            UC_TechniqueEdit uc = new UC_TechniqueEdit();
            tabhelper.AddorShowTabPage(barBtn_UC_TechniqueEdit.Caption, uc);
        }

        private void barBtn_UC_TechniqueMissionEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            UC_TechniqueMissionEdit uc = new UC_TechniqueMissionEdit();
            tabhelper.AddorShowTabPage(barBtn_UC_TechniqueMissionEdit.Caption, uc);
        }

        private void barBtn_UC_TechniqueLogManage_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            UC_TechniqueLogManage uc = new UC_TechniqueLogManage();
            tabhelper.AddorShowTabPage(barBtn_UC_TechniqueLogManage.Caption, uc);
        }

        private void barBtn_UC_ProblemSetsEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            UC_ProblemSetsEdit uc = new UC_ProblemSetsEdit();
            tabhelper.AddorShowTabPage(barBtn_UC_ProblemSetsEdit.Caption, uc);
        }

        private void btn_UC_TestLogAsyn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            UC_TestLogAsyn uc = new UC_TestLogAsyn();
            tabhelper.AddorShowTabPage(btn_UC_TestLogAsyn.Caption, uc);
        }

        private void barBtn_UC_TechniqueReviewEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            UC_TechniqueReviewEdit uc = new UC_TechniqueReviewEdit();
            tabhelper.AddorShowTabPage(barBtn_UC_TechniqueReviewEdit.Caption, uc);
        }

        private void barBtn_UC_TechniqueReviewInvertedEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            UC_TechniqueReviewInvertedEdit uc = new UC_TechniqueReviewInvertedEdit();
            tabhelper.AddorShowTabPage(e.Item.Caption, uc);
        }
    }
}
