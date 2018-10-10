using Moon.Orm;
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
    public class TechniqueLogController : ManageBaseController2<TB_TechniqueLog, TB_TechniqueLogSet>
    {
        public TechniqueLogController()
        {
            this.dbFactory = GParam.Create();
        }

        protected override Moon.Orm.MQLBase onCreateMQL_QueryAllEntities()
        {
            return TB_TechniqueLogSet.SelectAll();
        }

        protected override int onGetCurrentEntryID(TB_TechniqueLog entry)
        {
            return (int)entry.ID;
        }

        protected override Moon.Orm.WhereExpression onBlindIDWhere(TB_TechniqueLog entry)
        {
            return TB_TechniqueLogSet.ID.Equal(entry.ID);
        }

        protected override Moon.Orm.WhereExpression onBlindIDWhere(int entry)
        {
            return TB_TechniqueLogSet.ID.Equal(entry);
        }

        internal IList<TB_TechniqueLog> QueryEntryByDate(DateTime dateTime)
        {
            string datestr = FormatDate(dateTime);
            MQLBase mql = TB_TechniqueLogSet.SelectAll().Where(TB_TechniqueLogSet.Date.Equal(datestr));
            return TravelEntitiesByWhereCaluse(mql);
        }
    }
}
