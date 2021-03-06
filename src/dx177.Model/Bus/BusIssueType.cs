/*
版权所有：版权所有(C) 2012，中兴通讯
文件编号：M01_BusIssueType.cs
文件名称：BusIssueType.cs
系统编号：Z0003007
系统名称：通用办公系统
模块编号：M01
模块名称：信息发布
设计文档：IOA_M01信息发布XDE建模.mdx
完成日期：2012/6/22
作　　者：
内容摘要：表[Bus_Issue_Type]对应的实体类
*/

using System;
using System.Collections;
using System.Data;
using System.Collections.Generic;


namespace dx177.Model.Bus
{
		/// <summary>
		/// 类 编 号：
		/// 类 名 称：BusIssueType
		/// 内容摘要：
		/// </summary>
		
		[Serializable]
		public class BusIssueType : BaseModel
		{
		#region 自动生成代码
		
			#region 重载Equals/GetHashCode
			/// <summary>
			/// 重载Equals			
			/// </summary>
			public override bool Equals (Object obj)
			{
				if (obj != null && obj is BusIssueType)
				{
					if (obj == this)
						return true;
					BusIssueType castObj = (BusIssueType)obj; 
					
					if (!this.m_BusIssueTypeId.Equals(castObj.BusIssueTypeId))
						return false;
						
					if (!this.m_Jinqqucode.Equals(castObj.Jinqqucode))
						return false;
						
					if (!this.m_BusIssueTypeName.Equals(castObj.BusIssueTypeName))
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
					if ((object)m_BusIssueTypeId != null)
					{
						hash = hash ^ m_BusIssueTypeId.GetHashCode();
					}
						
					hash = hash <<  8;
					if ((object)m_Jinqqucode != null)
					{
						hash = hash ^ m_Jinqqucode.GetHashCode();
					}
						
					hash = hash <<  8;
					if ((object)m_BusIssueTypeName != null)
					{
						hash = hash ^ m_BusIssueTypeName.GetHashCode();
					}
						
					return hash; 
			}
			#endregion
			
			public BusIssueType()
			{
				MarkNew();
			}						
			
			public BusIssueType GetOldValue()
			{
				return OldValue as BusIssueType;
			}
		
		#region BusIssueTypeId属性
			private int m_BusIssueTypeId = 0;
			/// <summary>
			/// 属性名称： BusIssueTypeId
			/// 内容摘要： DB列名：Bus_Issue_Type_Id[]
			///            DB类型：int
			/// </summary>
			public int BusIssueTypeId
			{
				get
					{
						return m_BusIssueTypeId;
					}
				set
					{
						if (m_BusIssueTypeId as object == null || !m_BusIssueTypeId.Equals(value))
						{
							m_BusIssueTypeId = value;
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
		
		#region BusIssueTypeName属性
			private string m_BusIssueTypeName = String.Empty;
			/// <summary>
			/// 属性名称： BusIssueTypeName
			/// 内容摘要： DB列名：Bus_Issue_Type_Name[]
			///            DB类型：nvarchar(200)
			/// </summary>
			public string BusIssueTypeName
			{
				get
					{
						return m_BusIssueTypeName;
					}
				set
					{
						if (m_BusIssueTypeName as object == null || !m_BusIssueTypeName.Equals(value))
						{
							m_BusIssueTypeName = value;
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
					dtResult.Columns.Add(new DataColumn("Bus_Issue_Type_Id",typeof(int)));
					dtResult.Columns.Add(new DataColumn("JinqQuCode",typeof(string)));
					dtResult.Columns.Add(new DataColumn("Bus_Issue_Type_Name",typeof(string)));
				}
				else if (cne == ColumnNameEnum.PropertyName)
				{
					dtResult.Columns.Add(new DataColumn("BusIssueTypeId",typeof(int)));
					dtResult.Columns.Add(new DataColumn("Jinqqucode",typeof(string)));
					dtResult.Columns.Add(new DataColumn("BusIssueTypeName",typeof(string)));
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
					dr["Bus_Issue_Type_Id"] = this.BusIssueTypeId;
					dr["JinqQuCode"] = this.Jinqqucode;
					dr["Bus_Issue_Type_Name"] = this.BusIssueTypeName;
				}
				else if (ColumnNameEnum.PropertyName == cne)
				{
					dr["BusIssueTypeId"] = this.BusIssueTypeId;
					dr["Jinqqucode"] = this.Jinqqucode;
					dr["BusIssueTypeName"] = this.BusIssueTypeName;					
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
			/// 将DataRow转换成BusIssueType对象
			/// </summary>
			/// <param name="dr">由CreateTable生成的DataTable通过NewRow得到的DataRow对象</param>
			/// <param name="cne">dr的列名映射方式:DB列名或属性名</param>
			/// <returns>BusIssueType对象</returns>
			public static BusIssueType Dr2Obj(DataRow dr,ColumnNameEnum cne)
			{
				if (dr == null)
				{
					throw new ArgumentNullException("dr");
				}
				BusIssueType obj = new BusIssueType();
				if (ColumnNameEnum.DBName == cne)
				{
					obj.BusIssueTypeId = (dr["Bus_Issue_Type_Id"] == Convert.DBNull) ? 0  : (int)Convert.ChangeType(dr["Bus_Issue_Type_Id"],typeof(int));
					obj.Jinqqucode = (dr["JinqQuCode"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["JinqQuCode"],typeof(string));
					obj.BusIssueTypeName = (dr["Bus_Issue_Type_Name"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Bus_Issue_Type_Name"],typeof(string));
				}
				else if (ColumnNameEnum.PropertyName == cne)
				{
					obj.BusIssueTypeId = (dr["BusIssueTypeId"] == Convert.DBNull) ? 0  : (int)Convert.ChangeType(dr["BusIssueTypeId"],typeof(int));
					obj.Jinqqucode = (dr["Jinqqucode"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Jinqqucode"],typeof(string));
					obj.BusIssueTypeName = (dr["BusIssueTypeName"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["BusIssueTypeName"],typeof(string));		
				}
				
				return obj;
			}
			
			/// <summary>
			/// 将DataRow转换成BusIssueType对象(默认列名映射为属性名)
			/// </summary>
			/// <returns>BusIssueType对象</returns>
			public static BusIssueType Dr2Obj(DataRow dr)
			{
				return Dr2Obj(dr,ColumnNameEnum.DBName);
			}
			
			/// <summary>
			/// 将DataTabe转换成的BusIssueType对象集合
			/// </summary>
			/// <param name="dt">由CreateTable生成的DataTable</param>
			/// <param name="cne">dt的列名映射方式:DB列名或属性名</param>
			/// <returns>BusIssueType对象的集合</returns>
			public static List<BusIssueType>  Dt2Objs(DataTable dt,ColumnNameEnum cne)
			{
				if (dt == null)
				{
					throw new ArgumentNullException("dt");
				}
				
				 
				List<BusIssueType> alResult = new List<BusIssueType>();
				
				foreach(DataRow dr in dt.Rows)
				{
					alResult.Add(Dr2Obj(dr,cne));
				}
				
				return alResult;
			}

			/// <summary>
			/// 将DataTabe转换成的BusIssueType对象集合(默认列名映射为属性名)
			/// </summary>
			/// <param name="dt">由CreateTable生成的DataTable</param>
			/// <returns>BusIssueType对象的集合</returns>
			public static List<BusIssueType> Dt2Objs(DataTable dt)
			{
				return Dt2Objs(dt,ColumnNameEnum.DBName);
			}
			
			/// <summary>
			/// 用objs的BusIssueType对象集合填充DataTable
			/// </summary>
			/// <param name="dt">由CreateTable生成的DataTable</param>
			/// <param name="objs">BusIssueType对象集合</param>
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
				
				foreach(BusIssueType obj in objs)
				{
					DataRow dr = dt.NewRow();
					obj.FillDataRow(dr,cne);
					dt.Rows.Add(dr);
				}
			}

			/// <summary>
			/// 用objs的BusIssueType对象集合填充DataTable(默认列名映射为属性名)
			/// </summary>
			/// <param name="dt">由CreateTable生成的DataTable</param>
			/// <param name="objs">BusIssueType对象集合</param>
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
			BusIssueType old = this.OldValue as BusIssueType;
			if (old != null)
			{
					this.BusIssueTypeId = old.BusIssueTypeId;
					this.Jinqqucode = old.Jinqqucode;
					this.BusIssueTypeName = old.BusIssueTypeName;				
				this.OldValue = null;
			}
		}
		
		
		
		
		#region BusIssueType实体的内部Key类
			/// <summary>
			/// BusIssueType实体的Key类
			/// </summary>
			public class Key
			{
		
				private int m_BusIssueTypeId;
				public int BusIssueTypeId
				{
 					get 
					{ 
						 return m_BusIssueTypeId; 
					}
					set 
					{ 
						m_BusIssueTypeId = value;
					}
				}
		
				public Key(int pBusIssueTypeId)
				{
					m_BusIssueTypeId=pBusIssueTypeId;

				}
			}
		#endregion
			/// <summary>
			/// 得到实体BusIssueType的PK
			/// </summary>
			public Key GetKey()
			{
				return new Key(BusIssueTypeId);				
			}
	
		
		#endregion
	}
}
