﻿namespace TechniqueMaster
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
            this.barBtn_TechniqueEvaluate = new DevExpress.XtraBars.BarButtonItem();
            this.barBtn_TechniqueCatalog = new DevExpress.XtraBars.BarButtonItem();
            this.barBtn_TechniqueEdit = new DevExpress.XtraBars.BarButtonItem();
            this.barBtn_TechniqueMission = new DevExpress.XtraBars.BarButtonItem();
            this.barBtn_UC_TechniqueLogEdit = new DevExpress.XtraBars.BarButtonItem();
            this.barBtn_UC_TechniqueLogScan = new DevExpress.XtraBars.BarButtonItem();
            this.barBtn_UC_TechniqueRegister = new DevExpress.XtraBars.BarButtonItem();
            this.barBtn_UC_TechniqueRegisterEdit = new DevExpress.XtraBars.BarButtonItem();
            this.barBtn_UC_TechniqueLog = new DevExpress.XtraBars.BarButtonItem();
            this.barBtn_UC_TechniqueCategoryEdit = new DevExpress.XtraBars.BarButtonItem();
            this.barBtn_UC_TechniqueEdit = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.tab_Control = new DevExpress.XtraTab.XtraTabControl();
            this.barBtn_UC_TechniqueMissionEdit = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tab_Control)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.barBtn_TechniqueEvaluate,
            this.barBtn_TechniqueCatalog,
            this.barBtn_TechniqueEdit,
            this.barBtn_TechniqueMission,
            this.barBtn_UC_TechniqueLogEdit,
            this.barBtn_UC_TechniqueLogScan,
            this.barBtn_UC_TechniqueRegister,
            this.barBtn_UC_TechniqueRegisterEdit,
            this.barBtn_UC_TechniqueLog,
            this.barBtn_UC_TechniqueCategoryEdit,
            this.barBtn_UC_TechniqueEdit,
            this.barBtn_UC_TechniqueMissionEdit});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.Margin = new System.Windows.Forms.Padding(4);
            this.ribbonControl1.MaxItemId = 13;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPage2});
            this.ribbonControl1.ShowQatLocationSelector = false;
            this.ribbonControl1.Size = new System.Drawing.Size(1029, 184);
            this.ribbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // barBtn_TechniqueEvaluate
            // 
            this.barBtn_TechniqueEvaluate.Caption = "评估登记";
            this.barBtn_TechniqueEvaluate.Glyph = ((System.Drawing.Image)(resources.GetObject("barBtn_TechniqueEvaluate.Glyph")));
            this.barBtn_TechniqueEvaluate.Id = 1;
            this.barBtn_TechniqueEvaluate.Name = "barBtn_TechniqueEvaluate";
            this.barBtn_TechniqueEvaluate.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barBtn_TechniqueEvaluate.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtn_TechniqueEvaluate_ItemClick);
            // 
            // barBtn_TechniqueCatalog
            // 
            this.barBtn_TechniqueCatalog.Caption = "技能类别";
            this.barBtn_TechniqueCatalog.Glyph = ((System.Drawing.Image)(resources.GetObject("barBtn_TechniqueCatalog.Glyph")));
            this.barBtn_TechniqueCatalog.Id = 2;
            this.barBtn_TechniqueCatalog.Name = "barBtn_TechniqueCatalog";
            this.barBtn_TechniqueCatalog.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            this.barBtn_TechniqueCatalog.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtn_TechniqueCatalog_ItemClick);
            // 
            // barBtn_TechniqueEdit
            // 
            this.barBtn_TechniqueEdit.Caption = "技能浏览";
            this.barBtn_TechniqueEdit.Glyph = ((System.Drawing.Image)(resources.GetObject("barBtn_TechniqueEdit.Glyph")));
            this.barBtn_TechniqueEdit.Id = 3;
            this.barBtn_TechniqueEdit.Name = "barBtn_TechniqueEdit";
            this.barBtn_TechniqueEdit.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barBtn_TechniqueEdit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtn_TechniqueEdit_ItemClick);
            // 
            // barBtn_TechniqueMission
            // 
            this.barBtn_TechniqueMission.Caption = "任务管理";
            this.barBtn_TechniqueMission.Glyph = ((System.Drawing.Image)(resources.GetObject("barBtn_TechniqueMission.Glyph")));
            this.barBtn_TechniqueMission.Id = 4;
            this.barBtn_TechniqueMission.Name = "barBtn_TechniqueMission";
            this.barBtn_TechniqueMission.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barBtn_TechniqueMission.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtn_TechniqueMission_ItemClick);
            // 
            // barBtn_UC_TechniqueLogEdit
            // 
            this.barBtn_UC_TechniqueLogEdit.Caption = "日志登记";
            this.barBtn_UC_TechniqueLogEdit.Glyph = ((System.Drawing.Image)(resources.GetObject("barBtn_UC_TechniqueLogEdit.Glyph")));
            this.barBtn_UC_TechniqueLogEdit.Id = 5;
            this.barBtn_UC_TechniqueLogEdit.Name = "barBtn_UC_TechniqueLogEdit";
            this.barBtn_UC_TechniqueLogEdit.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barBtn_UC_TechniqueLogEdit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtn_UC_TechniqueLogEdit_ItemClick);
            // 
            // barBtn_UC_TechniqueLogScan
            // 
            this.barBtn_UC_TechniqueLogScan.Caption = "日志浏览";
            this.barBtn_UC_TechniqueLogScan.Glyph = ((System.Drawing.Image)(resources.GetObject("barBtn_UC_TechniqueLogScan.Glyph")));
            this.barBtn_UC_TechniqueLogScan.Id = 6;
            this.barBtn_UC_TechniqueLogScan.Name = "barBtn_UC_TechniqueLogScan";
            this.barBtn_UC_TechniqueLogScan.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barBtn_UC_TechniqueLogScan.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtn_UC_TechniqueLogScan_ItemClick);
            // 
            // barBtn_UC_TechniqueRegister
            // 
            this.barBtn_UC_TechniqueRegister.Caption = "技能状态更新";
            this.barBtn_UC_TechniqueRegister.Glyph = ((System.Drawing.Image)(resources.GetObject("barBtn_UC_TechniqueRegister.Glyph")));
            this.barBtn_UC_TechniqueRegister.Id = 7;
            this.barBtn_UC_TechniqueRegister.Name = "barBtn_UC_TechniqueRegister";
            this.barBtn_UC_TechniqueRegister.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtn_UC_TechniqueRegister_ItemClick);
            // 
            // barBtn_UC_TechniqueRegisterEdit
            // 
            this.barBtn_UC_TechniqueRegisterEdit.Caption = "技能状态编辑";
            this.barBtn_UC_TechniqueRegisterEdit.Glyph = ((System.Drawing.Image)(resources.GetObject("barBtn_UC_TechniqueRegisterEdit.Glyph")));
            this.barBtn_UC_TechniqueRegisterEdit.Id = 8;
            this.barBtn_UC_TechniqueRegisterEdit.Name = "barBtn_UC_TechniqueRegisterEdit";
            this.barBtn_UC_TechniqueRegisterEdit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtn_UC_TechniqueRegisterEdit_ItemClick);
            // 
            // barBtn_UC_TechniqueLog
            // 
            this.barBtn_UC_TechniqueLog.Caption = "日常登记";
            this.barBtn_UC_TechniqueLog.Id = 9;
            this.barBtn_UC_TechniqueLog.Name = "barBtn_UC_TechniqueLog";
            this.barBtn_UC_TechniqueLog.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtn_UC_TechniqueLog_ItemClick);
            // 
            // barBtn_UC_TechniqueCategoryEdit
            // 
            this.barBtn_UC_TechniqueCategoryEdit.Caption = "技能类别管理";
            this.barBtn_UC_TechniqueCategoryEdit.Id = 10;
            this.barBtn_UC_TechniqueCategoryEdit.Name = "barBtn_UC_TechniqueCategoryEdit";
            this.barBtn_UC_TechniqueCategoryEdit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtn_UC_TechniqueCategoryEdit_ItemClick);
            // 
            // barBtn_UC_TechniqueEdit
            // 
            this.barBtn_UC_TechniqueEdit.Caption = "技能登记";
            this.barBtn_UC_TechniqueEdit.Id = 11;
            this.barBtn_UC_TechniqueEdit.Name = "barBtn_UC_TechniqueEdit";
            this.barBtn_UC_TechniqueEdit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtn_UC_TechniqueEdit_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "技能管理";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.barBtn_TechniqueEvaluate);
            this.ribbonPageGroup1.ItemLinks.Add(this.barBtn_TechniqueEdit);
            this.ribbonPageGroup1.ItemLinks.Add(this.barBtn_TechniqueCatalog);
            this.ribbonPageGroup1.ItemLinks.Add(this.barBtn_UC_TechniqueRegister);
            this.ribbonPageGroup1.ItemLinks.Add(this.barBtn_UC_TechniqueRegisterEdit);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "技能管理";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.barBtn_TechniqueMission);
            this.ribbonPageGroup2.ItemLinks.Add(this.barBtn_UC_TechniqueLogEdit);
            this.ribbonPageGroup2.ItemLinks.Add(this.barBtn_UC_TechniqueLogScan);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "技能任务";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup4,
            this.ribbonPageGroup3});
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "技能管理Bomb版";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.barBtn_UC_TechniqueCategoryEdit);
            this.ribbonPageGroup4.ItemLinks.Add(this.barBtn_UC_TechniqueEdit);
            this.ribbonPageGroup4.ItemLinks.Add(this.barBtn_UC_TechniqueMissionEdit);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "ribbonPageGroup4";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.barBtn_UC_TechniqueLog);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "技能登记";
            // 
            // tab_Control
            // 
            this.tab_Control.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tab_Control.HeaderLocation = DevExpress.XtraTab.TabHeaderLocation.Bottom;
            this.tab_Control.Location = new System.Drawing.Point(0, 184);
            this.tab_Control.Margin = new System.Windows.Forms.Padding(4);
            this.tab_Control.Name = "tab_Control";
            this.tab_Control.Size = new System.Drawing.Size(1029, 340);
            this.tab_Control.TabIndex = 1;
            // 
            // barBtn_UC_TechniqueMissionEdit
            // 
            this.barBtn_UC_TechniqueMissionEdit.Caption = "任务登记";
            this.barBtn_UC_TechniqueMissionEdit.Id = 12;
            this.barBtn_UC_TechniqueMissionEdit.Name = "barBtn_UC_TechniqueMissionEdit";
            this.barBtn_UC_TechniqueMissionEdit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtn_UC_TechniqueMissionEdit_ItemClick);
            // 
            // Frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 524);
            this.Controls.Add(this.tab_Control);
            this.Controls.Add(this.ribbonControl1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm_Main";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Frm_Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tab_Control)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem barBtn_TechniqueEvaluate;
        private DevExpress.XtraBars.BarButtonItem barBtn_TechniqueCatalog;
        private DevExpress.XtraBars.BarButtonItem barBtn_TechniqueEdit;
        private DevExpress.XtraTab.XtraTabControl tab_Control;
        private DevExpress.XtraBars.BarButtonItem barBtn_TechniqueMission;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem barBtn_UC_TechniqueLogEdit;
        private DevExpress.XtraBars.BarButtonItem barBtn_UC_TechniqueLogScan;
        private DevExpress.XtraBars.BarButtonItem barBtn_UC_TechniqueRegister;
        private DevExpress.XtraBars.BarButtonItem barBtn_UC_TechniqueRegisterEdit;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.BarButtonItem barBtn_UC_TechniqueLog;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem barBtn_UC_TechniqueCategoryEdit;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.BarButtonItem barBtn_UC_TechniqueEdit;
        private DevExpress.XtraBars.BarButtonItem barBtn_UC_TechniqueMissionEdit;
    }
}

