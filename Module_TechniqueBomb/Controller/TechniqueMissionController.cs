using cn.bmob.http;
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
            BmobQuery query = new BmobQuery();
            query.WhereGreaterThanOrEqualTo("FinishDate", InvailDate);
            query.Limit(1000);
            return FindByQuery(query);
        }

        public IList<TB_TechniqueMission> FindMissionByTechniqueID(string TechniqueID)
        {
            BmobQuery query = new BmobQuery();
            query.WhereEqualTo("TechniqueID", TechniqueID);
            return FindByQuery(query);
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

        public void TravelAsyn(BmobCallback<cn.bmob.response.QueryCallbackData<TB_TechniqueMission>> callback)
        {
            //创建一个BmobQuery查询对象
            BmobQuery query = new BmobQuery();
            BmobIntance.Create().Bmob.Find<TB_TechniqueMission>("TB_TechniqueMission", query, callback);
        }
    }
}
