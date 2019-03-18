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
    public class TechniqueLogController : BaseBmobController<TB_TechniqueLog>
    {
        public override cn.bmob.api.BmobWindows Bomb()
        {
            return BmobIntance.Create().Bmob;
        }

        public override string GetTableName()
        {
            return "TB_TechniqueLog";
        }

        public bool BatchInsert(IList<TB_TechniqueLog> list)
        {
            bool result = false;
            try
            {
                foreach (var item in list)
                {
                    var task = Bomb().CreateTaskAsync(item);
                    result = string.IsNullOrEmpty(task.Result.objectId) == false;
                }
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

        public IList<TB_TechniqueLog> FindLogBetweenDate(DateTime start, DateTime end)
        {
            BmobDate st = start;
            BmobDate ed = end;

            BmobQuery query = new BmobQuery();
            query.WhereGreaterThanOrEqualTo("Date",  st);
            query.WhereLessThanOrEqualTo("Date", ed);
            return FindByQuery(query);
        }
    }
}
