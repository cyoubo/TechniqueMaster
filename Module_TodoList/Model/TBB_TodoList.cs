using cn.bmob.io;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechniqueMaster.Module_TodoList.Model
{
    public class TBB_TodoList : BmobTable
    {
        public string GUID {get;set;}
        public string Catagory {get;set;}
        public string Description {get;set;}
        public BmobInt Importance {get;set;}
        public BmobInt Immediacy{get;set;}
        public BmobInt Size {get;set;}
        public BmobInt Difficulty{get;set;}
        public BmobDate FinishDate { get; set; }
        public string PreTodoGUID { get; set; }

        public override void readFields(BmobInput input)
        {
            base.readFields(input);
            GUID = input.getString("GUID");
            Catagory = input.getString("Catagory");
            Description = input.getString("Description");
            Importance = input.getInt("Importance");
            Immediacy = input.getInt("Immediacy");
            Size = input.getInt("Size");
            Difficulty = input.getInt("Difficulty");
            FinishDate = input.getDate("FinishDate");
            PreTodoGUID = input.getString("PreTodoGUID");
        }

        public override void write(BmobOutput output, bool all)
        {
            base.write(output, all);
            output.Put("GUID", GUID);
            output.Put("Catagory", Catagory);
            output.Put("Description", Description);
            output.Put("Importance", Importance);
            output.Put("Immediacy", Immediacy);
            output.Put("Size", Size);
            output.Put("Difficulty", Difficulty);
            output.Put("FinishDate", FinishDate);
            output.Put("PreTodoGUID", PreTodoGUID);
        }
    }
}
