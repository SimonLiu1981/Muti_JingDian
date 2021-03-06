/*
版权所有：版权所有(C) 2011，321Nets
文件编号：M01_HotelorderDao.cs
文件名称：HotelorderBLL.cs
系统编号：Z0003007
系统名称：通用办公系统
模块编号：M01
模块名称：信息发布
设计文档：IOA_M01信息发布XDE建模.mdx
完成日期：2011/4/15
作　　者：
内容摘要：表[HotelOrder]对应的业务逻辑 BLL
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
	/// Hotelorder的BLL
	/// 该BLL已经生成了基本的业务操作，在自动生成的方法中已经提供了事务机制
	/// </summary>
	public class HotelorderDao 
	{
		#region 自动生成代码：取得相关实体

		//数据库连接字符串(web.config来配置)
		//<add key="ConnectionString" value="Provider=Microsoft.Jet.OLEDB.4.0; Data Source=D:\\db1.mdb" />
		
		protected static string connectionString =
			string.Format(ConfigurationSettings.AppSettings["ConnectionNewString"],
			              System.Web.HttpContext.Current.Request.PhysicalApplicationPath);

		/// <summary>
		/// 方法名称: HotelorderDao
		/// 内容摘要: 构造函数进行初始化
		/// </summary>
		protected HotelorderDao()
		{
		}

		private static volatile HotelorderDao m_instance = null;
		/// <summary>
		/// 方法名称: GetInstance
		/// 内容摘要: 取得 HotelorderDao 对象
		/// </summary>
		/// <returns>返回一个已经存在的实体</returns>
		public static HotelorderDao GetInstance()
		{
			// 通用的必要代码 iBatisNet双校检机制,如果实例不存在
			if (m_instance == null)
			{
				lock (typeof (HotelorderDao))
				{

					// 如果实例不存在
					if (m_instance == null)
					{

						// 创建一个的实例
						m_instance = new HotelorderDao();
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
		//private static Hotelorder DataReaderToEntity(IDataReader dataReader)
		//{
		//	Hotelorder obj = null;			
        //    while (dataReader.Read())
        //    {
		//		obj = new Hotelorder();
		
		//
		//	}
		//	return obj;
		//}	
		/// <summary>
        /// 将DataReader的属性值转化为实体类的属性值，返回实体类
        /// </summary>
        /// <param name="dataReader">有效的DataReader对象</param>
        /// <returns>实体类对象</returns>
        private Hotelorder DataRowToEntity(DataRow dataReader)
        {            
			Hotelorder obj = new Hotelorder();
		
		
		 if (dataReader["Seqno"]!= DBNull.Value) obj.Seqno = (int)dataReader["Seqno"];
		 if (dataReader["GUID"]!= DBNull.Value) obj.Guid = (string)dataReader["GUID"];
		 if (dataReader["OrderNo"]!= DBNull.Value) obj.Orderno = (string)dataReader["OrderNo"];
		 if (dataReader["PersonName"]!= DBNull.Value) obj.Personname = (string)dataReader["PersonName"];
		 if (dataReader["PersonPhone"]!= DBNull.Value) obj.Personphone = (string)dataReader["PersonPhone"];
		 if (dataReader["OrderUserName"]!= DBNull.Value) obj.Orderusername = (string)dataReader["OrderUserName"];
		 if (dataReader["OrderUserPhone"]!= DBNull.Value) obj.Orderuserphone = (string)dataReader["OrderUserPhone"];
		 if (dataReader["Email"]!= DBNull.Value) obj.Email = (string)dataReader["Email"];
		 if (dataReader["PCount"]!= DBNull.Value) obj.Pcount = (int)dataReader["PCount"];
		 if (dataReader["BeginDate"]!= DBNull.Value) obj.Begindate = (DateTime)dataReader["BeginDate"];
		 if (dataReader["EndDate"]!= DBNull.Value) obj.Enddate = (DateTime)dataReader["EndDate"];
		 if (dataReader["ReachDate"]!= DBNull.Value) obj.Reachdate = (string)dataReader["ReachDate"];
		 if (dataReader["HotelSeqno"]!= DBNull.Value) obj.Hotelseqno = (int)dataReader["HotelSeqno"];
		 if (dataReader["HotelName"]!= DBNull.Value) obj.Hotelname = (string)dataReader["HotelName"];
		 if (dataReader["RoomTitle"]!= DBNull.Value) obj.Roomtitle = (string)dataReader["RoomTitle"];
		 if (dataReader["RoomSeqno"]!= DBNull.Value) obj.Roomseqno = (int)dataReader["RoomSeqno"];
		 if (dataReader["RoomCount"]!= DBNull.Value) obj.Roomcount = (int)dataReader["RoomCount"];
		 if (dataReader["Price"]!= DBNull.Value) obj.Price = (double)dataReader["Price"];
		 if (dataReader["referrall"]!= DBNull.Value) obj.Referrall = (string)dataReader["referrall"];
		 if (dataReader["TotalMoney"]!= DBNull.Value) obj.Totalmoney = (double)dataReader["TotalMoney"];
		 if (dataReader["Creator"]!= DBNull.Value) obj.Creator = (string)dataReader["Creator"];
		 if (dataReader["CREATE_DATE"]!= DBNull.Value) obj.CreateDate = (DateTime)dataReader["CREATE_DATE"];
		 if (dataReader["Ip"]!= DBNull.Value) obj.Ip = (string)dataReader["Ip"];
		 if (dataReader["Content"]!= DBNull.Value) obj.Content = (string)dataReader["Content"];
		 if (dataReader["Status"]!= DBNull.Value) obj.Status = (int)dataReader["Status"];
			
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
		public int Insert(Hotelorder entity)
		{
			int returnValue = -1;
			using (OleDbConnection connection = new OleDbConnection(connectionString))
            {   
				try
				{
				
					OleDbParameter p;
					string sqlCommand = "Insert into HotelOrder([GUID],[OrderNo],[PersonName],[PersonPhone],[OrderUserName],[OrderUserPhone],[Email],[PCount],[BeginDate],[EndDate],[ReachDate],[HotelSeqno],[HotelName],[RoomTitle],[RoomSeqno],[RoomCount],[Price],[referrall],[TotalMoney],[Creator],[CREATE_DATE],[Ip],[Content],[Status]) values (?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?);";
					using (OleDbCommand cmd = new OleDbCommand(sqlCommand,connection))
					{
						connection.Open();					
						
		p = new OleDbParameter("@GUID",OleDbType.VarChar);
		p.Value = entity.Guid;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@OrderNo",OleDbType.VarChar);
		p.Value = entity.Orderno;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@PersonName",OleDbType.VarChar);
		p.Value = entity.Personname;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@PersonPhone",OleDbType.VarChar);
		p.Value = entity.Personphone;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@OrderUserName",OleDbType.VarChar);
		p.Value = entity.Orderusername;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@OrderUserPhone",OleDbType.VarChar);
		p.Value = entity.Orderuserphone;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@Email",OleDbType.VarChar);
		p.Value = entity.Email;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@PCount",OleDbType.Integer);
		p.Value = entity.Pcount;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@BeginDate",OleDbType.DBTimeStamp);
		p.Value = DateTime.Parse(entity.Begindate.ToString("yyyy-MM-dd HH:mm:ss"));
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@EndDate",OleDbType.DBTimeStamp);
		p.Value = DateTime.Parse(entity.Enddate.ToString("yyyy-MM-dd HH:mm:ss"));
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@ReachDate",OleDbType.VarChar);
		p.Value = entity.Reachdate;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@HotelSeqno",OleDbType.Integer);
		p.Value = entity.Hotelseqno;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@HotelName",OleDbType.VarChar);
		p.Value = entity.Hotelname;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@RoomTitle",OleDbType.VarChar);
		p.Value = entity.Roomtitle;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@RoomSeqno",OleDbType.Integer);
		p.Value = entity.Roomseqno;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@RoomCount",OleDbType.Integer);
		p.Value = entity.Roomcount;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@Price",OleDbType.Double);
		p.Value = entity.Price;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@referrall",OleDbType.VarChar);
		p.Value = entity.Referrall;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@TotalMoney",OleDbType.Double);
		p.Value = entity.Totalmoney;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@Creator",OleDbType.VarChar);
		p.Value = entity.Creator;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@CREATE_DATE",OleDbType.DBTimeStamp);
		p.Value = DateTime.Parse(entity.CreateDate.ToString("yyyy-MM-dd HH:mm:ss"));
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@Ip",OleDbType.VarChar);
		p.Value = entity.Ip;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@Content",OleDbType.VarChar);
		p.Value = entity.Content;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@Status",OleDbType.Integer);
		p.Value = entity.Status;
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
		public bool Update(Hotelorder entity)
		{
			bool returnValue = false;
			using (OleDbConnection connection = new OleDbConnection(connectionString))
            { 
			
				try
				{
					OleDbParameter p;
					string sqlCommand = "Update HotelOrder Set [GUID] = ?,[OrderNo] = ?,[PersonName] = ?,[PersonPhone] = ?,[OrderUserName] = ?,[OrderUserPhone] = ?,[Email] = ?,[PCount] = ?,[BeginDate] = ?,[EndDate] = ?,[ReachDate] = ?,[HotelSeqno] = ?,[HotelName] = ?,[RoomTitle] = ?,[RoomSeqno] = ?,[RoomCount] = ?,[Price] = ?,[referrall] = ?,[TotalMoney] = ?,[Creator] = ?,[CREATE_DATE] = ?,[Ip] = ?,[Content] = ?,[Status] = ? where [Seqno] =?  ";
					using (OleDbCommand cmd = new OleDbCommand(sqlCommand,connection))
					{
						connection.Open();					
						
		p = new OleDbParameter("@GUID",OleDbType.VarChar);
		p.Value = entity.Guid;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@OrderNo",OleDbType.VarChar);
		p.Value = entity.Orderno;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@PersonName",OleDbType.VarChar);
		p.Value = entity.Personname;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@PersonPhone",OleDbType.VarChar);
		p.Value = entity.Personphone;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@OrderUserName",OleDbType.VarChar);
		p.Value = entity.Orderusername;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@OrderUserPhone",OleDbType.VarChar);
		p.Value = entity.Orderuserphone;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@Email",OleDbType.VarChar);
		p.Value = entity.Email;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@PCount",OleDbType.Integer);
		p.Value = entity.Pcount;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@BeginDate",OleDbType.DBTimeStamp);
		p.Value = DateTime.Parse(entity.Begindate.ToString("yyyy-MM-dd HH:mm:ss"));
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@EndDate",OleDbType.DBTimeStamp);
		p.Value = DateTime.Parse(entity.Enddate.ToString("yyyy-MM-dd HH:mm:ss"));
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@ReachDate",OleDbType.VarChar);
		p.Value = entity.Reachdate;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@HotelSeqno",OleDbType.Integer);
		p.Value = entity.Hotelseqno;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@HotelName",OleDbType.VarChar);
		p.Value = entity.Hotelname;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@RoomTitle",OleDbType.VarChar);
		p.Value = entity.Roomtitle;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@RoomSeqno",OleDbType.Integer);
		p.Value = entity.Roomseqno;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@RoomCount",OleDbType.Integer);
		p.Value = entity.Roomcount;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@Price",OleDbType.Double);
		p.Value = entity.Price;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@referrall",OleDbType.VarChar);
		p.Value = entity.Referrall;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@TotalMoney",OleDbType.Double);
		p.Value = entity.Totalmoney;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@Creator",OleDbType.VarChar);
		p.Value = entity.Creator;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@CREATE_DATE",OleDbType.DBTimeStamp);
		p.Value = DateTime.Parse(entity.CreateDate.ToString("yyyy-MM-dd HH:mm:ss"));
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@Ip",OleDbType.VarChar);
		p.Value = entity.Ip;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@Content",OleDbType.VarChar);
		p.Value = entity.Content;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@Status",OleDbType.Integer);
		p.Value = entity.Status;
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
		public Hotelorder SelectByID(Hotelorder.Key entity)
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
		public DataRow SelectRowByID(Hotelorder.Key entity)
        {
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
            
				try
				{
					OleDbParameter p;
					string sqlCommand = " select * From HotelOrder where [Seqno] = ?    ";
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
			
				string sqlCommand = "   select * From HotelOrder  ";
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
		public bool DeleteByID(Hotelorder.Key entity)
        {
			try
			{
				using (OleDbConnection connection = new OleDbConnection(connectionString))
				{
            	
					OleDbParameter p;
					string sqlCommand = " delete From HotelOrder where [Seqno] = ?    ";
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
		