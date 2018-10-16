namespace TechniqueMaster.Module_Technique.View.UControl
{
    partial class UC_TechniqueRegister
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
            this.components = new System.ComponentModel.Container();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.gridControl_Tech = new DevExpress.XtraGrid.GridControl();
            this.gridView_Tech = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.tv_Status = new DevExpress.XtraEditors.TextEdit();
            this.btn_sure = new DevExpress.XtraEditors.SimpleButton();
            this.tv_Introspection = new DevExpress.XtraEditors.MemoEdit();
            this.tv_Summary = new DevExpress.XtraEditors.MemoEdit();
            this.tv_Reason = new DevExpress.XtraEditors.MemoEdit();
            this.dateE_Date = new DevExpress.XtraEditors.DateEdit();
            this.tv_Name = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barBtn_Start = new DevExpress.XtraBars.BarButtonItem();
            this.barBtn_Pause = new DevExpress.XtraBars.BarButtonItem();
            this.barBtn_Finish = new DevExpress.XtraBars.BarButtonItem();
            this.barBtn_Abandon = new DevExpress.XtraBars.BarButtonItem();
            this.popupMenu1 = new DevExpress.XtraBars.PopupMenu(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_Tech)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_Tech)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tv_Status.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tv_Introspection.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tv_Summary.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tv_Reason.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateE_Date.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateE_Date.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tv_Name.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.gridControl_Tech);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.layoutControl1);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1280, 698);
            this.splitContainerControl1.SplitterPosition = 362;
            this.splitContainerControl1.TabIndex = 0;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // gridControl_Tech
            // 
            this.gridControl_Tech.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl_Tech.Location = new System.Drawing.Point(0, 0);
            this.gridControl_Tech.MainView = this.gridView_Tech;
            this.gridControl_Tech.Name = "gridControl_Tech";
            this.gridControl_Tech.Size = new System.Drawing.Size(362, 698);
            this.gridControl_Tech.TabIndex = 0;
            this.gridControl_Tech.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_Tech});
            // 
            // gridView_Tech
            // 
            this.gridView_Tech.GridControl = this.gridControl_Tech;
            this.gridView_Tech.Name = "gridView_Tech";
            this.gridView_Tech.OptionsView.ShowGroupPanel = false;
            this.gridView_Tech.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView_Tech_RowClick);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.tv_Status);
            this.layoutControl1.Controls.Add(this.btn_sure);
            this.layoutControl1.Controls.Add(this.tv_Introspection);
            this.layoutControl1.Controls.Add(this.tv_Summary);
            this.layoutControl1.Controls.Add(this.tv_Reason);
            this.layoutControl1.Controls.Add(this.dateE_Date);
            this.layoutControl1.Controls.Add(this.tv_Name);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(910, 698);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // tv_Status
            // 
            this.tv_Status.Location = new System.Drawing.Point(598, 52);
            this.tv_Status.Name = "tv_Status";
            this.tv_Status.Properties.ReadOnly = true;
            this.tv_Status.Size = new System.Drawing.Size(294, 28);
            this.tv_Status.StyleController = this.layoutControl1;
            this.tv_Status.TabIndex = 11;
            // 
            // btn_sure
            // 
            this.btn_sure.Location = new System.Drawing.Point(818, 648);
            this.btn_sure.Name = "btn_sure";
            this.btn_sure.Size = new System.Drawing.Size(74, 32);
            this.btn_sure.StyleController = this.layoutControl1;
            this.btn_sure.TabIndex = 10;
            this.btn_sure.Text = "确定";
            this.btn_sure.Click += new System.EventHandler(this.btn_sure_Click);
            // 
            // tv_Introspection
            // 
            this.tv_Introspection.Location = new System.Drawing.Point(18, 453);
            this.tv_Introspection.Name = "tv_Introspection";
            this.tv_Introspection.Size = new System.Drawing.Size(874, 189);
            this.tv_Introspection.StyleController = this.layoutControl1;
            this.tv_Introspection.TabIndex = 9;
            // 
            // tv_Summary
            // 
            this.tv_Summary.Location = new System.Drawing.Point(18, 266);
            this.tv_Summary.Name = "tv_Summary";
            this.tv_Summary.Size = new System.Drawing.Size(874, 154);
            this.tv_Summary.StyleController = this.layoutControl1;
            this.tv_Summary.TabIndex = 8;
            // 
            // tv_Reason
            // 
            this.tv_Reason.Location = new System.Drawing.Point(18, 113);
            this.tv_Reason.Name = "tv_Reason";
            this.tv_Reason.Size = new System.Drawing.Size(874, 120);
            this.tv_Reason.StyleController = this.layoutControl1;
            this.tv_Reason.TabIndex = 7;
            // 
            // dateE_Date
            // 
            this.dateE_Date.EditValue = null;
            this.dateE_Date.Location = new System.Drawing.Point(131, 52);
            this.dateE_Date.Name = "dateE_Date";
            this.dateE_Date.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateE_Date.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateE_Date.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.dateE_Date.Size = new System.Drawing.Size(348, 28);
            this.dateE_Date.StyleController = this.layoutControl1;
            this.dateE_Date.TabIndex = 5;
            // 
            // tv_Name
            // 
            this.tv_Name.Location = new System.Drawing.Point(131, 18);
            this.tv_Name.Name = "tv_Name";
            this.tv_Name.Properties.ReadOnly = true;
            this.tv_Name.Size = new System.Drawing.Size(761, 28);
            this.tv_Name.StyleController = this.layoutControl1;
            this.tv_Name.TabIndex = 4;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem6,
            this.layoutControlItem7,
            this.emptySpaceItem1,
            this.layoutControlItem3});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.OptionsItemText.TextToControlDistance = 5;
            this.layoutControlGroup1.Size = new System.Drawing.Size(910, 698);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.tv_Name;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(880, 34);
            this.layoutControlItem1.Text = "技术名称";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(108, 22);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.dateE_Date;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 34);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(467, 34);
            this.layoutControlItem2.Text = "登记日期";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(108, 22);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.tv_Reason;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 68);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(880, 153);
            this.layoutControlItem4.Text = "状态更改原因";
            this.layoutControlItem4.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem4.TextSize = new System.Drawing.Size(108, 22);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.tv_Summary;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 221);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(880, 187);
            this.layoutControlItem5.Text = "技术总结";
            this.layoutControlItem5.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem5.TextSize = new System.Drawing.Size(108, 22);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.tv_Introspection;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 408);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(880, 222);
            this.layoutControlItem6.Text = "问题反思";
            this.layoutControlItem6.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem6.TextSize = new System.Drawing.Size(108, 22);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.btn_sure;
            this.layoutControlItem7.FillControlToClientArea = false;
            this.layoutControlItem7.Location = new System.Drawing.Point(800, 630);
            this.layoutControlItem7.MaxSize = new System.Drawing.Size(80, 38);
            this.layoutControlItem7.MinSize = new System.Drawing.Size(80, 38);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(80, 38);
            this.layoutControlItem7.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem7.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem7.TextVisible = false;
            this.layoutControlItem7.TrimClientAreaToControl = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 630);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(800, 38);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.tv_Status;
            this.layoutControlItem3.Location = new System.Drawing.Point(467, 34);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(413, 34);
            this.layoutControlItem3.Text = "技术状态";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(108, 22);
            // 
            // barManager1
            // 
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barBtn_Start,
            this.barBtn_Pause,
            this.barBtn_Finish,
            this.barBtn_Abandon});
            this.barManager1.MaxItemId = 4;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(1280, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 698);
            this.barDockControlBottom.Size = new System.Drawing.Size(1280, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 698);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1280, 0);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 698);
            // 
            // barBtn_Start
            // 
            this.barBtn_Start.Caption = "开始技术学习";
            this.barBtn_Start.Id = 0;
            this.barBtn_Start.Name = "barBtn_Start";
            this.barBtn_Start.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtn_Start_ItemClick);
            // 
            // barBtn_Pause
            // 
            this.barBtn_Pause.Caption = "暂停技术学习";
            this.barBtn_Pause.Id = 1;
            this.barBtn_Pause.Name = "barBtn_Pause";
            this.barBtn_Pause.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtn_Pause_ItemClick);
            // 
            // barBtn_Finish
            // 
            this.barBtn_Finish.Caption = "完成技术学习";
            this.barBtn_Finish.Id = 2;
            this.barBtn_Finish.Name = "barBtn_Finish";
            this.barBtn_Finish.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtn_Finish_ItemClick);
            // 
            // barBtn_Abandon
            // 
            this.barBtn_Abandon.Caption = "放弃技术学习";
            this.barBtn_Abandon.Id = 3;
            this.barBtn_Abandon.Name = "barBtn_Abandon";
            this.barBtn_Abandon.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtn_Abandon_ItemClick);
            // 
            // popupMenu1
            // 
            this.popupMenu1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barBtn_Start),
            new DevExpress.XtraBars.LinkPersistInfo(this.barBtn_Pause),
            new DevExpress.XtraBars.LinkPersistInfo(this.barBtn_Finish),
            new DevExpress.XtraBars.LinkPersistInfo(this.barBtn_Abandon)});
            this.popupMenu1.Manager = this.barManager1;
            this.popupMenu1.Name = "popupMenu1";
            // 
            // UC_TechniqueRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainerControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "UC_TechniqueRegister";
            this.Size = new System.Drawing.Size(1280, 698);
            this.Load += new System.EventHandler(this.UC_TechniqueRegister_Load);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_Tech)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_Tech)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tv_Status.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tv_Introspection.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tv_Summary.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tv_Reason.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateE_Date.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateE_Date.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tv_Name.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraGrid.GridControl gridControl_Tech;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_Tech;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.SimpleButton btn_sure;
        private DevExpress.XtraEditors.MemoEdit tv_Introspection;
        private DevExpress.XtraEditors.MemoEdit tv_Summary;
        private DevExpress.XtraEditors.MemoEdit tv_Reason;
        private DevExpress.XtraEditors.DateEdit dateE_Date;
        private DevExpress.XtraEditors.TextEdit tv_Name;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraEditors.TextEdit tv_Status;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem barBtn_Start;
        private DevExpress.XtraBars.BarButtonItem barBtn_Pause;
        private DevExpress.XtraBars.PopupMenu popupMenu1;
        private DevExpress.XtraBars.BarButtonItem barBtn_Finish;
        private DevExpress.XtraBars.BarButtonItem barBtn_Abandon;

    }
}
