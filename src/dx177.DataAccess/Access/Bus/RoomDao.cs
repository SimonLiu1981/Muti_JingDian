/*
版权所有：版权所有(C) 2011，321Nets
文件编号：M01_RoomDao.cs
文件名称：RoomBLL.cs
系统编号：Z0003007
系统名称：通用办公系统
模块编号：M01
模块名称：信息发布
设计文档：IOA_M01信息发布XDE建模.mdx
完成日期：2011/4/15
作　　者：
内容摘要：表[Room]对应的业务逻辑 BLL
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
	/// Room的BLL
	/// 该BLL已经生成了基本的业务操作，在自动生成的方法中已经提供了事务机制
	/// </summary>
	public class RoomDao 
	{
		#region 自动生成代码：取得相关实体

		//数据库连接字符串(web.config来配置)
		//<add key="ConnectionString" value="Provider=Microsoft.Jet.OLEDB.4.0; Data Source=D:\\db1.mdb" />
		
		protected static string connectionString =
			string.Format(ConfigurationSettings.AppSettings["ConnectionNewString"],
			              System.Web.HttpContext.Current.Request.PhysicalApplicationPath);

		/// <summary>
		/// 方法名称: RoomDao
		/// 内容摘要: 构造函数进行初始化
		/// </summary>
		protected RoomDao()
		{
		}

		private static volatile RoomDao m_instance = null;
		/// <summary>
		/// 方法名称: GetInstance
		/// 内容摘要: 取得 RoomDao 对象
		/// </summary>
		/// <returns>返回一个已经存在的实体</returns>
		public static RoomDao GetInstance()
		{
			// 通用的必要代码 iBatisNet双校检机制,如果实例不存在
			if (m_instance == null)
			{
				lock (typeof (RoomDao))
				{

					// 如果实例不存在
					if (m_instance == null)
					{

						// 创建一个的实例
						m_instance = new RoomDao();
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
		//private static Room DataReaderToEntity(IDataReader dataReader)
		//{
		//	Room obj = null;			
        //    while (dataReader.Read())
        //    {
		//		obj = new Room();
		
		//
		//	}
		//	return obj;
		//}	
		/// <summary>
        /// 将DataReader的属性值转化为实体类的属性值，返回实体类
        /// </summary>
        /// <param name="dataReader">有效的DataReader对象</param>
        /// <returns>实体类对象</returns>
        private Room DataRowToEntity(DataRow dataReader)
        {            
			Room obj = new Room();
		
		
		 if (dataReader["Seqno"]!= DBNull.Value) obj.Seqno = (int)dataReader["Seqno"];
		 if (dataReader["GUID"]!= DBNull.Value) obj.Guid = (string)dataReader["GUID"];
		 if (dataReader["PGUID"]!= DBNull.Value) obj.Pguid = (string)dataReader["PGUID"];
		 if (dataReader["RoomTitle"]!= DBNull.Value) obj.Roomtitle = (string)dataReader["RoomTitle"];
		 if (dataReader["ShortDescr"]!= DBNull.Value) obj.Shortdescr = (string)dataReader["ShortDescr"];
		 if (dataReader["Descr"]!= DBNull.Value) obj.Descr = (string)dataReader["Descr"];
		 if (dataReader["MarketPrice"]!= DBNull.Value) obj.Marketprice = (double)dataReader["MarketPrice"];
		 if (dataReader["Price1"]!= DBNull.Value) obj.Price1 = (double)dataReader["Price1"];
		 if (dataReader["Price2"]!= DBNull.Value) obj.Price2 = (double)dataReader["Price2"];
		 if (dataReader["installations"]!= DBNull.Value) obj.Installations = (string)dataReader["installations"];
		 if (dataReader["Logo"]!= DBNull.Value) obj.Logo = (string)dataReader["Logo"];
		 if (dataReader["Laste_update_By"]!= DBNull.Value) obj.LasteUpdateBy = (string)dataReader["Laste_update_By"];
		 if (dataReader["CREATOR"]!= DBNull.Value) obj.Creator = (string)dataReader["CREATOR"];
		 if (dataReader["CREATE_DATE"]!= DBNull.Value) obj.CreateDate = (DateTime)dataReader["CREATE_DATE"];
		 if (dataReader["Laste_update_date"]!= DBNull.Value) obj.LasteUpdateDate = (DateTime)dataReader["Laste_update_date"];
		 if (dataReader["Square"]!= DBNull.Value) obj.Square = (double)dataReader["Square"];
		 if (dataReader["Breakfast"]!= DBNull.Value) obj.Breakfast = (string)dataReader["Breakfast"];
		 if (dataReader["Broadband"]!= DBNull.Value) obj.Broadband = (string)dataReader["Broadband"];
		 if (dataReader["Present"]!= DBNull.Value) obj.Present = (double)dataReader["Present"];
		 if (dataReader["ShowPr"]!= DBNull.Value) obj.Showpr = (int)dataReader["ShowPr"];
			
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
		public int Insert(Room entity)
		{
			int returnValue = -1;
			using (OleDbConnection connection = new OleDbConnection(connectionString))
            {   
				try
				{
				
					OleDbParameter p;
					string sqlCommand = "Insert into Room([GUID],[PGUID],[RoomTitle],[ShortDescr],[Descr],[MarketPrice],[Price1],[Price2],[installations],[Logo],[Laste_update_By],[CREATOR],[CREATE_DATE],[Laste_update_date],[Square],[Breakfast],[Broadband],[Present],[ShowPr]) values (?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?);";
					using (OleDbCommand cmd = new OleDbCommand(sqlCommand,connection))
					{
						connection.Open();					
						
		p = new OleDbParameter("@GUID",OleDbType.VarChar);
		p.Value = entity.Guid;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@PGUID",OleDbType.VarChar);
		p.Value = entity.Pguid;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@RoomTitle",OleDbType.VarChar);
		p.Value = entity.Roomtitle;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@ShortDescr",OleDbType.VarChar);
		p.Value = entity.Shortdescr;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@Descr",OleDbType.VarChar);
		p.Value = entity.Descr;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@MarketPrice",OleDbType.Double);
		p.Value = entity.Marketprice;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@Price1",OleDbType.Double);
		p.Value = entity.Price1;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@Price2",OleDbType.Double);
		p.Value = entity.Price2;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@installations",OleDbType.VarChar);
		p.Value = entity.Installations;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@Logo",OleDbType.VarChar);
		p.Value = entity.Logo;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@Laste_update_By",OleDbType.VarChar);
		p.Value = entity.LasteUpdateBy;
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
		p = new OleDbParameter("@Square",OleDbType.Double);
		p.Value = entity.Square;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@Breakfast",OleDbType.VarChar);
		p.Value = entity.Breakfast;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@Broadband",OleDbType.VarChar);
		p.Value = entity.Broadband;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@Present",OleDbType.Double);
		p.Value = entity.Present;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@ShowPr",OleDbType.Integer);
		p.Value = entity.Showpr;
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
		public bool Update(Room entity)
		{
			bool returnValue = false;
			using (OleDbConnection connection = new OleDbConnection(connectionString))
            { 
			
				try
				{
					OleDbParameter p;
					string sqlCommand = "Update Room Set [GUID] = ?,[PGUID] = ?,[RoomTitle] = ?,[ShortDescr] = ?,[Descr] = ?,[MarketPrice] = ?,[Price1] = ?,[Price2] = ?,[installations] = ?,[Logo] = ?,[Laste_update_By] = ?,[CREATOR] = ?,[CREATE_DATE] = ?,[Laste_update_date] = ?,[Square] = ?,[Breakfast] = ?,[Broadband] = ?,[Present] = ?,[ShowPr] = ? where [Seqno] =?  ";
					using (OleDbCommand cmd = new OleDbCommand(sqlCommand,connection))
					{
						connection.Open();					
						
		p = new OleDbParameter("@GUID",OleDbType.VarChar);
		p.Value = entity.Guid;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@PGUID",OleDbType.VarChar);
		p.Value = entity.Pguid;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@RoomTitle",OleDbType.VarChar);
		p.Value = entity.Roomtitle;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@ShortDescr",OleDbType.VarChar);
		p.Value = entity.Shortdescr;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@Descr",OleDbType.VarChar);
		p.Value = entity.Descr;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@MarketPrice",OleDbType.Double);
		p.Value = entity.Marketprice;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@Price1",OleDbType.Double);
		p.Value = entity.Price1;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@Price2",OleDbType.Double);
		p.Value = entity.Price2;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@installations",OleDbType.VarChar);
		p.Value = entity.Installations;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@Logo",OleDbType.VarChar);
		p.Value = entity.Logo;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@Laste_update_By",OleDbType.VarChar);
		p.Value = entity.LasteUpdateBy;
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
		p = new OleDbParameter("@Square",OleDbType.Double);
		p.Value = entity.Square;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@Breakfast",OleDbType.VarChar);
		p.Value = entity.Breakfast;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@Broadband",OleDbType.VarChar);
		p.Value = entity.Broadband;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@Present",OleDbType.Double);
		p.Value = entity.Present;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@ShowPr",OleDbType.Integer);
		p.Value = entity.Showpr;
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
		public Room SelectByID(Room.Key entity)
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
		public DataRow SelectRowByID(Room.Key entity)
        {
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
            
				try
				{
					OleDbParameter p;
					string sqlCommand = " select * From Room where [Seqno] = ?    ";
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
			
				string sqlCommand = "   select * From Room  ";
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
		public bool DeleteByID(Room.Key entity)
        {
			try
			{
				using (OleDbConnection connection = new OleDbConnection(connectionString))
				{
            	
					OleDbParameter p;
					string sqlCommand = " delete From Room where [Seqno] = ?    ";
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
		