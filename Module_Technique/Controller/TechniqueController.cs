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
    public class TechniqueController : ManageBaseController<TB_Technique>
    {

        public TechniqueController()
        {
            this.dbFactory = GParam.Create();
        }

        protected override Moon.Orm.MQLBase onCreateMQL_QueryAllEntities()
        {
            return TB_TechniqueSet.SelectAll();
        }

        protected override int onGetCurrentEntryID(TB_Technique entry)
        {
            return (int)entry.ID;
        }

        protected override Moon.Orm.WhereExpression onBlindIDWhere(TB_Technique entry)
        {
            return TB_TechniqueSet.ID.Equal(entry.ID);
        }

        protected override Moon.Orm.WhereExpression onBlindIDWhere(int entry)
        {
            return TB_TechniqueSet.ID.Equal(entry);
        }

        public static bool IsExitCatalogIDReference(int currentID)
        {
            return false;
            //return new TechniqueController().ExsitByID<TB_TechniqueSet>(currentID);
        }

        public static long ExtractID(object p)
        {
            return (p as TB_Technique).ID;
        }
    }
}
