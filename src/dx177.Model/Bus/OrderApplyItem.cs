/*
版权所有：版权所有(C) 2011，中兴通讯
文件编号：M01_OrderApplyItem.cs
文件名称：OrderApplyItem.cs
系统编号：Z0003007
系统名称：通用办公系统
模块编号：M01
模块名称：信息发布
设计文档：IOA_M01信息发布XDE建模.mdx
完成日期：2011-04-30
作　　者：
内容摘要：表[Order_Apply_Item]对应的实体类
*/

using System;
using System.Collections;
using System.Data;


namespace dx177.Model.Bus
{
		/// <summary>
		/// 类 编 号：
		/// 类 名 称：OrderApplyItem
		/// 内容摘要：
		/// </summary>
		
		[Serializable]
		public class OrderApplyItem : BaseModel
		{
		#region 自动生成代码
		
			#region 重载Equals/GetHashCode
			/// <summary>
			/// 重载Equals			
			/// </summary>
			public override bool Equals (Object obj)
			{
				if (obj != null && obj is OrderApplyItem)
				{
					if (obj == this)
						return true;
					OrderApplyItem castObj = (OrderApplyItem)obj; 
					
					if (!this.m_OrderApplyItemId.Equals(castObj.OrderApplyItemId))
						return false;
						
					if (!this.m_OrderApplyId.Equals(castObj.OrderApplyId))
						return false;
						
					if (!this.m_ProductId.Equals(castObj.ProductId))
						return false;
						
					if (!this.m_ProductType.Equals(castObj.ProductType))
						return false;
						
					if (!this.m_ProductName.Equals(castObj.ProductName))
						return false;
						
					if (!this.m_ProductPrice.Equals(castObj.ProductPrice))
						return false;
						
					if (!this.m_Count.Equals(castObj.Count))
						return false;
						
					if (!this.m_Tatol.Equals(castObj.Tatol))
						return false;
						
					if (!this.m_UnitPrice.Equals(castObj.UnitPrice))
						return false;
						
					if (!this.m_Unit.Equals(castObj.Unit))
						return false;
						
					if (!this.m_Vaild.Equals(castObj.Vaild))
						return false;
						
					if (!this.m_CreateDate.Equals(castObj.CreateDate))
						return false;
						
					if (!this.m_LasteUpdateDate.Equals(castObj.LasteUpdateDate))
						return false;
						
					if (!this.m_ProductBelog.Equals(castObj.ProductBelog))
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
					if ((object)m_OrderApplyItemId != null)
					{
						hash = hash ^ m_OrderApplyItemId.GetHashCode();
					}
						
					hash = hash <<  8;
					if ((object)m_OrderApplyId != null)
					{
						hash = hash ^ m_OrderApplyId.GetHashCode();
					}
						
					hash = hash <<  8;
					if ((object)m_ProductId != null)
					{
						hash = hash ^ m_ProductId.GetHashCode();
					}
						
					hash = hash <<  8;
					if ((object)m_ProductType != null)
					{
						hash = hash ^ m_ProductType.GetHashCode();
					}
						
					hash = hash <<  8;
					if ((object)m_ProductName != null)
					{
						hash = hash ^ m_ProductName.GetHashCode();
					}
						
					hash = hash <<  8;
					if ((object)m_ProductPrice != null)
					{
						hash = hash ^ m_ProductPrice.GetHashCode();
					}
						
					hash = hash <<  8;
					if ((object)m_Count != null)
					{
						hash = hash ^ m_Count.GetHashCode();
					}
						
					hash = hash <<  8;
					if ((object)m_Tatol != null)
					{
						hash = hash ^ m_Tatol.GetHashCode();
					}
						
					hash = hash <<  8;
					if ((object)m_UnitPrice != null)
					{
						hash = hash ^ m_UnitPrice.GetHashCode();
					}
						
					hash = hash <<  8;
					if ((object)m_Unit != null)
					{
						hash = hash ^ m_Unit.GetHashCode();
					}
						
					hash = hash <<  8;
					if ((object)m_Vaild != null)
					{
						hash = hash ^ m_Vaild.GetHashCode();
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
					if ((object)m_ProductBelog != null)
					{
						hash = hash ^ m_ProductBelog.GetHashCode();
					}
						
					return hash; 
			}
			#endregion
			
			public OrderApplyItem()
			{
				MarkNew();
			}						
			
			public OrderApplyItem GetOldValue()
			{
				return OldValue as OrderApplyItem;
			}
		
		#region OrderApplyItemId属性
			private int m_OrderApplyItemId = 0;
			/// <summary>
			/// 属性名称： OrderApplyItemId
			/// 内容摘要： DB列名：Order_Apply_Item_ID[]
			///            DB类型：int
			/// </summary>
			public int OrderApplyItemId
			{
				get
					{
						return m_OrderApplyItemId;
					}
				set
					{
						if (m_OrderApplyItemId as object == null || !m_OrderApplyItemId.Equals(value))
						{
							m_OrderApplyItemId = value;
							MarkUpdated();
						}						
					}
			}
		#endregion
		
		#region OrderApplyId属性
			private int m_OrderApplyId = 0;
			/// <summary>
			/// 属性名称： OrderApplyId
			/// 内容摘要： DB列名：Order_Apply_ID[]
			///            DB类型：int
			/// </summary>
			public int OrderApplyId
			{
				get
					{
						return m_OrderApplyId;
					}
				set
					{
						if (m_OrderApplyId as object == null || !m_OrderApplyId.Equals(value))
						{
							m_OrderApplyId = value;
							MarkUpdated();
						}						
					}
			}
		#endregion
		
		#region ProductId属性
			private int m_ProductId = 0;
			/// <summary>
			/// 属性名称： ProductId
			/// 内容摘要： DB列名：Product_ID[]
			///            DB类型：int
			/// </summary>
			public int ProductId
			{
				get
					{
						return m_ProductId;
					}
				set
					{
						if (m_ProductId as object == null || !m_ProductId.Equals(value))
						{
							m_ProductId = value;
							MarkUpdated();
						}						
					}
			}
		#endregion
		
		#region ProductType属性
			private string m_ProductType = String.Empty;
			/// <summary>
			/// 属性名称： ProductType
			/// 内容摘要： DB列名：Product_Type[]
			///            DB类型：nvarchar(200)
			/// </summary>
			public string ProductType
			{
				get
					{
						return m_ProductType;
					}
				set
					{
						if (m_ProductType as object == null || !m_ProductType.Equals(value))
						{
							m_ProductType = value;
							MarkUpdated();
						}						
					}
			}
		#endregion
		
		#region ProductName属性
			private string m_ProductName = String.Empty;
			/// <summary>
			/// 属性名称： ProductName
			/// 内容摘要： DB列名：Product_Name[]
			///            DB类型：nvarchar(200)
			/// </summary>
			public string ProductName
			{
				get
					{
						return m_ProductName;
					}
				set
					{
						if (m_ProductName as object == null || !m_ProductName.Equals(value))
						{
							m_ProductName = value;
							MarkUpdated();
						}						
					}
			}
		#endregion
		
		#region ProductPrice属性
			private double m_ProductPrice = 0.0;
			/// <summary>
			/// 属性名称： ProductPrice
			/// 内容摘要： DB列名：Product_Price[]
			///            DB类型：float
			/// </summary>
			public double ProductPrice
			{
				get
					{
						return m_ProductPrice;
					}
				set
					{
						if (m_ProductPrice as object == null || !m_ProductPrice.Equals(value))
						{
							m_ProductPrice = value;
							MarkUpdated();
						}						
					}
			}
		#endregion
		
		#region Count属性
			private int m_Count = 0;
			/// <summary>
			/// 属性名称： Count
			/// 内容摘要： DB列名：Count[]
			///            DB类型：int
			/// </summary>
			public int Count
			{
				get
					{
						return m_Count;
					}
				set
					{
						if (m_Count as object == null || !m_Count.Equals(value))
						{
							m_Count = value;
							MarkUpdated();
						}						
					}
			}
		#endregion
		
		#region Tatol属性
			private double m_Tatol = 0.0;
			/// <summary>
			/// 属性名称： Tatol
			/// 内容摘要： DB列名：Tatol[]
			///            DB类型：float
			/// </summary>
			public double Tatol
			{
				get
					{
						return m_Tatol;
					}
				set
					{
						if (m_Tatol as object == null || !m_Tatol.Equals(value))
						{
							m_Tatol = value;
							MarkUpdated();
						}						
					}
			}
		#endregion
		
		#region UnitPrice属性
			private double m_UnitPrice = 0.0;
			/// <summary>
			/// 属性名称： UnitPrice
			/// 内容摘要： DB列名：Unit_Price[]
			///            DB类型：float
			/// </summary>
			public double UnitPrice
			{
				get
					{
						return m_UnitPrice;
					}
				set
					{
						if (m_UnitPrice as object == null || !m_UnitPrice.Equals(value))
						{
							m_UnitPrice = value;
							MarkUpdated();
						}						
					}
			}
		#endregion
		
		#region Unit属性
			private string m_Unit = String.Empty;
			/// <summary>
			/// 属性名称： Unit
			/// 内容摘要： DB列名：Unit[]
			///            DB类型：nvarchar(50)
			/// </summary>
			public string Unit
			{
				get
					{
						return m_Unit;
					}
				set
					{
						if (m_Unit as object == null || !m_Unit.Equals(value))
						{
							m_Unit = value;
							MarkUpdated();
						}						
					}
			}
		#endregion
		
		#region Vaild属性
			private int m_Vaild = 0;
			/// <summary>
			/// 属性名称： Vaild
			/// 内容摘要： DB列名：Vaild[]
			///            DB类型：int
			/// </summary>
			public int Vaild
			{
				get
					{
						return m_Vaild;
					}
				set
					{
						if (m_Vaild as object == null || !m_Vaild.Equals(value))
						{
							m_Vaild = value;
							MarkUpdated();
						}						
					}
			}
		#endregion
		
		#region CreateDate属性
			private DateTime m_CreateDate = new DateTime(1900,1,1);
			/// <summary>
			/// 属性名称： CreateDate
			/// 内容摘要： DB列名：Create_Date[]
			///            DB类型：datetime
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
			/// 内容摘要： DB列名：Laste_Update_Date[]
			///            DB类型：datetime
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
		
		#region ProductBelog属性
			private string m_ProductBelog = String.Empty;
			/// <summary>
			/// 属性名称： ProductBelog
			/// 内容摘要： DB列名：Product_Belog[]
			///            DB类型：nvarchar(50)
			/// </summary>
			public string ProductBelog
			{
				get
					{
						return m_ProductBelog;
					}
				set
					{
						if (m_ProductBelog as object == null || !m_ProductBelog.Equals(value))
						{
							m_ProductBelog = value;
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
					dtResult.Columns.Add(new DataColumn("Order_Apply_Item_ID",typeof(int)));
					dtResult.Columns.Add(new DataColumn("Order_Apply_ID",typeof(int)));
					dtResult.Columns.Add(new DataColumn("Product_ID",typeof(int)));
					dtResult.Columns.Add(new DataColumn("Product_Type",typeof(string)));
					dtResult.Columns.Add(new DataColumn("Product_Name",typeof(string)));
					dtResult.Columns.Add(new DataColumn("Product_Price",typeof(double)));
					dtResult.Columns.Add(new DataColumn("Count",typeof(int)));
					dtResult.Columns.Add(new DataColumn("Tatol",typeof(double)));
					dtResult.Columns.Add(new DataColumn("Unit_Price",typeof(double)));
					dtResult.Columns.Add(new DataColumn("Unit",typeof(string)));
					dtResult.Columns.Add(new DataColumn("Vaild",typeof(int)));
					dtResult.Columns.Add(new DataColumn("Create_Date",typeof(DateTime)));
					dtResult.Columns.Add(new DataColumn("Laste_Update_Date",typeof(DateTime)));
					dtResult.Columns.Add(new DataColumn("Product_Belog",typeof(string)));
				}
				else if (cne == ColumnNameEnum.PropertyName)
				{
					dtResult.Columns.Add(new DataColumn("OrderApplyItemId",typeof(int)));
					dtResult.Columns.Add(new DataColumn("OrderApplyId",typeof(int)));
					dtResult.Columns.Add(new DataColumn("ProductId",typeof(int)));
					dtResult.Columns.Add(new DataColumn("ProductType",typeof(string)));
					dtResult.Columns.Add(new DataColumn("ProductName",typeof(string)));
					dtResult.Columns.Add(new DataColumn("ProductPrice",typeof(double)));
					dtResult.Columns.Add(new DataColumn("Count",typeof(int)));
					dtResult.Columns.Add(new DataColumn("Tatol",typeof(double)));
					dtResult.Columns.Add(new DataColumn("UnitPrice",typeof(double)));
					dtResult.Columns.Add(new DataColumn("Unit",typeof(string)));
					dtResult.Columns.Add(new DataColumn("Vaild",typeof(int)));
					dtResult.Columns.Add(new DataColumn("CreateDate",typeof(DateTime)));
					dtResult.Columns.Add(new DataColumn("LasteUpdateDate",typeof(DateTime)));
					dtResult.Columns.Add(new DataColumn("ProductBelog",typeof(string)));
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
					dr["Order_Apply_Item_ID"] = this.OrderApplyItemId;
					dr["Order_Apply_ID"] = this.OrderApplyId;
					dr["Product_ID"] = this.ProductId;
					dr["Product_Type"] = this.ProductType;
					dr["Product_Name"] = this.ProductName;
					dr["Product_Price"] = this.ProductPrice;
					dr["Count"] = this.Count;
					dr["Tatol"] = this.Tatol;
					dr["Unit_Price"] = this.UnitPrice;
					dr["Unit"] = this.Unit;
					dr["Vaild"] = this.Vaild;
					dr["Create_Date"] = this.CreateDate;
					dr["Laste_Update_Date"] = this.LasteUpdateDate;
					dr["Product_Belog"] = this.ProductBelog;
				}
				else if (ColumnNameEnum.PropertyName == cne)
				{
					dr["OrderApplyItemId"] = this.OrderApplyItemId;
					dr["OrderApplyId"] = this.OrderApplyId;
					dr["ProductId"] = this.ProductId;
					dr["ProductType"] = this.ProductType;
					dr["ProductName"] = this.ProductName;
					dr["ProductPrice"] = this.ProductPrice;
					dr["Count"] = this.Count;
					dr["Tatol"] = this.Tatol;
					dr["UnitPrice"] = this.UnitPrice;
					dr["Unit"] = this.Unit;
					dr["Vaild"] = this.Vaild;
					dr["CreateDate"] = this.CreateDate;
					dr["LasteUpdateDate"] = this.LasteUpdateDate;
					dr["ProductBelog"] = this.ProductBelog;					
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
			/// 将DataRow转换成OrderApplyItem对象
			/// </summary>
			/// <param name="dr">由CreateTable生成的DataTable通过NewRow得到的DataRow对象</param>
			/// <param name="cne">dr的列名映射方式:DB列名或属性名</param>
			/// <returns>OrderApplyItem对象</returns>
			public static OrderApplyItem Dr2Obj(DataRow dr,ColumnNameEnum cne)
			{
				if (dr == null)
				{
					throw new ArgumentNullException("dr");
				}
				OrderApplyItem obj = new OrderApplyItem();
				if (ColumnNameEnum.DBName == cne)
				{
					obj.OrderApplyItemId = (dr["Order_Apply_Item_ID"] == Convert.DBNull) ? 0  : (int)Convert.ChangeType(dr["Order_Apply_Item_ID"],typeof(int));
					obj.OrderApplyId = (dr["Order_Apply_ID"] == Convert.DBNull) ? 0  : (int)Convert.ChangeType(dr["Order_Apply_ID"],typeof(int));
					obj.ProductId = (dr["Product_ID"] == Convert.DBNull) ? 0  : (int)Convert.ChangeType(dr["Product_ID"],typeof(int));
					obj.ProductType = (dr["Product_Type"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Product_Type"],typeof(string));
					obj.ProductName = (dr["Product_Name"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Product_Name"],typeof(string));
					obj.ProductPrice = (dr["Product_Price"] == Convert.DBNull) ? 0.0  : (double)Convert.ChangeType(dr["Product_Price"],typeof(double));
					obj.Count = (dr["Count"] == Convert.DBNull) ? 0  : (int)Convert.ChangeType(dr["Count"],typeof(int));
					obj.Tatol = (dr["Tatol"] == Convert.DBNull) ? 0.0  : (double)Convert.ChangeType(dr["Tatol"],typeof(double));
					obj.UnitPrice = (dr["Unit_Price"] == Convert.DBNull) ? 0.0  : (double)Convert.ChangeType(dr["Unit_Price"],typeof(double));
					obj.Unit = (dr["Unit"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Unit"],typeof(string));
					obj.Vaild = (dr["Vaild"] == Convert.DBNull) ? 0  : (int)Convert.ChangeType(dr["Vaild"],typeof(int));
					obj.CreateDate = (dr["Create_Date"] == Convert.DBNull) ? new DateTime(1900,1,1)  : (DateTime)Convert.ChangeType(dr["Create_Date"],typeof(DateTime));
					obj.LasteUpdateDate = (dr["Laste_Update_Date"] == Convert.DBNull) ? new DateTime(1900,1,1)  : (DateTime)Convert.ChangeType(dr["Laste_Update_Date"],typeof(DateTime));
					obj.ProductBelog = (dr["Product_Belog"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Product_Belog"],typeof(string));
				}
				else if (ColumnNameEnum.PropertyName == cne)
				{
					obj.OrderApplyItemId = (dr["OrderApplyItemId"] == Convert.DBNull) ? 0  : (int)Convert.ChangeType(dr["OrderApplyItemId"],typeof(int));
					obj.OrderApplyId = (dr["OrderApplyId"] == Convert.DBNull) ? 0  : (int)Convert.ChangeType(dr["OrderApplyId"],typeof(int));
					obj.ProductId = (dr["ProductId"] == Convert.DBNull) ? 0  : (int)Convert.ChangeType(dr["ProductId"],typeof(int));
					obj.ProductType = (dr["ProductType"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["ProductType"],typeof(string));
					obj.ProductName = (dr["ProductName"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["ProductName"],typeof(string));
					obj.ProductPrice = (dr["ProductPrice"] == Convert.DBNull) ? 0.0  : (double)Convert.ChangeType(dr["ProductPrice"],typeof(double));
					obj.Count = (dr["Count"] == Convert.DBNull) ? 0  : (int)Convert.ChangeType(dr["Count"],typeof(int));
					obj.Tatol = (dr["Tatol"] == Convert.DBNull) ? 0.0  : (double)Convert.ChangeType(dr["Tatol"],typeof(double));
					obj.UnitPrice = (dr["UnitPrice"] == Convert.DBNull) ? 0.0  : (double)Convert.ChangeType(dr["UnitPrice"],typeof(double));
					obj.Unit = (dr["Unit"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Unit"],typeof(string));
					obj.Vaild = (dr["Vaild"] == Convert.DBNull) ? 0  : (int)Convert.ChangeType(dr["Vaild"],typeof(int));
					obj.CreateDate = (dr["CreateDate"] == Convert.DBNull) ? new DateTime(1900,1,1)  : (DateTime)Convert.ChangeType(dr["CreateDate"],typeof(DateTime));
					obj.LasteUpdateDate = (dr["LasteUpdateDate"] == Convert.DBNull) ? new DateTime(1900,1,1)  : (DateTime)Convert.ChangeType(dr["LasteUpdateDate"],typeof(DateTime));
					obj.ProductBelog = (dr["ProductBelog"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["ProductBelog"],typeof(string));		
				}
				
				return obj;
			}
			
			/// <summary>
			/// 将DataRow转换成OrderApplyItem对象(默认列名映射为属性名)
			/// </summary>
			/// <returns>OrderApplyItem对象</returns>
			public static OrderApplyItem Dr2Obj(DataRow dr)
			{
				return Dr2Obj(dr,ColumnNameEnum.PropertyName);
			}
			
			/// <summary>
			/// 将DataTabe转换成的OrderApplyItem对象集合
			/// </summary>
			/// <param name="dt">由CreateTable生成的DataTable</param>
			/// <param name="cne">dt的列名映射方式:DB列名或属性名</param>
			/// <returns>OrderApplyItem对象的集合</returns>
			public static IList Dt2Objs(DataTable dt,ColumnNameEnum cne)
			{
				if (dt == null)
				{
					throw new ArgumentNullException("dt");
				}
				
				ArrayList alResult = new ArrayList();
				
				foreach(DataRow dr in dt.Rows)
				{
					alResult.Add(Dr2Obj(dr,cne));
				}
				
				return alResult;
			}

			/// <summary>
			/// 将DataTabe转换成的OrderApplyItem对象集合(默认列名映射为属性名)
			/// </summary>
			/// <param name="dt">由CreateTable生成的DataTable</param>
			/// <returns>OrderApplyItem对象的集合</returns>
			public static IList Dt2Objs(DataTable dt)
			{
				return Dt2Objs(dt,ColumnNameEnum.PropertyName);
			}
			
			/// <summary>
			/// 用objs的OrderApplyItem对象集合填充DataTable
			/// </summary>
			/// <param name="dt">由CreateTable生成的DataTable</param>
			/// <param name="objs">OrderApplyItem对象集合</param>
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
				
				foreach(OrderApplyItem obj in objs)
				{
					DataRow dr = dt.NewRow();
					obj.FillDataRow(dr,cne);
					dt.Rows.Add(dr);
				}
			}

			/// <summary>
			/// 用objs的OrderApplyItem对象集合填充DataTable(默认列名映射为属性名)
			/// </summary>
			/// <param name="dt">由CreateTable生成的DataTable</param>
			/// <param name="objs">OrderApplyItem对象集合</param>
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
			OrderApplyItem old = this.OldValue as OrderApplyItem;
			if (old != null)
			{
					this.OrderApplyItemId = old.OrderApplyItemId;
					this.OrderApplyId = old.OrderApplyId;
					this.ProductId = old.ProductId;
					this.ProductType = old.ProductType;
					this.ProductName = old.ProductName;
					this.ProductPrice = old.ProductPrice;
					this.Count = old.Count;
					this.Tatol = old.Tatol;
					this.UnitPrice = old.UnitPrice;
					this.Unit = old.Unit;
					this.Vaild = old.Vaild;
					this.CreateDate = old.CreateDate;
					this.LasteUpdateDate = old.LasteUpdateDate;
					this.ProductBelog = old.ProductBelog;				
				this.OldValue = null;
			}
		}
		
		
		
		
		#region OrderApplyItem实体的内部Key类
			/// <summary>
			/// OrderApplyItem实体的Key类
			/// </summary>
			public class Key
			{
		
				private int m_OrderApplyItemId;
				public int OrderApplyItemId
				{
 					get 
					{ 
						 return m_OrderApplyItemId; 
					}
					set 
					{ 
						m_OrderApplyItemId = value;
					}
				}
		
				public Key(int pOrderApplyItemId)
				{
					m_OrderApplyItemId=pOrderApplyItemId;

				}
			}
		#endregion
			/// <summary>
			/// 得到实体OrderApplyItem的PK
			/// </summary>
			public Key GetKey()
			{
				return new Key(OrderApplyItemId);				
			}
	
		
		#endregion
	}
}
