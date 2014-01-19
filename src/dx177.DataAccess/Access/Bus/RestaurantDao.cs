/*
版权所有：版权所有(C) 2012，321Nets
文件编号：M01_RestaurantDao.cs
文件名称：RestaurantBLL.cs
系统编号：Z0003007
系统名称：通用办公系统
模块编号：M01
模块名称：信息发布
设计文档：IOA_M01信息发布XDE建模.mdx
完成日期：2012/6/22
作　　者：
内容摘要：表[Restaurant]对应的业务逻辑 BLL
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
	/// Restaurant的BLL
	/// 该BLL已经生成了基本的业务操作，在自动生成的方法中已经提供了事务机制
	/// </summary>
	public class RestaurantDao 
	{
		#region 自动生成代码：取得相关实体

		//数据库连接字符串(web.config来配置)
		//<add key="ConnectionString" value="Provider=Microsoft.Jet.OLEDB.4.0; Data Source=D:\\db1.mdb" />
		
		protected static string connectionString =
			string.Format(ConfigurationSettings.AppSettings["ConnectionNewString"],
			              System.Web.HttpContext.Current.Request.PhysicalApplicationPath);

		/// <summary>
		/// 方法名称: RestaurantDao
		/// 内容摘要: 构造函数进行初始化
		/// </summary>
		protected RestaurantDao()
		{
		}

		private static volatile RestaurantDao m_instance = null;
		/// <summary>
		/// 方法名称: GetInstance
		/// 内容摘要: 取得 RestaurantDao 对象
		/// </summary>
		/// <returns>返回一个已经存在的实体</returns>
		public static RestaurantDao GetInstance()
		{
			// 通用的必要代码 iBatisNet双校检机制,如果实例不存在
			if (m_instance == null)
			{
				lock (typeof (RestaurantDao))
				{

					// 如果实例不存在
					if (m_instance == null)
					{

						// 创建一个的实例
						m_instance = new RestaurantDao();
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
		//private static Restaurant DataReaderToEntity(IDataReader dataReader)
		//{
		//	Restaurant obj = null;			
        //    while (dataReader.Read())
        //    {
		//		obj = new Restaurant();
		
		//
		//	}
		//	return obj;
		//}	
		/// <summary>
        /// 将DataReader的属性值转化为实体类的属性值，返回实体类
        /// </summary>
        /// <param name="dataReader">有效的DataReader对象</param>
        /// <returns>实体类对象</returns>
        private Restaurant DataRowToEntity(DataRow dataReader)
        {            
			Restaurant obj = new Restaurant();
		
		
		 if (dataReader["Seqno"]!= DBNull.Value) obj.Seqno = (int)dataReader["Seqno"];
		 if (dataReader["Guid"]!= DBNull.Value) obj.Guid = (string)dataReader["Guid"];
		 if (dataReader["Title"]!= DBNull.Value) obj.Title = (string)dataReader["Title"];
		 if (dataReader["Address"]!= DBNull.Value) obj.Address = (string)dataReader["Address"];
		 if (dataReader["RestaurantType"]!= DBNull.Value) obj.Restauranttype = (string)dataReader["RestaurantType"];
		 if (dataReader["Area"]!= DBNull.Value) obj.Area = (string)dataReader["Area"];
		 if (dataReader["City"]!= DBNull.Value) obj.City = (string)dataReader["City"];
		 if (dataReader["county"]!= DBNull.Value) obj.County = (string)dataReader["county"];
		 if (dataReader["Line"]!= DBNull.Value) obj.Line = (string)dataReader["Line"];
		 if (dataReader["LinkMan"]!= DBNull.Value) obj.Linkman = (string)dataReader["LinkMan"];
		 if (dataReader["Cost"]!= DBNull.Value) obj.Cost = (double)dataReader["Cost"];
		 if (dataReader["shortContent"]!= DBNull.Value) obj.Shortcontent = (string)dataReader["shortContent"];
		 if (dataReader["TelNumber"]!= DBNull.Value) obj.Telnumber = (string)dataReader["TelNumber"];
		 if (dataReader["Content"]!= DBNull.Value) obj.Content = (string)dataReader["Content"];
		 if (dataReader["Map"]!= DBNull.Value) obj.Map = (string)dataReader["Map"];
		 if (dataReader["Logo"]!= DBNull.Value) obj.Logo = (string)dataReader["Logo"];
		 if (dataReader["Status"]!= DBNull.Value) obj.Status = (int)dataReader["Status"];
		 if (dataReader["QQ"]!= DBNull.Value) obj.Qq = (string)dataReader["QQ"];
		 if (dataReader["aliww"]!= DBNull.Value) obj.Aliww = (string)dataReader["aliww"];
		 if (dataReader["CREATOR"]!= DBNull.Value) obj.Creator = (string)dataReader["CREATOR"];
		 if (dataReader["CREATE_DATE"]!= DBNull.Value) obj.CreateDate = (DateTime)dataReader["CREATE_DATE"];
		 if (dataReader["Laste_update_date"]!= DBNull.Value) obj.LasteUpdateDate = (DateTime)dataReader["Laste_update_date"];
		 if (dataReader["Laste_update_By"]!= DBNull.Value) obj.LasteUpdateBy = (string)dataReader["Laste_update_By"];
		 if (dataReader["Tag"]!= DBNull.Value) obj.Tag = (string)dataReader["Tag"];
		 if (dataReader["Favorable"]!= DBNull.Value) obj.Favorable = (string)dataReader["Favorable"];
		 if (dataReader["ViewTimes"]!= DBNull.Value) obj.Viewtimes = (int)dataReader["ViewTimes"];
		 if (dataReader["ShowPr"]!= DBNull.Value) obj.Showpr = (int)dataReader["ShowPr"];
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
		public int Insert(Restaurant entity)
		{
			int returnValue = -1;
			using (OleDbConnection connection = new OleDbConnection(connectionString))
            {   
				try
				{
				
					OleDbParameter p;
					string sqlCommand = "Insert into Restaurant([Guid],[Title],[Address],[RestaurantType],[Area],[City],[county],[Line],[LinkMan],[Cost],[shortContent],[TelNumber],[Content],[Map],[Logo],[Status],[QQ],[aliww],[CREATOR],[CREATE_DATE],[Laste_update_date],[Laste_update_By],[Tag],[Favorable],[ViewTimes],[ShowPr],[JingQuCode]) values (?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?);";
					using (OleDbCommand cmd = new OleDbCommand(sqlCommand,connection))
					{
						connection.Open();					
						
		p = new OleDbParameter("@Guid",OleDbType.VarChar);
		p.Value = entity.Guid;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@Title",OleDbType.VarChar);
		p.Value = entity.Title;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@Address",OleDbType.VarChar);
		p.Value = entity.Address;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@RestaurantType",OleDbType.VarChar);
		p.Value = entity.Restauranttype;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@Area",OleDbType.VarChar);
		p.Value = entity.Area;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@City",OleDbType.VarChar);
		p.Value = entity.City;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@county",OleDbType.VarChar);
		p.Value = entity.County;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@Line",OleDbType.VarChar);
		p.Value = entity.Line;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@LinkMan",OleDbType.VarChar);
		p.Value = entity.Linkman;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@Cost",OleDbType.Double);
		p.Value = entity.Cost;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@shortContent",OleDbType.VarChar);
		p.Value = entity.Shortcontent;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@TelNumber",OleDbType.VarChar);
		p.Value = entity.Telnumber;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@Content",OleDbType.VarChar);
		p.Value = entity.Content;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@Map",OleDbType.VarChar);
		p.Value = entity.Map;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@Logo",OleDbType.VarChar);
		p.Value = entity.Logo;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@Status",OleDbType.Integer);
		p.Value = entity.Status;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@QQ",OleDbType.VarChar);
		p.Value = entity.Qq;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@aliww",OleDbType.VarChar);
		p.Value = entity.Aliww;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@CREATOR",OleDbType.VarChar);
		p.Value = entity.Creator;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@CREATE_DATE",OleDbType.DBTimeStamp);
		p.Value = DateTime.Parse(entity.CreateDate.ToString("yyyy-MM-dd HH:mm:ss"));
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@Laste_update_date",OleDbType.DBTimeStamp);
		p.Value = DateTime.Parse(entity.LasteUpdateDate.ToString("yyyy-MM-dd HH:mm:ss"));
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@Laste_update_By",OleDbType.VarChar);
		p.Value = entity.LasteUpdateBy;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@Tag",OleDbType.VarChar);
		p.Value = entity.Tag;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@Favorable",OleDbType.VarChar);
		p.Value = entity.Favorable;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@ViewTimes",OleDbType.Integer);
		p.Value = entity.Viewtimes;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@ShowPr",OleDbType.Integer);
		p.Value = entity.Showpr;
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
		public bool Update(Restaurant entity)
		{
			bool returnValue = false;
			using (OleDbConnection connection = new OleDbConnection(connectionString))
            { 
			
				try
				{
					OleDbParameter p;
					string sqlCommand = "Update Restaurant Set [Guid] = ?,[Title] = ?,[Address] = ?,[RestaurantType] = ?,[Area] = ?,[City] = ?,[county] = ?,[Line] = ?,[LinkMan] = ?,[Cost] = ?,[shortContent] = ?,[TelNumber] = ?,[Content] = ?,[Map] = ?,[Logo] = ?,[Status] = ?,[QQ] = ?,[aliww] = ?,[CREATOR] = ?,[CREATE_DATE] = ?,[Laste_update_date] = ?,[Laste_update_By] = ?,[Tag] = ?,[Favorable] = ?,[ViewTimes] = ?,[ShowPr] = ?,[JingQuCode] = ? where [Seqno] =?  ";
					using (OleDbCommand cmd = new OleDbCommand(sqlCommand,connection))
					{
						connection.Open();					
						
		p = new OleDbParameter("@Guid",OleDbType.VarChar);
		p.Value = entity.Guid;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@Title",OleDbType.VarChar);
		p.Value = entity.Title;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@Address",OleDbType.VarChar);
		p.Value = entity.Address;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@RestaurantType",OleDbType.VarChar);
		p.Value = entity.Restauranttype;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@Area",OleDbType.VarChar);
		p.Value = entity.Area;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@City",OleDbType.VarChar);
		p.Value = entity.City;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@county",OleDbType.VarChar);
		p.Value = entity.County;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@Line",OleDbType.VarChar);
		p.Value = entity.Line;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@LinkMan",OleDbType.VarChar);
		p.Value = entity.Linkman;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@Cost",OleDbType.Double);
		p.Value = entity.Cost;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@shortContent",OleDbType.VarChar);
		p.Value = entity.Shortcontent;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@TelNumber",OleDbType.VarChar);
		p.Value = entity.Telnumber;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@Content",OleDbType.VarChar);
		p.Value = entity.Content;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@Map",OleDbType.VarChar);
		p.Value = entity.Map;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@Logo",OleDbType.VarChar);
		p.Value = entity.Logo;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@Status",OleDbType.Integer);
		p.Value = entity.Status;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@QQ",OleDbType.VarChar);
		p.Value = entity.Qq;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@aliww",OleDbType.VarChar);
		p.Value = entity.Aliww;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@CREATOR",OleDbType.VarChar);
		p.Value = entity.Creator;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@CREATE_DATE",OleDbType.DBTimeStamp);
		p.Value = DateTime.Parse(entity.CreateDate.ToString("yyyy-MM-dd HH:mm:ss"));
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@Laste_update_date",OleDbType.DBTimeStamp);
		p.Value = DateTime.Parse(entity.LasteUpdateDate.ToString("yyyy-MM-dd HH:mm:ss"));
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@Laste_update_By",OleDbType.VarChar);
		p.Value = entity.LasteUpdateBy;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@Tag",OleDbType.VarChar);
		p.Value = entity.Tag;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@Favorable",OleDbType.VarChar);
		p.Value = entity.Favorable;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@ViewTimes",OleDbType.Integer);
		p.Value = entity.Viewtimes;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@ShowPr",OleDbType.Integer);
		p.Value = entity.Showpr;
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
		public Restaurant SelectByID(Restaurant.Key entity)
        {
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
            
				try
				{
					OleDbParameter p;
					string sqlCommand = " select * From Restaurant where [Seqno] = ?    ";
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
			
				string sqlCommand = "   select * From Restaurant  ";
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
		public bool DeleteByID(Restaurant.Key entity)
        {
			try
			{
				using (OleDbConnection connection = new OleDbConnection(connectionString))
				{
            	
					OleDbParameter p;
					string sqlCommand = " delete From Restaurant where [Seqno] = ?    ";
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
		