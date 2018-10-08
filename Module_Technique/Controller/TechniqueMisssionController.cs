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
    public class TechniqueMisssionController : ManageBaseController2<TB_TechniqueMission, TB_TechniqueMissionSet>
    {

        public TechniqueMisssionController()
        {
            this.dbFactory = GParam.Create();
        }

        protected override Moon.Orm.MQLBase onCreateMQL_QueryAllEntities()
        {
            return TB_TechniqueMissionSet.SelectAll();
        }

        protected override int onGetCurrentEntryID(TB_TechniqueMission entry)
        {
            return (int)entry.ID;
        }

        protected override Moon.Orm.WhereExpression onBlindIDWhere(TB_TechniqueMission entry)
        {
            return TB_TechniqueMissionSet.ID.Equal(onGetCurrentEntryID(entry));
        }

        protected override Moon.Orm.WhereExpression onBlindIDWhere(int entry)
        {
            return TB_TechniqueMissionSet.ID.Equal(entry);
        }

        public IList<TB_TechniqueMission> QueryEntriesByTechniquID(long TechniqueID)
        {
            using (var db = this.dbFactory.OpenDefalutDataBase())
            {
                MQLBase mql = TB_TechniqueMissionSet.SelectAll().Where(TB_TechniqueMissionSet.TechniqueID.Equal(TechniqueID));
                IList<TB_TechniqueMission> result = db.GetEntities<TB_TechniqueMission>(mql);
                if (result == null)
                    result = new List<TB_TechniqueMission>();
                return result;
            }
        }
    }
}
