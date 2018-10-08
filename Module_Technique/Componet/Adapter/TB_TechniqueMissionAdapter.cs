using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using Moon.Orm;
using PS.Plot.FrameBasic.Module_Common.Component.Adapter;
using TechniqueMaster.Module_Technique.Model;

namespace TechniqueMaster.Module_Technique.Componet.Adapter
{
    public class TB_TechniqueMissionBuilder : BaseDataTableBuilder
    {
        public readonly string ID = "ID";
        public readonly string TechniqueID = "TechniqueID";
        public readonly string Name = "Name";
        public readonly string Description = "Description";
        public readonly string CreateDate = "CreateDate";
        public readonly string FinishDate = "FinishDate";
        public readonly string Status = "Status";
        public readonly string Op_Delete = "删除";
        public readonly string Op_Edit = "编辑";
        protected override void AddDataColumn()
        {
            onCreateDataColumn(ID);
            onCreateDataColumn(TechniqueID);
            onCreateDataColumn(Name);
            onCreateDataColumn(Description);
            onCreateDataColumn(CreateDate);
            onCreateDataColumn(FinishDate);
            onCreateDataColumn(Status);
            onCreateDataColumn(Op_Delete);
            onCreateDataColumn(Op_Edit);
        }
    }

    public class TB_TechniqueMissionAdapter : BaseGridControlAdapter<TB_TechniqueMission>
    {
        public override void onCreateDataRow(ref System.Data.DataRow tempRow, BaseDataTableBuilder builder, int RowIndex, TB_TechniqueMission t)
        {
            TB_TechniqueMissionBuilder targetBuilder = builder as TB_TechniqueMissionBuilder;
            tempRow[targetBuilder.ID] = t.ID.ToString();
            tempRow[targetBuilder.TechniqueID] = t.TechniqueID.ToString();
            tempRow[targetBuilder.Name] = t.Name;
            tempRow[targetBuilder.Description] = t.Description;
            tempRow[targetBuilder.CreateDate] = t.CreateDate;
            tempRow[targetBuilder.FinishDate] = t.FinishDate;
            tempRow[targetBuilder.Status] = t.Status;
            tempRow[targetBuilder.Op_Delete] = targetBuilder.Op_Delete;
            tempRow[targetBuilder.Op_Edit] = targetBuilder.Op_Edit;
        }
    }
}
