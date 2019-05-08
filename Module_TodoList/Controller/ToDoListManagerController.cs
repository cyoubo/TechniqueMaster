using PS.Plot.FrameBasic.Module_SupportLibs.MoonORM.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TTechniqueMaster.Module_TodoList.Model;

namespace TechniqueMaster.Module_TodoList.Controller
{
    public class ToDoListManagerController : ManageGUIDController<TB_TodoList,TB_TodoListSet>
    {

        protected override string onGetCurrentEntryID(TB_TodoList entry)
        {
            return entry.GUID;
        }

        protected override Moon.Orm.WhereExpression onBlindIDWhere(TB_TodoList entry)
        {
            return TB_TodoListSet.GUID.Equal(entry.GUID);
        }

        protected override Moon.Orm.WhereExpression onBlindIDWhere(string entry)
        {
            return TB_TodoListSet.GUID.Equal(entry);
        }

        protected override Moon.Orm.MQLBase onCreateMQL_QueryEntryByID(string CurrentID)
        {
            return TB_TodoListSet.SelectAll().Where(onBlindIDWhere(CurrentGUID));
        }

        protected override Moon.Orm.MQLBase onCreateMQL_QueryAllEntities()
        {
            return TB_TodoListSet.SelectAll();
        }
    }
}
