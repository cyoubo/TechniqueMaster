using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PS.Plot.FrameBasic.Module_Common.Interface;
using TechniqueMaster.Module_TechniqueBomb.Componet.Adapter;
using DevExpress.XtraGrid.Views.BandedGrid;
using PS.Plot.FrameBasic.Module_System.DevExpressionTools;
using TechniqueMaster.Module_TechniqueBomb.Controller;

namespace TechniqueMaster.Module_TechniqueBomb.View.UControl
{
    public partial class UC_TechniqueReviewInvertedEdit : DevExpress.XtraEditors.XtraUserControl, IInitialUI
    {
        private TB_TechniqueLogAdapter2 adapter_Log;
        private TB_TechniqueLogBuilder2 builder_Log;
        private TechniqueLogController controller;

        public UC_TechniqueReviewInvertedEdit()
        {
            InitializeComponent();
        }
        private void UC_TechniqueReviewInvertedEdit_Load(object sender, EventArgs e)
        {
            onCreateComponet();
            onInitialUI();
        }

        public void onCreateComponet()
        {
            adapter_Log = new TB_TechniqueLogAdapter2();
            builder_Log = new TB_TechniqueLogBuilder2();
            adapter_Log.Initial(builder_Log);

            this.gridControl1.DataSource = builder_Log.CreateDataTable();

            GridBand band_Date = new GridBand() { Caption = "日期" };
            GridBand band_Info = new GridBand() { Caption = "信息" };
            GridBand band_Op = new GridBand() { Caption = "操作" };
            GridBand band_ID = new GridBand() { Caption = "ID", Visible = false };
            this.advBandedGridView1.Bands.Clear();
            this.advBandedGridView1.Bands.AddRange(new GridBand[] { band_ID, band_Date, band_Info, band_Op });


            BandedGridColumn col_Date = new BandedGridColumn { FieldName = builder_Log.Date, Visible = true };
            BandedGridColumn col_Context = new BandedGridColumn { FieldName = builder_Log.Context, Visible = true };
            BandedGridColumn col_Url = new BandedGridColumn { FieldName = builder_Log.LogUrl, Visible = true };
            BandedGridColumn col_Op_ReviewAdd = new BandedGridColumn { FieldName = builder_Log.Op_ReviewAdd, Visible = true };
            BandedGridColumn col_Op_ReviewReduce = new BandedGridColumn { FieldName = builder_Log.Op_ReviewReduce, Visible = true };
            BandedGridColumn col_ID = new BandedGridColumn { FieldName = builder_Log.ID, Visible = false };

            UpdateColumnOption(col_Date, band_Date, false, true, 0);
            UpdateColumnOption(col_Context, band_Info, false, false, 0);
            UpdateColumnOption(col_Url, band_Info, false, false, 1);
            UpdateColumnOption(col_Op_ReviewAdd, band_Op, false, true, 0);
            UpdateColumnOption(col_Op_ReviewReduce, band_Op, false, true, 1);
            UpdateColumnOption(col_ID, band_ID, false, true, 0);

            advBandedGridView1.OptionsView.ColumnAutoWidth = true;
            advBandedGridView1.OptionsView.ShowBands = false;
            advBandedGridView1.RowHeight = 35;
            advBandedGridView1.OptionsView.ShowColumnHeaders = false;
            band_Date.OptionsBand.FixedWidth = true;
            band_Op.OptionsBand.FixedWidth = true;

            this.advBandedGridView1.Columns[builder_Log.Op_ReviewReduce].ColumnEdit = repo_HLE_ReviewReduce;
            this.advBandedGridView1.Columns[builder_Log.Op_ReviewReduce].OptionsColumn.AllowEdit = true;

            this.advBandedGridView1.Columns[builder_Log.LogUrl].ColumnEdit = repo_HLE_gotoURL;
            this.advBandedGridView1.Columns[builder_Log.LogUrl].OptionsColumn.AllowEdit = true;

            this.advBandedGridView1.Columns[builder_Log.Op_ReviewAdd].ColumnEdit = repo_HLE_ReviewAdd;
            this.advBandedGridView1.Columns[builder_Log.Op_ReviewAdd].OptionsColumn.AllowEdit = true;

            controller = new TechniqueLogController();
        }

        public void onInitialUI()
        {
            adapter_Log.NotifyfreshDataTable(controller.FindLogInvertedData(int.Parse(tv_count.Text)));
            this.gridControl1.DataSource = adapter_Log.ResultTable;
        }

        private void UpdateColumnOption(BandedGridColumn col, GridBand Owner, bool isEditable = false, bool isFillDown = false, int rowIndex = 0)
        {
            col.OwnerBand = Owner;
            col.OptionsColumn.AllowEdit = isEditable;
            col.AutoFillDown = isFillDown;
            col.RowIndex = rowIndex;
        }

        private void repo_HLE_gotoURL_Click(object sender, EventArgs e)
        {
            string LogUrl = advBandedGridView1.GetFocusedRowCellValue(builder_Log.LogUrl).ToString();
            if (string.IsNullOrEmpty(LogUrl))
                return;
            System.Diagnostics.Process.Start("chrome.exe", LogUrl);
        }

        private void repo_HLE_ReviewAdd_Click(object sender, EventArgs e)
        {
            string logID = advBandedGridView1.GetFocusedRowCellValue(builder_Log.ID).ToString();
            string str_reviewCount = advBandedGridView1.GetFocusedRowCellValue(builder_Log.ReViewCount).ToString();
            int reviewCount = string.IsNullOrEmpty(str_reviewCount) ? 0 : int.Parse(str_reviewCount);
            if (controller.AddReviewCount(logID, ref reviewCount))
            {
                advBandedGridView1.SetFocusedRowCellValue(builder_Log.ReViewCount, reviewCount);
                advBandedGridView1.RefreshRow(advBandedGridView1.FocusedRowHandle);
            }
            else
                MessageBoxHelper.ShowUpdateStateDialog(false);
        }

        private void repo_HLE_ReviewReduce_Click(object sender, EventArgs e)
        {
            string logID = advBandedGridView1.GetFocusedRowCellValue(builder_Log.ID).ToString();
            string str_reviewCount = advBandedGridView1.GetFocusedRowCellValue(builder_Log.ReViewCount).ToString();
            int reviewCount = string.IsNullOrEmpty(str_reviewCount) ? 0 : int.Parse(str_reviewCount);
            if (controller.ReduceReviewCount(logID, ref reviewCount))
            {
                advBandedGridView1.SetFocusedRowCellValue(builder_Log.ReViewCount, reviewCount);
                advBandedGridView1.RefreshRow(advBandedGridView1.FocusedRowHandle);
            }
            else
                MessageBoxHelper.ShowUpdateStateDialog(false);
        }

        private void btn_reduceTen_Click(object sender, EventArgs e)
        {
            int newCount = int.Parse(tv_count.Text) - 10;
            if(newCount >0)
            {
                tv_count.Text = "" + newCount;
                onInitialUI();
            }
            else
                MessageBoxHelper.ShowDialog("提示", "至少需要回顾10条记录");
        }

        private void btn_plusTen_Click(object sender, EventArgs e)
        {
            int newCount = int.Parse(tv_count.Text) + 10;
            if (newCount <= 50)
            {
                tv_count.Text = "" + newCount;
                onInitialUI();
            }
            else
                MessageBoxHelper.ShowDialog("提示", "默认只允许查看最新的50条记录");
        }
    }
}
