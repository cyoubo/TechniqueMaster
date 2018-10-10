using  System ;
using  System.Text ;
using  System.Collections ;
using  System.Collections.Generic ;
using  Moon.Orm ;
using PS.Plot.FrameBasic.Module_Common.Component.Adapter;
using TechniqueMaster.Module_Technique.Model;
using TechniqueMaster.Module_Technique.Controller;

namespace TechniqueMaster.Module_Technique.Componet.Adapter
 {
	public class TB_TechniqueLogBuilder : BaseDataTableBuilder
	 {
		public readonly string ID = "ID";
		public readonly string MissionID = "任务编号";
		public readonly string Date = "日志时间";
		public readonly string Context = "学习内容";
		public readonly string LogUrl = "云笔记";
        public readonly string MissionName = "任务名称";
        public readonly string TechName = "技术名称";
		public readonly string Op_Delete = "删除";
		public readonly string Op_Edit = "编辑";
		protected override void AddDataColumn()
		 {
			onCreateDataColumn(ID);
            onCreateDataColumn(TechName);
			onCreateDataColumn(MissionID);
            onCreateDataColumn(MissionName);
			onCreateDataColumn(Date);
			onCreateDataColumn(Context);
			onCreateDataColumn(LogUrl);
			onCreateDataColumn(Op_Delete);
			onCreateDataColumn(Op_Edit);
		 }
	 }
	public class TB_TechniqueLogAdapter : BaseGridControlAdapter3<TB_TechniqueLog>
	 {
        private Dictionary<long, string> MissionDict;
        private Dictionary<long, string> TechDict;
        private Dictionary<long, long> Mission_TechDict;

        public override void onPrepareCreated(System.Data.DataTable m_ResultTable, BaseDataTableBuilder m_TableBuilder)
        {
            base.onPrepareCreated(m_ResultTable, m_TableBuilder);

            MissionDict = new Dictionary<long,string>();
            TechDict = new Dictionary<long,string>();
            Mission_TechDict = new Dictionary<long, long>();

            foreach (var item in new TechniqueMisssionController().TravleAllEntities())
            {
                MissionDict.Add(item.ID, item.Name);
                Mission_TechDict.Add(item.ID, item.TechniqueID);
            }
            foreach (var item in new TechniqueController().TravleAllEntities())
                TechDict.Add(item.ID, item.Name);
            
        }

        public override void onFinishRowsCreated(System.Data.DataTable m_ResultTable)
        {
            base.onFinishRowsCreated(m_ResultTable);

            if (MissionDict != null)
                MissionDict.Clear();
            if (TechDict != null)
                TechDict.Clear();
            if (Mission_TechDict != null)
                Mission_TechDict.Clear();
        }

		public override void onCreateDataRow(ref System.Data.DataRow tempRow, BaseDataTableBuilder builder, int RowIndex, TB_TechniqueLog t)
		 {
			TB_TechniqueLogBuilder targetBuilder = builder as TB_TechniqueLogBuilder;
			tempRow[targetBuilder.ID] = t.ID.ToString();
			tempRow[targetBuilder.MissionID] = t.MissionID.ToString();
			tempRow[targetBuilder.Date] = t.Date;
			tempRow[targetBuilder.Context] = t.Context;
            tempRow[targetBuilder.MissionName] = MissionDict[t.MissionID];
            tempRow[targetBuilder.TechName] = TechDict[Mission_TechDict[t.MissionID]];
			tempRow[targetBuilder.LogUrl] = t.LogUrl;
			tempRow[targetBuilder.Op_Delete] = targetBuilder.Op_Delete;
			tempRow[targetBuilder.Op_Edit] = targetBuilder.Op_Edit;
		 }
	 }
 }
