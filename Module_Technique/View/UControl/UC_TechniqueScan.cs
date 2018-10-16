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
using TechniqueMaster.Module_Technique.Componet.Adapter;
using TechniqueMaster.Module_Technique.Controller;
using PS.Plot.FrameBasic.Module_Common.Interface;
using PS.Plot.FrameBasic.Module_SupportLibs.DevExpressionTools;
using PS.Plot.FrameBasic.Module_Common.Utils;
using OfficeAider.Module_Technique.Componet.Enum;
using TechniqueMaster.Module_Technique.Componet.Strategy;
using DevExpress.XtraScheduler;
using TechniqueMaster.Module_Technique.View.Frm;

namespace TechniqueMaster.Module_Technique.View.UControl
{
    public partial class UC_TechniqueScan : DevExpress.XtraEditors.XtraUserControl,IInitialUI
    {
        private TB_TechniqueBuilder builder_tech;
        private TB_TechniqueAdapter adapter_tech;
        private TechniqueController controller_tech;
        private GridControlHelper gridhelper_tech;

        private TB_TechniqueMissionAdapter adapter_mission;
        private TB_TechniqueMissionBuilder builder_mission;
        private TechniqueMisssionController controller_mission;
        private GridControlHelper gridhelper_mission;

        private TB_TechniqueLogAdapter adapter_log;
        private TB_TechniqueLogBuilder builder_log;
        private GridControlHelper gridhelper_log;
        private TechniqueLogController controller_log;

        private TechniqueEvaluationController controller_Evaluate;

        public UC_TechniqueScan()
        {
            InitializeComponent();
        }

        private void UC_TechniqueScan_Load(object sender, EventArgs e)
        {
            onCreateComponet();
            onInitialUI();
        }

        public void onCreateComponet()
        {
            builder_tech = new TB_TechniqueBuilder();
            adapter_tech = new TB_TechniqueAdapter();
            controller_tech = new TechniqueController();
            gridhelper_tech = new GridControlHelper(gridView_Technique, gridControl_Technique);

            adapter_mission = new TB_TechniqueMissionAdapter();
            builder_mission = new TB_TechniqueMissionBuilder();
            controller_mission = new TechniqueMisssionController();
            gridhelper_mission = new GridControlHelper(gridView_Mission, gridControl_Mission);

            adapter_log = new TB_TechniqueLogAdapter();
            builder_log = new TB_TechniqueLogBuilder();
            controller_log = new TechniqueLogController();
            gridhelper_log = new GridControlHelper(gridView_log, gridControl_log);

            controller_Evaluate = new TechniqueEvaluationController();
        }

        public void onInitialUI()
        {
            //技能列表
            if (adapter_tech != null)
            {
                adapter_tech.NotifyClearTable();
                adapter_tech.NotifyDestoryTable();
            }

            adapter_tech.Initial(builder_tech);
            adapter_tech.NotifyfreshDataTable(controller_tech.TravleAllEntities());

            gridhelper_tech.GridControl.DataSource = adapter_tech.ResultTable;
            gridhelper_tech.SetAllColumnEditable(false);
            gridhelper_tech.SetAllColumnVisible(false);
            gridhelper_tech.SetColunmOption(builder_tech.Name, false, true);

            //任务列表
            if (adapter_mission != null)
            {
                adapter_mission.NotifyClearTable();
                adapter_mission.NotifyDestoryTable();
            }
            adapter_mission.Initial(builder_mission);
            adapter_mission.NotifyfreshDataTable(null);
            gridhelper_mission.GridControl.DataSource = adapter_mission.ResultTable;
            gridhelper_mission.SetAllColumnEditable(false);
            gridhelper_mission.SetColunmOption(builder_mission.ID, false, false);
            gridhelper_mission.SetColunmOption(builder_mission.TechniqueID, false, false);
            gridhelper_mission.SetColunmOption(builder_mission.Op_Delete, false, false);
            gridhelper_mission.SetColunmOption(builder_mission.Op_Edit, false, false);
            gridhelper_mission.SetColMaxWidth(builder_mission.Op_Edit, 80);
            gridhelper_mission.Group(builder_mission.Status);
            gridhelper_mission.GridView.ExpandAllGroups();

            //任务日志
            if (adapter_log != null)
            {
                adapter_log.NotifyClearTable();
                adapter_log.NotifyDestoryTable();
            }
            adapter_log.Initial(builder_log);
            adapter_log.NotifyfreshDataTable(null);
            gridhelper_log.GridControl.DataSource = adapter_log.ResultTable;
            gridhelper_log.SetAllColumnEditable(false);
            gridhelper_log.SetColunmOption(builder_log.ID, false, false);
            gridhelper_log.SetColunmOption(builder_log.MissionID, false, false);
            gridhelper_log.SetColunmOption(builder_log.Op_Delete, false, false);
            gridhelper_log.SetColunmOption(builder_log.Op_Edit, false, false);
            gridhelper_log.SetColunmOption(builder_log.MissionName, false, false);
            gridhelper_log.SetColunmOption(builder_log.TechName, false, false);
            gridhelper_log.SetColMaxWidth(builder_log.Date, 120);
            gridhelper_log.SetColMaxWidth(builder_log.LogUrl, 100);

            btn_showInCanlender.Enabled = controller_tech.CurrentID != 0;
        }

