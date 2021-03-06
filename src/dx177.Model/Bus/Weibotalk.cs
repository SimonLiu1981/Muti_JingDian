/*
版权所有：版权所有(C) 2014，中兴通讯
文件编号：M01_Weibotalk.cs
文件名称：Weibotalk.cs
系统编号：Z0003007
系统名称：通用办公系统
模块编号：M01
模块名称：信息发布
设计文档：IOA_M01信息发布XDE建模.mdx
完成日期：2014-1-15
作　　者：
内容摘要：表[WeiBoTalk]对应的实体类
*/

using System;
using System.Collections;
using System.Data;
using System.Collections.Generic;


namespace dx177.Model.Bus
{
		/// <summary>
		/// 类 编 号：
		/// 类 名 称：Weibotalk
		/// 内容摘要：
		/// </summary>
		
		[Serializable]
		public class Weibotalk : BaseModel
		{
		#region 自动生成代码
		
			#region 重载Equals/GetHashCode
			/// <summary>
			/// 重载Equals			
			/// </summary>
			public override bool Equals (Object obj)
			{
				if (obj != null && obj is Weibotalk)
				{
					if (obj == this)
						return true;
					Weibotalk castObj = (Weibotalk)obj; 
					
					if (!this.m_Seqno.Equals(castObj.Seqno))
						return false;
						
					if (!this.m_Guid.Equals(castObj.Guid))
						return false;
						
					if (!this.m_Jinqqucode.Equals(castObj.Jinqqucode))
						return false;
						
					if (!this.m_Talk.Equals(castObj.Talk))
						return false;
						
					if (!this.m_Keyval.Equals(castObj.Keyval))
						return false;
						
					if (!this.m_Createdate.Equals(castObj.Createdate))
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
					if ((object)m_Jinqqucode != null)
					{
						hash = hash ^ m_Jinqqucode.GetHashCode();
					}
						
					hash = hash <<  8;
					if ((object)m_Talk != null)
					{
						hash = hash ^ m_Talk.GetHashCode();
					}
						
					hash = hash <<  8;
					if ((object)m_Keyval != null)
					{
						hash = hash ^ m_Keyval.GetHashCode();
					}
						
					hash = hash <<  8;
					if ((object)m_Createdate != null)
					{
						hash = hash ^ m_Createdate.GetHashCode();
					}
						
					return hash; 
			}
			#endregion
			
			public Weibotalk()
			{
				MarkNew();
			}						
			
			public Weibotalk GetOldValue()
			{
				return OldValue as Weibotalk;
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
		
		#region Guid属性
			private string m_Guid = String.Empty;
			/// <summary>
			/// 属性名称： Guid
			/// 内容摘要： DB列名：guid[]
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
		
		#region Jinqqucode属性
			private string m_Jinqqucode = String.Empty;
			/// <summary>
			/// 属性名称： Jinqqucode
			/// 内容摘要： DB列名：JinqQuCode[]
			///            DB类型：nvarchar(50)
			/// </summary>
			public string Jinqqucode
			{
				get
					{
						return m_Jinqqucode;
					}
				set
					{
						if (m_Jinqqucode as object == null || !m_Jinqqucode.Equals(value))
						{
							m_Jinqqucode = value;
							MarkUpdated();
						}						
					}
			}
		#endregion
		
		#region Talk属性
			private string m_Talk = String.Empty;
			/// <summary>
			/// 属性名称： Talk
			/// 内容摘要： DB列名：talk[]
			///            DB类型：nvarchar(1000)
			/// </summary>
			public string Talk
			{
				get
					{
						return m_Talk;
					}
				set
					{
						if (m_Talk as object == null || !m_Talk.Equals(value))
						{
							m_Talk = value;
							MarkUpdated();
						}						
					}
			}
		#endregion
		
		#region Keyval属性
			private string m_Keyval = String.Empty;
			/// <summary>
			/// 属性名称： Keyval
			/// 内容摘要： DB列名：Keyval[]
			///            DB类型：nvarchar(100)
			/// </summary>
			public string Keyval
			{
				get
					{
						return m_Keyval;
					}
				set
					{
						if (m_Keyval as object == null || !m_Keyval.Equals(value))
						{
							m_Keyval = value;
							MarkUpdated();
						}						
					}
			}
		#endregion
		
		#region Createdate属性
			private DateTime m_Createdate = new DateTime(1900,1,1);
			/// <summary>
			/// 属性名称： Createdate
			/// 内容摘要： DB列名：CreateDate[]
			///            DB类型：datetime
			/// </summary>
			public DateTime Createdate
			{
				get
					{
						return m_Createdate;
					}
				set
					{
						if (m_Createdate as object == null || !m_Createdate.Equals(value))
						{
							m_Createdate = value;
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
					dtResult.Columns.Add(new DataColumn("guid",typeof(string)));
					dtResult.Columns.Add(new DataColumn("JinqQuCode",typeof(string)));
					dtResult.Columns.Add(new DataColumn("talk",typeof(string)));
					dtResult.Columns.Add(new DataColumn("Keyval",typeof(string)));
					dtResult.Columns.Add(new DataColumn("CreateDate",typeof(DateTime)));
				}
				else if (cne == ColumnNameEnum.PropertyName)
				{
					dtResult.Columns.Add(new DataColumn("Seqno",typeof(int)));
					dtResult.Columns.Add(new DataColumn("Guid",typeof(string)));
					dtResult.Columns.Add(new DataColumn("Jinqqucode",typeof(string)));
					dtResult.Columns.Add(new DataColumn("Talk",typeof(string)));
					dtResult.Columns.Add(new DataColumn("Keyval",typeof(string)));
					dtResult.Columns.Add(new DataColumn("Createdate",typeof(DateTime)));
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
					dr["guid"] = this.Guid;
					dr["JinqQuCode"] = this.Jinqqucode;
					dr["talk"] = this.Talk;
					dr["Keyval"] = this.Keyval;
					dr["CreateDate"] = this.Createdate;
				}
				else if (ColumnNameEnum.PropertyName == cne)
				{
					dr["Seqno"] = this.Seqno;
					dr["Guid"] = this.Guid;
					dr["Jinqqucode"] = this.Jinqqucode;
					dr["Talk"] = this.Talk;
					dr["Keyval"] = this.Keyval;
					dr["Createdate"] = this.Createdate;					
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
			/// 将DataRow转换成Weibotalk对象
			/// </summary>
			/// <param name="dr">由CreateTable生成的DataTable通过NewRow得到的DataRow对象</param>
			/// <param name="cne">dr的列名映射方式:DB列名或属性名</param>
			/// <returns>Weibotalk对象</returns>
			public static Weibotalk Dr2Obj(DataRow dr,ColumnNameEnum cne)
			{
				if (dr == null)
				{
					throw new ArgumentNullException("dr");
				}
				Weibotalk obj = new Weibotalk();
				if (ColumnNameEnum.DBName == cne)
				{
					obj.Seqno = (dr["seqno"] == Convert.DBNull) ? 0  : (int)Convert.ChangeType(dr["seqno"],typeof(int));
					obj.Guid = (dr["guid"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["guid"],typeof(string));
					obj.Jinqqucode = (dr["JinqQuCode"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["JinqQuCode"],typeof(string));
					obj.Talk = (dr["talk"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["talk"],typeof(string));
					obj.Keyval = (dr["Keyval"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Keyval"],typeof(string));
					obj.Createdate = (dr["CreateDate"] == Convert.DBNull) ? new DateTime(1900,1,1)  : (DateTime)Convert.ChangeType(dr["CreateDate"],typeof(DateTime));
				}
				else if (ColumnNameEnum.PropertyName == cne)
				{
					obj.Seqno = (dr["Seqno"] == Convert.DBNull) ? 0  : (int)Convert.ChangeType(dr["Seqno"],typeof(int));
					obj.Guid = (dr["Guid"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Guid"],typeof(string));
					obj.Jinqqucode = (dr["Jinqqucode"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Jinqqucode"],typeof(string));
					obj.Talk = (dr["Talk"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Talk"],typeof(string));
					obj.Keyval = (dr["Keyval"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Keyval"],typeof(string));
					obj.Createdate = (dr["Createdate"] == Convert.DBNull) ? new DateTime(1900,1,1)  : (DateTime)Convert.ChangeType(dr["Createdate"],typeof(DateTime));		
				}
				
				return obj;
			}
			
			/// <summary>
			/// 将DataRow转换成Weibotalk对象(默认列名映射为属性名)
			/// </summary>
			/// <returns>Weibotalk对象</returns>
			public static Weibotalk Dr2Obj(DataRow dr)
			{
				return Dr2Obj(dr,ColumnNameEnum.DBName);
			}
			
			/// <summary>
			/// 将DataTabe转换成的Weibotalk对象集合
			/// </summary>
			/// <param name="dt">由CreateTable生成的DataTable</param>
			/// <param name="cne">dt的列名映射方式:DB列名或属性名</param>
			/// <returns>Weibotalk对象的集合</returns>
			public static List<Weibotalk>  Dt2Objs(DataTable dt,ColumnNameEnum cne)
			{
				if (dt == null)
				{
					throw new ArgumentNullException("dt");
				}
				
				 
				List<Weibotalk> alResult = new List<Weibotalk>();
				
				foreach(DataRow dr in dt.Rows)
				{
					alResult.Add(Dr2Obj(dr,cne));
				}
				
				return alResult;
			}

			/// <summary>
			/// 将DataTabe转换成的Weibotalk对象集合(默认列名映射为属性名)
			/// </summary>
			/// <param name="dt">由CreateTable生成的DataTable</param>
			/// <returns>Weibotalk对象的集合</returns>
			public static List<Weibotalk> Dt2Objs(DataTable dt)
			{
				return Dt2Objs(dt,ColumnNameEnum.DBName);
			}
			
			/// <summary>
			/// 用objs的Weibotalk对象集合填充DataTable
			/// </summary>
			/// <param name="dt">由CreateTable生成的DataTable</param>
			/// <param name="objs">Weibotalk对象集合</param>
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
				
				foreach(Weibotalk obj in objs)
				{
					DataRow dr = dt.NewRow();
					obj.FillDataRow(dr,cne);
					dt.Rows.Add(dr);
				}
			}

			/// <summary>
			/// 用objs的Weibotalk对象集合填充DataTable(默认列名映射为属性名)
			/// </summary>
			/// <param name="dt">由CreateTable生成的DataTable</param>
			/// <param name="objs">Weibotalk对象集合</param>
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
			Weibotalk old = this.OldValue as Weibotalk;
			if (old != null)
			{
					this.Seqno = old.Seqno;
					this.Guid = old.Guid;
					this.Jinqqucode = old.Jinqqucode;
					this.Talk = old.Talk;
					this.Keyval = old.Keyval;
					this.Createdate = old.Createdate;				
				this.OldValue = null;
			}
		}
		
		
		
		
		#region Weibotalk实体的内部Key类
			/// <summary>
			/// Weibotalk实体的Key类
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
			/// 得到实体Weibotalk的PK
			/// </summary>
			public Key GetKey()
			{
				return new Key(Seqno);				
			}
	
		
		#endregion
	}
}
