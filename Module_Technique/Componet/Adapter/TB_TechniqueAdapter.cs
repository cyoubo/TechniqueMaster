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
            onCreateDataColumn(Interest);
            onCreateDataColumn(Op_Delete);
            onCreateDataColumn(Op_Edit);
            onCreateDataColumn(Op_Detail);
        }
    }

    public class TB_TechniqueBuilder2 : TB_TechniqueBuilder
    {
        public readonly string CatalogName = "类别名称";

        protected override void AddDataColumn()
        {
            base.AddDataColumn();
            onCreateDataColumn(CatalogName);
        }
    }

    public class TB_TechniqueAdapter : ScanGridControlAdapter<TB_Technique>
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
            tempRow[targetBuilder.Interest] = t.Interest.ToString();
            tempRow[targetBuilder.Op_Delete] = targetBuilder.Op_Delete;
            tempRow[targetBuilder.Op_Edit] = targetBuilder.Op_Edit;
            tempRow[targetBuilder.Op_Detail] = targetBuilder.Op_Detail;
        }
    }

    public class TB_TechniqueAdapter2 : TB_TechniqueAdapter
    {
        public override void onPrepareCreated(System.Data.DataTable m_ResultTable, BaseDataTableBuilder m_TableBuilder)
        {
            base.onPrepareCreated(m_ResultTable, m_TableBuilder);
            foreach (var item in new TechniqueMaster.Module_Technique.Controller.TechniqueCatalogController().TravleAllEntities())
                AddTempParams(""+item.ID, item.Name);
        }

        public override void onCreateDataRow(ref System.Data.DataRow tempRow, BaseDataTableBuilder builder, int RowIndex, TB_Technique t)
        {
            base.onCreateDataRow(ref tempRow, builder, RowIndex, t);
            if (builder is TB_TechniqueBuilder2)
            {
                tempRow[(builder as TB_TechniqueBuilder2).CatalogName] = m_TempParams["" + t.CatalogID];
            }
        }

        public override void onFinishRowsCreated(System.Data.DataTable m_ResultTable)
        {
            base.onFinishRowsCreated(m_ResultTable);
            m_TempParams.Clear();
        }
    }
}
