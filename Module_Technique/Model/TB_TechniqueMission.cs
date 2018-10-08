using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using Moon.Orm;

namespace TechniqueMaster.Module_Technique.Model
{

    [Table("[TB_TechniqueMission]", DbType.Sqlite)]
    [TablesPrimaryKey(PrimaryKeyType.AutoIncrease, typeof(Int64), "ID")]
    public class TB_TechniqueMission : EntityBase
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
        public Int64 TechniqueID
        {
            get { return GetPropertyValue<Int64>("TechniqueID"); }
            set { SetPropertyValue("TechniqueID", value); }
        }

        /// <summary>
        /// 
        /// </summary>
        public String Name
        {
            get { return GetPropertyValue<String>("Name"); }
            set { SetPropertyValue("Name", value); }
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
        public String Status
        {
            get { return GetPropertyValue<String>("Status"); }
            set { SetPropertyValue("Status", value); }
        }
    }

    [Table("[TB_TechniqueMission]", DbType.Sqlite)]
    public class TB_TechniqueMissionSet : MQLBase
    {
        public static new MQLBase Select(params FieldBase[] fields)
        {
            return MQLBase.Select(DbType.Sqlite,"[TB_TechniqueMission]",fields);
        }
        public static new MQLBase SelectAll()
        {
            return MQLBase.SelectAll(DbType.Sqlite,"[TB_TechniqueMission]");
        }
        public static readonly FieldBase ID = new FieldBase(DbType.Sqlite, "[TB_TechniqueMission]", FieldType.OnlyPrimaryKey, "[ID]");
        public static readonly FieldBase TechniqueID = new FieldBase(DbType.Sqlite, "[TB_TechniqueMission]", FieldType.Common, "[TechniqueID]");
        public static readonly FieldBase Name = new FieldBase(DbType.Sqlite, "[TB_TechniqueMission]", FieldType.Common, "[Name]");
        public static readonly FieldBase Description = new FieldBase(DbType.Sqlite, "[TB_TechniqueMission]", FieldType.Common, "[Description]");
        public static readonly FieldBase CreateDate = new FieldBase(DbType.Sqlite, "[TB_TechniqueMission]", FieldType.Common, "[CreateDate]");
        public static readonly FieldBase FinishDate = new FieldBase(DbType.Sqlite, "[TB_TechniqueMission]", FieldType.Common, "[FinishDate]");
        public static readonly FieldBase Status = new FieldBase(DbType.Sqlite, "[TB_TechniqueMission]", FieldType.Common, "[Status]");
    }

}
