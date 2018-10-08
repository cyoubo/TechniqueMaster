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
    public class TechniqueLogController : ManageBaseController2<TB_TechniqueMission, TB_TechniqueMissionSet>
    {
        public TechniqueLogController()
        {
            this.dbFactory = GParam.Create();
        }

        protected override Moon.Orm.MQLBase onCreateMQL_QueryAllEntities()
        {
            return TB_TechniqueLogSet.SelectAll();
        }

        protected override int onGetCurrentEntryID(TB_TechniqueMission entry)
        {
            return (int)entry.ID;
        }

        protected override Moon.Orm.WhereExpression onBlindIDWhere(TB_TechniqueMission entry)
        {
            return TB_TechniqueLogSet.ID.Equal(entry.ID);
        }

        protected override Moon.Orm.WhereExpression onBlindIDWhere(int entry)
        {
            return TB_TechniqueLogSet.ID.Equal(entry);
        }
    }
}
