/*
版权所有：版权所有(C) 2012，321Nets
文件编号：M01_NewsDao.cs
文件名称：NewsBLL.cs
系统编号：Z0003007
系统名称：通用办公系统
模块编号：M01
模块名称：信息发布
设计文档：IOA_M01信息发布XDE建模.mdx
完成日期：2012/6/22
作　　者：
内容摘要：表[News]对应的业务逻辑 BLL
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
	/// News的BLL
	/// 该BLL已经生成了基本的业务操作，在自动生成的方法中已经提供了事务机制
	/// </summary>
	public class NewsDao 
	{
		#region 自动生成代码：取得相关实体

		//数据库连接字符串(web.config来配置)
		//<add key="ConnectionString" value="Provider=Microsoft.Jet.OLEDB.4.0; Data Source=D:\\db1.mdb" />
		
		protected static string connectionString =
			string.Format(ConfigurationSettings.AppSettings["ConnectionNewString"],
			              System.Web.HttpContext.Current.Request.PhysicalApplicationPath);

		/// <summary>
		/// 方法名称: NewsDao
		/// 内容摘要: 构造函数进行初始化
		/// </summary>
		protected NewsDao()
		{
		}

		private static volatile NewsDao m_instance = null;
		/// <summary>
		/// 方法名称: GetInstance
		/// 内容摘要: 取得 NewsDao 对象
		/// </summary>
		/// <returns>返回一个已经存在的实体</returns>
		public static NewsDao GetInstance()
		{
			// 通用的必要代码 iBatisNet双校检机制,如果实例不存在
			if (m_instance == null)
			{
				lock (typeof (NewsDao))
				{

					// 如果实例不存在
					if (m_instance == null)
					{

						// 创建一个的实例
						m_instance = new NewsDao();
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
		//private static News DataReaderToEntity(IDataReader dataReader)
		//{
		//	News obj = null;			
        //    while (dataReader.Read())
        //    {
		//		obj = new News();
		
		//
		//	}
		//	return obj;
		//}	
		/// <summary>
        /// 将DataReader的属性值转化为实体类的属性值，返回实体类
        /// </summary>
        /// <param name="dataReader">有效的DataReader对象</param>
        /// <returns>实体类对象</returns>
        private News DataRowToEntity(DataRow dataReader)
        {            
			News obj = new News();
		
		
		 if (dataReader["Seqno"]!= DBNull.Value) obj.Seqno = (int)dataReader["Seqno"];
		 if (dataReader["GUID"]!= DBNull.Value) obj.Guid = (string)dataReader["GUID"];
		 if (dataReader["TGUID"]!= DBNull.Value) obj.Tguid = (string)dataReader["TGUID"];
		 if (dataReader["Title"]!= DBNull.Value) obj.Title = (string)dataReader["Title"];
		 if (dataReader["ShortContent"]!= DBNull.Value) obj.Shortcontent = (string)dataReader["ShortContent"];
		 if (dataReader["Code"]!= DBNull.Value) obj.Code = (string)dataReader["Code"];
		 if (dataReader["Content"]!= DBNull.Value) obj.Content = (string)dataReader["Content"];
		 if (dataReader["ViewTimes"]!= DBNull.Value) obj.Viewtimes = (int)dataReader["ViewTimes"];
		 if (dataReader["Laste_update_date"]!= DBNull.Value) obj.LasteUpdateDate = (DateTime)dataReader["Laste_update_date"];
		 if (dataReader["Laste_update_By"]!= DBNull.Value) obj.LasteUpdateBy = (string)dataReader["Laste_update_By"];
		 if (dataReader["IsFirst"]!= DBNull.Value) obj.Isfirst = (int)dataReader["IsFirst"];
		 if (dataReader["IsHot"]!= DBNull.Value) obj.Ishot = (int)dataReader["IsHot"];
		 if (dataReader["IsComment"]!= DBNull.Value) obj.Iscomment = (int)dataReader["IsComment"];
		 if (dataReader["Logo"]!= DBNull.Value) obj.Logo = (string)dataReader["Logo"];
		 if (dataReader["CREATOR"]!= DBNull.Value) obj.Creator = (string)dataReader["CREATOR"];
		 if (dataReader["CREATE_DATE"]!= DBNull.Value) obj.CreateDate = (DateTime)dataReader["CREATE_DATE"];
		 if (dataReader["Good"]!= DBNull.Value) obj.Good = (int)dataReader["Good"];
		 if (dataReader["Bad"]!= DBNull.Value) obj.Bad = (int)dataReader["Bad"];
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
		public int Insert(News entity)
		{
			int returnValue = -1;
			using (OleDbConnection connection = new OleDbConnection(connectionString))
            {   
				try
				{
				
					OleDbParameter p;
					string sqlCommand = "Insert into News([GUID],[TGUID],[Title],[ShortContent],[Code],[Content],[ViewTimes],[Laste_update_date],[Laste_update_By],[IsFirst],[IsHot],[IsComment],[Logo],[CREATOR],[CREATE_DATE],[Good],[Bad],[ShowPr],[JingQuCode]) values (?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?);";
					using (OleDbCommand cmd = new OleDbCommand(sqlCommand,connection))
					{
						connection.Open();					
						
		p = new OleDbParameter("@GUID",OleDbType.VarChar);
		p.Value = entity.Guid;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@TGUID",OleDbType.VarChar);
		p.Value = entity.Tguid;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@Title",OleDbType.VarChar);
		p.Value = entity.Title;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@ShortContent",OleDbType.VarChar);
		p.Value = entity.Shortcontent;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@Code",OleDbType.VarChar);
		p.Value = entity.Code;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@Content",OleDbType.VarChar);
		p.Value = entity.Content;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@ViewTimes",OleDbType.Integer);
		p.Value = entity.Viewtimes;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@Laste_update_date",OleDbType.DBTimeStamp);
		p.Value = DateTime.Parse(entity.LasteUpdateDate.ToString("yyyy-MM-dd HH:mm:ss"));
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@Laste_update_By",OleDbType.VarChar);
		p.Value = entity.LasteUpdateBy;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@IsFirst",OleDbType.Integer);
		p.Value = entity.Isfirst;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@IsHot",OleDbType.Integer);
		p.Value = entity.Ishot;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@IsComment",OleDbType.Integer);
		p.Value = entity.Iscomment;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@Logo",OleDbType.VarChar);
		p.Value = entity.Logo;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@CREATOR",OleDbType.VarChar);
		p.Value = entity.Creator;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@CREATE_DATE",OleDbType.DBTimeStamp);
		p.Value = DateTime.Parse(entity.CreateDate.ToString("yyyy-MM-dd HH:mm:ss"));
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@Good",OleDbType.Integer);
		p.Value = entity.Good;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@Bad",OleDbType.Integer);
		p.Value = entity.Bad;
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
		public bool Update(News entity)
		{
			bool returnValue = false;
			using (OleDbConnection connection = new OleDbConnection(connectionString))
            { 
			
				try
				{
					OleDbParameter p;
					string sqlCommand = "Update News Set [GUID] = ?,[TGUID] = ?,[Title] = ?,[ShortContent] = ?,[Code] = ?,[Content] = ?,[ViewTimes] = ?,[Laste_update_date] = ?,[Laste_update_By] = ?,[IsFirst] = ?,[IsHot] = ?,[IsComment] = ?,[Logo] = ?,[CREATOR] = ?,[CREATE_DATE] = ?,[Good] = ?,[Bad] = ?,[ShowPr] = ?,[JingQuCode] = ? where [Seqno] =?  ";
					using (OleDbCommand cmd = new OleDbCommand(sqlCommand,connection))
					{
						connection.Open();					
						
		p = new OleDbParameter("@GUID",OleDbType.VarChar);
		p.Value = entity.Guid;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@TGUID",OleDbType.VarChar);
		p.Value = entity.Tguid;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@Title",OleDbType.VarChar);
		p.Value = entity.Title;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@ShortContent",OleDbType.VarChar);
		p.Value = entity.Shortcontent;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@Code",OleDbType.VarChar);
		p.Value = entity.Code;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@Content",OleDbType.VarChar);
		p.Value = entity.Content;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@ViewTimes",OleDbType.Integer);
		p.Value = entity.Viewtimes;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@Laste_update_date",OleDbType.DBTimeStamp);
		p.Value = DateTime.Parse(entity.LasteUpdateDate.ToString("yyyy-MM-dd HH:mm:ss"));
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@Laste_update_By",OleDbType.VarChar);
		p.Value = entity.LasteUpdateBy;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@IsFirst",OleDbType.Integer);
		p.Value = entity.Isfirst;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@IsHot",OleDbType.Integer);
		p.Value = entity.Ishot;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@IsComment",OleDbType.Integer);
		p.Value = entity.Iscomment;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@Logo",OleDbType.VarChar);
		p.Value = entity.Logo;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@CREATOR",OleDbType.VarChar);
		p.Value = entity.Creator;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@CREATE_DATE",OleDbType.DBTimeStamp);
		p.Value = DateTime.Parse(entity.CreateDate.ToString("yyyy-MM-dd HH:mm:ss"));
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@Good",OleDbType.Integer);
		p.Value = entity.Good;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@Bad",OleDbType.Integer);
		p.Value = entity.Bad;
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
		public News SelectByID(News.Key entity)
        {
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
            
				try
				{
					OleDbParameter p;
					string sqlCommand = " select * From News where [Seqno] = ?    ";
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
			
				string sqlCommand = "   select * From News  ";
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
		public bool DeleteByID(News.Key entity)
        {
			try
			{
				using (OleDbConnection connection = new OleDbConnection(connectionString))
				{
            	
					OleDbParameter p;
					string sqlCommand = " delete From News where [Seqno] = ?    ";
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
		