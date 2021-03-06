﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;

namespace FirstABP
{
    #region Code

    /// <summary>
    /// IDBSchema工厂类
    /// </summary>
    public class DBSchemaFactory
    {
        /// <summary>
        /// 获取IDBSchema实例
        /// </summary>
        /// <param name="config">IDBSchema配置参数</param>
        /// <returns></returns>
        public static IDBSchema GetDBSchema(DbConfig config)
        {
            IDBSchema dbSchema;
            switch (config.DatabaseType)
            {
                case DatabaseType.SqlServer:
                    {
                        dbSchema = new SqlServerSchema(config);
                        break;
                    }
                case DatabaseType.MySql:
                    {
                        dbSchema = new MySqlSchema(config);
                        break;
                    }
                case DatabaseType.Oracle:
                    {
                        throw new ArgumentException("The input argument of DatabaseType is not implemented!");
                    }
                default:
                    {
                        throw new ArgumentException("The input argument of DatabaseType is invalid!");
                    }
            }

            return dbSchema;
        }
    }

    /// <summary>
    /// IDBSchema接口
    /// </summary>
    public interface IDBSchema : IDisposable
    {
        /// <summary>
        /// 获取目标数据库所有表列表
        /// </summary>
        /// <returns>返回目标数据库所有表名称列表</returns>
        List<string> GetTablesList();

        /// <summary>
        /// 根据表名获取其原始数据
        /// </summary>
        /// <param name="tableName">表名</param>
        /// <returns>返回符合条件的TableMetadata</returns>
        Table GetTableMetadata(string tableName);

        /// <summary>
        /// 获取目标数据库所有表列表
        /// </summary>
        /// <returns>返回目标数据库所有表列表</returns>
        List<DbTable> GetDbTables();

        /// <summary>
        /// 获取目标表所有列列表
        /// </summary>
        /// <param name="dbTable">目标表对象</param>
        /// <returns>返回目标表所有列列表</returns>
        List<DbColumn> GetDbColumns(DataTable dbTable);
    }

    /// <summary>
    /// SQLSERVER
    /// </summary>
    public class SqlServerSchema : IDBSchema
    {
        /// <summary>
        /// 数据库链接对象
        /// </summary>
        private SqlConnection _conn;

        /// <summary>
        /// 数据库链接对象
        /// </summary>
        private DbConfig _config;

        /// <summary>
        /// 构造函数，初始化配置信息
        /// </summary>
        /// <param name="config"></param>
        public SqlServerSchema(DbConfig config)
        {
            _config = config;
            if (string.IsNullOrWhiteSpace(config.ConnectionString))
            {
                throw new ArgumentNullException("The input argument of ConnectionString is empty!");
            }
            _conn = new SqlConnection(config.ConnectionString);
            _conn.Open();
        }

        /// <summary>
        /// 获取目标数据库所有表列表
        /// </summary>
        /// <returns>返回目标数据库所有表名称列表</returns>
        public List<string> GetTablesList()
        {
            DataTable dt = _conn.GetSchema("Tables");
            List<string> list = new List<string>();
            foreach (DataRow row in dt.Rows)
            {
                list.Add(row["TABLE_NAME"].ToString());
            }
            return list;
        }

        /// <summary>
        /// 根据表名获取其原始数据
        /// </summary>
        /// <param name="tableName">表名</param>
        /// <returns>返回符合条件的TableMetadata</returns>
        public Table GetTableMetadata(string tableName)
        {
            string selectCmdText = string.Format("SELECT * FROM {0}", tableName); ;
            SqlCommand command = new SqlCommand(selectCmdText, _conn);
            SqlDataAdapter ad = new SqlDataAdapter(command);
            System.Data.DataSet ds = new DataSet();
            ad.FillSchema(ds, SchemaType.Mapped, tableName);

            Table table = new Table(ds.Tables[0]);
            return table;
        }

