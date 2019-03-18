using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using PS.Plot.FrameBasic.Module_Common.Component.Adapter;
using TechniqueMaster.Module_TechniqueBomb.Model;

namespace TechniqueMaster.Module_TechniqueBomb.Componet.Adapter
{
    public class TB_TechniqueCategoryBuilder : BaseDataTableBuilder
    {
        public readonly string ID = "ID";
        public readonly string Name = "名称";
        public readonly string Description = "描述";
        public readonly string Op_Delete = "删除";
        public readonly string Op_Edit = "编辑";
        protected override void AddDataColumn()
        {
            onCreateDataColumn(ID);
            onCreateDataColumn(Name);
            onCreateDataColumn(Description);
            onCreateDataColumn(Op_Delete);
            onCreateDataColumn(Op_Edit);
        }
    }
    public class TB_TechniqueCategoryAdapter : BaseGridControlAdapter<TB_TechniqueCategory>
    {
        public override void onCreateDataRow(ref System.Data.DataRow tempRow, BaseDataTableBuilder builder, int RowIndex, TB_TechniqueCategory t)
        {
            TB_TechniqueCategoryBuilder targetBuilder = builder as TB_TechniqueCategoryBuilder;
            tempRow[targetBuilder.ID] = t.objectId.ToString();
            tempRow[targetBuilder.Name] = t.Name;
            tempRow[targetBuilder.Description] = t.Description;
            tempRow[targetBuilder.Op_Delete] = targetBuilder.Op_Delete;
            tempRow[targetBuilder.Op_Edit] = targetBuilder.Op_Edit;
        }
    }
}
