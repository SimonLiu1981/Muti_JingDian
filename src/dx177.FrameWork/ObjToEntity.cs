//-------------------------------------------------------------------
//版权所有：
//系统名称：
//文件名称：
//模块名称：
//模块编号：****
//作　　者：
//完成日期：2006-05-20
//功能说明：
//-----------------------------------------------------------------
//修改记录：
//修改人：  
//修改时间：
//修改内容：
//-----------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.Common;
using System.Reflection;

namespace dx177.FrameWork
{
    public class DataExchange
    {

        static  int  INIT_INT = int.MinValue;
        static float INIT_FLOAT = float.MinValue;
        static double INIT_DOUBLE = double.MinValue;
        static long INIT_LONG = long.MinValue;

        /// <summary>
        /// 将DataRow中数据付给相应的实体类型(界面层用)
        /// </summary>
        /// <param name="row"></param>
        /// <param name="entity"></param>
        public static void CopyDataRowToEntity(DataRow row, object entity)
        {
            Type type = entity.GetType();
            CopyDataRowToEntity( row, type, entity );
        }

        /// <summary>
        /// 将DataRow中数据赋值给DataRow(界面层用)
        /// </summary>
        /// <param name="row"></param>
        /// <param name="typeName"></param>
        /// <param name="entity"></param>
        public static void CopyDataRowToDataRow(DataRow fromRow, DataRow toRow)
        {
            if (fromRow == null) return;
            //PropertyInfo[] propertys = type.GetProperties();
            try
            {
                foreach (DataColumn col in fromRow.Table.Columns)
                {
                    toRow[col.ColumnName] = fromRow[col.ColumnName];
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// 将DataRow中数据付给相应的实体类型(界面层用)
        /// </summary>
        /// <param name="row"></param>
        /// <param name="typeName"></param>
        /// <param name="entity"></param>
        public static void CopyDataRowToEntity(DataRow row,Type type,  object entity)
        {
            if (type == null) return;
            PropertyInfo[] propertys = type.GetProperties(  );
            try
            {
                foreach (PropertyInfo property in propertys)
                {
                    foreach (DataColumn col in row.Table.Columns)
                    {
                        if (col.ColumnName.ToUpper() == property.Name.ToUpper() )
                        {
                            if (row[col.ColumnName].GetType().Equals(typeof(DBNull)))
                            {
                                object obj = row[col.ColumnName];
                                SetDefaultValue(ref obj , property.PropertyType);
                                if (property.PropertyType.IsValueType )
                                {
                                    property.SetValue(entity, obj, null);
                                }
                                else
                                {
                                    property.SetValue(entity, null, null);
                                }
                                
                                break;
                            }
                            
                            if (property.PropertyType.Equals( col.DataType ))
                            {
                                property.SetValue( entity, row[col.ColumnName], null );
                                break;
                            }
                            else 
                            {
                                object obj = Convert.ChangeType(row[col.ColumnName], property.PropertyType);
                                property.SetValue( entity, obj, null );
                                break;
                            }
                            //Logger.LogInfo( "DataExchange", "CopyDataRowToEntity", 0, col.ColumnName, property.PropertyType.ToString() + "-" + col.DataType.ToString() );
                        }
                    }
                    
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// 将DataRow中数据付给相应的实体类型(中间层用)
        /// </summary>
        /// <param name="row"></param>
        /// <param name="typeName"></param>
        /// <param name="entity"></param>
        public static void CopyDataRowToEntityInMiddLayer(DataRow row, object entity)
        {
            Type type = entity.GetType();
            FieldInfo[] fields = type.GetFields();
            try
            {
                foreach (FieldInfo field in fields)
                {
                    string name = field.Name.ToUpper ();
                    foreach (DataColumn dc in row.Table.Columns)
                    { 
                        if (dc.ColumnName == name)
                        {
                            if (field.FieldType == typeof(String))
                            {
                                string value = row[dc].ToString();
                                field.SetValue(entity, value);
                            }
                            else if (field.FieldType == typeof(Int32)) //int
                            {
                                if (row[dc].ToString() != string.Empty)
                                {
                                    Int32 value = Int32.Parse(row[dc].ToString());
                                    field.SetValue(entity, value);
                                }
                            }
                            else if (field.FieldType == typeof(Int64)) //long
                            {
                                if (row[dc].ToString() != string.Empty)
                                {
                                    Int64 value = Int64.Parse(row[dc].ToString());
                                    field.SetValue(entity, value);
                                }
                            }
                            else if (field.FieldType == typeof(System.Single)) //float
                            {
                                if (row[dc].ToString() != string.Empty)
                                {
                                    Single value = Single.Parse(row[dc].ToString());
                                    field.SetValue(entity, value);
                                }
                            }
                            else if (field.FieldType == typeof(Double)) //double
                            {
                                if (row[dc].ToString() != string.Empty)
                                {
                                    double value = double.Parse(row[dc].ToString());
                                    field.SetValue(entity, value);
                                }
                            }
                            else if (field.FieldType == typeof(DateTime))
                            {
                                if (row[dc].ToString() != string.Empty)
                                {
                                    DateTime value = DateTime.Parse(row[dc].ToString());
                                    field.SetValue(entity, value);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// 方法说明：根据实体类（中间层）对象，生成DataTable。一行数据，列名为实体类成员名。
        /// 作    者：
        /// 创建时间：2007-6-18
        /// </summary>
        /// <param name="obj">实体类对象</param>
        /// <param name="tablename">表名</param>
        /// <returns>数据表</returns>
        public static DataTable NewDataTableForEntity(object obj, string tablename,bool IsCopyData)
        {
            if (obj == null) return null;
            Type type = obj.GetType();
            FieldInfo[] fields = type.GetFields();
            DataTable dtret = new DataTable(tablename);
            string colname = null;
            //使用 hashtable 减少循环次数
            System.Collections.Hashtable ht = new System.Collections.Hashtable();

            //创建表结构
            foreach (FieldInfo fd in fields)
            {
                colname = fd.Name.ToUpper();
                dtret.Columns.Add(colname, fd.FieldType);
                ht.Add(colname, fd.GetValue(obj));

            }

            if (IsCopyData)
            {
                //添加数据
                DataRow dr = dtret.NewRow();
                foreach (DataColumn dcol in dtret.Columns)
                {
                    dr[dcol.ColumnName] = ht[dcol.ColumnName];
                }
                dtret.Rows.Add(dr);
            }
            return dtret;

        }


        /// <summary>
        /// 方法说明：根据实体类（中间层）对象，生成DataTable。一行数据，列名为实体类成员名。
        /// 作    者：
        /// 创建时间：2007-6-18
        /// </summary>
        /// <param name="obj">实体类对象</param>
        /// <param name="tablename">表名</param>
        /// <returns>数据表</returns>
        public static DataTable NewDataTableForObjEntity(object obj )
        {
            if (obj == null) return null;
            DataTable dtret = new DataTable();
            Type type = obj.GetType();
             PropertyInfo[] propertys = type.GetProperties();
             foreach (PropertyInfo property in propertys)
             {
                string  colname = property.Name.ToUpper();
                 dtret.Columns.Add(colname, property.PropertyType);
             }
            return dtret;

        }

        /// <summary>
        /// 方法说明：根据实体类（中间层）对象，生成DataSet。一张表一行数据，列名为实体类成员名。
        /// 作    者：
        /// 创建时间： 
        /// </summary>
        /// <param name="obj">实体类对象</param>
        /// <param name="tablename">表名</param>
        /// <returns>DataSet</returns>
        public static DataSet NewDataSetForEntity(object obj, string tablename)
        {
            if (obj == null) return null;
            DataSet dsret = new DataSet();
            dsret.Tables.Add(NewDataTableForEntity(obj, tablename,true  ));
            return dsret;
        }

        /// <summary>
        /// DataRow中数据为DBNnull时,设置初始值.
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="type"></param>
        private static void SetDefaultValue(ref object obj,Type type)
        {
            if (type.Equals(typeof(Int32))) //int
            {
                obj = INIT_INT;
            }
            else if (type.Equals(typeof(Int64))) //long
            {
                obj = INIT_LONG;
            }
            else if ( type.Equals(typeof(System.Single))) //float
            {
                obj = INIT_FLOAT;
            }
            else if ( type.Equals(typeof(Double)) )  //double
            {
                obj = INIT_DOUBLE;
            }
            else if (type.Equals(typeof(DateTime)))
            {
                obj = DateTime.MinValue;
            }

        }
        /// <summary>
        ///  将实体类型中数据付给相应的DataRow
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="typeName"></param>
        /// <param name="row"></param>
        public static void CopyEntityToDataRow( object entity,DataRow row)
        {
            Type type = entity.GetType();
            CopyEntityToDataRow( entity, type, row );
        }
        public static void CopyEntityToDataRow(object entity, Type type ,DataRow row)
        {
            if (type == null) return ;
            PropertyInfo[] propertys = type.GetProperties( );
            foreach (DataColumn dc in row.Table.Columns)
            {
                foreach (PropertyInfo property in propertys)
                {
                    if (dc.ColumnName.ToUpper() == property.Name.ToUpper())
                    {
                        row[dc.ColumnName] = property.GetValue( entity, null );
                        break;
                    }
                }
            }
        }

        /// <summary>
        /// UI层使用实体类的问题.
        /// 拷贝值类型和非数组类型．
        /// </summary>
        /// <param name="entity">源实体类</param>
        /// <param name="entity">目标实体类</param>
        public static void CopyEntityToEntity(object entityFrom,object entityTo)
        {
            if (entityFrom == null || entityTo == null) return;
            Type typeFrom = entityFrom.GetType();
            Type typeTo = entityTo.GetType();

            PropertyInfo[] propertys = typeFrom.GetProperties();
            foreach (PropertyInfo pInfo in propertys)
            {
                PropertyInfo pInfoTo = typeTo.GetProperty( pInfo.Name );
                //不为空且不为数组类型时赋值.
                if (pInfoTo != null && !pInfoTo.PropertyType.IsArray)
                {
                    object obj = pInfo.GetValue( entityFrom, null );
                    if (obj == null) continue;
                    //为值类型或者类型相同时赋值．
                    if ( obj.GetType ().IsValueType || obj.GetType().Equals(pInfoTo.PropertyType))
                    {
                        pInfoTo.SetValue( entityTo, obj, null );
                    }
                }
            }
        }

        /// <summary>
        /// DAL层IDataReader返回实体类用
        /// 只能是简单数据类型
        /// </summary>
        /// <param name="dataReader"></param>
        /// <param name="entity"></param>
        public static void CopyIDataReaderToEntity(IDataReader dataReader, object entity)
        {
            Type type = entity.GetType();
            if (type == null) return;
            FieldInfo[] fieldInfos = type.GetFields();
            try
            {
                foreach (FieldInfo fieldInfo in fieldInfos)
                {
                    string name = fieldInfo.Name.ToLower();
                    int x = dataReader.GetOrdinal(name);

                    if (fieldInfo.FieldType == typeof(String))
                    {
                        if (dataReader.IsDBNull(x))
                        {
                            fieldInfo.SetValue(entity, string.Empty);
                        }
                        else
                        {
                            fieldInfo.SetValue(entity, dataReader.GetString(x));
                        }
                    }
                    else if (fieldInfo.FieldType == typeof(Int32)) //int
                    {
                        if (dataReader.IsDBNull(x))
                        {
                            fieldInfo.SetValue(entity, INIT_INT);
                        }
                        else
                        {
                            fieldInfo.SetValue(entity, dataReader.GetInt32(x));
                        }
                    }
                    else if (fieldInfo.FieldType == typeof(Int64)) //long
                    {
                        if (dataReader.IsDBNull(x))
                        {
                            fieldInfo.SetValue(entity, INIT_LONG);
                        }
                        else
                        {
                            fieldInfo.SetValue(entity, dataReader.GetInt64(x));
                        }
                    }
                    else if (fieldInfo.FieldType == typeof(System.Single)) //float
                    {
                        if (dataReader.IsDBNull(x))
                        {
                            fieldInfo.SetValue(entity, INIT_FLOAT);
                        }
                        else
                        {
                            fieldInfo.SetValue(entity, dataReader.GetDecimal(x));
                        }
                    }
                    else if (fieldInfo.FieldType == typeof(Double)) //double
                    {
                        if (dataReader.IsDBNull(x))
                        {
                            fieldInfo.SetValue(entity, INIT_DOUBLE);
                        }
                        else
                        {
                            fieldInfo.SetValue(entity, dataReader.GetDouble(x));
                        }
                    }
                    else if (fieldInfo.FieldType == typeof(DateTime))
                    {
                        if (dataReader.IsDBNull(x))
                        {
                            fieldInfo.SetValue(entity, DateTime.MinValue);
                        }
                        else
                        {
                            fieldInfo.SetValue(entity, dataReader.GetDateTime(x));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// 方法说明　：DAL层根据实体类型拼装SQL语句
        ///        1,处理引用类型。(String) 当为null时不更新，当为string.empty 时更新。 
        ///        2,处理基元类型。
        ///        基本型別是 Boolean、Byte、SByte、Int16、UInt16、Int32、UInt32、Int64、UInt64、Char、Double 和 Single。
        ///        实体类中基元类型的初始值为INIT_INT/INIT_LONG，不等时将加入SQL中。
        ///        3,实体字段名必须和数据库列名相同。
        /// 作者    　：  
        /// 完成日期　： 
        /// </summary>
        /// </summary>
        /// <param name="pi"></param>
        /// <param name="token">连接属性值对的标志。":" or "and"</param>
        /// <param name="excludeCol">不设置的属性值</param>
        /// <param name="mappingTableName">对应的表名</param>
        /// <returns>eg " and a=1 and b='d'" or " a=1 , b='d'"</returns>
        private static string GetSQLStringByEntity(object entity,string token,string excludeCol,string mappingTableName)
        {
            string sql = null;
            Type type = entity.GetType();
            FieldInfo[] fis = type.GetFields();
            if (!string.IsNullOrEmpty(mappingTableName))
            {
                mappingTableName = mappingTableName + ".";
            }
            foreach (FieldInfo fi in fis)
            {
                string colName = fi.Name.ToUpper();
                if (colName.Equals(excludeCol)) continue;
                //取实体对应的字段值。
                object value = fi.GetValue(entity);
                if (value == null) continue;

                //1,处理字符串类型。-- ，字符串
                if (fi.FieldType.IsClass)
                {
                    if (fi.FieldType == typeof(string))
                    {
                        sql += string.Format(@" {0} {1}{2} = '{3}'", token, mappingTableName, colName, value);
                    }
                }
                #region 处理值类型。
                
                if (fi.FieldType.IsValueType)
                {
                    //2,处理日期类型。最小日期时跳过，最大日期类型时清空。
                    if (fi.FieldType == typeof(DateTime))
                    {
                        if (value.Equals(DateTime.MinValue)) continue;
                        if (value.Equals(DateTime.MaxValue))
                        {
                            sql += string.Format(@" {0} {1}{2} = '{3}'", token, mappingTableName, colName, DBNull.Value);
                        }
                        else
                        {
                            sql += string.Format(@" {0} {1}{2} = TO_DATE('{3} ','YYYY-MM-DD HH24:MI:SS')
                                ", token, mappingTableName, colName, value);
                        }
                        continue;
                    }
                    //3,处理基元类型。
                    //基本型別是 Boolean、Byte、SByte、Int16、UInt16、Int32、UInt32、Int64、UInt64、Char、Double 和 Single。
                    if (fi.FieldType.IsPrimitive)
                    {
                        if ( fi.FieldType == typeof(int) && value.Equals(INIT_INT)) continue;
                        if ( fi.FieldType == typeof(long) && value.Equals(INIT_LONG)) continue;
                        if ( fi.FieldType == typeof(double) && value.Equals(INIT_DOUBLE)) continue;
                        if (fi.FieldType == typeof(float) && value.Equals(INIT_FLOAT)) continue;

                        if (fi.FieldType == typeof(long) && value.Equals((long)Int32.MinValue))
                        {
                            sql += string.Format(@" {0} {1}{2} = null", token, mappingTableName, colName);
                            continue;
                        }

                        sql += string.Format(@" {0} {1}{2} = {3}", token, mappingTableName, colName, value);
                    }
                }

                #endregion
            }
            return sql;
        }

        /// <summary>
        /// 方法说明：根据实体获取查询字符串
        /// 作者    ：
        /// 创建时间：
        /// </summary>
        /// <param name="entity">The entity.</param>
        /// <returns>eg:" ,column1 = 'a' and column2 =3"</returns>
        public static string GetWhereStringByEntity(object entity)
        {
            return GetWhereStringByEntity(entity, null);
        }
        public static string GetWhereStringByEntity(object entity,string mappingTableName)
        {
            if (entity == null) return null;
            return GetSQLStringByEntity(entity, "and", null,mappingTableName);
        }
        /// <summary>
        /// 方法说明：根据实体获取更新字符串,注意：空值将不更新。请赋为string.Empty.
        /// 作者    ：
        /// 创建时间：
        /// </summary>
        /// <param name="entity">The entity.</param>
        /// <param name="excludeCol">The exclude col.</param>
        /// <returns>eg :" column1 = 'a' , column2 =3"</returns>
        public static string GetUpdateStringByEntity(object entity,string excludeCol)
        {
            if (entity == null) return null;
            string sql = GetSQLStringByEntity(entity, ",",excludeCol,null);
            if (string.IsNullOrEmpty(sql))
            {
                return null;
            }
            int start = sql.IndexOf(",");
            return sql.Substring(start + 1, sql.Length - start - 1);
        }
    }
}
