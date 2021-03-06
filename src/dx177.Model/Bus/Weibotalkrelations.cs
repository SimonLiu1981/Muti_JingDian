/*
版权所有：版权所有(C) 2014，中兴通讯
文件编号：M01_Weibotalkrelations.cs
文件名称：Weibotalkrelations.cs
系统编号：Z0003007
系统名称：通用办公系统
模块编号：M01
模块名称：信息发布
设计文档：IOA_M01信息发布XDE建模.mdx
完成日期：2014-1-15
作　　者：
内容摘要：表[WeiBoTalkRelations]对应的实体类
*/

using System;
using System.Collections;
using System.Data;
using System.Collections.Generic;


namespace dx177.Model.Bus
{
		/// <summary>
		/// 类 编 号：
		/// 类 名 称：Weibotalkrelations
		/// 内容摘要：
		/// </summary>
		
		[Serializable]
		public class Weibotalkrelations : BaseModel
		{
		#region 自动生成代码
		
			#region 重载Equals/GetHashCode
			/// <summary>
			/// 重载Equals			
			/// </summary>
			public override bool Equals (Object obj)
			{
				if (obj != null && obj is Weibotalkrelations)
				{
					if (obj == this)
						return true;
					Weibotalkrelations castObj = (Weibotalkrelations)obj; 
					
					if (!this.m_Seqno.Equals(castObj.Seqno))
						return false;
						
					if (!this.m_Weibotalkguid.Equals(castObj.Weibotalkguid))
						return false;
						
					if (!this.m_Relationsguid.Equals(castObj.Relationsguid))
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
					if ((object)m_Weibotalkguid != null)
					{
						hash = hash ^ m_Weibotalkguid.GetHashCode();
					}
						
					hash = hash <<  8;
					if ((object)m_Relationsguid != null)
					{
						hash = hash ^ m_Relationsguid.GetHashCode();
					}
						
					return hash; 
			}
			#endregion
			
			public Weibotalkrelations()
			{
				MarkNew();
			}						
			
			public Weibotalkrelations GetOldValue()
			{
				return OldValue as Weibotalkrelations;
			}
		
		#region Seqno属性
			private int m_Seqno = 0;
			/// <summary>
			/// 属性名称： Seqno
			/// 内容摘要： DB列名：seqno[]
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
		
		#region Weibotalkguid属性
			private string m_Weibotalkguid = String.Empty;
			/// <summary>
			/// 属性名称： Weibotalkguid
			/// 内容摘要： DB列名：WeiBoTalkGuid[]
			///            DB类型：nvarchar(50)
			/// </summary>
			public string Weibotalkguid
			{
				get
					{
						return m_Weibotalkguid;
					}
				set
					{
						if (m_Weibotalkguid as object == null || !m_Weibotalkguid.Equals(value))
						{
							m_Weibotalkguid = value;
							MarkUpdated();
						}						
					}
			}
		#endregion
		
		#region Relationsguid属性
			private string m_Relationsguid = String.Empty;
			/// <summary>
			/// 属性名称： Relationsguid
			/// 内容摘要： DB列名：RelationsGuid[]
			///            DB类型：nvarchar(50)
			/// </summary>
			public string Relationsguid
			{
				get
					{
						return m_Relationsguid;
					}
				set
					{
						if (m_Relationsguid as object == null || !m_Relationsguid.Equals(value))
						{
							m_Relationsguid = value;
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
					dtResult.Columns.Add(new DataColumn("seqno",typeof(int)));
					dtResult.Columns.Add(new DataColumn("WeiBoTalkGuid",typeof(string)));
					dtResult.Columns.Add(new DataColumn("RelationsGuid",typeof(string)));
				}
				else if (cne == ColumnNameEnum.PropertyName)
				{
					dtResult.Columns.Add(new DataColumn("Seqno",typeof(int)));
					dtResult.Columns.Add(new DataColumn("Weibotalkguid",typeof(string)));
					dtResult.Columns.Add(new DataColumn("Relationsguid",typeof(string)));
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
					dr["seqno"] = this.Seqno;
					dr["WeiBoTalkGuid"] = this.Weibotalkguid;
					dr["RelationsGuid"] = this.Relationsguid;
				}
				else if (ColumnNameEnum.PropertyName == cne)
				{
					dr["Seqno"] = this.Seqno;
					dr["Weibotalkguid"] = this.Weibotalkguid;
					dr["Relationsguid"] = this.Relationsguid;					
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
			/// 将DataRow转换成Weibotalkrelations对象
			/// </summary>
			/// <param name="dr">由CreateTable生成的DataTable通过NewRow得到的DataRow对象</param>
			/// <param name="cne">dr的列名映射方式:DB列名或属性名</param>
			/// <returns>Weibotalkrelations对象</returns>
			public static Weibotalkrelations Dr2Obj(DataRow dr,ColumnNameEnum cne)
			{
				if (dr == null)
				{
					throw new ArgumentNullException("dr");
				}
				Weibotalkrelations obj = new Weibotalkrelations();
				if (ColumnNameEnum.DBName == cne)
				{
					obj.Seqno = (dr["seqno"] == Convert.DBNull) ? 0  : (int)Convert.ChangeType(dr["seqno"],typeof(int));
					obj.Weibotalkguid = (dr["WeiBoTalkGuid"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["WeiBoTalkGuid"],typeof(string));
					obj.Relationsguid = (dr["RelationsGuid"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["RelationsGuid"],typeof(string));
				}
				else if (ColumnNameEnum.PropertyName == cne)
				{
					obj.Seqno = (dr["Seqno"] == Convert.DBNull) ? 0  : (int)Convert.ChangeType(dr["Seqno"],typeof(int));
					obj.Weibotalkguid = (dr["Weibotalkguid"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Weibotalkguid"],typeof(string));
					obj.Relationsguid = (dr["Relationsguid"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Relationsguid"],typeof(string));		
				}
				
				return obj;
			}
			
			/// <summary>
			/// 将DataRow转换成Weibotalkrelations对象(默认列名映射为属性名)
			/// </summary>
			/// <returns>Weibotalkrelations对象</returns>
			public static Weibotalkrelations Dr2Obj(DataRow dr)
			{
				return Dr2Obj(dr,ColumnNameEnum.DBName);
			}
			
			/// <summary>
			/// 将DataTabe转换成的Weibotalkrelations对象集合
			/// </summary>
			/// <param name="dt">由CreateTable生成的DataTable</param>
			/// <param name="cne">dt的列名映射方式:DB列名或属性名</param>
			/// <returns>Weibotalkrelations对象的集合</returns>
			public static List<Weibotalkrelations>  Dt2Objs(DataTable dt,ColumnNameEnum cne)
			{
				if (dt == null)
				{
					throw new ArgumentNullException("dt");
				}
				
				 
				List<Weibotalkrelations> alResult = new List<Weibotalkrelations>();
				
				foreach(DataRow dr in dt.Rows)
				{
					alResult.Add(Dr2Obj(dr,cne));
				}
				
				return alResult;
			}

			/// <summary>
			/// 将DataTabe转换成的Weibotalkrelations对象集合(默认列名映射为属性名)
			/// </summary>
			/// <param name="dt">由CreateTable生成的DataTable</param>
			/// <returns>Weibotalkrelations对象的集合</returns>
			public static List<Weibotalkrelations> Dt2Objs(DataTable dt)
			{
				return Dt2Objs(dt,ColumnNameEnum.DBName);
			}
			
			/// <summary>
			/// 用objs的Weibotalkrelations对象集合填充DataTable
			/// </summary>
			/// <param name="dt">由CreateTable生成的DataTable</param>
			/// <param name="objs">Weibotalkrelations对象集合</param>
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
				
				foreach(Weibotalkrelations obj in objs)
				{
					DataRow dr = dt.NewRow();
					obj.FillDataRow(dr,cne);
					dt.Rows.Add(dr);
				}
			}

			/// <summary>
			/// 用objs的Weibotalkrelations对象集合填充DataTable(默认列名映射为属性名)
			/// </summary>
			/// <param name="dt">由CreateTable生成的DataTable</param>
			/// <param name="objs">Weibotalkrelations对象集合</param>
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
			Weibotalkrelations old = this.OldValue as Weibotalkrelations;
			if (old != null)
			{
					this.Seqno = old.Seqno;
					this.Weibotalkguid = old.Weibotalkguid;
					this.Relationsguid = old.Relationsguid;				
				this.OldValue = null;
			}
		}
		
		
		
		
		#region Weibotalkrelations实体的内部Key类
			/// <summary>
			/// Weibotalkrelations实体的Key类
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
			/// 得到实体Weibotalkrelations的PK
			/// </summary>
			public Key GetKey()
			{
				return new Key(Seqno);				
			}
	
		
		#endregion
	}
}
