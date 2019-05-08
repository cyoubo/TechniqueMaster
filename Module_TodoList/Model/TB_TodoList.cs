using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using Moon.Orm;

namespace TTechniqueMaster.Module_TodoList.Model
{

    [Table("[TB_TodoList]", DbType.Sqlite)]
    [TablesPrimaryKey(PrimaryKeyType.CustomerGUID, typeof(String), "GUID")]
    public class TB_TodoList : EntityBase
    {

        /// <summary>
        /// 
        /// </summary>
        public String GUID
        {
            get { return GetPropertyValue<String>("GUID"); }
            set { SetPropertyValue("GUID", value); }
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
        public String PreTodoGUID
        {
            get { return GetPropertyValue<String>("PreTodoGUID"); }
            set { SetPropertyValue("PreTodoGUID", value); }
        }
    }

    [Table("[TB_TodoList]", DbType.Sqlite)]
    public class TB_TodoListSet : MQLBase
    {
        public static new MQLBase Select(params FieldBase[] fields)
        {
            return MQLBase.Select(DbType.Sqlite,"[TB_TodoList]",fields);
        }
        public static new MQLBase SelectAll()
        {
            return MQLBase.SelectAll(DbType.Sqlite,"[TB_TodoList]");
        }
        public static readonly FieldBase GUID = new FieldBase(DbType.Sqlite, "[TB_TodoList]", FieldType.OnlyPrimaryKey, "[GUID]");
        public static readonly FieldBase Catagory = new FieldBase(DbType.Sqlite, "[TB_TodoList]", FieldType.Common, "[Catagory]");
        public static readonly FieldBase Description = new FieldBase(DbType.Sqlite, "[TB_TodoList]", FieldType.Common, "[Description]");
        public static readonly FieldBase Importance = new FieldBase(DbType.Sqlite, "[TB_TodoList]", FieldType.Common, "[Importance]");
        public static readonly FieldBase Immediacy = new FieldBase(DbType.Sqlite, "[TB_TodoList]", FieldType.Common, "[Immediacy]");
        public static readonly FieldBase Size = new FieldBase(DbType.Sqlite, "[TB_TodoList]", FieldType.Common, "[Size]");
        public static readonly FieldBase Difficulty = new FieldBase(DbType.Sqlite, "[TB_TodoList]", FieldType.Common, "[Difficulty]");
        public static readonly FieldBase CreateDate = new FieldBase(DbType.Sqlite, "[TB_TodoList]", FieldType.Common, "[CreateDate]");
        public static readonly FieldBase FinishDate = new FieldBase(DbType.Sqlite, "[TB_TodoList]", FieldType.Common, "[FinishDate]");
        public static readonly FieldBase UpdateDate = new FieldBase(DbType.Sqlite, "[TB_TodoList]", FieldType.Common, "[UpdateDate]");
        public static readonly FieldBase PreTodoGUID = new FieldBase(DbType.Sqlite, "[TB_TodoList]", FieldType.Common, "[PreTodoGUID]");
    }

}
