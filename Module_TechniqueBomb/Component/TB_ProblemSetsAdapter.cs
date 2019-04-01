using  System ;
using  System.Text ;
using  System.Collections ;
using  System.Collections.Generic ;
using  Moon.Orm ;
using PS.Plot.FrameBasic.Module_Common.Component.Adapter;
using TechniqueMaster.Module_TechniqueBomb.Model;

namespace TechniqueMaster.Module_TechniqueBomb.Componet.Adapter
{

	public class TB_ProblemSetsBuilder : BaseDataTableBuilder
	{

		public readonly string ID = "ID";
		public readonly string Catagory = "Catagory";
		public readonly string Description = "Description";
		public readonly string Importance = "Importance";
		public readonly string Immediacy = "Immediacy";
		public readonly string Size = "Size";
		public readonly string Difficulty = "Difficulty";
		public readonly string CreateDate = "CreateDate";
		public readonly string FinishDate = "FinishDate";
		public readonly string UpdateDate = "UpdateDate";
        public readonly string PreProblemID = "PreProblemID";
		public readonly string Op_Delete = "删除";
		public readonly string Op_Edit = "编辑";
		protected override void AddDataColumn()
		{

			onCreateDataColumn(ID);
			onCreateDataColumn(Catagory);
			onCreateDataColumn(Description);
			onCreateDataColumn(Importance);
			onCreateDataColumn(Immediacy);
			onCreateDataColumn(Size);
			onCreateDataColumn(Difficulty);
			onCreateDataColumn(CreateDate);
			onCreateDataColumn(FinishDate);
			onCreateDataColumn(UpdateDate);
            onCreateDataColumn(PreProblemID);
			onCreateDataColumn(Op_Delete);
			onCreateDataColumn(Op_Edit);
		}

	}

	public class TB_ProblemSetsAdapter : ScanGridControlAdapter<TB_ProblemSets>
	{

		public override void onCreateDataRow(ref System.Data.DataRow tempRow, BaseDataTableBuilder builder, int RowIndex, TB_ProblemSets t)
		{

			TB_ProblemSetsBuilder targetBuilder = builder as TB_ProblemSetsBuilder;
			tempRow[targetBuilder.ID] = t.ID.ToString();
			tempRow[targetBuilder.Catagory] = t.Catagory;
			tempRow[targetBuilder.Description] = t.Description;
			tempRow[targetBuilder.Importance] = t.Importance.ToString();
			tempRow[targetBuilder.Immediacy] = t.Immediacy.ToString();
			tempRow[targetBuilder.Size] = t.Size.ToString();
			tempRow[targetBuilder.Difficulty] = t.Difficulty.ToString();
			tempRow[targetBuilder.CreateDate] = t.CreateDate;
			tempRow[targetBuilder.FinishDate] = t.FinishDate;
			tempRow[targetBuilder.UpdateDate] = t.UpdateDate;
            tempRow[targetBuilder.PreProblemID] = t.PreProblemID;
			tempRow[targetBuilder.Op_Delete] = targetBuilder.Op_Delete;
			tempRow[targetBuilder.Op_Edit] = targetBuilder.Op_Edit;
		}

	}

}

