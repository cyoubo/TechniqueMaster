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
    public class TechniqueMissionController : BaseBmobController<TB_TechniqueMission>
    {
        public const string Running = "进行中";
        public const string Finish = "已完成";

        public static string[] StatesArrays()
        {
            return new string[] { Running, Finish };
        }

        public override cn.bmob.api.BmobWindows Bomb()
        {
            return BmobIntance.Create().Bmob;
        }

        public override string GetTableName()
        {
            return "TB_TechniqueMission";
        }



        public IList<TB_TechniqueMission> FindUnFinishMission()
        {
            IList<TB_TechniqueMission> data = new List<TB_TechniqueMission>();
            try
            {
                BmobQuery query = new BmobQuery();
                BmobQuery query2 = new BmobQuery();
                query2.WhereEqualTo("FinishDate", null);
                query.WhereLessThan("FinishDate", InvailDate).Or(query2);
                query.Limit(1000);
                var result = Bomb().FindTaskAsync<TB_TechniqueMission>(GetTableName(), query);
                data = new List<TB_TechniqueMission>(result.Result.results);
            }
            catch (AggregateException ex)
            {
                ErrorMessage = ex.InnerException.Message;
            }
            catch (Exception ex2)
            {
                ErrorMessage = ex2.Message;
            }
            return data;
        }

        public IList<TB_TechniqueMission> FindMissionByTechniqueID(string TechniqueID)
        {
            BmobQuery query = new BmobQuery();
            query.WhereEqualTo("TechniqueID", TechniqueID);
            return FindByQuery(query, 2);
        }

        public bool ExistTechniqueID(string techniqueObjectID)
        {
            BmobQuery query = new BmobQuery();
            query.WhereEqualTo("TechniqueID", techniqueObjectID);
            return FindByQuery(query, 2).Count != 0;
        }

        public bool ExistSubLog(string currentID)
        {
            return new TechniqueLogController().ExsitLogID(currentID);
        }
    }
}
