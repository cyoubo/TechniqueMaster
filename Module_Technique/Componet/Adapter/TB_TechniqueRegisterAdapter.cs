using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using Moon.Orm;
using PS.Plot.FrameBasic.Module_Common.Component.Adapter;
using TechniqueMaster.Module_Technique.Model;
using PS.Plot.FrameBasic.Module_Common.Utils;
using TechniqueMaster.Module_Technique.Componet.Enum;

namespace TechniqueMaster.Module_Technique.Componet.Adapter
{
    public class TB_TechniqueRegisterBuilder : BaseDataTableBuilder
    {
        public readonly string ID = "ID";
        public readonly string TechniqueID = "技术编号";
        public readonly string TechniqueStatue = "变更状态";
        public readonly string Reason = "变更原因";
        public readonly string Summary = "技术整理";
        public readonly string Introspection = "反思总结";
        public readonly string Date = "变更日期";
        public readonly string Op_Delete = "删除";
        public readonly string Op_Edit = "编辑";
        protected override void AddDataColumn()
        {
            onCreateDataColumn(ID);
            onCreateDataColumn(TechniqueID);
            onCreateDataColumn(Date);
            onCreateDataColumn(TechniqueStatue);
            onCreateDataColumn(Reason);
            onCreateDataColumn(Summary);
            onCreateDataColumn(Introspection);
            onCreateDataColumn(Op_Delete);
            onCreateDataColumn(Op_Edit);
        }
    }
    public class TB_TechniqueRegisterAdapter : ScanGridControlAdapter<TB_TechniqueRegister>
    {
        private EnumUtils utils;
        public override void onPrepareCreated(System.Data.DataTable m_ResultTable, BaseDataTableBuilder m_TableBuilder)
        {
            base.onPrepareCreated(m_ResultTable, m_TableBuilder);
            utils = new EnumUtils();
        }

        public override void onCreateDataRow(ref System.Data.DataRow tempRow, BaseDataTableBuilder builder, int RowIndex, TB_TechniqueRegister t)
        {
            TB_TechniqueRegisterBuilder targetBuilder = builder as TB_TechniqueRegisterBuilder;
            tempRow[targetBuilder.ID] = t.ID.ToString();
            tempRow[targetBuilder.TechniqueID] = t.TechniqueID.ToString();
            tempRow[targetBuilder.TechniqueStatue] = utils.GetEnumdescriptionByValue(typeof(TechniqueStatusEnum), int.Parse(t.TechniqueStatue.ToString()));
            tempRow[targetBuilder.Reason] = t.Reason;
            tempRow[targetBuilder.Summary] = t.Summary;
            tempRow[targetBuilder.Introspection] = t.Introspection;
            tempRow[targetBuilder.Op_Delete] = targetBuilder.Op_Delete;
            tempRow[targetBuilder.Op_Edit] = targetBuilder.Op_Edit;
            tempRow[targetBuilder.Date] = t.Date;
        }
    }
}
