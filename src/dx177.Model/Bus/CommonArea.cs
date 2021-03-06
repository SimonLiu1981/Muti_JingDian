/*
版权所有：版权所有(C) 2012，中兴通讯
文件编号：M01_CommonArea.cs
文件名称：CommonArea.cs
系统编号：Z0003007
系统名称：通用办公系统
模块编号：M01
模块名称：信息发布
设计文档：IOA_M01信息发布XDE建模.mdx
完成日期：2012/9/9
作　　者：
内容摘要：表[common_Area]对应的实体类
*/

using System;
using System.Collections;
using System.Data;
using System.Collections.Generic;


namespace dx177.Model.Bus
{
		/// <summary>
		/// 类 编 号：
		/// 类 名 称：CommonArea
		/// 内容摘要：
		/// </summary>
		
		[Serializable]
		public class CommonArea : BaseModel
		{
		#region 自动生成代码
		
			#region 重载Equals/GetHashCode
			/// <summary>
			/// 重载Equals			
			/// </summary>
			public override bool Equals (Object obj)
			{
				if (obj != null && obj is CommonArea)
				{
					if (obj == this)
						return true;
					CommonArea castObj = (CommonArea)obj; 
					
					if (!this.m_Areaid.Equals(castObj.Areaid))
						return false;
						
					if (!this.m_Areaname.Equals(castObj.Areaname))
						return false;
						
					if (!this.m_Pareaid.Equals(castObj.Pareaid))
						return false;
						
					if (!this.m_Childamount.Equals(castObj.Childamount))
						return false;
						
					if (!this.m_Depth.Equals(castObj.Depth))
						return false;
						
					if (!this.m_Sort.Equals(castObj.Sort))
						return false;
						
					if (!this.m_Isopen.Equals(castObj.Isopen))
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
					if ((object)m_Areaid != null)
					{
						hash = hash ^ m_Areaid.GetHashCode();
					}
						
					hash = hash <<  8;
					if ((object)m_Areaname != null)
					{
						hash = hash ^ m_Areaname.GetHashCode();
					}
						
					hash = hash <<  8;
					if ((object)m_Pareaid != null)
					{
						hash = hash ^ m_Pareaid.GetHashCode();
					}
						
					hash = hash <<  8;
					if ((object)m_Childamount != null)
					{
						hash = hash ^ m_Childamount.GetHashCode();
					}
						
					hash = hash <<  8;
					if ((object)m_Depth != null)
					{
						hash = hash ^ m_Depth.GetHashCode();
					}
						
					hash = hash <<  8;
					if ((object)m_Sort != null)
					{
						hash = hash ^ m_Sort.GetHashCode();
					}
						
					hash = hash <<  8;
					if ((object)m_Isopen != null)
					{
						hash = hash ^ m_Isopen.GetHashCode();
					}
						
					return hash; 
			}
			#endregion
			
			public CommonArea()
			{
				MarkNew();
			}						
			
			public CommonArea GetOldValue()
			{
				return OldValue as CommonArea;
			}
		
		#region Areaid属性
			private int m_Areaid = 0;
			/// <summary>
			/// 属性名称： Areaid
			/// 内容摘要： DB列名：AreaID[]
			///            DB类型：int
			/// </summary>
			public int Areaid
			{
				get
					{
						return m_Areaid;
					}
				set
					{
						if (m_Areaid as object == null || !m_Areaid.Equals(value))
						{
							m_Areaid = value;
							MarkUpdated();
						}						
					}
			}
		#endregion
		
		#region Areaname属性
			private string m_Areaname = String.Empty;
			/// <summary>
			/// 属性名称： Areaname
			/// 内容摘要： DB列名：AreaName[]
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
		
		#region Pareaid属性
			private int m_Pareaid = 0;
			/// <summary>
			/// 属性名称： Pareaid
			/// 内容摘要： DB列名：PAreaID[]
			///            DB类型：int
			/// </summary>
			public int Pareaid
			{
				get
					{
						return m_Pareaid;
					}
				set
					{
						if (m_Pareaid as object == null || !m_Pareaid.Equals(value))
						{
							m_Pareaid = value;
							MarkUpdated();
						}						
					}
			}
		#endregion
		
		#region Childamount属性
			private int m_Childamount = 0;
			/// <summary>
			/// 属性名称： Childamount
			/// 内容摘要： DB列名：ChildAmount[]
			///            DB类型：int
			/// </summary>
			public int Childamount
			{
				get
					{
						return m_Childamount;
					}
				set
					{
						if (m_Childamount as object == null || !m_Childamount.Equals(value))
						{
							m_Childamount = value;
							MarkUpdated();
						}						
					}
			}
		#endregion
		
		#region Depth属性
			private int m_Depth = 0;
			/// <summary>
			/// 属性名称： Depth
			/// 内容摘要： DB列名：Depth[]
			///            DB类型：int
			/// </summary>
			public int Depth
			{
				get
					{
						return m_Depth;
					}
				set
					{
						if (m_Depth as object == null || !m_Depth.Equals(value))
						{
							m_Depth = value;
							MarkUpdated();
						}						
					}
			}
		#endregion
		
		#region Sort属性
			private int m_Sort = 0;
			/// <summary>
			/// 属性名称： Sort
			/// 内容摘要： DB列名：Sort[]
			///            DB类型：int
			/// </summary>
			public int Sort
			{
				get
					{
						return m_Sort;
					}
				set
					{
						if (m_Sort as object == null || !m_Sort.Equals(value))
						{
							m_Sort = value;
							MarkUpdated();
						}						
					}
			}
		#endregion
		
		#region Isopen属性
			private bool m_Isopen = false;
			/// <summary>
			/// 属性名称： Isopen
			/// 内容摘要： DB列名：IsOpen[]
			///            DB类型：bit
			/// </summary>
			public bool Isopen
			{
				get
					{
						return m_Isopen;
					}
				set
					{
						if (m_Isopen as object == null || !m_Isopen.Equals(value))
						{
							m_Isopen = value;
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
					dtResult.Columns.Add(new DataColumn("AreaID",typeof(int)));
					dtResult.Columns.Add(new DataColumn("AreaName",typeof(string)));
					dtResult.Columns.Add(new DataColumn("PAreaID",typeof(int)));
					dtResult.Columns.Add(new DataColumn("ChildAmount",typeof(int)));
					dtResult.Columns.Add(new DataColumn("Depth",typeof(int)));
					dtResult.Columns.Add(new DataColumn("Sort",typeof(int)));
					dtResult.Columns.Add(new DataColumn("IsOpen",typeof(bool)));
				}
				else if (cne == ColumnNameEnum.PropertyName)
				{
					dtResult.Columns.Add(new DataColumn("Areaid",typeof(int)));
					dtResult.Columns.Add(new DataColumn("Areaname",typeof(string)));
					dtResult.Columns.Add(new DataColumn("Pareaid",typeof(int)));
					dtResult.Columns.Add(new DataColumn("Childamount",typeof(int)));
					dtResult.Columns.Add(new DataColumn("Depth",typeof(int)));
					dtResult.Columns.Add(new DataColumn("Sort",typeof(int)));
					dtResult.Columns.Add(new DataColumn("Isopen",typeof(bool)));
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
					dr["AreaID"] = this.Areaid;
					dr["AreaName"] = this.Areaname;
					dr["PAreaID"] = this.Pareaid;
					dr["ChildAmount"] = this.Childamount;
					dr["Depth"] = this.Depth;
					dr["Sort"] = this.Sort;
					dr["IsOpen"] = this.Isopen;
				}
				else if (ColumnNameEnum.PropertyName == cne)
				{
					dr["Areaid"] = this.Areaid;
					dr["Areaname"] = this.Areaname;
					dr["Pareaid"] = this.Pareaid;
					dr["Childamount"] = this.Childamount;
					dr["Depth"] = this.Depth;
					dr["Sort"] = this.Sort;
					dr["Isopen"] = this.Isopen;					
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
			/// 将DataRow转换成CommonArea对象
			/// </summary>
			/// <param name="dr">由CreateTable生成的DataTable通过NewRow得到的DataRow对象</param>
			/// <param name="cne">dr的列名映射方式:DB列名或属性名</param>
			/// <returns>CommonArea对象</returns>
			public static CommonArea Dr2Obj(DataRow dr,ColumnNameEnum cne)
			{
				if (dr == null)
				{
					throw new ArgumentNullException("dr");
				}
				CommonArea obj = new CommonArea();
				if (ColumnNameEnum.DBName == cne)
				{
					obj.Areaid = (dr["AreaID"] == Convert.DBNull) ? 0  : (int)Convert.ChangeType(dr["AreaID"],typeof(int));
					obj.Areaname = (dr["AreaName"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["AreaName"],typeof(string));
					obj.Pareaid = (dr["PAreaID"] == Convert.DBNull) ? 0  : (int)Convert.ChangeType(dr["PAreaID"],typeof(int));
					obj.Childamount = (dr["ChildAmount"] == Convert.DBNull) ? 0  : (int)Convert.ChangeType(dr["ChildAmount"],typeof(int));
					obj.Depth = (dr["Depth"] == Convert.DBNull) ? 0  : (int)Convert.ChangeType(dr["Depth"],typeof(int));
					obj.Sort = (dr["Sort"] == Convert.DBNull) ? 0  : (int)Convert.ChangeType(dr["Sort"],typeof(int));
					obj.Isopen = (dr["IsOpen"] == Convert.DBNull) ? false  : (bool)Convert.ChangeType(dr["IsOpen"],typeof(bool));
				}
				else if (ColumnNameEnum.PropertyName == cne)
				{
					obj.Areaid = (dr["Areaid"] == Convert.DBNull) ? 0  : (int)Convert.ChangeType(dr["Areaid"],typeof(int));
					obj.Areaname = (dr["Areaname"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Areaname"],typeof(string));
					obj.Pareaid = (dr["Pareaid"] == Convert.DBNull) ? 0  : (int)Convert.ChangeType(dr["Pareaid"],typeof(int));
					obj.Childamount = (dr["Childamount"] == Convert.DBNull) ? 0  : (int)Convert.ChangeType(dr["Childamount"],typeof(int));
					obj.Depth = (dr["Depth"] == Convert.DBNull) ? 0  : (int)Convert.ChangeType(dr["Depth"],typeof(int));
					obj.Sort = (dr["Sort"] == Convert.DBNull) ? 0  : (int)Convert.ChangeType(dr["Sort"],typeof(int));
					obj.Isopen = (dr["Isopen"] == Convert.DBNull) ? false  : (bool)Convert.ChangeType(dr["Isopen"],typeof(bool));		
				}
				
				return obj;
			}
			
			/// <summary>
			/// 将DataRow转换成CommonArea对象(默认列名映射为属性名)
			/// </summary>
			/// <returns>CommonArea对象</returns>
			public static CommonArea Dr2Obj(DataRow dr)
			{
				return Dr2Obj(dr,ColumnNameEnum.DBName);
			}
			
			/// <summary>
			/// 将DataTabe转换成的CommonArea对象集合
			/// </summary>
			/// <param name="dt">由CreateTable生成的DataTable</param>
			/// <param name="cne">dt的列名映射方式:DB列名或属性名</param>
			/// <returns>CommonArea对象的集合</returns>
			public static List<CommonArea>  Dt2Objs(DataTable dt,ColumnNameEnum cne)
			{
				if (dt == null)
				{
					throw new ArgumentNullException("dt");
				}
				
				 
				List<CommonArea> alResult = new List<CommonArea>();
				
				foreach(DataRow dr in dt.Rows)
				{
					alResult.Add(Dr2Obj(dr,cne));
				}
				
				return alResult;
			}

			/// <summary>
			/// 将DataTabe转换成的CommonArea对象集合(默认列名映射为属性名)
			/// </summary>
			/// <param name="dt">由CreateTable生成的DataTable</param>
			/// <returns>CommonArea对象的集合</returns>
			public static List<CommonArea> Dt2Objs(DataTable dt)
			{
				return Dt2Objs(dt,ColumnNameEnum.DBName);
			}
			
			/// <summary>
			/// 用objs的CommonArea对象集合填充DataTable
			/// </summary>
			/// <param name="dt">由CreateTable生成的DataTable</param>
			/// <param name="objs">CommonArea对象集合</param>
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
				
				foreach(CommonArea obj in objs)
				{
					DataRow dr = dt.NewRow();
					obj.FillDataRow(dr,cne);
					dt.Rows.Add(dr);
				}
			}

			/// <summary>
			/// 用objs的CommonArea对象集合填充DataTable(默认列名映射为属性名)
			/// </summary>
			/// <param name="dt">由CreateTable生成的DataTable</param>
			/// <param name="objs">CommonArea对象集合</param>
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
			CommonArea old = this.OldValue as CommonArea;
			if (old != null)
			{
					this.Areaid = old.Areaid;
					this.Areaname = old.Areaname;
					this.Pareaid = old.Pareaid;
					this.Childamount = old.Childamount;
					this.Depth = old.Depth;
					this.Sort = old.Sort;
					this.Isopen = old.Isopen;				
				this.OldValue = null;
			}
		}
		
		
		
		
		#region CommonArea实体的内部Key类
			/// <summary>
			/// CommonArea实体的Key类
			/// </summary>
			public class Key
			{
		
				private int m_Areaid;
				public int Areaid
				{
 					get 
					{ 
						 return m_Areaid; 
					}
					set 
					{ 
						m_Areaid = value;
					}
				}
		
				public Key(int pAreaid)
				{
					m_Areaid=pAreaid;

				}
			}
		#endregion
			/// <summary>
			/// 得到实体CommonArea的PK
			/// </summary>
			public Key GetKey()
			{
				return new Key(Areaid);				
			}
	
		
		#endregion
	}
}
