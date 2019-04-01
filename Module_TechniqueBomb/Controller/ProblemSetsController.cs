using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PS.Plot.FrameBasic.Module_SupportLibs.MoonORM.Controller;
using TechniqueMaster.Module_TechniqueBomb.Model;
using TechniqueMaster.Module_System.Model;

namespace TechniqueMaster.Module_TechniqueBomb.Controller
{

	public class ProblemSetsController : ManageBaseController2<TB_ProblemSets,TB_ProblemSetsSet>
	{

		public ProblemSetsController() 
		{
			this.dbFactory = GParam.Create();
		}

		protected override Moon.Orm.MQLBase onCreateMQL_QueryAllEntities()
		{
			return TB_ProblemSetsSet.SelectAll();
		}

		protected override Moon.Orm.WhereExpression onBlindIDWhere(TB_ProblemSets entry)
		{
			return TB_ProblemSetsSet.ID.Equal(entry.ID);
		}

		protected override Moon.Orm.WhereExpression onBlindIDWhere(int entry)
		{
			return TB_ProblemSetsSet.ID.Equal(entry);
		}

		protected override int onGetCurrentEntryID(TB_ProblemSets entry)
		{
			return (int)entry.ID;
		}


        public IList<TB_ProblemSets> FindUnFinishProblem()
        {
            return TravelEntitiesByWhereCaluse(TB_ProblemSetsSet.SelectAll().Where(TB_ProblemSetsSet.FinishDate.Equal("").Or(TB_ProblemSetsSet.FinishDate.IsNull())));
        }

        protected override void onBeforeInsert(TB_ProblemSets entry)
        {
            base.onBeforeInsert(entry);
            entry.UpdateDate = FormatDateTime(DateTime.Now);
        }

        protected override void onBeforeUpdate(TB_ProblemSets entry)
        {
            base.onBeforeUpdate(entry);
            entry.UpdateDate = FormatDateTime(DateTime.Now);
        }
    }

}

