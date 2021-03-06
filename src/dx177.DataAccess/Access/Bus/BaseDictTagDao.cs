/*
版权所有：版权所有(C) 2011，321Nets
文件编号：M01_BaseDictTagDao.cs
文件名称：BaseDictTagBLL.cs
系统编号：Z0003007
系统名称：通用办公系统
模块编号：M01
模块名称：信息发布
设计文档：IOA_M01信息发布XDE建模.mdx
完成日期：2011/4/15
作　　者：
内容摘要：表[Base_Dict_Tag]对应的业务逻辑 BLL
*/
using System;
using System.Data;
using System.Data.OleDb;
using System.Collections;
using System.Configuration;

using dx177.Model.Bus;

namespace dx177.DataAccess.Access.Bus
{
	/// <summary>
	/// BaseDictTag的BLL
	/// 该BLL已经生成了基本的业务操作，在自动生成的方法中已经提供了事务机制
	/// </summary>
	public class BaseDictTagDao 
	{
		#region 自动生成代码：取得相关实体

		//数据库连接字符串(web.config来配置)
		//<add key="ConnectionString" value="Provider=Microsoft.Jet.OLEDB.4.0; Data Source=D:\\db1.mdb" />
		
		protected static string connectionString =
			string.Format(ConfigurationSettings.AppSettings["ConnectionNewString"],
			              System.Web.HttpContext.Current.Request.PhysicalApplicationPath);

		/// <summary>
		/// 方法名称: BaseDictTagDao
		/// 内容摘要: 构造函数进行初始化
		/// </summary>
		protected BaseDictTagDao()
		{
		}

		private static volatile BaseDictTagDao m_instance = null;
		/// <summary>
		/// 方法名称: GetInstance
		/// 内容摘要: 取得 BaseDictTagDao 对象
		/// </summary>
		/// <returns>返回一个已经存在的实体</returns>
		public static BaseDictTagDao GetInstance()
		{
			// 通用的必要代码 iBatisNet双校检机制,如果实例不存在
			if (m_instance == null)
			{
				lock (typeof (BaseDictTagDao))
				{

					// 如果实例不存在
					if (m_instance == null)
					{

						// 创建一个的实例
						m_instance = new BaseDictTagDao();
					}
				}
			}

			// 返回业务逻辑对象
			return m_instance;
		}

		/// <summary>
		/// 将DataReader的属性值转化为实体类的属性值，返回实体类
		/// </summary>
		/// <param name="dataReader">有效的DataReader对象</param>
		/// <returns>实体类对象</returns>
		//private static BaseDictTag DataReaderToEntity(IDataReader dataReader)
		//{
		//	BaseDictTag obj = null;			
        //    while (dataReader.Read())
        //    {
		//		obj = new BaseDictTag();
		
		//
		//	}
		//	return obj;
		//}	
		/// <summary>
        /// 将DataReader的属性值转化为实体类的属性值，返回实体类
        /// </summary>
        /// <param name="dataReader">有效的DataReader对象</param>
        /// <returns>实体类对象</returns>
        private BaseDictTag DataRowToEntity(DataRow dataReader)
        {            
			BaseDictTag obj = new BaseDictTag();
		
		
		 if (dataReader["Base_Dict_Tag_Id"]!= DBNull.Value) obj.BaseDictTagId = (int)dataReader["Base_Dict_Tag_Id"];
		 if (dataReader["Enum_Type_Name"]!= DBNull.Value) obj.EnumTypeName = (string)dataReader["Enum_Type_Name"];
		 if (dataReader["Enum_Value"]!= DBNull.Value) obj.EnumValue = (string)dataReader["Enum_Value"];
		 if (dataReader["Tag_Name"]!= DBNull.Value) obj.TagName = (string)dataReader["Tag_Name"];
		 if (dataReader["Enum_Name"]!= DBNull.Value) obj.EnumName = (string)dataReader["Enum_Name"];
		 if (dataReader["LCID"]!= DBNull.Value) obj.Lcid = (int)dataReader["LCID"];
			
			return obj;
		}	
		
