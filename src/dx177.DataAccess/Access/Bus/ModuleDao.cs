/*
版权所有：版权所有(C) 2011，321Nets
文件编号：M01_ModuleDao.cs
文件名称：ModuleBLL.cs
系统编号：Z0003007
系统名称：通用办公系统
模块编号：M01
模块名称：信息发布
设计文档：IOA_M01信息发布XDE建模.mdx
完成日期：2011-10-25
作　　者：
内容摘要：表[Module]对应的业务逻辑 BLL
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
	/// Module的BLL
	/// 该BLL已经生成了基本的业务操作，在自动生成的方法中已经提供了事务机制
	/// </summary>
	public class ModuleDao 
	{
		#region 自动生成代码：取得相关实体

		//数据库连接字符串(web.config来配置)
		//<add key="ConnectionString" value="Provider=Microsoft.Jet.OLEDB.4.0; Data Source=D:\\db1.mdb" />
		
		protected static string connectionString =
			string.Format(ConfigurationSettings.AppSettings["ConnectionNewString"],
			              System.Web.HttpContext.Current.Request.PhysicalApplicationPath);

		/// <summary>
		/// 方法名称: ModuleDao
		/// 内容摘要: 构造函数进行初始化
		/// </summary>
		protected ModuleDao()
		{
		}

		private static volatile ModuleDao m_instance = null;
		/// <summary>
		/// 方法名称: GetInstance
		/// 内容摘要: 取得 ModuleDao 对象
		/// </summary>
		/// <returns>返回一个已经存在的实体</returns>
		public static ModuleDao GetInstance()
		{
			// 通用的必要代码 iBatisNet双校检机制,如果实例不存在
			if (m_instance == null)
			{
				lock (typeof (ModuleDao))
				{

					// 如果实例不存在
					if (m_instance == null)
					{

						// 创建一个的实例
						m_instance = new ModuleDao();
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
		//private static Module DataReaderToEntity(IDataReader dataReader)
		//{
		//	Module obj = null;			
        //    while (dataReader.Read())
        //    {
		//		obj = new Module();
		
		//
		//	}
		//	return obj;
		//}	
		/// <summary>
        /// 将DataReader的属性值转化为实体类的属性值，返回实体类
        /// </summary>
        /// <param name="dataReader">有效的DataReader对象</param>
        /// <returns>实体类对象</returns>
        private Module DataRowToEntity(DataRow dataReader)
        {            
			Module obj = new Module();
		
		
		 if (dataReader["Seqno"]!= DBNull.Value) obj.Seqno = (int)dataReader["Seqno"];
		 if (dataReader["PGUID"]!= DBNull.Value) obj.Pguid = (string)dataReader["PGUID"];
		 if (dataReader["ModuleCode"]!= DBNull.Value) obj.Modulecode = (string)dataReader["ModuleCode"];
		 if (dataReader["ShowIdx"]!= DBNull.Value) obj.Showidx = (int)dataReader["ShowIdx"];
		 if (dataReader["Title"]!= DBNull.Value) obj.Title = (string)dataReader["Title"];
		 if (dataReader["ImgFile"]!= DBNull.Value) obj.Imgfile = (string)dataReader["ImgFile"];
		 if (dataReader["ShortDescrt"]!= DBNull.Value) obj.Shortdescrt = (string)dataReader["ShortDescrt"];
		 if (dataReader["Link"]!= DBNull.Value) obj.Link = (string)dataReader["Link"];
			
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
		public int Insert(Module entity)
		{
			int returnValue = -1;
			using (OleDbConnection connection = new OleDbConnection(connectionString))
            {   
				try
				{
				
					OleDbParameter p;
					string sqlCommand = "Insert into Module([PGUID],[ModuleCode],[ShowIdx],[Title],[ImgFile],[ShortDescrt],[Link]) values (?,?,?,?,?,?,?);";
					using (OleDbCommand cmd = new OleDbCommand(sqlCommand,connection))
					{
						connection.Open();					
						
		p = new OleDbParameter("@PGUID",OleDbType.VarChar);
		p.Value = entity.Pguid;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@ModuleCode",OleDbType.VarChar);
		p.Value = entity.Modulecode;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@ShowIdx",OleDbType.Integer);
		p.Value = entity.Showidx;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@Title",OleDbType.VarChar);
		p.Value = entity.Title;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@ImgFile",OleDbType.VarChar);
		p.Value = entity.Imgfile;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@ShortDescrt",OleDbType.VarChar);
		p.Value = entity.Shortdescrt;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@Link",OleDbType.VarChar);
		p.Value = entity.Link;
		cmd.Parameters.Add(p);			
						cmd.ExecuteNonQuery();
						
						sqlCommand = "SELECT @@IDENTITY AS ID";
												
						cmd.CommandText = sqlCommand;
						object o = cmd.ExecuteScalar();
						entity.Seqno =  Convert.ToInt32(o);;
						returnValue = entity.Seqno;
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
		public bool Update(Module entity)
		{
			bool returnValue = false;
			using (OleDbConnection connection = new OleDbConnection(connectionString))
            { 
			
				try
				{
					OleDbParameter p;
					string sqlCommand = "Update Module Set [PGUID] = ?,[ModuleCode] = ?,[ShowIdx] = ?,[Title] = ?,[ImgFile] = ?,[ShortDescrt] = ?,[Link] = ? where [Seqno] =?  ";
					using (OleDbCommand cmd = new OleDbCommand(sqlCommand,connection))
					{
						connection.Open();					
						
		p = new OleDbParameter("@PGUID",OleDbType.VarChar);
		p.Value = entity.Pguid;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@ModuleCode",OleDbType.VarChar);
		p.Value = entity.Modulecode;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@ShowIdx",OleDbType.Integer);
		p.Value = entity.Showidx;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@Title",OleDbType.VarChar);
		p.Value = entity.Title;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@ImgFile",OleDbType.VarChar);
		p.Value = entity.Imgfile;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@ShortDescrt",OleDbType.VarChar);
		p.Value = entity.Shortdescrt;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@Link",OleDbType.VarChar);
		p.Value = entity.Link;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@Seqno",OleDbType.Integer);
		p.Value = entity.Seqno;
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
		public Module SelectByID(Module.Key entity)
        {
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
            
				try
				{
					OleDbParameter p;
					string sqlCommand = " select * From Module where [Seqno] = ?    ";
					using (OleDbCommand cmd = new OleDbCommand(sqlCommand,connection))
					{   					
						connection.Open();				
						
		p = new OleDbParameter("@Seqno",DbType.Int32);
		p.Value = entity.Seqno;
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
			
				string sqlCommand = "   select * From Module  ";
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
		public bool DeleteByID(Module.Key entity)
        {
			try
			{
				using (OleDbConnection connection = new OleDbConnection(connectionString))
				{
            	
					OleDbParameter p;
					string sqlCommand = " delete From Module where [Seqno] = ?    ";
					using (OleDbCommand cmd = new OleDbCommand(sqlCommand,connection))
					{     
						connection.Open();				
						
		p = new OleDbParameter("@Seqno",DbType.Int32);
		p.Value = entity.Seqno;
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
		