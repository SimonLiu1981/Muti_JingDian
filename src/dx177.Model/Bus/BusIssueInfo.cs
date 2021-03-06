/*
版权所有：版权所有(C) 2012，中兴通讯
文件编号：M01_BusIssueInfo.cs
文件名称：BusIssueInfo.cs
系统编号：Z0003007
系统名称：通用办公系统
模块编号：M01
模块名称：信息发布
设计文档：IOA_M01信息发布XDE建模.mdx
完成日期：2012/6/22
作　　者：
内容摘要：表[Bus_Issue_Info]对应的实体类
*/

using System;
using System.Collections;
using System.Data;
using System.Collections.Generic;


namespace dx177.Model.Bus
{
		/// <summary>
		/// 类 编 号：
		/// 类 名 称：BusIssueInfo
		/// 内容摘要：
		/// </summary>
		
		[Serializable]
		public class BusIssueInfo : BaseModel
		{
		#region 自动生成代码
		
			#region 重载Equals/GetHashCode
			/// <summary>
			/// 重载Equals			
			/// </summary>
			public override bool Equals (Object obj)
			{
				if (obj != null && obj is BusIssueInfo)
				{
					if (obj == this)
						return true;
					BusIssueInfo castObj = (BusIssueInfo)obj; 
					
					if (!this.m_Seqno.Equals(castObj.Seqno))
						return false;
						
					if (!this.m_Guid.Equals(castObj.Guid))
						return false;
						
					if (!this.m_Infotype.Equals(castObj.Infotype))
						return false;
						
					if (!this.m_Title.Equals(castObj.Title))
						return false;
						
					if (!this.m_Shortcontent.Equals(castObj.Shortcontent))
						return false;
						
					if (!this.m_Code.Equals(castObj.Code))
						return false;
						
					if (!this.m_Content.Equals(castObj.Content))
						return false;
						
					if (!this.m_Viewtimes.Equals(castObj.Viewtimes))
						return false;
						
					if (!this.m_LasteUpdateDate.Equals(castObj.LasteUpdateDate))
						return false;
						
					if (!this.m_LasteUpdateBy.Equals(castObj.LasteUpdateBy))
						return false;
						
					if (!this.m_Isfirst.Equals(castObj.Isfirst))
						return false;
						
					if (!this.m_Ishot.Equals(castObj.Ishot))
						return false;
						
					if (!this.m_Iscomment.Equals(castObj.Iscomment))
						return false;
						
					if (!this.m_Logo.Equals(castObj.Logo))
						return false;
						
					if (!this.m_Creator.Equals(castObj.Creator))
						return false;
						
					if (!this.m_CreateDate.Equals(castObj.CreateDate))
						return false;
						
					if (!this.m_Good.Equals(castObj.Good))
						return false;
						
					if (!this.m_Bad.Equals(castObj.Bad))
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
					if ((object)m_Infotype != null)
					{
						hash = hash ^ m_Infotype.GetHashCode();
					}
						
					hash = hash <<  8;
					if ((object)m_Title != null)
					{
						hash = hash ^ m_Title.GetHashCode();
					}
						
					hash = hash <<  8;
					if ((object)m_Shortcontent != null)
					{
						hash = hash ^ m_Shortcontent.GetHashCode();
					}
						
					hash = hash <<  8;
					if ((object)m_Code != null)
					{
						hash = hash ^ m_Code.GetHashCode();
					}
						
					hash = hash <<  8;
					if ((object)m_Content != null)
					{
						hash = hash ^ m_Content.GetHashCode();
					}
						
					hash = hash <<  8;
					if ((object)m_Viewtimes != null)
					{
						hash = hash ^ m_Viewtimes.GetHashCode();
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
					if ((object)m_Isfirst != null)
					{
						hash = hash ^ m_Isfirst.GetHashCode();
					}
						
					hash = hash <<  8;
					if ((object)m_Ishot != null)
					{
						hash = hash ^ m_Ishot.GetHashCode();
					}
						
					hash = hash <<  8;
					if ((object)m_Iscomment != null)
					{
						hash = hash ^ m_Iscomment.GetHashCode();
					}
						
					hash = hash <<  8;
					if ((object)m_Logo != null)
					{
						hash = hash ^ m_Logo.GetHashCode();
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
					if ((object)m_Good != null)
					{
						hash = hash ^ m_Good.GetHashCode();
					}
						
					hash = hash <<  8;
					if ((object)m_Bad != null)
					{
						hash = hash ^ m_Bad.GetHashCode();
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
			
			public BusIssueInfo()
			{
				MarkNew();
			}						
			
			public BusIssueInfo GetOldValue()
			{
				return OldValue as BusIssueInfo;
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
		
		#region Infotype属性
			private string m_Infotype = String.Empty;
			/// <summary>
			/// 属性名称： Infotype
			/// 内容摘要： DB列名：InfoType[类型]
			///            DB类型：nvarchar(50)
			/// </summary>
			public string Infotype
			{
				get
					{
						return m_Infotype;
					}
				set
					{
						if (m_Infotype as object == null || !m_Infotype.Equals(value))
						{
							m_Infotype = value;
							MarkUpdated();
						}						
					}
			}
		#endregion
		
		#region Title属性
			private string m_Title = String.Empty;
			/// <summary>
			/// 属性名称： Title
			/// 内容摘要： DB列名：Title[标题]
			///            DB类型：nvarchar(255)
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
		
		#region Shortcontent属性
			private string m_Shortcontent = String.Empty;
			/// <summary>
			/// 属性名称： Shortcontent
			/// 内容摘要： DB列名：ShortContent[简述]
			///            DB类型：nvarchar(50)
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
		
		#region Code属性
			private string m_Code = String.Empty;
			/// <summary>
			/// 属性名称： Code
			/// 内容摘要： DB列名：Code[代号]
			///            DB类型：nvarchar(50)
			/// </summary>
			public string Code
			{
				get
					{
						return m_Code;
					}
				set
					{
						if (m_Code as object == null || !m_Code.Equals(value))
						{
							m_Code = value;
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
		
		#region Viewtimes属性
			private int m_Viewtimes = 0;
			/// <summary>
			/// 属性名称： Viewtimes
			/// 内容摘要： DB列名：ViewTimes[浏览次数]
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
		
		#region Isfirst属性
			private int m_Isfirst = 0;
			/// <summary>
			/// 属性名称： Isfirst
			/// 内容摘要： DB列名：IsFirst[首页]
			///            DB类型：int
			/// </summary>
			public int Isfirst
			{
				get
					{
						return m_Isfirst;
					}
				set
					{
						if (m_Isfirst as object == null || !m_Isfirst.Equals(value))
						{
							m_Isfirst = value;
							MarkUpdated();
						}						
					}
			}
		#endregion
		
		#region Ishot属性
			private int m_Ishot = 0;
			/// <summary>
			/// 属性名称： Ishot
			/// 内容摘要： DB列名：IsHot[热点新闻]
			///            DB类型：int
			/// </summary>
			public int Ishot
			{
				get
					{
						return m_Ishot;
					}
				set
					{
						if (m_Ishot as object == null || !m_Ishot.Equals(value))
						{
							m_Ishot = value;
							MarkUpdated();
						}						
					}
			}
		#endregion
		
		#region Iscomment属性
			private int m_Iscomment = 0;
			/// <summary>
			/// 属性名称： Iscomment
			/// 内容摘要： DB列名：IsComment[推荐新闻]
			///            DB类型：int
			/// </summary>
			public int Iscomment
			{
				get
					{
						return m_Iscomment;
					}
				set
					{
						if (m_Iscomment as object == null || !m_Iscomment.Equals(value))
						{
							m_Iscomment = value;
							MarkUpdated();
						}						
					}
			}
		#endregion
		
		#region Logo属性
			private string m_Logo = String.Empty;
			/// <summary>
			/// 属性名称： Logo
			/// 内容摘要： DB列名：Logo[图片]
			///            DB类型：nvarchar(255)
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
		
		#region Good属性
			private int m_Good = 0;
			/// <summary>
			/// 属性名称： Good
			/// 内容摘要： DB列名：Good[顶]
			///            DB类型：int
			/// </summary>
			public int Good
			{
				get
					{
						return m_Good;
					}
				set
					{
						if (m_Good as object == null || !m_Good.Equals(value))
						{
							m_Good = value;
							MarkUpdated();
						}						
					}
			}
		#endregion
		
		#region Bad属性
			private int m_Bad = 0;
			/// <summary>
			/// 属性名称： Bad
			/// 内容摘要： DB列名：Bad[坏]
			///            DB类型：int
			/// </summary>
			public int Bad
			{
				get
					{
						return m_Bad;
					}
				set
					{
						if (m_Bad as object == null || !m_Bad.Equals(value))
						{
							m_Bad = value;
							MarkUpdated();
						}						
					}
			}
		#endregion
		
		#region Showpr属性
			private int m_Showpr = 0;
			/// <summary>
			/// 属性名称： Showpr
			/// 内容摘要： DB列名：ShowPr[权重]
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
					dtResult.Columns.Add(new DataColumn("GUID",typeof(string)));
					dtResult.Columns.Add(new DataColumn("InfoType",typeof(string)));
					dtResult.Columns.Add(new DataColumn("Title",typeof(string)));
					dtResult.Columns.Add(new DataColumn("ShortContent",typeof(string)));
					dtResult.Columns.Add(new DataColumn("Code",typeof(string)));
					dtResult.Columns.Add(new DataColumn("Content",typeof(string)));
					dtResult.Columns.Add(new DataColumn("ViewTimes",typeof(int)));
					dtResult.Columns.Add(new DataColumn("Laste_update_date",typeof(DateTime)));
					dtResult.Columns.Add(new DataColumn("Laste_update_By",typeof(string)));
					dtResult.Columns.Add(new DataColumn("IsFirst",typeof(int)));
					dtResult.Columns.Add(new DataColumn("IsHot",typeof(int)));
					dtResult.Columns.Add(new DataColumn("IsComment",typeof(int)));
					dtResult.Columns.Add(new DataColumn("Logo",typeof(string)));
					dtResult.Columns.Add(new DataColumn("CREATOR",typeof(string)));
					dtResult.Columns.Add(new DataColumn("CREATE_DATE",typeof(DateTime)));
					dtResult.Columns.Add(new DataColumn("Good",typeof(int)));
					dtResult.Columns.Add(new DataColumn("Bad",typeof(int)));
					dtResult.Columns.Add(new DataColumn("ShowPr",typeof(int)));
					dtResult.Columns.Add(new DataColumn("JingQuCode",typeof(string)));
				}
				else if (cne == ColumnNameEnum.PropertyName)
				{
					dtResult.Columns.Add(new DataColumn("Seqno",typeof(int)));
					dtResult.Columns.Add(new DataColumn("Guid",typeof(string)));
					dtResult.Columns.Add(new DataColumn("Infotype",typeof(string)));
					dtResult.Columns.Add(new DataColumn("Title",typeof(string)));
					dtResult.Columns.Add(new DataColumn("Shortcontent",typeof(string)));
					dtResult.Columns.Add(new DataColumn("Code",typeof(string)));
					dtResult.Columns.Add(new DataColumn("Content",typeof(string)));
					dtResult.Columns.Add(new DataColumn("Viewtimes",typeof(int)));
					dtResult.Columns.Add(new DataColumn("LasteUpdateDate",typeof(DateTime)));
					dtResult.Columns.Add(new DataColumn("LasteUpdateBy",typeof(string)));
					dtResult.Columns.Add(new DataColumn("Isfirst",typeof(int)));
					dtResult.Columns.Add(new DataColumn("Ishot",typeof(int)));
					dtResult.Columns.Add(new DataColumn("Iscomment",typeof(int)));
					dtResult.Columns.Add(new DataColumn("Logo",typeof(string)));
					dtResult.Columns.Add(new DataColumn("Creator",typeof(string)));
					dtResult.Columns.Add(new DataColumn("CreateDate",typeof(DateTime)));
					dtResult.Columns.Add(new DataColumn("Good",typeof(int)));
					dtResult.Columns.Add(new DataColumn("Bad",typeof(int)));
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
					dr["GUID"] = this.Guid;
					dr["InfoType"] = this.Infotype;
					dr["Title"] = this.Title;
					dr["ShortContent"] = this.Shortcontent;
					dr["Code"] = this.Code;
					dr["Content"] = this.Content;
					dr["ViewTimes"] = this.Viewtimes;
					dr["Laste_update_date"] = this.LasteUpdateDate;
					dr["Laste_update_By"] = this.LasteUpdateBy;
					dr["IsFirst"] = this.Isfirst;
					dr["IsHot"] = this.Ishot;
					dr["IsComment"] = this.Iscomment;
					dr["Logo"] = this.Logo;
					dr["CREATOR"] = this.Creator;
					dr["CREATE_DATE"] = this.CreateDate;
					dr["Good"] = this.Good;
					dr["Bad"] = this.Bad;
					dr["ShowPr"] = this.Showpr;
					dr["JingQuCode"] = this.Jingqucode;
				}
				else if (ColumnNameEnum.PropertyName == cne)
				{
					dr["Seqno"] = this.Seqno;
					dr["Guid"] = this.Guid;
					dr["Infotype"] = this.Infotype;
					dr["Title"] = this.Title;
					dr["Shortcontent"] = this.Shortcontent;
					dr["Code"] = this.Code;
					dr["Content"] = this.Content;
					dr["Viewtimes"] = this.Viewtimes;
					dr["LasteUpdateDate"] = this.LasteUpdateDate;
					dr["LasteUpdateBy"] = this.LasteUpdateBy;
					dr["Isfirst"] = this.Isfirst;
					dr["Ishot"] = this.Ishot;
					dr["Iscomment"] = this.Iscomment;
					dr["Logo"] = this.Logo;
					dr["Creator"] = this.Creator;
					dr["CreateDate"] = this.CreateDate;
					dr["Good"] = this.Good;
					dr["Bad"] = this.Bad;
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
			/// 将DataRow转换成BusIssueInfo对象
			/// </summary>
			/// <param name="dr">由CreateTable生成的DataTable通过NewRow得到的DataRow对象</param>
			/// <param name="cne">dr的列名映射方式:DB列名或属性名</param>
			/// <returns>BusIssueInfo对象</returns>
			public static BusIssueInfo Dr2Obj(DataRow dr,ColumnNameEnum cne)
			{
				if (dr == null)
				{
					throw new ArgumentNullException("dr");
				}
				BusIssueInfo obj = new BusIssueInfo();
				if (ColumnNameEnum.DBName == cne)
				{
					obj.Seqno = (dr["Seqno"] == Convert.DBNull) ? 0  : (int)Convert.ChangeType(dr["Seqno"],typeof(int));
					obj.Guid = (dr["GUID"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["GUID"],typeof(string));
					obj.Infotype = (dr["InfoType"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["InfoType"],typeof(string));
					obj.Title = (dr["Title"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Title"],typeof(string));
					obj.Shortcontent = (dr["ShortContent"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["ShortContent"],typeof(string));
					obj.Code = (dr["Code"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Code"],typeof(string));
					obj.Content = (dr["Content"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Content"],typeof(string));
					obj.Viewtimes = (dr["ViewTimes"] == Convert.DBNull) ? 0  : (int)Convert.ChangeType(dr["ViewTimes"],typeof(int));
					obj.LasteUpdateDate = (dr["Laste_update_date"] == Convert.DBNull) ? new DateTime(1900,1,1)  : (DateTime)Convert.ChangeType(dr["Laste_update_date"],typeof(DateTime));
					obj.LasteUpdateBy = (dr["Laste_update_By"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Laste_update_By"],typeof(string));
					obj.Isfirst = (dr["IsFirst"] == Convert.DBNull) ? 0  : (int)Convert.ChangeType(dr["IsFirst"],typeof(int));
					obj.Ishot = (dr["IsHot"] == Convert.DBNull) ? 0  : (int)Convert.ChangeType(dr["IsHot"],typeof(int));
					obj.Iscomment = (dr["IsComment"] == Convert.DBNull) ? 0  : (int)Convert.ChangeType(dr["IsComment"],typeof(int));
					obj.Logo = (dr["Logo"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Logo"],typeof(string));
					obj.Creator = (dr["CREATOR"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["CREATOR"],typeof(string));
					obj.CreateDate = (dr["CREATE_DATE"] == Convert.DBNull) ? new DateTime(1900,1,1)  : (DateTime)Convert.ChangeType(dr["CREATE_DATE"],typeof(DateTime));
					obj.Good = (dr["Good"] == Convert.DBNull) ? 0  : (int)Convert.ChangeType(dr["Good"],typeof(int));
					obj.Bad = (dr["Bad"] == Convert.DBNull) ? 0  : (int)Convert.ChangeType(dr["Bad"],typeof(int));
					obj.Showpr = (dr["ShowPr"] == Convert.DBNull) ? 0  : (int)Convert.ChangeType(dr["ShowPr"],typeof(int));
					obj.Jingqucode = (dr["JingQuCode"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["JingQuCode"],typeof(string));
				}
				else if (ColumnNameEnum.PropertyName == cne)
				{
					obj.Seqno = (dr["Seqno"] == Convert.DBNull) ? 0  : (int)Convert.ChangeType(dr["Seqno"],typeof(int));
					obj.Guid = (dr["Guid"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Guid"],typeof(string));
					obj.Infotype = (dr["Infotype"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Infotype"],typeof(string));
					obj.Title = (dr["Title"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Title"],typeof(string));
					obj.Shortcontent = (dr["Shortcontent"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Shortcontent"],typeof(string));
					obj.Code = (dr["Code"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Code"],typeof(string));
					obj.Content = (dr["Content"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Content"],typeof(string));
					obj.Viewtimes = (dr["Viewtimes"] == Convert.DBNull) ? 0  : (int)Convert.ChangeType(dr["Viewtimes"],typeof(int));
					obj.LasteUpdateDate = (dr["LasteUpdateDate"] == Convert.DBNull) ? new DateTime(1900,1,1)  : (DateTime)Convert.ChangeType(dr["LasteUpdateDate"],typeof(DateTime));
					obj.LasteUpdateBy = (dr["LasteUpdateBy"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["LasteUpdateBy"],typeof(string));
					obj.Isfirst = (dr["Isfirst"] == Convert.DBNull) ? 0  : (int)Convert.ChangeType(dr["Isfirst"],typeof(int));
					obj.Ishot = (dr["Ishot"] == Convert.DBNull) ? 0  : (int)Convert.ChangeType(dr["Ishot"],typeof(int));
					obj.Iscomment = (dr["Iscomment"] == Convert.DBNull) ? 0  : (int)Convert.ChangeType(dr["Iscomment"],typeof(int));
					obj.Logo = (dr["Logo"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Logo"],typeof(string));
					obj.Creator = (dr["Creator"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Creator"],typeof(string));
					obj.CreateDate = (dr["CreateDate"] == Convert.DBNull) ? new DateTime(1900,1,1)  : (DateTime)Convert.ChangeType(dr["CreateDate"],typeof(DateTime));
					obj.Good = (dr["Good"] == Convert.DBNull) ? 0  : (int)Convert.ChangeType(dr["Good"],typeof(int));
					obj.Bad = (dr["Bad"] == Convert.DBNull) ? 0  : (int)Convert.ChangeType(dr["Bad"],typeof(int));
					obj.Showpr = (dr["Showpr"] == Convert.DBNull) ? 0  : (int)Convert.ChangeType(dr["Showpr"],typeof(int));
					obj.Jingqucode = (dr["Jingqucode"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Jingqucode"],typeof(string));		
				}
				
				return obj;
			}
			
			/// <summary>
			/// 将DataRow转换成BusIssueInfo对象(默认列名映射为属性名)
			/// </summary>
			/// <returns>BusIssueInfo对象</returns>
			public static BusIssueInfo Dr2Obj(DataRow dr)
			{
				return Dr2Obj(dr,ColumnNameEnum.DBName);
			}
			
			/// <summary>
			/// 将DataTabe转换成的BusIssueInfo对象集合
			/// </summary>
			/// <param name="dt">由CreateTable生成的DataTable</param>
			/// <param name="cne">dt的列名映射方式:DB列名或属性名</param>
			/// <returns>BusIssueInfo对象的集合</returns>
			public static List<BusIssueInfo>  Dt2Objs(DataTable dt,ColumnNameEnum cne)
			{
				if (dt == null)
				{
					throw new ArgumentNullException("dt");
				}
				
				 
				List<BusIssueInfo> alResult = new List<BusIssueInfo>();
				
				foreach(DataRow dr in dt.Rows)
				{
					alResult.Add(Dr2Obj(dr,cne));
				}
				
				return alResult;
			}

			/// <summary>
			/// 将DataTabe转换成的BusIssueInfo对象集合(默认列名映射为属性名)
			/// </summary>
			/// <param name="dt">由CreateTable生成的DataTable</param>
			/// <returns>BusIssueInfo对象的集合</returns>
			public static List<BusIssueInfo> Dt2Objs(DataTable dt)
			{
				return Dt2Objs(dt,ColumnNameEnum.DBName);
			}
			
			/// <summary>
			/// 用objs的BusIssueInfo对象集合填充DataTable
			/// </summary>
			/// <param name="dt">由CreateTable生成的DataTable</param>
			/// <param name="objs">BusIssueInfo对象集合</param>
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
				
				foreach(BusIssueInfo obj in objs)
				{
					DataRow dr = dt.NewRow();
					obj.FillDataRow(dr,cne);
					dt.Rows.Add(dr);
				}
			}

			/// <summary>
			/// 用objs的BusIssueInfo对象集合填充DataTable(默认列名映射为属性名)
			/// </summary>
			/// <param name="dt">由CreateTable生成的DataTable</param>
			/// <param name="objs">BusIssueInfo对象集合</param>
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
			BusIssueInfo old = this.OldValue as BusIssueInfo;
			if (old != null)
			{
					this.Seqno = old.Seqno;
					this.Guid = old.Guid;
					this.Infotype = old.Infotype;
					this.Title = old.Title;
					this.Shortcontent = old.Shortcontent;
					this.Code = old.Code;
					this.Content = old.Content;
					this.Viewtimes = old.Viewtimes;
					this.LasteUpdateDate = old.LasteUpdateDate;
					this.LasteUpdateBy = old.LasteUpdateBy;
					this.Isfirst = old.Isfirst;
					this.Ishot = old.Ishot;
					this.Iscomment = old.Iscomment;
					this.Logo = old.Logo;
					this.Creator = old.Creator;
					this.CreateDate = old.CreateDate;
					this.Good = old.Good;
					this.Bad = old.Bad;
					this.Showpr = old.Showpr;
					this.Jingqucode = old.Jingqucode;				
				this.OldValue = null;
			}
		}
		
		
		
		
		#region BusIssueInfo实体的内部Key类
			/// <summary>
			/// BusIssueInfo实体的Key类
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
			/// 得到实体BusIssueInfo的PK
			/// </summary>
			public Key GetKey()
			{
				return new Key(Seqno);				
			}
	
		
		#endregion
	}
}
