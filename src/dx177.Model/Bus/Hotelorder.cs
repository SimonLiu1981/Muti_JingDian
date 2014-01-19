/*
版权所有：版权所有(C) 2011，刘建新
文件编号：M01_Hotelorder.cs
文件名称：Hotelorder.cs
系统编号：Z0003007
系统名称：通用办公系统
模块编号：M01
模块名称：信息发布
设计文档：IOA_M01信息发布XDE建模.mdx
完成日期：2011/4/11
作　　者：
内容摘要：表[HotelOrder]对应的实体类
*/

using System;
using System.Collections;
using System.Data;
using System.Collections.Generic;


namespace dx177.Model.Bus
{
		/// <summary>
		/// 类 编 号：
		/// 类 名 称：Hotelorder
		/// 内容摘要：
		/// </summary>
		
		[Serializable]
		public class Hotelorder : BaseModel
		{
		#region 自动生成代码
		
			#region 重载Equals/GetHashCode
			/// <summary>
			/// 重载Equals			
			/// </summary>
			public override bool Equals (Object obj)
			{
				if (obj != null && obj is Hotelorder)
				{
					if (obj == this)
						return true;
					Hotelorder castObj = (Hotelorder)obj; 
					
					if (!this.m_Seqno.Equals(castObj.Seqno))
						return false;
						
					if (!this.m_Guid.Equals(castObj.Guid))
						return false;
						
					if (!this.m_Orderno.Equals(castObj.Orderno))
						return false;
						
					if (!this.m_Personname.Equals(castObj.Personname))
						return false;
						
					if (!this.m_Personphone.Equals(castObj.Personphone))
						return false;
						
					if (!this.m_Orderusername.Equals(castObj.Orderusername))
						return false;
						
					if (!this.m_Orderuserphone.Equals(castObj.Orderuserphone))
						return false;
						
					if (!this.m_Email.Equals(castObj.Email))
						return false;
						
					if (!this.m_Pcount.Equals(castObj.Pcount))
						return false;
						
					if (!this.m_Begindate.Equals(castObj.Begindate))
						return false;
						
					if (!this.m_Enddate.Equals(castObj.Enddate))
						return false;
						
					if (!this.m_Reachdate.Equals(castObj.Reachdate))
						return false;
						
					if (!this.m_Hotelseqno.Equals(castObj.Hotelseqno))
						return false;
						
					if (!this.m_Hotelname.Equals(castObj.Hotelname))
						return false;
						
					if (!this.m_Roomtitle.Equals(castObj.Roomtitle))
						return false;
						
					if (!this.m_Roomseqno.Equals(castObj.Roomseqno))
						return false;
						
					if (!this.m_Roomcount.Equals(castObj.Roomcount))
						return false;
						
					if (!this.m_Price.Equals(castObj.Price))
						return false;
						
					if (!this.m_Referrall.Equals(castObj.Referrall))
						return false;
						
					if (!this.m_Totalmoney.Equals(castObj.Totalmoney))
						return false;
						
					if (!this.m_Creator.Equals(castObj.Creator))
						return false;
						
					if (!this.m_CreateDate.Equals(castObj.CreateDate))
						return false;
						
					if (!this.m_Ip.Equals(castObj.Ip))
						return false;
						
					if (!this.m_Content.Equals(castObj.Content))
						return false;
						
					if (!this.m_Status.Equals(castObj.Status))
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
					if ((object)m_Seqno != null)
					{
						hash = hash ^ m_Seqno.GetHashCode();
					}
						
					hash = hash <<  8;
					if ((object)m_Guid != null)
					{
						hash = hash ^ m_Guid.GetHashCode();
					}
						
					hash = hash <<  8;
					if ((object)m_Orderno != null)
					{
						hash = hash ^ m_Orderno.GetHashCode();
					}
						
					hash = hash <<  8;
					if ((object)m_Personname != null)
					{
						hash = hash ^ m_Personname.GetHashCode();
					}
						
					hash = hash <<  8;
					if ((object)m_Personphone != null)
					{
						hash = hash ^ m_Personphone.GetHashCode();
					}
						
					hash = hash <<  8;
					if ((object)m_Orderusername != null)
					{
						hash = hash ^ m_Orderusername.GetHashCode();
					}
						
					hash = hash <<  8;
					if ((object)m_Orderuserphone != null)
					{
						hash = hash ^ m_Orderuserphone.GetHashCode();
					}
						
					hash = hash <<  8;
					if ((object)m_Email != null)
					{
						hash = hash ^ m_Email.GetHashCode();
					}
						
					hash = hash <<  8;
					if ((object)m_Pcount != null)
					{
						hash = hash ^ m_Pcount.GetHashCode();
					}
						
					hash = hash <<  8;
					if ((object)m_Begindate != null)
					{
						hash = hash ^ m_Begindate.GetHashCode();
					}
						
					hash = hash <<  8;
					if ((object)m_Enddate != null)
					{
						hash = hash ^ m_Enddate.GetHashCode();
					}
						
					hash = hash <<  8;
					if ((object)m_Reachdate != null)
					{
						hash = hash ^ m_Reachdate.GetHashCode();
					}
						
					hash = hash <<  8;
					if ((object)m_Hotelseqno != null)
					{
						hash = hash ^ m_Hotelseqno.GetHashCode();
					}
						
					hash = hash <<  8;
					if ((object)m_Hotelname != null)
					{
						hash = hash ^ m_Hotelname.GetHashCode();
					}
						
					hash = hash <<  8;
					if ((object)m_Roomtitle != null)
					{
						hash = hash ^ m_Roomtitle.GetHashCode();
					}
						
					hash = hash <<  8;
					if ((object)m_Roomseqno != null)
					{
						hash = hash ^ m_Roomseqno.GetHashCode();
					}
						
					hash = hash <<  8;
					if ((object)m_Roomcount != null)
					{
						hash = hash ^ m_Roomcount.GetHashCode();
					}
						
					hash = hash <<  8;
					if ((object)m_Price != null)
					{
						hash = hash ^ m_Price.GetHashCode();
					}
						
					hash = hash <<  8;
					if ((object)m_Referrall != null)
					{
						hash = hash ^ m_Referrall.GetHashCode();
					}
						
					hash = hash <<  8;
					if ((object)m_Totalmoney != null)
					{
						hash = hash ^ m_Totalmoney.GetHashCode();
					}
						
					hash = hash <<  8;
					if ((object)m_Creator != null)
					{
						hash = hash ^ m_Creator.GetHashCode();
					}
						
					hash = hash <<  8;
					if ((object)m_CreateDate != null)
					{
						hash = hash ^ m_CreateDate.GetHashCode();
					}
						
					hash = hash <<  8;
					if ((object)m_Ip != null)
					{
						hash = hash ^ m_Ip.GetHashCode();
					}
						
					hash = hash <<  8;
					if ((object)m_Content != null)
					{
						hash = hash ^ m_Content.GetHashCode();
					}
						
					hash = hash <<  8;
					if ((object)m_Status != null)
					{
						hash = hash ^ m_Status.GetHashCode();
					}
						
					return hash; 
			}
			#endregion
			
			public Hotelorder()
			{
				MarkNew();
			}						
			
			public Hotelorder GetOldValue()
			{
				return OldValue as Hotelorder;
			}
		
		#region Seqno属性
			private int m_Seqno = 0;
			/// <summary>
			/// 属性名称： Seqno
			/// 内容摘要： DB列名：Seqno[名称]
			///            DB类型：int
			/// </summary>
			public int Seqno
			{
				get
					{
						return m_Seqno;
					}
				set
					{
						if (m_Seqno as object == null || !m_Seqno.Equals(value))
						{
							m_Seqno = value;
							MarkUpdated();
						}						
					}
			}
		#endregion
		
		#region Guid属性
			private string m_Guid = String.Empty;
			/// <summary>
			/// 属性名称： Guid
			/// 内容摘要： DB列名：GUID[GUID]
			///            DB类型：string
			/// </summary>
			public string Guid
			{
				get
					{
						return m_Guid;
					}
				set
					{
						if (m_Guid as object == null || !m_Guid.Equals(value))
						{
							m_Guid = value;
							MarkUpdated();
						}						
					}
			}
		#endregion
		
		#region Orderno属性
			private string m_Orderno = String.Empty;
			/// <summary>
			/// 属性名称： Orderno
			/// 内容摘要： DB列名：OrderNo[订单编号]
			///            DB类型：string
			/// </summary>
			public string Orderno
			{
				get
					{
						return m_Orderno;
					}
				set
					{
						if (m_Orderno as object == null || !m_Orderno.Equals(value))
						{
							m_Orderno = value;
							MarkUpdated();
						}						
					}
			}
		#endregion
		
		#region Personname属性
			private string m_Personname = String.Empty;
			/// <summary>
			/// 属性名称： Personname
			/// 内容摘要： DB列名：PersonName[入住人姓名]
			///            DB类型：string
			/// </summary>
			public string Personname
			{
				get
					{
						return m_Personname;
					}
				set
					{
						if (m_Personname as object == null || !m_Personname.Equals(value))
						{
							m_Personname = value;
							MarkUpdated();
						}						
					}
			}
		#endregion
		
		#region Personphone属性
			private string m_Personphone = String.Empty;
			/// <summary>
			/// 属性名称： Personphone
			/// 内容摘要： DB列名：PersonPhone[入住人手机]
			///            DB类型：string
			/// </summary>
			public string Personphone
			{
				get
					{
						return m_Personphone;
					}
				set
					{
						if (m_Personphone as object == null || !m_Personphone.Equals(value))
						{
							m_Personphone = value;
							MarkUpdated();
						}						
					}
			}
		#endregion
		
		#region Orderusername属性
			private string m_Orderusername = String.Empty;
			/// <summary>
			/// 属性名称： Orderusername
			/// 内容摘要： DB列名：OrderUserName[订单联系人姓名]
			///            DB类型：string
			/// </summary>
			public string Orderusername
			{
				get
					{
						return m_Orderusername;
					}
				set
					{
						if (m_Orderusername as object == null || !m_Orderusername.Equals(value))
						{
							m_Orderusername = value;
							MarkUpdated();
						}						
					}
			}
		#endregion
		
		#region Orderuserphone属性
			private string m_Orderuserphone = String.Empty;
			/// <summary>
			/// 属性名称： Orderuserphone
			/// 内容摘要： DB列名：OrderUserPhone[订单联系人手机]
			///            DB类型：string
			/// </summary>
			public string Orderuserphone
			{
				get
					{
						return m_Orderuserphone;
					}
				set
					{
						if (m_Orderuserphone as object == null || !m_Orderuserphone.Equals(value))
						{
							m_Orderuserphone = value;
							MarkUpdated();
						}						
					}
			}
		#endregion
		
		#region Email属性
			private string m_Email = String.Empty;
			/// <summary>
			/// 属性名称： Email
			/// 内容摘要： DB列名：Email[Email]
			///            DB类型：string
			/// </summary>
			public string Email
			{
				get
					{
						return m_Email;
					}
				set
					{
						if (m_Email as object == null || !m_Email.Equals(value))
						{
							m_Email = value;
							MarkUpdated();
						}						
					}
			}
		#endregion
		
		#region Pcount属性
			private int m_Pcount = 0;
			/// <summary>
			/// 属性名称： Pcount
			/// 内容摘要： DB列名：PCount[人数]
			///            DB类型：int
			/// </summary>
			public int Pcount
			{
				get
					{
						return m_Pcount;
					}
				set
					{
						if (m_Pcount as object == null || !m_Pcount.Equals(value))
						{
							m_Pcount = value;
							MarkUpdated();
						}						
					}
			}
		#endregion
		
		#region Begindate属性
			private DateTime m_Begindate = new DateTime(1900,1,1);
			/// <summary>
			/// 属性名称： Begindate
			/// 内容摘要： DB列名：BeginDate[开始时间]
			///            DB类型：DateTime
			/// </summary>
			public DateTime Begindate
			{
				get
					{
						return m_Begindate;
					}
				set
					{
						if (m_Begindate as object == null || !m_Begindate.Equals(value))
						{
							m_Begindate = value;
							MarkUpdated();
						}						
					}
			}
		#endregion
		
		#region Enddate属性
			private DateTime m_Enddate = new DateTime(1900,1,1);
			/// <summary>
			/// 属性名称： Enddate
			/// 内容摘要： DB列名：EndDate[离开时间]
			///            DB类型：DateTime
			/// </summary>
			public DateTime Enddate
			{
				get
					{
						return m_Enddate;
					}
				set
					{
						if (m_Enddate as object == null || !m_Enddate.Equals(value))
						{
							m_Enddate = value;
							MarkUpdated();
						}						
					}
			}
		#endregion
		
		#region Reachdate属性
			private string m_Reachdate = String.Empty;
			/// <summary>
			/// 属性名称： Reachdate
			/// 内容摘要： DB列名：ReachDate[到店时间]
			///            DB类型：string
			/// </summary>
			public string Reachdate
			{
				get
					{
						return m_Reachdate;
					}
				set
					{
						if (m_Reachdate as object == null || !m_Reachdate.Equals(value))
						{
							m_Reachdate = value;
							MarkUpdated();
						}						
					}
			}
		#endregion
		
		#region Hotelseqno属性
			private int m_Hotelseqno = 0;
			/// <summary>
			/// 属性名称： Hotelseqno
			/// 内容摘要： DB列名：HotelSeqno[酒店ID]
			///            DB类型：int
			/// </summary>
			public int Hotelseqno
			{
				get
					{
						return m_Hotelseqno;
					}
				set
					{
						if (m_Hotelseqno as object == null || !m_Hotelseqno.Equals(value))
						{
							m_Hotelseqno = value;
							MarkUpdated();
						}						
					}
			}
		#endregion
		
		#region Hotelname属性
			private string m_Hotelname = String.Empty;
			/// <summary>
			/// 属性名称： Hotelname
			/// 内容摘要： DB列名：HotelName[酒店名]
			///            DB类型：string
			/// </summary>
			public string Hotelname
			{
				get
					{
						return m_Hotelname;
					}
				set
					{
						if (m_Hotelname as object == null || !m_Hotelname.Equals(value))
						{
							m_Hotelname = value;
							MarkUpdated();
						}						
					}
			}
		#endregion
		
		#region Roomtitle属性
			private string m_Roomtitle = String.Empty;
			/// <summary>
			/// 属性名称： Roomtitle
			/// 内容摘要： DB列名：RoomTitle[房型名]
			///            DB类型：string
			/// </summary>
			public string Roomtitle
			{
				get
					{
						return m_Roomtitle;
					}
				set
					{
						if (m_Roomtitle as object == null || !m_Roomtitle.Equals(value))
						{
							m_Roomtitle = value;
							MarkUpdated();
						}						
					}
			}
		#endregion
		
		#region Roomseqno属性
			private int m_Roomseqno = 0;
			/// <summary>
			/// 属性名称： Roomseqno
			/// 内容摘要： DB列名：RoomSeqno[房间ID]
			///            DB类型：int
			/// </summary>
			public int Roomseqno
			{
				get
					{
						return m_Roomseqno;
					}
				set
					{
						if (m_Roomseqno as object == null || !m_Roomseqno.Equals(value))
						{
							m_Roomseqno = value;
							MarkUpdated();
						}						
					}
			}
		#endregion
		
		#region Roomcount属性
			private int m_Roomcount = 0;
			/// <summary>
			/// 属性名称： Roomcount
			/// 内容摘要： DB列名：RoomCount[房间数量]
			///            DB类型：int
			/// </summary>
			public int Roomcount
			{
				get
					{
						return m_Roomcount;
					}
				set
					{
						if (m_Roomcount as object == null || !m_Roomcount.Equals(value))
						{
							m_Roomcount = value;
							MarkUpdated();
						}						
					}
			}
		#endregion
		
		#region Price属性
			private double m_Price = 0;
			/// <summary>
			/// 属性名称： Price
			/// 内容摘要： DB列名：Price[价格]
			///            DB类型：double
			/// </summary>
			public double Price
			{
				get
					{
						return m_Price;
					}
				set
					{
						if (m_Price as object == null || !m_Price.Equals(value))
						{
							m_Price = value;
							MarkUpdated();
						}						
					}
			}
		#endregion
		
		#region Referrall属性
			private string m_Referrall = String.Empty;
			/// <summary>
			/// 属性名称： Referrall
			/// 内容摘要： DB列名：referrall[介绍人]
			///            DB类型：string
			/// </summary>
			public string Referrall
			{
				get
					{
						return m_Referrall;
					}
				set
					{
						if (m_Referrall as object == null || !m_Referrall.Equals(value))
						{
							m_Referrall = value;
							MarkUpdated();
						}						
					}
			}
		#endregion
		
		#region Totalmoney属性
			private double m_Totalmoney = 0;
			/// <summary>
			/// 属性名称： Totalmoney
			/// 内容摘要： DB列名：TotalMoney[总金额]
			///            DB类型：double
			/// </summary>
			public double Totalmoney
			{
				get
					{
						return m_Totalmoney;
					}
				set
					{
						if (m_Totalmoney as object == null || !m_Totalmoney.Equals(value))
						{
							m_Totalmoney = value;
							MarkUpdated();
						}						
					}
			}
		#endregion
		
		#region Creator属性
			private string m_Creator = String.Empty;
			/// <summary>
			/// 属性名称： Creator
			/// 内容摘要： DB列名：Creator[创建人]
			///            DB类型：string
			/// </summary>
			public string Creator
			{
				get
					{
						return m_Creator;
					}
				set
					{
						if (m_Creator as object == null || !m_Creator.Equals(value))
						{
							m_Creator = value;
							MarkUpdated();
						}						
					}
			}
		#endregion
		
		#region CreateDate属性
			private DateTime m_CreateDate = new DateTime(1900,1,1);
			/// <summary>
			/// 属性名称： CreateDate
			/// 内容摘要： DB列名：CREATE_DATE[创建时间]
			///            DB类型：DateTime
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
		
		#region Ip属性
			private string m_Ip = String.Empty;
			/// <summary>
			/// 属性名称： Ip
			/// 内容摘要： DB列名：Ip[请求IP]
			///            DB类型：string
			/// </summary>
			public string Ip
			{
				get
					{
						return m_Ip;
					}
				set
					{
						if (m_Ip as object == null || !m_Ip.Equals(value))
						{
							m_Ip = value;
							MarkUpdated();
						}						
					}
			}
		#endregion
		
		#region Content属性
			private string m_Content = String.Empty;
			/// <summary>
			/// 属性名称： Content
			/// 内容摘要： DB列名：Content[备注]
			///            DB类型：string
			/// </summary>
			public string Content
			{
				get
					{
						return m_Content;
					}
				set
					{
						if (m_Content as object == null || !m_Content.Equals(value))
						{
							m_Content = value;
							MarkUpdated();
						}						
					}
			}
		#endregion
		
		#region Status属性
			private int m_Status = 0;
			/// <summary>
			/// 属性名称： Status
			/// 内容摘要： DB列名：Status[是否付款]
			///            DB类型：int
			/// </summary>
			public int Status
			{
				get
					{
						return m_Status;
					}
				set
					{
						if (m_Status as object == null || !m_Status.Equals(value))
						{
							m_Status = value;
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
					dtResult.Columns.Add(new DataColumn("Seqno",typeof(int)));
					dtResult.Columns.Add(new DataColumn("GUID",typeof(string)));
					dtResult.Columns.Add(new DataColumn("OrderNo",typeof(string)));
					dtResult.Columns.Add(new DataColumn("PersonName",typeof(string)));
					dtResult.Columns.Add(new DataColumn("PersonPhone",typeof(string)));
					dtResult.Columns.Add(new DataColumn("OrderUserName",typeof(string)));
					dtResult.Columns.Add(new DataColumn("OrderUserPhone",typeof(string)));
					dtResult.Columns.Add(new DataColumn("Email",typeof(string)));
					dtResult.Columns.Add(new DataColumn("PCount",typeof(int)));
					dtResult.Columns.Add(new DataColumn("BeginDate",typeof(DateTime)));
					dtResult.Columns.Add(new DataColumn("EndDate",typeof(DateTime)));
					dtResult.Columns.Add(new DataColumn("ReachDate",typeof(string)));
					dtResult.Columns.Add(new DataColumn("HotelSeqno",typeof(int)));
					dtResult.Columns.Add(new DataColumn("HotelName",typeof(string)));
					dtResult.Columns.Add(new DataColumn("RoomTitle",typeof(string)));
					dtResult.Columns.Add(new DataColumn("RoomSeqno",typeof(int)));
					dtResult.Columns.Add(new DataColumn("RoomCount",typeof(int)));
					dtResult.Columns.Add(new DataColumn("Price",typeof(double)));
					dtResult.Columns.Add(new DataColumn("referrall",typeof(string)));
					dtResult.Columns.Add(new DataColumn("TotalMoney",typeof(double)));
					dtResult.Columns.Add(new DataColumn("Creator",typeof(string)));
					dtResult.Columns.Add(new DataColumn("CREATE_DATE",typeof(DateTime)));
					dtResult.Columns.Add(new DataColumn("Ip",typeof(string)));
					dtResult.Columns.Add(new DataColumn("Content",typeof(string)));
					dtResult.Columns.Add(new DataColumn("Status",typeof(int)));
				}
				else if (cne == ColumnNameEnum.PropertyName)
				{
					dtResult.Columns.Add(new DataColumn("Seqno",typeof(int)));
					dtResult.Columns.Add(new DataColumn("Guid",typeof(string)));
					dtResult.Columns.Add(new DataColumn("Orderno",typeof(string)));
					dtResult.Columns.Add(new DataColumn("Personname",typeof(string)));
					dtResult.Columns.Add(new DataColumn("Personphone",typeof(string)));
					dtResult.Columns.Add(new DataColumn("Orderusername",typeof(string)));
					dtResult.Columns.Add(new DataColumn("Orderuserphone",typeof(string)));
					dtResult.Columns.Add(new DataColumn("Email",typeof(string)));
					dtResult.Columns.Add(new DataColumn("Pcount",typeof(int)));
					dtResult.Columns.Add(new DataColumn("Begindate",typeof(DateTime)));
					dtResult.Columns.Add(new DataColumn("Enddate",typeof(DateTime)));
					dtResult.Columns.Add(new DataColumn("Reachdate",typeof(string)));
					dtResult.Columns.Add(new DataColumn("Hotelseqno",typeof(int)));
					dtResult.Columns.Add(new DataColumn("Hotelname",typeof(string)));
					dtResult.Columns.Add(new DataColumn("Roomtitle",typeof(string)));
					dtResult.Columns.Add(new DataColumn("Roomseqno",typeof(int)));
					dtResult.Columns.Add(new DataColumn("Roomcount",typeof(int)));
					dtResult.Columns.Add(new DataColumn("Price",typeof(double)));
					dtResult.Columns.Add(new DataColumn("Referrall",typeof(string)));
					dtResult.Columns.Add(new DataColumn("Totalmoney",typeof(double)));
					dtResult.Columns.Add(new DataColumn("Creator",typeof(string)));
					dtResult.Columns.Add(new DataColumn("CreateDate",typeof(DateTime)));
					dtResult.Columns.Add(new DataColumn("Ip",typeof(string)));
					dtResult.Columns.Add(new DataColumn("Content",typeof(string)));
					dtResult.Columns.Add(new DataColumn("Status",typeof(int)));
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
					dr["Seqno"] = this.Seqno;
					dr["GUID"] = this.Guid;
					dr["OrderNo"] = this.Orderno;
					dr["PersonName"] = this.Personname;
					dr["PersonPhone"] = this.Personphone;
					dr["OrderUserName"] = this.Orderusername;
					dr["OrderUserPhone"] = this.Orderuserphone;
					dr["Email"] = this.Email;
					dr["PCount"] = this.Pcount;
					dr["BeginDate"] = this.Begindate;
					dr["EndDate"] = this.Enddate;
					dr["ReachDate"] = this.Reachdate;
					dr["HotelSeqno"] = this.Hotelseqno;
					dr["HotelName"] = this.Hotelname;
					dr["RoomTitle"] = this.Roomtitle;
					dr["RoomSeqno"] = this.Roomseqno;
					dr["RoomCount"] = this.Roomcount;
					dr["Price"] = this.Price;
					dr["referrall"] = this.Referrall;
					dr["TotalMoney"] = this.Totalmoney;
					dr["Creator"] = this.Creator;
					dr["CREATE_DATE"] = this.CreateDate;
					dr["Ip"] = this.Ip;
					dr["Content"] = this.Content;
					dr["Status"] = this.Status;
				}
				else if (ColumnNameEnum.PropertyName == cne)
				{
					dr["Seqno"] = this.Seqno;
					dr["Guid"] = this.Guid;
					dr["Orderno"] = this.Orderno;
					dr["Personname"] = this.Personname;
					dr["Personphone"] = this.Personphone;
					dr["Orderusername"] = this.Orderusername;
					dr["Orderuserphone"] = this.Orderuserphone;
					dr["Email"] = this.Email;
					dr["Pcount"] = this.Pcount;
					dr["Begindate"] = this.Begindate;
					dr["Enddate"] = this.Enddate;
					dr["Reachdate"] = this.Reachdate;
					dr["Hotelseqno"] = this.Hotelseqno;
					dr["Hotelname"] = this.Hotelname;
					dr["Roomtitle"] = this.Roomtitle;
					dr["Roomseqno"] = this.Roomseqno;
					dr["Roomcount"] = this.Roomcount;
					dr["Price"] = this.Price;
					dr["Referrall"] = this.Referrall;
					dr["Totalmoney"] = this.Totalmoney;
					dr["Creator"] = this.Creator;
					dr["CreateDate"] = this.CreateDate;
					dr["Ip"] = this.Ip;
					dr["Content"] = this.Content;
					dr["Status"] = this.Status;					
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
			/// 将DataRow转换成Hotelorder对象
			/// </summary>
			/// <param name="dr">由CreateTable生成的DataTable通过NewRow得到的DataRow对象</param>
			/// <param name="cne">dr的列名映射方式:DB列名或属性名</param>
			/// <returns>Hotelorder对象</returns>
			public static Hotelorder Dr2Obj(DataRow dr,ColumnNameEnum cne)
			{
				if (dr == null)
				{
					throw new ArgumentNullException("dr");
				}
				Hotelorder obj = new Hotelorder();
				if (ColumnNameEnum.DBName == cne)
				{
					obj.Seqno = (dr["Seqno"] == Convert.DBNull) ? 0  : (int)Convert.ChangeType(dr["Seqno"],typeof(int));
					obj.Guid = (dr["GUID"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["GUID"],typeof(string));
					obj.Orderno = (dr["OrderNo"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["OrderNo"],typeof(string));
					obj.Personname = (dr["PersonName"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["PersonName"],typeof(string));
					obj.Personphone = (dr["PersonPhone"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["PersonPhone"],typeof(string));
					obj.Orderusername = (dr["OrderUserName"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["OrderUserName"],typeof(string));
					obj.Orderuserphone = (dr["OrderUserPhone"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["OrderUserPhone"],typeof(string));
					obj.Email = (dr["Email"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Email"],typeof(string));
					obj.Pcount = (dr["PCount"] == Convert.DBNull) ? 0  : (int)Convert.ChangeType(dr["PCount"],typeof(int));
					obj.Begindate = (dr["BeginDate"] == Convert.DBNull) ? new DateTime(1900,1,1)  : (DateTime)Convert.ChangeType(dr["BeginDate"],typeof(DateTime));
					obj.Enddate = (dr["EndDate"] == Convert.DBNull) ? new DateTime(1900,1,1)  : (DateTime)Convert.ChangeType(dr["EndDate"],typeof(DateTime));
					obj.Reachdate = (dr["ReachDate"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["ReachDate"],typeof(string));
					obj.Hotelseqno = (dr["HotelSeqno"] == Convert.DBNull) ? 0  : (int)Convert.ChangeType(dr["HotelSeqno"],typeof(int));
					obj.Hotelname = (dr["HotelName"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["HotelName"],typeof(string));
					obj.Roomtitle = (dr["RoomTitle"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["RoomTitle"],typeof(string));
					obj.Roomseqno = (dr["RoomSeqno"] == Convert.DBNull) ? 0  : (int)Convert.ChangeType(dr["RoomSeqno"],typeof(int));
					obj.Roomcount = (dr["RoomCount"] == Convert.DBNull) ? 0  : (int)Convert.ChangeType(dr["RoomCount"],typeof(int));
					obj.Price = (dr["Price"] == Convert.DBNull) ? 0  : (double)Convert.ChangeType(dr["Price"],typeof(double));
					obj.Referrall = (dr["referrall"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["referrall"],typeof(string));
					obj.Totalmoney = (dr["TotalMoney"] == Convert.DBNull) ? 0  : (double)Convert.ChangeType(dr["TotalMoney"],typeof(double));
					obj.Creator = (dr["Creator"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Creator"],typeof(string));
					obj.CreateDate = (dr["CREATE_DATE"] == Convert.DBNull) ? new DateTime(1900,1,1)  : (DateTime)Convert.ChangeType(dr["CREATE_DATE"],typeof(DateTime));
					obj.Ip = (dr["Ip"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Ip"],typeof(string));
					obj.Content = (dr["Content"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Content"],typeof(string));
					obj.Status = (dr["Status"] == Convert.DBNull) ? 0  : (int)Convert.ChangeType(dr["Status"],typeof(int));
				}
				else if (ColumnNameEnum.PropertyName == cne)
				{
					obj.Seqno = (dr["Seqno"] == Convert.DBNull) ? 0  : (int)Convert.ChangeType(dr["Seqno"],typeof(int));
					obj.Guid = (dr["Guid"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Guid"],typeof(string));
					obj.Orderno = (dr["Orderno"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Orderno"],typeof(string));
					obj.Personname = (dr["Personname"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Personname"],typeof(string));
					obj.Personphone = (dr["Personphone"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Personphone"],typeof(string));
					obj.Orderusername = (dr["Orderusername"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Orderusername"],typeof(string));
					obj.Orderuserphone = (dr["Orderuserphone"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Orderuserphone"],typeof(string));
					obj.Email = (dr["Email"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Email"],typeof(string));
					obj.Pcount = (dr["Pcount"] == Convert.DBNull) ? 0  : (int)Convert.ChangeType(dr["Pcount"],typeof(int));
					obj.Begindate = (dr["Begindate"] == Convert.DBNull) ? new DateTime(1900,1,1)  : (DateTime)Convert.ChangeType(dr["Begindate"],typeof(DateTime));
					obj.Enddate = (dr["Enddate"] == Convert.DBNull) ? new DateTime(1900,1,1)  : (DateTime)Convert.ChangeType(dr["Enddate"],typeof(DateTime));
					obj.Reachdate = (dr["Reachdate"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Reachdate"],typeof(string));
					obj.Hotelseqno = (dr["Hotelseqno"] == Convert.DBNull) ? 0  : (int)Convert.ChangeType(dr["Hotelseqno"],typeof(int));
					obj.Hotelname = (dr["Hotelname"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Hotelname"],typeof(string));
					obj.Roomtitle = (dr["Roomtitle"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Roomtitle"],typeof(string));
					obj.Roomseqno = (dr["Roomseqno"] == Convert.DBNull) ? 0  : (int)Convert.ChangeType(dr["Roomseqno"],typeof(int));
					obj.Roomcount = (dr["Roomcount"] == Convert.DBNull) ? 0  : (int)Convert.ChangeType(dr["Roomcount"],typeof(int));
					obj.Price = (dr["Price"] == Convert.DBNull) ? 0  : (double)Convert.ChangeType(dr["Price"],typeof(double));
					obj.Referrall = (dr["Referrall"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Referrall"],typeof(string));
					obj.Totalmoney = (dr["Totalmoney"] == Convert.DBNull) ? 0  : (double)Convert.ChangeType(dr["Totalmoney"],typeof(double));
					obj.Creator = (dr["Creator"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Creator"],typeof(string));
					obj.CreateDate = (dr["CreateDate"] == Convert.DBNull) ? new DateTime(1900,1,1)  : (DateTime)Convert.ChangeType(dr["CreateDate"],typeof(DateTime));
					obj.Ip = (dr["Ip"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Ip"],typeof(string));
					obj.Content = (dr["Content"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Content"],typeof(string));
					obj.Status = (dr["Status"] == Convert.DBNull) ? 0  : (int)Convert.ChangeType(dr["Status"],typeof(int));		
				}
				
				return obj;
			}
			
			/// <summary>
			/// 将DataRow转换成Hotelorder对象(默认列名映射为属性名)
			/// </summary>
			/// <returns>Hotelorder对象</returns>
			public static Hotelorder Dr2Obj(DataRow dr)
			{
				return Dr2Obj(dr,ColumnNameEnum.DBName);
			}
			
			/// <summary>
			/// 将DataTabe转换成的Hotelorder对象集合
			/// </summary>
			/// <param name="dt">由CreateTable生成的DataTable</param>
			/// <param name="cne">dt的列名映射方式:DB列名或属性名</param>
			/// <returns>Hotelorder对象的集合</returns>
			public static List<Hotelorder> Dt2Objs(DataTable dt,ColumnNameEnum cne)
			{
				if (dt == null)
				{
					throw new ArgumentNullException("dt");
				}
				
				List<Hotelorder> alResult = new List<Hotelorder>();
				
				foreach(DataRow dr in dt.Rows)
				{
					alResult.Add(Dr2Obj(dr,cne));
				}
				
				return alResult;
			}

			/// <summary>
			/// 将DataTabe转换成的Hotelorder对象集合(默认列名映射为属性名)
			/// </summary>
			/// <param name="dt">由CreateTable生成的DataTable</param>
			/// <returns>Hotelorder对象的集合</returns>
			public static  List<Hotelorder> Dt2Objs(DataTable dt)
			{
				return Dt2Objs(dt, ColumnNameEnum.DBName);
			}
			
			/// <summary>
			/// 用objs的Hotelorder对象集合填充DataTable
			/// </summary>
			/// <param name="dt">由CreateTable生成的DataTable</param>
			/// <param name="objs">Hotelorder对象集合</param>
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
				
				foreach(Hotelorder obj in objs)
				{
					DataRow dr = dt.NewRow();
					obj.FillDataRow(dr,cne);
					dt.Rows.Add(dr);
				}
			}

			/// <summary>
			/// 用objs的Hotelorder对象集合填充DataTable(默认列名映射为属性名)
			/// </summary>
			/// <param name="dt">由CreateTable生成的DataTable</param>
			/// <param name="objs">Hotelorder对象集合</param>
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
			Hotelorder old = this.OldValue as Hotelorder;
			if (old != null)
			{
					this.Seqno = old.Seqno;
					this.Guid = old.Guid;
					this.Orderno = old.Orderno;
					this.Personname = old.Personname;
					this.Personphone = old.Personphone;
					this.Orderusername = old.Orderusername;
					this.Orderuserphone = old.Orderuserphone;
					this.Email = old.Email;
					this.Pcount = old.Pcount;
					this.Begindate = old.Begindate;
					this.Enddate = old.Enddate;
					this.Reachdate = old.Reachdate;
					this.Hotelseqno = old.Hotelseqno;
					this.Hotelname = old.Hotelname;
					this.Roomtitle = old.Roomtitle;
					this.Roomseqno = old.Roomseqno;
					this.Roomcount = old.Roomcount;
					this.Price = old.Price;
					this.Referrall = old.Referrall;
					this.Totalmoney = old.Totalmoney;
					this.Creator = old.Creator;
					this.CreateDate = old.CreateDate;
					this.Ip = old.Ip;
					this.Content = old.Content;
					this.Status = old.Status;				
				this.OldValue = null;
			}
		}
		
		
		
		
		#region Hotelorder实体的内部Key类
			/// <summary>
			/// Hotelorder实体的Key类
			/// </summary>
			public sealed class Key
			{
		
				private int m_Seqno;
				public int Seqno
				{
 					get 
					{ 
						 return m_Seqno; 
					}
					set 
					{ 
						m_Seqno = value;
					}
				}
		
				public Key(int pSeqno)
				{
					m_Seqno=pSeqno;

				}
			}
		#endregion
			/// <summary>
			/// 得到实体Hotelorder的PK
			/// </summary>
			public Key GetKey()
			{
				return new Key(Seqno);				
			}
			
				
		#endregion
	}
}
