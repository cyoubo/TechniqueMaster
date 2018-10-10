using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using Moon.Orm;
using PS.Plot.FrameBasic.Module_Common.Component.Adapter;
using TechniqueMaster.Module_Technique.Model;

namespace TechniqueMaster.Module_Technique.Componet.Adapter
{
    public class TB_TechniqueBuilder : BaseDataTableBuilder
    {
        public readonly string ID = "ID";
        public readonly string Name = "名称";
        public readonly string CatalogID = "类别ID";
        public readonly string Description = "描述";
        public readonly string Status = "状态";
        public readonly string CreateDate = "创建日期";
        public readonly string StartDate = "开始日期";
        public readonly string PauseDate = "暂停日期";
        public readonly string FinishDate = "完成日期";
        public readonly string AbandonDate = "终止日期";
        public readonly string Interest = "兴趣度";
        public readonly string Op_Delete = "删除";
        public readonly string Op_Edit = "编辑";
        public readonly string Op_Detail = "详情";
        protected override void AddDataColumn()
        {
            onCreateDataColumn(ID);
            onCreateDataColumn(Name);
            onCreateDataColumn(CatalogID);
            onCreateDataColumn(Description);
            onCreateDataColumn(Status);
            onCreateDataColumn(CreateDate);
            onCreateDataColumn(StartDate);
            onCreateDataColumn(PauseDate);
            onCreateDataColumn(FinishDate);
            onCreateDataColumn(AbandonDate);
            onCreateDataColumn(Interest);
            onCreateDataColumn(Op_Delete);
            onCreateDataColumn(Op_Edit);
            onCreateDataColumn(Op_Detail);
        }
    }
    public class TB_TechniqueAdapter : BaseGridControlAdapter<TB_Technique>
    {
        public override void onCreateDataRow(ref System.Data.DataRow tempRow, BaseDataTableBuilder builder, int RowIndex, TB_Technique t)
        {
            TB_TechniqueBuilder targetBuilder = builder as TB_TechniqueBuilder;
            tempRow[targetBuilder.ID] = t.ID.ToString();
            tempRow[targetBuilder.Name] = t.Name;
            tempRow[targetBuilder.CatalogID] = t.CatalogID.ToString();
            tempRow[targetBuilder.Description] = t.Description;
            tempRow[targetBuilder.Status] = t.Status;
            tempRow[targetBuilder.CreateDate] = t.CreateDate;
            tempRow[targetBuilder.StartDate] = t.StartDate;
            tempRow[targetBuilder.PauseDate] = t.PauseDate;
            tempRow[targetBuilder.FinishDate] = t.FinishDate;
            tempRow[targetBuilder.AbandonDate] = t.AbandonDate;
            tempRow[targetBuilder.Interest] = t.Interest.ToString();
            tempRow[targetBuilder.Op_Delete] = targetBuilder.Op_Delete;
            tempRow[targetBuilder.Op_Edit] = targetBuilder.Op_Edit;
            tempRow[targetBuilder.Op_Detail] = targetBuilder.Op_Detail;
        }
    }
}
