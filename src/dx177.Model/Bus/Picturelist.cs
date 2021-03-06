/*
版权所有：版权所有(C) 2012，中兴通讯
文件编号：M01_Picturelist.cs
文件名称：Picturelist.cs
系统编号：Z0003007
系统名称：通用办公系统
模块编号：M01
模块名称：信息发布
设计文档：IOA_M01信息发布XDE建模.mdx
完成日期：2012/6/24
作　　者：
内容摘要：表[PictureList]对应的实体类
*/

using System;
using System.Collections;
using System.Data;
using System.Collections.Generic;


namespace dx177.Model.Bus
{
		/// <summary>
		/// 类 编 号：
		/// 类 名 称：Picturelist
		/// 内容摘要：
		/// </summary>
		
		[Serializable]
		public class Picturelist : BaseModel
		{
		#region 自动生成代码
		
			#region 重载Equals/GetHashCode
			/// <summary>
			/// 重载Equals			
			/// </summary>
			public override bool Equals (Object obj)
			{
				if (obj != null && obj is Picturelist)
				{
					if (obj == this)
						return true;
					Picturelist castObj = (Picturelist)obj; 
					
					if (!this.m_Seqno.Equals(castObj.Seqno))
						return false;
						
					if (!this.m_Pguid.Equals(castObj.Pguid))
						return false;
						
					if (!this.m_Title.Equals(castObj.Title))
						return false;
						
					if (!this.m_Bigimgfile.Equals(castObj.Bigimgfile))
						return false;
						
					if (!this.m_Showidx.Equals(castObj.Showidx))
						return false;
						
					if (!this.m_Smallimgfile.Equals(castObj.Smallimgfile))
						return false;
						
					if (!this.m_Creator.Equals(castObj.Creator))
						return false;
						
					if (!this.m_CreateDate.Equals(castObj.CreateDate))
						return false;
						
					if (!this.m_Viewtimes.Equals(castObj.Viewtimes))
						return false;
						
					if (!this.m_Descprition.Equals(castObj.Descprition))
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
					if ((object)m_Pguid != null)
					{
						hash = hash ^ m_Pguid.GetHashCode();
					}
						
					hash = hash <<  8;
					if ((object)m_Title != null)
					{
						hash = hash ^ m_Title.GetHashCode();
					}
						
					hash = hash <<  8;
					if ((object)m_Bigimgfile != null)
					{
						hash = hash ^ m_Bigimgfile.GetHashCode();
					}
						
					hash = hash <<  8;
					if ((object)m_Showidx != null)
					{
						hash = hash ^ m_Showidx.GetHashCode();
					}
						
					hash = hash <<  8;
					if ((object)m_Smallimgfile != null)
					{
						hash = hash ^ m_Smallimgfile.GetHashCode();
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
					if ((object)m_Viewtimes != null)
					{
						hash = hash ^ m_Viewtimes.GetHashCode();
					}
						
					hash = hash <<  8;
					if ((object)m_Descprition != null)
					{
						hash = hash ^ m_Descprition.GetHashCode();
					}
						
					hash = hash <<  8;
					if ((object)m_Jingqucode != null)
					{
						hash = hash ^ m_Jingqucode.GetHashCode();
					}
						
					return hash; 
			}
			#endregion
			
			public Picturelist()
			{
				MarkNew();
			}						
			
			public Picturelist GetOldValue()
			{
				return OldValue as Picturelist;
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
		
		#region Pguid属性
			private string m_Pguid = String.Empty;
			/// <summary>
			/// 属性名称： Pguid
			/// 内容摘要： DB列名：PGUID[PGUID]
			///            DB类型：nvarchar(50)
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
		
		#region Title属性
			private string m_Title = String.Empty;
			/// <summary>
			/// 属性名称： Title
			/// 内容摘要： DB列名：Title[名称]
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
		
		#region Bigimgfile属性
			private string m_Bigimgfile = String.Empty;
			/// <summary>
			/// 属性名称： Bigimgfile
			/// 内容摘要： DB列名：BigImgFile[大图片]
			///            DB类型：nvarchar(255)
			/// </summary>
			public string Bigimgfile
			{
				get
					{
						return m_Bigimgfile;
					}
				set
					{
						if (m_Bigimgfile as object == null || !m_Bigimgfile.Equals(value))
						{
							m_Bigimgfile = value;
							MarkUpdated();
						}						
					}
			}
		#endregion
		
		#region Showidx属性
			private int m_Showidx = 0;
			/// <summary>
			/// 属性名称： Showidx
			/// 内容摘要： DB列名：ShowIdx[序列]
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
		
		#region Smallimgfile属性
			private string m_Smallimgfile = String.Empty;
			/// <summary>
			/// 属性名称： Smallimgfile
			/// 内容摘要： DB列名：SmallImgFile[小图片]
			///            DB类型：nvarchar(255)
			/// </summary>
			public string Smallimgfile
			{
				get
					{
						return m_Smallimgfile;
					}
				set
					{
						if (m_Smallimgfile as object == null || !m_Smallimgfile.Equals(value))
						{
							m_Smallimgfile = value;
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
		
		#region Descprition属性
			private string m_Descprition = String.Empty;
			/// <summary>
			/// 属性名称： Descprition
			/// 内容摘要： DB列名：Descprition[]
			///            DB类型：text
			/// </summary>
			public string Descprition
			{
				get
					{
						return m_Descprition;
					}
				set
					{
						if (m_Descprition as object == null || !m_Descprition.Equals(value))
						{
							m_Descprition = value;
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
					dtResult.Columns.Add(new DataColumn("PGUID",typeof(string)));
					dtResult.Columns.Add(new DataColumn("Title",typeof(string)));
					dtResult.Columns.Add(new DataColumn("BigImgFile",typeof(string)));
					dtResult.Columns.Add(new DataColumn("ShowIdx",typeof(int)));
					dtResult.Columns.Add(new DataColumn("SmallImgFile",typeof(string)));
					dtResult.Columns.Add(new DataColumn("CREATOR",typeof(string)));
					dtResult.Columns.Add(new DataColumn("CREATE_DATE",typeof(DateTime)));
					dtResult.Columns.Add(new DataColumn("ViewTimes",typeof(int)));
					dtResult.Columns.Add(new DataColumn("Descprition",typeof(string)));
					dtResult.Columns.Add(new DataColumn("JingQuCode",typeof(string)));
				}
				else if (cne == ColumnNameEnum.PropertyName)
				{
					dtResult.Columns.Add(new DataColumn("Seqno",typeof(int)));
					dtResult.Columns.Add(new DataColumn("Pguid",typeof(string)));
					dtResult.Columns.Add(new DataColumn("Title",typeof(string)));
					dtResult.Columns.Add(new DataColumn("Bigimgfile",typeof(string)));
					dtResult.Columns.Add(new DataColumn("Showidx",typeof(int)));
					dtResult.Columns.Add(new DataColumn("Smallimgfile",typeof(string)));
					dtResult.Columns.Add(new DataColumn("Creator",typeof(string)));
					dtResult.Columns.Add(new DataColumn("CreateDate",typeof(DateTime)));
					dtResult.Columns.Add(new DataColumn("Viewtimes",typeof(int)));
					dtResult.Columns.Add(new DataColumn("Descprition",typeof(string)));
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
					dr["PGUID"] = this.Pguid;
					dr["Title"] = this.Title;
					dr["BigImgFile"] = this.Bigimgfile;
					dr["ShowIdx"] = this.Showidx;
					dr["SmallImgFile"] = this.Smallimgfile;
					dr["CREATOR"] = this.Creator;
					dr["CREATE_DATE"] = this.CreateDate;
					dr["ViewTimes"] = this.Viewtimes;
					dr["Descprition"] = this.Descprition;
					dr["JingQuCode"] = this.Jingqucode;
				}
				else if (ColumnNameEnum.PropertyName == cne)
				{
					dr["Seqno"] = this.Seqno;
					dr["Pguid"] = this.Pguid;
					dr["Title"] = this.Title;
					dr["Bigimgfile"] = this.Bigimgfile;
					dr["Showidx"] = this.Showidx;
					dr["Smallimgfile"] = this.Smallimgfile;
					dr["Creator"] = this.Creator;
					dr["CreateDate"] = this.CreateDate;
					dr["Viewtimes"] = this.Viewtimes;
					dr["Descprition"] = this.Descprition;
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
			/// 将DataRow转换成Picturelist对象
			/// </summary>
			/// <param name="dr">由CreateTable生成的DataTable通过NewRow得到的DataRow对象</param>
			/// <param name="cne">dr的列名映射方式:DB列名或属性名</param>
			/// <returns>Picturelist对象</returns>
			public static Picturelist Dr2Obj(DataRow dr,ColumnNameEnum cne)
			{
				if (dr == null)
				{
					throw new ArgumentNullException("dr");
				}
				Picturelist obj = new Picturelist();
				if (ColumnNameEnum.DBName == cne)
				{
					obj.Seqno = (dr["Seqno"] == Convert.DBNull) ? 0  : (int)Convert.ChangeType(dr["Seqno"],typeof(int));
					obj.Pguid = (dr["PGUID"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["PGUID"],typeof(string));
					obj.Title = (dr["Title"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Title"],typeof(string));
					obj.Bigimgfile = (dr["BigImgFile"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["BigImgFile"],typeof(string));
					obj.Showidx = (dr["ShowIdx"] == Convert.DBNull) ? 0  : (int)Convert.ChangeType(dr["ShowIdx"],typeof(int));
					obj.Smallimgfile = (dr["SmallImgFile"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["SmallImgFile"],typeof(string));
					obj.Creator = (dr["CREATOR"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["CREATOR"],typeof(string));
					obj.CreateDate = (dr["CREATE_DATE"] == Convert.DBNull) ? new DateTime(1900,1,1)  : (DateTime)Convert.ChangeType(dr["CREATE_DATE"],typeof(DateTime));
					obj.Viewtimes = (dr["ViewTimes"] == Convert.DBNull) ? 0  : (int)Convert.ChangeType(dr["ViewTimes"],typeof(int));
					obj.Descprition = (dr["Descprition"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Descprition"],typeof(string));
					obj.Jingqucode = (dr["JingQuCode"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["JingQuCode"],typeof(string));
				}
				else if (ColumnNameEnum.PropertyName == cne)
				{
					obj.Seqno = (dr["Seqno"] == Convert.DBNull) ? 0  : (int)Convert.ChangeType(dr["Seqno"],typeof(int));
					obj.Pguid = (dr["Pguid"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Pguid"],typeof(string));
					obj.Title = (dr["Title"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Title"],typeof(string));
					obj.Bigimgfile = (dr["Bigimgfile"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Bigimgfile"],typeof(string));
					obj.Showidx = (dr["Showidx"] == Convert.DBNull) ? 0  : (int)Convert.ChangeType(dr["Showidx"],typeof(int));
					obj.Smallimgfile = (dr["Smallimgfile"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Smallimgfile"],typeof(string));
					obj.Creator = (dr["Creator"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Creator"],typeof(string));
					obj.CreateDate = (dr["CreateDate"] == Convert.DBNull) ? new DateTime(1900,1,1)  : (DateTime)Convert.ChangeType(dr["CreateDate"],typeof(DateTime));
					obj.Viewtimes = (dr["Viewtimes"] == Convert.DBNull) ? 0  : (int)Convert.ChangeType(dr["Viewtimes"],typeof(int));
					obj.Descprition = (dr["Descprition"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Descprition"],typeof(string));
					obj.Jingqucode = (dr["Jingqucode"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Jingqucode"],typeof(string));		
				}
				
				return obj;
			}
			
			/// <summary>
			/// 将DataRow转换成Picturelist对象(默认列名映射为属性名)
			/// </summary>
			/// <returns>Picturelist对象</returns>
			public static Picturelist Dr2Obj(DataRow dr)
			{
				return Dr2Obj(dr,ColumnNameEnum.DBName);
			}
			
			/// <summary>
			/// 将DataTabe转换成的Picturelist对象集合
			/// </summary>
			/// <param name="dt">由CreateTable生成的DataTable</param>
			/// <param name="cne">dt的列名映射方式:DB列名或属性名</param>
			/// <returns>Picturelist对象的集合</returns>
			public static List<Picturelist>  Dt2Objs(DataTable dt,ColumnNameEnum cne)
			{
				if (dt == null)
				{
					throw new ArgumentNullException("dt");
				}
				
				 
				List<Picturelist> alResult = new List<Picturelist>();
				
				foreach(DataRow dr in dt.Rows)
				{
					alResult.Add(Dr2Obj(dr,cne));
				}
				
				return alResult;
			}

			/// <summary>
			/// 将DataTabe转换成的Picturelist对象集合(默认列名映射为属性名)
			/// </summary>
			/// <param name="dt">由CreateTable生成的DataTable</param>
			/// <returns>Picturelist对象的集合</returns>
			public static List<Picturelist> Dt2Objs(DataTable dt)
			{
				return Dt2Objs(dt,ColumnNameEnum.DBName);
			}
			
			/// <summary>
			/// 用objs的Picturelist对象集合填充DataTable
			/// </summary>
			/// <param name="dt">由CreateTable生成的DataTable</param>
			/// <param name="objs">Picturelist对象集合</param>
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
				
				foreach(Picturelist obj in objs)
				{
					DataRow dr = dt.NewRow();
					obj.FillDataRow(dr,cne);
					dt.Rows.Add(dr);
				}
			}

			/// <summary>
			/// 用objs的Picturelist对象集合填充DataTable(默认列名映射为属性名)
			/// </summary>
			/// <param name="dt">由CreateTable生成的DataTable</param>
			/// <param name="objs">Picturelist对象集合</param>
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
			Picturelist old = this.OldValue as Picturelist;
			if (old != null)
			{
					this.Seqno = old.Seqno;
					this.Pguid = old.Pguid;
					this.Title = old.Title;
					this.Bigimgfile = old.Bigimgfile;
					this.Showidx = old.Showidx;
					this.Smallimgfile = old.Smallimgfile;
					this.Creator = old.Creator;
					this.CreateDate = old.CreateDate;
					this.Viewtimes = old.Viewtimes;
					this.Descprition = old.Descprition;
					this.Jingqucode = old.Jingqucode;				
				this.OldValue = null;
			}
		}
		
		
		
		
		#region Picturelist实体的内部Key类
			/// <summary>
			/// Picturelist实体的Key类
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
			/// 得到实体Picturelist的PK
			/// </summary>
			public Key GetKey()
			{
				return new Key(Seqno);				
			}
	
		
		#endregion
	}
}
