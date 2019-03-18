using cn.bmob.io;
using PS.Plot.FrameBasic.Module_Common.Component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechniqueMaster.Module_TechniqueBomb.Model
{
    public class TB_TechniqueMission : BmobTable,IComboxItemSupport
    {
        public string TechniqueID { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public BmobDate CreateDate { get; set; }

        public BmobDate FinishDate { get; set; }

        public override void readFields(BmobInput input)
        {
            base.readFields(input);

            TechniqueID = input.getString("TechniqueID");
            Name = input.getString("Name");
            Description = input.getString("Description");
            CreateDate = input.getDate("CreateDate");
            FinishDate = input.getDate("FinishDate");
        }

        public override void write(BmobOutput output, bool all)
        {
            base.write(output, all);

            output.Put("TechniqueID", TechniqueID);
            output.Put("Name", Name);
            output.Put("Description", Description);
            output.Put("CreateDate", CreateDate);
            output.Put("TechniqueID", TechniqueID);
            output.Put("CreateDate", CreateDate);
            output.Put("FinishDate", FinishDate);
        }

        public ComboxItem ConvertToComboxItem()
        {
            return new ComboxItem() { Text = Name, Tag = objectId };
        }

        public void InvalidateFinishDate()
        {
            if (FinishDate != null)
            {
                FinishDate = DateTime.Parse(FinishDate.iso).AddYears(1000);
            }
           
        }

        public bool IsInvailDate()
        {
            return FinishDate == null || DateTime.Parse(FinishDate.iso).Year > 2200;
        }
    }
}
