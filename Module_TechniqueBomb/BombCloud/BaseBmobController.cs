using cn.bmob.api;
using cn.bmob.io;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechniqueMaster.Module_TechniqueBomb.BombCloud
{
    public abstract class BaseBmobController<E> where E : BmobTable, new()
    {
        public string ErrorMessage { get; protected set; }

        public string CurrentObjectID { get; set; }

        public E Entry { protected set; get; }

        public abstract BmobWindows Bomb();
       
        public abstract string GetTableName();

        public void ReleaseEntry()
        {
            CurrentObjectID = "";
            Entry = new E();
        }

        public void LoadEntry()
        {
            try
            {
                if (string.IsNullOrEmpty(CurrentObjectID))
                {
                    Entry = new E();
                }
                else
                {
                    
                    BmobQuery query = new BmobQuery();
                    query.WhereEqualTo("objectId", CurrentObjectID);
                    var task = Bomb().FindTaskAsync<E>(GetTableName(), query);
                    if (task.Result.results.Count == 1)
                        Entry = task.Result.results[0];
                    else
                        Entry = new E();
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
        }

        public IList<E> Travels(int limit = 10000)
        {
            IList<E> data = new List<E>();
            try
            {
                BmobQuery query = new BmobQuery();
                query.Limit(1000);
                var result = Bomb().FindTaskAsync<E>(GetTableName(), query);
                data = new List<E>(result.Result.results);
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

        public IList<E> FindByQuery(BmobQuery query, int limit = 1000)
        {
            IList<E> data = new List<E>();
            try
            {
                query.Limit(limit);
                var result = Bomb().FindTaskAsync<E>(GetTableName(), query);
                data = new List<E>(result.Result.results);
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

        public bool InsertEntry()
        {
            bool result = false;
            try
            {
                var task = Bomb().CreateTaskAsync(Entry);
                result = string.IsNullOrEmpty(task.Result.objectId) == false;
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

        public bool DeleteByObjectID(string objectID)
        {
            bool result = false;
            try
            {
                var task = Bomb().DeleteTaskAsync(GetTableName(), objectID);
                result = !task.IsFaulted;
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

        public bool UpdateEntry()
        {
            bool result = false;
            try
            {
                var task = Bomb().UpdateTaskAsync(Entry);
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

        public string FormatBmobDate(BmobDate date)
        {
            return DateTime.Parse(date.iso).ToString("yyyy-MM-dd"); 
        }
    }
}
