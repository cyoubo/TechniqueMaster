using PS.Plot.FrameBasic.Module_SupportLibs.MoonORM.Controller;
using TechniqueMaster.Module_Technique.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechniqueMaster.Module_System.Model;
using Moon.Orm;
using PS.Plot.FrameBasic.Module_Common.Utils;
using TechniqueMaster.Module_Technique.Componet.Enum;

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

        public IList<TB_Technique> TravleUnFinishEntities()
        {
            EnumUtils utils = new EnumUtils();
            string createStr = utils.GetEnumdescription(TechniqueStatusEnum.Create);
            string doingStr = utils.GetEnumdescription(TechniqueStatusEnum.Start);
            MQLBase mql = TB_TechniqueSet.SelectAll();
            WhereExpression expression = TB_TechniqueSet.Status.Equal(createStr).Or(TB_TechniqueSet.Status.Equal(doingStr));
            mql.Where(expression);
            return TravelEntitiesByWhereCaluse(mql);
        }

        public bool ShiftTechStatus(long targetID, TechniqueStatusEnum techniqueStatusEnum)
        {
            TB_Technique tech = QueryEntryByID((int)targetID);
            tech.Status = new EnumUtils().GetEnumdescription(techniqueStatusEnum);
            tech.WhereExpression = TB_TechniqueSet.ID.Equal(targetID);
            return UpdateEntryByID(tech);
        }
    }
}
