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

namespace TechniqueMaster.Module_Technique.View.UControl
{
    public partial class UC_TechniqueScan : DevExpress.XtraEditors.XtraUserControl,IInitialUI
    {
        private TB_TechniqueBuilder builder_tech;
        private TB_TechniqueAdapter adapter_tech;
        private TechniqueController controller_tech;
        private GridControlHelper gridhelper_tech;

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

            controller_Evaluate = new TechniqueEvaluationController();
        }

        public void onInitialUI()
        {
            if (adapter_tech != null)
            {
                adapter_tech.NotifyClearTable();
                adapter_tech.NotifyDestoryTable();
            }

            adapter_tech.Initial(controller_tech.TravleAllEntities(), builder_tech);
            adapter_tech.NotifyfreshDataTable();

            gridhelper_tech.GridControl.DataSource = adapter_tech.ResultTable;
            gridhelper_tech.SetAllColumnEditable(false);
            gridhelper_tech.SetAllColumnVisible(false);
            gridhelper_tech.SetColunmOption(builder_tech.Name, false, true);
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
            //this.tv_job.Text = utils.GetEnumdescriptionByValue(typeof(JobRelation), (int)controller_Evaluate.Entry.JobRelation);
            //this.tv_industry.Text = utils.GetEnumdescriptionByValue(typeof(IndustryRelation), (int)controller_Evaluate.Entry.IndustryRelation);
            //this.tv_target.Text = utils.GetEnumdescriptionByValue(typeof(TargetDefinition), (int)controller_Evaluate.Entry.TargetDefinition);
            //this.tv_techcatalog.Text = utils.GetEnumdescriptionByValue(typeof(TechniqueCalatog), (int)controller_Evaluate.Entry.Technique);
            //this.tv_size.Text = utils.GetEnumdescriptionByValue(typeof(SystemSize), (int)controller_Evaluate.Entry.SystemSize);
            //this.tv_ecology.Text = utils.GetEnumdescriptionByValue(typeof(ResourceEcology), (int)controller_Evaluate.Entry.ResourceEcology);
            //this.tv_reserve.Text = utils.GetEnumdescriptionByValue(typeof(KnowledgeReserve), (int)controller_Evaluate.Entry.KnowledgeReserve);
            //this.tv_learnmethod.Text = utils.GetEnumdescriptionByValue(typeof(LearnMethod), (int)controller_Evaluate.Entry.LearnMethod);
            //this.tv_dirs.Text = utils.GetEnumdescriptionByValue(typeof(Dispersion), (int)controller_Evaluate.Entry.Dispersion);

            TechniqueEvalutor evaluator = new TechniqueEvalutor();
            evaluator.CreateStrategy(controller_Evaluate.Entry.EvaluationMethod);
            tv_summary.Text = "" + evaluator.Evaluate(controller_Evaluate.Entry);
            tv_result_abouns.Text = evaluator.Bonus.Sum().ToString("0.00");
            tv_Result_deduction.Text = evaluator.Deductions.Sum().ToString("0.00");
        }


    }
}
