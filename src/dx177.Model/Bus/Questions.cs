/*
版权所有：版权所有(C) 2012，中兴通讯
文件编号：M01_Questions.cs
文件名称：Questions.cs
系统编号：Z0003007
系统名称：通用办公系统
模块编号：M01
模块名称：信息发布
设计文档：IOA_M01信息发布XDE建模.mdx
完成日期：2012/6/22
作　　者：
内容摘要：表[Questions]对应的实体类
*/

using System;
using System.Collections;
using System.Data;
using System.Collections.Generic;


namespace dx177.Model.Bus
{
		/// <summary>
		/// 类 编 号：
		/// 类 名 称：Questions
		/// 内容摘要：
		/// </summary>
		
		[Serializable]
		public class Questions : BaseModel
		{
		#region 自动生成代码
		
			#region 重载Equals/GetHashCode
			/// <summary>
			/// 重载Equals			
			/// </summary>
			public override bool Equals (Object obj)
			{
				if (obj != null && obj is Questions)
				{
					if (obj == this)
						return true;
					Questions castObj = (Questions)obj; 
					
					if (!this.m_Seqno.Equals(castObj.Seqno))
						return false;
						
					if (!this.m_Guid.Equals(castObj.Guid))
						return false;
						
					if (!this.m_Title.Equals(castObj.Title))
						return false;
						
					if (!this.m_Qtype.Equals(castObj.Qtype))
						return false;
						
					if (!this.m_Content.Equals(castObj.Content))
						return false;
						
					if (!this.m_Status.Equals(castObj.Status))
						return false;
						
					if (!this.m_Creator.Equals(castObj.Creator))
						return false;
						
					if (!this.m_CreateDate.Equals(castObj.CreateDate))
						return false;
						
					if (!this.m_Showidx.Equals(castObj.Showidx))
						return false;
						
					if (!this.m_Viewtimes.Equals(castObj.Viewtimes))
						return false;
						
					if (!this.m_Owner.Equals(castObj.Owner))
						return false;
						
					if (!this.m_Siteid.Equals(castObj.Siteid))
						return false;
						
					if (!this.m_Cityid.Equals(castObj.Cityid))
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
					if ((object)m_Qtype != null)
					{
						hash = hash ^ m_Qtype.GetHashCode();
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
					if ((object)m_Showidx != null)
					{
						hash = hash ^ m_Showidx.GetHashCode();
					}
						
					hash = hash <<  8;
					if ((object)m_Viewtimes != null)
					{
						hash = hash ^ m_Viewtimes.GetHashCode();
					}
						
					hash = hash <<  8;
					if ((object)m_Owner != null)
					{
						hash = hash ^ m_Owner.GetHashCode();
					}
						
					hash = hash <<  8;
					if ((object)m_Siteid != null)
					{
						hash = hash ^ m_Siteid.GetHashCode();
					}
						
					hash = hash <<  8;
					if ((object)m_Cityid != null)
					{
						hash = hash ^ m_Cityid.GetHashCode();
					}
						
					hash = hash <<  8;
					if ((object)m_Jingqucode != null)
					{
						hash = hash ^ m_Jingqucode.GetHashCode();
					}
						
					return hash; 
			}
			#endregion
			
			public Questions()
			{
				MarkNew();
			}						
			
			public Questions GetOldValue()
			{
				return OldValue as Questions;
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
		
		#region Qtype属性
			private string m_Qtype = String.Empty;
			/// <summary>
			/// 属性名称： Qtype
			/// 内容摘要： DB列名：QType[类型]
			///            DB类型：nvarchar(50)
			/// </summary>
			public string Qtype
			{
				get
					{
						return m_Qtype;
					}
				set
					{
						if (m_Qtype as object == null || !m_Qtype.Equals(value))
						{
							m_Qtype = value;
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
		
		#region Status属性
			private int m_Status = 0;
			/// <summary>
			/// 属性名称： Status
			/// 内容摘要： DB列名：Status[1=有解答,0待解决,2=已解决]
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
		
		#region Showidx属性
			private int m_Showidx = 0;
			/// <summary>
			/// 属性名称： Showidx
			/// 内容摘要： DB列名：ShowIdx[排序]
			///            DB类型：int
			/// </summary>
			public int Showidx
			{
				get
					{
						return m_Showidx;
					}
				set
					{
						if (m_Showidx as object == null || !m_Showidx.Equals(value))
						{
							m_Showidx = value;
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
		
		#region Owner属性
			private string m_Owner = String.Empty;
			/// <summary>
			/// 属性名称： Owner
			/// 内容摘要： DB列名：Owner[]
			///            DB类型：nvarchar(50)
			/// </summary>
			public string Owner
			{
				get
					{
						return m_Owner;
					}
				set
					{
						if (m_Owner as object == null || !m_Owner.Equals(value))
						{
							m_Owner = value;
							MarkUpdated();
						}						
					}
			}
		#endregion
		
		#region Siteid属性
			private string m_Siteid = String.Empty;
			/// <summary>
			/// 属性名称： Siteid
			/// 内容摘要： DB列名：Siteid[]
			///            DB类型：nvarchar(50)
			/// </summary>
			public string Siteid
			{
				get
					{
						return m_Siteid;
					}
				set
					{
						if (m_Siteid as object == null || !m_Siteid.Equals(value))
						{
							m_Siteid = value;
							MarkUpdated();
						}						
					}
			}
		#endregion
		
		#region Cityid属性
			private string m_Cityid = String.Empty;
			/// <summary>
			/// 属性名称： Cityid
			/// 内容摘要： DB列名：Cityid[]
			///            DB类型：nvarchar(50)
			/// </summary>
			public string Cityid
			{
				get
					{
						return m_Cityid;
					}
				set
					{
						if (m_Cityid as object == null || !m_Cityid.Equals(value))
						{
							m_Cityid = value;
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
					dtResult.Columns.Add(new DataColumn("Title",typeof(string)));
					dtResult.Columns.Add(new DataColumn("QType",typeof(string)));
					dtResult.Columns.Add(new DataColumn("Content",typeof(string)));
					dtResult.Columns.Add(new DataColumn("Status",typeof(int)));
					dtResult.Columns.Add(new DataColumn("CREATOR",typeof(string)));
					dtResult.Columns.Add(new DataColumn("CREATE_DATE",typeof(DateTime)));
					dtResult.Columns.Add(new DataColumn("ShowIdx",typeof(int)));
					dtResult.Columns.Add(new DataColumn("ViewTimes",typeof(int)));
					dtResult.Columns.Add(new DataColumn("Owner",typeof(string)));
					dtResult.Columns.Add(new DataColumn("Siteid",typeof(string)));
					dtResult.Columns.Add(new DataColumn("Cityid",typeof(string)));
					dtResult.Columns.Add(new DataColumn("JingQuCode",typeof(string)));
				}
				else if (cne == ColumnNameEnum.PropertyName)
				{
					dtResult.Columns.Add(new DataColumn("Seqno",typeof(int)));
					dtResult.Columns.Add(new DataColumn("Guid",typeof(string)));
					dtResult.Columns.Add(new DataColumn("Title",typeof(string)));
					dtResult.Columns.Add(new DataColumn("Qtype",typeof(string)));
					dtResult.Columns.Add(new DataColumn("Content",typeof(string)));
					dtResult.Columns.Add(new DataColumn("Status",typeof(int)));
					dtResult.Columns.Add(new DataColumn("Creator",typeof(string)));
					dtResult.Columns.Add(new DataColumn("CreateDate",typeof(DateTime)));
					dtResult.Columns.Add(new DataColumn("Showidx",typeof(int)));
					dtResult.Columns.Add(new DataColumn("Viewtimes",typeof(int)));
					dtResult.Columns.Add(new DataColumn("Owner",typeof(string)));
					dtResult.Columns.Add(new DataColumn("Siteid",typeof(string)));
					dtResult.Columns.Add(new DataColumn("Cityid",typeof(string)));
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
					dr["Title"] = this.Title;
					dr["QType"] = this.Qtype;
					dr["Content"] = this.Content;
					dr["Status"] = this.Status;
					dr["CREATOR"] = this.Creator;
					dr["CREATE_DATE"] = this.CreateDate;
					dr["ShowIdx"] = this.Showidx;
					dr["ViewTimes"] = this.Viewtimes;
					dr["Owner"] = this.Owner;
					dr["Siteid"] = this.Siteid;
					dr["Cityid"] = this.Cityid;
					dr["JingQuCode"] = this.Jingqucode;
				}
				else if (ColumnNameEnum.PropertyName == cne)
				{
					dr["Seqno"] = this.Seqno;
					dr["Guid"] = this.Guid;
					dr["Title"] = this.Title;
					dr["Qtype"] = this.Qtype;
					dr["Content"] = this.Content;
					dr["Status"] = this.Status;
					dr["Creator"] = this.Creator;
					dr["CreateDate"] = this.CreateDate;
					dr["Showidx"] = this.Showidx;
					dr["Viewtimes"] = this.Viewtimes;
					dr["Owner"] = this.Owner;
					dr["Siteid"] = this.Siteid;
					dr["Cityid"] = this.Cityid;
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
			/// 将DataRow转换成Questions对象
			/// </summary>
			/// <param name="dr">由CreateTable生成的DataTable通过NewRow得到的DataRow对象</param>
			/// <param name="cne">dr的列名映射方式:DB列名或属性名</param>
			/// <returns>Questions对象</returns>
			public static Questions Dr2Obj(DataRow dr,ColumnNameEnum cne)
			{
				if (dr == null)
				{
					throw new ArgumentNullException("dr");
				}
				Questions obj = new Questions();
				if (ColumnNameEnum.DBName == cne)
				{
					obj.Seqno = (dr["Seqno"] == Convert.DBNull) ? 0  : (int)Convert.ChangeType(dr["Seqno"],typeof(int));
					obj.Guid = (dr["GUID"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["GUID"],typeof(string));
					obj.Title = (dr["Title"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Title"],typeof(string));
					obj.Qtype = (dr["QType"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["QType"],typeof(string));
					obj.Content = (dr["Content"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Content"],typeof(string));
					obj.Status = (dr["Status"] == Convert.DBNull) ? 0  : (int)Convert.ChangeType(dr["Status"],typeof(int));
					obj.Creator = (dr["CREATOR"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["CREATOR"],typeof(string));
					obj.CreateDate = (dr["CREATE_DATE"] == Convert.DBNull) ? new DateTime(1900,1,1)  : (DateTime)Convert.ChangeType(dr["CREATE_DATE"],typeof(DateTime));
					obj.Showidx = (dr["ShowIdx"] == Convert.DBNull) ? 0  : (int)Convert.ChangeType(dr["ShowIdx"],typeof(int));
					obj.Viewtimes = (dr["ViewTimes"] == Convert.DBNull) ? 0  : (int)Convert.ChangeType(dr["ViewTimes"],typeof(int));
					obj.Owner = (dr["Owner"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Owner"],typeof(string));
					obj.Siteid = (dr["Siteid"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Siteid"],typeof(string));
					obj.Cityid = (dr["Cityid"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Cityid"],typeof(string));
					obj.Jingqucode = (dr["JingQuCode"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["JingQuCode"],typeof(string));
				}
				else if (ColumnNameEnum.PropertyName == cne)
				{
					obj.Seqno = (dr["Seqno"] == Convert.DBNull) ? 0  : (int)Convert.ChangeType(dr["Seqno"],typeof(int));
					obj.Guid = (dr["Guid"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Guid"],typeof(string));
					obj.Title = (dr["Title"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Title"],typeof(string));
					obj.Qtype = (dr["Qtype"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Qtype"],typeof(string));
					obj.Content = (dr["Content"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Content"],typeof(string));
					obj.Status = (dr["Status"] == Convert.DBNull) ? 0  : (int)Convert.ChangeType(dr["Status"],typeof(int));
					obj.Creator = (dr["Creator"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Creator"],typeof(string));
					obj.CreateDate = (dr["CreateDate"] == Convert.DBNull) ? new DateTime(1900,1,1)  : (DateTime)Convert.ChangeType(dr["CreateDate"],typeof(DateTime));
					obj.Showidx = (dr["Showidx"] == Convert.DBNull) ? 0  : (int)Convert.ChangeType(dr["Showidx"],typeof(int));
					obj.Viewtimes = (dr["Viewtimes"] == Convert.DBNull) ? 0  : (int)Convert.ChangeType(dr["Viewtimes"],typeof(int));
					obj.Owner = (dr["Owner"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Owner"],typeof(string));
					obj.Siteid = (dr["Siteid"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Siteid"],typeof(string));
					obj.Cityid = (dr["Cityid"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Cityid"],typeof(string));
					obj.Jingqucode = (dr["Jingqucode"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Jingqucode"],typeof(string));		
				}
				
				return obj;
			}
			
			/// <summary>
			/// 将DataRow转换成Questions对象(默认列名映射为属性名)
			/// </summary>
			/// <returns>Questions对象</returns>
			public static Questions Dr2Obj(DataRow dr)
			{
				return Dr2Obj(dr,ColumnNameEnum.DBName);
			}
			
			/// <summary>
			/// 将DataTabe转换成的Questions对象集合
			/// </summary>
			/// <param name="dt">由CreateTable生成的DataTable</param>
			/// <param name="cne">dt的列名映射方式:DB列名或属性名</param>
			/// <returns>Questions对象的集合</returns>
			public static List<Questions>  Dt2Objs(DataTable dt,ColumnNameEnum cne)
			{
				if (dt == null)
				{
					throw new ArgumentNullException("dt");
				}
				
				 
				List<Questions> alResult = new List<Questions>();
				
				foreach(DataRow dr in dt.Rows)
				{
					alResult.Add(Dr2Obj(dr,cne));
				}
				
				return alResult;
			}

			/// <summary>
			/// 将DataTabe转换成的Questions对象集合(默认列名映射为属性名)
			/// </summary>
			/// <param name="dt">由CreateTable生成的DataTable</param>
			/// <returns>Questions对象的集合</returns>
			public static List<Questions> Dt2Objs(DataTable dt)
			{
				return Dt2Objs(dt,ColumnNameEnum.DBName);
			}
			
			/// <summary>
			/// 用objs的Questions对象集合填充DataTable
			/// </summary>
			/// <param name="dt">由CreateTable生成的DataTable</param>
			/// <param name="objs">Questions对象集合</param>
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
				
				foreach(Questions obj in objs)
				{
					DataRow dr = dt.NewRow();
					obj.FillDataRow(dr,cne);
					dt.Rows.Add(dr);
				}
			}

			/// <summary>
			/// 用objs的Questions对象集合填充DataTable(默认列名映射为属性名)
			/// </summary>
			/// <param name="dt">由CreateTable生成的DataTable</param>
			/// <param name="objs">Questions对象集合</param>
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
			Questions old = this.OldValue as Questions;
			if (old != null)
			{
					this.Seqno = old.Seqno;
					this.Guid = old.Guid;
					this.Title = old.Title;
					this.Qtype = old.Qtype;
					this.Content = old.Content;
					this.Status = old.Status;
					this.Creator = old.Creator;
					this.CreateDate = old.CreateDate;
					this.Showidx = old.Showidx;
					this.Viewtimes = old.Viewtimes;
					this.Owner = old.Owner;
					this.Siteid = old.Siteid;
					this.Cityid = old.Cityid;
					this.Jingqucode = old.Jingqucode;				
				this.OldValue = null;
			}
		}
		
		
		
		
		#region Questions实体的内部Key类
			/// <summary>
			/// Questions实体的Key类
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
			/// 得到实体Questions的PK
			/// </summary>
			public Key GetKey()
			{
				return new Key(Seqno);				
			}
	
		
		#endregion
	}
}
