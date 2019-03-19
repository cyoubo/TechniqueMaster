using OfficeAider.Module_Technique.View.Form;
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
using TechniqueMaster.Module_Technique.View.UControl;
using TechniqueMaster.Module_TechniqueBomb.BombCloud;
using TechniqueMaster.Module_TechniqueBomb.View.UControl;

namespace TechniqueMaster
{
    public partial class Frm_Main : Form, IInitialUI
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

        private void barBtn_TechniqueEvaluate_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            UC_TechniqueEvaluate uc = new UC_TechniqueEvaluate();
            tabhelper.AddorShowTabPage(barBtn_TechniqueEvaluate.Caption, uc);
        }

        private void barBtn_TechniqueCatalog_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            UC_TechniqueCatalogEdit uc = new UC_TechniqueCatalogEdit();
            tabhelper.AddorShowTabPage(barBtn_TechniqueCatalog.Caption, uc);
        }

        private void barBtn_TechniqueEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            UC_TechniqueScan uc = new UC_TechniqueScan();
            tabhelper.AddorShowTabPage(barBtn_TechniqueEdit.Caption, uc);
        }

        private void barBtn_TechniqueMission_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            UC_TechniqueMission uc = new UC_TechniqueMission();
            tabhelper.AddorShowTabPage(barBtn_TechniqueMission.Caption, uc);
        }

        private void barBtn_UC_TechniqueLogEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            UC_TechniqueLogInsert uc = new UC_TechniqueLogInsert();
            tabhelper.AddorShowTabPage(barBtn_UC_TechniqueLogEdit.Caption, uc);
        }

        private void barBtn_UC_TechniqueLogScan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            UC_TechniqueLogScan uc = new UC_TechniqueLogScan();
            tabhelper.AddorShowTabPage(barBtn_UC_TechniqueLogScan.Caption, uc);
        }

        private void barBtn_UC_TechniqueRegister_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            UC_TechniqueRegister uc = new UC_TechniqueRegister();
            tabhelper.AddorShowTabPage(barBtn_UC_TechniqueRegister.Caption, uc);
        }

        private void barBtn_UC_TechniqueRegisterEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            UC_TechniqueRegisterEdit uc = new UC_TechniqueRegisterEdit();
            tabhelper.AddorShowTabPage(barBtn_UC_TechniqueRegisterEdit.Caption, uc);
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
    }
}
