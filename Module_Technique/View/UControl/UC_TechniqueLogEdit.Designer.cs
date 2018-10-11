namespace TechniqueMaster.Module_Technique.View.UControl
{
    partial class UC_TechniqueLogEdit
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.dateE_Date = new DevExpress.XtraEditors.DateEdit();
            this.calendar_DataPicker = new DevExpress.XtraEditors.Controls.CalendarControl();
            this.btn_sure = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl_Misssion = new DevExpress.XtraGrid.GridControl();
            this.gridView_Misssion = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.repo_HLE_Delete = new DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit();
            this.repo_HLE_Edit = new DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit();
            this.tv_Context = new DevExpress.XtraEditors.MemoEdit();
            this.tv_URL = new DevExpress.XtraEditors.TextEdit();
            this.cmb_Mission = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cmb_Tech = new DevExpress.XtraEditors.ComboBoxEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateE_Date.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateE_Date.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calendar_DataPicker.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_Misssion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_Misssion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repo_HLE_Delete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repo_HLE_Edit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tv_Context.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tv_URL.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Mission.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Tech.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.dateE_Date);
            this.layoutControl1.Controls.Add(this.calendar_DataPicker);
            this.layoutControl1.Controls.Add(this.btn_sure);
            this.layoutControl1.Controls.Add(this.gridControl_Misssion);
            this.layoutControl1.Controls.Add(this.tv_Context);
            this.layoutControl1.Controls.Add(this.tv_URL);
            this.layoutControl1.Controls.Add(this.cmb_Mission);
            this.layoutControl1.Controls.Add(this.cmb_Tech);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(1254, 712);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // dateE_Date
            // 
            this.dateE_Date.EditValue = null;
            this.dateE_Date.Location = new System.Drawing.Point(132, 459);
            this.dateE_Date.Name = "dateE_Date";
            this.dateE_Date.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateE_Date.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateE_Date.Size = new System.Drawing.Size(1085, 28);
            this.dateE_Date.StyleController = this.layoutControl1;
            this.dateE_Date.TabIndex = 11;
            this.dateE_Date.EditValueChanged += new System.EventHandler(this.dateE_Date_EditValueChanged);
            // 
            // calendar_DataPicker
            // 
            this.calendar_DataPicker.AutoSize = false;
            this.calendar_DataPicker.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.calendar_DataPicker.Location = new System.Drawing.Point(37, 67);
            this.calendar_DataPicker.Name = "calendar_DataPicker";
            this.calendar_DataPicker.ShowMonthHeaders = false;
            this.calendar_DataPicker.Size = new System.Drawing.Size(294, 318);
            this.calendar_DataPicker.StyleController = this.layoutControl1;
            this.calendar_DataPicker.TabIndex = 10;
            // 
            // btn_sure
            // 
            this.btn_sure.Location = new System.Drawing.Point(1143, 353);
            this.btn_sure.Name = "btn_sure";
            this.btn_sure.Size = new System.Drawing.Size(74, 32);
            this.btn_sure.StyleController = this.layoutControl1;
            this.btn_sure.TabIndex = 9;
            this.btn_sure.Text = "确定";
            this.btn_sure.Click += new System.EventHandler(this.btn_sure_Click);
            // 
            // gridControl_Misssion
            // 
            this.gridControl_Misssion.Location = new System.Drawing.Point(37, 520);
            this.gridControl_Misssion.MainView = this.gridView_Misssion;
            this.gridControl_Misssion.Name = "gridControl_Misssion";
            this.gridControl_Misssion.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repo_HLE_Delete,
            this.repo_HLE_Edit});
            this.gridControl_Misssion.Size = new System.Drawing.Size(1180, 155);
            this.gridControl_Misssion.TabIndex = 8;
            this.gridControl_Misssion.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_Misssion});
            // 
            // gridView_Misssion
            // 
            this.gridView_Misssion.GridControl = this.gridControl_Misssion;
            this.gridView_Misssion.Name = "gridView_Misssion";
            this.gridView_Misssion.OptionsView.ShowGroupPanel = false;
            // 
            // repo_HLE_Delete
            // 
            this.repo_HLE_Delete.AutoHeight = false;
            this.repo_HLE_Delete.Name = "repo_HLE_Delete";
            this.repo_HLE_Delete.Click += new System.EventHandler(this.repo_HLE_Delete_Click);
            // 
            // repo_HLE_Edit
            // 
            this.repo_HLE_Edit.AutoHeight = false;
            this.repo_HLE_Edit.Name = "repo_HLE_Edit";
            this.repo_HLE_Edit.Click += new System.EventHandler(this.repo_HLE_Edit_Click);
            // 
            // tv_Context
            // 
            this.tv_Context.Location = new System.Drawing.Point(337, 162);
            this.tv_Context.Name = "tv_Context";
            this.tv_Context.Size = new System.Drawing.Size(880, 185);
            this.tv_Context.StyleController = this.layoutControl1;
            this.tv_Context.TabIndex = 7;
            // 
            // tv_URL
            // 
            this.tv_URL.Location = new System.Drawing.Point(432, 101);
            this.tv_URL.Name = "tv_URL";
            this.tv_URL.Size = new System.Drawing.Size(785, 28);
            this.tv_URL.StyleController = this.layoutControl1;
            this.tv_URL.TabIndex = 6;
            // 
            // cmb_Mission
            // 
            this.cmb_Mission.Location = new System.Drawing.Point(910, 67);
            this.cmb_Mission.Name = "cmb_Mission";
            this.cmb_Mission.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_Mission.Size = new System.Drawing.Size(307, 28);
            this.cmb_Mission.StyleController = this.layoutControl1;
            this.cmb_Mission.TabIndex = 5;
            // 
            // cmb_Tech
            // 
            this.cmb_Tech.Location = new System.Drawing.Point(432, 67);
            this.cmb_Tech.Name = "cmb_Tech";
            this.cmb_Tech.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmb_Tech.Size = new System.Drawing.Size(377, 28);
            this.cmb_Tech.StyleController = this.layoutControl1;
            this.cmb_Tech.TabIndex = 4;
            this.cmb_Tech.SelectedIndexChanged += new System.EventHandler(this.cmb_Tech_SelectedIndexChanged);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2,
            this.layoutControlGroup3});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.OptionsItemText.TextToControlDistance = 5;
            this.layoutControlGroup1.Size = new System.Drawing.Size(1254, 712);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem4,
            this.layoutControlItem6,
            this.emptySpaceItem1,
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem7});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.OptionsItemText.TextToControlDistance = 5;
            this.layoutControlGroup2.Size = new System.Drawing.Size(1224, 392);
            this.layoutControlGroup2.Text = "日志登记";
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.tv_Context;
            this.layoutControlItem4.Location = new System.Drawing.Point(300, 68);
            this.layoutControlItem4.Name = "日志内容";
            this.layoutControlItem4.Size = new System.Drawing.Size(886, 218);
            this.layoutControlItem4.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem4.TextSize = new System.Drawing.Size(90, 22);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.btn_sure;
            this.layoutControlItem6.FillControlToClientArea = false;
            this.layoutControlItem6.Location = new System.Drawing.Point(1106, 286);
            this.layoutControlItem6.MaxSize = new System.Drawing.Size(80, 38);
            this.layoutControlItem6.MinSize = new System.Drawing.Size(80, 38);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(80, 38);
            this.layoutControlItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            this.layoutControlItem6.TrimClientAreaToControl = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(300, 286);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(806, 38);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.cmb_Tech;
            this.layoutControlItem1.Location = new System.Drawing.Point(300, 0);
            this.layoutControlItem1.Name = "所属技术";
            this.layoutControlItem1.Size = new System.Drawing.Size(478, 34);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(90, 22);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.cmb_Mission;
            this.layoutControlItem2.Location = new System.Drawing.Point(778, 0);
            this.layoutControlItem2.Name = "所属任务";
            this.layoutControlItem2.Size = new System.Drawing.Size(408, 34);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(90, 22);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.tv_URL;
            this.layoutControlItem3.Location = new System.Drawing.Point(300, 34);
            this.layoutControlItem3.Name = "云笔记链接";
            this.layoutControlItem3.Size = new System.Drawing.Size(886, 34);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(90, 22);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.calendar_DataPicker;
            this.layoutControlItem7.FillControlToClientArea = false;
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(300, 324);
            this.layoutControlItem7.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.SupportHorzAlignment;
            this.layoutControlItem7.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem7.TextVisible = false;
            this.layoutControlItem7.TrimClientAreaToControl = false;
            // 
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem8,
            this.layoutControlItem5});
            this.layoutControlGroup3.Location = new System.Drawing.Point(0, 392);
            this.layoutControlGroup3.Name = "layoutControlGroup3";
            this.layoutControlGroup3.OptionsItemText.TextToControlDistance = 5;
            this.layoutControlGroup3.Size = new System.Drawing.Size(1224, 290);
            this.layoutControlGroup3.Text = "日志浏览";
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.dateE_Date;
            this.layoutControlItem8.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem8.Name = "日志日期";
            this.layoutControlItem8.Size = new System.Drawing.Size(1186, 34);
            this.layoutControlItem8.TextSize = new System.Drawing.Size(90, 22);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.gridControl_Misssion;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 34);
            this.layoutControlItem5.Name = "日志列表";
            this.layoutControlItem5.Size = new System.Drawing.Size(1186, 188);
            this.layoutControlItem5.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem5.TextSize = new System.Drawing.Size(90, 22);
            // 
            // UC_TechniqueLogEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.Name = "UC_TechniqueLogEdit";
            this.Size = new System.Drawing.Size(1254, 712);
            this.Load += new System.EventHandler(this.UC_TechniqueLogEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dateE_Date.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateE_Date.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calendar_DataPicker.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_Misssion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_Misssion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repo_HLE_Delete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repo_HLE_Edit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tv_Context.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tv_URL.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Mission.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmb_Tech.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.MemoEdit tv_Context;
        private DevExpress.XtraEditors.TextEdit tv_URL;
        private DevExpress.XtraEditors.ComboBoxEdit cmb_Mission;
        private DevExpress.XtraEditors.ComboBoxEdit cmb_Tech;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraGrid.GridControl gridControl_Misssion;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_Misssion;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraEditors.SimpleButton btn_sure;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraEditors.Controls.CalendarControl calendar_DataPicker;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraEditors.DateEdit dateE_Date;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit repo_HLE_Delete;
        private DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit repo_HLE_Edit;

    }
}
