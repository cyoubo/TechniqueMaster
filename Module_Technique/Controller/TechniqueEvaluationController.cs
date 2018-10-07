using PS.Plot.FrameBasic.Module_SupportLibs.MoonORM.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechniqueMaster.Module_System.Model;
using TechniqueMaster.Module_Technique.Model;

namespace TechniqueMaster.Module_Technique.Controller
{
    public class TechniqueEvaluationController : ManageBaseController<TB_TechniqueEvaluation>
    {

        public TechniqueEvaluationController()
        {
            this.dbFactory = GParam.Create();
        }

        protected override Moon.Orm.MQLBase onCreateMQL_QueryAllEntities()
        {
            return TB_TechniqueEvaluationSet.SelectAll();
        }

        protected override int onGetCurrentEntryID(TB_TechniqueEvaluation entry)
        {
            return (int)entry.ID;
        }

        protected override Moon.Orm.WhereExpression onBlindIDWhere(TB_TechniqueEvaluation entry)
        {
            return TB_TechniqueEvaluationSet.ID.Equal(onGetCurrentEntryID(entry));
        }

        protected override Moon.Orm.WhereExpression onBlindIDWhere(int entry)
        {
            return TB_TechniqueEvaluationSet.ID.Equal(entry);
        }

        public void LoadEntryByTechniqueID(int p)
        {
            using (var db = this.dbFactory.OpenDefalutDataBase())
            {
                entry = db.GetEntity<TB_TechniqueEvaluation>(TB_TechniqueEvaluationSet.SelectAll().Where
                    (TB_TechniqueEvaluationSet.TechniqueID.Equal(p)));
                if (entry == null)
                    entry = new TB_TechniqueEvaluation();
            }
        }
    }
}
