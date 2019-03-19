using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using PS.Plot.FrameBasic.Module_Common.Interface;
using TechniqueMaster.Module_TechniqueBomb.Controller;
using PS.Plot.FrameBasic.Module_Common.Component;
using TechniqueMaster.Module_TechniqueBomb.Componet.Adapter;
using PS.Plot.FrameBasic.Module_SupportLibs.DevExpressionTools;
using DevExpress.XtraGrid.Views.BandedGrid;
using PS.Plot.FrameBasic.Module_System.DevExpressionTools;

namespace TechniqueMaster.Module_TechniqueBomb.View.UControl
{
    public partial class UC_TechniqueLogManage : DevExpress.XtraEditors.XtraUserControl,IInitialUI
    {
        private TB_TechniqueMissionStateBuilder builder_Mission;
        private TB_TechniqueMissionStateAdapter adapter_Mission;
        private GridControlHelper gridHelper_Mission;

        private TB_TechniqueLogAdapter adapter_Log;
        private TB_TechniqueLogBuilder builder_Log;

        public UC_TechniqueLogManage()
        {
            InitializeComponent();
        }
        private void UC_TechniqueLogManage_Load(object sender, EventArgs e)
        {
            onCreateComponet();
            onInitialUI();
        }

        public void onCreateComponet()
        {
            builder_Mission = new TB_TechniqueMissionStateBuilder();
            adapter_Mission = new TB_TechniqueMissionStateAdapter();
            adapter_Mission.Initial(builder_Mission);
            gridHelper_Mission = new GridControlHelper(this.gridView1, this.gridControl1);

            adapter_Log = new TB_TechniqueLogAdapter();
            builder_Log = new TB_TechniqueLogBuilder();
            adapter_Log.Initial(builder_Log);

            this.gridControl2.DataSource = builder_Log.CreateDataTable();

            GridBand band_Date = new GridBand() {Caption = "日期"};
            GridBand band_Info = new GridBand() {Caption = "信息"};
            GridBand band_Op = new GridBand() { Caption = "操作" };
            this.advBandedGridView1.Bands.Clear();
            this.advBandedGridView1.Bands.AddRange(new GridBand[]{band_Date,band_Info,band_Op});

            BandedGridColumn col_Date = new BandedGridColumn { FieldName = builder_Log.Date, Visible = true };
            BandedGridColumn col_Context = new BandedGridColumn { FieldName = builder_Log.Context, Visible = true };
            BandedGridColumn col_Url = new BandedGridColumn { FieldName = builder_Log.LogUrl, Visible = true };
            BandedGridColumn col_OpDelete = new BandedGridColumn { FieldName = builder_Log.Op_Delete, Visible = true };
            
            UpdateColumnOption(col_Date, band_Date, false, true, 0);
            UpdateColumnOption(col_Context, band_Info, false, false, 0);
            UpdateColumnOption(col_Url, band_Info, false, false, 1);
            UpdateColumnOption(col_OpDelete, band_Op, false, true, 0);

            advBandedGridView1.OptionsView.ColumnAutoWidth = true;
            advBandedGridView1.OptionsView.ShowBands = false;
            advBandedGridView1.RowHeight = 35;
            advBandedGridView1.OptionsView.ShowColumnHeaders = false;
            band_Date.OptionsBand.FixedWidth = true;
            band_Op.OptionsBand.FixedWidth = true;

            this.advBandedGridView1.Columns[builder_Log.Op_Delete].ColumnEdit = repo_HLE_delete;
            this.advBandedGridView1.Columns[builder_Log.Op_Delete].OptionsColumn.AllowEdit = true;

            this.advBandedGridView1.Columns[builder_Log.LogUrl].ColumnEdit = repo_HLE_gotoURL;
            this.advBandedGridView1.Columns[builder_Log.LogUrl].OptionsColumn.AllowEdit = true;
        }

        public void onInitialUI()
        {
            this.cmb_Technique.Properties.Items.Clear();
            foreach (var item in new TechniqueController().Travels())
                this.cmb_Technique.Properties.Items.Add(item.ConvertToComboxItem());
            this.cmb_Technique.SelectedIndex = -1;

            if (adapter_Log != null)
                adapter_Log.NotifyClearTable();
            if (adapter_Mission != null)
                adapter_Mission.NotifyClearTable();
        }

        private void cmb_Technique_SelectedIndexChanged(object sender, EventArgs e)
        {
            string techniqueID = (cmb_Technique.SelectedItem as ComboxItem).Tag;
            adapter_Mission.NotifyfreshDataTable(new TechniqueMissionController().FindMissionByTechniqueID(techniqueID));
            gridHelper_Mission.GridControl.DataSource = adapter_Mission.ResultTable;
            gridHelper_Mission.SetAllColumnVisible(false);
            gridHelper_Mission.SetColunmOption(builder_Mission.Name, false, true);
            gridHelper_Mission.SetColunmOption(builder_Mission.Cal_IsFinish, false, true);
            gridHelper_Mission.Group(builder_Mission.Cal_IsFinish);
            gridHelper_Mission.GridView.ExpandAllGroups();
            gridHelper_Mission.GridView.GroupFormat = "{1}";
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            if (gridHelper_Mission.GridView.IsGroupRow(gridHelper_Mission.GridView.FocusedRowHandle))
                return;

            string missionID = gridHelper_Mission.getFocuseRowCellValue_String(builder_Mission.ObjectID);
            adapter_Log.NotifyfreshDataTable(new TechniqueLogController().FindByMissionID(missionID));
            this.gridControl2.DataSource = adapter_Log.ResultTable;
        }

        private void UpdateColumnOption(BandedGridColumn col, GridBand Owner, bool isEditable = false, bool isFillDown = false, int rowIndex = 0)
        {
            col.OwnerBand = Owner;
            col.OptionsColumn.AllowEdit = isEditable;
            col.AutoFillDown = isFillDown;
            col.RowIndex = rowIndex;
        }

        private void repo_HLE_delete_Click(object sender, EventArgs e)
        {
            string MissionID = advBandedGridView1.GetFocusedRowCellValue(builder_Log.MissionID).ToString();
            string LogID = advBandedGridView1.GetFocusedRowCellValue(builder_Log.ID).ToString();
            if (new TechniqueLogController().DeleteByObjectID(LogID))
            {
                adapter_Log.NotifyfreshDataTable(new TechniqueLogController().FindByMissionID(MissionID));
                this.gridControl2.DataSource = adapter_Log.ResultTable;
            }
            else
                MessageBoxHelper.ShowDeleteStateDialog(false);
        }

        private void repo_HLE_gotoURL_Click(object sender, EventArgs e)
        {
            string LogUrl = advBandedGridView1.GetFocusedRowCellValue(builder_Log.LogUrl).ToString();
            if (string.IsNullOrEmpty(LogUrl))
                return;
            System.Diagnostics.Process.Start("chrome.exe", LogUrl);  
        }
    }
}
