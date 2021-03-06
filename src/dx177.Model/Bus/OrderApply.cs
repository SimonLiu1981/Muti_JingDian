/*
版权所有：版权所有(C) 2011，中兴通讯
文件编号：M01_OrderApply.cs
文件名称：OrderApply.cs
系统编号：Z0003007
系统名称：通用办公系统
模块编号：M01
模块名称：信息发布
设计文档：IOA_M01信息发布XDE建模.mdx
完成日期：2011-04-30
作　　者：
内容摘要：表[Order_Apply]对应的实体类
*/

using System;
using System.Collections;
using System.Data;


namespace dx177.Model.Bus
{
		/// <summary>
		/// 类 编 号：
		/// 类 名 称：OrderApply
		/// 内容摘要：
		/// </summary>
		
		[Serializable]
		public class OrderApply : BaseModel
		{
		#region 自动生成代码
		
			#region 重载Equals/GetHashCode
			/// <summary>
			/// 重载Equals			
			/// </summary>
			public override bool Equals (Object obj)
			{
				if (obj != null && obj is OrderApply)
				{
					if (obj == this)
						return true;
					OrderApply castObj = (OrderApply)obj; 
					
					if (!this.m_OrderApplyId.Equals(castObj.OrderApplyId))
						return false;
						
					if (!this.m_OrderNo.Equals(castObj.OrderNo))
						return false;
						
					if (!this.m_OrderTitle.Equals(castObj.OrderTitle))
						return false;
						
					if (!this.m_ResUserNo.Equals(castObj.ResUserNo))
						return false;
						
					if (!this.m_ReceiveName.Equals(castObj.ReceiveName))
						return false;
						
					if (!this.m_ReceivePhone.Equals(castObj.ReceivePhone))
						return false;
						
					if (!this.m_ReceiveTel.Equals(castObj.ReceiveTel))
						return false;
						
					if (!this.m_ReceiveEmail.Equals(castObj.ReceiveEmail))
						return false;
						
					if (!this.m_ReceiveAddress.Equals(castObj.ReceiveAddress))
						return false;
						
					if (!this.m_ReceiveAddress1.Equals(castObj.ReceiveAddress1))
						return false;
						
					if (!this.m_MailMoney.Equals(castObj.MailMoney))
						return false;
						
					if (!this.m_ProductTMoney.Equals(castObj.ProductTMoney))
						return false;
						
					if (!this.m_OtherMoney.Equals(castObj.OtherMoney))
						return false;
						
					if (!this.m_TotalMoney.Equals(castObj.TotalMoney))
						return false;
						
					if (!this.m_OrderStatus.Equals(castObj.OrderStatus))
						return false;
						
					if (!this.m_ProductSeller.Equals(castObj.ProductSeller))
						return false;
						
					if (!this.m_Remark.Equals(castObj.Remark))
						return false;
						
					if (!this.m_CreateDate.Equals(castObj.CreateDate))
						return false;
						
					if (!this.m_LastUpdateDate.Equals(castObj.LastUpdateDate))
						return false;
						
					if (!this.m_PreferentialMoney.Equals(castObj.PreferentialMoney))
						return false;
						
					if (!this.m_City.Equals(castObj.City))
						return false;
						
					if (!this.m_State.Equals(castObj.State))
						return false;
						
					if (!this.m_Country.Equals(castObj.Country))
						return false;
						
					if (!this.m_Mypayment.Equals(castObj.Mypayment))
						return false;
						
					if (!this.m_Shipment.Equals(castObj.Shipment))
						return false;
						
					if (!this.m_Zip.Equals(castObj.Zip))
						return false;
						
					return true;
				}
				return false;
			}
			
