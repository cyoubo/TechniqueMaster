using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using Moon.Orm;

namespace TechniqueMaster.Module_TechniqueBomb.Model
{

    [Table("[TB_ProblemSets]", DbType.Sqlite)]
    [TablesPrimaryKey(PrimaryKeyType.AutoIncrease, typeof(Int64), "ID")]
    public class TB_ProblemSets : EntityBase
    {

        /// <summary>
        /// 
        /// </summary>
        public Int64 ID
        {
            get { return GetPropertyValue<Int64>("ID"); }
            set { SetPropertyValue("ID", value); }
        }

        /// <summary>
        /// 
        /// </summary>
        public String Catagory
        {
            get { return GetPropertyValue<String>("Catagory"); }
            set { SetPropertyValue("Catagory", value); }
        }

        /// <summary>
        /// 
        /// </summary>
        public String Description
        {
            get { return GetPropertyValue<String>("Description"); }
            set { SetPropertyValue("Description", value); }
        }

        /// <summary>
        /// 
        /// </summary>
        public Int64 Importance
        {
            get { return GetPropertyValue<Int64>("Importance"); }
            set { SetPropertyValue("Importance", value); }
        }

        /// <summary>
        /// 
        /// </summary>
        public Int64 Immediacy
        {
            get { return GetPropertyValue<Int64>("Immediacy"); }
            set { SetPropertyValue("Immediacy", value); }
        }

        /// <summary>
        /// 
        /// </summary>
        public Int64 Size
        {
            get { return GetPropertyValue<Int64>("Size"); }
            set { SetPropertyValue("Size", value); }
        }

        /// <summary>
        /// 
        /// </summary>
        public Int64 Difficulty
        {
            get { return GetPropertyValue<Int64>("Difficulty"); }
            set { SetPropertyValue("Difficulty", value); }
        }

        /// <summary>
        /// 
        /// </summary>
        public String CreateDate
        {
            get { return GetPropertyValue<String>("CreateDate"); }
            set { SetPropertyValue("CreateDate", value); }
        }

        /// <summary>
        /// 
        /// </summary>
        public String FinishDate
        {
            get { return GetPropertyValue<String>("FinishDate"); }
            set { SetPropertyValue("FinishDate", value); }
        }

        /// <summary>
        /// 
        /// </summary>
        public String UpdateDate
        {
            get { return GetPropertyValue<String>("UpdateDate"); }
            set { SetPropertyValue("UpdateDate", value); }
        }

        /// <summary>
        /// 
        /// </summary>
        public Int64 PreProblemID
        {
            get { return GetPropertyValue<Int64>("PreProblemID"); }
            set { SetPropertyValue("PreProblemID", value); }
        }
    }

    [Table("[TB_ProblemSets]", DbType.Sqlite)]
    public class TB_ProblemSetsSet : MQLBase
    {
        public static new MQLBase Select(params FieldBase[] fields)
        {
            return MQLBase.Select(DbType.Sqlite,"[TB_ProblemSets]",fields);
        }
        public static new MQLBase SelectAll()
        {
            return MQLBase.SelectAll(DbType.Sqlite,"[TB_ProblemSets]");
        }
        public static readonly FieldBase ID = new FieldBase(DbType.Sqlite, "[TB_ProblemSets]", FieldType.OnlyPrimaryKey, "[ID]");
        public static readonly FieldBase Catagory = new FieldBase(DbType.Sqlite, "[TB_ProblemSets]", FieldType.Common, "[Catagory]");
        public static readonly FieldBase Description = new FieldBase(DbType.Sqlite, "[TB_ProblemSets]", FieldType.Common, "[Description]");
        public static readonly FieldBase Importance = new FieldBase(DbType.Sqlite, "[TB_ProblemSets]", FieldType.Common, "[Importance]");
        public static readonly FieldBase Immediacy = new FieldBase(DbType.Sqlite, "[TB_ProblemSets]", FieldType.Common, "[Immediacy]");
        public static readonly FieldBase Size = new FieldBase(DbType.Sqlite, "[TB_ProblemSets]", FieldType.Common, "[Size]");
        public static readonly FieldBase Difficulty = new FieldBase(DbType.Sqlite, "[TB_ProblemSets]", FieldType.Common, "[Difficulty]");
        public static readonly FieldBase CreateDate = new FieldBase(DbType.Sqlite, "[TB_ProblemSets]", FieldType.Common, "[CreateDate]");
        public static readonly FieldBase FinishDate = new FieldBase(DbType.Sqlite, "[TB_ProblemSets]", FieldType.Common, "[FinishDate]");
        public static readonly FieldBase UpdateDate = new FieldBase(DbType.Sqlite, "[TB_ProblemSets]", FieldType.Common, "[UpdateDate]");
        public static readonly FieldBase PreProblemID = new FieldBase(DbType.Sqlite, "[TB_ProblemSets]", FieldType.Common, "[PreProblemID]");
    }

}
