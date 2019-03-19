using cn.bmob.io;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechniqueMaster.Module_TechniqueBomb.Model
{
    public class TB_TechniqueLog : BmobTable
    {
        public string MissionID { get; set; }

        public BmobDate Date { get; set; }

        public string Context { get; set; }

        public string LogUrl { get; set; }

        public BmobBoolean IsNeedTidy { get; set; }

        public override void readFields(BmobInput input)
        {
            base.readFields(input);

            MissionID = input.getString("MissionID");
            Date = input.getDate("Date");
            Context = input.getString("Context");
            LogUrl = input.getString("LogUrl");
            IsNeedTidy = input.getBoolean("IsNeedTidy");
        }

        public override void write(BmobOutput output, bool all)
        {
            base.write(output, all);

            output.Put("MissionID", MissionID);
            output.Put("Date", Date);
            output.Put("Context", Context);
            output.Put("LogUrl", LogUrl);
            output.Put("IsNeedTidy", IsNeedTidy);
        }
    }
}
