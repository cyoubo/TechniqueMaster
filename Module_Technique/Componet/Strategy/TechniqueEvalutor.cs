using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechniqueMaster.Module_Technique.Model;

namespace TechniqueMaster.Module_Technique.Componet.Strategy
{
    public interface ITechniqueEvaluateStrategy
    {
        void onEvaluate(object Entry, IList<double> bonus, IList<double> deductions);
    }

    public abstract class BaseTechniqueEvaluteStrategy : ITechniqueEvaluateStrategy
    {
        public abstract void onEvaluate(object Entry, IList<double> bonus, IList<double> deductions);
        
        public abstract string StrategyName { get; }

        public override string ToString()
        {
            return StrategyName;
        }

        protected double onCacluateDeducation(int scope, long level, int count)
        {
            return (scope - scope * (level * 1.0 / count)) * -1; 
        }

        protected double onCacluateBonus(int scope, long level, int count)
        {
            return scope - scope * ((level - 1) * 1.0 / count);
        }
    }

    public class TechniqueEvalutor
    {
        public const string Strategy_Normal = MeanStrategy.strategyName;

        public ITechniqueEvaluateStrategy Strategy { get; protected set; }

        public IList<double> Bonus { get; protected set; }

        public IList<double> Deductions { get; protected set; }

        public string EvaluateResult { get; protected set; }
        
        public void CreateStrategy(string name)
        {
            switch (name)
            {
                case Strategy_Normal: Strategy = new MeanStrategy(); break;
                default: Strategy = new MeanStrategy(); break;
            }
        }

        public int Evaluate(TB_TechniqueEvaluation entry)
        {
            if(Bonus!= null)
                Bonus.Clear();
            else
                Bonus = new List<double>();
            
            if(Deductions!= null)
                Deductions.Clear();
            else
                Deductions = new List<double>();

             Strategy.onEvaluate(entry, Bonus, Deductions);

             EvaluateResult = string.Format("技术前景估分 {0:F2}，学习成本估分 {1:F2}，合计得分 {2}", Bonus.Sum(), Deductions.Sum(), (int)(Bonus.Sum() + Deductions.Sum()));
             
            return (int)(Bonus.Sum() + Deductions.Sum());
        }

        
    }
}
