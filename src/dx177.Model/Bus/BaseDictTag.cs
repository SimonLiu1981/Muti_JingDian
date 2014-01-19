/*
版权所有：版权所有(C) 2011，刘建新
文件编号：M01_BaseDictTag.cs
文件名称：BaseDictTag.cs
系统编号：Z0003007
系统名称：通用办公系统
模块编号：M01
模块名称：信息发布
设计文档：IOA_M01信息发布XDE建模.mdx
完成日期：2011/3/24
作　　者：
内容摘要：表[Base_Dict_Tag]对应的实体类
*/

using System;
using System.Collections;
using System.Data;
using System.Collections.Generic;


namespace dx177.Model.Bus
{
		/// <summary>
		/// 类 编 号：
		/// 类 名 称：BaseDictTag
		/// 内容摘要：
		/// </summary>
		
		[Serializable]
		public class BaseDictTag : BaseModel
		{
		#region 自动生成代码
		
			#region 重载Equals/GetHashCode
			/// <summary>
			/// 重载Equals			
			/// </summary>
			public override bool Equals (Object obj)
			{
				if (obj != null && obj is BaseDictTag)
				{
					if (obj == this)
						return true;
					BaseDictTag castObj = (BaseDictTag)obj; 
					
					if (!this.m_BaseDictTagId.Equals(castObj.BaseDictTagId))
						return false;
						
					if (!this.m_EnumTypeName.Equals(castObj.EnumTypeName))
						return false;
						
					if (!this.m_EnumValue.Equals(castObj.EnumValue))
						return false;
						
					if (!this.m_TagName.Equals(castObj.TagName))
						return false;
						
					if (!this.m_EnumName.Equals(castObj.EnumName))
						return false;
						
					if (!this.m_Lcid.Equals(castObj.Lcid))
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
					if ((object)m_BaseDictTagId != null)
					{
						hash = hash ^ m_BaseDictTagId.GetHashCode();
					}
						
					hash = hash <<  8;
					if ((object)m_EnumTypeName != null)
					{
						hash = hash ^ m_EnumTypeName.GetHashCode();
					}
						
					hash = hash <<  8;
					if ((object)m_EnumValue != null)
					{
						hash = hash ^ m_EnumValue.GetHashCode();
					}
						
					hash = hash <<  8;
					if ((object)m_TagName != null)
					{
						hash = hash ^ m_TagName.GetHashCode();
					}
						
					hash = hash <<  8;
					if ((object)m_EnumName != null)
					{
						hash = hash ^ m_EnumName.GetHashCode();
					}
						
					hash = hash <<  8;
					if ((object)m_Lcid != null)
					{
						hash = hash ^ m_Lcid.GetHashCode();
					}
						
					return hash; 
			}
			#endregion
			
			public BaseDictTag()
			{
				MarkNew();
			}						
			
			public BaseDictTag GetOldValue()
			{
				return OldValue as BaseDictTag;
			}
		
		#region BaseDictTagId属性
			private int m_BaseDictTagId = 0;
			/// <summary>
			/// 属性名称： BaseDictTagId
			/// 内容摘要： DB列名：Base_Dict_Tag_Id[序列ID]
			///            DB类型：int
			/// </summary>
			public int BaseDictTagId
			{
				get
					{
						return m_BaseDictTagId;
					}
				set
					{
						if (m_BaseDictTagId as object == null || !m_BaseDictTagId.Equals(value))
						{
							m_BaseDictTagId = value;
							MarkUpdated();
						}						
					}
			}
		#endregion
		
		#region EnumTypeName属性
			private string m_EnumTypeName = String.Empty;
			/// <summary>
			/// 属性名称： EnumTypeName
			/// 内容摘要： DB列名：Enum_Type_Name[枚举中的Type.A Type]
			///            DB类型：string
			/// </summary>
			public string EnumTypeName
			{
				get
					{
						return m_EnumTypeName;
					}
				set
					{
						if (m_EnumTypeName as object == null || !m_EnumTypeName.Equals(value))
						{
							m_EnumTypeName = value;
							MarkUpdated();
						}						
					}
			}
		#endregion
		
		#region EnumValue属性
			private string m_EnumValue = String.Empty;
			/// <summary>
			/// 属性名称： EnumValue
			/// 内容摘要： DB列名：Enum_Value[A=1]
			///            DB类型：string
			/// </summary>
			public string EnumValue
			{
				get
					{
						return m_EnumValue;
					}
				set
					{
						if (m_EnumValue as object == null || !m_EnumValue.Equals(value))
						{
							m_EnumValue = value;
							MarkUpdated();
						}						
					}
			}
		#endregion
		
		#region TagName属性
			private string m_TagName = String.Empty;
			/// <summary>
			/// 属性名称： TagName
			/// 内容摘要： DB列名：Tag_Name[显示名]
			///            DB类型：string
			/// </summary>
			public string TagName
			{
				get
					{
						return m_TagName;
					}
				set
					{
						if (m_TagName as object == null || !m_TagName.Equals(value))
						{
							m_TagName = value;
							MarkUpdated();
						}						
					}
			}
		#endregion
		
		#region EnumName属性
			private string m_EnumName = String.Empty;
			/// <summary>
			/// 属性名称： EnumName
			/// 内容摘要： DB列名：Enum_Name[A]
			///            DB类型：string
			/// </summary>
			public string EnumName
			{
				get
					{
						return m_EnumName;
					}
				set
					{
						if (m_EnumName as object == null || !m_EnumName.Equals(value))
						{
							m_EnumName = value;
							MarkUpdated();
						}						
					}
			}
		#endregion
		
		#region Lcid属性
			private int m_Lcid = 0;
			/// <summary>
			/// 属性名称： Lcid
			/// 内容摘要： DB列名：LCID[语言ID]
			///            DB类型：int
			/// </summary>
			public int Lcid
			{
				get
					{
						return m_Lcid;
					}
				set
					{
						if (m_Lcid as object == null || !m_Lcid.Equals(value))
						{
							m_Lcid = value;
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
					dtResult.Columns.Add(new DataColumn("Base_Dict_Tag_Id",typeof(int)));
					dtResult.Columns.Add(new DataColumn("Enum_Type_Name",typeof(string)));
					dtResult.Columns.Add(new DataColumn("Enum_Value",typeof(string)));
					dtResult.Columns.Add(new DataColumn("Tag_Name",typeof(string)));
					dtResult.Columns.Add(new DataColumn("Enum_Name",typeof(string)));
					dtResult.Columns.Add(new DataColumn("LCID",typeof(int)));
				}
				else if (cne == ColumnNameEnum.PropertyName)
				{
					dtResult.Columns.Add(new DataColumn("BaseDictTagId",typeof(int)));
					dtResult.Columns.Add(new DataColumn("EnumTypeName",typeof(string)));
					dtResult.Columns.Add(new DataColumn("EnumValue",typeof(string)));
					dtResult.Columns.Add(new DataColumn("TagName",typeof(string)));
					dtResult.Columns.Add(new DataColumn("EnumName",typeof(string)));
					dtResult.Columns.Add(new DataColumn("Lcid",typeof(int)));
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
					dr["Base_Dict_Tag_Id"] = this.BaseDictTagId;
					dr["Enum_Type_Name"] = this.EnumTypeName;
					dr["Enum_Value"] = this.EnumValue;
					dr["Tag_Name"] = this.TagName;
					dr["Enum_Name"] = this.EnumName;
					dr["LCID"] = this.Lcid;
				}
				else if (ColumnNameEnum.PropertyName == cne)
				{
					dr["BaseDictTagId"] = this.BaseDictTagId;
					dr["EnumTypeName"] = this.EnumTypeName;
					dr["EnumValue"] = this.EnumValue;
					dr["TagName"] = this.TagName;
					dr["EnumName"] = this.EnumName;
					dr["Lcid"] = this.Lcid;					
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
			/// 将DataRow转换成BaseDictTag对象
			/// </summary>
			/// <param name="dr">由CreateTable生成的DataTable通过NewRow得到的DataRow对象</param>
			/// <param name="cne">dr的列名映射方式:DB列名或属性名</param>
			/// <returns>BaseDictTag对象</returns>
			public static BaseDictTag Dr2Obj(DataRow dr,ColumnNameEnum cne)
			{
				if (dr == null)
				{
					throw new ArgumentNullException("dr");
				}
				BaseDictTag obj = new BaseDictTag();
				if (ColumnNameEnum.DBName == cne)
				{
					obj.BaseDictTagId = (dr["Base_Dict_Tag_Id"] == Convert.DBNull) ? 0  : (int)Convert.ChangeType(dr["Base_Dict_Tag_Id"],typeof(int));
					obj.EnumTypeName = (dr["Enum_Type_Name"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Enum_Type_Name"],typeof(string));
					obj.EnumValue = (dr["Enum_Value"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Enum_Value"],typeof(string));
					obj.TagName = (dr["Tag_Name"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Tag_Name"],typeof(string));
					obj.EnumName = (dr["Enum_Name"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Enum_Name"],typeof(string));
					obj.Lcid = (dr["LCID"] == Convert.DBNull) ? 0  : (int)Convert.ChangeType(dr["LCID"],typeof(int));
				}
				else if (ColumnNameEnum.PropertyName == cne)
				{
					obj.BaseDictTagId = (dr["BaseDictTagId"] == Convert.DBNull) ? 0  : (int)Convert.ChangeType(dr["BaseDictTagId"],typeof(int));
					obj.EnumTypeName = (dr["EnumTypeName"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["EnumTypeName"],typeof(string));
					obj.EnumValue = (dr["EnumValue"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["EnumValue"],typeof(string));
					obj.TagName = (dr["TagName"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["TagName"],typeof(string));
					obj.EnumName = (dr["EnumName"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["EnumName"],typeof(string));
					obj.Lcid = (dr["Lcid"] == Convert.DBNull) ? 0  : (int)Convert.ChangeType(dr["Lcid"],typeof(int));		
				}
				
				return obj;
			}
			
			/// <summary>
			/// 将DataRow转换成BaseDictTag对象(默认列名映射为属性名)
			/// </summary>
			/// <returns>BaseDictTag对象</returns>
			public static BaseDictTag Dr2Obj(DataRow dr)
			{
				return Dr2Obj(dr,ColumnNameEnum.DBName);
			}
			
			/// <summary>
			/// 将DataTabe转换成的BaseDictTag对象集合
			/// </summary>
			/// <param name="dt">由CreateTable生成的DataTable</param>
			/// <param name="cne">dt的列名映射方式:DB列名或属性名</param>
			/// <returns>BaseDictTag对象的集合</returns>
			public static List<BaseDictTag> Dt2Objs(DataTable dt,ColumnNameEnum cne)
			{
				if (dt == null)
				{
					throw new ArgumentNullException("dt");
				}
				
				List<BaseDictTag> alResult = new List<BaseDictTag>();
				
				foreach(DataRow dr in dt.Rows)
				{
					alResult.Add(Dr2Obj(dr,cne));
				}
				
				return alResult;
			}

			/// <summary>
			/// 将DataTabe转换成的BaseDictTag对象集合(默认列名映射为属性名)
			/// </summary>
			/// <param name="dt">由CreateTable生成的DataTable</param>
			/// <returns>BaseDictTag对象的集合</returns>
			public static  List<BaseDictTag> Dt2Objs(DataTable dt)
			{
				return Dt2Objs(dt, ColumnNameEnum.DBName);
			}
			
			/// <summary>
			/// 用objs的BaseDictTag对象集合填充DataTable
			/// </summary>
			/// <param name="dt">由CreateTable生成的DataTable</param>
			/// <param name="objs">BaseDictTag对象集合</param>
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
				
				foreach(BaseDictTag obj in objs)
				{
					DataRow dr = dt.NewRow();
					obj.FillDataRow(dr,cne);
					dt.Rows.Add(dr);
				}
			}

			/// <summary>
			/// 用objs的BaseDictTag对象集合填充DataTable(默认列名映射为属性名)
			/// </summary>
			/// <param name="dt">由CreateTable生成的DataTable</param>
			/// <param name="objs">BaseDictTag对象集合</param>
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
			BaseDictTag old = this.OldValue as BaseDictTag;
			if (old != null)
			{
					this.BaseDictTagId = old.BaseDictTagId;
					this.EnumTypeName = old.EnumTypeName;
					this.EnumValue = old.EnumValue;
					this.TagName = old.TagName;
					this.EnumName = old.EnumName;
					this.Lcid = old.Lcid;				
				this.OldValue = null;
			}
		}
		
		
		
		
		#region BaseDictTag实体的内部Key类
			/// <summary>
			/// BaseDictTag实体的Key类
			/// </summary>
			public sealed class Key
			{
		
				private int m_BaseDictTagId;
				public int BaseDictTagId
				{
 					get 
					{ 
						 return m_BaseDictTagId; 
					}
					set 
					{ 
						m_BaseDictTagId = value;
					}
				}
		
				public Key(int pBaseDictTagId)
				{
					m_BaseDictTagId=pBaseDictTagId;

				}
			}
		#endregion
			/// <summary>
			/// 得到实体BaseDictTag的PK
			/// </summary>
			public Key GetKey()
			{
				return new Key(BaseDictTagId);				
			}
			
				
		#endregion
	}
}