			/// <summary>
			/// 重载GetHashCode
			/// </summary>
			public override int GetHashCode()
			{
					int hash = 0;					
					
					hash = hash <<  8;
					if ((object)m_OrderApplyId != null)
					{
						hash = hash ^ m_OrderApplyId.GetHashCode();
					}
						
					hash = hash <<  8;
					if ((object)m_OrderNo != null)
					{
						hash = hash ^ m_OrderNo.GetHashCode();
					}
						
					hash = hash <<  8;
					if ((object)m_OrderTitle != null)
					{
						hash = hash ^ m_OrderTitle.GetHashCode();
					}
						
					hash = hash <<  8;
					if ((object)m_ResUserNo != null)
					{
						hash = hash ^ m_ResUserNo.GetHashCode();
					}
						
					hash = hash <<  8;
					if ((object)m_ReceiveName != null)
					{
						hash = hash ^ m_ReceiveName.GetHashCode();
					}
						
					hash = hash <<  8;
					if ((object)m_ReceivePhone != null)
					{
						hash = hash ^ m_ReceivePhone.GetHashCode();
					}
						
					hash = hash <<  8;
					if ((object)m_ReceiveTel != null)
					{
						hash = hash ^ m_ReceiveTel.GetHashCode();
					}
						
					hash = hash <<  8;
					if ((object)m_ReceiveEmail != null)
					{
						hash = hash ^ m_ReceiveEmail.GetHashCode();
					}
						
					hash = hash <<  8;
					if ((object)m_ReceiveAddress != null)
					{
						hash = hash ^ m_ReceiveAddress.GetHashCode();
					}
						
					hash = hash <<  8;
					if ((object)m_ReceiveAddress1 != null)
					{
						hash = hash ^ m_ReceiveAddress1.GetHashCode();
					}
						
					hash = hash <<  8;
					if ((object)m_MailMoney != null)
					{
						hash = hash ^ m_MailMoney.GetHashCode();
					}
						
					hash = hash <<  8;
					if ((object)m_ProductTMoney != null)
					{
						hash = hash ^ m_ProductTMoney.GetHashCode();
					}
						
					hash = hash <<  8;
					if ((object)m_OtherMoney != null)
					{
						hash = hash ^ m_OtherMoney.GetHashCode();
					}
						
					hash = hash <<  8;
					if ((object)m_TotalMoney != null)
					{
						hash = hash ^ m_TotalMoney.GetHashCode();
					}
						
					hash = hash <<  8;
					if ((object)m_OrderStatus != null)
					{
						hash = hash ^ m_OrderStatus.GetHashCode();
					}
						
					hash = hash <<  8;
					if ((object)m_ProductSeller != null)
					{
						hash = hash ^ m_ProductSeller.GetHashCode();
					}
						
					hash = hash <<  8;
					if ((object)m_Remark != null)
					{
						hash = hash ^ m_Remark.GetHashCode();
					}
						
					hash = hash <<  8;
					if ((object)m_CreateDate != null)
					{
						hash = hash ^ m_CreateDate.GetHashCode();
					}
						
					hash = hash <<  8;
					if ((object)m_LastUpdateDate != null)
					{
						hash = hash ^ m_LastUpdateDate.GetHashCode();
					}
						
					hash = hash <<  8;
					if ((object)m_PreferentialMoney != null)
					{
						hash = hash ^ m_PreferentialMoney.GetHashCode();
					}
						
					hash = hash <<  8;
					if ((object)m_City != null)
					{
						hash = hash ^ m_City.GetHashCode();
					}
						
					hash = hash <<  8;
					if ((object)m_State != null)
					{
						hash = hash ^ m_State.GetHashCode();
					}
						
					hash = hash <<  8;
					if ((object)m_Country != null)
					{
						hash = hash ^ m_Country.GetHashCode();
					}
						
					hash = hash <<  8;
					if ((object)m_Mypayment != null)
					{
						hash = hash ^ m_Mypayment.GetHashCode();
					}
						
					hash = hash <<  8;
					if ((object)m_Shipment != null)
					{
						hash = hash ^ m_Shipment.GetHashCode();
					}
						
					hash = hash <<  8;
					if ((object)m_Zip != null)
					{
						hash = hash ^ m_Zip.GetHashCode();
					}
						
					return hash; 
			}
			#endregion
			
			public OrderApply()
			{
				MarkNew();
			}						
			
			public OrderApply GetOldValue()
			{
				return OldValue as OrderApply;
			}
		
		#region OrderApplyId属性
			private int m_OrderApplyId = 0;
			/// <summary>
			/// 属性名称： OrderApplyId
			/// 内容摘要： DB列名：Order_Apply_ID[]
			///            DB类型：int
			/// </summary>
			public int OrderApplyId
			{
				get
					{
						return m_OrderApplyId;
					}
				set
					{
						if (m_OrderApplyId as object == null || !m_OrderApplyId.Equals(value))
						{
							m_OrderApplyId = value;
							MarkUpdated();
						}						
					}
			}
		#endregion
		
		#region OrderNo属性
			private string m_OrderNo = String.Empty;
			/// <summary>
			/// 属性名称： OrderNo
			/// 内容摘要： DB列名：Order_NO[]
			///            DB类型：nvarchar(50)
			/// </summary>
			public string OrderNo
			{
				get
					{
						return m_OrderNo;
					}
				set
					{
						if (m_OrderNo as object == null || !m_OrderNo.Equals(value))
						{
							m_OrderNo = value;
							MarkUpdated();
						}						
					}
			}
		#endregion
		
		#region OrderTitle属性
			private string m_OrderTitle = String.Empty;
			/// <summary>
			/// 属性名称： OrderTitle
			/// 内容摘要： DB列名：Order_Title[]
			///            DB类型：nvarchar(200)
			/// </summary>
			public string OrderTitle
			{
				get
					{
						return m_OrderTitle;
					}
				set
					{
						if (m_OrderTitle as object == null || !m_OrderTitle.Equals(value))
						{
							m_OrderTitle = value;
							MarkUpdated();
						}						
					}
			}
		#endregion
		
		#region ResUserNo属性
			private string m_ResUserNo = String.Empty;
			/// <summary>
			/// 属性名称： ResUserNo
			/// 内容摘要： DB列名：Res_User_NO[]
			///            DB类型：nvarchar(50)
			/// </summary>
			public string ResUserNo
			{
				get
					{
						return m_ResUserNo;
					}
				set
					{
						if (m_ResUserNo as object == null || !m_ResUserNo.Equals(value))
						{
							m_ResUserNo = value;
							MarkUpdated();
						}						
					}
			}
		#endregion
		
		#region ReceiveName属性
			private string m_ReceiveName = String.Empty;
			/// <summary>
			/// 属性名称： ReceiveName
			/// 内容摘要： DB列名：receive_Name[]
			///            DB类型：nvarchar(200)
			/// </summary>
			public string ReceiveName
			{
				get
					{
						return m_ReceiveName;
					}
				set
					{
						if (m_ReceiveName as object == null || !m_ReceiveName.Equals(value))
						{
							m_ReceiveName = value;
							MarkUpdated();
						}						
					}
			}
		#endregion
		
