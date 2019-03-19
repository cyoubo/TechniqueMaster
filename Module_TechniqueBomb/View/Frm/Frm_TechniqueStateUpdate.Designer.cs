namespace TechniqueMaster.Module_TechniqueBomb.View.Frm
{
    partial class Frm_TechniqueStateUpdate
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.tv_State = new DevExpress.XtraEditors.TextEdit();
            this.btn_Abandon = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Finish = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Pause = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Run = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.tv_MissionName = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tv_State.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tv_MissionName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.tv_State);
            this.layoutControl1.Controls.Add(this.btn_Abandon);
            this.layoutControl1.Controls.Add(this.btn_Finish);
            this.layoutControl1.Controls.Add(this.btn_Pause);
            this.layoutControl1.Controls.Add(this.btn_Run);
            this.layoutControl1.Controls.Add(this.gridControl1);
            this.layoutControl1.Controls.Add(this.tv_MissionName);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(1003, 598);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // tv_State
            // 
            this.tv_State.Location = new System.Drawing.Point(95, 52);
            this.tv_State.Name = "tv_State";
            this.tv_State.Properties.ReadOnly = true;
            this.tv_State.Size = new System.Drawing.Size(570, 28);
            this.tv_State.StyleController = this.layoutControl1;
            this.tv_State.TabIndex = 11;
            // 
            // btn_Abandon
            // 
            this.btn_Abandon.Location = new System.Drawing.Point(911, 52);
            this.btn_Abandon.Name = "btn_Abandon";
            this.btn_Abandon.Size = new System.Drawing.Size(74, 32);
            this.btn_Abandon.StyleController = this.layoutControl1;
            this.btn_Abandon.TabIndex = 10;
            this.btn_Abandon.Text = "放弃了";
            this.btn_Abandon.Click += new System.EventHandler(this.btn_Abandon_Click);
            // 
            // btn_Finish
            // 
            this.btn_Finish.Location = new System.Drawing.Point(751, 52);
            this.btn_Finish.Name = "btn_Finish";
            this.btn_Finish.Size = new System.Drawing.Size(74, 32);
            this.btn_Finish.StyleController = this.layoutControl1;
            this.btn_Finish.TabIndex = 9;
            this.btn_Finish.Text = "已完成";
            this.btn_Finish.Click += new System.EventHandler(this.btn_Finish_Click);
            // 
            // btn_Pause
            // 
            this.btn_Pause.Location = new System.Drawing.Point(831, 52);
            this.btn_Pause.Name = "btn_Pause";
            this.btn_Pause.Size = new System.Drawing.Size(74, 32);
            this.btn_Pause.StyleController = this.layoutControl1;
            this.btn_Pause.TabIndex = 8;
            this.btn_Pause.Text = "暂停中";
            this.btn_Pause.Click += new System.EventHandler(this.btn_Pause_Click);
            // 
            // btn_Run
            // 
            this.btn_Run.Location = new System.Drawing.Point(671, 52);
            this.btn_Run.Name = "btn_Run";
            this.btn_Run.Size = new System.Drawing.Size(74, 32);
            this.btn_Run.StyleController = this.layoutControl1;
            this.btn_Run.TabIndex = 7;
            this.btn_Run.Text = "进行中";
            this.btn_Run.Click += new System.EventHandler(this.btn_Run_Click);
            // 
            // gridControl1
            // 
            gridLevelNode1.RelationName = "Level1";
            this.gridControl1.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gridControl1.Location = new System.Drawing.Point(18, 117);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(967, 463);
            this.gridControl1.TabIndex = 5;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // tv_MissionName
            // 
            this.tv_MissionName.Location = new System.Drawing.Point(95, 18);
            this.tv_MissionName.Name = "tv_MissionName";
            this.tv_MissionName.Properties.ReadOnly = true;
            this.tv_MissionName.Size = new System.Drawing.Size(890, 28);
            this.tv_MissionName.StyleController = this.layoutControl1;
            this.tv_MissionName.TabIndex = 4;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem4,
            this.layoutControlItem6,
            this.layoutControlItem3,
            this.layoutControlItem5,
            this.layoutControlItem7});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.OptionsItemText.TextToControlDistance = 5;
            this.layoutControlGroup1.Size = new System.Drawing.Size(1003, 598);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.tv_MissionName;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(973, 34);
            this.layoutControlItem1.Text = "技能名称";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(72, 22);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.gridControl1;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(973, 496);
            this.layoutControlItem2.Text = "下属任务";
            this.layoutControlItem2.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(72, 22);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.btn_Run;
            this.layoutControlItem4.FillControlToClientArea = false;
            this.layoutControlItem4.Location = new System.Drawing.Point(653, 34);
            this.layoutControlItem4.MaxSize = new System.Drawing.Size(80, 38);
            this.layoutControlItem4.MinSize = new System.Drawing.Size(80, 38);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(80, 38);
            this.layoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            this.layoutControlItem4.TrimClientAreaToControl = false;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.btn_Abandon;
            this.layoutControlItem6.FillControlToClientArea = false;
            this.layoutControlItem6.Location = new System.Drawing.Point(893, 34);
            this.layoutControlItem6.MaxSize = new System.Drawing.Size(80, 38);
            this.layoutControlItem6.MinSize = new System.Drawing.Size(80, 38);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(80, 38);
            this.layoutControlItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            this.layoutControlItem6.TrimClientAreaToControl = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.btn_Pause;
            this.layoutControlItem3.FillControlToClientArea = false;
            this.layoutControlItem3.Location = new System.Drawing.Point(813, 34);
            this.layoutControlItem3.MaxSize = new System.Drawing.Size(80, 38);
            this.layoutControlItem3.MinSize = new System.Drawing.Size(80, 38);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(80, 38);
            this.layoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            this.layoutControlItem3.TrimClientAreaToControl = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.btn_Finish;
            this.layoutControlItem5.FillControlToClientArea = false;
            this.layoutControlItem5.Location = new System.Drawing.Point(733, 34);
            this.layoutControlItem5.MaxSize = new System.Drawing.Size(80, 38);
            this.layoutControlItem5.MinSize = new System.Drawing.Size(80, 38);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(80, 38);
            this.layoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            this.layoutControlItem5.TrimClientAreaToControl = false;
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.tv_State;
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 34);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(653, 38);
            this.layoutControlItem7.Text = "技能状态";
            this.layoutControlItem7.TextSize = new System.Drawing.Size(72, 22);
            // 
            // Frm_TechniqueStateUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 598);
            this.Controls.Add(this.layoutControl1);
            this.Name = "Frm_TechniqueStateUpdate";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "技能状态更新";
            this.Load += new System.EventHandler(this.Frm_TechniqueStateUpdate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tv_State.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tv_MissionName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.TextEdit tv_MissionName;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraEditors.SimpleButton btn_Run;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraEditors.TextEdit tv_State;
        private DevExpress.XtraEditors.SimpleButton btn_Abandon;
        private DevExpress.XtraEditors.SimpleButton btn_Finish;
        private DevExpress.XtraEditors.SimpleButton btn_Pause;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
    }
}