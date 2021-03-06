/*
版权所有：版权所有(C) 2012，321Nets
文件编号：M01_ResuserDao.cs
文件名称：ResuserBLL.cs
系统编号：Z0003007
系统名称：通用办公系统
模块编号：M01
模块名称：信息发布
设计文档：IOA_M01信息发布XDE建模.mdx
完成日期：2012-6-20
作　　者：
内容摘要：表[ResUser]对应的业务逻辑 BLL
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
	/// Resuser的BLL
	/// 该BLL已经生成了基本的业务操作，在自动生成的方法中已经提供了事务机制
	/// </summary>
	public class ResuserDao 
	{
		#region 自动生成代码：取得相关实体

		//数据库连接字符串(web.config来配置)
		//<add key="ConnectionString" value="Provider=Microsoft.Jet.OLEDB.4.0; Data Source=D:\\db1.mdb" />
		
		protected static string connectionString =
			string.Format(ConfigurationSettings.AppSettings["ConnectionNewString"],
			              System.Web.HttpContext.Current.Request.PhysicalApplicationPath);

		/// <summary>
		/// 方法名称: ResuserDao
		/// 内容摘要: 构造函数进行初始化
		/// </summary>
		protected ResuserDao()
		{
		}

		private static volatile ResuserDao m_instance = null;
		/// <summary>
		/// 方法名称: GetInstance
		/// 内容摘要: 取得 ResuserDao 对象
		/// </summary>
		/// <returns>返回一个已经存在的实体</returns>
		public static ResuserDao GetInstance()
		{
			// 通用的必要代码 iBatisNet双校检机制,如果实例不存在
			if (m_instance == null)
			{
				lock (typeof (ResuserDao))
				{

					// 如果实例不存在
					if (m_instance == null)
					{

						// 创建一个的实例
						m_instance = new ResuserDao();
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
		//private static Resuser DataReaderToEntity(IDataReader dataReader)
		//{
		//	Resuser obj = null;			
        //    while (dataReader.Read())
        //    {
		//		obj = new Resuser();
		
		//
		//	}
		//	return obj;
		//}	
		/// <summary>
        /// 将DataReader的属性值转化为实体类的属性值，返回实体类
        /// </summary>
        /// <param name="dataReader">有效的DataReader对象</param>
        /// <returns>实体类对象</returns>
        private Resuser DataRowToEntity(DataRow dataReader)
        {            
			Resuser obj = new Resuser();
		
		
		 if (dataReader["Seqno"]!= DBNull.Value) obj.Seqno = (int)dataReader["Seqno"];
		 if (dataReader["GUID"]!= DBNull.Value) obj.Guid = (string)dataReader["GUID"];
		 if (dataReader["UserName"]!= DBNull.Value) obj.Username = (string)dataReader["UserName"];
		 if (dataReader["Name"]!= DBNull.Value) obj.Name = (string)dataReader["Name"];
		 if (dataReader["Pwd"]!= DBNull.Value) obj.Pwd = (string)dataReader["Pwd"];
		 if (dataReader["Status"]!= DBNull.Value) obj.Status = (int)dataReader["Status"];
		 if (dataReader["Sex"]!= DBNull.Value) obj.Sex = (string)dataReader["Sex"];
		 if (dataReader["brithday"]!= DBNull.Value) obj.Brithday = (string)dataReader["brithday"];
		 if (dataReader["Email"]!= DBNull.Value) obj.Email = (string)dataReader["Email"];
		 if (dataReader["Mobile"]!= DBNull.Value) obj.Mobile = (string)dataReader["Mobile"];
		 if (dataReader["Msn"]!= DBNull.Value) obj.Msn = (string)dataReader["Msn"];
		 if (dataReader["QQ"]!= DBNull.Value) obj.Qq = (string)dataReader["QQ"];
		 if (dataReader["CREATE_DATE"]!= DBNull.Value) obj.CreateDate = (DateTime)dataReader["CREATE_DATE"];
		 if (dataReader["Laste_update_date"]!= DBNull.Value) obj.LasteUpdateDate = (DateTime)dataReader["Laste_update_date"];
		 if (dataReader["UserType"]!= DBNull.Value) obj.Usertype = (string)dataReader["UserType"];
		 if (dataReader["IsSubdomain"]!= DBNull.Value) obj.Issubdomain = (int)dataReader["IsSubdomain"];
		 if (dataReader["domainName"]!= DBNull.Value) obj.Domainname = (string)dataReader["domainName"];
		 if (dataReader["Phone"]!= DBNull.Value) obj.Phone = (string)dataReader["Phone"];
		 if (dataReader["ShortContent"]!= DBNull.Value) obj.Shortcontent = (string)dataReader["ShortContent"];
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
		public int Insert(Resuser entity)
		{
			int returnValue = -1;
			using (OleDbConnection connection = new OleDbConnection(connectionString))
            {   
				try
				{
				
					OleDbParameter p;
					string sqlCommand = "Insert into ResUser([GUID],[UserName],[Name],[Pwd],[Status],[Sex],[brithday],[Email],[Mobile],[Msn],[QQ],[CREATE_DATE],[Laste_update_date],[UserType],[IsSubdomain],[domainName],[Phone],[ShortContent],[JingQuCode]) values (?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?);";
					using (OleDbCommand cmd = new OleDbCommand(sqlCommand,connection))
					{
						connection.Open();					
						
		p = new OleDbParameter("@GUID",OleDbType.VarChar);
		p.Value = entity.Guid;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@UserName",OleDbType.VarChar);
		p.Value = entity.Username;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@Name",OleDbType.VarChar);
		p.Value = entity.Name;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@Pwd",OleDbType.VarChar);
		p.Value = entity.Pwd;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@Status",OleDbType.Integer);
		p.Value = entity.Status;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@Sex",OleDbType.VarChar);
		p.Value = entity.Sex;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@brithday",OleDbType.VarChar);
		p.Value = entity.Brithday;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@Email",OleDbType.VarChar);
		p.Value = entity.Email;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@Mobile",OleDbType.VarChar);
		p.Value = entity.Mobile;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@Msn",OleDbType.VarChar);
		p.Value = entity.Msn;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@QQ",OleDbType.VarChar);
		p.Value = entity.Qq;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@CREATE_DATE",OleDbType.DBTimeStamp);
		p.Value = DateTime.Parse(entity.CreateDate.ToString("yyyy-MM-dd HH:mm:ss"));
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@Laste_update_date",OleDbType.DBTimeStamp);
		p.Value = DateTime.Parse(entity.LasteUpdateDate.ToString("yyyy-MM-dd HH:mm:ss"));
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@UserType",OleDbType.VarChar);
		p.Value = entity.Usertype;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@IsSubdomain",OleDbType.Integer);
		p.Value = entity.Issubdomain;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@domainName",OleDbType.VarChar);
		p.Value = entity.Domainname;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@Phone",OleDbType.VarChar);
		p.Value = entity.Phone;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@ShortContent",OleDbType.VarChar);
		p.Value = entity.Shortcontent;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@JingQuCode",OleDbType.VarChar);
		p.Value = entity.Jingqucode;
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
		public bool Update(Resuser entity)
		{
			bool returnValue = false;
			using (OleDbConnection connection = new OleDbConnection(connectionString))
            { 
			
				try
				{
					OleDbParameter p;
					string sqlCommand = "Update ResUser Set [GUID] = ?,[UserName] = ?,[Name] = ?,[Pwd] = ?,[Status] = ?,[Sex] = ?,[brithday] = ?,[Email] = ?,[Mobile] = ?,[Msn] = ?,[QQ] = ?,[CREATE_DATE] = ?,[Laste_update_date] = ?,[UserType] = ?,[IsSubdomain] = ?,[domainName] = ?,[Phone] = ?,[ShortContent] = ?,[JingQuCode] = ? where [Seqno] =?  ";
					using (OleDbCommand cmd = new OleDbCommand(sqlCommand,connection))
					{
						connection.Open();					
						
		p = new OleDbParameter("@GUID",OleDbType.VarChar);
		p.Value = entity.Guid;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@UserName",OleDbType.VarChar);
		p.Value = entity.Username;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@Name",OleDbType.VarChar);
		p.Value = entity.Name;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@Pwd",OleDbType.VarChar);
		p.Value = entity.Pwd;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@Status",OleDbType.Integer);
		p.Value = entity.Status;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@Sex",OleDbType.VarChar);
		p.Value = entity.Sex;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@brithday",OleDbType.VarChar);
		p.Value = entity.Brithday;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@Email",OleDbType.VarChar);
		p.Value = entity.Email;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@Mobile",OleDbType.VarChar);
		p.Value = entity.Mobile;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@Msn",OleDbType.VarChar);
		p.Value = entity.Msn;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@QQ",OleDbType.VarChar);
		p.Value = entity.Qq;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@CREATE_DATE",OleDbType.DBTimeStamp);
		p.Value = DateTime.Parse(entity.CreateDate.ToString("yyyy-MM-dd HH:mm:ss"));
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@Laste_update_date",OleDbType.DBTimeStamp);
		p.Value = DateTime.Parse(entity.LasteUpdateDate.ToString("yyyy-MM-dd HH:mm:ss"));
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@UserType",OleDbType.VarChar);
		p.Value = entity.Usertype;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@IsSubdomain",OleDbType.Integer);
		p.Value = entity.Issubdomain;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@domainName",OleDbType.VarChar);
		p.Value = entity.Domainname;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@Phone",OleDbType.VarChar);
		p.Value = entity.Phone;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@ShortContent",OleDbType.VarChar);
		p.Value = entity.Shortcontent;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@JingQuCode",OleDbType.VarChar);
		p.Value = entity.Jingqucode;
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
		public Resuser SelectByID(Resuser.Key entity)
        {
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
            
				try
				{
					OleDbParameter p;
					string sqlCommand = " select * From ResUser where [Seqno] = ?    ";
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
			
				string sqlCommand = "   select * From ResUser  ";
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
		public bool DeleteByID(Resuser.Key entity)
        {
			try
			{
				using (OleDbConnection connection = new OleDbConnection(connectionString))
				{
            	
					OleDbParameter p;
					string sqlCommand = " delete From ResUser where [Seqno] = ?    ";
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
		