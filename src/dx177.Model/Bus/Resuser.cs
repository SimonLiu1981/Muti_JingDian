/*
版权所有：版权所有(C) 2012，中兴通讯
文件编号：M01_Resuser.cs
文件名称：Resuser.cs
系统编号：Z0003007
系统名称：通用办公系统
模块编号：M01
模块名称：信息发布
设计文档：IOA_M01信息发布XDE建模.mdx
完成日期：2012-6-20
作　　者：
内容摘要：表[ResUser]对应的实体类
*/

using System;
using System.Collections;
using System.Data;
using System.Collections.Generic;


namespace dx177.Model.Bus
{
		/// <summary>
		/// 类 编 号：
		/// 类 名 称：Resuser
		/// 内容摘要：
		/// </summary>
		
		[Serializable]
		public class Resuser : BaseModel
		{
		#region 自动生成代码
		
			#region 重载Equals/GetHashCode
			/// <summary>
			/// 重载Equals			
			/// </summary>
			public override bool Equals (Object obj)
			{
				if (obj != null && obj is Resuser)
				{
					if (obj == this)
						return true;
					Resuser castObj = (Resuser)obj; 
					
					if (!this.m_Seqno.Equals(castObj.Seqno))
						return false;
						
					if (!this.m_Guid.Equals(castObj.Guid))
						return false;
						
					if (!this.m_Username.Equals(castObj.Username))
						return false;
						
					if (!this.m_Name.Equals(castObj.Name))
						return false;
						
					if (!this.m_Pwd.Equals(castObj.Pwd))
						return false;
						
					if (!this.m_Status.Equals(castObj.Status))
						return false;
						
					if (!this.m_Sex.Equals(castObj.Sex))
						return false;
						
					if (!this.m_Brithday.Equals(castObj.Brithday))
						return false;
						
					if (!this.m_Email.Equals(castObj.Email))
						return false;
						
					if (!this.m_Mobile.Equals(castObj.Mobile))
						return false;
						
					if (!this.m_Msn.Equals(castObj.Msn))
						return false;
						
					if (!this.m_Qq.Equals(castObj.Qq))
						return false;
						
					if (!this.m_CreateDate.Equals(castObj.CreateDate))
						return false;
						
					if (!this.m_LasteUpdateDate.Equals(castObj.LasteUpdateDate))
						return false;
						
					if (!this.m_Usertype.Equals(castObj.Usertype))
						return false;
						
					if (!this.m_Issubdomain.Equals(castObj.Issubdomain))
						return false;
						
					if (!this.m_Domainname.Equals(castObj.Domainname))
						return false;
						
					if (!this.m_Phone.Equals(castObj.Phone))
						return false;
						
					if (!this.m_Shortcontent.Equals(castObj.Shortcontent))
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
					if ((object)m_Name != null)
					{
						hash = hash ^ m_Name.GetHashCode();
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
					if ((object)m_Sex != null)
					{
						hash = hash ^ m_Sex.GetHashCode();
					}
						
					hash = hash <<  8;
					if ((object)m_Brithday != null)
					{
						hash = hash ^ m_Brithday.GetHashCode();
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
					if ((object)m_Msn != null)
					{
						hash = hash ^ m_Msn.GetHashCode();
					}
						
					hash = hash <<  8;
					if ((object)m_Qq != null)
					{
						hash = hash ^ m_Qq.GetHashCode();
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
					if ((object)m_Usertype != null)
					{
						hash = hash ^ m_Usertype.GetHashCode();
					}
						
					hash = hash <<  8;
					if ((object)m_Issubdomain != null)
					{
						hash = hash ^ m_Issubdomain.GetHashCode();
					}
						
					hash = hash <<  8;
					if ((object)m_Domainname != null)
					{
						hash = hash ^ m_Domainname.GetHashCode();
					}
						
					hash = hash <<  8;
					if ((object)m_Phone != null)
					{
						hash = hash ^ m_Phone.GetHashCode();
					}
						
					hash = hash <<  8;
					if ((object)m_Shortcontent != null)
					{
						hash = hash ^ m_Shortcontent.GetHashCode();
					}
						
					hash = hash <<  8;
					if ((object)m_Jingqucode != null)
					{
						hash = hash ^ m_Jingqucode.GetHashCode();
					}
						
					return hash; 
			}
			#endregion
			
			public Resuser()
			{
				MarkNew();
			}						
			
			public Resuser GetOldValue()
			{
				return OldValue as Resuser;
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
		
		#region Username属性
			private string m_Username = String.Empty;
			/// <summary>
			/// 属性名称： Username
			/// 内容摘要： DB列名：UserName[用户名]
			///            DB类型：nvarchar(50)
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
		
		#region Name属性
			private string m_Name = String.Empty;
			/// <summary>
			/// 属性名称： Name
			/// 内容摘要： DB列名：Name[姓名]
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
		
		#region Pwd属性
			private string m_Pwd = String.Empty;
			/// <summary>
			/// 属性名称： Pwd
			/// 内容摘要： DB列名：Pwd[密码]
			///            DB类型：nvarchar(50)
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
		
		#region Sex属性
			private string m_Sex = String.Empty;
			/// <summary>
			/// 属性名称： Sex
			/// 内容摘要： DB列名：Sex[性别]
			///            DB类型：nvarchar(50)
			/// </summary>
			public string Sex
			{
				get
					{
						return m_Sex;
					}
				set
					{
						if (m_Sex as object == null || !m_Sex.Equals(value))
						{
							m_Sex = value;
							MarkUpdated();
						}						
					}
			}
		#endregion
		
		#region Brithday属性
			private string m_Brithday = String.Empty;
			/// <summary>
			/// 属性名称： Brithday
			/// 内容摘要： DB列名：brithday[生日]
			///            DB类型：nvarchar(50)
			/// </summary>
			public string Brithday
			{
				get
					{
						return m_Brithday;
					}
				set
					{
						if (m_Brithday as object == null || !m_Brithday.Equals(value))
						{
							m_Brithday = value;
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
			///            DB类型：nvarchar(50)
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
			///            DB类型：nvarchar(50)
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
		
		#region Msn属性
			private string m_Msn = String.Empty;
			/// <summary>
			/// 属性名称： Msn
			/// 内容摘要： DB列名：Msn[Msn]
			///            DB类型：nvarchar(50)
			/// </summary>
			public string Msn
			{
				get
					{
						return m_Msn;
					}
				set
					{
						if (m_Msn as object == null || !m_Msn.Equals(value))
						{
							m_Msn = value;
							MarkUpdated();
						}						
					}
			}
		#endregion
		
		#region Qq属性
			private string m_Qq = String.Empty;
			/// <summary>
			/// 属性名称： Qq
			/// 内容摘要： DB列名：QQ[QQ]
			///            DB类型：nvarchar(50)
			/// </summary>
			public string Qq
			{
				get
					{
						return m_Qq;
					}
				set
					{
						if (m_Qq as object == null || !m_Qq.Equals(value))
						{
							m_Qq = value;
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
			/// 内容摘要： DB列名：Laste_update_date[最后更新时间]
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
		
		#region Usertype属性
			private string m_Usertype = String.Empty;
			/// <summary>
			/// 属性名称： Usertype
			/// 内容摘要： DB列名：UserType[类型]
			///            DB类型：nvarchar(50)
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
		
		#region Issubdomain属性
			private int m_Issubdomain = 0;
			/// <summary>
			/// 属性名称： Issubdomain
			/// 内容摘要： DB列名：IsSubdomain[]
			///            DB类型：int
			/// </summary>
			public int Issubdomain
			{
				get
					{
						return m_Issubdomain;
					}
				set
					{
						if (m_Issubdomain as object == null || !m_Issubdomain.Equals(value))
						{
							m_Issubdomain = value;
							MarkUpdated();
						}						
					}
			}
		#endregion
		
		#region Domainname属性
			private string m_Domainname = String.Empty;
			/// <summary>
			/// 属性名称： Domainname
			/// 内容摘要： DB列名：domainName[]
			///            DB类型：nvarchar(200)
			/// </summary>
			public string Domainname
			{
				get
					{
						return m_Domainname;
					}
				set
					{
						if (m_Domainname as object == null || !m_Domainname.Equals(value))
						{
							m_Domainname = value;
							MarkUpdated();
						}						
					}
			}
		#endregion
		
		#region Phone属性
			private string m_Phone = String.Empty;
			/// <summary>
			/// 属性名称： Phone
			/// 内容摘要： DB列名：Phone[]
			///            DB类型：nvarchar(20)
			/// </summary>
			public string Phone
			{
				get
					{
						return m_Phone;
					}
				set
					{
						if (m_Phone as object == null || !m_Phone.Equals(value))
						{
							m_Phone = value;
							MarkUpdated();
						}						
					}
			}
		#endregion
		
		#region Shortcontent属性
			private string m_Shortcontent = String.Empty;
			/// <summary>
			/// 属性名称： Shortcontent
			/// 内容摘要： DB列名：ShortContent[]
			///            DB类型：nvarchar(200)
			/// </summary>
			public string Shortcontent
			{
				get
					{
						return m_Shortcontent;
					}
				set
					{
						if (m_Shortcontent as object == null || !m_Shortcontent.Equals(value))
						{
							m_Shortcontent = value;
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
					dtResult.Columns.Add(new DataColumn("Seqno",typeof(int)));
					dtResult.Columns.Add(new DataColumn("GUID",typeof(string)));
					dtResult.Columns.Add(new DataColumn("UserName",typeof(string)));
					dtResult.Columns.Add(new DataColumn("Name",typeof(string)));
					dtResult.Columns.Add(new DataColumn("Pwd",typeof(string)));
					dtResult.Columns.Add(new DataColumn("Status",typeof(int)));
					dtResult.Columns.Add(new DataColumn("Sex",typeof(string)));
					dtResult.Columns.Add(new DataColumn("brithday",typeof(string)));
					dtResult.Columns.Add(new DataColumn("Email",typeof(string)));
					dtResult.Columns.Add(new DataColumn("Mobile",typeof(string)));
					dtResult.Columns.Add(new DataColumn("Msn",typeof(string)));
					dtResult.Columns.Add(new DataColumn("QQ",typeof(string)));
					dtResult.Columns.Add(new DataColumn("CREATE_DATE",typeof(DateTime)));
					dtResult.Columns.Add(new DataColumn("Laste_update_date",typeof(DateTime)));
					dtResult.Columns.Add(new DataColumn("UserType",typeof(string)));
					dtResult.Columns.Add(new DataColumn("IsSubdomain",typeof(int)));
					dtResult.Columns.Add(new DataColumn("domainName",typeof(string)));
					dtResult.Columns.Add(new DataColumn("Phone",typeof(string)));
					dtResult.Columns.Add(new DataColumn("ShortContent",typeof(string)));
					dtResult.Columns.Add(new DataColumn("JingQuCode",typeof(string)));
				}
				else if (cne == ColumnNameEnum.PropertyName)
				{
					dtResult.Columns.Add(new DataColumn("Seqno",typeof(int)));
					dtResult.Columns.Add(new DataColumn("Guid",typeof(string)));
					dtResult.Columns.Add(new DataColumn("Username",typeof(string)));
					dtResult.Columns.Add(new DataColumn("Name",typeof(string)));
					dtResult.Columns.Add(new DataColumn("Pwd",typeof(string)));
					dtResult.Columns.Add(new DataColumn("Status",typeof(int)));
					dtResult.Columns.Add(new DataColumn("Sex",typeof(string)));
					dtResult.Columns.Add(new DataColumn("Brithday",typeof(string)));
					dtResult.Columns.Add(new DataColumn("Email",typeof(string)));
					dtResult.Columns.Add(new DataColumn("Mobile",typeof(string)));
					dtResult.Columns.Add(new DataColumn("Msn",typeof(string)));
					dtResult.Columns.Add(new DataColumn("Qq",typeof(string)));
					dtResult.Columns.Add(new DataColumn("CreateDate",typeof(DateTime)));
					dtResult.Columns.Add(new DataColumn("LasteUpdateDate",typeof(DateTime)));
					dtResult.Columns.Add(new DataColumn("Usertype",typeof(string)));
					dtResult.Columns.Add(new DataColumn("Issubdomain",typeof(int)));
					dtResult.Columns.Add(new DataColumn("Domainname",typeof(string)));
					dtResult.Columns.Add(new DataColumn("Phone",typeof(string)));
					dtResult.Columns.Add(new DataColumn("Shortcontent",typeof(string)));
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
					dr["Seqno"] = this.Seqno;
					dr["GUID"] = this.Guid;
					dr["UserName"] = this.Username;
					dr["Name"] = this.Name;
					dr["Pwd"] = this.Pwd;
					dr["Status"] = this.Status;
					dr["Sex"] = this.Sex;
					dr["brithday"] = this.Brithday;
					dr["Email"] = this.Email;
					dr["Mobile"] = this.Mobile;
					dr["Msn"] = this.Msn;
					dr["QQ"] = this.Qq;
					dr["CREATE_DATE"] = this.CreateDate;
					dr["Laste_update_date"] = this.LasteUpdateDate;
					dr["UserType"] = this.Usertype;
					dr["IsSubdomain"] = this.Issubdomain;
					dr["domainName"] = this.Domainname;
					dr["Phone"] = this.Phone;
					dr["ShortContent"] = this.Shortcontent;
					dr["JingQuCode"] = this.Jingqucode;
				}
				else if (ColumnNameEnum.PropertyName == cne)
				{
					dr["Seqno"] = this.Seqno;
					dr["Guid"] = this.Guid;
					dr["Username"] = this.Username;
					dr["Name"] = this.Name;
					dr["Pwd"] = this.Pwd;
					dr["Status"] = this.Status;
					dr["Sex"] = this.Sex;
					dr["Brithday"] = this.Brithday;
					dr["Email"] = this.Email;
					dr["Mobile"] = this.Mobile;
					dr["Msn"] = this.Msn;
					dr["Qq"] = this.Qq;
					dr["CreateDate"] = this.CreateDate;
					dr["LasteUpdateDate"] = this.LasteUpdateDate;
					dr["Usertype"] = this.Usertype;
					dr["Issubdomain"] = this.Issubdomain;
					dr["Domainname"] = this.Domainname;
					dr["Phone"] = this.Phone;
					dr["Shortcontent"] = this.Shortcontent;
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
			/// 将DataRow转换成Resuser对象
			/// </summary>
			/// <param name="dr">由CreateTable生成的DataTable通过NewRow得到的DataRow对象</param>
			/// <param name="cne">dr的列名映射方式:DB列名或属性名</param>
			/// <returns>Resuser对象</returns>
			public static Resuser Dr2Obj(DataRow dr,ColumnNameEnum cne)
			{
				if (dr == null)
				{
					throw new ArgumentNullException("dr");
				}
				Resuser obj = new Resuser();
				if (ColumnNameEnum.DBName == cne)
				{
					obj.Seqno = (dr["Seqno"] == Convert.DBNull) ? 0  : (int)Convert.ChangeType(dr["Seqno"],typeof(int));
					obj.Guid = (dr["GUID"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["GUID"],typeof(string));
					obj.Username = (dr["UserName"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["UserName"],typeof(string));
					obj.Name = (dr["Name"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Name"],typeof(string));
					obj.Pwd = (dr["Pwd"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Pwd"],typeof(string));
					obj.Status = (dr["Status"] == Convert.DBNull) ? 0  : (int)Convert.ChangeType(dr["Status"],typeof(int));
					obj.Sex = (dr["Sex"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Sex"],typeof(string));
					obj.Brithday = (dr["brithday"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["brithday"],typeof(string));
					obj.Email = (dr["Email"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Email"],typeof(string));
					obj.Mobile = (dr["Mobile"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Mobile"],typeof(string));
					obj.Msn = (dr["Msn"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Msn"],typeof(string));
					obj.Qq = (dr["QQ"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["QQ"],typeof(string));
					obj.CreateDate = (dr["CREATE_DATE"] == Convert.DBNull) ? new DateTime(1900,1,1)  : (DateTime)Convert.ChangeType(dr["CREATE_DATE"],typeof(DateTime));
					obj.LasteUpdateDate = (dr["Laste_update_date"] == Convert.DBNull) ? new DateTime(1900,1,1)  : (DateTime)Convert.ChangeType(dr["Laste_update_date"],typeof(DateTime));
					obj.Usertype = (dr["UserType"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["UserType"],typeof(string));
					obj.Issubdomain = (dr["IsSubdomain"] == Convert.DBNull) ? 0  : (int)Convert.ChangeType(dr["IsSubdomain"],typeof(int));
					obj.Domainname = (dr["domainName"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["domainName"],typeof(string));
					obj.Phone = (dr["Phone"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Phone"],typeof(string));
					obj.Shortcontent = (dr["ShortContent"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["ShortContent"],typeof(string));
					obj.Jingqucode = (dr["JingQuCode"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["JingQuCode"],typeof(string));
				}
				else if (ColumnNameEnum.PropertyName == cne)
				{
					obj.Seqno = (dr["Seqno"] == Convert.DBNull) ? 0  : (int)Convert.ChangeType(dr["Seqno"],typeof(int));
					obj.Guid = (dr["Guid"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Guid"],typeof(string));
					obj.Username = (dr["Username"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Username"],typeof(string));
					obj.Name = (dr["Name"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Name"],typeof(string));
					obj.Pwd = (dr["Pwd"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Pwd"],typeof(string));
					obj.Status = (dr["Status"] == Convert.DBNull) ? 0  : (int)Convert.ChangeType(dr["Status"],typeof(int));
					obj.Sex = (dr["Sex"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Sex"],typeof(string));
					obj.Brithday = (dr["Brithday"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Brithday"],typeof(string));
					obj.Email = (dr["Email"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Email"],typeof(string));
					obj.Mobile = (dr["Mobile"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Mobile"],typeof(string));
					obj.Msn = (dr["Msn"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Msn"],typeof(string));
					obj.Qq = (dr["Qq"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Qq"],typeof(string));
					obj.CreateDate = (dr["CreateDate"] == Convert.DBNull) ? new DateTime(1900,1,1)  : (DateTime)Convert.ChangeType(dr["CreateDate"],typeof(DateTime));
					obj.LasteUpdateDate = (dr["LasteUpdateDate"] == Convert.DBNull) ? new DateTime(1900,1,1)  : (DateTime)Convert.ChangeType(dr["LasteUpdateDate"],typeof(DateTime));
					obj.Usertype = (dr["Usertype"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Usertype"],typeof(string));
					obj.Issubdomain = (dr["Issubdomain"] == Convert.DBNull) ? 0  : (int)Convert.ChangeType(dr["Issubdomain"],typeof(int));
					obj.Domainname = (dr["Domainname"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Domainname"],typeof(string));
					obj.Phone = (dr["Phone"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Phone"],typeof(string));
					obj.Shortcontent = (dr["Shortcontent"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Shortcontent"],typeof(string));
					obj.Jingqucode = (dr["Jingqucode"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Jingqucode"],typeof(string));		
				}
				
				return obj;
			}
			
			/// <summary>
			/// 将DataRow转换成Resuser对象(默认列名映射为属性名)
			/// </summary>
			/// <returns>Resuser对象</returns>
			public static Resuser Dr2Obj(DataRow dr)
			{
				return Dr2Obj(dr,ColumnNameEnum.DBName);
			}
			
			/// <summary>
			/// 将DataTabe转换成的Resuser对象集合
			/// </summary>
			/// <param name="dt">由CreateTable生成的DataTable</param>
			/// <param name="cne">dt的列名映射方式:DB列名或属性名</param>
			/// <returns>Resuser对象的集合</returns>
			public static List<Resuser>  Dt2Objs(DataTable dt,ColumnNameEnum cne)
			{
				if (dt == null)
				{
					throw new ArgumentNullException("dt");
				}
				
				 
				List<Resuser> alResult = new List<Resuser>();
				
				foreach(DataRow dr in dt.Rows)
				{
					alResult.Add(Dr2Obj(dr,cne));
				}
				
				return alResult;
			}

			/// <summary>
			/// 将DataTabe转换成的Resuser对象集合(默认列名映射为属性名)
			/// </summary>
			/// <param name="dt">由CreateTable生成的DataTable</param>
			/// <returns>Resuser对象的集合</returns>
			public static List<Resuser> Dt2Objs(DataTable dt)
			{
				return Dt2Objs(dt,ColumnNameEnum.DBName);
			}
			
			/// <summary>
			/// 用objs的Resuser对象集合填充DataTable
			/// </summary>
			/// <param name="dt">由CreateTable生成的DataTable</param>
			/// <param name="objs">Resuser对象集合</param>
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
				
				foreach(Resuser obj in objs)
				{
					DataRow dr = dt.NewRow();
					obj.FillDataRow(dr,cne);
					dt.Rows.Add(dr);
				}
			}

			/// <summary>
			/// 用objs的Resuser对象集合填充DataTable(默认列名映射为属性名)
			/// </summary>
			/// <param name="dt">由CreateTable生成的DataTable</param>
			/// <param name="objs">Resuser对象集合</param>
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
			Resuser old = this.OldValue as Resuser;
			if (old != null)
			{
					this.Seqno = old.Seqno;
					this.Guid = old.Guid;
					this.Username = old.Username;
					this.Name = old.Name;
					this.Pwd = old.Pwd;
					this.Status = old.Status;
					this.Sex = old.Sex;
					this.Brithday = old.Brithday;
					this.Email = old.Email;
					this.Mobile = old.Mobile;
					this.Msn = old.Msn;
					this.Qq = old.Qq;
					this.CreateDate = old.CreateDate;
					this.LasteUpdateDate = old.LasteUpdateDate;
					this.Usertype = old.Usertype;
					this.Issubdomain = old.Issubdomain;
					this.Domainname = old.Domainname;
					this.Phone = old.Phone;
					this.Shortcontent = old.Shortcontent;
					this.Jingqucode = old.Jingqucode;				
				this.OldValue = null;
			}
		}
		
		
		
		
		#region Resuser实体的内部Key类
			/// <summary>
			/// Resuser实体的Key类
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
			/// 得到实体Resuser的PK
			/// </summary>
			public Key GetKey()
			{
				return new Key(Seqno);				
			}
	
		
		#endregion
	}
}
