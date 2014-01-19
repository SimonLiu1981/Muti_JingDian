//-------------------------------------------------------------------
//��Ȩ���У�
//ϵͳ���ƣ�
//�ļ����ƣ�
//ģ�����ƣ�
//ģ���ţ�****
//�������ߣ�
//������ڣ�2006-05-20
//����˵����
//-----------------------------------------------------------------
//�޸ļ�¼��
//�޸��ˣ�  
//�޸�ʱ�䣺
//�޸����ݣ�
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
        /// ��DataRow�����ݸ�����Ӧ��ʵ������(�������)
        /// </summary>
        /// <param name="row"></param>
        /// <param name="entity"></param>
        public static void CopyDataRowToEntity(DataRow row, object entity)
        {
            Type type = entity.GetType();
            CopyDataRowToEntity( row, type, entity );
        }

        /// <summary>
        /// ��DataRow�����ݸ�ֵ��DataRow(�������)
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
        /// ��DataRow�����ݸ�����Ӧ��ʵ������(�������)
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
        /// ��DataRow�����ݸ�����Ӧ��ʵ������(�м����)
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
        /// ����˵��������ʵ���ࣨ�м�㣩��������DataTable��һ�����ݣ�����Ϊʵ�����Ա����
        /// ��    �ߣ�
        /// ����ʱ�䣺2007-6-18
        /// </summary>
        /// <param name="obj">ʵ�������</param>
        /// <param name="tablename">����</param>
        /// <returns>���ݱ�</returns>
        public static DataTable NewDataTableForEntity(object obj, string tablename,bool IsCopyData)
        {
            if (obj == null) return null;
            Type type = obj.GetType();
            FieldInfo[] fields = type.GetFields();
            DataTable dtret = new DataTable(tablename);
            string colname = null;
            //ʹ�� hashtable ����ѭ������
            System.Collections.Hashtable ht = new System.Collections.Hashtable();

            //������ṹ
            foreach (FieldInfo fd in fields)
            {
                colname = fd.Name.ToUpper();
                dtret.Columns.Add(colname, fd.FieldType);
                ht.Add(colname, fd.GetValue(obj));

            }

            if (IsCopyData)
            {
                //�������
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
        /// ����˵��������ʵ���ࣨ�м�㣩��������DataTable��һ�����ݣ�����Ϊʵ�����Ա����
        /// ��    �ߣ�
        /// ����ʱ�䣺2007-6-18
        /// </summary>
        /// <param name="obj">ʵ�������</param>
        /// <param name="tablename">����</param>
        /// <returns>���ݱ�</returns>
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
        /// ����˵��������ʵ���ࣨ�м�㣩��������DataSet��һ�ű�һ�����ݣ�����Ϊʵ�����Ա����
        /// ��    �ߣ�
        /// ����ʱ�䣺 
        /// </summary>
        /// <param name="obj">ʵ�������</param>
        /// <param name="tablename">����</param>
        /// <returns>DataSet</returns>
        public static DataSet NewDataSetForEntity(object obj, string tablename)
        {
            if (obj == null) return null;
            DataSet dsret = new DataSet();
            dsret.Tables.Add(NewDataTableForEntity(obj, tablename,true  ));
            return dsret;
        }

        /// <summary>
        /// DataRow������ΪDBNnullʱ,���ó�ʼֵ.
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
        ///  ��ʵ�����������ݸ�����Ӧ��DataRow
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
        /// UI��ʹ��ʵ���������.
        /// ����ֵ���ͺͷ��������ͣ�
        /// </summary>
        /// <param name="entity">Դʵ����</param>
        /// <param name="entity">Ŀ��ʵ����</param>
        public static void CopyEntityToEntity(object entityFrom,object entityTo)
        {
            if (entityFrom == null || entityTo == null) return;
            Type typeFrom = entityFrom.GetType();
            Type typeTo = entityTo.GetType();

            PropertyInfo[] propertys = typeFrom.GetProperties();
            foreach (PropertyInfo pInfo in propertys)
            {
                PropertyInfo pInfoTo = typeTo.GetProperty( pInfo.Name );
                //��Ϊ���Ҳ�Ϊ��������ʱ��ֵ.
                if (pInfoTo != null && !pInfoTo.PropertyType.IsArray)
                {
                    object obj = pInfo.GetValue( entityFrom, null );
                    if (obj == null) continue;
                    //Ϊֵ���ͻ���������ͬʱ��ֵ��
                    if ( obj.GetType ().IsValueType || obj.GetType().Equals(pInfoTo.PropertyType))
                    {
                        pInfoTo.SetValue( entityTo, obj, null );
                    }
                }
            }
        }

        /// <summary>
        /// DAL��IDataReader����ʵ������
        /// ֻ���Ǽ���������
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
        /// ����˵������DAL�����ʵ������ƴװSQL���
        ///        1,�����������͡�(String) ��Ϊnullʱ�����£���Ϊstring.empty ʱ���¡� 
        ///        2,�����Ԫ���͡�
        ///        �����̈́e�� Boolean��Byte��SByte��Int16��UInt16��Int32��UInt32��Int64��UInt64��Char��Double �� Single��
        ///        ʵ�����л�Ԫ���͵ĳ�ʼֵΪINIT_INT/INIT_LONG������ʱ������SQL�С�
        ///        3,ʵ���ֶ�����������ݿ�������ͬ��
        /// ����    ����  
        /// ������ڡ��� 
        /// </summary>
        /// </summary>
        /// <param name="pi"></param>
        /// <param name="token">��������ֵ�Եı�־��":" or "and"</param>
        /// <param name="excludeCol">�����õ�����ֵ</param>
        /// <param name="mappingTableName">��Ӧ�ı���</param>
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
                //ȡʵ���Ӧ���ֶ�ֵ��
                object value = fi.GetValue(entity);
                if (value == null) continue;

                //1,�����ַ������͡�-- ���ַ���
                if (fi.FieldType.IsClass)
                {
                    if (fi.FieldType == typeof(string))
                    {
                        sql += string.Format(@" {0} {1}{2} = '{3}'", token, mappingTableName, colName, value);
                    }
                }
                #region ����ֵ���͡�
                
                if (fi.FieldType.IsValueType)
                {
                    //2,�����������͡���С����ʱ�����������������ʱ��ա�
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
                    //3,�����Ԫ���͡�
                    //�����̈́e�� Boolean��Byte��SByte��Int16��UInt16��Int32��UInt32��Int64��UInt64��Char��Double �� Single��
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
        /// ����˵��������ʵ���ȡ��ѯ�ַ���
        /// ����    ��
        /// ����ʱ�䣺
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
        /// ����˵��������ʵ���ȡ�����ַ���,ע�⣺��ֵ�������¡��븳Ϊstring.Empty.
        /// ����    ��
        /// ����ʱ�䣺
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
