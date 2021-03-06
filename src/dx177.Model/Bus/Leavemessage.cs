/*
版权所有：版权所有(C) 2011，中兴通讯
文件编号：M01_Leavemessage.cs
文件名称：Leavemessage.cs
系统编号：Z0003007
系统名称：通用办公系统
模块编号：M01
模块名称：信息发布
设计文档：IOA_M01信息发布XDE建模.mdx
完成日期：2011-05-16
作　　者：
内容摘要：表[LeaveMessage]对应的实体类
*/

using System;
using System.Collections;
using System.Data;


namespace dx177.Model.Bus
{
		/// <summary>
		/// 类 编 号：
		/// 类 名 称：Leavemessage
		/// 内容摘要：
		/// </summary>
		
		[Serializable]
		public class Leavemessage : BaseModel
		{
		#region 自动生成代码
		
			#region 重载Equals/GetHashCode
			/// <summary>
			/// 重载Equals			
			/// </summary>
			public override bool Equals (Object obj)
			{
				if (obj != null && obj is Leavemessage)
				{
					if (obj == this)
						return true;
					Leavemessage castObj = (Leavemessage)obj; 
					
					if (!this.m_Seqno.Equals(castObj.Seqno))
						return false;
						
					if (!this.m_Guid.Equals(castObj.Guid))
						return false;
						
					if (!this.m_UserName.Equals(castObj.UserName))
						return false;
						
					if (!this.m_UserEmail.Equals(castObj.UserEmail))
						return false;
						
					if (!this.m_Tel.Equals(castObj.Tel))
						return false;
						
					if (!this.m_IsView.Equals(castObj.IsView))
						return false;
						
					if (!this.m_Type.Equals(castObj.Type))
						return false;
						
					if (!this.m_Content.Equals(castObj.Content))
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
					if ((object)m_Guid != null)
					{
						hash = hash ^ m_Guid.GetHashCode();
					}
						
					hash = hash <<  8;
					if ((object)m_UserName != null)
					{
						hash = hash ^ m_UserName.GetHashCode();
					}
						
					hash = hash <<  8;
					if ((object)m_UserEmail != null)
					{
						hash = hash ^ m_UserEmail.GetHashCode();
					}
						
					hash = hash <<  8;
					if ((object)m_Tel != null)
					{
						hash = hash ^ m_Tel.GetHashCode();
					}
						
					hash = hash <<  8;
					if ((object)m_IsView != null)
					{
						hash = hash ^ m_IsView.GetHashCode();
					}
						
					hash = hash <<  8;
					if ((object)m_Type != null)
					{
						hash = hash ^ m_Type.GetHashCode();
					}
						
					hash = hash <<  8;
					if ((object)m_Content != null)
					{
						hash = hash ^ m_Content.GetHashCode();
					}
						
					hash = hash <<  8;
					if ((object)m_CreateDate != null)
					{
						hash = hash ^ m_CreateDate.GetHashCode();
					}
						
					return hash; 
			}
			#endregion
			
			public Leavemessage()
			{
				MarkNew();
			}						
			
			public Leavemessage GetOldValue()
			{
				return OldValue as Leavemessage;
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
		
		#region Guid属性
			private string m_Guid = String.Empty;
			/// <summary>
			/// 属性名称： Guid
			/// 内容摘要： DB列名：GUID[]
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
		
		#region UserName属性
			private string m_UserName = String.Empty;
			/// <summary>
			/// 属性名称： UserName
			/// 内容摘要： DB列名：User_Name[]
			///            DB类型：nvarchar(50)
			/// </summary>
			public string UserName
			{
				get
					{
						return m_UserName;
					}
				set
					{
						if (m_UserName as object == null || !m_UserName.Equals(value))
						{
							m_UserName = value;
							MarkUpdated();
						}						
					}
			}
		#endregion
		
		#region UserEmail属性
			private string m_UserEmail = String.Empty;
			/// <summary>
			/// 属性名称： UserEmail
			/// 内容摘要： DB列名：User_Email[]
			///            DB类型：nvarchar(50)
			/// </summary>
			public string UserEmail
			{
				get
					{
						return m_UserEmail;
					}
				set
					{
						if (m_UserEmail as object == null || !m_UserEmail.Equals(value))
						{
							m_UserEmail = value;
							MarkUpdated();
						}						
					}
			}
		#endregion
		
		#region Tel属性
			private string m_Tel = String.Empty;
			/// <summary>
			/// 属性名称： Tel
			/// 内容摘要： DB列名：Tel[]
			///            DB类型：nvarchar(50)
			/// </summary>
			public string Tel
			{
				get
					{
						return m_Tel;
					}
				set
					{
						if (m_Tel as object == null || !m_Tel.Equals(value))
						{
							m_Tel = value;
							MarkUpdated();
						}						
					}
			}
		#endregion
		
		#region IsView属性
			private int m_IsView = 0;
			/// <summary>
			/// 属性名称： IsView
			/// 内容摘要： DB列名：Is_View[]
			///            DB类型：int
			/// </summary>
			public int IsView
			{
				get
					{
						return m_IsView;
					}
				set
					{
						if (m_IsView as object == null || !m_IsView.Equals(value))
						{
							m_IsView = value;
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
			///            DB类型：nvarchar(10)
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
		
		#region Content属性
			private string m_Content = String.Empty;
			/// <summary>
			/// 属性名称： Content
			/// 内容摘要： DB列名：Content[]
			///            DB类型：nvarchar(255)
			/// </summary>
			public string Content
			{
				get
					{
						return m_Content;
					}
				set
					{
						if (m_Content as object == null || !m_Content.Equals(value))
						{
							m_Content = value;
							MarkUpdated();
						}						
					}
			}
		#endregion
		
		#region CreateDate属性
			private DateTime m_CreateDate = new DateTime(1900,1,1);
			/// <summary>
			/// 属性名称： CreateDate
			/// 内容摘要： DB列名：CREATE_DATE[]
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
					dtResult.Columns.Add(new DataColumn("GUID",typeof(string)));
					dtResult.Columns.Add(new DataColumn("User_Name",typeof(string)));
					dtResult.Columns.Add(new DataColumn("User_Email",typeof(string)));
					dtResult.Columns.Add(new DataColumn("Tel",typeof(string)));
					dtResult.Columns.Add(new DataColumn("Is_View",typeof(int)));
					dtResult.Columns.Add(new DataColumn("type",typeof(string)));
					dtResult.Columns.Add(new DataColumn("Content",typeof(string)));
					dtResult.Columns.Add(new DataColumn("CREATE_DATE",typeof(DateTime)));
				}
				else if (cne == ColumnNameEnum.PropertyName)
				{
					dtResult.Columns.Add(new DataColumn("Seqno",typeof(int)));
					dtResult.Columns.Add(new DataColumn("Guid",typeof(string)));
					dtResult.Columns.Add(new DataColumn("UserName",typeof(string)));
					dtResult.Columns.Add(new DataColumn("UserEmail",typeof(string)));
					dtResult.Columns.Add(new DataColumn("Tel",typeof(string)));
					dtResult.Columns.Add(new DataColumn("IsView",typeof(int)));
					dtResult.Columns.Add(new DataColumn("Type",typeof(string)));
					dtResult.Columns.Add(new DataColumn("Content",typeof(string)));
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
					dr["GUID"] = this.Guid;
					dr["User_Name"] = this.UserName;
					dr["User_Email"] = this.UserEmail;
					dr["Tel"] = this.Tel;
					dr["Is_View"] = this.IsView;
					dr["type"] = this.Type;
					dr["Content"] = this.Content;
					dr["CREATE_DATE"] = this.CreateDate;
				}
				else if (ColumnNameEnum.PropertyName == cne)
				{
					dr["Seqno"] = this.Seqno;
					dr["Guid"] = this.Guid;
					dr["UserName"] = this.UserName;
					dr["UserEmail"] = this.UserEmail;
					dr["Tel"] = this.Tel;
					dr["IsView"] = this.IsView;
					dr["Type"] = this.Type;
					dr["Content"] = this.Content;
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
			/// 将DataRow转换成Leavemessage对象
			/// </summary>
			/// <param name="dr">由CreateTable生成的DataTable通过NewRow得到的DataRow对象</param>
			/// <param name="cne">dr的列名映射方式:DB列名或属性名</param>
			/// <returns>Leavemessage对象</returns>
			public static Leavemessage Dr2Obj(DataRow dr,ColumnNameEnum cne)
			{
				if (dr == null)
				{
					throw new ArgumentNullException("dr");
				}
				Leavemessage obj = new Leavemessage();
				if (ColumnNameEnum.DBName == cne)
				{
					obj.Seqno = (dr["Seqno"] == Convert.DBNull) ? 0  : (int)Convert.ChangeType(dr["Seqno"],typeof(int));
					obj.Guid = (dr["GUID"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["GUID"],typeof(string));
					obj.UserName = (dr["User_Name"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["User_Name"],typeof(string));
					obj.UserEmail = (dr["User_Email"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["User_Email"],typeof(string));
					obj.Tel = (dr["Tel"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Tel"],typeof(string));
					obj.IsView = (dr["Is_View"] == Convert.DBNull) ? 0  : (int)Convert.ChangeType(dr["Is_View"],typeof(int));
					obj.Type = (dr["type"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["type"],typeof(string));
					obj.Content = (dr["Content"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Content"],typeof(string));
					obj.CreateDate = (dr["CREATE_DATE"] == Convert.DBNull) ? new DateTime(1900,1,1)  : (DateTime)Convert.ChangeType(dr["CREATE_DATE"],typeof(DateTime));
				}
				else if (ColumnNameEnum.PropertyName == cne)
				{
					obj.Seqno = (dr["Seqno"] == Convert.DBNull) ? 0  : (int)Convert.ChangeType(dr["Seqno"],typeof(int));
					obj.Guid = (dr["Guid"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Guid"],typeof(string));
					obj.UserName = (dr["UserName"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["UserName"],typeof(string));
					obj.UserEmail = (dr["UserEmail"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["UserEmail"],typeof(string));
					obj.Tel = (dr["Tel"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Tel"],typeof(string));
					obj.IsView = (dr["IsView"] == Convert.DBNull) ? 0  : (int)Convert.ChangeType(dr["IsView"],typeof(int));
					obj.Type = (dr["Type"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Type"],typeof(string));
					obj.Content = (dr["Content"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Content"],typeof(string));
					obj.CreateDate = (dr["CreateDate"] == Convert.DBNull) ? new DateTime(1900,1,1)  : (DateTime)Convert.ChangeType(dr["CreateDate"],typeof(DateTime));		
				}
				
				return obj;
			}
			
			/// <summary>
			/// 将DataRow转换成Leavemessage对象(默认列名映射为属性名)
			/// </summary>
			/// <returns>Leavemessage对象</returns>
			public static Leavemessage Dr2Obj(DataRow dr)
			{
				return Dr2Obj(dr,ColumnNameEnum.PropertyName);
			}
			
			/// <summary>
			/// 将DataTabe转换成的Leavemessage对象集合
			/// </summary>
			/// <param name="dt">由CreateTable生成的DataTable</param>
			/// <param name="cne">dt的列名映射方式:DB列名或属性名</param>
			/// <returns>Leavemessage对象的集合</returns>
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
			/// 将DataTabe转换成的Leavemessage对象集合(默认列名映射为属性名)
			/// </summary>
			/// <param name="dt">由CreateTable生成的DataTable</param>
			/// <returns>Leavemessage对象的集合</returns>
			public static IList Dt2Objs(DataTable dt)
			{
				return Dt2Objs(dt,ColumnNameEnum.PropertyName);
			}
			
			/// <summary>
			/// 用objs的Leavemessage对象集合填充DataTable
			/// </summary>
			/// <param name="dt">由CreateTable生成的DataTable</param>
			/// <param name="objs">Leavemessage对象集合</param>
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
				
				foreach(Leavemessage obj in objs)
				{
					DataRow dr = dt.NewRow();
					obj.FillDataRow(dr,cne);
					dt.Rows.Add(dr);
				}
			}

			/// <summary>
			/// 用objs的Leavemessage对象集合填充DataTable(默认列名映射为属性名)
			/// </summary>
			/// <param name="dt">由CreateTable生成的DataTable</param>
			/// <param name="objs">Leavemessage对象集合</param>
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
			Leavemessage old = this.OldValue as Leavemessage;
			if (old != null)
			{
					this.Seqno = old.Seqno;
					this.Guid = old.Guid;
					this.UserName = old.UserName;
					this.UserEmail = old.UserEmail;
					this.Tel = old.Tel;
					this.IsView = old.IsView;
					this.Type = old.Type;
					this.Content = old.Content;
					this.CreateDate = old.CreateDate;				
				this.OldValue = null;
			}
		}
		
		
		
		
		#region Leavemessage实体的内部Key类
			/// <summary>
			/// Leavemessage实体的Key类
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
			/// 得到实体Leavemessage的PK
			/// </summary>
			public Key GetKey()
			{
				return new Key(Seqno);				
			}
	
		
		#endregion
	}
}