		#region ReceivePhone属性
			private string m_ReceivePhone = String.Empty;
			/// <summary>
			/// 属性名称： ReceivePhone
			/// 内容摘要： DB列名：receive_Phone[]
			///            DB类型：nvarchar(50)
			/// </summary>
			public string ReceivePhone
			{
				get
					{
						return m_ReceivePhone;
					}
				set
					{
						if (m_ReceivePhone as object == null || !m_ReceivePhone.Equals(value))
						{
							m_ReceivePhone = value;
							MarkUpdated();
						}						
					}
			}
		#endregion
		
		#region ReceiveTel属性
			private string m_ReceiveTel = String.Empty;
			/// <summary>
			/// 属性名称： ReceiveTel
			/// 内容摘要： DB列名：receive_Tel[]
			///            DB类型：nvarchar(50)
			/// </summary>
			public string ReceiveTel
			{
				get
					{
						return m_ReceiveTel;
					}
				set
					{
						if (m_ReceiveTel as object == null || !m_ReceiveTel.Equals(value))
						{
							m_ReceiveTel = value;
							MarkUpdated();
						}						
					}
			}
		#endregion
		
		#region ReceiveEmail属性
			private string m_ReceiveEmail = String.Empty;
			/// <summary>
			/// 属性名称： ReceiveEmail
			/// 内容摘要： DB列名：receive_Email[]
			///            DB类型：nvarchar(50)
			/// </summary>
			public string ReceiveEmail
			{
				get
					{
						return m_ReceiveEmail;
					}
				set
					{
						if (m_ReceiveEmail as object == null || !m_ReceiveEmail.Equals(value))
						{
							m_ReceiveEmail = value;
							MarkUpdated();
						}						
					}
			}
		#endregion
		
		#region ReceiveAddress属性
			private string m_ReceiveAddress = String.Empty;
			/// <summary>
			/// 属性名称： ReceiveAddress
			/// 内容摘要： DB列名：receive_Address[]
			///            DB类型：nvarchar(200)
			/// </summary>
			public string ReceiveAddress
			{
				get
					{
						return m_ReceiveAddress;
					}
				set
					{
						if (m_ReceiveAddress as object == null || !m_ReceiveAddress.Equals(value))
						{
							m_ReceiveAddress = value;
							MarkUpdated();
						}						
					}
			}
		#endregion
		
		#region ReceiveAddress1属性
			private string m_ReceiveAddress1 = String.Empty;
			/// <summary>
			/// 属性名称： ReceiveAddress1
			/// 内容摘要： DB列名：receive_Address1[]
			///            DB类型：nvarchar(200)
			/// </summary>
			public string ReceiveAddress1
			{
				get
					{
						return m_ReceiveAddress1;
					}
				set
					{
						if (m_ReceiveAddress1 as object == null || !m_ReceiveAddress1.Equals(value))
						{
							m_ReceiveAddress1 = value;
							MarkUpdated();
						}						
					}
			}
		#endregion
		
		#region MailMoney属性
			private double m_MailMoney = 0.0;
			/// <summary>
			/// 属性名称： MailMoney
			/// 内容摘要： DB列名：Mail_Money[]
			///            DB类型：float
			/// </summary>
			public double MailMoney
			{
				get
					{
						return m_MailMoney;
					}
				set
					{
						if (m_MailMoney as object == null || !m_MailMoney.Equals(value))
						{
							m_MailMoney = value;
							MarkUpdated();
						}						
					}
			}
		#endregion
		
		#region ProductTMoney属性
			private double m_ProductTMoney = 0.0;
			/// <summary>
			/// 属性名称： ProductTMoney
			/// 内容摘要： DB列名：Product_T_Money[]
			///            DB类型：float
			/// </summary>
			public double ProductTMoney
			{
				get
					{
						return m_ProductTMoney;
					}
				set
					{
						if (m_ProductTMoney as object == null || !m_ProductTMoney.Equals(value))
						{
							m_ProductTMoney = value;
							MarkUpdated();
						}						
					}
			}
		#endregion
		
		#region OtherMoney属性
			private double m_OtherMoney = 0.0;
			/// <summary>
			/// 属性名称： OtherMoney
			/// 内容摘要： DB列名：Other_money[]
			///            DB类型：float
			/// </summary>
			public double OtherMoney
			{
				get
					{
						return m_OtherMoney;
					}
				set
					{
						if (m_OtherMoney as object == null || !m_OtherMoney.Equals(value))
						{
							m_OtherMoney = value;
							MarkUpdated();
						}						
					}
			}
		#endregion
		
		#region TotalMoney属性
			private double m_TotalMoney = 0.0;
			/// <summary>
			/// 属性名称： TotalMoney
			/// 内容摘要： DB列名：Total_money[]
			///            DB类型：float
			/// </summary>
			public double TotalMoney
			{
				get
					{
						return m_TotalMoney;
					}
				set
					{
						if (m_TotalMoney as object == null || !m_TotalMoney.Equals(value))
						{
							m_TotalMoney = value;
							MarkUpdated();
						}						
					}
			}
		#endregion
		
		#region OrderStatus属性
			private int m_OrderStatus = 0;
			/// <summary>
			/// 属性名称： OrderStatus
			/// 内容摘要： DB列名：Order_Status[]
			///            DB类型：int
			/// </summary>
			public int OrderStatus
			{
				get
					{
						return m_OrderStatus;
					}
				set
					{
						if (m_OrderStatus as object == null || !m_OrderStatus.Equals(value))
						{
							m_OrderStatus = value;
							MarkUpdated();
						}						
					}
			}
		#endregion
		
