using cn.bmob.io;
using PS.Plot.FrameBasic.Module_Common.Component.Adapter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechniqueMaster.Module_TechniqueBomb.Controller;
using TechniqueMaster.Module_TechniqueBomb.Model;

namespace TechniqueMaster.Module_TechniqueBomb.Componet.Adapter
{

	public class TB_TechniqueLogBuilder : BaseDataTableBuilder
	{

        public readonly string ID = "objectId";
		public readonly string MissionID = "MissionID";
		public readonly string Date = "Date";
		public readonly string Context = "Context";
		public readonly string LogUrl = "LogUrl";
		public readonly string Op_Delete = "删除";
		protected override void AddDataColumn()
		{
            onCreateDataColumn(ID);
			onCreateDataColumn(MissionID);
			onCreateDataColumn(Date);
			onCreateDataColumn(Context);
			onCreateDataColumn(LogUrl);
			onCreateDataColumn(Op_Delete);
		}

	}

	public class TB_TechniqueLogAdapter : EditGridControlAdapter<TB_TechniqueLog>
	{

        public override void onCreateDataRow(ref System.Data.DataRow tempRow, BaseDataTableBuilder builder, int RowIndex, TB_TechniqueLog t)
		{

			TB_TechniqueLogBuilder targetBuilder = builder as TB_TechniqueLogBuilder;
			tempRow[targetBuilder.MissionID] = t.MissionID;
			tempRow[targetBuilder.Date] = TechniqueLogController.FormatBmobDate(t.Date);
			tempRow[targetBuilder.Context] = t.Context;
			tempRow[targetBuilder.LogUrl] = t.LogUrl;
			tempRow[targetBuilder.Op_Delete] = targetBuilder.Op_Delete;
            tempRow[targetBuilder.ID] = t.objectId;
		}

        public override TB_TechniqueLog onDesrialize(BaseDataTableBuilder builder, System.Data.DataRow row)
		{

			TB_TechniqueLogBuilder targetBuilder = builder as TB_TechniqueLogBuilder;
            TB_TechniqueLog tempBean = new TB_TechniqueLog();
			tempBean.MissionID = row[targetBuilder.MissionID].ToString();
            tempBean.Date = DateTime.Parse(row[targetBuilder.Date].ToString());
			tempBean.Context = row[targetBuilder.Context].ToString();
			tempBean.LogUrl = row[targetBuilder.LogUrl].ToString();
            tempBean.objectId = row[targetBuilder.ID].ToString();
			return tempBean;
		}

	}

    public class TB_TechniqueLogDeserializion : BaseTableDeserializion<TB_TechniqueLog>
    {
        public DateTime LogDate { set; get; }

        public override TB_TechniqueLog onDesrialize(BaseDataTableBuilder builder, System.Data.DataRow row, params object[] otherParam)
        {
            TB_TechniqueLogBuilder targetBuilder = builder as TB_TechniqueLogBuilder;
            TB_TechniqueLog result = new TB_TechniqueLog();
            result.Context = row[targetBuilder.Context].ToString();
            result.LogUrl = row[targetBuilder.LogUrl].ToString();
            result.MissionID = row[targetBuilder.MissionID].ToString();
            result.Date = LogDate;
            if(string.IsNullOrEmpty(row[targetBuilder.ID].ToString())   ==false)
                result.objectId = row[targetBuilder.ID].ToString();
            return result;
        }
    }

}