        /// <summary>
        /// 获取目标数据库所有表列表
        /// </summary>
        /// <returns>返回目标数据库所有表列表</returns>
        public List<DbTable> GetDbTables()
        {
            string sql = string.Format(@"SELECT
											obj.name tablename,
											schem.name schemname,
											idx.rows,
											CAST
											(
												CASE 
													WHEN (SELECT COUNT(1) FROM sys.indexes WHERE object_id= obj.OBJECT_ID AND is_primary_key=1) >=1 THEN 1
													ELSE 0
												END 
											AS BIT) HasPrimaryKey                                         
											from {0}.sys.objects obj 
											inner join {0}.dbo.sysindexes idx on obj.object_id=idx.id and idx.indid<=1
											INNER JOIN {0}.sys.schemas schem ON obj.schema_id=schem.schema_id
											where type='U' {1}
											order by obj.name", _config.DbDatabase, "");

            DataTable dt = GetDataTable(sql);
            return dt.Rows.Cast<DataRow>().Select(row => new DbTable
            {
                TableName = row.Field<string>("tablename"),
                SchemaName = row.Field<string>("schemname"),
                Rows = row.Field<int>("rows"),
                HasPrimaryKey = row.Field<bool>("HasPrimaryKey")
            }).ToList();
        }

        /// <summary>
        /// 获取目标表所有列列表
        /// </summary>
        /// <param name="dbTable">目标表对象</param>
        /// <returns>返回目标表所有列列表</returns>
        public List<DbColumn> GetDbColumns(DataTable dbTable)
        {
            return dbTable.Rows.Cast<DataRow>().Select(row => new DbColumn
            {
                ColumnID = row.Field<int>("ColumnID"),
                IsPrimaryKey = row.Field<bool>("IsPrimaryKey"),
                ColumnName = row.Field<string>("ColumnName"),
                ColumnType = row.Field<string>("ColumnType"),
                IsIdentity = row.Field<bool>("IsIdentity"),
                IsNullable = row.Field<bool>("IsNullable"),
                ByteLength = row.Field<int>("ByteLength"),
                CharLength = row.Field<int>("CharLength"),
                Scale = row.Field<int>("Scale"),
                Remark = row["Remark"].ToString()
            }).ToList();

            throw new NotImplementedException();
        }

        /// <summary>
        /// 释放数据库资源
        /// </summary>
        public void Dispose()
        {
            if (_conn != null && _conn.State == ConnectionState.Open)
            {
                _conn.Close();
            }
        }

        private DataTable GetDataTable(string commandText, params SqlParameter[] parms)
        {
            using (SqlConnection connection = new SqlConnection(_config.ConnectionString))
            {
                SqlCommand command = connection.CreateCommand();
                command.CommandText = commandText;
                command.Parameters.AddRange(parms);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }
    }

    /// <summary>
    ///  MySql
    /// </summary>
    public class MySqlSchema : IDBSchema
    {
        /// <summary>
        /// 数据库链接对象
        /// </summary>
        private MySqlConnection _conn;

        /// <summary>
        /// 构造函数，初始化配置信息
        /// </summary>
        public MySqlSchema(DbConfig config)
        {
            if (string.IsNullOrWhiteSpace(config.ConnectionString))
            {
                throw new ArgumentNullException("The input argument of ConnectionString is empty!");
            }
            _conn = new MySqlConnection(config.ConnectionString);
            _conn.Open();
        }

        /// <summary>
        /// 获取目标数据库所有表列表
        /// </summary>
        /// <returns>返回目标数据库所有表名称列表</returns>
        public List<string> GetTablesList()
        {
            DataTable dt = _conn.GetSchema("Tables");
            List<string> list = new List<string>();
            foreach (DataRow row in dt.Rows)
            {
                list.Add(row["TABLE_NAME"].ToString());
            }
            return list;
        }

        /// <summary>
        /// 根据表名获取其原始数据
        /// </summary>
        /// <param name="tableName">表名</param>
        /// <returns>返回符合条件的TableMetadata</returns>
        public Table GetTableMetadata(string tableName)
        {
            string selectCmdText = string.Format("SELECT * FROM {0}", tableName); ;
            MySqlCommand command = new MySqlCommand(selectCmdText, _conn);
            MySqlDataAdapter ad = new MySqlDataAdapter(command);
            System.Data.DataSet ds = new DataSet();
            ad.FillSchema(ds, SchemaType.Mapped, tableName);

            Table table = new Table(ds.Tables[0]);
            return table;
        }

        /// <summary>
        /// 获取目标数据库所有表列表
        /// </summary>
        /// <returns>返回目标数据库所有表列表</returns>
        public List<DbTable> GetDbTables()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 获取目标表所有列列表
        /// </summary>
        /// <param name="dbTable">目标表对象</param>
        /// <returns>返回目标表所有列列表</returns>
        public List<DbColumn> GetDbColumns(DataTable dbTable)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 释放数据库资源
        /// </summary>
        public void Dispose()
        {
            if (_conn != null && _conn.State == ConnectionState.Open)
            {
                _conn.Close();
            }
        }
    }

    public class Table
    {
        public Table(DataTable t)
        {
            this.PKs = this.GetPKList(t);
            this.Columns = this.GetColumnList(t);
            this.ColumnTypeNames = this.SetColumnNames();
        }

        public List<Column> PKs;

        public List<Column> Columns;

        public string ColumnTypeNames;
        public List<Column> GetPKList(DataTable dt)
        {
            List<Column> list = new List<Column>();
            Column c = null;
            if (dt.PrimaryKey.Length > 0)
            {
                list = new List<Column>();
                foreach (DataColumn dc in dt.PrimaryKey)
                {
                    c = new Column(dc);
                    list.Add(c);
                }
            }
            return list;
        }

        private List<Column> GetColumnList(DataTable dt)
        {
            List<Column> list = new List<Column>();
            Column c = null;
            foreach (DataColumn dc in dt.Columns)
            {
                c = new Column(dc);
                list.Add(c);
            }
            return list;
        }

        private string SetColumnNames()
        {
            List<string> list = new List<string>();
            foreach (Column c in this.Columns)
            {
                list.Add(string.Format("{0} {1}", c.TypeName, c.LowerColumnName));
            }
            return string.Join(",", list.ToArray());
        }
    }

    public class Column
    {
        DataColumn columnBase;

        public Column(DataColumn columnBase)
        {
            this.columnBase = columnBase;
        }

        public string ColumnName { get { return this.columnBase.ColumnName; } }

        public string MaxLength { get { return this.columnBase.MaxLength.ToString(); } }

        public string TypeName
        {
            get
            {
                string result = string.Empty;
                if (this.columnBase.DataType.Name == "Guid")//for mysql,因为对于MYSQL如果是CHAR(36),类型自动为Guid
                    result = "String";
                else
                    result = this.columnBase.DataType.Name;
                return result;
            }
        }

        public bool AllowDBNull { get { return this.columnBase.AllowDBNull; } }

        public string UpColumnName
        {
            get
            {
                return string.Format("{0}{1}", this.ColumnName[0].ToString().ToUpper(), this.ColumnName.Substring(1));
            }
        }

        public string LowerColumnName
        {
            get
            {
                return string.Format("{0}{1}", this.ColumnName[0].ToString().ToLower(), this.ColumnName.Substring(1));
            }
        }

        public bool IsValueType
        {
            get
            {
                return this.columnBase.DataType.IsValueType;
            }
        }

        public string Description
        {
            get
            {
                if (columnBase.ExtendedProperties == null || columnBase.ExtendedProperties.Count <= 0)
                {
                    return columnBase.Caption;
                }
                return this.columnBase.ExtendedProperties["MS_Description"].ToString();
            }
        }
    }

    public class GeneratorHelper
    {
        public static class SqlServerDbTypeMap
        {
            public static string MapCsharpType(string dbtype)
            {
                if (string.IsNullOrEmpty(dbtype)) return dbtype;
                dbtype = dbtype.ToLower();
                string csharpType = "object";
                switch (dbtype)
                {
                    case "bigint": csharpType = "long"; break;
                    case "binary": csharpType = "byte[]"; break;
                    case "bit": csharpType = "bool"; break;
                    case "char": csharpType = "string"; break;
                    case "date": csharpType = "DateTime"; break;
                    case "datetime": csharpType = "DateTime"; break;
                    case "datetime2": csharpType = "DateTime"; break;
                    case "datetimeoffset": csharpType = "DateTimeOffset"; break;
                    case "decimal": csharpType = "decimal"; break;
                    case "float": csharpType = "double"; break;
                    case "image": csharpType = "byte[]"; break;
                    case "int": csharpType = "int"; break;
                    case "money": csharpType = "decimal"; break;
                    case "nchar": csharpType = "string"; break;
                    case "ntext": csharpType = "string"; break;
                    case "numeric": csharpType = "decimal"; break;
                    case "nvarchar": csharpType = "string"; break;
                    case "real": csharpType = "Single"; break;
                    case "smalldatetime": csharpType = "DateTime"; break;
                    case "smallint": csharpType = "short"; break;
                    case "smallmoney": csharpType = "decimal"; break;
                    case "sql_variant": csharpType = "object"; break;
                    case "sysname": csharpType = "object"; break;
                    case "text": csharpType = "string"; break;
                    case "time": csharpType = "TimeSpan"; break;
                    case "timestamp": csharpType = "byte[]"; break;
                    case "tinyint": csharpType = "byte"; break;
                    case "uniqueidentifier": csharpType = "Guid"; break;
                    case "varbinary": csharpType = "byte[]"; break;
                    case "varchar": csharpType = "string"; break;
                    case "xml": csharpType = "string"; break;
                    default: csharpType = "object"; break;
                }
                return csharpType;
            }

            public static string MapCsharpType(string dbtype,bool allowDBNull)
            {
                var csharpType = MapCsharpType(dbtype);
                switch (csharpType)
                {
                    case "byte":
                    case "short":
                    case "Single":
                    case "int":
                    case "long":
                    case "double":
                    case "decimal":
                    case "bool":
                    case "DateTime":
                    case "DateTimeOffset":
                    case "TimeSpan":
                        if(allowDBNull)
                        {
                            csharpType += "?";
                        }
                        break;
                }

                return csharpType;
            }

            public static Type MapCommonType(string dbtype)
            {
                if (string.IsNullOrEmpty(dbtype)) return Type.Missing.GetType();
                dbtype = dbtype.ToLower();
                Type commonType = typeof(object);
                switch (dbtype)
                {
                    case "bigint": commonType = typeof(long); break;
                    case "binary": commonType = typeof(byte[]); break;
                    case "bit": commonType = typeof(bool); break;
                    case "char": commonType = typeof(string); break;
                    case "date": commonType = typeof(DateTime); break;
                    case "datetime": commonType = typeof(DateTime); break;
                    case "datetime2": commonType = typeof(DateTime); break;
                    case "datetimeoffset": commonType = typeof(DateTimeOffset); break;
                    case "decimal": commonType = typeof(decimal); break;
                    case "float": commonType = typeof(double); break;
                    case "image": commonType = typeof(byte[]); break;
                    case "int": commonType = typeof(int); break;
                    case "money": commonType = typeof(decimal); break;
                    case "nchar": commonType = typeof(string); break;
                    case "ntext": commonType = typeof(string); break;
                    case "numeric": commonType = typeof(decimal); break;
                    case "nvarchar": commonType = typeof(string); break;
                    case "real": commonType = typeof(Single); break;
                    case "smalldatetime": commonType = typeof(DateTime); break;
                    case "smallint": commonType = typeof(short); break;
                    case "smallmoney": commonType = typeof(decimal); break;
                    case "sql_variant": commonType = typeof(object); break;
                    case "sysname": commonType = typeof(object); break;
                    case "text": commonType = typeof(string); break;
                    case "time": commonType = typeof(TimeSpan); break;
                    case "timestamp": commonType = typeof(byte[]); break;
                    case "tinyint": commonType = typeof(byte); break;
                    case "uniqueidentifier": commonType = typeof(Guid); break;
                    case "varbinary": commonType = typeof(byte[]); break;
                    case "varchar": commonType = typeof(string); break;
                    case "xml": commonType = typeof(string); break;
                    default: commonType = typeof(object); break;
                }
                return commonType;
            }
        }

        public static readonly string StringType = "String";
        public static readonly string DateTimeType = "DateTime";
        public static string GetQuesMarkByType(string typeName)
        {
            string result = typeName;
            if (typeName == DateTimeType)
            {
                result += "?";
            }
            return result;
        }

        /// <summary>
        /// Converts camelCase string to PascalCase string.
        /// </summary>
        /// <param name="str">String to convert</param>
        /// <returns>PascalCase of the string</returns>
        public static string ToPascalCase(string str)
        {
            return ToPascalCase(str, CultureInfo.InvariantCulture);
        }

        /// <summary>
        /// Converts camelCase string to PascalCase string in specified culture.
        /// </summary>
        /// <param name="str">String to convert</param>
        /// <param name="culture">An object that supplies culture-specific casing rules</param>
        /// <returns>PascalCase of the string</returns>
        public static string ToPascalCase(string str, CultureInfo culture)
        {
            var array = str.Split(new char[]
            {
                '_'
            });

            string text = string.Empty;
            if (array.Length > 1)
            {
                for (int i = 1; i < array.Length; i++)
                {
                    text = text + array[i].Substring(0, 1).ToUpper() + array[i].Substring(1).ToLower();
                }

                return text;
            }
            else
            {
                return str;
            }

        }
    }

    public class DbConfig
    {
        public string ConnectionString { get; set; }

        public DatabaseType DatabaseType { get; set; }

        public string DbDatabase { get; set; }
    }

    #region DbTable

    /// <summary>
    /// 表结构
    /// </summary>
    public sealed class DbTable
    {
        /// <summary>
        /// 表名称
        /// </summary>
        public string TableName { get; set; }

        /// <summary>
        /// 表的架构
        /// </summary>
        public string SchemaName { get; set; }

        /// <summary>
        /// 表的记录数
        /// </summary>
        public int Rows { get; set; }

        /// <summary>
        /// 是否含有主键
        /// </summary>
        public bool HasPrimaryKey { get; set; }

    }
    #endregion

    #region DbColumn

    /// <summary>
    /// 表字段结构
    /// </summary>
    public sealed class DbColumn
    {
        /// <summary>
        /// 字段ID
        /// </summary>
        public int ColumnID { get; set; }

        /// <summary>
        /// 是否主键
        /// </summary>
        public bool IsPrimaryKey { get; set; }

        /// <summary>
        /// 字段名称
        /// </summary>
        public string ColumnName { get; set; }

        /// <summary>
        /// 字段类型
        /// </summary>
        public string ColumnType { get; set; }

        /// <summary>
        /// 数据库类型对应的C#类型
        /// </summary>
        public string CSharpType
        {
            get
            {
                return GeneratorHelper.SqlServerDbTypeMap.MapCsharpType(ColumnType);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public Type CommonType
        {
            get
            {
                return GeneratorHelper.SqlServerDbTypeMap.MapCommonType(ColumnType);
            }
        }

        /// <summary>
        /// 字节长度
        /// </summary>
        public int ByteLength { get; set; }

        /// <summary>
        /// 字符长度
        /// </summary>
        public int CharLength { get; set; }

        /// <summary>
        /// 小数位
        /// </summary>
        public int Scale { get; set; }

        /// <summary>
        /// 是否自增列
        /// </summary>
        public bool IsIdentity { get; set; }

        /// <summary>
        /// 是否允许空
        /// </summary>
        public bool IsNullable { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        public string Remark { get; set; }
    }

    #endregion

    #region Enum

    public enum DatabaseType
    {
        SqlServer = 1,

        Oracle = 2,

        MySql = 3
    }

    #endregion

    #endregion
}
