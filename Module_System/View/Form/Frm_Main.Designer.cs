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
            this.barBtn_TechniqueEvaluate = new DevExpress.XtraBars.BarButtonItem();
            this.barBtn_TechniqueCatalog = new DevExpress.XtraBars.BarButtonItem();
            this.barBtn_TechniqueEdit = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.tab_Control = new DevExpress.XtraTab.XtraTabControl();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.barBtn_TechniqueMission = new DevExpress.XtraBars.BarButtonItem();
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
            this.barBtn_TechniqueMission});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ribbonControl1.MaxItemId = 5;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
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
            this.barBtn_TechniqueCatalog.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
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
            this.ribbonPageGroup1.ItemLinks.Add(this.barBtn_TechniqueCatalog);
            this.ribbonPageGroup1.ItemLinks.Add(this.barBtn_TechniqueEdit);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "技能管理";
            // 
            // tab_Control
            // 
            this.tab_Control.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tab_Control.HeaderLocation = DevExpress.XtraTab.TabHeaderLocation.Bottom;
            this.tab_Control.Location = new System.Drawing.Point(0, 184);
            this.tab_Control.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tab_Control.Name = "tab_Control";
            this.tab_Control.Size = new System.Drawing.Size(1029, 340);
            this.tab_Control.TabIndex = 1;
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.barBtn_TechniqueMission);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "技能任务";
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
            // Frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 524);
            this.Controls.Add(this.tab_Control);
            this.Controls.Add(this.ribbonControl1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
    }
}

