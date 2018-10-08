using  System ;
using  System.Text ;
using  System.Collections ;
using  System.Collections.Generic ;
using  Moon.Orm ;
using PS.Plot.FrameBasic.Module_Common.Component.Adapter;
using TechniqueMaster.Module_Technique.Model;

namespace TechniqueMaster.Module_Technique.Componet.Adapter
 {
	public class TB_TechniqueLogBuilder : BaseDataTableBuilder
	 {
		public readonly string ID = "ID";
		public readonly string MissionID = "MissionID";
		public readonly string Date = "Date";
		public readonly string Context = "Context";
		public readonly string LogUrl = "LogUrl";
		public readonly string Op_Delete = "删除";
		public readonly string Op_Edit = "编辑";
		protected override void AddDataColumn()
		 {
			onCreateDataColumn(ID);
			onCreateDataColumn(MissionID);
			onCreateDataColumn(Date);
			onCreateDataColumn(Context);
			onCreateDataColumn(LogUrl);
			onCreateDataColumn(Op_Delete);
			onCreateDataColumn(Op_Edit);
		 }
	 }
	public class TB_TechniqueLogAdapter : BaseGridControlAdapter<TB_TechniqueLog>
	 {
		public override void onCreateDataRow(ref System.Data.DataRow tempRow, BaseDataTableBuilder builder, int RowIndex, TB_TechniqueLog t)
		 {
			TB_TechniqueLogBuilder targetBuilder = builder as TB_TechniqueLogBuilder;
			tempRow[targetBuilder.ID] = t.ID.ToString();
			tempRow[targetBuilder.MissionID] = t.MissionID.ToString();
			tempRow[targetBuilder.Date] = t.Date;
			tempRow[targetBuilder.Context] = t.Context;
			tempRow[targetBuilder.LogUrl] = t.LogUrl;
			tempRow[targetBuilder.Op_Delete] = targetBuilder.Op_Delete;
			tempRow[targetBuilder.Op_Edit] = targetBuilder.Op_Edit;
		 }
	 }
 }
