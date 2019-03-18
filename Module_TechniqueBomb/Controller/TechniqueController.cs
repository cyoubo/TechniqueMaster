using cn.bmob.io;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechniqueMaster.Module_TechniqueBomb.BombCloud;
using TechniqueMaster.Module_TechniqueBomb.Model;

namespace TechniqueMaster.Module_TechniqueBomb.Controller
{
    public class TechniqueController : BaseBmobController<TB_Technique>
    {
        public override cn.bmob.api.BmobWindows Bomb()
        {
            return BombCloud.BmobIntance.Create().Bmob;
        }

        public override string GetTableName()
        {
            return "TB_Technique";
        }

        public bool ExsitCategoryID(string objectID)
        {
            bool result = false;
            try
            {
                BmobQuery query = new BmobQuery();
                query.WhereEqualTo("CatalogID",objectID);
                query.Count();
                var task = Bomb().FindTaskAsync<TB_Technique>(GetTableName(),query);
                result = task.Result.count.Get() != 0;
            }
            catch (AggregateException ex)
            {
                ErrorMessage = ex.InnerException.Message;
            }
            catch (Exception ex2)
            {
                ErrorMessage = ex2.Message;
            }
            return result;
        }

        internal bool ExistSubTechniqueLog(string p)
        {
            return true;
        }


    }
}
