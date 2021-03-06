/*
版权所有：版权所有(C) 2012，中兴通讯
文件编号：M01_Questionralations.cs
文件名称：Questionralations.cs
系统编号：Z0003007
系统名称：通用办公系统
模块编号：M01
模块名称：信息发布
设计文档：IOA_M01信息发布XDE建模.mdx
完成日期：2012-8-27
作　　者：
内容摘要：表[QuestionRalations]对应的实体类
*/

using System;
using System.Collections;
using System.Data;
using System.Collections.Generic;


namespace dx177.Model.Bus
{
		/// <summary>
		/// 类 编 号：
		/// 类 名 称：Questionralations
		/// 内容摘要：
		/// </summary>
		
		[Serializable]
		public class Questionralations : BaseModel
		{
		#region 自动生成代码
		
			#region 重载Equals/GetHashCode
			/// <summary>
			/// 重载Equals			
			/// </summary>
			public override bool Equals (Object obj)
			{
				if (obj != null && obj is Questionralations)
				{
					if (obj == this)
						return true;
					Questionralations castObj = (Questionralations)obj; 
					
					if (!this.m_Seqno.Equals(castObj.Seqno))
						return false;
						
					if (!this.m_Ralatequestionguida.Equals(castObj.Ralatequestionguida))
						return false;
						
					if (!this.m_Ralatequestionguidb.Equals(castObj.Ralatequestionguidb))
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
					if ((object)m_Ralatequestionguida != null)
					{
						hash = hash ^ m_Ralatequestionguida.GetHashCode();
					}
						
					hash = hash <<  8;
					if ((object)m_Ralatequestionguidb != null)
					{
						hash = hash ^ m_Ralatequestionguidb.GetHashCode();
					}
						
					return hash; 
			}
			#endregion
			
			public Questionralations()
			{
				MarkNew();
			}						
			
			public Questionralations GetOldValue()
			{
				return OldValue as Questionralations;
			}
		
		#region Seqno属性
			private int m_Seqno = 0;
			/// <summary>
			/// 属性名称： Seqno
			/// 内容摘要： DB列名：Seqno[]
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
		
		#region Ralatequestionguida属性
			private string m_Ralatequestionguida = String.Empty;
			/// <summary>
			/// 属性名称： Ralatequestionguida
			/// 内容摘要： DB列名：RalateQuestionGUIDA[]
			///            DB类型：nvarchar(50)
			/// </summary>
			public string Ralatequestionguida
			{
				get
					{
						return m_Ralatequestionguida;
					}
				set
					{
						if (m_Ralatequestionguida as object == null || !m_Ralatequestionguida.Equals(value))
						{
							m_Ralatequestionguida = value;
							MarkUpdated();
						}						
					}
			}
		#endregion
		
		#region Ralatequestionguidb属性
			private string m_Ralatequestionguidb = String.Empty;
			/// <summary>
			/// 属性名称： Ralatequestionguidb
			/// 内容摘要： DB列名：RalateQuestionGUIDB[]
			///            DB类型：nvarchar(50)
			/// </summary>
			public string Ralatequestionguidb
			{
				get
					{
						return m_Ralatequestionguidb;
					}
				set
					{
						if (m_Ralatequestionguidb as object == null || !m_Ralatequestionguidb.Equals(value))
						{
							m_Ralatequestionguidb = value;
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
					dtResult.Columns.Add(new DataColumn("RalateQuestionGUIDA",typeof(string)));
					dtResult.Columns.Add(new DataColumn("RalateQuestionGUIDB",typeof(string)));
				}
				else if (cne == ColumnNameEnum.PropertyName)
				{
					dtResult.Columns.Add(new DataColumn("Seqno",typeof(int)));
					dtResult.Columns.Add(new DataColumn("Ralatequestionguida",typeof(string)));
					dtResult.Columns.Add(new DataColumn("Ralatequestionguidb",typeof(string)));
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
					dr["RalateQuestionGUIDA"] = this.Ralatequestionguida;
					dr["RalateQuestionGUIDB"] = this.Ralatequestionguidb;
				}
				else if (ColumnNameEnum.PropertyName == cne)
				{
					dr["Seqno"] = this.Seqno;
					dr["Ralatequestionguida"] = this.Ralatequestionguida;
					dr["Ralatequestionguidb"] = this.Ralatequestionguidb;					
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
			/// 将DataRow转换成Questionralations对象
			/// </summary>
			/// <param name="dr">由CreateTable生成的DataTable通过NewRow得到的DataRow对象</param>
			/// <param name="cne">dr的列名映射方式:DB列名或属性名</param>
			/// <returns>Questionralations对象</returns>
			public static Questionralations Dr2Obj(DataRow dr,ColumnNameEnum cne)
			{
				if (dr == null)
				{
					throw new ArgumentNullException("dr");
				}
				Questionralations obj = new Questionralations();
				if (ColumnNameEnum.DBName == cne)
				{
					obj.Seqno = (dr["Seqno"] == Convert.DBNull) ? 0  : (int)Convert.ChangeType(dr["Seqno"],typeof(int));
					obj.Ralatequestionguida = (dr["RalateQuestionGUIDA"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["RalateQuestionGUIDA"],typeof(string));
					obj.Ralatequestionguidb = (dr["RalateQuestionGUIDB"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["RalateQuestionGUIDB"],typeof(string));
				}
				else if (ColumnNameEnum.PropertyName == cne)
				{
					obj.Seqno = (dr["Seqno"] == Convert.DBNull) ? 0  : (int)Convert.ChangeType(dr["Seqno"],typeof(int));
					obj.Ralatequestionguida = (dr["Ralatequestionguida"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Ralatequestionguida"],typeof(string));
					obj.Ralatequestionguidb = (dr["Ralatequestionguidb"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Ralatequestionguidb"],typeof(string));		
				}
				
				return obj;
			}
			
			/// <summary>
			/// 将DataRow转换成Questionralations对象(默认列名映射为属性名)
			/// </summary>
			/// <returns>Questionralations对象</returns>
			public static Questionralations Dr2Obj(DataRow dr)
			{
				return Dr2Obj(dr,ColumnNameEnum.DBName);
			}
			
			/// <summary>
			/// 将DataTabe转换成的Questionralations对象集合
			/// </summary>
			/// <param name="dt">由CreateTable生成的DataTable</param>
			/// <param name="cne">dt的列名映射方式:DB列名或属性名</param>
			/// <returns>Questionralations对象的集合</returns>
			public static List<Questionralations>  Dt2Objs(DataTable dt,ColumnNameEnum cne)
			{
				if (dt == null)
				{
					throw new ArgumentNullException("dt");
				}
				
				 
				List<Questionralations> alResult = new List<Questionralations>();
				
				foreach(DataRow dr in dt.Rows)
				{
					alResult.Add(Dr2Obj(dr,cne));
				}
				
				return alResult;
			}

			/// <summary>
			/// 将DataTabe转换成的Questionralations对象集合(默认列名映射为属性名)
			/// </summary>
			/// <param name="dt">由CreateTable生成的DataTable</param>
			/// <returns>Questionralations对象的集合</returns>
			public static List<Questionralations> Dt2Objs(DataTable dt)
			{
				return Dt2Objs(dt,ColumnNameEnum.DBName);
			}
			
			/// <summary>
			/// 用objs的Questionralations对象集合填充DataTable
			/// </summary>
			/// <param name="dt">由CreateTable生成的DataTable</param>
			/// <param name="objs">Questionralations对象集合</param>
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
				
				foreach(Questionralations obj in objs)
				{
					DataRow dr = dt.NewRow();
					obj.FillDataRow(dr,cne);
					dt.Rows.Add(dr);
				}
			}

			/// <summary>
			/// 用objs的Questionralations对象集合填充DataTable(默认列名映射为属性名)
			/// </summary>
			/// <param name="dt">由CreateTable生成的DataTable</param>
			/// <param name="objs">Questionralations对象集合</param>
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
			Questionralations old = this.OldValue as Questionralations;
			if (old != null)
			{
					this.Seqno = old.Seqno;
					this.Ralatequestionguida = old.Ralatequestionguida;
					this.Ralatequestionguidb = old.Ralatequestionguidb;				
				this.OldValue = null;
			}
		}
		
		
		
		
		#region Questionralations实体的内部Key类
			/// <summary>
			/// Questionralations实体的Key类
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
			/// 得到实体Questionralations的PK
			/// </summary>
			public Key GetKey()
			{
				return new Key(Seqno);				
			}
	
		
		#endregion
	}
}
