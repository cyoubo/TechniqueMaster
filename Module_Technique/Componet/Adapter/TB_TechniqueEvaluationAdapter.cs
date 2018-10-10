using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using Moon.Orm;
using PS.Plot.FrameBasic.Module_Common.Component.Adapter;
using TechniqueMaster.Module_Technique.Model;

namespace TechniqueMaster.Module_Technique.Componet.Adapter
{
    public class TB_TechniqueEvaluationBuilder : BaseDataTableBuilder
    {
        public readonly string ID = "ID";
        public readonly string TechniqueID = "技术编号";
        public readonly string JobRelation = "工作相关性";
        public readonly string IndustryRelation = "行业相关性";
        public readonly string TargetDefinition = "目标明确性";
        public readonly string Technique = "应用类别";
        public readonly string SystemSize = "体系尺寸";
        public readonly string KnowledgeReserve = "知识储备";
        public readonly string ResourceEcology = "资源生态";
        public readonly string LearnMethod = "学习方式";
        public readonly string Dispersion = "时间离散度";
        public readonly string SummaryScope = "总计得分";
        public readonly string Op_Delete = "删除";
        public readonly string Op_Edit = "编辑";
        protected override void AddDataColumn()
        {
            onCreateDataColumn(ID);
            onCreateDataColumn(TechniqueID);
            onCreateDataColumn(JobRelation);
            onCreateDataColumn(IndustryRelation);
            onCreateDataColumn(TargetDefinition);
            onCreateDataColumn(Technique);
            onCreateDataColumn(SystemSize);
            onCreateDataColumn(KnowledgeReserve);
            onCreateDataColumn(ResourceEcology);
            onCreateDataColumn(LearnMethod);
            onCreateDataColumn(Dispersion);
            onCreateDataColumn(SummaryScope);
            onCreateDataColumn(Op_Delete);
            onCreateDataColumn(Op_Edit);
        }
    }
    public class TB_TechniqueEvaluationAdapter : BaseGridControlAdapter<TB_TechniqueEvaluation>
    {
        public override void onCreateDataRow(ref System.Data.DataRow tempRow, BaseDataTableBuilder builder, int RowIndex, TB_TechniqueEvaluation t)
        {
            TB_TechniqueEvaluationBuilder targetBuilder = builder as TB_TechniqueEvaluationBuilder;
            tempRow[targetBuilder.ID] = t.ID.ToString();
            tempRow[targetBuilder.TechniqueID] = t.TechniqueID.ToString();
            tempRow[targetBuilder.JobRelation] = t.JobRelation.ToString();
            tempRow[targetBuilder.IndustryRelation] = t.IndustryRelation.ToString();
            tempRow[targetBuilder.TargetDefinition] = t.TargetDefinition.ToString();
            tempRow[targetBuilder.Technique] = t.Technique.ToString();
            tempRow[targetBuilder.SystemSize] = t.SystemSize.ToString();
            tempRow[targetBuilder.KnowledgeReserve] = t.KnowledgeReserve.ToString();
            tempRow[targetBuilder.ResourceEcology] = t.ResourceEcology.ToString();
            tempRow[targetBuilder.LearnMethod] = t.LearnMethod.ToString();
            tempRow[targetBuilder.Dispersion] = t.Dispersion.ToString();
            tempRow[targetBuilder.SummaryScope] = t.SummaryScope.ToString();
            tempRow[targetBuilder.Op_Delete] = targetBuilder.Op_Delete;
            tempRow[targetBuilder.Op_Edit] = targetBuilder.Op_Edit;
        }
    }
}
