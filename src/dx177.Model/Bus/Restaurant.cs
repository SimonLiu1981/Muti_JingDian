/*
版权所有：版权所有(C) 2012，中兴通讯
文件编号：M01_Restaurant.cs
文件名称：Restaurant.cs
系统编号：Z0003007
系统名称：通用办公系统
模块编号：M01
模块名称：信息发布
设计文档：IOA_M01信息发布XDE建模.mdx
完成日期：2012/6/22
作　　者：
内容摘要：表[Restaurant]对应的实体类
*/

using System;
using System.Collections;
using System.Data;
using System.Collections.Generic;


namespace dx177.Model.Bus
{
		/// <summary>
		/// 类 编 号：
		/// 类 名 称：Restaurant
		/// 内容摘要：
		/// </summary>
		
		[Serializable]
		public class Restaurant : BaseModel
		{
		#region 自动生成代码
		
			#region 重载Equals/GetHashCode
			/// <summary>
			/// 重载Equals			
			/// </summary>
			public override bool Equals (Object obj)
			{
				if (obj != null && obj is Restaurant)
				{
					if (obj == this)
						return true;
					Restaurant castObj = (Restaurant)obj; 
					
					if (!this.m_Seqno.Equals(castObj.Seqno))
						return false;
						
					if (!this.m_Guid.Equals(castObj.Guid))
						return false;
						
					if (!this.m_Title.Equals(castObj.Title))
						return false;
						
					if (!this.m_Address.Equals(castObj.Address))
						return false;
						
					if (!this.m_Restauranttype.Equals(castObj.Restauranttype))
						return false;
						
					if (!this.m_Area.Equals(castObj.Area))
						return false;
						
					if (!this.m_City.Equals(castObj.City))
						return false;
						
					if (!this.m_County.Equals(castObj.County))
						return false;
						
					if (!this.m_Line.Equals(castObj.Line))
						return false;
						
					if (!this.m_Linkman.Equals(castObj.Linkman))
						return false;
						
					if (!this.m_Cost.Equals(castObj.Cost))
						return false;
						
					if (!this.m_Shortcontent.Equals(castObj.Shortcontent))
						return false;
						
					if (!this.m_Telnumber.Equals(castObj.Telnumber))
						return false;
						
					if (!this.m_Content.Equals(castObj.Content))
						return false;
						
					if (!this.m_Map.Equals(castObj.Map))
						return false;
						
					if (!this.m_Logo.Equals(castObj.Logo))
						return false;
						
					if (!this.m_Status.Equals(castObj.Status))
						return false;
						
					if (!this.m_Qq.Equals(castObj.Qq))
						return false;
						
					if (!this.m_Aliww.Equals(castObj.Aliww))
						return false;
						
					if (!this.m_Creator.Equals(castObj.Creator))
						return false;
						
					if (!this.m_CreateDate.Equals(castObj.CreateDate))
						return false;
						
					if (!this.m_LasteUpdateDate.Equals(castObj.LasteUpdateDate))
						return false;
						
					if (!this.m_LasteUpdateBy.Equals(castObj.LasteUpdateBy))
						return false;
						
					if (!this.m_Tag.Equals(castObj.Tag))
						return false;
						
					if (!this.m_Favorable.Equals(castObj.Favorable))
						return false;
						
					if (!this.m_Viewtimes.Equals(castObj.Viewtimes))
						return false;
						
					if (!this.m_Showpr.Equals(castObj.Showpr))
						return false;
						
					if (!this.m_Jingqucode.Equals(castObj.Jingqucode))
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
					if ((object)m_Title != null)
					{
						hash = hash ^ m_Title.GetHashCode();
					}
						
					hash = hash <<  8;
					if ((object)m_Address != null)
					{
						hash = hash ^ m_Address.GetHashCode();
					}
						
					hash = hash <<  8;
					if ((object)m_Restauranttype != null)
					{
						hash = hash ^ m_Restauranttype.GetHashCode();
					}
						
					hash = hash <<  8;
					if ((object)m_Area != null)
					{
						hash = hash ^ m_Area.GetHashCode();
					}
						
					hash = hash <<  8;
					if ((object)m_City != null)
					{
						hash = hash ^ m_City.GetHashCode();
					}
						
					hash = hash <<  8;
					if ((object)m_County != null)
					{
						hash = hash ^ m_County.GetHashCode();
					}
						
					hash = hash <<  8;
					if ((object)m_Line != null)
					{
						hash = hash ^ m_Line.GetHashCode();
					}
						
					hash = hash <<  8;
					if ((object)m_Linkman != null)
					{
						hash = hash ^ m_Linkman.GetHashCode();
					}
						
					hash = hash <<  8;
					if ((object)m_Cost != null)
					{
						hash = hash ^ m_Cost.GetHashCode();
					}
						
					hash = hash <<  8;
					if ((object)m_Shortcontent != null)
					{
						hash = hash ^ m_Shortcontent.GetHashCode();
					}
						
					hash = hash <<  8;
					if ((object)m_Telnumber != null)
					{
						hash = hash ^ m_Telnumber.GetHashCode();
					}
						
					hash = hash <<  8;
					if ((object)m_Content != null)
					{
						hash = hash ^ m_Content.GetHashCode();
					}
						
					hash = hash <<  8;
					if ((object)m_Map != null)
					{
						hash = hash ^ m_Map.GetHashCode();
					}
						
					hash = hash <<  8;
					if ((object)m_Logo != null)
					{
						hash = hash ^ m_Logo.GetHashCode();
					}
						
					hash = hash <<  8;
					if ((object)m_Status != null)
					{
						hash = hash ^ m_Status.GetHashCode();
					}
						
					hash = hash <<  8;
					if ((object)m_Qq != null)
					{
						hash = hash ^ m_Qq.GetHashCode();
					}
						
					hash = hash <<  8;
					if ((object)m_Aliww != null)
					{
						hash = hash ^ m_Aliww.GetHashCode();
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
					if ((object)m_LasteUpdateBy != null)
					{
						hash = hash ^ m_LasteUpdateBy.GetHashCode();
					}
						
					hash = hash <<  8;
					if ((object)m_Tag != null)
					{
						hash = hash ^ m_Tag.GetHashCode();
					}
						
					hash = hash <<  8;
					if ((object)m_Favorable != null)
					{
						hash = hash ^ m_Favorable.GetHashCode();
					}
						
					hash = hash <<  8;
					if ((object)m_Viewtimes != null)
					{
						hash = hash ^ m_Viewtimes.GetHashCode();
					}
						
					hash = hash <<  8;
					if ((object)m_Showpr != null)
					{
						hash = hash ^ m_Showpr.GetHashCode();
					}
						
					hash = hash <<  8;
					if ((object)m_Jingqucode != null)
					{
						hash = hash ^ m_Jingqucode.GetHashCode();
					}
						
					return hash; 
			}
			#endregion
			
			public Restaurant()
			{
				MarkNew();
			}						
			
			public Restaurant GetOldValue()
			{
				return OldValue as Restaurant;
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
			/// 内容摘要： DB列名：Guid[GUID]
			///            DB类型：nvarchar(50)
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
		
		#region Title属性
			private string m_Title = String.Empty;
			/// <summary>
			/// 属性名称： Title
			/// 内容摘要： DB列名：Title[饭店名]
			///            DB类型：nvarchar(50)
			/// </summary>
			public string Title
			{
				get
					{
						return m_Title;
					}
				set
					{
						if (m_Title as object == null || !m_Title.Equals(value))
						{
							m_Title = value;
							MarkUpdated();
						}						
					}
			}
		#endregion
		
		#region Address属性
			private string m_Address = String.Empty;
			/// <summary>
			/// 属性名称： Address
			/// 内容摘要： DB列名：Address[地址]
			///            DB类型：nvarchar(255)
			/// </summary>
			public string Address
			{
				get
					{
						return m_Address;
					}
				set
					{
						if (m_Address as object == null || !m_Address.Equals(value))
						{
							m_Address = value;
							MarkUpdated();
						}						
					}
			}
		#endregion
		
		#region Restauranttype属性
			private string m_Restauranttype = String.Empty;
			/// <summary>
			/// 属性名称： Restauranttype
			/// 内容摘要： DB列名：RestaurantType[饭店类型]
			///            DB类型：nvarchar(50)
			/// </summary>
			public string Restauranttype
			{
				get
					{
						return m_Restauranttype;
					}
				set
					{
						if (m_Restauranttype as object == null || !m_Restauranttype.Equals(value))
						{
							m_Restauranttype = value;
							MarkUpdated();
						}						
					}
			}
		#endregion
		
		#region Area属性
			private string m_Area = String.Empty;
			/// <summary>
			/// 属性名称： Area
			/// 内容摘要： DB列名：Area[地段]
			///            DB类型：nvarchar(255)
			/// </summary>
			public string Area
			{
				get
					{
						return m_Area;
					}
				set
					{
						if (m_Area as object == null || !m_Area.Equals(value))
						{
							m_Area = value;
							MarkUpdated();
						}						
					}
			}
		#endregion
		
		#region City属性
			private string m_City = String.Empty;
			/// <summary>
			/// 属性名称： City
			/// 内容摘要： DB列名：City[市]
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
		
		#region County属性
			private string m_County = String.Empty;
			/// <summary>
			/// 属性名称： County
			/// 内容摘要： DB列名：county[县]
			///            DB类型：nvarchar(50)
			/// </summary>
			public string County
			{
				get
					{
						return m_County;
					}
				set
					{
						if (m_County as object == null || !m_County.Equals(value))
						{
							m_County = value;
							MarkUpdated();
						}						
					}
			}
		#endregion
		
		#region Line属性
			private string m_Line = String.Empty;
			/// <summary>
			/// 属性名称： Line
			/// 内容摘要： DB列名：Line[路线]
			///            DB类型：nvarchar(255)
			/// </summary>
			public string Line
			{
				get
					{
						return m_Line;
					}
				set
					{
						if (m_Line as object == null || !m_Line.Equals(value))
						{
							m_Line = value;
							MarkUpdated();
						}						
					}
			}
		#endregion
		
		#region Linkman属性
			private string m_Linkman = String.Empty;
			/// <summary>
			/// 属性名称： Linkman
			/// 内容摘要： DB列名：LinkMan[联系人]
			///            DB类型：nvarchar(50)
			/// </summary>
			public string Linkman
			{
				get
					{
						return m_Linkman;
					}
				set
					{
						if (m_Linkman as object == null || !m_Linkman.Equals(value))
						{
							m_Linkman = value;
							MarkUpdated();
						}						
					}
			}
		#endregion
		
		#region Cost属性
			private double m_Cost = 0.0;
			/// <summary>
			/// 属性名称： Cost
			/// 内容摘要： DB列名：Cost[人均花费]
			///            DB类型：float
			/// </summary>
			public double Cost
			{
				get
					{
						return m_Cost;
					}
				set
					{
						if (m_Cost as object == null || !m_Cost.Equals(value))
						{
							m_Cost = value;
							MarkUpdated();
						}						
					}
			}
		#endregion
		
		#region Shortcontent属性
			private string m_Shortcontent = String.Empty;
			/// <summary>
			/// 属性名称： Shortcontent
			/// 内容摘要： DB列名：shortContent[简介]
			///            DB类型：nvarchar(2000)
			/// </summary>
			public string Shortcontent
			{
				get
					{
						return m_Shortcontent;
					}
				set
					{
						if (m_Shortcontent as object == null || !m_Shortcontent.Equals(value))
						{
							m_Shortcontent = value;
							MarkUpdated();
						}						
					}
			}
		#endregion
		
		#region Telnumber属性
			private string m_Telnumber = String.Empty;
			/// <summary>
			/// 属性名称： Telnumber
			/// 内容摘要： DB列名：TelNumber[手机号码]
			///            DB类型：nvarchar(50)
			/// </summary>
			public string Telnumber
			{
				get
					{
						return m_Telnumber;
					}
				set
					{
						if (m_Telnumber as object == null || !m_Telnumber.Equals(value))
						{
							m_Telnumber = value;
							MarkUpdated();
						}						
					}
			}
		#endregion
		
		#region Content属性
			private string m_Content = String.Empty;
			/// <summary>
			/// 属性名称： Content
			/// 内容摘要： DB列名：Content[内容]
			///            DB类型：text
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
		
		#region Map属性
			private string m_Map = String.Empty;
			/// <summary>
			/// 属性名称： Map
			/// 内容摘要： DB列名：Map[地图]
			///            DB类型：text
			/// </summary>
			public string Map
			{
				get
					{
						return m_Map;
					}
				set
					{
						if (m_Map as object == null || !m_Map.Equals(value))
						{
							m_Map = value;
							MarkUpdated();
						}						
					}
			}
		#endregion
		
		#region Logo属性
			private string m_Logo = String.Empty;
			/// <summary>
			/// 属性名称： Logo
			/// 内容摘要： DB列名：Logo[图标]
			///            DB类型：nvarchar(200)
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
		
		#region Status属性
			private int m_Status = 0;
			/// <summary>
			/// 属性名称： Status
			/// 内容摘要： DB列名：Status[开通状态(OpenStatus枚举)]
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
		
		#region Qq属性
			private string m_Qq = String.Empty;
			/// <summary>
			/// 属性名称： Qq
			/// 内容摘要： DB列名：QQ[QQ]
			///            DB类型：nvarchar(50)
			/// </summary>
			public string Qq
			{
				get
					{
						return m_Qq;
					}
				set
					{
						if (m_Qq as object == null || !m_Qq.Equals(value))
						{
							m_Qq = value;
							MarkUpdated();
						}						
					}
			}
		#endregion
		
		#region Aliww属性
			private string m_Aliww = String.Empty;
			/// <summary>
			/// 属性名称： Aliww
			/// 内容摘要： DB列名：aliww[aliww]
			///            DB类型：nvarchar(50)
			/// </summary>
			public string Aliww
			{
				get
					{
						return m_Aliww;
					}
				set
					{
						if (m_Aliww as object == null || !m_Aliww.Equals(value))
						{
							m_Aliww = value;
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
			///            DB类型：nvarchar(50)
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
		
		#region LasteUpdateDate属性
			private DateTime m_LasteUpdateDate = new DateTime(1900,1,1);
			/// <summary>
			/// 属性名称： LasteUpdateDate
			/// 内容摘要： DB列名：Laste_update_date[最后更新时间]
			///            DB类型：datetime
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
		
		#region LasteUpdateBy属性
			private string m_LasteUpdateBy = String.Empty;
			/// <summary>
			/// 属性名称： LasteUpdateBy
			/// 内容摘要： DB列名：Laste_update_By[最后更新人]
			///            DB类型：nvarchar(50)
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
		
		#region Tag属性
			private string m_Tag = String.Empty;
			/// <summary>
			/// 属性名称： Tag
			/// 内容摘要： DB列名：Tag[关键字]
			///            DB类型：nvarchar(255)
			/// </summary>
			public string Tag
			{
				get
					{
						return m_Tag;
					}
				set
					{
						if (m_Tag as object == null || !m_Tag.Equals(value))
						{
							m_Tag = value;
							MarkUpdated();
						}						
					}
			}
		#endregion
		
		#region Favorable属性
			private string m_Favorable = String.Empty;
			/// <summary>
			/// 属性名称： Favorable
			/// 内容摘要： DB列名：Favorable[优惠]
			///            DB类型：nvarchar(50)
			/// </summary>
			public string Favorable
			{
				get
					{
						return m_Favorable;
					}
				set
					{
						if (m_Favorable as object == null || !m_Favorable.Equals(value))
						{
							m_Favorable = value;
							MarkUpdated();
						}						
					}
			}
		#endregion
		
		#region Viewtimes属性
			private int m_Viewtimes = 0;
			/// <summary>
			/// 属性名称： Viewtimes
			/// 内容摘要： DB列名：ViewTimes[]
			///            DB类型：int
			/// </summary>
			public int Viewtimes
			{
				get
					{
						return m_Viewtimes;
					}
				set
					{
						if (m_Viewtimes as object == null || !m_Viewtimes.Equals(value))
						{
							m_Viewtimes = value;
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
		
		#region Jingqucode属性
			private string m_Jingqucode = String.Empty;
			/// <summary>
			/// 属性名称： Jingqucode
			/// 内容摘要： DB列名：JingQuCode[]
			///            DB类型：nvarchar(20)
			/// </summary>
			public string Jingqucode
			{
				get
					{
						return m_Jingqucode;
					}
				set
					{
						if (m_Jingqucode as object == null || !m_Jingqucode.Equals(value))
						{
							m_Jingqucode = value;
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
					dtResult.Columns.Add(new DataColumn("Guid",typeof(string)));
					dtResult.Columns.Add(new DataColumn("Title",typeof(string)));
					dtResult.Columns.Add(new DataColumn("Address",typeof(string)));
					dtResult.Columns.Add(new DataColumn("RestaurantType",typeof(string)));
					dtResult.Columns.Add(new DataColumn("Area",typeof(string)));
					dtResult.Columns.Add(new DataColumn("City",typeof(string)));
					dtResult.Columns.Add(new DataColumn("county",typeof(string)));
					dtResult.Columns.Add(new DataColumn("Line",typeof(string)));
					dtResult.Columns.Add(new DataColumn("LinkMan",typeof(string)));
					dtResult.Columns.Add(new DataColumn("Cost",typeof(double)));
					dtResult.Columns.Add(new DataColumn("shortContent",typeof(string)));
					dtResult.Columns.Add(new DataColumn("TelNumber",typeof(string)));
					dtResult.Columns.Add(new DataColumn("Content",typeof(string)));
					dtResult.Columns.Add(new DataColumn("Map",typeof(string)));
					dtResult.Columns.Add(new DataColumn("Logo",typeof(string)));
					dtResult.Columns.Add(new DataColumn("Status",typeof(int)));
					dtResult.Columns.Add(new DataColumn("QQ",typeof(string)));
					dtResult.Columns.Add(new DataColumn("aliww",typeof(string)));
					dtResult.Columns.Add(new DataColumn("CREATOR",typeof(string)));
					dtResult.Columns.Add(new DataColumn("CREATE_DATE",typeof(DateTime)));
					dtResult.Columns.Add(new DataColumn("Laste_update_date",typeof(DateTime)));
					dtResult.Columns.Add(new DataColumn("Laste_update_By",typeof(string)));
					dtResult.Columns.Add(new DataColumn("Tag",typeof(string)));
					dtResult.Columns.Add(new DataColumn("Favorable",typeof(string)));
					dtResult.Columns.Add(new DataColumn("ViewTimes",typeof(int)));
					dtResult.Columns.Add(new DataColumn("ShowPr",typeof(int)));
					dtResult.Columns.Add(new DataColumn("JingQuCode",typeof(string)));
				}
				else if (cne == ColumnNameEnum.PropertyName)
				{
					dtResult.Columns.Add(new DataColumn("Seqno",typeof(int)));
					dtResult.Columns.Add(new DataColumn("Guid",typeof(string)));
					dtResult.Columns.Add(new DataColumn("Title",typeof(string)));
					dtResult.Columns.Add(new DataColumn("Address",typeof(string)));
					dtResult.Columns.Add(new DataColumn("Restauranttype",typeof(string)));
					dtResult.Columns.Add(new DataColumn("Area",typeof(string)));
					dtResult.Columns.Add(new DataColumn("City",typeof(string)));
					dtResult.Columns.Add(new DataColumn("County",typeof(string)));
					dtResult.Columns.Add(new DataColumn("Line",typeof(string)));
					dtResult.Columns.Add(new DataColumn("Linkman",typeof(string)));
					dtResult.Columns.Add(new DataColumn("Cost",typeof(double)));
					dtResult.Columns.Add(new DataColumn("Shortcontent",typeof(string)));
					dtResult.Columns.Add(new DataColumn("Telnumber",typeof(string)));
					dtResult.Columns.Add(new DataColumn("Content",typeof(string)));
					dtResult.Columns.Add(new DataColumn("Map",typeof(string)));
					dtResult.Columns.Add(new DataColumn("Logo",typeof(string)));
					dtResult.Columns.Add(new DataColumn("Status",typeof(int)));
					dtResult.Columns.Add(new DataColumn("Qq",typeof(string)));
					dtResult.Columns.Add(new DataColumn("Aliww",typeof(string)));
					dtResult.Columns.Add(new DataColumn("Creator",typeof(string)));
					dtResult.Columns.Add(new DataColumn("CreateDate",typeof(DateTime)));
					dtResult.Columns.Add(new DataColumn("LasteUpdateDate",typeof(DateTime)));
					dtResult.Columns.Add(new DataColumn("LasteUpdateBy",typeof(string)));
					dtResult.Columns.Add(new DataColumn("Tag",typeof(string)));
					dtResult.Columns.Add(new DataColumn("Favorable",typeof(string)));
					dtResult.Columns.Add(new DataColumn("Viewtimes",typeof(int)));
					dtResult.Columns.Add(new DataColumn("Showpr",typeof(int)));
					dtResult.Columns.Add(new DataColumn("Jingqucode",typeof(string)));
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
					dr["Guid"] = this.Guid;
					dr["Title"] = this.Title;
					dr["Address"] = this.Address;
					dr["RestaurantType"] = this.Restauranttype;
					dr["Area"] = this.Area;
					dr["City"] = this.City;
					dr["county"] = this.County;
					dr["Line"] = this.Line;
					dr["LinkMan"] = this.Linkman;
					dr["Cost"] = this.Cost;
					dr["shortContent"] = this.Shortcontent;
					dr["TelNumber"] = this.Telnumber;
					dr["Content"] = this.Content;
					dr["Map"] = this.Map;
					dr["Logo"] = this.Logo;
					dr["Status"] = this.Status;
					dr["QQ"] = this.Qq;
					dr["aliww"] = this.Aliww;
					dr["CREATOR"] = this.Creator;
					dr["CREATE_DATE"] = this.CreateDate;
					dr["Laste_update_date"] = this.LasteUpdateDate;
					dr["Laste_update_By"] = this.LasteUpdateBy;
					dr["Tag"] = this.Tag;
					dr["Favorable"] = this.Favorable;
					dr["ViewTimes"] = this.Viewtimes;
					dr["ShowPr"] = this.Showpr;
					dr["JingQuCode"] = this.Jingqucode;
				}
				else if (ColumnNameEnum.PropertyName == cne)
				{
					dr["Seqno"] = this.Seqno;
					dr["Guid"] = this.Guid;
					dr["Title"] = this.Title;
					dr["Address"] = this.Address;
					dr["Restauranttype"] = this.Restauranttype;
					dr["Area"] = this.Area;
					dr["City"] = this.City;
					dr["County"] = this.County;
					dr["Line"] = this.Line;
					dr["Linkman"] = this.Linkman;
					dr["Cost"] = this.Cost;
					dr["Shortcontent"] = this.Shortcontent;
					dr["Telnumber"] = this.Telnumber;
					dr["Content"] = this.Content;
					dr["Map"] = this.Map;
					dr["Logo"] = this.Logo;
					dr["Status"] = this.Status;
					dr["Qq"] = this.Qq;
					dr["Aliww"] = this.Aliww;
					dr["Creator"] = this.Creator;
					dr["CreateDate"] = this.CreateDate;
					dr["LasteUpdateDate"] = this.LasteUpdateDate;
					dr["LasteUpdateBy"] = this.LasteUpdateBy;
					dr["Tag"] = this.Tag;
					dr["Favorable"] = this.Favorable;
					dr["Viewtimes"] = this.Viewtimes;
					dr["Showpr"] = this.Showpr;
					dr["Jingqucode"] = this.Jingqucode;					
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
			/// 将DataRow转换成Restaurant对象
			/// </summary>
			/// <param name="dr">由CreateTable生成的DataTable通过NewRow得到的DataRow对象</param>
			/// <param name="cne">dr的列名映射方式:DB列名或属性名</param>
			/// <returns>Restaurant对象</returns>
			public static Restaurant Dr2Obj(DataRow dr,ColumnNameEnum cne)
			{
				if (dr == null)
				{
					throw new ArgumentNullException("dr");
				}
				Restaurant obj = new Restaurant();
				if (ColumnNameEnum.DBName == cne)
				{
					obj.Seqno = (dr["Seqno"] == Convert.DBNull) ? 0  : (int)Convert.ChangeType(dr["Seqno"],typeof(int));
					obj.Guid = (dr["Guid"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Guid"],typeof(string));
					obj.Title = (dr["Title"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Title"],typeof(string));
					obj.Address = (dr["Address"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Address"],typeof(string));
					obj.Restauranttype = (dr["RestaurantType"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["RestaurantType"],typeof(string));
					obj.Area = (dr["Area"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Area"],typeof(string));
					obj.City = (dr["City"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["City"],typeof(string));
					obj.County = (dr["county"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["county"],typeof(string));
					obj.Line = (dr["Line"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Line"],typeof(string));
					obj.Linkman = (dr["LinkMan"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["LinkMan"],typeof(string));
					obj.Cost = (dr["Cost"] == Convert.DBNull) ? 0.0  : (double)Convert.ChangeType(dr["Cost"],typeof(double));
					obj.Shortcontent = (dr["shortContent"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["shortContent"],typeof(string));
					obj.Telnumber = (dr["TelNumber"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["TelNumber"],typeof(string));
					obj.Content = (dr["Content"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Content"],typeof(string));
					obj.Map = (dr["Map"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Map"],typeof(string));
					obj.Logo = (dr["Logo"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Logo"],typeof(string));
					obj.Status = (dr["Status"] == Convert.DBNull) ? 0  : (int)Convert.ChangeType(dr["Status"],typeof(int));
					obj.Qq = (dr["QQ"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["QQ"],typeof(string));
					obj.Aliww = (dr["aliww"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["aliww"],typeof(string));
					obj.Creator = (dr["CREATOR"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["CREATOR"],typeof(string));
					obj.CreateDate = (dr["CREATE_DATE"] == Convert.DBNull) ? new DateTime(1900,1,1)  : (DateTime)Convert.ChangeType(dr["CREATE_DATE"],typeof(DateTime));
					obj.LasteUpdateDate = (dr["Laste_update_date"] == Convert.DBNull) ? new DateTime(1900,1,1)  : (DateTime)Convert.ChangeType(dr["Laste_update_date"],typeof(DateTime));
					obj.LasteUpdateBy = (dr["Laste_update_By"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Laste_update_By"],typeof(string));
					obj.Tag = (dr["Tag"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Tag"],typeof(string));
					obj.Favorable = (dr["Favorable"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Favorable"],typeof(string));
					obj.Viewtimes = (dr["ViewTimes"] == Convert.DBNull) ? 0  : (int)Convert.ChangeType(dr["ViewTimes"],typeof(int));
					obj.Showpr = (dr["ShowPr"] == Convert.DBNull) ? 0  : (int)Convert.ChangeType(dr["ShowPr"],typeof(int));
					obj.Jingqucode = (dr["JingQuCode"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["JingQuCode"],typeof(string));
				}
				else if (ColumnNameEnum.PropertyName == cne)
				{
					obj.Seqno = (dr["Seqno"] == Convert.DBNull) ? 0  : (int)Convert.ChangeType(dr["Seqno"],typeof(int));
					obj.Guid = (dr["Guid"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Guid"],typeof(string));
					obj.Title = (dr["Title"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Title"],typeof(string));
					obj.Address = (dr["Address"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Address"],typeof(string));
					obj.Restauranttype = (dr["Restauranttype"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Restauranttype"],typeof(string));
					obj.Area = (dr["Area"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Area"],typeof(string));
					obj.City = (dr["City"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["City"],typeof(string));
					obj.County = (dr["County"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["County"],typeof(string));
					obj.Line = (dr["Line"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Line"],typeof(string));
					obj.Linkman = (dr["Linkman"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Linkman"],typeof(string));
					obj.Cost = (dr["Cost"] == Convert.DBNull) ? 0.0  : (double)Convert.ChangeType(dr["Cost"],typeof(double));
					obj.Shortcontent = (dr["Shortcontent"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Shortcontent"],typeof(string));
					obj.Telnumber = (dr["Telnumber"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Telnumber"],typeof(string));
					obj.Content = (dr["Content"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Content"],typeof(string));
					obj.Map = (dr["Map"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Map"],typeof(string));
					obj.Logo = (dr["Logo"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Logo"],typeof(string));
					obj.Status = (dr["Status"] == Convert.DBNull) ? 0  : (int)Convert.ChangeType(dr["Status"],typeof(int));
					obj.Qq = (dr["Qq"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Qq"],typeof(string));
					obj.Aliww = (dr["Aliww"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Aliww"],typeof(string));
					obj.Creator = (dr["Creator"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Creator"],typeof(string));
					obj.CreateDate = (dr["CreateDate"] == Convert.DBNull) ? new DateTime(1900,1,1)  : (DateTime)Convert.ChangeType(dr["CreateDate"],typeof(DateTime));
					obj.LasteUpdateDate = (dr["LasteUpdateDate"] == Convert.DBNull) ? new DateTime(1900,1,1)  : (DateTime)Convert.ChangeType(dr["LasteUpdateDate"],typeof(DateTime));
					obj.LasteUpdateBy = (dr["LasteUpdateBy"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["LasteUpdateBy"],typeof(string));
					obj.Tag = (dr["Tag"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Tag"],typeof(string));
					obj.Favorable = (dr["Favorable"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Favorable"],typeof(string));
					obj.Viewtimes = (dr["Viewtimes"] == Convert.DBNull) ? 0  : (int)Convert.ChangeType(dr["Viewtimes"],typeof(int));
					obj.Showpr = (dr["Showpr"] == Convert.DBNull) ? 0  : (int)Convert.ChangeType(dr["Showpr"],typeof(int));
					obj.Jingqucode = (dr["Jingqucode"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Jingqucode"],typeof(string));		
				}
				
				return obj;
			}
			
			/// <summary>
			/// 将DataRow转换成Restaurant对象(默认列名映射为属性名)
			/// </summary>
			/// <returns>Restaurant对象</returns>
			public static Restaurant Dr2Obj(DataRow dr)
			{
				return Dr2Obj(dr,ColumnNameEnum.DBName);
			}
			
			/// <summary>
			/// 将DataTabe转换成的Restaurant对象集合
			/// </summary>
			/// <param name="dt">由CreateTable生成的DataTable</param>
			/// <param name="cne">dt的列名映射方式:DB列名或属性名</param>
			/// <returns>Restaurant对象的集合</returns>
			public static List<Restaurant>  Dt2Objs(DataTable dt,ColumnNameEnum cne)
			{
				if (dt == null)
				{
					throw new ArgumentNullException("dt");
				}
				
				 
				List<Restaurant> alResult = new List<Restaurant>();
				
				foreach(DataRow dr in dt.Rows)
				{
					alResult.Add(Dr2Obj(dr,cne));
				}
				
				return alResult;
			}

			/// <summary>
			/// 将DataTabe转换成的Restaurant对象集合(默认列名映射为属性名)
			/// </summary>
			/// <param name="dt">由CreateTable生成的DataTable</param>
			/// <returns>Restaurant对象的集合</returns>
			public static List<Restaurant> Dt2Objs(DataTable dt)
			{
				return Dt2Objs(dt,ColumnNameEnum.DBName);
			}
			
			/// <summary>
			/// 用objs的Restaurant对象集合填充DataTable
			/// </summary>
			/// <param name="dt">由CreateTable生成的DataTable</param>
			/// <param name="objs">Restaurant对象集合</param>
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
				
				foreach(Restaurant obj in objs)
				{
					DataRow dr = dt.NewRow();
					obj.FillDataRow(dr,cne);
					dt.Rows.Add(dr);
				}
			}

			/// <summary>
			/// 用objs的Restaurant对象集合填充DataTable(默认列名映射为属性名)
			/// </summary>
			/// <param name="dt">由CreateTable生成的DataTable</param>
			/// <param name="objs">Restaurant对象集合</param>
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
			Restaurant old = this.OldValue as Restaurant;
			if (old != null)
			{
					this.Seqno = old.Seqno;
					this.Guid = old.Guid;
					this.Title = old.Title;
					this.Address = old.Address;
					this.Restauranttype = old.Restauranttype;
					this.Area = old.Area;
					this.City = old.City;
					this.County = old.County;
					this.Line = old.Line;
					this.Linkman = old.Linkman;
					this.Cost = old.Cost;
					this.Shortcontent = old.Shortcontent;
					this.Telnumber = old.Telnumber;
					this.Content = old.Content;
					this.Map = old.Map;
					this.Logo = old.Logo;
					this.Status = old.Status;
					this.Qq = old.Qq;
					this.Aliww = old.Aliww;
					this.Creator = old.Creator;
					this.CreateDate = old.CreateDate;
					this.LasteUpdateDate = old.LasteUpdateDate;
					this.LasteUpdateBy = old.LasteUpdateBy;
					this.Tag = old.Tag;
					this.Favorable = old.Favorable;
					this.Viewtimes = old.Viewtimes;
					this.Showpr = old.Showpr;
					this.Jingqucode = old.Jingqucode;				
				this.OldValue = null;
			}
		}
		
		
		
		
		#region Restaurant实体的内部Key类
			/// <summary>
			/// Restaurant实体的Key类
			/// </summary>
			public class Key
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
			/// 得到实体Restaurant的PK
			/// </summary>
			public Key GetKey()
			{
				return new Key(Seqno);				
			}
	
		
		#endregion
	}
}