        private void gridView_Technique_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            controller_tech.CurrentID = gridhelper_tech.getFocuseRowCellValue_Int(builder_tech.ID);
            controller_tech.LoadEntry();

            tv_CreateDate.Text = controller_tech.Entry.CreateDate;
            tv_Description.Text = controller_tech.Entry.Description;
            tv_Interest.Text = ""+controller_tech.Entry.Interest;
            tv_Name.Text = controller_tech.Entry.Name;
            tv_Catalog.Text = new TechniqueCatalogController().QueryEntryByID((int)controller_tech.Entry.CatalogID).Name;

            EnumUtils utils = new EnumUtils();
            controller_Evaluate.LoadEntryByTechniqueID(controller_tech.CurrentID);
            this.tv_job.Text = utils.GetEnumdescriptionByValue(typeof(JobRelation), (int)controller_Evaluate.Entry.JobRelation);
            this.tv_industry.Text = utils.GetEnumdescriptionByValue(typeof(IndustryRelation), (int)controller_Evaluate.Entry.IndustryRelation);
            this.tv_target.Text = utils.GetEnumdescriptionByValue(typeof(TargetDefinition), (int)controller_Evaluate.Entry.TargetDefinition);
            this.tv_techcatalog.Text = utils.GetEnumdescriptionByValue(typeof(TechniqueCalatog), (int)controller_Evaluate.Entry.Technique);
            this.tv_size.Text = utils.GetEnumdescriptionByValue(typeof(SystemSize), (int)controller_Evaluate.Entry.SystemSize);
            this.tv_ecology.Text = utils.GetEnumdescriptionByValue(typeof(ResourceEcology), (int)controller_Evaluate.Entry.ResourceEcology);
            this.tv_reserve.Text = utils.GetEnumdescriptionByValue(typeof(KnowledgeReserve), (int)controller_Evaluate.Entry.KnowledgeReserve);
            this.tv_learnmethod.Text = utils.GetEnumdescriptionByValue(typeof(LearnMethod), (int)controller_Evaluate.Entry.LearnMethod);
            this.tv_dirs.Text = utils.GetEnumdescriptionByValue(typeof(Dispersion), (int)controller_Evaluate.Entry.Dispersion);

            TechniqueEvalutor evaluator = new TechniqueEvalutor();
            evaluator.CreateStrategy(controller_Evaluate.Entry.EvaluationMethod);
            tv_summary.Text = "" + evaluator.Evaluate(controller_Evaluate.Entry);
            tv_result_abouns.Text = evaluator.Bonus.Sum().ToString("0.00");
            tv_Result_deduction.Text = evaluator.Deductions.Sum().ToString("0.00");

            adapter_mission.NotifyfreshDataTable(controller_mission.QueryEntriesByTechniquID(controller_tech.CurrentID));
            gridhelper_mission.GridControl.DataSource = adapter_mission.ResultTable;
            gridhelper_mission.GridView.ExpandAllGroups();
        }

        private void repo_HLE_detail_Click(object sender, EventArgs e)
        {
            string url = gridhelper_log.getFocuseRowCellValue_String(builder_log.LogUrl);
            if(string.IsNullOrEmpty(url) == false)
                System.Diagnostics.Process.Start(url);
        }

        private void gridView_Mission_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            int currentMission = gridhelper_mission.getFocuseRowCellValue_Int(builder_mission.ID);
            var items = controller_log.QueryEntiesByMissionID(currentMission);
            adapter_log.NotifyfreshDataTable(items);
            gridhelper_log.GridControl.DataSource = adapter_log.ResultTable;
        }

        private void btn_showInCanlender_Click(object sender, EventArgs e)
        {
            Frm_TechniqueDetialScheduler frm = new Frm_TechniqueDetialScheduler();
            frm.CurrentTechID = controller_tech.CurrentID;
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog();
        }


    }
}
