/*
版权所有：版权所有(C) 2012，321Nets
文件编号：M01_SyscodemapDao.cs
文件名称：SyscodemapBLL.cs
系统编号：Z0003007
系统名称：通用办公系统
模块编号：M01
模块名称：信息发布
设计文档：IOA_M01信息发布XDE建模.mdx
完成日期：2012/6/22
作　　者：
内容摘要：表[SysCodeMap]对应的业务逻辑 BLL
*/
using System;
using System.Data;
using System.Data.OleDb;
using System.Collections;
using System.Configuration;
 

using dx177.Model.Bus;

namespace dx177.Access.Bus
{
	/// <summary>
	/// Syscodemap的BLL
	/// 该BLL已经生成了基本的业务操作，在自动生成的方法中已经提供了事务机制
	/// </summary>
	public class SyscodemapDao 
	{
		#region 自动生成代码：取得相关实体

		//数据库连接字符串(web.config来配置)
		//<add key="ConnectionString" value="Provider=Microsoft.Jet.OLEDB.4.0; Data Source=D:\\db1.mdb" />
		
		protected static string connectionString =
			string.Format(ConfigurationSettings.AppSettings["ConnectionNewString"],
			              System.Web.HttpContext.Current.Request.PhysicalApplicationPath);

		/// <summary>
		/// 方法名称: SyscodemapDao
		/// 内容摘要: 构造函数进行初始化
		/// </summary>
		protected SyscodemapDao()
		{
		}

		private static volatile SyscodemapDao m_instance = null;
		/// <summary>
		/// 方法名称: GetInstance
		/// 内容摘要: 取得 SyscodemapDao 对象
		/// </summary>
		/// <returns>返回一个已经存在的实体</returns>
		public static SyscodemapDao GetInstance()
		{
			// 通用的必要代码 iBatisNet双校检机制,如果实例不存在
			if (m_instance == null)
			{
				lock (typeof (SyscodemapDao))
				{

					// 如果实例不存在
					if (m_instance == null)
					{

						// 创建一个的实例
						m_instance = new SyscodemapDao();
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
		//private static Syscodemap DataReaderToEntity(IDataReader dataReader)
		//{
		//	Syscodemap obj = null;			
        //    while (dataReader.Read())
        //    {
		//		obj = new Syscodemap();
		
		//
		//	}
		//	return obj;
		//}	
		/// <summary>
        /// 将DataReader的属性值转化为实体类的属性值，返回实体类
        /// </summary>
        /// <param name="dataReader">有效的DataReader对象</param>
        /// <returns>实体类对象</returns>
        private Syscodemap DataRowToEntity(DataRow dataReader)
        {            
			Syscodemap obj = new Syscodemap();
		
		
		 if (dataReader["SysCodeMap_Id"]!= DBNull.Value) obj.SyscodemapId = (int)dataReader["SysCodeMap_Id"];
		 if (dataReader["name"]!= DBNull.Value) obj.Name = (string)dataReader["name"];
		 if (dataReader["val"]!= DBNull.Value) obj.Val = (string)dataReader["val"];
		 if (dataReader["type"]!= DBNull.Value) obj.Type = (string)dataReader["type"];
		 if (dataReader["TypeName"]!= DBNull.Value) obj.Typename = (string)dataReader["TypeName"];
		 if (dataReader["JingQuCode"]!= DBNull.Value) obj.Jingqucode = (string)dataReader["JingQuCode"];
			
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
		public int Insert(Syscodemap entity)
		{
			int returnValue = -1;
			using (OleDbConnection connection = new OleDbConnection(connectionString))
            {   
				try
				{
				
					OleDbParameter p;
					string sqlCommand = "Insert into SysCodeMap([name],[val],[type],[TypeName],[JingQuCode]) values (?,?,?,?,?);";
					using (OleDbCommand cmd = new OleDbCommand(sqlCommand,connection))
					{
						connection.Open();					
						
		p = new OleDbParameter("@name",OleDbType.VarChar);
		p.Value = entity.Name;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@val",OleDbType.VarChar);
		p.Value = entity.Val;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@type",OleDbType.VarChar);
		p.Value = entity.Type;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@TypeName",OleDbType.VarChar);
		p.Value = entity.Typename;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@JingQuCode",OleDbType.VarChar);
		p.Value = entity.Jingqucode;
		cmd.Parameters.Add(p);			
						cmd.ExecuteNonQuery();
						
						sqlCommand = "SELECT @@IDENTITY AS ID";
												
						cmd.CommandText = sqlCommand;
						object o = cmd.ExecuteScalar();
						entity.SyscodemapId =  Convert.ToInt32(o);;
						returnValue = entity.SyscodemapId;
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
		public bool Update(Syscodemap entity)
		{
			bool returnValue = false;
			using (OleDbConnection connection = new OleDbConnection(connectionString))
            { 
			
				try
				{
					OleDbParameter p;
					string sqlCommand = "Update SysCodeMap Set [name] = ?,[val] = ?,[type] = ?,[TypeName] = ?,[JingQuCode] = ? where [SysCodeMap_Id] =?  ";
					using (OleDbCommand cmd = new OleDbCommand(sqlCommand,connection))
					{
						connection.Open();					
						
		p = new OleDbParameter("@name",OleDbType.VarChar);
		p.Value = entity.Name;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@val",OleDbType.VarChar);
		p.Value = entity.Val;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@type",OleDbType.VarChar);
		p.Value = entity.Type;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@TypeName",OleDbType.VarChar);
		p.Value = entity.Typename;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@JingQuCode",OleDbType.VarChar);
		p.Value = entity.Jingqucode;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@SysCodeMap_Id",OleDbType.Integer);
		p.Value = entity.SyscodemapId;
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
		public Syscodemap SelectByID(Syscodemap.Key entity)
        {
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
            
				try
				{
					OleDbParameter p;
					string sqlCommand = " select * From SysCodeMap where [SysCodeMap_Id] = ?    ";
					using (OleDbCommand cmd = new OleDbCommand(sqlCommand,connection))
					{   					
						connection.Open();				
						
		p = new OleDbParameter("@SysCodeMap_Id",DbType.Int32);
		p.Value = entity.SyscodemapId;
		cmd.Parameters.Add(p);
						OleDbDataAdapter adp = new OleDbDataAdapter(sqlCommand, connection);
						adp.SelectCommand = cmd;
						DataTable dt = new DataTable();
						adp.Fill(dt);
						if (dt.Rows.Count > 0)
						{
							return DataRowToEntity(dt.Rows[0]);
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
			
				string sqlCommand = "   select * From SysCodeMap  ";
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
		public bool DeleteByID(Syscodemap.Key entity)
        {
			try
			{
				using (OleDbConnection connection = new OleDbConnection(connectionString))
				{
            	
					OleDbParameter p;
					string sqlCommand = " delete From SysCodeMap where [SysCodeMap_Id] = ?    ";
					using (OleDbCommand cmd = new OleDbCommand(sqlCommand,connection))
					{     
						connection.Open();				
						
		p = new OleDbParameter("@SysCodeMap_Id",DbType.Int32);
		p.Value = entity.SyscodemapId;
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
		