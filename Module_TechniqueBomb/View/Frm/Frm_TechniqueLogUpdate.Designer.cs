namespace TechniqueMaster.Module_TechniqueBomb.View.Frm
{
    partial class Frm_TechniqueLogUpdate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_TechniqueLogUpdate));
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.tv_date = new DevExpress.XtraEditors.TextEdit();
            this.btn_goto = new DevExpress.XtraEditors.SimpleButton();
            this.btn_delete = new DevExpress.XtraEditors.SimpleButton();
            this.btn_sure = new DevExpress.XtraEditors.SimpleButton();
            this.tv_Url = new DevExpress.XtraEditors.MemoEdit();
            this.tv_Context = new DevExpress.XtraEditors.MemoEdit();
            this.sle_Mission = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.tgS_IsNeedTidy = new DevExpress.XtraEditors.ToggleSwitch();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tv_date.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tv_Url.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tv_Context.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sle_Mission.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tgS_IsNeedTidy.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.tgS_IsNeedTidy);
            this.layoutControl1.Controls.Add(this.tv_date);
            this.layoutControl1.Controls.Add(this.btn_goto);
            this.layoutControl1.Controls.Add(this.btn_delete);
            this.layoutControl1.Controls.Add(this.btn_sure);
            this.layoutControl1.Controls.Add(this.tv_Url);
            this.layoutControl1.Controls.Add(this.tv_Context);
            this.layoutControl1.Controls.Add(this.sle_Mission);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(919, 418);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // tv_date
            // 
            this.tv_date.Location = new System.Drawing.Point(18, 45);
            this.tv_date.Name = "tv_date";
            this.tv_date.Properties.ReadOnly = true;
            this.tv_date.Size = new System.Drawing.Size(438, 28);
            this.tv_date.StyleController = this.layoutControl1;
            this.tv_date.TabIndex = 10;
            // 
            // btn_goto
            // 
            this.btn_goto.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_goto.Appearance.Options.UseBackColor = true;
            this.btn_goto.Appearance.Options.UseBorderColor = true;
            this.btn_goto.Image = ((System.Drawing.Image)(resources.GetObject("btn_goto.Image")));
            this.btn_goto.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.btn_goto.Location = new System.Drawing.Point(857, 328);
            this.btn_goto.Name = "btn_goto";
            this.btn_goto.Size = new System.Drawing.Size(44, 32);
            this.btn_goto.StyleController = this.layoutControl1;
            this.btn_goto.TabIndex = 9;
            this.btn_goto.Click += new System.EventHandler(this.btn_goto_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(747, 366);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(74, 32);
            this.btn_delete.StyleController = this.layoutControl1;
            this.btn_delete.TabIndex = 8;
            this.btn_delete.Text = "删除";
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_sure
            // 
            this.btn_sure.Location = new System.Drawing.Point(827, 366);
            this.btn_sure.Name = "btn_sure";
            this.btn_sure.Size = new System.Drawing.Size(74, 32);
            this.btn_sure.StyleController = this.layoutControl1;
            this.btn_sure.TabIndex = 7;
            this.btn_sure.Text = "确定";
            this.btn_sure.Click += new System.EventHandler(this.btn_sure_Click);
            // 
            // tv_Url
            // 
            this.tv_Url.Location = new System.Drawing.Point(18, 230);
            this.tv_Url.Name = "tv_Url";
            this.tv_Url.Size = new System.Drawing.Size(833, 130);
            this.tv_Url.StyleController = this.layoutControl1;
            this.tv_Url.TabIndex = 6;
            // 
            // tv_Context
            // 
            this.tv_Context.Location = new System.Drawing.Point(18, 106);
            this.tv_Context.Name = "tv_Context";
            this.tv_Context.Size = new System.Drawing.Size(883, 91);
            this.tv_Context.StyleController = this.layoutControl1;
            this.tv_Context.TabIndex = 5;
            // 
            // sle_Mission
            // 
            this.sle_Mission.Location = new System.Drawing.Point(462, 45);
            this.sle_Mission.Name = "sle_Mission";
            this.sle_Mission.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.sle_Mission.Properties.View = this.searchLookUpEdit1View;
            this.sle_Mission.Size = new System.Drawing.Size(439, 28);
            this.sle_Mission.StyleController = this.layoutControl1;
            this.sle_Mission.TabIndex = 4;
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.layoutControlItem4,
            this.layoutControlItem7,
            this.layoutControlItem1,
            this.layoutControlItem3,
            this.layoutControlItem6,
            this.layoutControlItem5,
            this.emptySpaceItem2,
            this.emptySpaceItem1,
            this.layoutControlItem8});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.OptionsItemText.TextToControlDistance = 5;
            this.layoutControlGroup1.Size = new System.Drawing.Size(919, 418);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.tv_Context;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 61);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(889, 124);
            this.layoutControlItem2.Text = "日志内容";
            this.layoutControlItem2.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(72, 22);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.btn_sure;
            this.layoutControlItem4.FillControlToClientArea = false;
            this.layoutControlItem4.Location = new System.Drawing.Point(809, 348);
            this.layoutControlItem4.MaxSize = new System.Drawing.Size(80, 38);
            this.layoutControlItem4.MinSize = new System.Drawing.Size(80, 38);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(80, 40);
            this.layoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            this.layoutControlItem4.TrimClientAreaToControl = false;
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.tv_date;
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(444, 61);
            this.layoutControlItem7.Text = "记录日期";
            this.layoutControlItem7.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem7.TextSize = new System.Drawing.Size(72, 22);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.sle_Mission;
            this.layoutControlItem1.Location = new System.Drawing.Point(444, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(445, 61);
            this.layoutControlItem1.Text = "所属任务";
            this.layoutControlItem1.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(72, 22);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.tv_Url;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 185);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(839, 163);
            this.layoutControlItem3.Text = "笔记连接";
            this.layoutControlItem3.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem3.TextSize = new System.Drawing.Size(72, 22);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.btn_goto;
            this.layoutControlItem6.ControlAlignment = System.Drawing.ContentAlignment.BottomCenter;
            this.layoutControlItem6.FillControlToClientArea = false;
            this.layoutControlItem6.Location = new System.Drawing.Point(839, 310);
            this.layoutControlItem6.MaxSize = new System.Drawing.Size(50, 38);
            this.layoutControlItem6.MinSize = new System.Drawing.Size(50, 38);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(50, 38);
            this.layoutControlItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            this.layoutControlItem6.TrimClientAreaToControl = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.btn_delete;
            this.layoutControlItem5.FillControlToClientArea = false;
            this.layoutControlItem5.Location = new System.Drawing.Point(729, 348);
            this.layoutControlItem5.MaxSize = new System.Drawing.Size(80, 38);
            this.layoutControlItem5.MinSize = new System.Drawing.Size(80, 38);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(80, 40);
            this.layoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            this.layoutControlItem5.TrimClientAreaToControl = false;
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(839, 185);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(50, 125);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(185, 348);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(544, 40);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // tgS_IsNeedTidy
            // 
            this.tgS_IsNeedTidy.Location = new System.Drawing.Point(18, 366);
            this.tgS_IsNeedTidy.Name = "tgS_IsNeedTidy";
            this.tgS_IsNeedTidy.Properties.OffText = "不用整理";
            this.tgS_IsNeedTidy.Properties.OnText = "亟待整理";
            this.tgS_IsNeedTidy.Size = new System.Drawing.Size(179, 34);
            this.tgS_IsNeedTidy.StyleController = this.layoutControl1;
            this.tgS_IsNeedTidy.TabIndex = 11;
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.tgS_IsNeedTidy;
            this.layoutControlItem8.Location = new System.Drawing.Point(0, 348);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(185, 40);
            this.layoutControlItem8.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem8.TextVisible = false;
            // 
            // Frm_TechniqueLogUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 418);
            this.Controls.Add(this.layoutControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_TechniqueLogUpdate";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "日志更新";
            this.Load += new System.EventHandler(this.Frm_TechniqueLogUpdate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tv_date.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tv_Url.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tv_Context.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sle_Mission.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tgS_IsNeedTidy.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.SimpleButton btn_goto;
        private DevExpress.XtraEditors.SimpleButton btn_delete;
        private DevExpress.XtraEditors.SimpleButton btn_sure;
        private DevExpress.XtraEditors.MemoEdit tv_Url;
        private DevExpress.XtraEditors.MemoEdit tv_Context;
        private DevExpress.XtraEditors.SearchLookUpEdit sle_Mission;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraEditors.TextEdit tv_date;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraEditors.ToggleSwitch tgS_IsNeedTidy;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
    }
}