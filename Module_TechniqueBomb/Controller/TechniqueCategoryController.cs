using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechniqueMaster.Module_TechniqueBomb.BombCloud;
using TechniqueMaster.Module_TechniqueBomb.Model;

namespace TechniqueMaster.Module_TechniqueBomb.Controller
{
    public class TechniqueCategoryController : BaseBmobController<TB_TechniqueCategory>
    {
        public override cn.bmob.api.BmobWindows Bomb()
        {
            return BmobIntance.Create().Bmob;
        }

        public override string GetTableName()
        {
            return "TB_TechniqueCategory";
        }

        public bool ExistSubTechnique(string objectID)
        {
            return new TechniqueController().ExsitCategoryID(objectID);
        }
    }
}
