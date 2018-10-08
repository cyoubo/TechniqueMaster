using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using Moon.Orm;

namespace TechniqueMaster.Module_Technique.Model
{

    [Table("[TB_TechniqueLog]", DbType.Sqlite)]
    [TablesPrimaryKey(PrimaryKeyType.AutoIncrease, typeof(Int64), "ID")]
    public class TB_TechniqueLog : EntityBase
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
        public Int64 MissionID
        {
            get { return GetPropertyValue<Int64>("MissionID"); }
            set { SetPropertyValue("MissionID", value); }
        }

        /// <summary>
        /// 
        /// </summary>
        public String Date
        {
            get { return GetPropertyValue<String>("Date"); }
            set { SetPropertyValue("Date", value); }
        }

        /// <summary>
        /// 
        /// </summary>
        public String Context
        {
            get { return GetPropertyValue<String>("Context"); }
            set { SetPropertyValue("Context", value); }
        }

        /// <summary>
        /// 
        /// </summary>
        public String LogUrl
        {
            get { return GetPropertyValue<String>("LogUrl"); }
            set { SetPropertyValue("LogUrl", value); }
        }
    }

    [Table("[TB_TechniqueLog]", DbType.Sqlite)]
    public class TB_TechniqueLogSet : MQLBase
    {
        public static new MQLBase Select(params FieldBase[] fields)
        {
            return MQLBase.Select(DbType.Sqlite,"[TB_TechniqueLog]",fields);
        }
        public static new MQLBase SelectAll()
        {
            return MQLBase.SelectAll(DbType.Sqlite,"[TB_TechniqueLog]");
        }
        public static readonly FieldBase ID = new FieldBase(DbType.Sqlite, "[TB_TechniqueLog]", FieldType.OnlyPrimaryKey, "[ID]");
        public static readonly FieldBase MissionID = new FieldBase(DbType.Sqlite, "[TB_TechniqueLog]", FieldType.Common, "[MissionID]");
        public static readonly FieldBase Date = new FieldBase(DbType.Sqlite, "[TB_TechniqueLog]", FieldType.Common, "[Date]");
        public static readonly FieldBase Context = new FieldBase(DbType.Sqlite, "[TB_TechniqueLog]", FieldType.Common, "[Context]");
        public static readonly FieldBase LogUrl = new FieldBase(DbType.Sqlite, "[TB_TechniqueLog]", FieldType.Common, "[LogUrl]");
    }

}
