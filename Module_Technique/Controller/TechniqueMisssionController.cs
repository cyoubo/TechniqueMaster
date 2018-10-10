using Moon.Orm;
using PS.Plot.FrameBasic.Module_Common.Utils;
using PS.Plot.FrameBasic.Module_SupportLibs.MoonORM.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechniqueMaster.Module_System.Model;
using TechniqueMaster.Module_Technique.Componet.Enum;
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
            MQLBase mql = TB_TechniqueMissionSet.SelectAll().Where(TB_TechniqueMissionSet.TechniqueID.Equal(TechniqueID));
            return TravelEntitiesByWhereCaluse(mql);
        }

        public IList<TB_TechniqueMission> QueryEntriesByTechniquIDWithUnFinishState(long TechniqueID)
        {
            string FinishStr = new EnumUtils().GetEnumdescription(MissionStatusEnum.Finish);
            WhereExpression ex = TB_TechniqueMissionSet.TechniqueID.Equal(TechniqueID).And(TB_TechniqueMissionSet.Status.NotEqual(FinishStr));
            return TravelEntitiesByWhereCaluse(TB_TechniqueMissionSet.SelectAll().Where(ex));
        }

        internal static long ExtractID(object p)
        {
            return (p as TB_TechniqueMission).ID;
        }
    }
}
