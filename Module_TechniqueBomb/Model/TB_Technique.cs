using cn.bmob.io;
using PS.Plot.FrameBasic.Module_Common.Component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechniqueMaster.Module_TechniqueBomb.Model
{
    public class TB_Technique : BmobTable, IComboxItemSupport
    {
        public string Name { get; set; }

        public string CatalogID { get; set; }

        public string Description { get; set; }

        public string Status { get; set; }

        public BmobDate CreateDate { get; set; }

        public BmobInt Interest { get; set; }
        

        public override void readFields(BmobInput input)
        {
            base.readFields(input);

            Name = input.getString("Name");
            CatalogID = input.getString("CatalogID");
            Description = input.getString("Description");
            Status = input.getString("Status");
            CreateDate = input.getDate("CreateDate");
            Interest = input.getInt("Interest");
        }

        public override void write(BmobOutput output, bool all)
        {
            base.write(output, all);

            output.Put("Name", Name);
            output.Put("CatalogID", CatalogID);
            output.Put("Description", Description);
            output.Put("Status", Status);
            output.Put("CreateDate", CreateDate);
            output.Put("Interest", Interest);
        }

        public override string ToString()
        {
            return Name;
        }

        public ComboxItem ConvertToComboxItem()
        {
            return new ComboxItem() { Text = Name, Tag = objectId };
        }
    }
}