		#region ProductSeller属性
			private string m_ProductSeller = String.Empty;
			/// <summary>
			/// 属性名称： ProductSeller
			/// 内容摘要： DB列名：Product_Seller[]
			///            DB类型：nvarchar(50)
			/// </summary>
			public string ProductSeller
			{
				get
					{
						return m_ProductSeller;
					}
				set
					{
						if (m_ProductSeller as object == null || !m_ProductSeller.Equals(value))
						{
							m_ProductSeller = value;
							MarkUpdated();
						}						
					}
			}
		#endregion
		
		#region Remark属性
			private string m_Remark = String.Empty;
			/// <summary>
			/// 属性名称： Remark
			/// 内容摘要： DB列名：Remark[]
			///            DB类型：nvarchar(500)
			/// </summary>
			public string Remark
			{
				get
					{
						return m_Remark;
					}
				set
					{
						if (m_Remark as object == null || !m_Remark.Equals(value))
						{
							m_Remark = value;
							MarkUpdated();
						}						
					}
			}
		#endregion
		
		#region CreateDate属性
			private DateTime m_CreateDate = new DateTime(1900,1,1);
			/// <summary>
			/// 属性名称： CreateDate
			/// 内容摘要： DB列名：Create_Date[]
			///            DB类型：datetime
			/// </summary>
			public DateTime CreateDate
			{
				get
					{
						return m_CreateDate;
					}
				set
					{
						if (m_CreateDate as object == null || !m_CreateDate.Equals(value))
						{
							m_CreateDate = value;
							MarkUpdated();
						}						
					}
			}
		#endregion
		
		#region LastUpdateDate属性
			private DateTime m_LastUpdateDate = new DateTime(1900,1,1);
			/// <summary>
			/// 属性名称： LastUpdateDate
			/// 内容摘要： DB列名：Last_update_Date[]
			///            DB类型：datetime
			/// </summary>
			public DateTime LastUpdateDate
			{
				get
					{
						return m_LastUpdateDate;
					}
				set
					{
						if (m_LastUpdateDate as object == null || !m_LastUpdateDate.Equals(value))
						{
							m_LastUpdateDate = value;
							MarkUpdated();
						}						
					}
			}
		#endregion
		
		#region PreferentialMoney属性
			private double m_PreferentialMoney = 0.0;
			/// <summary>
			/// 属性名称： PreferentialMoney
			/// 内容摘要： DB列名：Preferential_Money[]
			///            DB类型：float
			/// </summary>
			public double PreferentialMoney
			{
				get
					{
						return m_PreferentialMoney;
					}
				set
					{
						if (m_PreferentialMoney as object == null || !m_PreferentialMoney.Equals(value))
						{
							m_PreferentialMoney = value;
							MarkUpdated();
						}						
					}
			}
		#endregion
		
		#region City属性
			private string m_City = String.Empty;
			/// <summary>
			/// 属性名称： City
			/// 内容摘要： DB列名：City[]
			///            DB类型：nvarchar(50)
			/// </summary>
			public string City
			{
				get
					{
						return m_City;
					}
				set
					{
						if (m_City as object == null || !m_City.Equals(value))
						{
							m_City = value;
							MarkUpdated();
						}						
					}
			}
		#endregion
		
		#region State属性
			private string m_State = String.Empty;
			/// <summary>
			/// 属性名称： State
			/// 内容摘要： DB列名：State[]
			///            DB类型：nvarchar(50)
			/// </summary>
			public string State
			{
				get
					{
						return m_State;
					}
				set
					{
						if (m_State as object == null || !m_State.Equals(value))
						{
							m_State = value;
							MarkUpdated();
						}						
					}
			}
		#endregion
		
		#region Country属性
			private string m_Country = String.Empty;
			/// <summary>
			/// 属性名称： Country
			/// 内容摘要： DB列名：Country[]
			///            DB类型：nvarchar(50)
			/// </summary>
			public string Country
			{
				get
					{
						return m_Country;
					}
				set
					{
						if (m_Country as object == null || !m_Country.Equals(value))
						{
							m_Country = value;
							MarkUpdated();
						}						
					}
			}
		#endregion
		
		#region Mypayment属性
			private string m_Mypayment = String.Empty;
			/// <summary>
			/// 属性名称： Mypayment
			/// 内容摘要： DB列名：MyPayment[]
			///            DB类型：nvarchar(50)
			/// </summary>
			public string Mypayment
			{
				get
					{
						return m_Mypayment;
					}
				set
					{
						if (m_Mypayment as object == null || !m_Mypayment.Equals(value))
						{
							m_Mypayment = value;
							MarkUpdated();
						}						
					}
			}
		#endregion
		
		#region Shipment属性
			private string m_Shipment = String.Empty;
			/// <summary>
			/// 属性名称： Shipment
			/// 内容摘要： DB列名：ShipMent[]
			///            DB类型：nvarchar(50)
			/// </summary>
			public string Shipment
			{
				get
					{
						return m_Shipment;
					}
				set
					{
						if (m_Shipment as object == null || !m_Shipment.Equals(value))
						{
							m_Shipment = value;
							MarkUpdated();
						}						
					}
			}
		#endregion
		
