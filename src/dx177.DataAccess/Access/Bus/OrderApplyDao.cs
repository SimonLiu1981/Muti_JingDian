/*
版权所有：版权所有(C) 2011，321Nets
文件编号：M01_OrderApplyDao.cs
文件名称：OrderApplyBLL.cs
系统编号：Z0003007
系统名称：通用办公系统
模块编号：M01
模块名称：信息发布
设计文档：IOA_M01信息发布XDE建模.mdx
完成日期：2011-04-30
作　　者：
内容摘要：表[Order_Apply]对应的业务逻辑 BLL
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
	/// OrderApply的BLL
	/// 该BLL已经生成了基本的业务操作，在自动生成的方法中已经提供了事务机制
	/// </summary>
	public class OrderApplyDao 
	{
		#region 自动生成代码：取得相关实体

		//数据库连接字符串(web.config来配置)
		//<add key="ConnectionString" value="Provider=Microsoft.Jet.OLEDB.4.0; Data Source=D:\\db1.mdb" />
		
		protected static string connectionString =
			string.Format(ConfigurationSettings.AppSettings["ConnectionNewString"],
			              System.Web.HttpContext.Current.Request.PhysicalApplicationPath);

		/// <summary>
		/// 方法名称: OrderApplyDao
		/// 内容摘要: 构造函数进行初始化
		/// </summary>
		protected OrderApplyDao()
		{
		}

		private static volatile OrderApplyDao m_instance = null;
		/// <summary>
		/// 方法名称: GetInstance
		/// 内容摘要: 取得 OrderApplyDao 对象
		/// </summary>
		/// <returns>返回一个已经存在的实体</returns>
		public static OrderApplyDao GetInstance()
		{
			// 通用的必要代码 iBatisNet双校检机制,如果实例不存在
			if (m_instance == null)
			{
				lock (typeof (OrderApplyDao))
				{

					// 如果实例不存在
					if (m_instance == null)
					{

						// 创建一个的实例
						m_instance = new OrderApplyDao();
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
		//private static OrderApply DataReaderToEntity(IDataReader dataReader)
		//{
		//	OrderApply obj = null;			
        //    while (dataReader.Read())
        //    {
		//		obj = new OrderApply();
		
		//
		//	}
		//	return obj;
		//}	
		/// <summary>
        /// 将DataReader的属性值转化为实体类的属性值，返回实体类
        /// </summary>
        /// <param name="dataReader">有效的DataReader对象</param>
        /// <returns>实体类对象</returns>
        private OrderApply DataRowToEntity(DataRow dataReader)
        {            
			OrderApply obj = new OrderApply();
		
		
		 if (dataReader["Order_Apply_ID"]!= DBNull.Value) obj.OrderApplyId = (int)dataReader["Order_Apply_ID"];
		 if (dataReader["Order_NO"]!= DBNull.Value) obj.OrderNo = (string)dataReader["Order_NO"];
		 if (dataReader["Order_Title"]!= DBNull.Value) obj.OrderTitle = (string)dataReader["Order_Title"];
		 if (dataReader["Res_User_NO"]!= DBNull.Value) obj.ResUserNo = (string)dataReader["Res_User_NO"];
		 if (dataReader["receive_Name"]!= DBNull.Value) obj.ReceiveName = (string)dataReader["receive_Name"];
		 if (dataReader["receive_Phone"]!= DBNull.Value) obj.ReceivePhone = (string)dataReader["receive_Phone"];
		 if (dataReader["receive_Tel"]!= DBNull.Value) obj.ReceiveTel = (string)dataReader["receive_Tel"];
		 if (dataReader["receive_Email"]!= DBNull.Value) obj.ReceiveEmail = (string)dataReader["receive_Email"];
		 if (dataReader["receive_Address"]!= DBNull.Value) obj.ReceiveAddress = (string)dataReader["receive_Address"];
		 if (dataReader["receive_Address1"]!= DBNull.Value) obj.ReceiveAddress1 = (string)dataReader["receive_Address1"];
		 if (dataReader["Mail_Money"]!= DBNull.Value) obj.MailMoney = (double)dataReader["Mail_Money"];
		 if (dataReader["Product_T_Money"]!= DBNull.Value) obj.ProductTMoney = (double)dataReader["Product_T_Money"];
		 if (dataReader["Other_money"]!= DBNull.Value) obj.OtherMoney = (double)dataReader["Other_money"];
		 if (dataReader["Total_money"]!= DBNull.Value) obj.TotalMoney = (double)dataReader["Total_money"];
		 if (dataReader["Order_Status"]!= DBNull.Value) obj.OrderStatus = (int)dataReader["Order_Status"];
		 if (dataReader["Product_Seller"]!= DBNull.Value) obj.ProductSeller = (string)dataReader["Product_Seller"];
		 if (dataReader["Remark"]!= DBNull.Value) obj.Remark = (string)dataReader["Remark"];
		 if (dataReader["Create_Date"]!= DBNull.Value) obj.CreateDate = (DateTime)dataReader["Create_Date"];
		 if (dataReader["Last_update_Date"]!= DBNull.Value) obj.LastUpdateDate = (DateTime)dataReader["Last_update_Date"];
		 if (dataReader["Preferential_Money"]!= DBNull.Value) obj.PreferentialMoney = (double)dataReader["Preferential_Money"];
		 if (dataReader["City"]!= DBNull.Value) obj.City = (string)dataReader["City"];
		 if (dataReader["State"]!= DBNull.Value) obj.State = (string)dataReader["State"];
		 if (dataReader["Country"]!= DBNull.Value) obj.Country = (string)dataReader["Country"];
		 if (dataReader["MyPayment"]!= DBNull.Value) obj.Mypayment = (string)dataReader["MyPayment"];
		 if (dataReader["ShipMent"]!= DBNull.Value) obj.Shipment = (string)dataReader["ShipMent"];
		 if (dataReader["ZIP"]!= DBNull.Value) obj.Zip = (string)dataReader["ZIP"];
			
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
		public int Insert(OrderApply entity)
		{
			int returnValue = -1;
			using (OleDbConnection connection = new OleDbConnection(connectionString))
            {   
				try
				{
				
					OleDbParameter p;
					string sqlCommand = "Insert into Order_Apply([Order_NO],[Order_Title],[Res_User_NO],[receive_Name],[receive_Phone],[receive_Tel],[receive_Email],[receive_Address],[receive_Address1],[Mail_Money],[Product_T_Money],[Other_money],[Total_money],[Order_Status],[Product_Seller],[Remark],[Create_Date],[Last_update_Date],[Preferential_Money],[City],[State],[Country],[MyPayment],[ShipMent],[ZIP]) values (?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?);";
					using (OleDbCommand cmd = new OleDbCommand(sqlCommand,connection))
					{
						connection.Open();					
						
		p = new OleDbParameter("@Order_NO",OleDbType.VarChar);
		p.Value = entity.OrderNo;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@Order_Title",OleDbType.VarChar);
		p.Value = entity.OrderTitle;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@Res_User_NO",OleDbType.VarChar);
		p.Value = entity.ResUserNo;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@receive_Name",OleDbType.VarChar);
		p.Value = entity.ReceiveName;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@receive_Phone",OleDbType.VarChar);
		p.Value = entity.ReceivePhone;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@receive_Tel",OleDbType.VarChar);
		p.Value = entity.ReceiveTel;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@receive_Email",OleDbType.VarChar);
		p.Value = entity.ReceiveEmail;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@receive_Address",OleDbType.VarChar);
		p.Value = entity.ReceiveAddress;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@receive_Address1",OleDbType.VarChar);
		p.Value = entity.ReceiveAddress1;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@Mail_Money",OleDbType.Double);
		p.Value = entity.MailMoney;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@Product_T_Money",OleDbType.Double);
		p.Value = entity.ProductTMoney;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@Other_money",OleDbType.Double);
		p.Value = entity.OtherMoney;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@Total_money",OleDbType.Double);
		p.Value = entity.TotalMoney;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@Order_Status",OleDbType.Integer);
		p.Value = entity.OrderStatus;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@Product_Seller",OleDbType.VarChar);
		p.Value = entity.ProductSeller;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@Remark",OleDbType.VarChar);
		p.Value = entity.Remark;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@Create_Date",OleDbType.DBTimeStamp);
		p.Value = DateTime.Parse(entity.CreateDate.ToString("yyyy-MM-dd HH:mm:ss"));
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@Last_update_Date",OleDbType.DBTimeStamp);
		p.Value = DateTime.Parse(entity.LastUpdateDate.ToString("yyyy-MM-dd HH:mm:ss"));
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@Preferential_Money",OleDbType.Double);
		p.Value = entity.PreferentialMoney;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@City",OleDbType.VarChar);
		p.Value = entity.City;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@State",OleDbType.VarChar);
		p.Value = entity.State;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@Country",OleDbType.VarChar);
		p.Value = entity.Country;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@MyPayment",OleDbType.VarChar);
		p.Value = entity.Mypayment;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@ShipMent",OleDbType.VarChar);
		p.Value = entity.Shipment;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@ZIP",OleDbType.VarChar);
		p.Value = entity.Zip;
		cmd.Parameters.Add(p);			
						cmd.ExecuteNonQuery();
						
						sqlCommand = "SELECT @@IDENTITY AS ID";
												
						cmd.CommandText = sqlCommand;
						object o = cmd.ExecuteScalar();
						entity.OrderApplyId =  Convert.ToInt32(o);;
						returnValue = entity.OrderApplyId;
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
		public bool Update(OrderApply entity)
		{
			bool returnValue = false;
			using (OleDbConnection connection = new OleDbConnection(connectionString))
            { 
			
				try
				{
					OleDbParameter p;
					string sqlCommand = "Update Order_Apply Set [Order_NO] = ?,[Order_Title] = ?,[Res_User_NO] = ?,[receive_Name] = ?,[receive_Phone] = ?,[receive_Tel] = ?,[receive_Email] = ?,[receive_Address] = ?,[receive_Address1] = ?,[Mail_Money] = ?,[Product_T_Money] = ?,[Other_money] = ?,[Total_money] = ?,[Order_Status] = ?,[Product_Seller] = ?,[Remark] = ?,[Create_Date] = ?,[Last_update_Date] = ?,[Preferential_Money] = ?,[City] = ?,[State] = ?,[Country] = ?,[MyPayment] = ?,[ShipMent] = ?,[ZIP] = ? where [Order_Apply_ID] =?  ";
					using (OleDbCommand cmd = new OleDbCommand(sqlCommand,connection))
					{
						connection.Open();					
						
		p = new OleDbParameter("@Order_NO",OleDbType.VarChar);
		p.Value = entity.OrderNo;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@Order_Title",OleDbType.VarChar);
		p.Value = entity.OrderTitle;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@Res_User_NO",OleDbType.VarChar);
		p.Value = entity.ResUserNo;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@receive_Name",OleDbType.VarChar);
		p.Value = entity.ReceiveName;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@receive_Phone",OleDbType.VarChar);
		p.Value = entity.ReceivePhone;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@receive_Tel",OleDbType.VarChar);
		p.Value = entity.ReceiveTel;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@receive_Email",OleDbType.VarChar);
		p.Value = entity.ReceiveEmail;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@receive_Address",OleDbType.VarChar);
		p.Value = entity.ReceiveAddress;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@receive_Address1",OleDbType.VarChar);
		p.Value = entity.ReceiveAddress1;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@Mail_Money",OleDbType.Double);
		p.Value = entity.MailMoney;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@Product_T_Money",OleDbType.Double);
		p.Value = entity.ProductTMoney;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@Other_money",OleDbType.Double);
		p.Value = entity.OtherMoney;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@Total_money",OleDbType.Double);
		p.Value = entity.TotalMoney;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@Order_Status",OleDbType.Integer);
		p.Value = entity.OrderStatus;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@Product_Seller",OleDbType.VarChar);
		p.Value = entity.ProductSeller;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@Remark",OleDbType.VarChar);
		p.Value = entity.Remark;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@Create_Date",OleDbType.DBTimeStamp);
		p.Value = DateTime.Parse(entity.CreateDate.ToString("yyyy-MM-dd HH:mm:ss"));
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@Last_update_Date",OleDbType.DBTimeStamp);
		p.Value = DateTime.Parse(entity.LastUpdateDate.ToString("yyyy-MM-dd HH:mm:ss"));
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@Preferential_Money",OleDbType.Double);
		p.Value = entity.PreferentialMoney;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@City",OleDbType.VarChar);
		p.Value = entity.City;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@State",OleDbType.VarChar);
		p.Value = entity.State;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@Country",OleDbType.VarChar);
		p.Value = entity.Country;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@MyPayment",OleDbType.VarChar);
		p.Value = entity.Mypayment;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@ShipMent",OleDbType.VarChar);
		p.Value = entity.Shipment;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@ZIP",OleDbType.VarChar);
		p.Value = entity.Zip;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@Order_Apply_ID",OleDbType.Integer);
		p.Value = entity.OrderApplyId;
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
		public OrderApply SelectByID(OrderApply.Key entity)
        {
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
            
				try
				{
					OleDbParameter p;
					string sqlCommand = " select * From Order_Apply where [Order_Apply_ID] = ?    ";
					using (OleDbCommand cmd = new OleDbCommand(sqlCommand,connection))
					{   					
						connection.Open();				
						
		p = new OleDbParameter("@Order_Apply_ID",DbType.Int32);
		p.Value = entity.OrderApplyId;
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
			
				string sqlCommand = "   select * From Order_Apply  ";
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
		public bool DeleteByID(OrderApply.Key entity)
        {
			try
			{
				using (OleDbConnection connection = new OleDbConnection(connectionString))
				{
            	
					OleDbParameter p;
					string sqlCommand = " delete From Order_Apply where [Order_Apply_ID] = ?    ";
					using (OleDbCommand cmd = new OleDbCommand(sqlCommand,connection))
					{     
						connection.Open();				
						
		p = new OleDbParameter("@Order_Apply_ID",DbType.Int32);
		p.Value = entity.OrderApplyId;
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
		