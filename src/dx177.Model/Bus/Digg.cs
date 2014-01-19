/*
版权所有：版权所有(C) 2011，刘建新
文件编号：M01_Digg.cs
文件名称：Digg.cs
系统编号：Z0003007
系统名称：通用办公系统
模块编号：M01
模块名称：信息发布
设计文档：IOA_M01信息发布XDE建模.mdx
完成日期：2011/3/30
作　　者：
内容摘要：表[Digg]对应的实体类
*/

using System;
using System.Collections;
using System.Data;
using System.Collections.Generic;


namespace dx177.Model.Bus
{
		/// <summary>
		/// 类 编 号：
		/// 类 名 称：Digg
		/// 内容摘要：
		/// </summary>
		
		[Serializable]
		public class Digg : BaseModel
		{
		#region 自动生成代码
		
			#region 重载Equals/GetHashCode
			/// <summary>
			/// 重载Equals			
			/// </summary>
			public override bool Equals (Object obj)
			{
				if (obj != null && obj is Digg)
				{
					if (obj == this)
						return true;
					Digg castObj = (Digg)obj; 
					
					if (!this.m_Seqno.Equals(castObj.Seqno))
						return false;
						
					if (!this.m_Pguid.Equals(castObj.Pguid))
						return false;
						
					if (!this.m_Ip.Equals(castObj.Ip))
						return false;
						
					if (!this.m_Diggtype.Equals(castObj.Diggtype))
						return false;
						
					if (!this.m_CreateDate.Equals(castObj.CreateDate))
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
					if ((object)m_Ip != null)
					{
						hash = hash ^ m_Ip.GetHashCode();
					}
						
					hash = hash <<  8;
					if ((object)m_Diggtype != null)
					{
						hash = hash ^ m_Diggtype.GetHashCode();
					}
						
					hash = hash <<  8;
					if ((object)m_CreateDate != null)
					{
						hash = hash ^ m_CreateDate.GetHashCode();
					}
						
					return hash; 
			}
			#endregion
			
			public Digg()
			{
				MarkNew();
			}						
			
			public Digg GetOldValue()
			{
				return OldValue as Digg;
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
		
		#region Ip属性
			private string m_Ip = String.Empty;
			/// <summary>
			/// 属性名称： Ip
			/// 内容摘要： DB列名：IP[IP]
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
		
		#region Diggtype属性
			private int m_Diggtype = 0;
			/// <summary>
			/// 属性名称： Diggtype
			/// 内容摘要： DB列名：DiggType[类型(1:查看，2顶，)]
			///            DB类型：int
			/// </summary>
			public int Diggtype
			{
				get
					{
						return m_Diggtype;
					}
				set
					{
						if (m_Diggtype as object == null || !m_Diggtype.Equals(value))
						{
							m_Diggtype = value;
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
					dtResult.Columns.Add(new DataColumn("IP",typeof(string)));
					dtResult.Columns.Add(new DataColumn("DiggType",typeof(int)));
					dtResult.Columns.Add(new DataColumn("CREATE_DATE",typeof(DateTime)));
				}
				else if (cne == ColumnNameEnum.PropertyName)
				{
					dtResult.Columns.Add(new DataColumn("Seqno",typeof(int)));
					dtResult.Columns.Add(new DataColumn("Pguid",typeof(string)));
					dtResult.Columns.Add(new DataColumn("Ip",typeof(string)));
					dtResult.Columns.Add(new DataColumn("Diggtype",typeof(int)));
					dtResult.Columns.Add(new DataColumn("CreateDate",typeof(DateTime)));
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
					dr["IP"] = this.Ip;
					dr["DiggType"] = this.Diggtype;
					dr["CREATE_DATE"] = this.CreateDate;
				}
				else if (ColumnNameEnum.PropertyName == cne)
				{
					dr["Seqno"] = this.Seqno;
					dr["Pguid"] = this.Pguid;
					dr["Ip"] = this.Ip;
					dr["Diggtype"] = this.Diggtype;
					dr["CreateDate"] = this.CreateDate;					
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
			/// 将DataRow转换成Digg对象
			/// </summary>
			/// <param name="dr">由CreateTable生成的DataTable通过NewRow得到的DataRow对象</param>
			/// <param name="cne">dr的列名映射方式:DB列名或属性名</param>
			/// <returns>Digg对象</returns>
			public static Digg Dr2Obj(DataRow dr,ColumnNameEnum cne)
			{
				if (dr == null)
				{
					throw new ArgumentNullException("dr");
				}
				Digg obj = new Digg();
				if (ColumnNameEnum.DBName == cne)
				{
					obj.Seqno = (dr["Seqno"] == Convert.DBNull) ? 0  : (int)Convert.ChangeType(dr["Seqno"],typeof(int));
					obj.Pguid = (dr["PGUID"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["PGUID"],typeof(string));
					obj.Ip = (dr["IP"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["IP"],typeof(string));
					obj.Diggtype = (dr["DiggType"] == Convert.DBNull) ? 0  : (int)Convert.ChangeType(dr["DiggType"],typeof(int));
					obj.CreateDate = (dr["CREATE_DATE"] == Convert.DBNull) ? new DateTime(1900,1,1)  : (DateTime)Convert.ChangeType(dr["CREATE_DATE"],typeof(DateTime));
				}
				else if (ColumnNameEnum.PropertyName == cne)
				{
					obj.Seqno = (dr["Seqno"] == Convert.DBNull) ? 0  : (int)Convert.ChangeType(dr["Seqno"],typeof(int));
					obj.Pguid = (dr["Pguid"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Pguid"],typeof(string));
					obj.Ip = (dr["Ip"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Ip"],typeof(string));
					obj.Diggtype = (dr["Diggtype"] == Convert.DBNull) ? 0  : (int)Convert.ChangeType(dr["Diggtype"],typeof(int));
					obj.CreateDate = (dr["CreateDate"] == Convert.DBNull) ? new DateTime(1900,1,1)  : (DateTime)Convert.ChangeType(dr["CreateDate"],typeof(DateTime));		
				}
				
				return obj;
			}
			
			/// <summary>
			/// 将DataRow转换成Digg对象(默认列名映射为属性名)
			/// </summary>
			/// <returns>Digg对象</returns>
			public static Digg Dr2Obj(DataRow dr)
			{
				return Dr2Obj(dr,ColumnNameEnum.DBName);
			}
			
			/// <summary>
			/// 将DataTabe转换成的Digg对象集合
			/// </summary>
			/// <param name="dt">由CreateTable生成的DataTable</param>
			/// <param name="cne">dt的列名映射方式:DB列名或属性名</param>
			/// <returns>Digg对象的集合</returns>
			public static List<Digg> Dt2Objs(DataTable dt,ColumnNameEnum cne)
			{
				if (dt == null)
				{
					throw new ArgumentNullException("dt");
				}
				
				List<Digg> alResult = new List<Digg>();
				
				foreach(DataRow dr in dt.Rows)
				{
					alResult.Add(Dr2Obj(dr,cne));
				}
				
				return alResult;
			}

			/// <summary>
			/// 将DataTabe转换成的Digg对象集合(默认列名映射为属性名)
			/// </summary>
			/// <param name="dt">由CreateTable生成的DataTable</param>
			/// <returns>Digg对象的集合</returns>
			public static  List<Digg> Dt2Objs(DataTable dt)
			{
				return Dt2Objs(dt, ColumnNameEnum.DBName);
			}
			
			/// <summary>
			/// 用objs的Digg对象集合填充DataTable
			/// </summary>
			/// <param name="dt">由CreateTable生成的DataTable</param>
			/// <param name="objs">Digg对象集合</param>
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
				
				foreach(Digg obj in objs)
				{
					DataRow dr = dt.NewRow();
					obj.FillDataRow(dr,cne);
					dt.Rows.Add(dr);
				}
			}

			/// <summary>
			/// 用objs的Digg对象集合填充DataTable(默认列名映射为属性名)
			/// </summary>
			/// <param name="dt">由CreateTable生成的DataTable</param>
			/// <param name="objs">Digg对象集合</param>
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
			Digg old = this.OldValue as Digg;
			if (old != null)
			{
					this.Seqno = old.Seqno;
					this.Pguid = old.Pguid;
					this.Ip = old.Ip;
					this.Diggtype = old.Diggtype;
					this.CreateDate = old.CreateDate;				
				this.OldValue = null;
			}
		}
		
		
		
		
		#region Digg实体的内部Key类
			/// <summary>
			/// Digg实体的Key类
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
			/// 得到实体Digg的PK
			/// </summary>
			public Key GetKey()
			{
				return new Key(Seqno);				
			}
			
				
		#endregion
	}
}
