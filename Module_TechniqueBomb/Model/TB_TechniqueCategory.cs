using cn.bmob.io;
using PS.Plot.FrameBasic.Module_Common.Component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechniqueMaster.Module_TechniqueBomb.Model
{
    public class TB_TechniqueCategory : BmobTable,IComboxItemSupport
    {
        public TB_TechniqueCategory()
        {

        }

        public string Name { get; set; }

        public string Description { get; set; }

        public override void readFields(BmobInput input)
        {
            base.readFields(input);

            Name = input.getString("Name");
            Description = input.getString("Description");
        }

        public override void write(BmobOutput output, bool all)
        {
            base.write(output, all);

            output.Put("Name", Name);
            output.Put("Description", Description);
        }

        public ComboxItem ConvertToComboxItem()
        {
            return new ComboxItem() { Text = Name, Tag = objectId };
        }
    }
}