		#region Zip属性
			private string m_Zip = String.Empty;
			/// <summary>
			/// 属性名称： Zip
			/// 内容摘要： DB列名：ZIP[]
			///            DB类型：nvarchar(50)
			/// </summary>
			public string Zip
			{
				get
					{
						return m_Zip;
					}
				set
					{
						if (m_Zip as object == null || !m_Zip.Equals(value))
						{
							m_Zip = value;
							MarkUpdated();
						}						
					}
			}
		#endregion
		
		#region static CreateDataTable/FillDataRow/DataRow2Obj/Dt2Objs/FillDataTable
			/// <summary>
			/// 得到实体对应的DataTable
			/// </summary>
			/// <param name="tableName">表名</param>
			/// <param name="cne">列名映射选择:DB列名或属性名</param>
			/// <returns>生成的DataTable</returns>
			static public DataTable CreateDataTable(string tableName,ColumnNameEnum cne)
			{
				DataTable dtResult = new DataTable(tableName);
			
				if (cne == ColumnNameEnum.DBName)
				{
					dtResult.Columns.Add(new DataColumn("Order_Apply_ID",typeof(int)));
					dtResult.Columns.Add(new DataColumn("Order_NO",typeof(string)));
					dtResult.Columns.Add(new DataColumn("Order_Title",typeof(string)));
					dtResult.Columns.Add(new DataColumn("Res_User_NO",typeof(string)));
					dtResult.Columns.Add(new DataColumn("receive_Name",typeof(string)));
					dtResult.Columns.Add(new DataColumn("receive_Phone",typeof(string)));
					dtResult.Columns.Add(new DataColumn("receive_Tel",typeof(string)));
					dtResult.Columns.Add(new DataColumn("receive_Email",typeof(string)));
					dtResult.Columns.Add(new DataColumn("receive_Address",typeof(string)));
					dtResult.Columns.Add(new DataColumn("receive_Address1",typeof(string)));
					dtResult.Columns.Add(new DataColumn("Mail_Money",typeof(double)));
					dtResult.Columns.Add(new DataColumn("Product_T_Money",typeof(double)));
					dtResult.Columns.Add(new DataColumn("Other_money",typeof(double)));
					dtResult.Columns.Add(new DataColumn("Total_money",typeof(double)));
					dtResult.Columns.Add(new DataColumn("Order_Status",typeof(int)));
					dtResult.Columns.Add(new DataColumn("Product_Seller",typeof(string)));
					dtResult.Columns.Add(new DataColumn("Remark",typeof(string)));
					dtResult.Columns.Add(new DataColumn("Create_Date",typeof(DateTime)));
					dtResult.Columns.Add(new DataColumn("Last_update_Date",typeof(DateTime)));
					dtResult.Columns.Add(new DataColumn("Preferential_Money",typeof(double)));
					dtResult.Columns.Add(new DataColumn("City",typeof(string)));
					dtResult.Columns.Add(new DataColumn("State",typeof(string)));
					dtResult.Columns.Add(new DataColumn("Country",typeof(string)));
					dtResult.Columns.Add(new DataColumn("MyPayment",typeof(string)));
					dtResult.Columns.Add(new DataColumn("ShipMent",typeof(string)));
					dtResult.Columns.Add(new DataColumn("ZIP",typeof(string)));
				}
				else if (cne == ColumnNameEnum.PropertyName)
				{
					dtResult.Columns.Add(new DataColumn("OrderApplyId",typeof(int)));
					dtResult.Columns.Add(new DataColumn("OrderNo",typeof(string)));
					dtResult.Columns.Add(new DataColumn("OrderTitle",typeof(string)));
					dtResult.Columns.Add(new DataColumn("ResUserNo",typeof(string)));
					dtResult.Columns.Add(new DataColumn("ReceiveName",typeof(string)));
					dtResult.Columns.Add(new DataColumn("ReceivePhone",typeof(string)));
					dtResult.Columns.Add(new DataColumn("ReceiveTel",typeof(string)));
					dtResult.Columns.Add(new DataColumn("ReceiveEmail",typeof(string)));
					dtResult.Columns.Add(new DataColumn("ReceiveAddress",typeof(string)));
					dtResult.Columns.Add(new DataColumn("ReceiveAddress1",typeof(string)));
					dtResult.Columns.Add(new DataColumn("MailMoney",typeof(double)));
					dtResult.Columns.Add(new DataColumn("ProductTMoney",typeof(double)));
					dtResult.Columns.Add(new DataColumn("OtherMoney",typeof(double)));
					dtResult.Columns.Add(new DataColumn("TotalMoney",typeof(double)));
					dtResult.Columns.Add(new DataColumn("OrderStatus",typeof(int)));
					dtResult.Columns.Add(new DataColumn("ProductSeller",typeof(string)));
					dtResult.Columns.Add(new DataColumn("Remark",typeof(string)));
					dtResult.Columns.Add(new DataColumn("CreateDate",typeof(DateTime)));
					dtResult.Columns.Add(new DataColumn("LastUpdateDate",typeof(DateTime)));
					dtResult.Columns.Add(new DataColumn("PreferentialMoney",typeof(double)));
					dtResult.Columns.Add(new DataColumn("City",typeof(string)));
					dtResult.Columns.Add(new DataColumn("State",typeof(string)));
					dtResult.Columns.Add(new DataColumn("Country",typeof(string)));
					dtResult.Columns.Add(new DataColumn("Mypayment",typeof(string)));
					dtResult.Columns.Add(new DataColumn("Shipment",typeof(string)));
					dtResult.Columns.Add(new DataColumn("Zip",typeof(string)));
				}
				return dtResult;
			}
			
