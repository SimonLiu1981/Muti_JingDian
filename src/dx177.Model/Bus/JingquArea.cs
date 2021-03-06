/*
版权所有：版权所有(C) 2012，中兴通讯
文件编号：M01_JingquArea.cs
文件名称：JingquArea.cs
系统编号：Z0003007
系统名称：通用办公系统
模块编号：M01
模块名称：信息发布
设计文档：IOA_M01信息发布XDE建模.mdx
完成日期：2012/6/20
作　　者：
内容摘要：表[JingQu_Area]对应的实体类
*/

using System;
using System.Collections;
using System.Data;
using System.Collections.Generic;


namespace dx177.Model.Bus
{
		/// <summary>
		/// 类 编 号：
		/// 类 名 称：JingquArea
		/// 内容摘要：
		/// </summary>
		
		[Serializable]
		public class JingquArea : BaseModel
		{
		#region 自动生成代码
		
			#region 重载Equals/GetHashCode
			/// <summary>
			/// 重载Equals			
			/// </summary>
			public override bool Equals (Object obj)
			{
				if (obj != null && obj is JingquArea)
				{
					if (obj == this)
						return true;
					JingquArea castObj = (JingquArea)obj; 
					
					if (!this.m_Jingquareaid.Equals(castObj.Jingquareaid))
						return false;
						
					if (!this.m_Jinqqucode.Equals(castObj.Jinqqucode))
						return false;
						
					if (!this.m_Areaname.Equals(castObj.Areaname))
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
					if ((object)m_Jingquareaid != null)
					{
						hash = hash ^ m_Jingquareaid.GetHashCode();
					}
						
					hash = hash <<  8;
					if ((object)m_Jinqqucode != null)
					{
						hash = hash ^ m_Jinqqucode.GetHashCode();
					}
						
					hash = hash <<  8;
					if ((object)m_Areaname != null)
					{
						hash = hash ^ m_Areaname.GetHashCode();
					}
						
					return hash; 
			}
			#endregion
			
			public JingquArea()
			{
				MarkNew();
			}						
			
			public JingquArea GetOldValue()
			{
				return OldValue as JingquArea;
			}
		
		#region Jingquareaid属性
			private int m_Jingquareaid = 0;
			/// <summary>
			/// 属性名称： Jingquareaid
			/// 内容摘要： DB列名：JingQuAreaId[]
			///            DB类型：int
			/// </summary>
			public int Jingquareaid
			{
				get
					{
						return m_Jingquareaid;
					}
				set
					{
						if (m_Jingquareaid as object == null || !m_Jingquareaid.Equals(value))
						{
							m_Jingquareaid = value;
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
			///            DB类型：nvarchar(20)
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
		
		#region Areaname属性
			private string m_Areaname = String.Empty;
			/// <summary>
			/// 属性名称： Areaname
			/// 内容摘要： DB列名：AreaName[区域名]
			///            DB类型：nvarchar(50)
			/// </summary>
			public string Areaname
			{
				get
					{
						return m_Areaname;
					}
				set
					{
						if (m_Areaname as object == null || !m_Areaname.Equals(value))
						{
							m_Areaname = value;
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
					dtResult.Columns.Add(new DataColumn("JingQuAreaId",typeof(int)));
					dtResult.Columns.Add(new DataColumn("JinqQuCode",typeof(string)));
					dtResult.Columns.Add(new DataColumn("AreaName",typeof(string)));
				}
				else if (cne == ColumnNameEnum.PropertyName)
				{
					dtResult.Columns.Add(new DataColumn("Jingquareaid",typeof(int)));
					dtResult.Columns.Add(new DataColumn("Jinqqucode",typeof(string)));
					dtResult.Columns.Add(new DataColumn("Areaname",typeof(string)));
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
					dr["JingQuAreaId"] = this.Jingquareaid;
					dr["JinqQuCode"] = this.Jinqqucode;
					dr["AreaName"] = this.Areaname;
				}
				else if (ColumnNameEnum.PropertyName == cne)
				{
					dr["Jingquareaid"] = this.Jingquareaid;
					dr["Jinqqucode"] = this.Jinqqucode;
					dr["Areaname"] = this.Areaname;					
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
			/// 将DataRow转换成JingquArea对象
			/// </summary>
			/// <param name="dr">由CreateTable生成的DataTable通过NewRow得到的DataRow对象</param>
			/// <param name="cne">dr的列名映射方式:DB列名或属性名</param>
			/// <returns>JingquArea对象</returns>
			public static JingquArea Dr2Obj(DataRow dr,ColumnNameEnum cne)
			{
				if (dr == null)
				{
					throw new ArgumentNullException("dr");
				}
				JingquArea obj = new JingquArea();
				if (ColumnNameEnum.DBName == cne)
				{
					obj.Jingquareaid = (dr["JingQuAreaId"] == Convert.DBNull) ? 0  : (int)Convert.ChangeType(dr["JingQuAreaId"],typeof(int));
					obj.Jinqqucode = (dr["JinqQuCode"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["JinqQuCode"],typeof(string));
					obj.Areaname = (dr["AreaName"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["AreaName"],typeof(string));
				}
				else if (ColumnNameEnum.PropertyName == cne)
				{
					obj.Jingquareaid = (dr["Jingquareaid"] == Convert.DBNull) ? 0  : (int)Convert.ChangeType(dr["Jingquareaid"],typeof(int));
					obj.Jinqqucode = (dr["Jinqqucode"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Jinqqucode"],typeof(string));
					obj.Areaname = (dr["Areaname"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Areaname"],typeof(string));		
				}
				
				return obj;
			}
			
			/// <summary>
			/// 将DataRow转换成JingquArea对象(默认列名映射为属性名)
			/// </summary>
			/// <returns>JingquArea对象</returns>
			public static JingquArea Dr2Obj(DataRow dr)
			{
				return Dr2Obj(dr,ColumnNameEnum.DBName);
			}
			
			/// <summary>
			/// 将DataTabe转换成的JingquArea对象集合
			/// </summary>
			/// <param name="dt">由CreateTable生成的DataTable</param>
			/// <param name="cne">dt的列名映射方式:DB列名或属性名</param>
			/// <returns>JingquArea对象的集合</returns>
			public static List<JingquArea>  Dt2Objs(DataTable dt,ColumnNameEnum cne)
			{
				if (dt == null)
				{
					throw new ArgumentNullException("dt");
				}
				
				 
				List<JingquArea> alResult = new List<JingquArea>();
				
				foreach(DataRow dr in dt.Rows)
				{
					alResult.Add(Dr2Obj(dr,cne));
				}
				
				return alResult;
			}

			/// <summary>
			/// 将DataTabe转换成的JingquArea对象集合(默认列名映射为属性名)
			/// </summary>
			/// <param name="dt">由CreateTable生成的DataTable</param>
			/// <returns>JingquArea对象的集合</returns>
			public static List<JingquArea> Dt2Objs(DataTable dt)
			{
				return Dt2Objs(dt,ColumnNameEnum.DBName);
			}
			
			/// <summary>
			/// 用objs的JingquArea对象集合填充DataTable
			/// </summary>
			/// <param name="dt">由CreateTable生成的DataTable</param>
			/// <param name="objs">JingquArea对象集合</param>
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
				
				foreach(JingquArea obj in objs)
				{
					DataRow dr = dt.NewRow();
					obj.FillDataRow(dr,cne);
					dt.Rows.Add(dr);
				}
			}

			/// <summary>
			/// 用objs的JingquArea对象集合填充DataTable(默认列名映射为属性名)
			/// </summary>
			/// <param name="dt">由CreateTable生成的DataTable</param>
			/// <param name="objs">JingquArea对象集合</param>
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
			JingquArea old = this.OldValue as JingquArea;
			if (old != null)
			{
					this.Jingquareaid = old.Jingquareaid;
					this.Jinqqucode = old.Jinqqucode;
					this.Areaname = old.Areaname;				
				this.OldValue = null;
			}
		}
		
		
		
		
		#region JingquArea实体的内部Key类
			/// <summary>
			/// JingquArea实体的Key类
			/// </summary>
			public class Key
			{
		
				private int m_Jingquareaid;
				public int Jingquareaid
				{
 					get 
					{ 
						 return m_Jingquareaid; 
					}
					set 
					{ 
						m_Jingquareaid = value;
					}
				}
		
				public Key(int pJingquareaid)
				{
					m_Jingquareaid=pJingquareaid;

				}
			}
		#endregion
			/// <summary>
			/// 得到实体JingquArea的PK
			/// </summary>
			public Key GetKey()
			{
				return new Key(Jingquareaid);				
			}
	
		
		#endregion
	}
}
