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
using PS.Plot.FrameBasic.Module_SupportLibs.DevExpressionTools;
using TechniqueMaster.Module_TechniqueBomb.Controller;
using TechniqueMaster.Module_TechniqueBomb.Componet.Adapter;
using PS.Plot.FrameBasic.Module_Common.Component;
using TechniqueMaster.Module_TechniqueBomb.Model;
using PS.Plot.FrameBasic.Module_System.DevExpressionTools;

namespace TechniqueMaster.Module_TechniqueBomb.View.UControl
{
    public partial class UC_TechniqueReviewEdit : DevExpress.XtraEditors.XtraUserControl, IInitialUI
    {
        private TB_TechniqueLogBuilder2 builder;
        private TB_TechniqueLogAdapter2 adapter;
        private GridControlHelper gridhelper;
        private TechniqueLogController controller;

        public UC_TechniqueReviewEdit()
        {
            InitializeComponent();
        }

        private void UC_TechniqueReviewEdit_Load(object sender, EventArgs e)
        {
            onCreateComponet();
            onInitialUI();
        }

        public void onCreateComponet()
        {
            gridhelper = new GridControlHelper(this.gridView1, this.gridControl1);
            builder = new TB_TechniqueLogBuilder2();
            adapter = new TB_TechniqueLogAdapter2();
            adapter.Initial(builder);

            gridhelper.GridControl.DataSource = builder.CreateDataTable();
            gridhelper.SetAllColumnEditable(false);
            gridhelper.SetColunmOption(builder.ID, false, false);
            gridhelper.SetColunmOption(builder.MissionID, false, false);
            gridhelper.SetColunmOption(builder.Op_Delete, false, false);
            gridhelper.SetColunmOption(builder.Op_Edit, false, false);
            gridhelper.SetColunmOption(builder.IsNeedTidy, false, false);
            gridhelper.SetColunmOption(builder.ReViewCount, false, true);
            gridhelper.SetColMaxWidth(builder.Date, 100);
            gridhelper.SetColMaxWidth(builder.Op_ReviewAdd, 100);
            gridhelper.SetColMaxWidth(builder.Op_ReviewReduce, 100);
            gridhelper.SetColMaxWidth(builder.ReViewCount, 100);

            gridhelper.SetCellResposity(builder.Op_ReviewAdd, repo_HLE_reviewadd);
            gridhelper.SetCellResposity(builder.Op_ReviewReduce, repo_HLE_reviewReduce);
            gridhelper.SetCellResposity(builder.LogUrl, repo_HLE_goto);

            controller = new TechniqueLogController();
        }

        public void onInitialUI()
        {
            listBox_Mission.Items.Clear();
            listBox_Mission.ItemHeight = 35;
            TechniqueMissionController controller_mission = new TechniqueMissionController();
            foreach (var item in controller_mission.Travels())
                listBox_Mission.Items.Add(item.ConvertToComboxItem());
            listBox_Mission.SelectedIndex = -1;
        }


        private void listBox_Mission_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox_Mission.SelectedIndex >= 0)
            {
                ComboxItem itemsupport = listBox_Mission.SelectedItem as ComboxItem;
                adapter.NotifyfreshDataTable(controller.FindByMissionID(itemsupport.Tag));
                gridhelper.UpdateTableSourceAsyn(adapter.ResultTable);
            }
        }

        private void repo_HLE_reviewadd_Click(object sender, EventArgs e)
        {
            string logID = gridhelper.GridView.GetFocusedRowCellValue(builder.ID).ToString();
            string str_reviewCount = gridhelper.GridView.GetFocusedRowCellValue(builder.ReViewCount).ToString();
            int reviewCount = string.IsNullOrEmpty(str_reviewCount) ? 0 : int.Parse(str_reviewCount);
            if (controller.AddReviewCount(logID, ref reviewCount))
            {
                gridhelper.GridView.SetFocusedRowCellValue(builder.ReViewCount, reviewCount);
                gridhelper.GridView.RefreshRow(gridhelper.GridView.FocusedRowHandle);
            }
            else
                MessageBoxHelper.ShowUpdateStateDialog(false);
        }

        private void repo_HLE_reviewReduce_Click(object sender, EventArgs e)
        {
            string logID = gridhelper.GridView.GetFocusedRowCellValue(builder.ID).ToString();
            string str_reviewCount = gridhelper.GridView.GetFocusedRowCellValue(builder.ReViewCount).ToString();
            int reviewCount = string.IsNullOrEmpty(str_reviewCount) ? 0 : int.Parse(str_reviewCount);
            if (controller.ReduceReviewCount(logID, ref reviewCount))
            {
                gridhelper.GridView.SetFocusedRowCellValue(builder.ReViewCount, reviewCount);
                gridhelper.GridView.RefreshRow(gridhelper.GridView.FocusedRowHandle);
            }
            else
                MessageBoxHelper.ShowUpdateStateDialog(false);
        }

        private void repo_HLE_goto_Click(object sender, EventArgs e)
        {
            string LogUrl = gridhelper.GridView.GetFocusedRowCellValue(builder.LogUrl).ToString();
            if (string.IsNullOrEmpty(LogUrl))
                return;
            System.Diagnostics.Process.Start("chrome.exe", LogUrl);
        }
    }
}
