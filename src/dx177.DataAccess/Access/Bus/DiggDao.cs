/*
版权所有：版权所有(C) 2011，321Nets
文件编号：M01_DiggDao.cs
文件名称：DiggBLL.cs
系统编号：Z0003007
系统名称：通用办公系统
模块编号：M01
模块名称：信息发布
设计文档：IOA_M01信息发布XDE建模.mdx
完成日期：2011/4/15
作　　者：
内容摘要：表[Digg]对应的业务逻辑 BLL
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
	/// Digg的BLL
	/// 该BLL已经生成了基本的业务操作，在自动生成的方法中已经提供了事务机制
	/// </summary>
	public class DiggDao 
	{
		#region 自动生成代码：取得相关实体

		//数据库连接字符串(web.config来配置)
		//<add key="ConnectionString" value="Provider=Microsoft.Jet.OLEDB.4.0; Data Source=D:\\db1.mdb" />
		
		protected static string connectionString =
			string.Format(ConfigurationSettings.AppSettings["ConnectionNewString"],
			              System.Web.HttpContext.Current.Request.PhysicalApplicationPath);

		/// <summary>
		/// 方法名称: DiggDao
		/// 内容摘要: 构造函数进行初始化
		/// </summary>
		protected DiggDao()
		{
		}

		private static volatile DiggDao m_instance = null;
		/// <summary>
		/// 方法名称: GetInstance
		/// 内容摘要: 取得 DiggDao 对象
		/// </summary>
		/// <returns>返回一个已经存在的实体</returns>
		public static DiggDao GetInstance()
		{
			// 通用的必要代码 iBatisNet双校检机制,如果实例不存在
			if (m_instance == null)
			{
				lock (typeof (DiggDao))
				{

					// 如果实例不存在
					if (m_instance == null)
					{

						// 创建一个的实例
						m_instance = new DiggDao();
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
		//private static Digg DataReaderToEntity(IDataReader dataReader)
		//{
		//	Digg obj = null;			
        //    while (dataReader.Read())
        //    {
		//		obj = new Digg();
		
		//
		//	}
		//	return obj;
		//}	
		/// <summary>
        /// 将DataReader的属性值转化为实体类的属性值，返回实体类
        /// </summary>
        /// <param name="dataReader">有效的DataReader对象</param>
        /// <returns>实体类对象</returns>
        private Digg DataRowToEntity(DataRow dataReader)
        {            
			Digg obj = new Digg();
		
		
		 if (dataReader["Seqno"]!= DBNull.Value) obj.Seqno = (int)dataReader["Seqno"];
		 if (dataReader["PGUID"]!= DBNull.Value) obj.Pguid = (string)dataReader["PGUID"];
		 if (dataReader["IP"]!= DBNull.Value) obj.Ip = (string)dataReader["IP"];
		 if (dataReader["DiggType"]!= DBNull.Value) obj.Diggtype = (int)dataReader["DiggType"];
		 if (dataReader["CREATE_DATE"]!= DBNull.Value) obj.CreateDate = (DateTime)dataReader["CREATE_DATE"];
			
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
		public int Insert(Digg entity)
		{
			int returnValue = -1;
			using (OleDbConnection connection = new OleDbConnection(connectionString))
            {   
				try
				{
				
					OleDbParameter p;
					string sqlCommand = "Insert into Digg([PGUID],[IP],[DiggType],[CREATE_DATE]) values (?,?,?,?);";
					using (OleDbCommand cmd = new OleDbCommand(sqlCommand,connection))
					{
						connection.Open();					
						
		p = new OleDbParameter("@PGUID",OleDbType.VarChar);
		p.Value = entity.Pguid;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@IP",OleDbType.VarChar);
		p.Value = entity.Ip;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@DiggType",OleDbType.Integer);
		p.Value = entity.Diggtype;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@CREATE_DATE",OleDbType.DBTimeStamp);
		p.Value = DateTime.Parse(entity.CreateDate.ToString("yyyy-MM-dd HH:mm:ss"));
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
		public bool Update(Digg entity)
		{
			bool returnValue = false;
			using (OleDbConnection connection = new OleDbConnection(connectionString))
            { 
			
				try
				{
					OleDbParameter p;
					string sqlCommand = "Update Digg Set [PGUID] = ?,[IP] = ?,[DiggType] = ?,[CREATE_DATE] = ? where [Seqno] =?  ";
					using (OleDbCommand cmd = new OleDbCommand(sqlCommand,connection))
					{
						connection.Open();					
						
		p = new OleDbParameter("@PGUID",OleDbType.VarChar);
		p.Value = entity.Pguid;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@IP",OleDbType.VarChar);
		p.Value = entity.Ip;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@DiggType",OleDbType.Integer);
		p.Value = entity.Diggtype;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@CREATE_DATE",OleDbType.DBTimeStamp);
		p.Value = DateTime.Parse(entity.CreateDate.ToString("yyyy-MM-dd HH:mm:ss"));
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
		public Digg SelectByID(Digg.Key entity)
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
		public DataRow SelectRowByID(Digg.Key entity)
        {
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
            
				try
				{
					OleDbParameter p;
					string sqlCommand = " select * From Digg where [Seqno] = ?    ";
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
			
				string sqlCommand = "   select * From Digg  ";
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
		public bool DeleteByID(Digg.Key entity)
        {
			try
			{
				using (OleDbConnection connection = new OleDbConnection(connectionString))
				{
            	
					OleDbParameter p;
					string sqlCommand = " delete From Digg where [Seqno] = ?    ";
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
		