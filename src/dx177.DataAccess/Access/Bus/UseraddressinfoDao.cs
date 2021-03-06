/*
版权所有：版权所有(C) 2011，321Nets
文件编号：M01_UseraddressinfoDao.cs
文件名称：UseraddressinfoBLL.cs
系统编号：Z0003007
系统名称：通用办公系统
模块编号：M01
模块名称：信息发布
设计文档：IOA_M01信息发布XDE建模.mdx
完成日期：2011-04-30
作　　者：
内容摘要：表[UserAddressInfo]对应的业务逻辑 BLL
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
	/// Useraddressinfo的BLL
	/// 该BLL已经生成了基本的业务操作，在自动生成的方法中已经提供了事务机制
	/// </summary>
	public class UseraddressinfoDao 
	{
		#region 自动生成代码：取得相关实体

		//数据库连接字符串(web.config来配置)
		//<add key="ConnectionString" value="Provider=Microsoft.Jet.OLEDB.4.0; Data Source=D:\\db1.mdb" />
		
		protected static string connectionString =
			string.Format(ConfigurationSettings.AppSettings["ConnectionNewString"],
			              System.Web.HttpContext.Current.Request.PhysicalApplicationPath);

		/// <summary>
		/// 方法名称: UseraddressinfoDao
		/// 内容摘要: 构造函数进行初始化
		/// </summary>
		protected UseraddressinfoDao()
		{
		}

		private static volatile UseraddressinfoDao m_instance = null;
		/// <summary>
		/// 方法名称: GetInstance
		/// 内容摘要: 取得 UseraddressinfoDao 对象
		/// </summary>
		/// <returns>返回一个已经存在的实体</returns>
		public static UseraddressinfoDao GetInstance()
		{
			// 通用的必要代码 iBatisNet双校检机制,如果实例不存在
			if (m_instance == null)
			{
				lock (typeof (UseraddressinfoDao))
				{

					// 如果实例不存在
					if (m_instance == null)
					{

						// 创建一个的实例
						m_instance = new UseraddressinfoDao();
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
		//private static Useraddressinfo DataReaderToEntity(IDataReader dataReader)
		//{
		//	Useraddressinfo obj = null;			
        //    while (dataReader.Read())
        //    {
		//		obj = new Useraddressinfo();
		
		//
		//	}
		//	return obj;
		//}	
		/// <summary>
        /// 将DataReader的属性值转化为实体类的属性值，返回实体类
        /// </summary>
        /// <param name="dataReader">有效的DataReader对象</param>
        /// <returns>实体类对象</returns>
        private Useraddressinfo DataRowToEntity(DataRow dataReader)
        {            
			Useraddressinfo obj = new Useraddressinfo();
		
		
		 if (dataReader["seqno"]!= DBNull.Value) obj.Seqno = (int)dataReader["seqno"];
		 if (dataReader["Consigneename"]!= DBNull.Value) obj.Consigneename = (string)dataReader["Consigneename"];
		 if (dataReader["Receive_email"]!= DBNull.Value) obj.ReceiveEmail = (string)dataReader["Receive_email"];
		 if (dataReader["Country"]!= DBNull.Value) obj.Country = (string)dataReader["Country"];
		 if (dataReader["ContryCode"]!= DBNull.Value) obj.Contrycode = (string)dataReader["ContryCode"];
		 if (dataReader["State"]!= DBNull.Value) obj.State = (string)dataReader["State"];
		 if (dataReader["City"]!= DBNull.Value) obj.City = (string)dataReader["City"];
		 if (dataReader["Zip"]!= DBNull.Value) obj.Zip = (string)dataReader["Zip"];
		 if (dataReader["Receive_phone"]!= DBNull.Value) obj.ReceivePhone = (string)dataReader["Receive_phone"];
		 if (dataReader["Receive_tel"]!= DBNull.Value) obj.ReceiveTel = (string)dataReader["Receive_tel"];
		 if (dataReader["receive_address"]!= DBNull.Value) obj.ReceiveAddress = (string)dataReader["receive_address"];
		 if (dataReader["receive_address1"]!= DBNull.Value) obj.ReceiveAddress1 = (string)dataReader["receive_address1"];
		 if (dataReader["Res_User_NO"]!= DBNull.Value) obj.ResUserNo = (string)dataReader["Res_User_NO"];
			
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
		public int Insert(Useraddressinfo entity)
		{
			int returnValue = -1;
			using (OleDbConnection connection = new OleDbConnection(connectionString))
            {   
				try
				{
				
					OleDbParameter p;
					string sqlCommand = "Insert into UserAddressInfo([Consigneename],[Receive_email],[Country],[ContryCode],[State],[City],[Zip],[Receive_phone],[Receive_tel],[receive_address],[receive_address1],[Res_User_NO]) values (?,?,?,?,?,?,?,?,?,?,?,?);";
					using (OleDbCommand cmd = new OleDbCommand(sqlCommand,connection))
					{
						connection.Open();					
						
		p = new OleDbParameter("@Consigneename",OleDbType.VarChar);
		p.Value = entity.Consigneename;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@Receive_email",OleDbType.VarChar);
		p.Value = entity.ReceiveEmail;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@Country",OleDbType.VarChar);
		p.Value = entity.Country;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@ContryCode",OleDbType.VarChar);
		p.Value = entity.Contrycode;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@State",OleDbType.VarChar);
		p.Value = entity.State;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@City",OleDbType.VarChar);
		p.Value = entity.City;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@Zip",OleDbType.VarChar);
		p.Value = entity.Zip;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@Receive_phone",OleDbType.VarChar);
		p.Value = entity.ReceivePhone;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@Receive_tel",OleDbType.VarChar);
		p.Value = entity.ReceiveTel;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@receive_address",OleDbType.VarChar);
		p.Value = entity.ReceiveAddress;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@receive_address1",OleDbType.VarChar);
		p.Value = entity.ReceiveAddress1;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@Res_User_NO",OleDbType.VarChar);
		p.Value = entity.ResUserNo;
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
		public bool Update(Useraddressinfo entity)
		{
			bool returnValue = false;
			using (OleDbConnection connection = new OleDbConnection(connectionString))
            { 
			
				try
				{
					OleDbParameter p;
					string sqlCommand = "Update UserAddressInfo Set [Consigneename] = ?,[Receive_email] = ?,[Country] = ?,[ContryCode] = ?,[State] = ?,[City] = ?,[Zip] = ?,[Receive_phone] = ?,[Receive_tel] = ?,[receive_address] = ?,[receive_address1] = ?,[Res_User_NO] = ? where [seqno] =?  ";
					using (OleDbCommand cmd = new OleDbCommand(sqlCommand,connection))
					{
						connection.Open();					
						
		p = new OleDbParameter("@Consigneename",OleDbType.VarChar);
		p.Value = entity.Consigneename;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@Receive_email",OleDbType.VarChar);
		p.Value = entity.ReceiveEmail;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@Country",OleDbType.VarChar);
		p.Value = entity.Country;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@ContryCode",OleDbType.VarChar);
		p.Value = entity.Contrycode;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@State",OleDbType.VarChar);
		p.Value = entity.State;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@City",OleDbType.VarChar);
		p.Value = entity.City;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@Zip",OleDbType.VarChar);
		p.Value = entity.Zip;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@Receive_phone",OleDbType.VarChar);
		p.Value = entity.ReceivePhone;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@Receive_tel",OleDbType.VarChar);
		p.Value = entity.ReceiveTel;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@receive_address",OleDbType.VarChar);
		p.Value = entity.ReceiveAddress;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@receive_address1",OleDbType.VarChar);
		p.Value = entity.ReceiveAddress1;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@Res_User_NO",OleDbType.VarChar);
		p.Value = entity.ResUserNo;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@seqno",OleDbType.Integer);
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
		public Useraddressinfo SelectByID(Useraddressinfo.Key entity)
        {
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
            
				try
				{
					OleDbParameter p;
					string sqlCommand = " select * From UserAddressInfo where [seqno] = ?    ";
					using (OleDbCommand cmd = new OleDbCommand(sqlCommand,connection))
					{   					
						connection.Open();				
						
		p = new OleDbParameter("@seqno",DbType.Int32);
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
			
				string sqlCommand = "   select * From UserAddressInfo  ";
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
		public bool DeleteByID(Useraddressinfo.Key entity)
        {
			try
			{
				using (OleDbConnection connection = new OleDbConnection(connectionString))
				{
            	
					OleDbParameter p;
					string sqlCommand = " delete From UserAddressInfo where [seqno] = ?    ";
					using (OleDbCommand cmd = new OleDbCommand(sqlCommand,connection))
					{     
						connection.Open();				
						
		p = new OleDbParameter("@seqno",DbType.Int32);
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
		