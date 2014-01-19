/*
版权所有：版权所有(C) 2014，321Nets
文件编号：M01_JingqusDao.cs
文件名称：JingqusBLL.cs
系统编号：Z0003007
系统名称：通用办公系统
模块编号：M01
模块名称：信息发布
设计文档：IOA_M01信息发布XDE建模.mdx
完成日期：2014-1-15
作　　者：
内容摘要：表[JingQus]对应的业务逻辑 BLL
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
	/// Jingqus的BLL
	/// 该BLL已经生成了基本的业务操作，在自动生成的方法中已经提供了事务机制
	/// </summary>
	public class JingqusDao 
	{
		#region 自动生成代码：取得相关实体

		//数据库连接字符串(web.config来配置)
		//<add key="ConnectionString" value="Provider=Microsoft.Jet.OLEDB.4.0; Data Source=D:\\db1.mdb" />
		
		protected static string connectionString =
			string.Format(ConfigurationSettings.AppSettings["ConnectionNewString"],
			              System.Web.HttpContext.Current.Request.PhysicalApplicationPath);

		/// <summary>
		/// 方法名称: JingqusDao
		/// 内容摘要: 构造函数进行初始化
		/// </summary>
		protected JingqusDao()
		{
		}

		private static volatile JingqusDao m_instance = null;
		/// <summary>
		/// 方法名称: GetInstance
		/// 内容摘要: 取得 JingqusDao 对象
		/// </summary>
		/// <returns>返回一个已经存在的实体</returns>
		public static JingqusDao GetInstance()
		{
			// 通用的必要代码 iBatisNet双校检机制,如果实例不存在
			if (m_instance == null)
			{
				lock (typeof (JingqusDao))
				{

					// 如果实例不存在
					if (m_instance == null)
					{

						// 创建一个的实例
						m_instance = new JingqusDao();
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
		//private static Jingqus DataReaderToEntity(IDataReader dataReader)
		//{
		//	Jingqus obj = null;			
        //    while (dataReader.Read())
        //    {
		//		obj = new Jingqus();
		
		//
		//	}
		//	return obj;
		//}	
		/// <summary>
        /// 将DataReader的属性值转化为实体类的属性值，返回实体类
        /// </summary>
        /// <param name="dataReader">有效的DataReader对象</param>
        /// <returns>实体类对象</returns>
        private Jingqus DataRowToEntity(DataRow dataReader)
        {            
			Jingqus obj = new Jingqus();
		
		
		 if (dataReader["JingQu_ID"]!= DBNull.Value) obj.JingquId = (int)dataReader["JingQu_ID"];
		 if (dataReader["JingQuCode"]!= DBNull.Value) obj.Jingqucode = (string)dataReader["JingQuCode"];
		 if (dataReader["JingQuName"]!= DBNull.Value) obj.Jingquname = (string)dataReader["JingQuName"];
		 if (dataReader["MatchDomain"]!= DBNull.Value) obj.Matchdomain = (string)dataReader["MatchDomain"];
		 if (dataReader["navigation"]!= DBNull.Value) obj.Navigation = (string)dataReader["navigation"];
		 if (dataReader["Logo"]!= DBNull.Value) obj.Logo = (string)dataReader["Logo"];
		 if (dataReader["Sumary"]!= DBNull.Value) obj.Sumary = (string)dataReader["Sumary"];
		 if (dataReader["GUID"]!= DBNull.Value) obj.Guid = (string)dataReader["GUID"];
		 if (dataReader["ShowIdx"]!= DBNull.Value) obj.Showidx = (int)dataReader["ShowIdx"];
		 if (dataReader["AreaID"]!= DBNull.Value) obj.Areaid = (int)dataReader["AreaID"];
		 if (dataReader["Priceinfo"]!= DBNull.Value) obj.Priceinfo = (string)dataReader["Priceinfo"];
		 if (dataReader["weatherInfo"]!= DBNull.Value) obj.Weatherinfo = (string)dataReader["weatherInfo"];
		 if (dataReader["NavigationSwitch"]!= DBNull.Value) obj.Navigationswitch = (bool)dataReader["NavigationSwitch"];
		 if (dataReader["parent"]!= DBNull.Value) obj.Parent = (string)dataReader["parent"];
			
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
		public int Insert(Jingqus entity)
		{
			int returnValue = -1;
			using (OleDbConnection connection = new OleDbConnection(connectionString))
            {   
				try
				{
				
					OleDbParameter p;
					string sqlCommand = "Insert into JingQus([JingQuCode],[JingQuName],[MatchDomain],[navigation],[Logo],[Sumary],[GUID],[ShowIdx],[AreaID],[Priceinfo],[weatherInfo],[NavigationSwitch],[parent]) values (?,?,?,?,?,?,?,?,?,?,?,?,?);";
					using (OleDbCommand cmd = new OleDbCommand(sqlCommand,connection))
					{
						connection.Open();					
						
		p = new OleDbParameter("@JingQuCode",OleDbType.VarChar);
		p.Value = entity.Jingqucode;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@JingQuName",OleDbType.VarChar);
		p.Value = entity.Jingquname;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@MatchDomain",OleDbType.VarChar);
		p.Value = entity.Matchdomain;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@navigation",OleDbType.VarChar);
		p.Value = entity.Navigation;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@Logo",OleDbType.VarChar);
		p.Value = entity.Logo;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@Sumary",OleDbType.VarChar);
		p.Value = entity.Sumary;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@GUID",OleDbType.VarChar);
		p.Value = entity.Guid;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@ShowIdx",OleDbType.Integer);
		p.Value = entity.Showidx;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@AreaID",OleDbType.Integer);
		p.Value = entity.Areaid;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@Priceinfo",OleDbType.VarChar);
		p.Value = entity.Priceinfo;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@weatherInfo",OleDbType.VarChar);
		p.Value = entity.Weatherinfo;
		cmd.Parameters.Add(p);
        p = new OleDbParameter("@NavigationSwitch", OleDbType.Boolean);
		p.Value = entity.Navigationswitch;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@parent",OleDbType.VarChar);
		p.Value = entity.Parent;
		cmd.Parameters.Add(p);			
						cmd.ExecuteNonQuery();
						
						sqlCommand = "SELECT @@IDENTITY AS ID";
												
						cmd.CommandText = sqlCommand;
						object o = cmd.ExecuteScalar();
						entity.JingquId =  Convert.ToInt32(o);;
						returnValue = entity.JingquId;
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
		public bool Update(Jingqus entity)
		{
			bool returnValue = false;
			using (OleDbConnection connection = new OleDbConnection(connectionString))
            { 
			
				try
				{
					OleDbParameter p;
					string sqlCommand = "Update JingQus Set [JingQuCode] = ?,[JingQuName] = ?,[MatchDomain] = ?,[navigation] = ?,[Logo] = ?,[Sumary] = ?,[GUID] = ?,[ShowIdx] = ?,[AreaID] = ?,[Priceinfo] = ?,[weatherInfo] = ?,[NavigationSwitch] = ?,[parent] = ? where [JingQu_ID] =?  ";
					using (OleDbCommand cmd = new OleDbCommand(sqlCommand,connection))
					{
						connection.Open();					
						
		p = new OleDbParameter("@JingQuCode",OleDbType.VarChar);
		p.Value = entity.Jingqucode;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@JingQuName",OleDbType.VarChar);
		p.Value = entity.Jingquname;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@MatchDomain",OleDbType.VarChar);
		p.Value = entity.Matchdomain;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@navigation",OleDbType.VarChar);
		p.Value = entity.Navigation;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@Logo",OleDbType.VarChar);
		p.Value = entity.Logo;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@Sumary",OleDbType.VarChar);
		p.Value = entity.Sumary;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@GUID",OleDbType.VarChar);
		p.Value = entity.Guid;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@ShowIdx",OleDbType.Integer);
		p.Value = entity.Showidx;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@AreaID",OleDbType.Integer);
		p.Value = entity.Areaid;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@Priceinfo",OleDbType.VarChar);
		p.Value = entity.Priceinfo;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@weatherInfo",OleDbType.VarChar);
		p.Value = entity.Weatherinfo;
		cmd.Parameters.Add(p);
        p = new OleDbParameter("@NavigationSwitch", OleDbType.Boolean);
		p.Value = entity.Navigationswitch;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@parent",OleDbType.VarChar);
		p.Value = entity.Parent;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@JingQu_ID",OleDbType.Integer);
		p.Value = entity.JingquId;
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
		public Jingqus SelectByID(Jingqus.Key entity)
        {
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
            
				try
				{
					OleDbParameter p;
					string sqlCommand = " select * From JingQus where [JingQu_ID] = ?    ";
					using (OleDbCommand cmd = new OleDbCommand(sqlCommand,connection))
					{   					
						connection.Open();				
						
		p = new OleDbParameter("@JingQu_ID",DbType.Int32);
		p.Value = entity.JingquId;
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
			
				string sqlCommand = "   select * From JingQus  ";
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
		public bool DeleteByID(Jingqus.Key entity)
        {
			try
			{
				using (OleDbConnection connection = new OleDbConnection(connectionString))
				{
            	
					OleDbParameter p;
					string sqlCommand = " delete From JingQus where [JingQu_ID] = ?    ";
					using (OleDbCommand cmd = new OleDbCommand(sqlCommand,connection))
					{     
						connection.Open();				
						
		p = new OleDbParameter("@JingQu_ID",DbType.Int32);
		p.Value = entity.JingquId;
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
		