using cn.bmob.io;
using PS.Plot.FrameBasic.Module_Common.Component;
using PS.Plot.FrameBasic.Module_Common.Component.Adapter;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechniqueMaster.Module_TechniqueBomb.Controller;
using TechniqueMaster.Module_TechniqueBomb.Model;

namespace TechniqueMaster.Module_TechniqueBomb.Componet.Adapter
{

	public class TB_TechniqueMissionBuilder : BaseDataTableBuilder
	{

        public readonly string ObjectID = "ObjectID";
		public readonly string TechniqueID = "技能编号";
        public readonly string TechinqueName = "技能名称";
		public readonly string Name = "任务名称";
		public readonly string Description = "任务描述";
		public readonly string CreateDate = "创建日期";
		public readonly string FinishDate = "完成日期";
		public readonly string Op_Delete = "删除";
		public readonly string Op_Edit = "编辑";
		public readonly string Op_UpdateState = "状态更新";
		protected override void AddDataColumn()
		{

            onCreateDataColumn(ObjectID);
			onCreateDataColumn(TechniqueID);
            onCreateDataColumn(TechinqueName);
			onCreateDataColumn(Name);
			onCreateDataColumn(Description);
			onCreateDataColumn(CreateDate);
			onCreateDataColumn(FinishDate);
			onCreateDataColumn(Op_Delete);
			onCreateDataColumn(Op_Edit);
			onCreateDataColumn(Op_UpdateState);
		}

	}

	public class TB_TechniqueMissionAdapter : ScanGridControlAdapter<TB_TechniqueMission>
	{

        public override void onPrepareCreated(System.Data.DataTable m_ResultTable, BaseDataTableBuilder m_TableBuilder)
        {
            base.onPrepareCreated(m_ResultTable, m_TableBuilder);
            foreach (var item in new TechniqueController().Travels())
                AddTempParams(item.objectId, item.Name);
        }

		public override void onCreateDataRow(ref System.Data.DataRow tempRow, BaseDataTableBuilder builder, int RowIndex, TB_TechniqueMission t)
		{

			TB_TechniqueMissionBuilder targetBuilder = builder as TB_TechniqueMissionBuilder;
            tempRow[targetBuilder.ObjectID] = t.objectId;
			tempRow[targetBuilder.TechniqueID] = t.TechniqueID;
			tempRow[targetBuilder.Name] = t.Name;
			tempRow[targetBuilder.Description] = t.Description;
			tempRow[targetBuilder.CreateDate] = DateTime.Parse(t.CreateDate.iso).ToString("yyyy-MM-dd");
            if(t.IsInvailDate() == false)
			    tempRow[targetBuilder.FinishDate] =  DateTime.Parse(t.FinishDate.iso).ToString("yyyy-MM-dd");
			tempRow[targetBuilder.Op_Delete] = targetBuilder.Op_Delete;
			tempRow[targetBuilder.Op_Edit] = targetBuilder.Op_Edit;
			tempRow[targetBuilder.Op_UpdateState] = targetBuilder.Op_UpdateState;
            tempRow[targetBuilder.TechinqueName] = m_TempParams[t.TechniqueID];
		}

        public string ConvertMissionIDToName(string targetID)
        {
            TB_TechniqueMissionBuilder targetBuilder = this.m_TableBuilder as TB_TechniqueMissionBuilder;
            for (int index = 0; index < this.m_ResultTable.Rows.Count; index++)
            {
                DataRow tempRow = this.m_ResultTable.Rows[index];
                if (tempRow[targetBuilder.ObjectID].ToString().Equals(targetID))
                    return tempRow[targetBuilder.Name].ToString();
            }
            return "NoData";
        }
    }

}

