using cn.bmob.exception;
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

        public bool ExsitLogID(string missionID)
        {
            BmobQuery query = new BmobQuery();
            query.WhereEqualTo("MissionID", missionID);
            return FindByQuery(query, 2).Count != 0;
        }

        public IList<TB_TechniqueLog> FindByMissionID(string missionID, bool SortDatedesc = true)
        {
            BmobQuery query = new BmobQuery();
            query.WhereEqualTo("MissionID", missionID);
            query.OrderByDescending("Date");
            return FindByQuery(query);
        }

        public IList<TB_TechniqueLog> FindLogInvertedData(int limit)
        {
            BmobQuery query = new BmobQuery();
            query.OrderByDescending("Date");
            return FindByQuery(query, limit);
        }

        public void FindByMissionIDAsyn(string missionID, BmobCallback<cn.bmob.response.QueryCallbackData<TB_TechniqueLog>> callback)
        {
            //创建一个BmobQuery查询对象
            BmobQuery query = new BmobQuery();
            query.WhereEqualTo("MissionID", missionID);
            BmobIntance.Create().Bmob.Find<TB_TechniqueLog>("TB_TechniqueLog", query, callback);
        }

        public void TravelAsyn(BmobCallback<cn.bmob.response.QueryCallbackData<TB_TechniqueLog>> callback)
        {
            //创建一个BmobQuery查询对象
            BmobQuery query = new BmobQuery();
            BmobIntance.Create().Bmob.Find<TB_TechniqueLog>("TB_TechniqueLog", query, callback);
        }

        public bool AddReviewCount(string logID,ref int reviewCount)
        {
            bool result = false;
            try
            {
                reviewCount = reviewCount + 1;
                TB_TechniqueLog temp = new TB_TechniqueLog();
                temp.ReViewCount = reviewCount;
                temp.objectId = logID;
                var task = Bomb().UpdateTaskAsync(temp);
                result = string.IsNullOrEmpty(task.Result.updatedAt) == false;
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

        public bool ReduceReviewCount(string logID, ref int reviewCount)
        {
            bool result = false;
            try
            {
                reviewCount = reviewCount - 1;
                if (reviewCount < 0)
                    reviewCount = 0;
                TB_TechniqueLog temp = new TB_TechniqueLog();
                temp.ReViewCount = reviewCount;
                temp.objectId = logID;
                var task = Bomb().UpdateTaskAsync(temp);
                result = string.IsNullOrEmpty(task.Result.updatedAt) == false;
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


    }
}
