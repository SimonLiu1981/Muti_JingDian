/*
版权所有：版权所有(C) 2011，刘建新
文件编号：M01_Users.cs
文件名称：Users.cs
系统编号：Z0003007
系统名称：通用办公系统
模块编号：M01
模块名称：信息发布
设计文档：IOA_M01信息发布XDE建模.mdx
完成日期：2011/3/24
作　　者：
内容摘要：表[Users]对应的实体类
*/

using System;
using System.Collections;
using System.Data;
using System.Collections.Generic;


namespace dx177.Model.Bus
{
		/// <summary>
		/// 类 编 号：
		/// 类 名 称：Users
		/// 内容摘要：
		/// </summary>
		
		[Serializable]
		public class Users : BaseModel
		{
		#region 自动生成代码
		
			#region 重载Equals/GetHashCode
			/// <summary>
			/// 重载Equals			
			/// </summary>
			public override bool Equals (Object obj)
			{
				if (obj != null && obj is Users)
				{
					if (obj == this)
						return true;
					Users castObj = (Users)obj; 
					
					if (!this.m_Seqno.Equals(castObj.Seqno))
						return false;
						
					if (!this.m_Guid.Equals(castObj.Guid))
						return false;
						
					if (!this.m_Username.Equals(castObj.Username))
						return false;
						
					if (!this.m_Pwd.Equals(castObj.Pwd))
						return false;
						
					if (!this.m_Status.Equals(castObj.Status))
						return false;
						
					if (!this.m_Email.Equals(castObj.Email))
						return false;
						
					if (!this.m_Mobile.Equals(castObj.Mobile))
						return false;
						
					if (!this.m_Creator.Equals(castObj.Creator))
						return false;
						
					if (!this.m_CreateDate.Equals(castObj.CreateDate))
						return false;
						
					if (!this.m_LasteUpdateDate.Equals(castObj.LasteUpdateDate))
						return false;
						
					if (!this.m_LasteUpdateBy.Equals(castObj.LasteUpdateBy))
						return false;
						
					if (!this.m_Usertype.Equals(castObj.Usertype))
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
					if ((object)m_Username != null)
					{
						hash = hash ^ m_Username.GetHashCode();
					}
						
					hash = hash <<  8;
					if ((object)m_Pwd != null)
					{
						hash = hash ^ m_Pwd.GetHashCode();
					}
						
					hash = hash <<  8;
					if ((object)m_Status != null)
					{
						hash = hash ^ m_Status.GetHashCode();
					}
						
					hash = hash <<  8;
					if ((object)m_Email != null)
					{
						hash = hash ^ m_Email.GetHashCode();
					}
						
					hash = hash <<  8;
					if ((object)m_Mobile != null)
					{
						hash = hash ^ m_Mobile.GetHashCode();
					}
						
					hash = hash <<  8;
					if ((object)m_Creator != null)
					{
						hash = hash ^ m_Creator.GetHashCode();
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
					if ((object)m_LasteUpdateBy != null)
					{
						hash = hash ^ m_LasteUpdateBy.GetHashCode();
					}
						
					hash = hash <<  8;
					if ((object)m_Usertype != null)
					{
						hash = hash ^ m_Usertype.GetHashCode();
					}
						
					return hash; 
			}
			#endregion
			
			public Users()
			{
				MarkNew();
			}						
			
			public Users GetOldValue()
			{
				return OldValue as Users;
			}
		
		#region Seqno属性
			private int m_Seqno = 0;
			/// <summary>
			/// 属性名称： Seqno
			/// 内容摘要： DB列名：Seqno[名称]
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
			/// 内容摘要： DB列名：GUID[GUID]
			///            DB类型：string
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
		
		#region Username属性
			private string m_Username = String.Empty;
			/// <summary>
			/// 属性名称： Username
			/// 内容摘要： DB列名：UserName[用户名]
			///            DB类型：string
			/// </summary>
			public string Username
			{
				get
					{
						return m_Username;
					}
				set
					{
						if (m_Username as object == null || !m_Username.Equals(value))
						{
							m_Username = value;
							MarkUpdated();
						}						
					}
			}
		#endregion
		
		#region Pwd属性
			private string m_Pwd = String.Empty;
			/// <summary>
			/// 属性名称： Pwd
			/// 内容摘要： DB列名：Pwd[密码]
			///            DB类型：string
			/// </summary>
			public string Pwd
			{
				get
					{
						return m_Pwd;
					}
				set
					{
						if (m_Pwd as object == null || !m_Pwd.Equals(value))
						{
							m_Pwd = value;
							MarkUpdated();
						}						
					}
			}
		#endregion
		
		#region Status属性
			private int m_Status = 0;
			/// <summary>
			/// 属性名称： Status
			/// 内容摘要： DB列名：Status[状态 1正常状态，0冻结状态]
			///            DB类型：int
			/// </summary>
			public int Status
			{
				get
					{
						return m_Status;
					}
				set
					{
						if (m_Status as object == null || !m_Status.Equals(value))
						{
							m_Status = value;
							MarkUpdated();
						}						
					}
			}
		#endregion
		
		#region Email属性
			private string m_Email = String.Empty;
			/// <summary>
			/// 属性名称： Email
			/// 内容摘要： DB列名：Email[电子邮件]
			///            DB类型：string
			/// </summary>
			public string Email
			{
				get
					{
						return m_Email;
					}
				set
					{
						if (m_Email as object == null || !m_Email.Equals(value))
						{
							m_Email = value;
							MarkUpdated();
						}						
					}
			}
		#endregion
		
		#region Mobile属性
			private string m_Mobile = String.Empty;
			/// <summary>
			/// 属性名称： Mobile
			/// 内容摘要： DB列名：Mobile[手机号码]
			///            DB类型：string
			/// </summary>
			public string Mobile
			{
				get
					{
						return m_Mobile;
					}
				set
					{
						if (m_Mobile as object == null || !m_Mobile.Equals(value))
						{
							m_Mobile = value;
							MarkUpdated();
						}						
					}
			}
		#endregion
		
		#region Creator属性
			private string m_Creator = String.Empty;
			/// <summary>
			/// 属性名称： Creator
			/// 内容摘要： DB列名：CREATOR[创建人]
			///            DB类型：string
			/// </summary>
			public string Creator
			{
				get
					{
						return m_Creator;
					}
				set
					{
						if (m_Creator as object == null || !m_Creator.Equals(value))
						{
							m_Creator = value;
							MarkUpdated();
						}						
					}
			}
		#endregion
		
		#region CreateDate属性
			private DateTime m_CreateDate = new DateTime(1900,1,1);
			/// <summary>
			/// 属性名称： CreateDate
			/// 内容摘要： DB列名：CREATE_DATE[创建时间]
			///            DB类型：DateTime
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
			/// 内容摘要： DB列名：Laste_update_date[最后更新时间]
			///            DB类型：DateTime
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
		
		#region LasteUpdateBy属性
			private string m_LasteUpdateBy = String.Empty;
			/// <summary>
			/// 属性名称： LasteUpdateBy
			/// 内容摘要： DB列名：Laste_update_By[最后更新人]
			///            DB类型：string
			/// </summary>
			public string LasteUpdateBy
			{
				get
					{
						return m_LasteUpdateBy;
					}
				set
					{
						if (m_LasteUpdateBy as object == null || !m_LasteUpdateBy.Equals(value))
						{
							m_LasteUpdateBy = value;
							MarkUpdated();
						}						
					}
			}
		#endregion
		
		#region Usertype属性
			private string m_Usertype = String.Empty;
			/// <summary>
			/// 属性名称： Usertype
			/// 内容摘要： DB列名：UserType[类型]
			///            DB类型：string
			/// </summary>
			public string Usertype
			{
				get
					{
						return m_Usertype;
					}
				set
					{
						if (m_Usertype as object == null || !m_Usertype.Equals(value))
						{
							m_Usertype = value;
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
					dtResult.Columns.Add(new DataColumn("UserName",typeof(string)));
					dtResult.Columns.Add(new DataColumn("Pwd",typeof(string)));
					dtResult.Columns.Add(new DataColumn("Status",typeof(int)));
					dtResult.Columns.Add(new DataColumn("Email",typeof(string)));
					dtResult.Columns.Add(new DataColumn("Mobile",typeof(string)));
					dtResult.Columns.Add(new DataColumn("CREATOR",typeof(string)));
					dtResult.Columns.Add(new DataColumn("CREATE_DATE",typeof(DateTime)));
					dtResult.Columns.Add(new DataColumn("Laste_update_date",typeof(DateTime)));
					dtResult.Columns.Add(new DataColumn("Laste_update_By",typeof(string)));
					dtResult.Columns.Add(new DataColumn("UserType",typeof(string)));
				}
				else if (cne == ColumnNameEnum.PropertyName)
				{
					dtResult.Columns.Add(new DataColumn("Seqno",typeof(int)));
					dtResult.Columns.Add(new DataColumn("Guid",typeof(string)));
					dtResult.Columns.Add(new DataColumn("Username",typeof(string)));
					dtResult.Columns.Add(new DataColumn("Pwd",typeof(string)));
					dtResult.Columns.Add(new DataColumn("Status",typeof(int)));
					dtResult.Columns.Add(new DataColumn("Email",typeof(string)));
					dtResult.Columns.Add(new DataColumn("Mobile",typeof(string)));
					dtResult.Columns.Add(new DataColumn("Creator",typeof(string)));
					dtResult.Columns.Add(new DataColumn("CreateDate",typeof(DateTime)));
					dtResult.Columns.Add(new DataColumn("LasteUpdateDate",typeof(DateTime)));
					dtResult.Columns.Add(new DataColumn("LasteUpdateBy",typeof(string)));
					dtResult.Columns.Add(new DataColumn("Usertype",typeof(string)));
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
					dr["UserName"] = this.Username;
					dr["Pwd"] = this.Pwd;
					dr["Status"] = this.Status;
					dr["Email"] = this.Email;
					dr["Mobile"] = this.Mobile;
					dr["CREATOR"] = this.Creator;
					dr["CREATE_DATE"] = this.CreateDate;
					dr["Laste_update_date"] = this.LasteUpdateDate;
					dr["Laste_update_By"] = this.LasteUpdateBy;
					dr["UserType"] = this.Usertype;
				}
				else if (ColumnNameEnum.PropertyName == cne)
				{
					dr["Seqno"] = this.Seqno;
					dr["Guid"] = this.Guid;
					dr["Username"] = this.Username;
					dr["Pwd"] = this.Pwd;
					dr["Status"] = this.Status;
					dr["Email"] = this.Email;
					dr["Mobile"] = this.Mobile;
					dr["Creator"] = this.Creator;
					dr["CreateDate"] = this.CreateDate;
					dr["LasteUpdateDate"] = this.LasteUpdateDate;
					dr["LasteUpdateBy"] = this.LasteUpdateBy;
					dr["Usertype"] = this.Usertype;					
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
			/// 将DataRow转换成Users对象
			/// </summary>
			/// <param name="dr">由CreateTable生成的DataTable通过NewRow得到的DataRow对象</param>
			/// <param name="cne">dr的列名映射方式:DB列名或属性名</param>
			/// <returns>Users对象</returns>
			public static Users Dr2Obj(DataRow dr,ColumnNameEnum cne)
			{
				if (dr == null)
				{
					throw new ArgumentNullException("dr");
				}
				Users obj = new Users();
				if (ColumnNameEnum.DBName == cne)
				{
					obj.Seqno = (dr["Seqno"] == Convert.DBNull) ? 0  : (int)Convert.ChangeType(dr["Seqno"],typeof(int));
					obj.Guid = (dr["GUID"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["GUID"],typeof(string));
					obj.Username = (dr["UserName"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["UserName"],typeof(string));
					obj.Pwd = (dr["Pwd"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Pwd"],typeof(string));
					obj.Status = (dr["Status"] == Convert.DBNull) ? 0  : (int)Convert.ChangeType(dr["Status"],typeof(int));
					obj.Email = (dr["Email"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Email"],typeof(string));
					obj.Mobile = (dr["Mobile"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Mobile"],typeof(string));
					obj.Creator = (dr["CREATOR"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["CREATOR"],typeof(string));
					obj.CreateDate = (dr["CREATE_DATE"] == Convert.DBNull) ? new DateTime(1900,1,1)  : (DateTime)Convert.ChangeType(dr["CREATE_DATE"],typeof(DateTime));
					obj.LasteUpdateDate = (dr["Laste_update_date"] == Convert.DBNull) ? new DateTime(1900,1,1)  : (DateTime)Convert.ChangeType(dr["Laste_update_date"],typeof(DateTime));
					obj.LasteUpdateBy = (dr["Laste_update_By"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Laste_update_By"],typeof(string));
					obj.Usertype = (dr["UserType"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["UserType"],typeof(string));
				}
				else if (ColumnNameEnum.PropertyName == cne)
				{
					obj.Seqno = (dr["Seqno"] == Convert.DBNull) ? 0  : (int)Convert.ChangeType(dr["Seqno"],typeof(int));
					obj.Guid = (dr["Guid"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Guid"],typeof(string));
					obj.Username = (dr["Username"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Username"],typeof(string));
					obj.Pwd = (dr["Pwd"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Pwd"],typeof(string));
					obj.Status = (dr["Status"] == Convert.DBNull) ? 0  : (int)Convert.ChangeType(dr["Status"],typeof(int));
					obj.Email = (dr["Email"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Email"],typeof(string));
					obj.Mobile = (dr["Mobile"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Mobile"],typeof(string));
					obj.Creator = (dr["Creator"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Creator"],typeof(string));
					obj.CreateDate = (dr["CreateDate"] == Convert.DBNull) ? new DateTime(1900,1,1)  : (DateTime)Convert.ChangeType(dr["CreateDate"],typeof(DateTime));
					obj.LasteUpdateDate = (dr["LasteUpdateDate"] == Convert.DBNull) ? new DateTime(1900,1,1)  : (DateTime)Convert.ChangeType(dr["LasteUpdateDate"],typeof(DateTime));
					obj.LasteUpdateBy = (dr["LasteUpdateBy"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["LasteUpdateBy"],typeof(string));
					obj.Usertype = (dr["Usertype"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Usertype"],typeof(string));		
				}
				
				return obj;
			}
			
			/// <summary>
			/// 将DataRow转换成Users对象(默认列名映射为属性名)
			/// </summary>
			/// <returns>Users对象</returns>
			public static Users Dr2Obj(DataRow dr)
			{
				return Dr2Obj(dr,ColumnNameEnum.DBName);
			}
			
			/// <summary>
			/// 将DataTabe转换成的Users对象集合
			/// </summary>
			/// <param name="dt">由CreateTable生成的DataTable</param>
			/// <param name="cne">dt的列名映射方式:DB列名或属性名</param>
			/// <returns>Users对象的集合</returns>
			public static List<Users> Dt2Objs(DataTable dt,ColumnNameEnum cne)
			{
				if (dt == null)
				{
					throw new ArgumentNullException("dt");
				}
				
				List<Users> alResult = new List<Users>();
				
				foreach(DataRow dr in dt.Rows)
				{
					alResult.Add(Dr2Obj(dr,cne));
				}
				
				return alResult;
			}

			/// <summary>
			/// 将DataTabe转换成的Users对象集合(默认列名映射为属性名)
			/// </summary>
			/// <param name="dt">由CreateTable生成的DataTable</param>
			/// <returns>Users对象的集合</returns>
			public static  List<Users> Dt2Objs(DataTable dt)
			{
				return Dt2Objs(dt, ColumnNameEnum.DBName);
			}
			
			/// <summary>
			/// 用objs的Users对象集合填充DataTable
			/// </summary>
			/// <param name="dt">由CreateTable生成的DataTable</param>
			/// <param name="objs">Users对象集合</param>
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
				
				foreach(Users obj in objs)
				{
					DataRow dr = dt.NewRow();
					obj.FillDataRow(dr,cne);
					dt.Rows.Add(dr);
				}
			}

			/// <summary>
			/// 用objs的Users对象集合填充DataTable(默认列名映射为属性名)
			/// </summary>
			/// <param name="dt">由CreateTable生成的DataTable</param>
			/// <param name="objs">Users对象集合</param>
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
			Users old = this.OldValue as Users;
			if (old != null)
			{
					this.Seqno = old.Seqno;
					this.Guid = old.Guid;
					this.Username = old.Username;
					this.Pwd = old.Pwd;
					this.Status = old.Status;
					this.Email = old.Email;
					this.Mobile = old.Mobile;
					this.Creator = old.Creator;
					this.CreateDate = old.CreateDate;
					this.LasteUpdateDate = old.LasteUpdateDate;
					this.LasteUpdateBy = old.LasteUpdateBy;
					this.Usertype = old.Usertype;				
				this.OldValue = null;
			}
		}
		
		
		
		
		#region Users实体的内部Key类
			/// <summary>
			/// Users实体的Key类
			/// </summary>
			public sealed class Key
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
			/// 得到实体Users的PK
			/// </summary>
			public Key GetKey()
			{
				return new Key(Seqno);				
			}
			
				
		#endregion
	}
}
