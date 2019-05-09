namespace TechniqueMaster.Module_TechniqueBomb.View.UControl
{
    partial class UC_TechniqueReviewInvertedEdit
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.advBandedGridView1 = new DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.repo_HLE_gotoURL = new DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit();
            this.repo_HLE_ReviewAdd = new DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit();
            this.repo_HLE_ReviewReduce = new DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit();
            this.btn_reduceTen = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.btn_plusTen = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.tv_count = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.advBandedGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repo_HLE_gotoURL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repo_HLE_ReviewAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repo_HLE_ReviewReduce)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tv_count.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.tv_count);
            this.layoutControl1.Controls.Add(this.btn_plusTen);
            this.layoutControl1.Controls.Add(this.btn_reduceTen);
            this.layoutControl1.Controls.Add(this.gridControl1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(962, 514);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem4,
            this.layoutControlItem2,
            this.layoutControlItem3});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(962, 514);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(12, 38);
            this.gridControl1.MainView = this.advBandedGridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repo_HLE_gotoURL,
            this.repo_HLE_ReviewAdd,
            this.repo_HLE_ReviewReduce});
            this.gridControl1.Size = new System.Drawing.Size(938, 464);
            this.gridControl1.TabIndex = 4;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.advBandedGridView1});
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridControl1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 26);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(942, 468);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // advBandedGridView1
            // 
            this.advBandedGridView1.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBand1});
            this.advBandedGridView1.GridControl = this.gridControl1;
            this.advBandedGridView1.Name = "advBandedGridView1";
            this.advBandedGridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gridBand1
            // 
            this.gridBand1.Caption = "gridBand1";
            this.gridBand1.Name = "gridBand1";
            this.gridBand1.VisibleIndex = 0;
            // 
            // repo_HLE_gotoURL
            // 
            this.repo_HLE_gotoURL.AutoHeight = false;
            this.repo_HLE_gotoURL.Name = "repo_HLE_gotoURL";
            this.repo_HLE_gotoURL.Click += new System.EventHandler(this.repo_HLE_gotoURL_Click);
            // 
            // repo_HLE_ReviewAdd
            // 
            this.repo_HLE_ReviewAdd.AutoHeight = false;
            this.repo_HLE_ReviewAdd.Name = "repo_HLE_ReviewAdd";
            this.repo_HLE_ReviewAdd.Click += new System.EventHandler(this.repo_HLE_ReviewAdd_Click);
            // 
            // repo_HLE_ReviewReduce
            // 
            this.repo_HLE_ReviewReduce.AutoHeight = false;
            this.repo_HLE_ReviewReduce.Name = "repo_HLE_ReviewReduce";
            this.repo_HLE_ReviewReduce.Click += new System.EventHandler(this.repo_HLE_ReviewReduce_Click);
            // 
            // btn_reduceTen
            // 
            this.btn_reduceTen.Location = new System.Drawing.Point(864, 12);
            this.btn_reduceTen.Name = "btn_reduceTen";
            this.btn_reduceTen.Size = new System.Drawing.Size(86, 22);
            this.btn_reduceTen.StyleController = this.layoutControl1;
            this.btn_reduceTen.TabIndex = 5;
            this.btn_reduceTen.Text = "少看10条";
            this.btn_reduceTen.Click += new System.EventHandler(this.btn_reduceTen_Click);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.btn_reduceTen;
            this.layoutControlItem2.FillControlToClientArea = false;
            this.layoutControlItem2.Location = new System.Drawing.Point(852, 0);
            this.layoutControlItem2.MaxSize = new System.Drawing.Size(90, 26);
            this.layoutControlItem2.MinSize = new System.Drawing.Size(90, 26);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(90, 26);
            this.layoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            this.layoutControlItem2.TrimClientAreaToControl = false;
            // 
            // btn_plusTen
            // 
            this.btn_plusTen.Location = new System.Drawing.Point(774, 12);
            this.btn_plusTen.Name = "btn_plusTen";
            this.btn_plusTen.Size = new System.Drawing.Size(86, 22);
            this.btn_plusTen.StyleController = this.layoutControl1;
            this.btn_plusTen.TabIndex = 6;
            this.btn_plusTen.Text = "再看10条";
            this.btn_plusTen.Click += new System.EventHandler(this.btn_plusTen_Click);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.btn_plusTen;
            this.layoutControlItem3.FillControlToClientArea = false;
            this.layoutControlItem3.Location = new System.Drawing.Point(762, 0);
            this.layoutControlItem3.MaxSize = new System.Drawing.Size(90, 26);
            this.layoutControlItem3.MinSize = new System.Drawing.Size(90, 26);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(90, 26);
            this.layoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            this.layoutControlItem3.TrimClientAreaToControl = false;
            // 
            // tv_count
            // 
            this.tv_count.EditValue = "10";
            this.tv_count.Location = new System.Drawing.Point(88, 12);
            this.tv_count.Name = "tv_count";
            this.tv_count.Properties.ReadOnly = true;
            this.tv_count.Size = new System.Drawing.Size(682, 20);
            this.tv_count.StyleController = this.layoutControl1;
            this.tv_count.TabIndex = 7;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.tv_count;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(762, 26);
            this.layoutControlItem4.Text = "共计回顾条数";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(72, 14);
            // 
            // UC_TechniqueReviewInvertedEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.Name = "UC_TechniqueReviewInvertedEdit";
            this.Size = new System.Drawing.Size(962, 514);
            this.Load += new System.EventHandler(this.UC_TechniqueReviewInvertedEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.advBandedGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repo_HLE_gotoURL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repo_HLE_ReviewAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repo_HLE_ReviewReduce)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tv_count.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView advBandedGridView1;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
        private DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit repo_HLE_gotoURL;
        private DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit repo_HLE_ReviewAdd;
        private DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit repo_HLE_ReviewReduce;
        private DevExpress.XtraEditors.TextEdit tv_count;
        private DevExpress.XtraEditors.SimpleButton btn_plusTen;
        private DevExpress.XtraEditors.SimpleButton btn_reduceTen;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
    }
}
