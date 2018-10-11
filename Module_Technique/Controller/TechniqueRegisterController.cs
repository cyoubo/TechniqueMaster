using PS.Plot.FrameBasic.Module_SupportLibs.MoonORM.Controller;
using TechniqueMaster.Module_Technique.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechniqueMaster.Module_System.Model;

namespace TechniqueMaster.Module_Technique.Controller
{
    public class TechniqueRegisterController : ManageBaseController2<TB_TechniqueRegister,TB_TechniqueRegisterSet>
    {
        public TechniqueRegisterController()
        {
            this.dbFactory = GParam.Create();
        }

        protected override Moon.Orm.MQLBase onCreateMQL_QueryAllEntities()
        {
            return TB_TechniqueRegisterSet.SelectAll();
        }

        protected override int onGetCurrentEntryID(TB_TechniqueRegister entry)
        {
            return (int)entry.ID;
        }

        protected override Moon.Orm.WhereExpression onBlindIDWhere(TB_TechniqueRegister entry)
        {
            return TB_TechniqueRegisterSet.ID.Equal(onGetCurrentEntryID(entry));
        }

        protected override Moon.Orm.WhereExpression onBlindIDWhere(int entry)
        {
            return TB_TechniqueRegisterSet.ID.Equal(entry);
        }

        public IList<TB_TechniqueRegister> QueryEntryByTechniqueID(long targetID)
        {
            Moon.Orm.MQLBase mql = TB_TechniqueRegisterSet.SelectAll();
            Moon.Orm.WhereExpression express = TB_TechniqueRegisterSet.TechniqueID.Equal(targetID);
            return TravelEntitiesByWhereCaluse(mql.Where(express));
        }
    }
}
