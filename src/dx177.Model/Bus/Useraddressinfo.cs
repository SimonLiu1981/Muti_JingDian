/*
版权所有：版权所有(C) 2011，中兴通讯
文件编号：M01_Useraddressinfo.cs
文件名称：Useraddressinfo.cs
系统编号：Z0003007
系统名称：通用办公系统
模块编号：M01
模块名称：信息发布
设计文档：IOA_M01信息发布XDE建模.mdx
完成日期：2011-04-30
作　　者：
内容摘要：表[UserAddressInfo]对应的实体类
*/

using System;
using System.Collections;
using System.Data;


namespace dx177.Model.Bus
{
		/// <summary>
		/// 类 编 号：
		/// 类 名 称：Useraddressinfo
		/// 内容摘要：
		/// </summary>
		
		[Serializable]
		public class Useraddressinfo : BaseModel
		{
		#region 自动生成代码
		
			#region 重载Equals/GetHashCode
			/// <summary>
			/// 重载Equals			
			/// </summary>
			public override bool Equals (Object obj)
			{
				if (obj != null && obj is Useraddressinfo)
				{
					if (obj == this)
						return true;
					Useraddressinfo castObj = (Useraddressinfo)obj; 
					
					if (!this.m_Seqno.Equals(castObj.Seqno))
						return false;
						
					if (!this.m_Consigneename.Equals(castObj.Consigneename))
						return false;
						
					if (!this.m_ReceiveEmail.Equals(castObj.ReceiveEmail))
						return false;
						
					if (!this.m_Country.Equals(castObj.Country))
						return false;
						
					if (!this.m_Contrycode.Equals(castObj.Contrycode))
						return false;
						
					if (!this.m_State.Equals(castObj.State))
						return false;
						
					if (!this.m_City.Equals(castObj.City))
						return false;
						
					if (!this.m_Zip.Equals(castObj.Zip))
						return false;
						
					if (!this.m_ReceivePhone.Equals(castObj.ReceivePhone))
						return false;
						
					if (!this.m_ReceiveTel.Equals(castObj.ReceiveTel))
						return false;
						
					if (!this.m_ReceiveAddress.Equals(castObj.ReceiveAddress))
						return false;
						
					if (!this.m_ReceiveAddress1.Equals(castObj.ReceiveAddress1))
						return false;
						
					if (!this.m_ResUserNo.Equals(castObj.ResUserNo))
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
					if ((object)m_Consigneename != null)
					{
						hash = hash ^ m_Consigneename.GetHashCode();
					}
						
					hash = hash <<  8;
					if ((object)m_ReceiveEmail != null)
					{
						hash = hash ^ m_ReceiveEmail.GetHashCode();
					}
						
					hash = hash <<  8;
					if ((object)m_Country != null)
					{
						hash = hash ^ m_Country.GetHashCode();
					}
						
					hash = hash <<  8;
					if ((object)m_Contrycode != null)
					{
						hash = hash ^ m_Contrycode.GetHashCode();
					}
						
					hash = hash <<  8;
					if ((object)m_State != null)
					{
						hash = hash ^ m_State.GetHashCode();
					}
						
					hash = hash <<  8;
					if ((object)m_City != null)
					{
						hash = hash ^ m_City.GetHashCode();
					}
						
					hash = hash <<  8;
					if ((object)m_Zip != null)
					{
						hash = hash ^ m_Zip.GetHashCode();
					}
						
					hash = hash <<  8;
					if ((object)m_ReceivePhone != null)
					{
						hash = hash ^ m_ReceivePhone.GetHashCode();
					}
						
					hash = hash <<  8;
					if ((object)m_ReceiveTel != null)
					{
						hash = hash ^ m_ReceiveTel.GetHashCode();
					}
						
					hash = hash <<  8;
					if ((object)m_ReceiveAddress != null)
					{
						hash = hash ^ m_ReceiveAddress.GetHashCode();
					}
						
					hash = hash <<  8;
					if ((object)m_ReceiveAddress1 != null)
					{
						hash = hash ^ m_ReceiveAddress1.GetHashCode();
					}
						
					hash = hash <<  8;
					if ((object)m_ResUserNo != null)
					{
						hash = hash ^ m_ResUserNo.GetHashCode();
					}
						
					return hash; 
			}
			#endregion
			
			public Useraddressinfo()
			{
				MarkNew();
			}						
			
			public Useraddressinfo GetOldValue()
			{
				return OldValue as Useraddressinfo;
			}
		
		#region Seqno属性
			private int m_Seqno = 0;
			/// <summary>
			/// 属性名称： Seqno
			/// 内容摘要： DB列名：seqno[]
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
		
		#region Consigneename属性
			private string m_Consigneename = String.Empty;
			/// <summary>
			/// 属性名称： Consigneename
			/// 内容摘要： DB列名：Consigneename[]
			///            DB类型：nvarchar(200)
			/// </summary>
			public string Consigneename
			{
				get
					{
						return m_Consigneename;
					}
				set
					{
						if (m_Consigneename as object == null || !m_Consigneename.Equals(value))
						{
							m_Consigneename = value;
							MarkUpdated();
						}						
					}
			}
		#endregion
		
		#region ReceiveEmail属性
			private string m_ReceiveEmail = String.Empty;
			/// <summary>
			/// 属性名称： ReceiveEmail
			/// 内容摘要： DB列名：Receive_email[]
			///            DB类型：nvarchar(50)
			/// </summary>
			public string ReceiveEmail
			{
				get
					{
						return m_ReceiveEmail;
					}
				set
					{
						if (m_ReceiveEmail as object == null || !m_ReceiveEmail.Equals(value))
						{
							m_ReceiveEmail = value;
							MarkUpdated();
						}						
					}
			}
		#endregion
		
		#region Country属性
			private string m_Country = String.Empty;
			/// <summary>
			/// 属性名称： Country
			/// 内容摘要： DB列名：Country[]
			///            DB类型：nvarchar(50)
			/// </summary>
			public string Country
			{
				get
					{
						return m_Country;
					}
				set
					{
						if (m_Country as object == null || !m_Country.Equals(value))
						{
							m_Country = value;
							MarkUpdated();
						}						
					}
			}
		#endregion
		
		#region Contrycode属性
			private string m_Contrycode = String.Empty;
			/// <summary>
			/// 属性名称： Contrycode
			/// 内容摘要： DB列名：ContryCode[]
			///            DB类型：nvarchar(50)
			/// </summary>
			public string Contrycode
			{
				get
					{
						return m_Contrycode;
					}
				set
					{
						if (m_Contrycode as object == null || !m_Contrycode.Equals(value))
						{
							m_Contrycode = value;
							MarkUpdated();
						}						
					}
			}
		#endregion
		
		#region State属性
			private string m_State = String.Empty;
			/// <summary>
			/// 属性名称： State
			/// 内容摘要： DB列名：State[]
			///            DB类型：nvarchar(50)
			/// </summary>
			public string State
			{
				get
					{
						return m_State;
					}
				set
					{
						if (m_State as object == null || !m_State.Equals(value))
						{
							m_State = value;
							MarkUpdated();
						}						
					}
			}
		#endregion
		
		#region City属性
			private string m_City = String.Empty;
			/// <summary>
			/// 属性名称： City
			/// 内容摘要： DB列名：City[]
			///            DB类型：nvarchar(50)
			/// </summary>
			public string City
			{
				get
					{
						return m_City;
					}
				set
					{
						if (m_City as object == null || !m_City.Equals(value))
						{
							m_City = value;
							MarkUpdated();
						}						
					}
			}
		#endregion
		
		#region Zip属性
			private string m_Zip = String.Empty;
			/// <summary>
			/// 属性名称： Zip
			/// 内容摘要： DB列名：Zip[]
			///            DB类型：nvarchar(50)
			/// </summary>
			public string Zip
			{
				get
					{
						return m_Zip;
					}
				set
					{
						if (m_Zip as object == null || !m_Zip.Equals(value))
						{
							m_Zip = value;
							MarkUpdated();
						}						
					}
			}
		#endregion
		
		#region ReceivePhone属性
			private string m_ReceivePhone = String.Empty;
			/// <summary>
			/// 属性名称： ReceivePhone
			/// 内容摘要： DB列名：Receive_phone[]
			///            DB类型：nvarchar(50)
			/// </summary>
			public string ReceivePhone
			{
				get
					{
						return m_ReceivePhone;
					}
				set
					{
						if (m_ReceivePhone as object == null || !m_ReceivePhone.Equals(value))
						{
							m_ReceivePhone = value;
							MarkUpdated();
						}						
					}
			}
		#endregion
		
		#region ReceiveTel属性
			private string m_ReceiveTel = String.Empty;
			/// <summary>
			/// 属性名称： ReceiveTel
			/// 内容摘要： DB列名：Receive_tel[]
			///            DB类型：nvarchar(50)
			/// </summary>
			public string ReceiveTel
			{
				get
					{
						return m_ReceiveTel;
					}
				set
					{
						if (m_ReceiveTel as object == null || !m_ReceiveTel.Equals(value))
						{
							m_ReceiveTel = value;
							MarkUpdated();
						}						
					}
			}
		#endregion
		
		#region ReceiveAddress属性
			private string m_ReceiveAddress = String.Empty;
			/// <summary>
			/// 属性名称： ReceiveAddress
			/// 内容摘要： DB列名：receive_address[]
			///            DB类型：nvarchar(200)
			/// </summary>
			public string ReceiveAddress
			{
				get
					{
						return m_ReceiveAddress;
					}
				set
					{
						if (m_ReceiveAddress as object == null || !m_ReceiveAddress.Equals(value))
						{
							m_ReceiveAddress = value;
							MarkUpdated();
						}						
					}
			}
		#endregion
		
		#region ReceiveAddress1属性
			private string m_ReceiveAddress1 = String.Empty;
			/// <summary>
			/// 属性名称： ReceiveAddress1
			/// 内容摘要： DB列名：receive_address1[]
			///            DB类型：nvarchar(200)
			/// </summary>
			public string ReceiveAddress1
			{
				get
					{
						return m_ReceiveAddress1;
					}
				set
					{
						if (m_ReceiveAddress1 as object == null || !m_ReceiveAddress1.Equals(value))
						{
							m_ReceiveAddress1 = value;
							MarkUpdated();
						}						
					}
			}
		#endregion
		
		#region ResUserNo属性
			private string m_ResUserNo = String.Empty;
			/// <summary>
			/// 属性名称： ResUserNo
			/// 内容摘要： DB列名：Res_User_NO[]
			///            DB类型：nvarchar(50)
			/// </summary>
			public string ResUserNo
			{
				get
					{
						return m_ResUserNo;
					}
				set
					{
						if (m_ResUserNo as object == null || !m_ResUserNo.Equals(value))
						{
							m_ResUserNo = value;
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
					dtResult.Columns.Add(new DataColumn("seqno",typeof(int)));
					dtResult.Columns.Add(new DataColumn("Consigneename",typeof(string)));
					dtResult.Columns.Add(new DataColumn("Receive_email",typeof(string)));
					dtResult.Columns.Add(new DataColumn("Country",typeof(string)));
					dtResult.Columns.Add(new DataColumn("ContryCode",typeof(string)));
					dtResult.Columns.Add(new DataColumn("State",typeof(string)));
					dtResult.Columns.Add(new DataColumn("City",typeof(string)));
					dtResult.Columns.Add(new DataColumn("Zip",typeof(string)));
					dtResult.Columns.Add(new DataColumn("Receive_phone",typeof(string)));
					dtResult.Columns.Add(new DataColumn("Receive_tel",typeof(string)));
					dtResult.Columns.Add(new DataColumn("receive_address",typeof(string)));
					dtResult.Columns.Add(new DataColumn("receive_address1",typeof(string)));
					dtResult.Columns.Add(new DataColumn("Res_User_NO",typeof(string)));
				}
				else if (cne == ColumnNameEnum.PropertyName)
				{
					dtResult.Columns.Add(new DataColumn("Seqno",typeof(int)));
					dtResult.Columns.Add(new DataColumn("Consigneename",typeof(string)));
					dtResult.Columns.Add(new DataColumn("ReceiveEmail",typeof(string)));
					dtResult.Columns.Add(new DataColumn("Country",typeof(string)));
					dtResult.Columns.Add(new DataColumn("Contrycode",typeof(string)));
					dtResult.Columns.Add(new DataColumn("State",typeof(string)));
					dtResult.Columns.Add(new DataColumn("City",typeof(string)));
					dtResult.Columns.Add(new DataColumn("Zip",typeof(string)));
					dtResult.Columns.Add(new DataColumn("ReceivePhone",typeof(string)));
					dtResult.Columns.Add(new DataColumn("ReceiveTel",typeof(string)));
					dtResult.Columns.Add(new DataColumn("ReceiveAddress",typeof(string)));
					dtResult.Columns.Add(new DataColumn("ReceiveAddress1",typeof(string)));
					dtResult.Columns.Add(new DataColumn("ResUserNo",typeof(string)));
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
					dr["seqno"] = this.Seqno;
					dr["Consigneename"] = this.Consigneename;
					dr["Receive_email"] = this.ReceiveEmail;
					dr["Country"] = this.Country;
					dr["ContryCode"] = this.Contrycode;
					dr["State"] = this.State;
					dr["City"] = this.City;
					dr["Zip"] = this.Zip;
					dr["Receive_phone"] = this.ReceivePhone;
					dr["Receive_tel"] = this.ReceiveTel;
					dr["receive_address"] = this.ReceiveAddress;
					dr["receive_address1"] = this.ReceiveAddress1;
					dr["Res_User_NO"] = this.ResUserNo;
				}
				else if (ColumnNameEnum.PropertyName == cne)
				{
					dr["Seqno"] = this.Seqno;
					dr["Consigneename"] = this.Consigneename;
					dr["ReceiveEmail"] = this.ReceiveEmail;
					dr["Country"] = this.Country;
					dr["Contrycode"] = this.Contrycode;
					dr["State"] = this.State;
					dr["City"] = this.City;
					dr["Zip"] = this.Zip;
					dr["ReceivePhone"] = this.ReceivePhone;
					dr["ReceiveTel"] = this.ReceiveTel;
					dr["ReceiveAddress"] = this.ReceiveAddress;
					dr["ReceiveAddress1"] = this.ReceiveAddress1;
					dr["ResUserNo"] = this.ResUserNo;					
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
			/// 将DataRow转换成Useraddressinfo对象
			/// </summary>
			/// <param name="dr">由CreateTable生成的DataTable通过NewRow得到的DataRow对象</param>
			/// <param name="cne">dr的列名映射方式:DB列名或属性名</param>
			/// <returns>Useraddressinfo对象</returns>
			public static Useraddressinfo Dr2Obj(DataRow dr,ColumnNameEnum cne)
			{
				if (dr == null)
				{
					throw new ArgumentNullException("dr");
				}
				Useraddressinfo obj = new Useraddressinfo();
				if (ColumnNameEnum.DBName == cne)
				{
					obj.Seqno = (dr["seqno"] == Convert.DBNull) ? 0  : (int)Convert.ChangeType(dr["seqno"],typeof(int));
					obj.Consigneename = (dr["Consigneename"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Consigneename"],typeof(string));
					obj.ReceiveEmail = (dr["Receive_email"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Receive_email"],typeof(string));
					obj.Country = (dr["Country"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Country"],typeof(string));
					obj.Contrycode = (dr["ContryCode"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["ContryCode"],typeof(string));
					obj.State = (dr["State"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["State"],typeof(string));
					obj.City = (dr["City"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["City"],typeof(string));
					obj.Zip = (dr["Zip"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Zip"],typeof(string));
					obj.ReceivePhone = (dr["Receive_phone"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Receive_phone"],typeof(string));
					obj.ReceiveTel = (dr["Receive_tel"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Receive_tel"],typeof(string));
					obj.ReceiveAddress = (dr["receive_address"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["receive_address"],typeof(string));
					obj.ReceiveAddress1 = (dr["receive_address1"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["receive_address1"],typeof(string));
					obj.ResUserNo = (dr["Res_User_NO"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Res_User_NO"],typeof(string));
				}
				else if (ColumnNameEnum.PropertyName == cne)
				{
					obj.Seqno = (dr["Seqno"] == Convert.DBNull) ? 0  : (int)Convert.ChangeType(dr["Seqno"],typeof(int));
					obj.Consigneename = (dr["Consigneename"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Consigneename"],typeof(string));
					obj.ReceiveEmail = (dr["ReceiveEmail"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["ReceiveEmail"],typeof(string));
					obj.Country = (dr["Country"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Country"],typeof(string));
					obj.Contrycode = (dr["Contrycode"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Contrycode"],typeof(string));
					obj.State = (dr["State"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["State"],typeof(string));
					obj.City = (dr["City"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["City"],typeof(string));
					obj.Zip = (dr["Zip"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Zip"],typeof(string));
					obj.ReceivePhone = (dr["ReceivePhone"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["ReceivePhone"],typeof(string));
					obj.ReceiveTel = (dr["ReceiveTel"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["ReceiveTel"],typeof(string));
					obj.ReceiveAddress = (dr["ReceiveAddress"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["ReceiveAddress"],typeof(string));
					obj.ReceiveAddress1 = (dr["ReceiveAddress1"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["ReceiveAddress1"],typeof(string));
					obj.ResUserNo = (dr["ResUserNo"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["ResUserNo"],typeof(string));		
				}
				
				return obj;
			}
			
			/// <summary>
			/// 将DataRow转换成Useraddressinfo对象(默认列名映射为属性名)
			/// </summary>
			/// <returns>Useraddressinfo对象</returns>
			public static Useraddressinfo Dr2Obj(DataRow dr)
			{
				return Dr2Obj(dr,ColumnNameEnum.PropertyName);
			}
			
			/// <summary>
			/// 将DataTabe转换成的Useraddressinfo对象集合
			/// </summary>
			/// <param name="dt">由CreateTable生成的DataTable</param>
			/// <param name="cne">dt的列名映射方式:DB列名或属性名</param>
			/// <returns>Useraddressinfo对象的集合</returns>
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
			/// 将DataTabe转换成的Useraddressinfo对象集合(默认列名映射为属性名)
			/// </summary>
			/// <param name="dt">由CreateTable生成的DataTable</param>
			/// <returns>Useraddressinfo对象的集合</returns>
			public static IList Dt2Objs(DataTable dt)
			{
				return Dt2Objs(dt,ColumnNameEnum.PropertyName);
			}
			
			/// <summary>
			/// 用objs的Useraddressinfo对象集合填充DataTable
			/// </summary>
			/// <param name="dt">由CreateTable生成的DataTable</param>
			/// <param name="objs">Useraddressinfo对象集合</param>
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
				
				foreach(Useraddressinfo obj in objs)
				{
					DataRow dr = dt.NewRow();
					obj.FillDataRow(dr,cne);
					dt.Rows.Add(dr);
				}
			}

			/// <summary>
			/// 用objs的Useraddressinfo对象集合填充DataTable(默认列名映射为属性名)
			/// </summary>
			/// <param name="dt">由CreateTable生成的DataTable</param>
			/// <param name="objs">Useraddressinfo对象集合</param>
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
			Useraddressinfo old = this.OldValue as Useraddressinfo;
			if (old != null)
			{
					this.Seqno = old.Seqno;
					this.Consigneename = old.Consigneename;
					this.ReceiveEmail = old.ReceiveEmail;
					this.Country = old.Country;
					this.Contrycode = old.Contrycode;
					this.State = old.State;
					this.City = old.City;
					this.Zip = old.Zip;
					this.ReceivePhone = old.ReceivePhone;
					this.ReceiveTel = old.ReceiveTel;
					this.ReceiveAddress = old.ReceiveAddress;
					this.ReceiveAddress1 = old.ReceiveAddress1;
					this.ResUserNo = old.ResUserNo;				
				this.OldValue = null;
			}
		}
		
		
		
		
		#region Useraddressinfo实体的内部Key类
			/// <summary>
			/// Useraddressinfo实体的Key类
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
			/// 得到实体Useraddressinfo的PK
			/// </summary>
			public Key GetKey()
			{
				return new Key(Seqno);				
			}
	
		
		#endregion
	}
}
