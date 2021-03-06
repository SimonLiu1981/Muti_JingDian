/*
版权所有：版权所有(C) 2012，中兴通讯
文件编号：M01_Friendlink.cs
文件名称：Friendlink.cs
系统编号：Z0003007
系统名称：通用办公系统
模块编号：M01
模块名称：信息发布
设计文档：IOA_M01信息发布XDE建模.mdx
完成日期：2012/6/22
作　　者：
内容摘要：表[FriendLink]对应的实体类
*/

using System;
using System.Collections;
using System.Data;
using System.Collections.Generic;


namespace dx177.Model.Bus
{
		/// <summary>
		/// 类 编 号：
		/// 类 名 称：Friendlink
		/// 内容摘要：
		/// </summary>
		
		[Serializable]
		public class Friendlink : BaseModel
		{
		#region 自动生成代码
		
			#region 重载Equals/GetHashCode
			/// <summary>
			/// 重载Equals			
			/// </summary>
			public override bool Equals (Object obj)
			{
				if (obj != null && obj is Friendlink)
				{
					if (obj == this)
						return true;
					Friendlink castObj = (Friendlink)obj; 
					
					if (!this.m_Seqno.Equals(castObj.Seqno))
						return false;
						
					if (!this.m_Guid.Equals(castObj.Guid))
						return false;
						
					if (!this.m_Title.Equals(castObj.Title))
						return false;
						
					if (!this.m_Showcontent.Equals(castObj.Showcontent))
						return false;
						
					if (!this.m_Logo.Equals(castObj.Logo))
						return false;
						
					if (!this.m_Type.Equals(castObj.Type))
						return false;
						
					if (!this.m_CreateDate.Equals(castObj.CreateDate))
						return false;
						
					if (!this.m_Showidx.Equals(castObj.Showidx))
						return false;
						
					if (!this.m_Creator.Equals(castObj.Creator))
						return false;
						
					if (!this.m_Link.Equals(castObj.Link))
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
					if ((object)m_Showcontent != null)
					{
						hash = hash ^ m_Showcontent.GetHashCode();
					}
						
					hash = hash <<  8;
					if ((object)m_Logo != null)
					{
						hash = hash ^ m_Logo.GetHashCode();
					}
						
					hash = hash <<  8;
					if ((object)m_Type != null)
					{
						hash = hash ^ m_Type.GetHashCode();
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
					if ((object)m_Creator != null)
					{
						hash = hash ^ m_Creator.GetHashCode();
					}
						
					hash = hash <<  8;
					if ((object)m_Link != null)
					{
						hash = hash ^ m_Link.GetHashCode();
					}
						
					hash = hash <<  8;
					if ((object)m_Jingqucode != null)
					{
						hash = hash ^ m_Jingqucode.GetHashCode();
					}
						
					return hash; 
			}
			#endregion
			
			public Friendlink()
			{
				MarkNew();
			}						
			
			public Friendlink GetOldValue()
			{
				return OldValue as Friendlink;
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
		
		#region Showcontent属性
			private string m_Showcontent = String.Empty;
			/// <summary>
			/// 属性名称： Showcontent
			/// 内容摘要： DB列名：ShowContent[简述]
			///            DB类型：nvarchar(255)
			/// </summary>
			public string Showcontent
			{
				get
					{
						return m_Showcontent;
					}
				set
					{
						if (m_Showcontent as object == null || !m_Showcontent.Equals(value))
						{
							m_Showcontent = value;
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
		
		#region Type属性
			private string m_Type = String.Empty;
			/// <summary>
			/// 属性名称： Type
			/// 内容摘要： DB列名：Type[类型]
			///            DB类型：nvarchar(50)
			/// </summary>
			public string Type
			{
				get
					{
						return m_Type;
					}
				set
					{
						if (m_Type as object == null || !m_Type.Equals(value))
						{
							m_Type = value;
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
			/// 内容摘要： DB列名：ShowIdx[顺序]
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
		
		#region Link属性
			private string m_Link = String.Empty;
			/// <summary>
			/// 属性名称： Link
			/// 内容摘要： DB列名：Link[]
			///            DB类型：nvarchar(255)
			/// </summary>
			public string Link
			{
				get
					{
						return m_Link;
					}
				set
					{
						if (m_Link as object == null || !m_Link.Equals(value))
						{
							m_Link = value;
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
					dtResult.Columns.Add(new DataColumn("ShowContent",typeof(string)));
					dtResult.Columns.Add(new DataColumn("Logo",typeof(string)));
					dtResult.Columns.Add(new DataColumn("Type",typeof(string)));
					dtResult.Columns.Add(new DataColumn("CREATE_DATE",typeof(DateTime)));
					dtResult.Columns.Add(new DataColumn("ShowIdx",typeof(int)));
					dtResult.Columns.Add(new DataColumn("CREATOR",typeof(string)));
					dtResult.Columns.Add(new DataColumn("Link",typeof(string)));
					dtResult.Columns.Add(new DataColumn("JingQuCode",typeof(string)));
				}
				else if (cne == ColumnNameEnum.PropertyName)
				{
					dtResult.Columns.Add(new DataColumn("Seqno",typeof(int)));
					dtResult.Columns.Add(new DataColumn("Guid",typeof(string)));
					dtResult.Columns.Add(new DataColumn("Title",typeof(string)));
					dtResult.Columns.Add(new DataColumn("Showcontent",typeof(string)));
					dtResult.Columns.Add(new DataColumn("Logo",typeof(string)));
					dtResult.Columns.Add(new DataColumn("Type",typeof(string)));
					dtResult.Columns.Add(new DataColumn("CreateDate",typeof(DateTime)));
					dtResult.Columns.Add(new DataColumn("Showidx",typeof(int)));
					dtResult.Columns.Add(new DataColumn("Creator",typeof(string)));
					dtResult.Columns.Add(new DataColumn("Link",typeof(string)));
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
					dr["ShowContent"] = this.Showcontent;
					dr["Logo"] = this.Logo;
					dr["Type"] = this.Type;
					dr["CREATE_DATE"] = this.CreateDate;
					dr["ShowIdx"] = this.Showidx;
					dr["CREATOR"] = this.Creator;
					dr["Link"] = this.Link;
					dr["JingQuCode"] = this.Jingqucode;
				}
				else if (ColumnNameEnum.PropertyName == cne)
				{
					dr["Seqno"] = this.Seqno;
					dr["Guid"] = this.Guid;
					dr["Title"] = this.Title;
					dr["Showcontent"] = this.Showcontent;
					dr["Logo"] = this.Logo;
					dr["Type"] = this.Type;
					dr["CreateDate"] = this.CreateDate;
					dr["Showidx"] = this.Showidx;
					dr["Creator"] = this.Creator;
					dr["Link"] = this.Link;
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
			/// 将DataRow转换成Friendlink对象
			/// </summary>
			/// <param name="dr">由CreateTable生成的DataTable通过NewRow得到的DataRow对象</param>
			/// <param name="cne">dr的列名映射方式:DB列名或属性名</param>
			/// <returns>Friendlink对象</returns>
			public static Friendlink Dr2Obj(DataRow dr,ColumnNameEnum cne)
			{
				if (dr == null)
				{
					throw new ArgumentNullException("dr");
				}
				Friendlink obj = new Friendlink();
				if (ColumnNameEnum.DBName == cne)
				{
					obj.Seqno = (dr["Seqno"] == Convert.DBNull) ? 0  : (int)Convert.ChangeType(dr["Seqno"],typeof(int));
					obj.Guid = (dr["GUID"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["GUID"],typeof(string));
					obj.Title = (dr["Title"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Title"],typeof(string));
					obj.Showcontent = (dr["ShowContent"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["ShowContent"],typeof(string));
					obj.Logo = (dr["Logo"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Logo"],typeof(string));
					obj.Type = (dr["Type"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Type"],typeof(string));
					obj.CreateDate = (dr["CREATE_DATE"] == Convert.DBNull) ? new DateTime(1900,1,1)  : (DateTime)Convert.ChangeType(dr["CREATE_DATE"],typeof(DateTime));
					obj.Showidx = (dr["ShowIdx"] == Convert.DBNull) ? 0  : (int)Convert.ChangeType(dr["ShowIdx"],typeof(int));
					obj.Creator = (dr["CREATOR"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["CREATOR"],typeof(string));
					obj.Link = (dr["Link"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Link"],typeof(string));
					obj.Jingqucode = (dr["JingQuCode"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["JingQuCode"],typeof(string));
				}
				else if (ColumnNameEnum.PropertyName == cne)
				{
					obj.Seqno = (dr["Seqno"] == Convert.DBNull) ? 0  : (int)Convert.ChangeType(dr["Seqno"],typeof(int));
					obj.Guid = (dr["Guid"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Guid"],typeof(string));
					obj.Title = (dr["Title"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Title"],typeof(string));
					obj.Showcontent = (dr["Showcontent"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Showcontent"],typeof(string));
					obj.Logo = (dr["Logo"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Logo"],typeof(string));
					obj.Type = (dr["Type"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Type"],typeof(string));
					obj.CreateDate = (dr["CreateDate"] == Convert.DBNull) ? new DateTime(1900,1,1)  : (DateTime)Convert.ChangeType(dr["CreateDate"],typeof(DateTime));
					obj.Showidx = (dr["Showidx"] == Convert.DBNull) ? 0  : (int)Convert.ChangeType(dr["Showidx"],typeof(int));
					obj.Creator = (dr["Creator"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Creator"],typeof(string));
					obj.Link = (dr["Link"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Link"],typeof(string));
					obj.Jingqucode = (dr["Jingqucode"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Jingqucode"],typeof(string));		
				}
				
				return obj;
			}
			
			/// <summary>
			/// 将DataRow转换成Friendlink对象(默认列名映射为属性名)
			/// </summary>
			/// <returns>Friendlink对象</returns>
			public static Friendlink Dr2Obj(DataRow dr)
			{
				return Dr2Obj(dr,ColumnNameEnum.DBName);
			}
			
			/// <summary>
			/// 将DataTabe转换成的Friendlink对象集合
			/// </summary>
			/// <param name="dt">由CreateTable生成的DataTable</param>
			/// <param name="cne">dt的列名映射方式:DB列名或属性名</param>
			/// <returns>Friendlink对象的集合</returns>
			public static List<Friendlink>  Dt2Objs(DataTable dt,ColumnNameEnum cne)
			{
				if (dt == null)
				{
					throw new ArgumentNullException("dt");
				}
				
				 
				List<Friendlink> alResult = new List<Friendlink>();
				
				foreach(DataRow dr in dt.Rows)
				{
					alResult.Add(Dr2Obj(dr,cne));
				}
				
				return alResult;
			}

			/// <summary>
			/// 将DataTabe转换成的Friendlink对象集合(默认列名映射为属性名)
			/// </summary>
			/// <param name="dt">由CreateTable生成的DataTable</param>
			/// <returns>Friendlink对象的集合</returns>
			public static List<Friendlink> Dt2Objs(DataTable dt)
			{
				return Dt2Objs(dt,ColumnNameEnum.DBName);
			}
			
			/// <summary>
			/// 用objs的Friendlink对象集合填充DataTable
			/// </summary>
			/// <param name="dt">由CreateTable生成的DataTable</param>
			/// <param name="objs">Friendlink对象集合</param>
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
				
				foreach(Friendlink obj in objs)
				{
					DataRow dr = dt.NewRow();
					obj.FillDataRow(dr,cne);
					dt.Rows.Add(dr);
				}
			}

			/// <summary>
			/// 用objs的Friendlink对象集合填充DataTable(默认列名映射为属性名)
			/// </summary>
			/// <param name="dt">由CreateTable生成的DataTable</param>
			/// <param name="objs">Friendlink对象集合</param>
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
			Friendlink old = this.OldValue as Friendlink;
			if (old != null)
			{
					this.Seqno = old.Seqno;
					this.Guid = old.Guid;
					this.Title = old.Title;
					this.Showcontent = old.Showcontent;
					this.Logo = old.Logo;
					this.Type = old.Type;
					this.CreateDate = old.CreateDate;
					this.Showidx = old.Showidx;
					this.Creator = old.Creator;
					this.Link = old.Link;
					this.Jingqucode = old.Jingqucode;				
				this.OldValue = null;
			}
		}
		
		
		
		
		#region Friendlink实体的内部Key类
			/// <summary>
			/// Friendlink实体的Key类
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
			/// 得到实体Friendlink的PK
			/// </summary>
			public Key GetKey()
			{
				return new Key(Seqno);				
			}
	
		
		#endregion
	}
}