			/// <summary>
			/// 得到实体对应的DataTable
			/// </summary>
			/// <param name="cne">列名映射选择:DB列名或属性名</param>
			/// <returns>生成的DataTable</returns>
			static public DataTable CreateDataTable(ColumnNameEnum cne)
			{
				return CreateDataTable(null,cne);
			}

			/// <summary>
			/// 得到实体对应的DataTable(默认列名映射为属性名)
			/// </summary>
			/// <returns>生成的DataTable</returns>
			static public DataTable CreateDataTable()
			{
				return CreateDataTable(ColumnNameEnum.PropertyName);
			}
			
			/// <summary>
			/// 用当前对象值填充DaraRow
			/// </summary>
			/// <param name="dr">由CreateTable生成的DataTable通过NewRow得到的DataRow对象</param>
			/// <param name="cne">dr的列名映射方式:DB列名或属性名</param>
			public void FillDataRow(DataRow dr,ColumnNameEnum cne)
			{
				if (dr == null)
				{
					throw new ArgumentNullException("dr");
				}
				if (ColumnNameEnum.DBName == cne)
				{
					dr["Order_Apply_ID"] = this.OrderApplyId;
					dr["Order_NO"] = this.OrderNo;
					dr["Order_Title"] = this.OrderTitle;
					dr["Res_User_NO"] = this.ResUserNo;
					dr["receive_Name"] = this.ReceiveName;
					dr["receive_Phone"] = this.ReceivePhone;
					dr["receive_Tel"] = this.ReceiveTel;
					dr["receive_Email"] = this.ReceiveEmail;
					dr["receive_Address"] = this.ReceiveAddress;
					dr["receive_Address1"] = this.ReceiveAddress1;
					dr["Mail_Money"] = this.MailMoney;
					dr["Product_T_Money"] = this.ProductTMoney;
					dr["Other_money"] = this.OtherMoney;
					dr["Total_money"] = this.TotalMoney;
					dr["Order_Status"] = this.OrderStatus;
					dr["Product_Seller"] = this.ProductSeller;
					dr["Remark"] = this.Remark;
					dr["Create_Date"] = this.CreateDate;
					dr["Last_update_Date"] = this.LastUpdateDate;
					dr["Preferential_Money"] = this.PreferentialMoney;
					dr["City"] = this.City;
					dr["State"] = this.State;
					dr["Country"] = this.Country;
					dr["MyPayment"] = this.Mypayment;
					dr["ShipMent"] = this.Shipment;
					dr["ZIP"] = this.Zip;
				}
				else if (ColumnNameEnum.PropertyName == cne)
				{
					dr["OrderApplyId"] = this.OrderApplyId;
					dr["OrderNo"] = this.OrderNo;
					dr["OrderTitle"] = this.OrderTitle;
					dr["ResUserNo"] = this.ResUserNo;
					dr["ReceiveName"] = this.ReceiveName;
					dr["ReceivePhone"] = this.ReceivePhone;
					dr["ReceiveTel"] = this.ReceiveTel;
					dr["ReceiveEmail"] = this.ReceiveEmail;
					dr["ReceiveAddress"] = this.ReceiveAddress;
					dr["ReceiveAddress1"] = this.ReceiveAddress1;
					dr["MailMoney"] = this.MailMoney;
					dr["ProductTMoney"] = this.ProductTMoney;
					dr["OtherMoney"] = this.OtherMoney;
					dr["TotalMoney"] = this.TotalMoney;
					dr["OrderStatus"] = this.OrderStatus;
					dr["ProductSeller"] = this.ProductSeller;
					dr["Remark"] = this.Remark;
					dr["CreateDate"] = this.CreateDate;
					dr["LastUpdateDate"] = this.LastUpdateDate;
					dr["PreferentialMoney"] = this.PreferentialMoney;
					dr["City"] = this.City;
					dr["State"] = this.State;
					dr["Country"] = this.Country;
					dr["Mypayment"] = this.Mypayment;
					dr["Shipment"] = this.Shipment;
					dr["Zip"] = this.Zip;					
				}
			}
			
			/// <summary>
			/// 用当前对象值填充DaraRow(默认列名映射为属性名)
			/// </summary>
			/// <param name="dr">由CreateTable生成的DataTable通过NewRow得到的DataRow对象</param>
			public void FillDataRow(DataRow dr)
			{
				this.FillDataRow(dr,ColumnNameEnum.PropertyName);
			}
			