		/// <summary>
		/// 插入对象
		/// </summary>
		/// <param name="entity">
		/// 实体里的主键被赋值
		///	</param>
		/// <returns>
		/// 返回当前插入的主键值
		///</returns>
		public int Insert(BaseDictTag entity)
		{
			int returnValue = -1;
			using (OleDbConnection connection = new OleDbConnection(connectionString))
            {   
				try
				{
				
					OleDbParameter p;
					string sqlCommand = "Insert into Base_Dict_Tag([Enum_Type_Name],[Enum_Value],[Tag_Name],[Enum_Name],[LCID]) values (?,?,?,?,?);";
					using (OleDbCommand cmd = new OleDbCommand(sqlCommand,connection))
					{
						connection.Open();					
						
		p = new OleDbParameter("@Enum_Type_Name",OleDbType.VarChar);
		p.Value = entity.EnumTypeName;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@Enum_Value",OleDbType.VarChar);
		p.Value = entity.EnumValue;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@Tag_Name",OleDbType.VarChar);
		p.Value = entity.TagName;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@Enum_Name",OleDbType.VarChar);
		p.Value = entity.EnumName;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@LCID",OleDbType.Integer);
		p.Value = entity.Lcid;
		cmd.Parameters.Add(p);			
						cmd.ExecuteNonQuery();
						
						sqlCommand = "SELECT @@IDENTITY AS ID";
												
						cmd.CommandText = sqlCommand;
						object o = cmd.ExecuteScalar();
						entity.BaseDictTagId =  Convert.ToInt32(o);;
						returnValue = entity.BaseDictTagId;
					}	
				}
				catch
				{	
					if (connection.State == ConnectionState.Open)
					{
						connection.Close();
					}
				}				
			}
			return returnValue;
		}
		/// <summary>
        /// 更新对象
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
		public bool Update(BaseDictTag entity)
		{
			bool returnValue = false;
			using (OleDbConnection connection = new OleDbConnection(connectionString))
            { 
			
				try
				{
					OleDbParameter p;
					string sqlCommand = "Update Base_Dict_Tag Set [Enum_Type_Name] = ?,[Enum_Value] = ?,[Tag_Name] = ?,[Enum_Name] = ?,[LCID] = ? where [Base_Dict_Tag_Id] =?  ";
					using (OleDbCommand cmd = new OleDbCommand(sqlCommand,connection))
					{
						connection.Open();					
						
		p = new OleDbParameter("@Enum_Type_Name",OleDbType.VarChar);
		p.Value = entity.EnumTypeName;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@Enum_Value",OleDbType.VarChar);
		p.Value = entity.EnumValue;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@Tag_Name",OleDbType.VarChar);
		p.Value = entity.TagName;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@Enum_Name",OleDbType.VarChar);
		p.Value = entity.EnumName;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@LCID",OleDbType.Integer);
		p.Value = entity.Lcid;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@Base_Dict_Tag_Id",OleDbType.Integer);
		p.Value = entity.BaseDictTagId;
		cmd.Parameters.Add(p);			
						cmd.ExecuteNonQuery();						
					}					
					returnValue = true;
				}
				catch
				{
					if (connection.State == ConnectionState.Open)
					{
						connection.Close();
					}
				}
			}
			return returnValue;	
		}
			
		/// <summary>
		/// 通过主键取得实体
		/// </summary>
		/// <param name="entity"> 主键 </param>
		/// <returns>实体对象</returns>
		public BaseDictTag SelectByID(BaseDictTag.Key entity)
        {
            DataRow dr = SelectRowByID(entity);
            if (dr != null)
            {
                return DataRowToEntity(SelectRowByID(entity));
            }
            return null;
        }
		
		
				/// <summary>
		/// 通过主键取得实体
		/// </summary>
		/// <param name="entity"> 主键 </param>
		/// <returns>实体对象</returns>
		public DataRow SelectRowByID(BaseDictTag.Key entity)
        {
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
            
				try
				{
					OleDbParameter p;
					string sqlCommand = " select * From Base_Dict_Tag where [Base_Dict_Tag_Id] = ?    ";
					using (OleDbCommand cmd = new OleDbCommand(sqlCommand,connection))
					{   					
						connection.Open();				
						
		p = new OleDbParameter("@Base_Dict_Tag_Id",DbType.Int32);
		p.Value = entity.BaseDictTagId;
		cmd.Parameters.Add(p);
						OleDbDataAdapter adp = new OleDbDataAdapter(sqlCommand, connection);
						adp.SelectCommand = cmd;
						DataTable dt = new DataTable();
						adp.Fill(dt);
						if (dt.Rows.Count > 0)
						{
							return dt.Rows[0];
						}
						else
						{
							return null;
						}
					} 
				}
				catch
				{
					if (connection.State == ConnectionState.Open)
					{
						connection.Close();
					}
					return null;
				}
           }
        }
		
		
		public IList SelectAll()
        {
            ArrayList ar = new ArrayList();
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
			
				string sqlCommand = "   select * From Base_Dict_Tag  ";
				using (OleDbCommand cmd = new OleDbCommand(sqlCommand,connection))
                {
                    connection.Open();	                    
                    OleDbDataAdapter adp = new OleDbDataAdapter(sqlCommand, connection);
                    adp.SelectCommand = cmd;                    
                    DataTable dt = new DataTable();
                    adp.Fill(dt);
                    foreach(DataRow dr in dt.Rows)
                    {
                        ar.Add(DataRowToEntity(dr));
                    }
                    return ar;
                }                 
            }
			
        }
		public bool DeleteByID(BaseDictTag.Key entity)
        {
			try
			{
				using (OleDbConnection connection = new OleDbConnection(connectionString))
				{
            	
					OleDbParameter p;
					string sqlCommand = " delete From Base_Dict_Tag where [Base_Dict_Tag_Id] = ?    ";
					using (OleDbCommand cmd = new OleDbCommand(sqlCommand,connection))
					{     
						connection.Open();				
						
		p = new OleDbParameter("@Base_Dict_Tag_Id",DbType.Int32);
		p.Value = entity.BaseDictTagId;
		cmd.Parameters.Add(p);								
                        cmd.ExecuteNonQuery();
                        return true;
                    }
                }
            }
            catch
            {
                return false;
            }
        }					
		#endregion
		
	}	
}		
		