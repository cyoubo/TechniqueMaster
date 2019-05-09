namespace TechniqueMaster
{
    partial class Frm_Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Main));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barBtn_UC_TechniqueLog = new DevExpress.XtraBars.BarButtonItem();
            this.barBtn_UC_TechniqueCategoryEdit = new DevExpress.XtraBars.BarButtonItem();
            this.barBtn_UC_TechniqueEdit = new DevExpress.XtraBars.BarButtonItem();
            this.barBtn_UC_TechniqueMissionEdit = new DevExpress.XtraBars.BarButtonItem();
            this.barBtn_UC_TechniqueLogManage = new DevExpress.XtraBars.BarButtonItem();
            this.barBtn_UC_ProblemSetsEdit = new DevExpress.XtraBars.BarButtonItem();
            this.btn_UC_TestLogAsyn = new DevExpress.XtraBars.BarButtonItem();
            this.barBtn_UC_TechniqueReviewEdit = new DevExpress.XtraBars.BarButtonItem();
            this.barBtn_UC_TechniqueReviewInvertedEdit = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.tab_Control = new DevExpress.XtraTab.XtraTabControl();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tab_Control)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.barBtn_UC_TechniqueLog,
            this.barBtn_UC_TechniqueCategoryEdit,
            this.barBtn_UC_TechniqueEdit,
            this.barBtn_UC_TechniqueMissionEdit,
            this.barBtn_UC_TechniqueLogManage,
            this.barBtn_UC_ProblemSetsEdit,
            this.btn_UC_TestLogAsyn,
            this.barBtn_UC_TechniqueReviewEdit,
            this.barBtn_UC_TechniqueReviewInvertedEdit});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 18;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage2,
            this.ribbonPage1});
            this.ribbonControl1.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.ShowQatLocationSelector = false;
            this.ribbonControl1.ShowToolbarCustomizeItem = false;
            this.ribbonControl1.Size = new System.Drawing.Size(800, 147);
            this.ribbonControl1.Toolbar.ShowCustomizeItem = false;
            this.ribbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // barBtn_UC_TechniqueLog
            // 
            this.barBtn_UC_TechniqueLog.Caption = "日志登记";
            this.barBtn_UC_TechniqueLog.Glyph = ((System.Drawing.Image)(resources.GetObject("barBtn_UC_TechniqueLog.Glyph")));
            this.barBtn_UC_TechniqueLog.Id = 9;
            this.barBtn_UC_TechniqueLog.Name = "barBtn_UC_TechniqueLog";
            this.barBtn_UC_TechniqueLog.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barBtn_UC_TechniqueLog.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtn_UC_TechniqueLog_ItemClick);
            // 
            // barBtn_UC_TechniqueCategoryEdit
            // 
            this.barBtn_UC_TechniqueCategoryEdit.Caption = "技能类别管理";
            this.barBtn_UC_TechniqueCategoryEdit.Glyph = ((System.Drawing.Image)(resources.GetObject("barBtn_UC_TechniqueCategoryEdit.Glyph")));
            this.barBtn_UC_TechniqueCategoryEdit.Id = 10;
            this.barBtn_UC_TechniqueCategoryEdit.Name = "barBtn_UC_TechniqueCategoryEdit";
            this.barBtn_UC_TechniqueCategoryEdit.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barBtn_UC_TechniqueCategoryEdit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtn_UC_TechniqueCategoryEdit_ItemClick);
            // 
            // barBtn_UC_TechniqueEdit
            // 
            this.barBtn_UC_TechniqueEdit.Caption = "技能登记";
            this.barBtn_UC_TechniqueEdit.Glyph = ((System.Drawing.Image)(resources.GetObject("barBtn_UC_TechniqueEdit.Glyph")));
            this.barBtn_UC_TechniqueEdit.Id = 11;
            this.barBtn_UC_TechniqueEdit.Name = "barBtn_UC_TechniqueEdit";
            this.barBtn_UC_TechniqueEdit.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barBtn_UC_TechniqueEdit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtn_UC_TechniqueEdit_ItemClick);
            // 
            // barBtn_UC_TechniqueMissionEdit
            // 
            this.barBtn_UC_TechniqueMissionEdit.Caption = "任务登记";
            this.barBtn_UC_TechniqueMissionEdit.Glyph = ((System.Drawing.Image)(resources.GetObject("barBtn_UC_TechniqueMissionEdit.Glyph")));
            this.barBtn_UC_TechniqueMissionEdit.Id = 12;
            this.barBtn_UC_TechniqueMissionEdit.Name = "barBtn_UC_TechniqueMissionEdit";
            this.barBtn_UC_TechniqueMissionEdit.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barBtn_UC_TechniqueMissionEdit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtn_UC_TechniqueMissionEdit_ItemClick);
            // 
            // barBtn_UC_TechniqueLogManage
            // 
            this.barBtn_UC_TechniqueLogManage.Caption = "日志管理";
            this.barBtn_UC_TechniqueLogManage.Glyph = ((System.Drawing.Image)(resources.GetObject("barBtn_UC_TechniqueLogManage.Glyph")));
            this.barBtn_UC_TechniqueLogManage.Id = 13;
            this.barBtn_UC_TechniqueLogManage.Name = "barBtn_UC_TechniqueLogManage";
            this.barBtn_UC_TechniqueLogManage.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barBtn_UC_TechniqueLogManage.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtn_UC_TechniqueLogManage_ItemClick);
            // 
            // barBtn_UC_ProblemSetsEdit
            // 
            this.barBtn_UC_ProblemSetsEdit.Caption = "问题集锦";
            this.barBtn_UC_ProblemSetsEdit.Glyph = ((System.Drawing.Image)(resources.GetObject("barBtn_UC_ProblemSetsEdit.Glyph")));
            this.barBtn_UC_ProblemSetsEdit.Id = 14;
            this.barBtn_UC_ProblemSetsEdit.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barBtn_UC_ProblemSetsEdit.LargeGlyph")));
            this.barBtn_UC_ProblemSetsEdit.Name = "barBtn_UC_ProblemSetsEdit";
            this.barBtn_UC_ProblemSetsEdit.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barBtn_UC_ProblemSetsEdit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtn_UC_ProblemSetsEdit_ItemClick);
            // 
            // btn_UC_TestLogAsyn
            // 
            this.btn_UC_TestLogAsyn.Caption = "异步话测试";
            this.btn_UC_TestLogAsyn.Id = 15;
            this.btn_UC_TestLogAsyn.Name = "btn_UC_TestLogAsyn";
            this.btn_UC_TestLogAsyn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_UC_TestLogAsyn_ItemClick);
            // 
            // barBtn_UC_TechniqueReviewEdit
            // 
            this.barBtn_UC_TechniqueReviewEdit.Caption = "分类回顾";
            this.barBtn_UC_TechniqueReviewEdit.Glyph = ((System.Drawing.Image)(resources.GetObject("barBtn_UC_TechniqueReviewEdit.Glyph")));
            this.barBtn_UC_TechniqueReviewEdit.Id = 16;
            this.barBtn_UC_TechniqueReviewEdit.Name = "barBtn_UC_TechniqueReviewEdit";
            this.barBtn_UC_TechniqueReviewEdit.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barBtn_UC_TechniqueReviewEdit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtn_UC_TechniqueReviewEdit_ItemClick);
            // 
            // barBtn_UC_TechniqueReviewInvertedEdit
            // 
            this.barBtn_UC_TechniqueReviewInvertedEdit.Caption = "倒序回顾";
            this.barBtn_UC_TechniqueReviewInvertedEdit.Glyph = ((System.Drawing.Image)(resources.GetObject("barBtn_UC_TechniqueReviewInvertedEdit.Glyph")));
            this.barBtn_UC_TechniqueReviewInvertedEdit.Id = 17;
            this.barBtn_UC_TechniqueReviewInvertedEdit.Name = "barBtn_UC_TechniqueReviewInvertedEdit";
            this.barBtn_UC_TechniqueReviewInvertedEdit.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barBtn_UC_TechniqueReviewInvertedEdit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtn_UC_TechniqueReviewInvertedEdit_ItemClick);
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3,
            this.ribbonPageGroup1,
            this.ribbonPageGroup4});
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "技能管理Bomb版";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.barBtn_UC_TechniqueLog);
            this.ribbonPageGroup3.ItemLinks.Add(this.barBtn_UC_TechniqueLogManage);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "技能登记";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.barBtn_UC_TechniqueReviewEdit);
            this.ribbonPageGroup1.ItemLinks.Add(this.barBtn_UC_TechniqueReviewInvertedEdit);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "日志回顾";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.barBtn_UC_TechniqueCategoryEdit);
            this.ribbonPageGroup4.ItemLinks.Add(this.barBtn_UC_TechniqueEdit);
            this.ribbonPageGroup4.ItemLinks.Add(this.barBtn_UC_TechniqueMissionEdit);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "技能管理";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup5,
            this.ribbonPageGroup6});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "测试功能";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.barBtn_UC_ProblemSetsEdit);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            this.ribbonPageGroup5.Text = "网络笔记";
            // 
            // ribbonPageGroup6
            // 
            this.ribbonPageGroup6.ItemLinks.Add(this.btn_UC_TestLogAsyn);
            this.ribbonPageGroup6.Name = "ribbonPageGroup6";
            this.ribbonPageGroup6.Text = "ribbonPageGroup6";
            // 
            // tab_Control
            // 
            this.tab_Control.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tab_Control.HeaderLocation = DevExpress.XtraTab.TabHeaderLocation.Bottom;
            this.tab_Control.Location = new System.Drawing.Point(0, 147);
            this.tab_Control.Name = "tab_Control";
            this.tab_Control.Size = new System.Drawing.Size(800, 260);
            this.tab_Control.TabIndex = 1;
            // 
            // Frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 407);
            this.Controls.Add(this.tab_Control);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "Frm_Main";
            this.Ribbon = this.ribbonControl1;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "技能学习助手";
            this.Load += new System.EventHandler(this.Frm_Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tab_Control)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraTab.XtraTabControl tab_Control;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.BarButtonItem barBtn_UC_TechniqueLog;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem barBtn_UC_TechniqueCategoryEdit;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.BarButtonItem barBtn_UC_TechniqueEdit;
        private DevExpress.XtraBars.BarButtonItem barBtn_UC_TechniqueMissionEdit;
        private DevExpress.XtraBars.BarButtonItem barBtn_UC_TechniqueLogManage;
        private DevExpress.XtraBars.BarButtonItem barBtn_UC_ProblemSetsEdit;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.BarButtonItem btn_UC_TestLogAsyn;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
        private DevExpress.XtraBars.BarButtonItem barBtn_UC_TechniqueReviewEdit;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.BarButtonItem barBtn_UC_TechniqueReviewInvertedEdit;
    }
}

