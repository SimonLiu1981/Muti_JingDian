/*
版权所有：版权所有(C) 2011，321Nets
文件编号：M01_OrderApplyItemDao.cs
文件名称：OrderApplyItemBLL.cs
系统编号：Z0003007
系统名称：通用办公系统
模块编号：M01
模块名称：信息发布
设计文档：IOA_M01信息发布XDE建模.mdx
完成日期：2011-04-30
作　　者：
内容摘要：表[Order_Apply_Item]对应的业务逻辑 BLL
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
	/// OrderApplyItem的BLL
	/// 该BLL已经生成了基本的业务操作，在自动生成的方法中已经提供了事务机制
	/// </summary>
	public class OrderApplyItemDao 
	{
		#region 自动生成代码：取得相关实体

		//数据库连接字符串(web.config来配置)
		//<add key="ConnectionString" value="Provider=Microsoft.Jet.OLEDB.4.0; Data Source=D:\\db1.mdb" />
		
		protected static string connectionString =
			string.Format(ConfigurationSettings.AppSettings["ConnectionNewString"],
			              System.Web.HttpContext.Current.Request.PhysicalApplicationPath);

		/// <summary>
		/// 方法名称: OrderApplyItemDao
		/// 内容摘要: 构造函数进行初始化
		/// </summary>
		protected OrderApplyItemDao()
		{
		}

		private static volatile OrderApplyItemDao m_instance = null;
		/// <summary>
		/// 方法名称: GetInstance
		/// 内容摘要: 取得 OrderApplyItemDao 对象
		/// </summary>
		/// <returns>返回一个已经存在的实体</returns>
		public static OrderApplyItemDao GetInstance()
		{
			// 通用的必要代码 iBatisNet双校检机制,如果实例不存在
			if (m_instance == null)
			{
				lock (typeof (OrderApplyItemDao))
				{

					// 如果实例不存在
					if (m_instance == null)
					{

						// 创建一个的实例
						m_instance = new OrderApplyItemDao();
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
		//private static OrderApplyItem DataReaderToEntity(IDataReader dataReader)
		//{
		//	OrderApplyItem obj = null;			
        //    while (dataReader.Read())
        //    {
		//		obj = new OrderApplyItem();
		
		//
		//	}
		//	return obj;
		//}	
		/// <summary>
        /// 将DataReader的属性值转化为实体类的属性值，返回实体类
        /// </summary>
        /// <param name="dataReader">有效的DataReader对象</param>
        /// <returns>实体类对象</returns>
        private OrderApplyItem DataRowToEntity(DataRow dataReader)
        {            
			OrderApplyItem obj = new OrderApplyItem();
		
		
		 if (dataReader["Order_Apply_Item_ID"]!= DBNull.Value) obj.OrderApplyItemId = (int)dataReader["Order_Apply_Item_ID"];
		 if (dataReader["Order_Apply_ID"]!= DBNull.Value) obj.OrderApplyId = (int)dataReader["Order_Apply_ID"];
		 if (dataReader["Product_ID"]!= DBNull.Value) obj.ProductId = (int)dataReader["Product_ID"];
		 if (dataReader["Product_Type"]!= DBNull.Value) obj.ProductType = (string)dataReader["Product_Type"];
		 if (dataReader["Product_Name"]!= DBNull.Value) obj.ProductName = (string)dataReader["Product_Name"];
		 if (dataReader["Product_Price"]!= DBNull.Value) obj.ProductPrice = (double)dataReader["Product_Price"];
		 if (dataReader["Count"]!= DBNull.Value) obj.Count = (int)dataReader["Count"];
		 if (dataReader["Tatol"]!= DBNull.Value) obj.Tatol = (double)dataReader["Tatol"];
		 if (dataReader["Unit_Price"]!= DBNull.Value) obj.UnitPrice = (double)dataReader["Unit_Price"];
		 if (dataReader["Unit"]!= DBNull.Value) obj.Unit = (string)dataReader["Unit"];
		 if (dataReader["Vaild"]!= DBNull.Value) obj.Vaild = (int)dataReader["Vaild"];
		 if (dataReader["Create_Date"]!= DBNull.Value) obj.CreateDate = (DateTime)dataReader["Create_Date"];
		 if (dataReader["Laste_Update_Date"]!= DBNull.Value) obj.LasteUpdateDate = (DateTime)dataReader["Laste_Update_Date"];
		 if (dataReader["Product_Belog"]!= DBNull.Value) obj.ProductBelog = (string)dataReader["Product_Belog"];
			
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
		public int Insert(OrderApplyItem entity)
		{
			int returnValue = -1;
			using (OleDbConnection connection = new OleDbConnection(connectionString))
            {   
				try
				{
				
					OleDbParameter p;
					string sqlCommand = "Insert into Order_Apply_Item([Order_Apply_ID],[Product_ID],[Product_Type],[Product_Name],[Product_Price],[Count],[Tatol],[Unit_Price],[Unit],[Vaild],[Create_Date],[Laste_Update_Date],[Product_Belog]) values (?,?,?,?,?,?,?,?,?,?,?,?,?);";
					using (OleDbCommand cmd = new OleDbCommand(sqlCommand,connection))
					{
						connection.Open();					
						
		p = new OleDbParameter("@Order_Apply_ID",OleDbType.Integer);
		p.Value = entity.OrderApplyId;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@Product_ID",OleDbType.Integer);
		p.Value = entity.ProductId;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@Product_Type",OleDbType.VarChar);
		p.Value = entity.ProductType;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@Product_Name",OleDbType.VarChar);
		p.Value = entity.ProductName;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@Product_Price",OleDbType.Double);
		p.Value = entity.ProductPrice;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@Count",OleDbType.Integer);
		p.Value = entity.Count;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@Tatol",OleDbType.Double);
		p.Value = entity.Tatol;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@Unit_Price",OleDbType.Double);
		p.Value = entity.UnitPrice;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@Unit",OleDbType.VarChar);
		p.Value = entity.Unit;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@Vaild",OleDbType.Integer);
		p.Value = entity.Vaild;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@Create_Date",OleDbType.DBTimeStamp);
		p.Value = DateTime.Parse(entity.CreateDate.ToString("yyyy-MM-dd HH:mm:ss"));
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@Laste_Update_Date",OleDbType.DBTimeStamp);
		p.Value = DateTime.Parse(entity.LasteUpdateDate.ToString("yyyy-MM-dd HH:mm:ss"));
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@Product_Belog",OleDbType.VarChar);
		p.Value = entity.ProductBelog;
		cmd.Parameters.Add(p);			
						cmd.ExecuteNonQuery();
						
						sqlCommand = "SELECT @@IDENTITY AS ID";
												
						cmd.CommandText = sqlCommand;
						object o = cmd.ExecuteScalar();
						entity.OrderApplyItemId =  Convert.ToInt32(o);;
						returnValue = entity.OrderApplyItemId;
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
		public bool Update(OrderApplyItem entity)
		{
			bool returnValue = false;
			using (OleDbConnection connection = new OleDbConnection(connectionString))
            { 
			
				try
				{
					OleDbParameter p;
					string sqlCommand = "Update Order_Apply_Item Set [Order_Apply_ID] = ?,[Product_ID] = ?,[Product_Type] = ?,[Product_Name] = ?,[Product_Price] = ?,[Count] = ?,[Tatol] = ?,[Unit_Price] = ?,[Unit] = ?,[Vaild] = ?,[Create_Date] = ?,[Laste_Update_Date] = ?,[Product_Belog] = ? where [Order_Apply_Item_ID] =?  ";
					using (OleDbCommand cmd = new OleDbCommand(sqlCommand,connection))
					{
						connection.Open();					
						
		p = new OleDbParameter("@Order_Apply_ID",OleDbType.Integer);
		p.Value = entity.OrderApplyId;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@Product_ID",OleDbType.Integer);
		p.Value = entity.ProductId;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@Product_Type",OleDbType.VarChar);
		p.Value = entity.ProductType;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@Product_Name",OleDbType.VarChar);
		p.Value = entity.ProductName;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@Product_Price",OleDbType.Double);
		p.Value = entity.ProductPrice;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@Count",OleDbType.Integer);
		p.Value = entity.Count;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@Tatol",OleDbType.Double);
		p.Value = entity.Tatol;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@Unit_Price",OleDbType.Double);
		p.Value = entity.UnitPrice;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@Unit",OleDbType.VarChar);
		p.Value = entity.Unit;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@Vaild",OleDbType.Integer);
		p.Value = entity.Vaild;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@Create_Date",OleDbType.DBTimeStamp);
		p.Value = DateTime.Parse(entity.CreateDate.ToString("yyyy-MM-dd HH:mm:ss"));
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@Laste_Update_Date",OleDbType.DBTimeStamp);
		p.Value = DateTime.Parse(entity.LasteUpdateDate.ToString("yyyy-MM-dd HH:mm:ss"));
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@Product_Belog",OleDbType.VarChar);
		p.Value = entity.ProductBelog;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@Order_Apply_Item_ID",OleDbType.Integer);
		p.Value = entity.OrderApplyItemId;
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
		public OrderApplyItem SelectByID(OrderApplyItem.Key entity)
        {
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
            
				try
				{
					OleDbParameter p;
					string sqlCommand = " select * From Order_Apply_Item where [Order_Apply_Item_ID] = ?    ";
					using (OleDbCommand cmd = new OleDbCommand(sqlCommand,connection))
					{   					
						connection.Open();				
						
		p = new OleDbParameter("@Order_Apply_Item_ID",DbType.Int32);
		p.Value = entity.OrderApplyItemId;
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
			
				string sqlCommand = "   select * From Order_Apply_Item  ";
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
		public bool DeleteByID(OrderApplyItem.Key entity)
        {
			try
			{
				using (OleDbConnection connection = new OleDbConnection(connectionString))
				{
            	
					OleDbParameter p;
					string sqlCommand = " delete From Order_Apply_Item where [Order_Apply_Item_ID] = ?    ";
					using (OleDbCommand cmd = new OleDbCommand(sqlCommand,connection))
					{     
						connection.Open();				
						
		p = new OleDbParameter("@Order_Apply_Item_ID",DbType.Int32);
		p.Value = entity.OrderApplyItemId;
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
		