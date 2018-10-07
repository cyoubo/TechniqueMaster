using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechniqueMaster.Module_Technique.Model;

namespace TechniqueMaster.Module_Technique.Componet.Strategy
{
    public class MeanStrategy : BaseTechniqueEvaluteStrategy
    {
        public const string strategyName = "均值计算";

        public override string StrategyName
        {
            get { return strategyName; }
        }

        public override void onEvaluate(object Entry, IList<double> bonus, IList<double> deductions)
        {
            TB_TechniqueEvaluation entry = Entry as TB_TechniqueEvaluation;
            //先计算得分项目
            bonus.Add(onCacluateBonus(25, entry.JobRelation, 3));
            bonus.Add(onCacluateBonus(25, entry.IndustryRelation, 3));
            bonus.Add(onCacluateBonus(25, entry.TargetDefinition, 3));
            bonus.Add(onCacluateBonus(25, entry.Technique, 3));
            //计算扣分项目
            deductions.Add(onCacluateDeducation(20, entry.SystemSize, 3));
            deductions.Add(onCacluateDeducation(20, entry.KnowledgeReserve, 4));
            deductions.Add(onCacluateDeducation(20, entry.ResourceEcology, 3));
            deductions.Add(onCacluateDeducation(20, entry.LearnMethod, 3));
            deductions.Add(onCacluateDeducation(20, entry.Dispersion, 3));
        }
    }
}
