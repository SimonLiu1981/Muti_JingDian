/*
版权所有：版权所有(C) 2012，中兴通讯
文件编号：M01_Syscodemap.cs
文件名称：Syscodemap.cs
系统编号：Z0003007
系统名称：通用办公系统
模块编号：M01
模块名称：信息发布
设计文档：IOA_M01信息发布XDE建模.mdx
完成日期：2012/6/22
作　　者：
内容摘要：表[SysCodeMap]对应的实体类
*/

using System;
using System.Collections;
using System.Data;
using System.Collections.Generic;


namespace dx177.Model.Bus
{
		/// <summary>
		/// 类 编 号：
		/// 类 名 称：Syscodemap
		/// 内容摘要：
		/// </summary>
		
		[Serializable]
		public class Syscodemap : BaseModel
		{
		#region 自动生成代码
		
			#region 重载Equals/GetHashCode
			/// <summary>
			/// 重载Equals			
			/// </summary>
			public override bool Equals (Object obj)
			{
				if (obj != null && obj is Syscodemap)
				{
					if (obj == this)
						return true;
					Syscodemap castObj = (Syscodemap)obj; 
					
					if (!this.m_SyscodemapId.Equals(castObj.SyscodemapId))
						return false;
						
					if (!this.m_Name.Equals(castObj.Name))
						return false;
						
					if (!this.m_Val.Equals(castObj.Val))
						return false;
						
					if (!this.m_Type.Equals(castObj.Type))
						return false;
						
					if (!this.m_Typename.Equals(castObj.Typename))
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
					if ((object)m_SyscodemapId != null)
					{
						hash = hash ^ m_SyscodemapId.GetHashCode();
					}
						
					hash = hash <<  8;
					if ((object)m_Name != null)
					{
						hash = hash ^ m_Name.GetHashCode();
					}
						
					hash = hash <<  8;
					if ((object)m_Val != null)
					{
						hash = hash ^ m_Val.GetHashCode();
					}
						
					hash = hash <<  8;
					if ((object)m_Type != null)
					{
						hash = hash ^ m_Type.GetHashCode();
					}
						
					hash = hash <<  8;
					if ((object)m_Typename != null)
					{
						hash = hash ^ m_Typename.GetHashCode();
					}
						
					hash = hash <<  8;
					if ((object)m_Jingqucode != null)
					{
						hash = hash ^ m_Jingqucode.GetHashCode();
					}
						
					return hash; 
			}
			#endregion
			
			public Syscodemap()
			{
				MarkNew();
			}						
			
			public Syscodemap GetOldValue()
			{
				return OldValue as Syscodemap;
			}
		
		#region SyscodemapId属性
			private int m_SyscodemapId = 0;
			/// <summary>
			/// 属性名称： SyscodemapId
			/// 内容摘要： DB列名：SysCodeMap_Id[]
			///            DB类型：int
			/// </summary>
			public int SyscodemapId
			{
				get
					{
						return m_SyscodemapId;
					}
				set
					{
						if (m_SyscodemapId as object == null || !m_SyscodemapId.Equals(value))
						{
							m_SyscodemapId = value;
							MarkUpdated();
						}						
					}
			}
		#endregion
		
		#region Name属性
			private string m_Name = String.Empty;
			/// <summary>
			/// 属性名称： Name
			/// 内容摘要： DB列名：name[]
			///            DB类型：nvarchar(50)
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
		
		#region Val属性
			private string m_Val = String.Empty;
			/// <summary>
			/// 属性名称： Val
			/// 内容摘要： DB列名：val[]
			///            DB类型：nvarchar(50)
			/// </summary>
			public string Val
			{
				get
					{
						return m_Val;
					}
				set
					{
						if (m_Val as object == null || !m_Val.Equals(value))
						{
							m_Val = value;
							MarkUpdated();
						}						
					}
			}
		#endregion
		
		#region Type属性
			private string m_Type = String.Empty;
			/// <summary>
			/// 属性名称： Type
			/// 内容摘要： DB列名：type[]
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
		
		#region Typename属性
			private string m_Typename = String.Empty;
			/// <summary>
			/// 属性名称： Typename
			/// 内容摘要： DB列名：TypeName[]
			///            DB类型：nvarchar(50)
			/// </summary>
			public string Typename
			{
				get
					{
						return m_Typename;
					}
				set
					{
						if (m_Typename as object == null || !m_Typename.Equals(value))
						{
							m_Typename = value;
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
					dtResult.Columns.Add(new DataColumn("SysCodeMap_Id",typeof(int)));
					dtResult.Columns.Add(new DataColumn("name",typeof(string)));
					dtResult.Columns.Add(new DataColumn("val",typeof(string)));
					dtResult.Columns.Add(new DataColumn("type",typeof(string)));
					dtResult.Columns.Add(new DataColumn("TypeName",typeof(string)));
					dtResult.Columns.Add(new DataColumn("JingQuCode",typeof(string)));
				}
				else if (cne == ColumnNameEnum.PropertyName)
				{
					dtResult.Columns.Add(new DataColumn("SyscodemapId",typeof(int)));
					dtResult.Columns.Add(new DataColumn("Name",typeof(string)));
					dtResult.Columns.Add(new DataColumn("Val",typeof(string)));
					dtResult.Columns.Add(new DataColumn("Type",typeof(string)));
					dtResult.Columns.Add(new DataColumn("Typename",typeof(string)));
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
					dr["SysCodeMap_Id"] = this.SyscodemapId;
					dr["name"] = this.Name;
					dr["val"] = this.Val;
					dr["type"] = this.Type;
					dr["TypeName"] = this.Typename;
					dr["JingQuCode"] = this.Jingqucode;
				}
				else if (ColumnNameEnum.PropertyName == cne)
				{
					dr["SyscodemapId"] = this.SyscodemapId;
					dr["Name"] = this.Name;
					dr["Val"] = this.Val;
					dr["Type"] = this.Type;
					dr["Typename"] = this.Typename;
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
			/// 将DataRow转换成Syscodemap对象
			/// </summary>
			/// <param name="dr">由CreateTable生成的DataTable通过NewRow得到的DataRow对象</param>
			/// <param name="cne">dr的列名映射方式:DB列名或属性名</param>
			/// <returns>Syscodemap对象</returns>
			public static Syscodemap Dr2Obj(DataRow dr,ColumnNameEnum cne)
			{
				if (dr == null)
				{
					throw new ArgumentNullException("dr");
				}
				Syscodemap obj = new Syscodemap();
				if (ColumnNameEnum.DBName == cne)
				{
					obj.SyscodemapId = (dr["SysCodeMap_Id"] == Convert.DBNull) ? 0  : (int)Convert.ChangeType(dr["SysCodeMap_Id"],typeof(int));
					obj.Name = (dr["name"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["name"],typeof(string));
					obj.Val = (dr["val"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["val"],typeof(string));
					obj.Type = (dr["type"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["type"],typeof(string));
					obj.Typename = (dr["TypeName"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["TypeName"],typeof(string));
					obj.Jingqucode = (dr["JingQuCode"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["JingQuCode"],typeof(string));
				}
				else if (ColumnNameEnum.PropertyName == cne)
				{
					obj.SyscodemapId = (dr["SyscodemapId"] == Convert.DBNull) ? 0  : (int)Convert.ChangeType(dr["SyscodemapId"],typeof(int));
					obj.Name = (dr["Name"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Name"],typeof(string));
					obj.Val = (dr["Val"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Val"],typeof(string));
					obj.Type = (dr["Type"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Type"],typeof(string));
					obj.Typename = (dr["Typename"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Typename"],typeof(string));
					obj.Jingqucode = (dr["Jingqucode"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Jingqucode"],typeof(string));		
				}
				
				return obj;
			}
			
			/// <summary>
			/// 将DataRow转换成Syscodemap对象(默认列名映射为属性名)
			/// </summary>
			/// <returns>Syscodemap对象</returns>
			public static Syscodemap Dr2Obj(DataRow dr)
			{
				return Dr2Obj(dr,ColumnNameEnum.DBName);
			}
			
			/// <summary>
			/// 将DataTabe转换成的Syscodemap对象集合
			/// </summary>
			/// <param name="dt">由CreateTable生成的DataTable</param>
			/// <param name="cne">dt的列名映射方式:DB列名或属性名</param>
			/// <returns>Syscodemap对象的集合</returns>
			public static List<Syscodemap>  Dt2Objs(DataTable dt,ColumnNameEnum cne)
			{
				if (dt == null)
				{
					throw new ArgumentNullException("dt");
				}
				
				 
				List<Syscodemap> alResult = new List<Syscodemap>();
				
				foreach(DataRow dr in dt.Rows)
				{
					alResult.Add(Dr2Obj(dr,cne));
				}
				
				return alResult;
			}

			/// <summary>
			/// 将DataTabe转换成的Syscodemap对象集合(默认列名映射为属性名)
			/// </summary>
			/// <param name="dt">由CreateTable生成的DataTable</param>
			/// <returns>Syscodemap对象的集合</returns>
			public static List<Syscodemap> Dt2Objs(DataTable dt)
			{
				return Dt2Objs(dt,ColumnNameEnum.DBName);
			}
			
			/// <summary>
			/// 用objs的Syscodemap对象集合填充DataTable
			/// </summary>
			/// <param name="dt">由CreateTable生成的DataTable</param>
			/// <param name="objs">Syscodemap对象集合</param>
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
				
				foreach(Syscodemap obj in objs)
				{
					DataRow dr = dt.NewRow();
					obj.FillDataRow(dr,cne);
					dt.Rows.Add(dr);
				}
			}

			/// <summary>
			/// 用objs的Syscodemap对象集合填充DataTable(默认列名映射为属性名)
			/// </summary>
			/// <param name="dt">由CreateTable生成的DataTable</param>
			/// <param name="objs">Syscodemap对象集合</param>
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
			Syscodemap old = this.OldValue as Syscodemap;
			if (old != null)
			{
					this.SyscodemapId = old.SyscodemapId;
					this.Name = old.Name;
					this.Val = old.Val;
					this.Type = old.Type;
					this.Typename = old.Typename;
					this.Jingqucode = old.Jingqucode;				
				this.OldValue = null;
			}
		}
		
		
		
		
		#region Syscodemap实体的内部Key类
			/// <summary>
			/// Syscodemap实体的Key类
			/// </summary>
			public class Key
			{
		
				private int m_SyscodemapId;
				public int SyscodemapId
				{
 					get 
					{ 
						 return m_SyscodemapId; 
					}
					set 
					{ 
						m_SyscodemapId = value;
					}
				}
		
				public Key(int pSyscodemapId)
				{
					m_SyscodemapId=pSyscodemapId;

				}
			}
		#endregion
			/// <summary>
			/// 得到实体Syscodemap的PK
			/// </summary>
			public Key GetKey()
			{
				return new Key(SyscodemapId);				
			}
	
		
		#endregion
	}
}