			/// <summary>
			/// 将DataRow转换成OrderApply对象
			/// </summary>
			/// <param name="dr">由CreateTable生成的DataTable通过NewRow得到的DataRow对象</param>
			/// <param name="cne">dr的列名映射方式:DB列名或属性名</param>
			/// <returns>OrderApply对象</returns>
			public static OrderApply Dr2Obj(DataRow dr,ColumnNameEnum cne)
			{
				if (dr == null)
				{
					throw new ArgumentNullException("dr");
				}
				OrderApply obj = new OrderApply();
				if (ColumnNameEnum.DBName == cne)
				{
					obj.OrderApplyId = (dr["Order_Apply_ID"] == Convert.DBNull) ? 0  : (int)Convert.ChangeType(dr["Order_Apply_ID"],typeof(int));
					obj.OrderNo = (dr["Order_NO"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Order_NO"],typeof(string));
					obj.OrderTitle = (dr["Order_Title"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Order_Title"],typeof(string));
					obj.ResUserNo = (dr["Res_User_NO"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Res_User_NO"],typeof(string));
					obj.ReceiveName = (dr["receive_Name"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["receive_Name"],typeof(string));
					obj.ReceivePhone = (dr["receive_Phone"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["receive_Phone"],typeof(string));
					obj.ReceiveTel = (dr["receive_Tel"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["receive_Tel"],typeof(string));
					obj.ReceiveEmail = (dr["receive_Email"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["receive_Email"],typeof(string));
					obj.ReceiveAddress = (dr["receive_Address"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["receive_Address"],typeof(string));
					obj.ReceiveAddress1 = (dr["receive_Address1"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["receive_Address1"],typeof(string));
					obj.MailMoney = (dr["Mail_Money"] == Convert.DBNull) ? 0.0  : (double)Convert.ChangeType(dr["Mail_Money"],typeof(double));
					obj.ProductTMoney = (dr["Product_T_Money"] == Convert.DBNull) ? 0.0  : (double)Convert.ChangeType(dr["Product_T_Money"],typeof(double));
					obj.OtherMoney = (dr["Other_money"] == Convert.DBNull) ? 0.0  : (double)Convert.ChangeType(dr["Other_money"],typeof(double));
					obj.TotalMoney = (dr["Total_money"] == Convert.DBNull) ? 0.0  : (double)Convert.ChangeType(dr["Total_money"],typeof(double));
					obj.OrderStatus = (dr["Order_Status"] == Convert.DBNull) ? 0  : (int)Convert.ChangeType(dr["Order_Status"],typeof(int));
					obj.ProductSeller = (dr["Product_Seller"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Product_Seller"],typeof(string));
					obj.Remark = (dr["Remark"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Remark"],typeof(string));
					obj.CreateDate = (dr["Create_Date"] == Convert.DBNull) ? new DateTime(1900,1,1)  : (DateTime)Convert.ChangeType(dr["Create_Date"],typeof(DateTime));
					obj.LastUpdateDate = (dr["Last_update_Date"] == Convert.DBNull) ? new DateTime(1900,1,1)  : (DateTime)Convert.ChangeType(dr["Last_update_Date"],typeof(DateTime));
					obj.PreferentialMoney = (dr["Preferential_Money"] == Convert.DBNull) ? 0.0  : (double)Convert.ChangeType(dr["Preferential_Money"],typeof(double));
					obj.City = (dr["City"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["City"],typeof(string));
					obj.State = (dr["State"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["State"],typeof(string));
					obj.Country = (dr["Country"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Country"],typeof(string));
					obj.Mypayment = (dr["MyPayment"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["MyPayment"],typeof(string));
					obj.Shipment = (dr["ShipMent"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["ShipMent"],typeof(string));
					obj.Zip = (dr["ZIP"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["ZIP"],typeof(string));
				}
				else if (ColumnNameEnum.PropertyName == cne)
				{
					obj.OrderApplyId = (dr["OrderApplyId"] == Convert.DBNull) ? 0  : (int)Convert.ChangeType(dr["OrderApplyId"],typeof(int));
					obj.OrderNo = (dr["OrderNo"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["OrderNo"],typeof(string));
					obj.OrderTitle = (dr["OrderTitle"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["OrderTitle"],typeof(string));
					obj.ResUserNo = (dr["ResUserNo"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["ResUserNo"],typeof(string));
					obj.ReceiveName = (dr["ReceiveName"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["ReceiveName"],typeof(string));
					obj.ReceivePhone = (dr["ReceivePhone"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["ReceivePhone"],typeof(string));
					obj.ReceiveTel = (dr["ReceiveTel"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["ReceiveTel"],typeof(string));
					obj.ReceiveEmail = (dr["ReceiveEmail"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["ReceiveEmail"],typeof(string));
					obj.ReceiveAddress = (dr["ReceiveAddress"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["ReceiveAddress"],typeof(string));
					obj.ReceiveAddress1 = (dr["ReceiveAddress1"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["ReceiveAddress1"],typeof(string));
					obj.MailMoney = (dr["MailMoney"] == Convert.DBNull) ? 0.0  : (double)Convert.ChangeType(dr["MailMoney"],typeof(double));
					obj.ProductTMoney = (dr["ProductTMoney"] == Convert.DBNull) ? 0.0  : (double)Convert.ChangeType(dr["ProductTMoney"],typeof(double));
					obj.OtherMoney = (dr["OtherMoney"] == Convert.DBNull) ? 0.0  : (double)Convert.ChangeType(dr["OtherMoney"],typeof(double));
					obj.TotalMoney = (dr["TotalMoney"] == Convert.DBNull) ? 0.0  : (double)Convert.ChangeType(dr["TotalMoney"],typeof(double));
					obj.OrderStatus = (dr["OrderStatus"] == Convert.DBNull) ? 0  : (int)Convert.ChangeType(dr["OrderStatus"],typeof(int));
					obj.ProductSeller = (dr["ProductSeller"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["ProductSeller"],typeof(string));
					obj.Remark = (dr["Remark"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Remark"],typeof(string));
					obj.CreateDate = (dr["CreateDate"] == Convert.DBNull) ? new DateTime(1900,1,1)  : (DateTime)Convert.ChangeType(dr["CreateDate"],typeof(DateTime));
					obj.LastUpdateDate = (dr["LastUpdateDate"] == Convert.DBNull) ? new DateTime(1900,1,1)  : (DateTime)Convert.ChangeType(dr["LastUpdateDate"],typeof(DateTime));
					obj.PreferentialMoney = (dr["PreferentialMoney"] == Convert.DBNull) ? 0.0  : (double)Convert.ChangeType(dr["PreferentialMoney"],typeof(double));
					obj.City = (dr["City"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["City"],typeof(string));
					obj.State = (dr["State"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["State"],typeof(string));
					obj.Country = (dr["Country"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Country"],typeof(string));
					obj.Mypayment = (dr["Mypayment"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Mypayment"],typeof(string));
					obj.Shipment = (dr["Shipment"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Shipment"],typeof(string));
					obj.Zip = (dr["Zip"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Zip"],typeof(string));		
				}
				
				return obj;
			}
			
			/// <summary>
			/// 将DataRow转换成OrderApply对象(默认列名映射为属性名)
			/// </summary>
			/// <returns>OrderApply对象</returns>
			public static OrderApply Dr2Obj(DataRow dr)
			{
				return Dr2Obj(dr,ColumnNameEnum.PropertyName);
			}
			
			/// <summary>
			/// 将DataTabe转换成的OrderApply对象集合
			/// </summary>
			/// <param name="dt">由CreateTable生成的DataTable</param>
			/// <param name="cne">dt的列名映射方式:DB列名或属性名</param>
			/// <returns>OrderApply对象的集合</returns>
			public static IList Dt2Objs(DataTable dt,ColumnNameEnum cne)
			{
				if (dt == null)
				{
					throw new ArgumentNullException("dt");
				}
				
				ArrayList alResult = new ArrayList();
				
				foreach(DataRow dr in dt.Rows)
				{
					alResult.Add(Dr2Obj(dr,cne));
				}
				
				return alResult;
			}

			/// <summary>
			/// 将DataTabe转换成的OrderApply对象集合(默认列名映射为属性名)
			/// </summary>
			/// <param name="dt">由CreateTable生成的DataTable</param>
			/// <returns>OrderApply对象的集合</returns>
			public static IList Dt2Objs(DataTable dt)
			{
				return Dt2Objs(dt,ColumnNameEnum.PropertyName);
			}
			
			/// <summary>
			/// 用objs的OrderApply对象集合填充DataTable
			/// </summary>
			/// <param name="dt">由CreateTable生成的DataTable</param>
			/// <param name="objs">OrderApply对象集合</param>
			/// <param name="cne">dt的列名映射方式:DB列名或属性名</param>
			public static void FillDataTable(DataTable dt,IList objs,ColumnNameEnum cne)
			{
				if (dt == null)
				{
					throw new ArgumentNullException("dt");
				}
				if (objs == null)
				{
					throw new ArgumentNullException("objs");
				}
				
				foreach(OrderApply obj in objs)
				{
					DataRow dr = dt.NewRow();
					obj.FillDataRow(dr,cne);
					dt.Rows.Add(dr);
				}
			}

			/// <summary>
			/// 用objs的OrderApply对象集合填充DataTable(默认列名映射为属性名)
			/// </summary>
			/// <param name="dt">由CreateTable生成的DataTable</param>
			/// <param name="objs">OrderApply对象集合</param>
			public static void FillDataTable(DataTable dt,IList objs)
			{
				FillDataTable(dt,objs,ColumnNameEnum.PropertyName);
			}
		#endregion
		
		/// <summary>
		/// 取消编辑,恢复到上次有效调用BeginEdit前的状态,并清空保留值
		/// </summary>
		public override void CancelEdit()
		{
			OrderApply old = this.OldValue as OrderApply;
			if (old != null)
			{
					this.OrderApplyId = old.OrderApplyId;
					this.OrderNo = old.OrderNo;
					this.OrderTitle = old.OrderTitle;
					this.ResUserNo = old.ResUserNo;
					this.ReceiveName = old.ReceiveName;
					this.ReceivePhone = old.ReceivePhone;
					this.ReceiveTel = old.ReceiveTel;
					this.ReceiveEmail = old.ReceiveEmail;
					this.ReceiveAddress = old.ReceiveAddress;
					this.ReceiveAddress1 = old.ReceiveAddress1;
					this.MailMoney = old.MailMoney;
					this.ProductTMoney = old.ProductTMoney;
					this.OtherMoney = old.OtherMoney;
					this.TotalMoney = old.TotalMoney;
					this.OrderStatus = old.OrderStatus;
					this.ProductSeller = old.ProductSeller;
					this.Remark = old.Remark;
					this.CreateDate = old.CreateDate;
					this.LastUpdateDate = old.LastUpdateDate;
					this.PreferentialMoney = old.PreferentialMoney;
					this.City = old.City;
					this.State = old.State;
					this.Country = old.Country;
					this.Mypayment = old.Mypayment;
					this.Shipment = old.Shipment;
					this.Zip = old.Zip;				
				this.OldValue = null;
			}
		}
		
		
		
		
		#region OrderApply实体的内部Key类
			/// <summary>
			/// OrderApply实体的Key类
			/// </summary>
			public class Key
			{
		
				private int m_OrderApplyId;
				public int OrderApplyId
				{
 					get 
					{ 
						 return m_OrderApplyId; 
					}
					set 
					{ 
						m_OrderApplyId = value;
					}
				}
		
				public Key(int pOrderApplyId)
				{
					m_OrderApplyId=pOrderApplyId;

				}
			}
		#endregion
			/// <summary>
			/// 得到实体OrderApply的PK
			/// </summary>
			public Key GetKey()
			{
				return new Key(OrderApplyId);				
			}
	
		
		#endregion
	}
}
