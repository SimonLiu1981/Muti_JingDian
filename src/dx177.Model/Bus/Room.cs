/*
版权所有：版权所有(C) 2011，刘建新
文件编号：M01_Room.cs
文件名称：Room.cs
系统编号：Z0003007
系统名称：通用办公系统
模块编号：M01
模块名称：信息发布
设计文档：IOA_M01信息发布XDE建模.mdx
完成日期：2011/3/24
作　　者：
内容摘要：表[Room]对应的实体类
*/

using System;
using System.Collections;
using System.Data;
using System.Collections.Generic;


namespace dx177.Model.Bus
{
		/// <summary>
		/// 类 编 号：
		/// 类 名 称：Room
		/// 内容摘要：
		/// </summary>
		
		[Serializable]
		public class Room : BaseModel
		{
		#region 自动生成代码
		
			#region 重载Equals/GetHashCode
			/// <summary>
			/// 重载Equals			
			/// </summary>
			public override bool Equals (Object obj)
			{
				if (obj != null && obj is Room)
				{
					if (obj == this)
						return true;
					Room castObj = (Room)obj; 
					
					if (!this.m_Seqno.Equals(castObj.Seqno))
						return false;
						
					if (!this.m_Guid.Equals(castObj.Guid))
						return false;
						
					if (!this.m_Pguid.Equals(castObj.Pguid))
						return false;
						
					if (!this.m_Roomtitle.Equals(castObj.Roomtitle))
						return false;
						
					if (!this.m_Shortdescr.Equals(castObj.Shortdescr))
						return false;
						
					if (!this.m_Descr.Equals(castObj.Descr))
						return false;
						
					if (!this.m_Marketprice.Equals(castObj.Marketprice))
						return false;
						
					if (!this.m_Price1.Equals(castObj.Price1))
						return false;
						
					if (!this.m_Price2.Equals(castObj.Price2))
						return false;
						
					if (!this.m_Installations.Equals(castObj.Installations))
						return false;
						
					if (!this.m_Logo.Equals(castObj.Logo))
						return false;
						
					if (!this.m_LasteUpdateBy.Equals(castObj.LasteUpdateBy))
						return false;
						
					if (!this.m_Creator.Equals(castObj.Creator))
						return false;
						
					if (!this.m_CreateDate.Equals(castObj.CreateDate))
						return false;
						
					if (!this.m_LasteUpdateDate.Equals(castObj.LasteUpdateDate))
						return false;
						
					if (!this.m_Square.Equals(castObj.Square))
						return false;
						
					if (!this.m_Breakfast.Equals(castObj.Breakfast))
						return false;
						
					if (!this.m_Broadband.Equals(castObj.Broadband))
						return false;
						
					if (!this.m_Present.Equals(castObj.Present))
						return false;
						
					if (!this.m_Showpr.Equals(castObj.Showpr))
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
					if ((object)m_Pguid != null)
					{
						hash = hash ^ m_Pguid.GetHashCode();
					}
						
					hash = hash <<  8;
					if ((object)m_Roomtitle != null)
					{
						hash = hash ^ m_Roomtitle.GetHashCode();
					}
						
					hash = hash <<  8;
					if ((object)m_Shortdescr != null)
					{
						hash = hash ^ m_Shortdescr.GetHashCode();
					}
						
					hash = hash <<  8;
					if ((object)m_Descr != null)
					{
						hash = hash ^ m_Descr.GetHashCode();
					}
						
					hash = hash <<  8;
					if ((object)m_Marketprice != null)
					{
						hash = hash ^ m_Marketprice.GetHashCode();
					}
						
					hash = hash <<  8;
					if ((object)m_Price1 != null)
					{
						hash = hash ^ m_Price1.GetHashCode();
					}
						
					hash = hash <<  8;
					if ((object)m_Price2 != null)
					{
						hash = hash ^ m_Price2.GetHashCode();
					}
						
					hash = hash <<  8;
					if ((object)m_Installations != null)
					{
						hash = hash ^ m_Installations.GetHashCode();
					}
						
					hash = hash <<  8;
					if ((object)m_Logo != null)
					{
						hash = hash ^ m_Logo.GetHashCode();
					}
						
					hash = hash <<  8;
					if ((object)m_LasteUpdateBy != null)
					{
						hash = hash ^ m_LasteUpdateBy.GetHashCode();
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
					if ((object)m_LasteUpdateDate != null)
					{
						hash = hash ^ m_LasteUpdateDate.GetHashCode();
					}
						
					hash = hash <<  8;
					if ((object)m_Square != null)
					{
						hash = hash ^ m_Square.GetHashCode();
					}
						
					hash = hash <<  8;
					if ((object)m_Breakfast != null)
					{
						hash = hash ^ m_Breakfast.GetHashCode();
					}
						
					hash = hash <<  8;
					if ((object)m_Broadband != null)
					{
						hash = hash ^ m_Broadband.GetHashCode();
					}
						
					hash = hash <<  8;
					if ((object)m_Present != null)
					{
						hash = hash ^ m_Present.GetHashCode();
					}
						
					hash = hash <<  8;
					if ((object)m_Showpr != null)
					{
						hash = hash ^ m_Showpr.GetHashCode();
					}
						
					return hash; 
			}
			#endregion
			
			public Room()
			{
				MarkNew();
			}						
			
			public Room GetOldValue()
			{
				return OldValue as Room;
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
			/// 内容摘要： DB列名：GUID[]
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
		
		#region Pguid属性
			private string m_Pguid = String.Empty;
			/// <summary>
			/// 属性名称： Pguid
			/// 内容摘要： DB列名：PGUID[酒店GUID]
			///            DB类型：string
			/// </summary>
			public string Pguid
			{
				get
					{
						return m_Pguid;
					}
				set
					{
						if (m_Pguid as object == null || !m_Pguid.Equals(value))
						{
							m_Pguid = value;
							MarkUpdated();
						}						
					}
			}
		#endregion
		
		#region Roomtitle属性
			private string m_Roomtitle = String.Empty;
			/// <summary>
			/// 属性名称： Roomtitle
			/// 内容摘要： DB列名：RoomTitle[房间名称]
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
		
		#region Shortdescr属性
			private string m_Shortdescr = String.Empty;
			/// <summary>
			/// 属性名称： Shortdescr
			/// 内容摘要： DB列名：ShortDescr[简述]
			///            DB类型：string
			/// </summary>
			public string Shortdescr
			{
				get
					{
						return m_Shortdescr;
					}
				set
					{
						if (m_Shortdescr as object == null || !m_Shortdescr.Equals(value))
						{
							m_Shortdescr = value;
							MarkUpdated();
						}						
					}
			}
		#endregion
		
		#region Descr属性
			private string m_Descr = String.Empty;
			/// <summary>
			/// 属性名称： Descr
			/// 内容摘要： DB列名：Descr[描述]
			///            DB类型：string
			/// </summary>
			public string Descr
			{
				get
					{
						return m_Descr;
					}
				set
					{
						if (m_Descr as object == null || !m_Descr.Equals(value))
						{
							m_Descr = value;
							MarkUpdated();
						}						
					}
			}
		#endregion
		
		#region Marketprice属性
			private double m_Marketprice = 0;
			/// <summary>
			/// 属性名称： Marketprice
			/// 内容摘要： DB列名：MarketPrice[门面价]
			///            DB类型：double
			/// </summary>
			public double Marketprice
			{
				get
					{
						return m_Marketprice;
					}
				set
					{
						if (m_Marketprice as object == null || !m_Marketprice.Equals(value))
						{
							m_Marketprice = value;
							MarkUpdated();
						}						
					}
			}
		#endregion
		
		#region Price1属性
			private double m_Price1 = 0;
			/// <summary>
			/// 属性名称： Price1
			/// 内容摘要： DB列名：Price1[平常价]
			///            DB类型：double
			/// </summary>
			public double Price1
			{
				get
					{
						return m_Price1;
					}
				set
					{
						if (m_Price1 as object == null || !m_Price1.Equals(value))
						{
							m_Price1 = value;
							MarkUpdated();
						}						
					}
			}
		#endregion
		
		#region Price2属性
			private double m_Price2 = 0;
			/// <summary>
			/// 属性名称： Price2
			/// 内容摘要： DB列名：Price2[节假日]
			///            DB类型：double
			/// </summary>
			public double Price2
			{
				get
					{
						return m_Price2;
					}
				set
					{
						if (m_Price2 as object == null || !m_Price2.Equals(value))
						{
							m_Price2 = value;
							MarkUpdated();
						}						
					}
			}
		#endregion
		
		#region Installations属性
			private string m_Installations = String.Empty;
			/// <summary>
			/// 属性名称： Installations
			/// 内容摘要： DB列名：installations[设施]
			///            DB类型：string
			/// </summary>
			public string Installations
			{
				get
					{
						return m_Installations;
					}
				set
					{
						if (m_Installations as object == null || !m_Installations.Equals(value))
						{
							m_Installations = value;
							MarkUpdated();
						}						
					}
			}
		#endregion
		
		#region Logo属性
			private string m_Logo = String.Empty;
			/// <summary>
			/// 属性名称： Logo
			/// 内容摘要： DB列名：Logo[]
			///            DB类型：string
			/// </summary>
			public string Logo
			{
				get
					{
						return m_Logo;
					}
				set
					{
						if (m_Logo as object == null || !m_Logo.Equals(value))
						{
							m_Logo = value;
							MarkUpdated();
						}						
					}
			}
		#endregion
		
		#region LasteUpdateBy属性
			private string m_LasteUpdateBy = String.Empty;
			/// <summary>
			/// 属性名称： LasteUpdateBy
			/// 内容摘要： DB列名：Laste_update_By[最后更新人]
			///            DB类型：string
			/// </summary>
			public string LasteUpdateBy
			{
				get
					{
						return m_LasteUpdateBy;
					}
				set
					{
						if (m_LasteUpdateBy as object == null || !m_LasteUpdateBy.Equals(value))
						{
							m_LasteUpdateBy = value;
							MarkUpdated();
						}						
					}
			}
		#endregion
		
		#region Creator属性
			private string m_Creator = String.Empty;
			/// <summary>
			/// 属性名称： Creator
			/// 内容摘要： DB列名：CREATOR[创建人]
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
		
		#region LasteUpdateDate属性
			private DateTime m_LasteUpdateDate = new DateTime(1900,1,1);
			/// <summary>
			/// 属性名称： LasteUpdateDate
			/// 内容摘要： DB列名：Laste_update_date[最后更新时间]
			///            DB类型：DateTime
			/// </summary>
			public DateTime LasteUpdateDate
			{
				get
					{
						return m_LasteUpdateDate;
					}
				set
					{
						if (m_LasteUpdateDate as object == null || !m_LasteUpdateDate.Equals(value))
						{
							m_LasteUpdateDate = value;
							MarkUpdated();
						}						
					}
			}
		#endregion
		
		#region Square属性
			private double m_Square = 0;
			/// <summary>
			/// 属性名称： Square
			/// 内容摘要： DB列名：Square[面积]
			///            DB类型：double
			/// </summary>
			public double Square
			{
				get
					{
						return m_Square;
					}
				set
					{
						if (m_Square as object == null || !m_Square.Equals(value))
						{
							m_Square = value;
							MarkUpdated();
						}						
					}
			}
		#endregion
		
		#region Breakfast属性
			private string m_Breakfast = String.Empty;
			/// <summary>
			/// 属性名称： Breakfast
			/// 内容摘要： DB列名：Breakfast[早餐]
			///            DB类型：string
			/// </summary>
			public string Breakfast
			{
				get
					{
						return m_Breakfast;
					}
				set
					{
						if (m_Breakfast as object == null || !m_Breakfast.Equals(value))
						{
							m_Breakfast = value;
							MarkUpdated();
						}						
					}
			}
		#endregion
		
		#region Broadband属性
			private string m_Broadband = String.Empty;
			/// <summary>
			/// 属性名称： Broadband
			/// 内容摘要： DB列名：Broadband[宽带]
			///            DB类型：string
			/// </summary>
			public string Broadband
			{
				get
					{
						return m_Broadband;
					}
				set
					{
						if (m_Broadband as object == null || !m_Broadband.Equals(value))
						{
							m_Broadband = value;
							MarkUpdated();
						}						
					}
			}
		#endregion
		
		#region Present属性
			private double m_Present = 0;
			/// <summary>
			/// 属性名称： Present
			/// 内容摘要： DB列名：Present[回赠]
			///            DB类型：double
			/// </summary>
			public double Present
			{
				get
					{
						return m_Present;
					}
				set
					{
						if (m_Present as object == null || !m_Present.Equals(value))
						{
							m_Present = value;
							MarkUpdated();
						}						
					}
			}
		#endregion
		
		#region Showpr属性
			private int m_Showpr = 0;
			/// <summary>
			/// 属性名称： Showpr
			/// 内容摘要： DB列名：ShowPr[]
			///            DB类型：int
			/// </summary>
			public int Showpr
			{
				get
					{
						return m_Showpr;
					}
				set
					{
						if (m_Showpr as object == null || !m_Showpr.Equals(value))
						{
							m_Showpr = value;
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
					dtResult.Columns.Add(new DataColumn("PGUID",typeof(string)));
					dtResult.Columns.Add(new DataColumn("RoomTitle",typeof(string)));
					dtResult.Columns.Add(new DataColumn("ShortDescr",typeof(string)));
					dtResult.Columns.Add(new DataColumn("Descr",typeof(string)));
					dtResult.Columns.Add(new DataColumn("MarketPrice",typeof(double)));
					dtResult.Columns.Add(new DataColumn("Price1",typeof(double)));
					dtResult.Columns.Add(new DataColumn("Price2",typeof(double)));
					dtResult.Columns.Add(new DataColumn("installations",typeof(string)));
					dtResult.Columns.Add(new DataColumn("Logo",typeof(string)));
					dtResult.Columns.Add(new DataColumn("Laste_update_By",typeof(string)));
					dtResult.Columns.Add(new DataColumn("CREATOR",typeof(string)));
					dtResult.Columns.Add(new DataColumn("CREATE_DATE",typeof(DateTime)));
					dtResult.Columns.Add(new DataColumn("Laste_update_date",typeof(DateTime)));
					dtResult.Columns.Add(new DataColumn("Square",typeof(double)));
					dtResult.Columns.Add(new DataColumn("Breakfast",typeof(string)));
					dtResult.Columns.Add(new DataColumn("Broadband",typeof(string)));
					dtResult.Columns.Add(new DataColumn("Present",typeof(double)));
					dtResult.Columns.Add(new DataColumn("ShowPr",typeof(int)));
				}
				else if (cne == ColumnNameEnum.PropertyName)
				{
					dtResult.Columns.Add(new DataColumn("Seqno",typeof(int)));
					dtResult.Columns.Add(new DataColumn("Guid",typeof(string)));
					dtResult.Columns.Add(new DataColumn("Pguid",typeof(string)));
					dtResult.Columns.Add(new DataColumn("Roomtitle",typeof(string)));
					dtResult.Columns.Add(new DataColumn("Shortdescr",typeof(string)));
					dtResult.Columns.Add(new DataColumn("Descr",typeof(string)));
					dtResult.Columns.Add(new DataColumn("Marketprice",typeof(double)));
					dtResult.Columns.Add(new DataColumn("Price1",typeof(double)));
					dtResult.Columns.Add(new DataColumn("Price2",typeof(double)));
					dtResult.Columns.Add(new DataColumn("Installations",typeof(string)));
					dtResult.Columns.Add(new DataColumn("Logo",typeof(string)));
					dtResult.Columns.Add(new DataColumn("LasteUpdateBy",typeof(string)));
					dtResult.Columns.Add(new DataColumn("Creator",typeof(string)));
					dtResult.Columns.Add(new DataColumn("CreateDate",typeof(DateTime)));
					dtResult.Columns.Add(new DataColumn("LasteUpdateDate",typeof(DateTime)));
					dtResult.Columns.Add(new DataColumn("Square",typeof(double)));
					dtResult.Columns.Add(new DataColumn("Breakfast",typeof(string)));
					dtResult.Columns.Add(new DataColumn("Broadband",typeof(string)));
					dtResult.Columns.Add(new DataColumn("Present",typeof(double)));
					dtResult.Columns.Add(new DataColumn("Showpr",typeof(int)));
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
					dr["PGUID"] = this.Pguid;
					dr["RoomTitle"] = this.Roomtitle;
					dr["ShortDescr"] = this.Shortdescr;
					dr["Descr"] = this.Descr;
					dr["MarketPrice"] = this.Marketprice;
					dr["Price1"] = this.Price1;
					dr["Price2"] = this.Price2;
					dr["installations"] = this.Installations;
					dr["Logo"] = this.Logo;
					dr["Laste_update_By"] = this.LasteUpdateBy;
					dr["CREATOR"] = this.Creator;
					dr["CREATE_DATE"] = this.CreateDate;
					dr["Laste_update_date"] = this.LasteUpdateDate;
					dr["Square"] = this.Square;
					dr["Breakfast"] = this.Breakfast;
					dr["Broadband"] = this.Broadband;
					dr["Present"] = this.Present;
					dr["ShowPr"] = this.Showpr;
				}
				else if (ColumnNameEnum.PropertyName == cne)
				{
					dr["Seqno"] = this.Seqno;
					dr["Guid"] = this.Guid;
					dr["Pguid"] = this.Pguid;
					dr["Roomtitle"] = this.Roomtitle;
					dr["Shortdescr"] = this.Shortdescr;
					dr["Descr"] = this.Descr;
					dr["Marketprice"] = this.Marketprice;
					dr["Price1"] = this.Price1;
					dr["Price2"] = this.Price2;
					dr["Installations"] = this.Installations;
					dr["Logo"] = this.Logo;
					dr["LasteUpdateBy"] = this.LasteUpdateBy;
					dr["Creator"] = this.Creator;
					dr["CreateDate"] = this.CreateDate;
					dr["LasteUpdateDate"] = this.LasteUpdateDate;
					dr["Square"] = this.Square;
					dr["Breakfast"] = this.Breakfast;
					dr["Broadband"] = this.Broadband;
					dr["Present"] = this.Present;
					dr["Showpr"] = this.Showpr;					
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
			/// 将DataRow转换成Room对象
			/// </summary>
			/// <param name="dr">由CreateTable生成的DataTable通过NewRow得到的DataRow对象</param>
			/// <param name="cne">dr的列名映射方式:DB列名或属性名</param>
			/// <returns>Room对象</returns>
			public static Room Dr2Obj(DataRow dr,ColumnNameEnum cne)
			{
				if (dr == null)
				{
					throw new ArgumentNullException("dr");
				}
				Room obj = new Room();
				if (ColumnNameEnum.DBName == cne)
				{
					obj.Seqno = (dr["Seqno"] == Convert.DBNull) ? 0  : (int)Convert.ChangeType(dr["Seqno"],typeof(int));
					obj.Guid = (dr["GUID"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["GUID"],typeof(string));
					obj.Pguid = (dr["PGUID"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["PGUID"],typeof(string));
					obj.Roomtitle = (dr["RoomTitle"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["RoomTitle"],typeof(string));
					obj.Shortdescr = (dr["ShortDescr"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["ShortDescr"],typeof(string));
					obj.Descr = (dr["Descr"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Descr"],typeof(string));
					obj.Marketprice = (dr["MarketPrice"] == Convert.DBNull) ? 0  : (double)Convert.ChangeType(dr["MarketPrice"],typeof(double));
					obj.Price1 = (dr["Price1"] == Convert.DBNull) ? 0  : (double)Convert.ChangeType(dr["Price1"],typeof(double));
					obj.Price2 = (dr["Price2"] == Convert.DBNull) ? 0  : (double)Convert.ChangeType(dr["Price2"],typeof(double));
					obj.Installations = (dr["installations"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["installations"],typeof(string));
					obj.Logo = (dr["Logo"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Logo"],typeof(string));
					obj.LasteUpdateBy = (dr["Laste_update_By"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Laste_update_By"],typeof(string));
					obj.Creator = (dr["CREATOR"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["CREATOR"],typeof(string));
					obj.CreateDate = (dr["CREATE_DATE"] == Convert.DBNull) ? new DateTime(1900,1,1)  : (DateTime)Convert.ChangeType(dr["CREATE_DATE"],typeof(DateTime));
					obj.LasteUpdateDate = (dr["Laste_update_date"] == Convert.DBNull) ? new DateTime(1900,1,1)  : (DateTime)Convert.ChangeType(dr["Laste_update_date"],typeof(DateTime));
					obj.Square = (dr["Square"] == Convert.DBNull) ? 0  : (double)Convert.ChangeType(dr["Square"],typeof(double));
					obj.Breakfast = (dr["Breakfast"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Breakfast"],typeof(string));
					obj.Broadband = (dr["Broadband"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Broadband"],typeof(string));
					obj.Present = (dr["Present"] == Convert.DBNull) ? 0  : (double)Convert.ChangeType(dr["Present"],typeof(double));
					obj.Showpr = (dr["ShowPr"] == Convert.DBNull) ? 0  : (int)Convert.ChangeType(dr["ShowPr"],typeof(int));
				}
				else if (ColumnNameEnum.PropertyName == cne)
				{
					obj.Seqno = (dr["Seqno"] == Convert.DBNull) ? 0  : (int)Convert.ChangeType(dr["Seqno"],typeof(int));
					obj.Guid = (dr["Guid"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Guid"],typeof(string));
					obj.Pguid = (dr["Pguid"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Pguid"],typeof(string));
					obj.Roomtitle = (dr["Roomtitle"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Roomtitle"],typeof(string));
					obj.Shortdescr = (dr["Shortdescr"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Shortdescr"],typeof(string));
					obj.Descr = (dr["Descr"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Descr"],typeof(string));
					obj.Marketprice = (dr["Marketprice"] == Convert.DBNull) ? 0  : (double)Convert.ChangeType(dr["Marketprice"],typeof(double));
					obj.Price1 = (dr["Price1"] == Convert.DBNull) ? 0  : (double)Convert.ChangeType(dr["Price1"],typeof(double));
					obj.Price2 = (dr["Price2"] == Convert.DBNull) ? 0  : (double)Convert.ChangeType(dr["Price2"],typeof(double));
					obj.Installations = (dr["Installations"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Installations"],typeof(string));
					obj.Logo = (dr["Logo"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Logo"],typeof(string));
					obj.LasteUpdateBy = (dr["LasteUpdateBy"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["LasteUpdateBy"],typeof(string));
					obj.Creator = (dr["Creator"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Creator"],typeof(string));
					obj.CreateDate = (dr["CreateDate"] == Convert.DBNull) ? new DateTime(1900,1,1)  : (DateTime)Convert.ChangeType(dr["CreateDate"],typeof(DateTime));
					obj.LasteUpdateDate = (dr["LasteUpdateDate"] == Convert.DBNull) ? new DateTime(1900,1,1)  : (DateTime)Convert.ChangeType(dr["LasteUpdateDate"],typeof(DateTime));
					obj.Square = (dr["Square"] == Convert.DBNull) ? 0  : (double)Convert.ChangeType(dr["Square"],typeof(double));
					obj.Breakfast = (dr["Breakfast"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Breakfast"],typeof(string));
					obj.Broadband = (dr["Broadband"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Broadband"],typeof(string));
					obj.Present = (dr["Present"] == Convert.DBNull) ? 0  : (double)Convert.ChangeType(dr["Present"],typeof(double));
					obj.Showpr = (dr["Showpr"] == Convert.DBNull) ? 0  : (int)Convert.ChangeType(dr["Showpr"],typeof(int));		
				}
				
				return obj;
			}
			
			/// <summary>
			/// 将DataRow转换成Room对象(默认列名映射为属性名)
			/// </summary>
			/// <returns>Room对象</returns>
			public static Room Dr2Obj(DataRow dr)
			{
				return Dr2Obj(dr,ColumnNameEnum.DBName);
			}
			
			/// <summary>
			/// 将DataTabe转换成的Room对象集合
			/// </summary>
			/// <param name="dt">由CreateTable生成的DataTable</param>
			/// <param name="cne">dt的列名映射方式:DB列名或属性名</param>
			/// <returns>Room对象的集合</returns>
			public static List<Room> Dt2Objs(DataTable dt,ColumnNameEnum cne)
			{
				if (dt == null)
				{
					throw new ArgumentNullException("dt");
				}
				
				List<Room> alResult = new List<Room>();
				
				foreach(DataRow dr in dt.Rows)
				{
					alResult.Add(Dr2Obj(dr,cne));
				}
				
				return alResult;
			}

			/// <summary>
			/// 将DataTabe转换成的Room对象集合(默认列名映射为属性名)
			/// </summary>
			/// <param name="dt">由CreateTable生成的DataTable</param>
			/// <returns>Room对象的集合</returns>
			public static  List<Room> Dt2Objs(DataTable dt)
			{
				return Dt2Objs(dt, ColumnNameEnum.DBName);
			}
			
			/// <summary>
			/// 用objs的Room对象集合填充DataTable
			/// </summary>
			/// <param name="dt">由CreateTable生成的DataTable</param>
			/// <param name="objs">Room对象集合</param>
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
				
				foreach(Room obj in objs)
				{
					DataRow dr = dt.NewRow();
					obj.FillDataRow(dr,cne);
					dt.Rows.Add(dr);
				}
			}

			/// <summary>
			/// 用objs的Room对象集合填充DataTable(默认列名映射为属性名)
			/// </summary>
			/// <param name="dt">由CreateTable生成的DataTable</param>
			/// <param name="objs">Room对象集合</param>
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
			Room old = this.OldValue as Room;
			if (old != null)
			{
					this.Seqno = old.Seqno;
					this.Guid = old.Guid;
					this.Pguid = old.Pguid;
					this.Roomtitle = old.Roomtitle;
					this.Shortdescr = old.Shortdescr;
					this.Descr = old.Descr;
					this.Marketprice = old.Marketprice;
					this.Price1 = old.Price1;
					this.Price2 = old.Price2;
					this.Installations = old.Installations;
					this.Logo = old.Logo;
					this.LasteUpdateBy = old.LasteUpdateBy;
					this.Creator = old.Creator;
					this.CreateDate = old.CreateDate;
					this.LasteUpdateDate = old.LasteUpdateDate;
					this.Square = old.Square;
					this.Breakfast = old.Breakfast;
					this.Broadband = old.Broadband;
					this.Present = old.Present;
					this.Showpr = old.Showpr;				
				this.OldValue = null;
			}
		}
		
		
		
		
		#region Room实体的内部Key类
			/// <summary>
			/// Room实体的Key类
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
			/// 得到实体Room的PK
			/// </summary>
			public Key GetKey()
			{
				return new Key(Seqno);				
			}
			
				
		#endregion
	}
}
