using cn.bmob.io;
using PS.Plot.FrameBasic.Module_Common.Component.Adapter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechniqueMaster.Module_TechniqueBomb.Controller;
using TechniqueMaster.Module_TechniqueBomb.Model;
using System.Data;

namespace TechniqueMaster.Module_TechniqueBomb.Componet.Adapter
{

	public class TB_TechniqueLogBuilder : BaseDataTableBuilder
	{

        public readonly string ID = "objectId";
		public readonly string MissionID = "任务编号";
		public readonly string Date = "登记日期";
		public readonly string Context = "日志内容";
		public readonly string LogUrl = "笔记连接";
		public readonly string Op_Delete = "删除";
        public readonly string Op_Edit = "编辑";
        public readonly string IsNeedTidy = "亟待整理";
        

        protected override void AddDataColumn()
		{
            onCreateDataColumn(ID);
			onCreateDataColumn(MissionID);
			onCreateDataColumn(Date);
			onCreateDataColumn(Context);
			onCreateDataColumn(LogUrl);
            onCreateDataColumn(IsNeedTidy);
           
			onCreateDataColumn(Op_Delete);
            onCreateDataColumn(Op_Edit);
        }
	}

    public class TB_TechniqueLogBuilder2 : TB_TechniqueLogBuilder
    {
        public readonly string ReViewCount = "回顾次数";
        public readonly string Op_ReviewAdd = "确认回顾";
        public readonly string Op_ReviewReduce = "撤销回顾";

        protected override void AddDataColumn()
        {
            base.AddDataColumn();
            onCreateDataColumn(ReViewCount);
            onCreateDataColumn(Op_ReviewAdd);
            onCreateDataColumn(Op_ReviewReduce);
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
            tempRow[targetBuilder.Op_Edit] = targetBuilder.Op_Edit;
            tempRow[targetBuilder.ID] = t.objectId;
            tempRow[targetBuilder.IsNeedTidy] = t.IsNeedTidy;
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
            tempBean.IsNeedTidy.Set(Boolean.Parse(row[targetBuilder.ID].ToString()));
			return tempBean;
		}

	}

    public class TB_TechniqueLogAdapter2 : TB_TechniqueLogAdapter
    {
        public override void onCreateDataRow(ref DataRow tempRow, BaseDataTableBuilder builder, int RowIndex, TB_TechniqueLog t)
        {
            base.onCreateDataRow(ref tempRow, builder, RowIndex, t);
            TB_TechniqueLogBuilder2 targetBuilder = builder as TB_TechniqueLogBuilder2;
            tempRow[targetBuilder.ReViewCount] = t.ReViewCount;
            tempRow[targetBuilder.Op_ReviewAdd] = targetBuilder.Op_ReviewAdd;
            tempRow[targetBuilder.Op_ReviewReduce] = targetBuilder.Op_ReviewReduce;
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
            if (string.IsNullOrEmpty(row[targetBuilder.IsNeedTidy].ToString()) == false)
                result.IsNeedTidy = (Boolean.Parse(row[targetBuilder.IsNeedTidy].ToString()));
            else
                result.IsNeedTidy = false;
            return result;
        }
    }

}

