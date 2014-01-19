/*
版权所有：版权所有(C) 2011，刘建新
文件编号：M01_Cookbook.cs
文件名称：Cookbook.cs
系统编号：Z0003007
系统名称：通用办公系统
模块编号：M01
模块名称：信息发布
设计文档：IOA_M01信息发布XDE建模.mdx
完成日期：2011/3/24
作　　者：
内容摘要：表[Cookbook]对应的实体类
*/

using System;
using System.Collections;
using System.Data;
using System.Collections.Generic;


namespace dx177.Model.Bus
{
		/// <summary>
		/// 类 编 号：
		/// 类 名 称：Cookbook
		/// 内容摘要：
		/// </summary>
		
		[Serializable]
		public class Cookbook : BaseModel
		{
		#region 自动生成代码
		
			#region 重载Equals/GetHashCode
			/// <summary>
			/// 重载Equals			
			/// </summary>
			public override bool Equals (Object obj)
			{
				if (obj != null && obj is Cookbook)
				{
					if (obj == this)
						return true;
					Cookbook castObj = (Cookbook)obj; 
					
					if (!this.m_Seqno.Equals(castObj.Seqno))
						return false;
						
					if (!this.m_Guid.Equals(castObj.Guid))
						return false;
						
					if (!this.m_Pguid.Equals(castObj.Pguid))
						return false;
						
					if (!this.m_Name.Equals(castObj.Name))
						return false;
						
					if (!this.m_Price.Equals(castObj.Price))
						return false;
						
					if (!this.m_Logo.Equals(castObj.Logo))
						return false;
						
					if (!this.m_Showidx.Equals(castObj.Showidx))
						return false;
						
					if (!this.m_Content.Equals(castObj.Content))
						return false;
						
					if (!this.m_Shortcontent.Equals(castObj.Shortcontent))
						return false;
						
					if (!this.m_Creator.Equals(castObj.Creator))
						return false;
						
					if (!this.m_CreateDate.Equals(castObj.CreateDate))
						return false;
						
					if (!this.m_LasteUpdateDate.Equals(castObj.LasteUpdateDate))
						return false;
						
					if (!this.m_LasteUpdateBy.Equals(castObj.LasteUpdateBy))
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
					if ((object)m_Name != null)
					{
						hash = hash ^ m_Name.GetHashCode();
					}
						
					hash = hash <<  8;
					if ((object)m_Price != null)
					{
						hash = hash ^ m_Price.GetHashCode();
					}
						
					hash = hash <<  8;
					if ((object)m_Logo != null)
					{
						hash = hash ^ m_Logo.GetHashCode();
					}
						
					hash = hash <<  8;
					if ((object)m_Showidx != null)
					{
						hash = hash ^ m_Showidx.GetHashCode();
					}
						
					hash = hash <<  8;
					if ((object)m_Content != null)
					{
						hash = hash ^ m_Content.GetHashCode();
					}
						
					hash = hash <<  8;
					if ((object)m_Shortcontent != null)
					{
						hash = hash ^ m_Shortcontent.GetHashCode();
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
						
					return hash; 
			}
			#endregion
			
			public Cookbook()
			{
				MarkNew();
			}						
			
			public Cookbook GetOldValue()
			{
				return OldValue as Cookbook;
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
		
		#region Pguid属性
			private string m_Pguid = String.Empty;
			/// <summary>
			/// 属性名称： Pguid
			/// 内容摘要： DB列名：PGUID[饭店GUID]
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
		
		#region Name属性
			private string m_Name = String.Empty;
			/// <summary>
			/// 属性名称： Name
			/// 内容摘要： DB列名：Name[菜名]
			///            DB类型：string
			/// </summary>
			public string Name
			{
				get
					{
						return m_Name;
					}
				set
					{
						if (m_Name as object == null || !m_Name.Equals(value))
						{
							m_Name = value;
							MarkUpdated();
						}						
					}
			}
		#endregion
		
		#region Price属性
			private string m_Price = String.Empty;
			/// <summary>
			/// 属性名称： Price
			/// 内容摘要： DB列名：Price[价格]
			///            DB类型：string
			/// </summary>
			public string Price
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
		
		#region Logo属性
			private string m_Logo = String.Empty;
			/// <summary>
			/// 属性名称： Logo
			/// 内容摘要： DB列名：Logo[图标]
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
		
		#region Showidx属性
			private int m_Showidx = 0;
			/// <summary>
			/// 属性名称： Showidx
			/// 内容摘要： DB列名：ShowIdx[显示顺序]
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
		
		#region Content属性
			private string m_Content = String.Empty;
			/// <summary>
			/// 属性名称： Content
			/// 内容摘要： DB列名：Content[内容]
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
		
		#region Shortcontent属性
			private string m_Shortcontent = String.Empty;
			/// <summary>
			/// 属性名称： Shortcontent
			/// 内容摘要： DB列名：ShortContent[简述]
			///            DB类型：string
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
					dtResult.Columns.Add(new DataColumn("Name",typeof(string)));
					dtResult.Columns.Add(new DataColumn("Price",typeof(string)));
					dtResult.Columns.Add(new DataColumn("Logo",typeof(string)));
					dtResult.Columns.Add(new DataColumn("ShowIdx",typeof(int)));
					dtResult.Columns.Add(new DataColumn("Content",typeof(string)));
					dtResult.Columns.Add(new DataColumn("ShortContent",typeof(string)));
					dtResult.Columns.Add(new DataColumn("CREATOR",typeof(string)));
					dtResult.Columns.Add(new DataColumn("CREATE_DATE",typeof(DateTime)));
					dtResult.Columns.Add(new DataColumn("Laste_update_date",typeof(DateTime)));
					dtResult.Columns.Add(new DataColumn("Laste_update_By",typeof(string)));
				}
				else if (cne == ColumnNameEnum.PropertyName)
				{
					dtResult.Columns.Add(new DataColumn("Seqno",typeof(int)));
					dtResult.Columns.Add(new DataColumn("Guid",typeof(string)));
					dtResult.Columns.Add(new DataColumn("Pguid",typeof(string)));
					dtResult.Columns.Add(new DataColumn("Name",typeof(string)));
					dtResult.Columns.Add(new DataColumn("Price",typeof(string)));
					dtResult.Columns.Add(new DataColumn("Logo",typeof(string)));
					dtResult.Columns.Add(new DataColumn("Showidx",typeof(int)));
					dtResult.Columns.Add(new DataColumn("Content",typeof(string)));
					dtResult.Columns.Add(new DataColumn("Shortcontent",typeof(string)));
					dtResult.Columns.Add(new DataColumn("Creator",typeof(string)));
					dtResult.Columns.Add(new DataColumn("CreateDate",typeof(DateTime)));
					dtResult.Columns.Add(new DataColumn("LasteUpdateDate",typeof(DateTime)));
					dtResult.Columns.Add(new DataColumn("LasteUpdateBy",typeof(string)));
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
					dr["Name"] = this.Name;
					dr["Price"] = this.Price;
					dr["Logo"] = this.Logo;
					dr["ShowIdx"] = this.Showidx;
					dr["Content"] = this.Content;
					dr["ShortContent"] = this.Shortcontent;
					dr["CREATOR"] = this.Creator;
					dr["CREATE_DATE"] = this.CreateDate;
					dr["Laste_update_date"] = this.LasteUpdateDate;
					dr["Laste_update_By"] = this.LasteUpdateBy;
				}
				else if (ColumnNameEnum.PropertyName == cne)
				{
					dr["Seqno"] = this.Seqno;
					dr["Guid"] = this.Guid;
					dr["Pguid"] = this.Pguid;
					dr["Name"] = this.Name;
					dr["Price"] = this.Price;
					dr["Logo"] = this.Logo;
					dr["Showidx"] = this.Showidx;
					dr["Content"] = this.Content;
					dr["Shortcontent"] = this.Shortcontent;
					dr["Creator"] = this.Creator;
					dr["CreateDate"] = this.CreateDate;
					dr["LasteUpdateDate"] = this.LasteUpdateDate;
					dr["LasteUpdateBy"] = this.LasteUpdateBy;					
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
			/// 将DataRow转换成Cookbook对象
			/// </summary>
			/// <param name="dr">由CreateTable生成的DataTable通过NewRow得到的DataRow对象</param>
			/// <param name="cne">dr的列名映射方式:DB列名或属性名</param>
			/// <returns>Cookbook对象</returns>
			public static Cookbook Dr2Obj(DataRow dr,ColumnNameEnum cne)
			{
				if (dr == null)
				{
					throw new ArgumentNullException("dr");
				}
				Cookbook obj = new Cookbook();
				if (ColumnNameEnum.DBName == cne)
				{
					obj.Seqno = (dr["Seqno"] == Convert.DBNull) ? 0  : (int)Convert.ChangeType(dr["Seqno"],typeof(int));
					obj.Guid = (dr["GUID"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["GUID"],typeof(string));
					obj.Pguid = (dr["PGUID"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["PGUID"],typeof(string));
					obj.Name = (dr["Name"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Name"],typeof(string));
					obj.Price = (dr["Price"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Price"],typeof(string));
					obj.Logo = (dr["Logo"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Logo"],typeof(string));
					obj.Showidx = (dr["ShowIdx"] == Convert.DBNull) ? 0  : (int)Convert.ChangeType(dr["ShowIdx"],typeof(int));
					obj.Content = (dr["Content"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Content"],typeof(string));
					obj.Shortcontent = (dr["ShortContent"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["ShortContent"],typeof(string));
					obj.Creator = (dr["CREATOR"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["CREATOR"],typeof(string));
					obj.CreateDate = (dr["CREATE_DATE"] == Convert.DBNull) ? new DateTime(1900,1,1)  : (DateTime)Convert.ChangeType(dr["CREATE_DATE"],typeof(DateTime));
					obj.LasteUpdateDate = (dr["Laste_update_date"] == Convert.DBNull) ? new DateTime(1900,1,1)  : (DateTime)Convert.ChangeType(dr["Laste_update_date"],typeof(DateTime));
					obj.LasteUpdateBy = (dr["Laste_update_By"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Laste_update_By"],typeof(string));
				}
				else if (ColumnNameEnum.PropertyName == cne)
				{
					obj.Seqno = (dr["Seqno"] == Convert.DBNull) ? 0  : (int)Convert.ChangeType(dr["Seqno"],typeof(int));
					obj.Guid = (dr["Guid"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Guid"],typeof(string));
					obj.Pguid = (dr["Pguid"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Pguid"],typeof(string));
					obj.Name = (dr["Name"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Name"],typeof(string));
					obj.Price = (dr["Price"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Price"],typeof(string));
					obj.Logo = (dr["Logo"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Logo"],typeof(string));
					obj.Showidx = (dr["Showidx"] == Convert.DBNull) ? 0  : (int)Convert.ChangeType(dr["Showidx"],typeof(int));
					obj.Content = (dr["Content"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Content"],typeof(string));
					obj.Shortcontent = (dr["Shortcontent"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Shortcontent"],typeof(string));
					obj.Creator = (dr["Creator"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Creator"],typeof(string));
					obj.CreateDate = (dr["CreateDate"] == Convert.DBNull) ? new DateTime(1900,1,1)  : (DateTime)Convert.ChangeType(dr["CreateDate"],typeof(DateTime));
					obj.LasteUpdateDate = (dr["LasteUpdateDate"] == Convert.DBNull) ? new DateTime(1900,1,1)  : (DateTime)Convert.ChangeType(dr["LasteUpdateDate"],typeof(DateTime));
					obj.LasteUpdateBy = (dr["LasteUpdateBy"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["LasteUpdateBy"],typeof(string));		
				}
				
				return obj;
			}
			
			/// <summary>
			/// 将DataRow转换成Cookbook对象(默认列名映射为属性名)
			/// </summary>
			/// <returns>Cookbook对象</returns>
			public static Cookbook Dr2Obj(DataRow dr)
			{
				return Dr2Obj(dr,ColumnNameEnum.DBName);
			}
			
			/// <summary>
			/// 将DataTabe转换成的Cookbook对象集合
			/// </summary>
			/// <param name="dt">由CreateTable生成的DataTable</param>
			/// <param name="cne">dt的列名映射方式:DB列名或属性名</param>
			/// <returns>Cookbook对象的集合</returns>
			public static List<Cookbook> Dt2Objs(DataTable dt,ColumnNameEnum cne)
			{
				if (dt == null)
				{
					throw new ArgumentNullException("dt");
				}
				
				List<Cookbook> alResult = new List<Cookbook>();
				
				foreach(DataRow dr in dt.Rows)
				{
					alResult.Add(Dr2Obj(dr,cne));
				}
				
				return alResult;
			}

			/// <summary>
			/// 将DataTabe转换成的Cookbook对象集合(默认列名映射为属性名)
			/// </summary>
			/// <param name="dt">由CreateTable生成的DataTable</param>
			/// <returns>Cookbook对象的集合</returns>
			public static  List<Cookbook> Dt2Objs(DataTable dt)
			{
				return Dt2Objs(dt, ColumnNameEnum.DBName);
			}
			
			/// <summary>
			/// 用objs的Cookbook对象集合填充DataTable
			/// </summary>
			/// <param name="dt">由CreateTable生成的DataTable</param>
			/// <param name="objs">Cookbook对象集合</param>
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
				
				foreach(Cookbook obj in objs)
				{
					DataRow dr = dt.NewRow();
					obj.FillDataRow(dr,cne);
					dt.Rows.Add(dr);
				}
			}

			/// <summary>
			/// 用objs的Cookbook对象集合填充DataTable(默认列名映射为属性名)
			/// </summary>
			/// <param name="dt">由CreateTable生成的DataTable</param>
			/// <param name="objs">Cookbook对象集合</param>
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
			Cookbook old = this.OldValue as Cookbook;
			if (old != null)
			{
					this.Seqno = old.Seqno;
					this.Guid = old.Guid;
					this.Pguid = old.Pguid;
					this.Name = old.Name;
					this.Price = old.Price;
					this.Logo = old.Logo;
					this.Showidx = old.Showidx;
					this.Content = old.Content;
					this.Shortcontent = old.Shortcontent;
					this.Creator = old.Creator;
					this.CreateDate = old.CreateDate;
					this.LasteUpdateDate = old.LasteUpdateDate;
					this.LasteUpdateBy = old.LasteUpdateBy;				
				this.OldValue = null;
			}
		}
		
		
		
		
		#region Cookbook实体的内部Key类
			/// <summary>
			/// Cookbook实体的Key类
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
			/// 得到实体Cookbook的PK
			/// </summary>
			public Key GetKey()
			{
				return new Key(Seqno);				
			}
			
				
		#endregion
	}
}
