/*
版权所有：版权所有(C) 2011，中兴通讯
文件编号：M01_Module.cs
文件名称：Module.cs
系统编号：Z0003007
系统名称：通用办公系统
模块编号：M01
模块名称：信息发布
设计文档：IOA_M01信息发布XDE建模.mdx
完成日期：2011-10-25
作　　者：
内容摘要：表[Module]对应的实体类
*/

using System;
using System.Collections;
using System.Data;


namespace dx177.Model.Bus
{
		/// <summary>
		/// 类 编 号：
		/// 类 名 称：Module
		/// 内容摘要：
		/// </summary>
		
		[Serializable]
		public class Module : BaseModel
		{
		#region 自动生成代码
		
			#region 重载Equals/GetHashCode
			/// <summary>
			/// 重载Equals			
			/// </summary>
			public override bool Equals (Object obj)
			{
				if (obj != null && obj is Module)
				{
					if (obj == this)
						return true;
					Module castObj = (Module)obj; 
					
					if (!this.m_Seqno.Equals(castObj.Seqno))
						return false;
						
					if (!this.m_Pguid.Equals(castObj.Pguid))
						return false;
						
					if (!this.m_Modulecode.Equals(castObj.Modulecode))
						return false;
						
					if (!this.m_Showidx.Equals(castObj.Showidx))
						return false;
						
					if (!this.m_Title.Equals(castObj.Title))
						return false;
						
					if (!this.m_Imgfile.Equals(castObj.Imgfile))
						return false;
						
					if (!this.m_Shortdescrt.Equals(castObj.Shortdescrt))
						return false;
						
					if (!this.m_Link.Equals(castObj.Link))
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
					if ((object)m_Modulecode != null)
					{
						hash = hash ^ m_Modulecode.GetHashCode();
					}
						
					hash = hash <<  8;
					if ((object)m_Showidx != null)
					{
						hash = hash ^ m_Showidx.GetHashCode();
					}
						
					hash = hash <<  8;
					if ((object)m_Title != null)
					{
						hash = hash ^ m_Title.GetHashCode();
					}
						
					hash = hash <<  8;
					if ((object)m_Imgfile != null)
					{
						hash = hash ^ m_Imgfile.GetHashCode();
					}
						
					hash = hash <<  8;
					if ((object)m_Shortdescrt != null)
					{
						hash = hash ^ m_Shortdescrt.GetHashCode();
					}
						
					hash = hash <<  8;
					if ((object)m_Link != null)
					{
						hash = hash ^ m_Link.GetHashCode();
					}
						
					return hash; 
			}
			#endregion
			
			public Module()
			{
				MarkNew();
			}						
			
			public Module GetOldValue()
			{
				return OldValue as Module;
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
		
		#region Modulecode属性
			private string m_Modulecode = String.Empty;
			/// <summary>
			/// 属性名称： Modulecode
			/// 内容摘要： DB列名：ModuleCode[类型]
			///            DB类型：nvarchar(50)
			/// </summary>
			public string Modulecode
			{
				get
					{
						return m_Modulecode;
					}
				set
					{
						if (m_Modulecode as object == null || !m_Modulecode.Equals(value))
						{
							m_Modulecode = value;
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
		
		#region Title属性
			private string m_Title = String.Empty;
			/// <summary>
			/// 属性名称： Title
			/// 内容摘要： DB列名：Title[]
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
		
		#region Imgfile属性
			private string m_Imgfile = String.Empty;
			/// <summary>
			/// 属性名称： Imgfile
			/// 内容摘要： DB列名：ImgFile[]
			///            DB类型：nvarchar(50)
			/// </summary>
			public string Imgfile
			{
				get
					{
						return m_Imgfile;
					}
				set
					{
						if (m_Imgfile as object == null || !m_Imgfile.Equals(value))
						{
							m_Imgfile = value;
							MarkUpdated();
						}						
					}
			}
		#endregion
		
		#region Shortdescrt属性
			private string m_Shortdescrt = String.Empty;
			/// <summary>
			/// 属性名称： Shortdescrt
			/// 内容摘要： DB列名：ShortDescrt[]
			///            DB类型：nvarchar(1000)
			/// </summary>
			public string Shortdescrt
			{
				get
					{
						return m_Shortdescrt;
					}
				set
					{
						if (m_Shortdescrt as object == null || !m_Shortdescrt.Equals(value))
						{
							m_Shortdescrt = value;
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
			///            DB类型：nvarchar(200)
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
					dtResult.Columns.Add(new DataColumn("ModuleCode",typeof(string)));
					dtResult.Columns.Add(new DataColumn("ShowIdx",typeof(int)));
					dtResult.Columns.Add(new DataColumn("Title",typeof(string)));
					dtResult.Columns.Add(new DataColumn("ImgFile",typeof(string)));
					dtResult.Columns.Add(new DataColumn("ShortDescrt",typeof(string)));
					dtResult.Columns.Add(new DataColumn("Link",typeof(string)));
				}
				else if (cne == ColumnNameEnum.PropertyName)
				{
					dtResult.Columns.Add(new DataColumn("Seqno",typeof(int)));
					dtResult.Columns.Add(new DataColumn("Pguid",typeof(string)));
					dtResult.Columns.Add(new DataColumn("Modulecode",typeof(string)));
					dtResult.Columns.Add(new DataColumn("Showidx",typeof(int)));
					dtResult.Columns.Add(new DataColumn("Title",typeof(string)));
					dtResult.Columns.Add(new DataColumn("Imgfile",typeof(string)));
					dtResult.Columns.Add(new DataColumn("Shortdescrt",typeof(string)));
					dtResult.Columns.Add(new DataColumn("Link",typeof(string)));
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
					dr["ModuleCode"] = this.Modulecode;
					dr["ShowIdx"] = this.Showidx;
					dr["Title"] = this.Title;
					dr["ImgFile"] = this.Imgfile;
					dr["ShortDescrt"] = this.Shortdescrt;
					dr["Link"] = this.Link;
				}
				else if (ColumnNameEnum.PropertyName == cne)
				{
					dr["Seqno"] = this.Seqno;
					dr["Pguid"] = this.Pguid;
					dr["Modulecode"] = this.Modulecode;
					dr["Showidx"] = this.Showidx;
					dr["Title"] = this.Title;
					dr["Imgfile"] = this.Imgfile;
					dr["Shortdescrt"] = this.Shortdescrt;
					dr["Link"] = this.Link;					
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
			/// 将DataRow转换成Module对象
			/// </summary>
			/// <param name="dr">由CreateTable生成的DataTable通过NewRow得到的DataRow对象</param>
			/// <param name="cne">dr的列名映射方式:DB列名或属性名</param>
			/// <returns>Module对象</returns>
			public static Module Dr2Obj(DataRow dr,ColumnNameEnum cne)
			{
				if (dr == null)
				{
					throw new ArgumentNullException("dr");
				}
				Module obj = new Module();
				if (ColumnNameEnum.DBName == cne)
				{
					obj.Seqno = (dr["Seqno"] == Convert.DBNull) ? 0  : (int)Convert.ChangeType(dr["Seqno"],typeof(int));
					obj.Pguid = (dr["PGUID"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["PGUID"],typeof(string));
					obj.Modulecode = (dr["ModuleCode"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["ModuleCode"],typeof(string));
					obj.Showidx = (dr["ShowIdx"] == Convert.DBNull) ? 0  : (int)Convert.ChangeType(dr["ShowIdx"],typeof(int));
					obj.Title = (dr["Title"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Title"],typeof(string));
					obj.Imgfile = (dr["ImgFile"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["ImgFile"],typeof(string));
					obj.Shortdescrt = (dr["ShortDescrt"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["ShortDescrt"],typeof(string));
					obj.Link = (dr["Link"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Link"],typeof(string));
				}
				else if (ColumnNameEnum.PropertyName == cne)
				{
					obj.Seqno = (dr["Seqno"] == Convert.DBNull) ? 0  : (int)Convert.ChangeType(dr["Seqno"],typeof(int));
					obj.Pguid = (dr["Pguid"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Pguid"],typeof(string));
					obj.Modulecode = (dr["Modulecode"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Modulecode"],typeof(string));
					obj.Showidx = (dr["Showidx"] == Convert.DBNull) ? 0  : (int)Convert.ChangeType(dr["Showidx"],typeof(int));
					obj.Title = (dr["Title"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Title"],typeof(string));
					obj.Imgfile = (dr["Imgfile"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Imgfile"],typeof(string));
					obj.Shortdescrt = (dr["Shortdescrt"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Shortdescrt"],typeof(string));
					obj.Link = (dr["Link"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Link"],typeof(string));		
				}
				
				return obj;
			}
			
			/// <summary>
			/// 将DataRow转换成Module对象(默认列名映射为属性名)
			/// </summary>
			/// <returns>Module对象</returns>
			public static Module Dr2Obj(DataRow dr)
			{
				return Dr2Obj(dr,ColumnNameEnum.DBName);
			}
			
			/// <summary>
			/// 将DataTabe转换成的Module对象集合
			/// </summary>
			/// <param name="dt">由CreateTable生成的DataTable</param>
			/// <param name="cne">dt的列名映射方式:DB列名或属性名</param>
			/// <returns>Module对象的集合</returns>
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
			/// 将DataTabe转换成的Module对象集合(默认列名映射为属性名)
			/// </summary>
			/// <param name="dt">由CreateTable生成的DataTable</param>
			/// <returns>Module对象的集合</returns>
			public static IList Dt2Objs(DataTable dt)
			{
				return Dt2Objs(dt,ColumnNameEnum.DBName);
			}
			
			/// <summary>
			/// 用objs的Module对象集合填充DataTable
			/// </summary>
			/// <param name="dt">由CreateTable生成的DataTable</param>
			/// <param name="objs">Module对象集合</param>
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
				
				foreach(Module obj in objs)
				{
					DataRow dr = dt.NewRow();
					obj.FillDataRow(dr,cne);
					dt.Rows.Add(dr);
				}
			}

			/// <summary>
			/// 用objs的Module对象集合填充DataTable(默认列名映射为属性名)
			/// </summary>
			/// <param name="dt">由CreateTable生成的DataTable</param>
			/// <param name="objs">Module对象集合</param>
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
			Module old = this.OldValue as Module;
			if (old != null)
			{
					this.Seqno = old.Seqno;
					this.Pguid = old.Pguid;
					this.Modulecode = old.Modulecode;
					this.Showidx = old.Showidx;
					this.Title = old.Title;
					this.Imgfile = old.Imgfile;
					this.Shortdescrt = old.Shortdescrt;
					this.Link = old.Link;				
				this.OldValue = null;
			}
		}
		
		
		
		
		#region Module实体的内部Key类
			/// <summary>
			/// Module实体的Key类
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
			/// 得到实体Module的PK
			/// </summary>
			public Key GetKey()
			{
				return new Key(Seqno);				
			}
	
		
		#endregion
	}
}
