/*
版权所有：版权所有(C) 2014，中兴通讯
文件编号：M01_Jingqus.cs
文件名称：Jingqus.cs
系统编号：Z0003007
系统名称：通用办公系统
模块编号：M01
模块名称：信息发布
设计文档：IOA_M01信息发布XDE建模.mdx
完成日期：2014-1-15
作　　者：
内容摘要：表[JingQus]对应的实体类
*/

using System;
using System.Collections;
using System.Data;
using System.Collections.Generic;


namespace dx177.Model.Bus
{
		/// <summary>
		/// 类 编 号：
		/// 类 名 称：Jingqus
		/// 内容摘要：
		/// </summary>
		
		[Serializable]
		public class Jingqus : BaseModel
		{
		#region 自动生成代码
		
			#region 重载Equals/GetHashCode
			/// <summary>
			/// 重载Equals			
			/// </summary>
			public override bool Equals (Object obj)
			{
				if (obj != null && obj is Jingqus)
				{
					if (obj == this)
						return true;
					Jingqus castObj = (Jingqus)obj; 
					
					if (!this.m_JingquId.Equals(castObj.JingquId))
						return false;
						
					if (!this.m_Jingqucode.Equals(castObj.Jingqucode))
						return false;
						
					if (!this.m_Jingquname.Equals(castObj.Jingquname))
						return false;
						
					if (!this.m_Matchdomain.Equals(castObj.Matchdomain))
						return false;
						
					if (!this.m_Navigation.Equals(castObj.Navigation))
						return false;
						
					if (!this.m_Logo.Equals(castObj.Logo))
						return false;
						
					if (!this.m_Sumary.Equals(castObj.Sumary))
						return false;
						
					if (!this.m_Guid.Equals(castObj.Guid))
						return false;
						
					if (!this.m_Showidx.Equals(castObj.Showidx))
						return false;
						
					if (!this.m_Areaid.Equals(castObj.Areaid))
						return false;
						
					if (!this.m_Priceinfo.Equals(castObj.Priceinfo))
						return false;
						
					if (!this.m_Weatherinfo.Equals(castObj.Weatherinfo))
						return false;
						
					if (!this.m_Navigationswitch.Equals(castObj.Navigationswitch))
						return false;
						
					if (!this.m_Parent.Equals(castObj.Parent))
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
					if ((object)m_JingquId != null)
					{
						hash = hash ^ m_JingquId.GetHashCode();
					}
						
					hash = hash <<  8;
					if ((object)m_Jingqucode != null)
					{
						hash = hash ^ m_Jingqucode.GetHashCode();
					}
						
					hash = hash <<  8;
					if ((object)m_Jingquname != null)
					{
						hash = hash ^ m_Jingquname.GetHashCode();
					}
						
					hash = hash <<  8;
					if ((object)m_Matchdomain != null)
					{
						hash = hash ^ m_Matchdomain.GetHashCode();
					}
						
					hash = hash <<  8;
					if ((object)m_Navigation != null)
					{
						hash = hash ^ m_Navigation.GetHashCode();
					}
						
					hash = hash <<  8;
					if ((object)m_Logo != null)
					{
						hash = hash ^ m_Logo.GetHashCode();
					}
						
					hash = hash <<  8;
					if ((object)m_Sumary != null)
					{
						hash = hash ^ m_Sumary.GetHashCode();
					}
						
					hash = hash <<  8;
					if ((object)m_Guid != null)
					{
						hash = hash ^ m_Guid.GetHashCode();
					}
						
					hash = hash <<  8;
					if ((object)m_Showidx != null)
					{
						hash = hash ^ m_Showidx.GetHashCode();
					}
						
					hash = hash <<  8;
					if ((object)m_Areaid != null)
					{
						hash = hash ^ m_Areaid.GetHashCode();
					}
						
					hash = hash <<  8;
					if ((object)m_Priceinfo != null)
					{
						hash = hash ^ m_Priceinfo.GetHashCode();
					}
						
					hash = hash <<  8;
					if ((object)m_Weatherinfo != null)
					{
						hash = hash ^ m_Weatherinfo.GetHashCode();
					}
						
					hash = hash <<  8;
					if ((object)m_Navigationswitch != null)
					{
						hash = hash ^ m_Navigationswitch.GetHashCode();
					}
						
					hash = hash <<  8;
					if ((object)m_Parent != null)
					{
						hash = hash ^ m_Parent.GetHashCode();
					}
						
					return hash; 
			}
			#endregion
			
			public Jingqus()
			{
				MarkNew();
			}						
			
			public Jingqus GetOldValue()
			{
				return OldValue as Jingqus;
			}
		
		#region JingquId属性
			private int m_JingquId = 0;
			/// <summary>
			/// 属性名称： JingquId
			/// 内容摘要： DB列名：JingQu_ID[JingQu_ID]
			///            DB类型：int
			/// </summary>
			public int JingquId
			{
				get
					{
						return m_JingquId;
					}
				set
					{
						if (m_JingquId as object == null || !m_JingquId.Equals(value))
						{
							m_JingquId = value;
							MarkUpdated();
						}						
					}
			}
		#endregion
		
		#region Jingqucode属性
			private string m_Jingqucode = String.Empty;
			/// <summary>
			/// 属性名称： Jingqucode
			/// 内容摘要： DB列名：JingQuCode[景区编号]
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
		
		#region Jingquname属性
			private string m_Jingquname = String.Empty;
			/// <summary>
			/// 属性名称： Jingquname
			/// 内容摘要： DB列名：JingQuName[景区名]
			///            DB类型：nvarchar(100)
			/// </summary>
			public string Jingquname
			{
				get
					{
						return m_Jingquname;
					}
				set
					{
						if (m_Jingquname as object == null || !m_Jingquname.Equals(value))
						{
							m_Jingquname = value;
							MarkUpdated();
						}						
					}
			}
		#endregion
		
		#region Matchdomain属性
			private string m_Matchdomain = String.Empty;
			/// <summary>
			/// 属性名称： Matchdomain
			/// 内容摘要： DB列名：MatchDomain[匹配域名(xxx.youcode.com),xxx就是匹配域名]
			///            DB类型：nvarchar(100)
			/// </summary>
			public string Matchdomain
			{
				get
					{
						return m_Matchdomain;
					}
				set
					{
						if (m_Matchdomain as object == null || !m_Matchdomain.Equals(value))
						{
							m_Matchdomain = value;
							MarkUpdated();
						}						
					}
			}
		#endregion
		
		#region Navigation属性
			private string m_Navigation = String.Empty;
			/// <summary>
			/// 属性名称： Navigation
			/// 内容摘要： DB列名：navigation[]
			///            DB类型：text
			/// </summary>
			public string Navigation
			{
				get
					{
						return m_Navigation;
					}
				set
					{
						if (m_Navigation as object == null || !m_Navigation.Equals(value))
						{
							m_Navigation = value;
							MarkUpdated();
						}						
					}
			}
		#endregion
		
		#region Logo属性
			private string m_Logo = String.Empty;
			/// <summary>
			/// 属性名称： Logo
			/// 内容摘要： DB列名：Logo[]
			///            DB类型：nvarchar(256)
			/// </summary>
			public string Logo
			{
				get
					{
						return m_Logo;
					}
				set
					{
						if (m_Logo as object == null || !m_Logo.Equals(value))
						{
							m_Logo = value;
							MarkUpdated();
						}						
					}
			}
		#endregion
		
		#region Sumary属性
			private string m_Sumary = String.Empty;
			/// <summary>
			/// 属性名称： Sumary
			/// 内容摘要： DB列名：Sumary[]
			///            DB类型：text
			/// </summary>
			public string Sumary
			{
				get
					{
						return m_Sumary;
					}
				set
					{
						if (m_Sumary as object == null || !m_Sumary.Equals(value))
						{
							m_Sumary = value;
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
		
		#region Showidx属性
			private int m_Showidx = 0;
			/// <summary>
			/// 属性名称： Showidx
			/// 内容摘要： DB列名：ShowIdx[]
			///            DB类型：int
			/// </summary>
			public int Showidx
			{
				get
					{
						return m_Showidx;
					}
				set
					{
						if (m_Showidx as object == null || !m_Showidx.Equals(value))
						{
							m_Showidx = value;
							MarkUpdated();
						}						
					}
			}
		#endregion
		
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
		
		#region Priceinfo属性
			private string m_Priceinfo = String.Empty;
			/// <summary>
			/// 属性名称： Priceinfo
			/// 内容摘要： DB列名：Priceinfo[]
			///            DB类型：nvarchar(500)
			/// </summary>
			public string Priceinfo
			{
				get
					{
						return m_Priceinfo;
					}
				set
					{
						if (m_Priceinfo as object == null || !m_Priceinfo.Equals(value))
						{
							m_Priceinfo = value;
							MarkUpdated();
						}						
					}
			}
		#endregion
		
		#region Weatherinfo属性
			private string m_Weatherinfo = String.Empty;
			/// <summary>
			/// 属性名称： Weatherinfo
			/// 内容摘要： DB列名：weatherInfo[]
			///            DB类型：nvarchar(2000)
			/// </summary>
			public string Weatherinfo
			{
				get
					{
						return m_Weatherinfo;
					}
				set
					{
						if (m_Weatherinfo as object == null || !m_Weatherinfo.Equals(value))
						{
							m_Weatherinfo = value;
							MarkUpdated();
						}						
					}
			}
		#endregion
		
		#region Navigationswitch属性
			private bool m_Navigationswitch = false;
			/// <summary>
			/// 属性名称： Navigationswitch
			/// 内容摘要： DB列名：NavigationSwitch[]
			///            DB类型：bit
			/// </summary>
			public bool Navigationswitch
			{
				get
					{
						return m_Navigationswitch;
					}
				set
					{
						if (m_Navigationswitch as object == null || !m_Navigationswitch.Equals(value))
						{
							m_Navigationswitch = value;
							MarkUpdated();
						}						
					}
			}
		#endregion
		
		#region Parent属性
			private string m_Parent = String.Empty;
			/// <summary>
			/// 属性名称： Parent
			/// 内容摘要： DB列名：parent[]
			///            DB类型：nvarchar(50)
			/// </summary>
			public string Parent
			{
				get
					{
						return m_Parent;
					}
				set
					{
						if (m_Parent as object == null || !m_Parent.Equals(value))
						{
							m_Parent = value;
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
					dtResult.Columns.Add(new DataColumn("JingQu_ID",typeof(int)));
					dtResult.Columns.Add(new DataColumn("JingQuCode",typeof(string)));
					dtResult.Columns.Add(new DataColumn("JingQuName",typeof(string)));
					dtResult.Columns.Add(new DataColumn("MatchDomain",typeof(string)));
					dtResult.Columns.Add(new DataColumn("navigation",typeof(string)));
					dtResult.Columns.Add(new DataColumn("Logo",typeof(string)));
					dtResult.Columns.Add(new DataColumn("Sumary",typeof(string)));
					dtResult.Columns.Add(new DataColumn("GUID",typeof(string)));
					dtResult.Columns.Add(new DataColumn("ShowIdx",typeof(int)));
					dtResult.Columns.Add(new DataColumn("AreaID",typeof(int)));
					dtResult.Columns.Add(new DataColumn("Priceinfo",typeof(string)));
					dtResult.Columns.Add(new DataColumn("weatherInfo",typeof(string)));
					dtResult.Columns.Add(new DataColumn("NavigationSwitch",typeof(bool)));
					dtResult.Columns.Add(new DataColumn("parent",typeof(string)));
				}
				else if (cne == ColumnNameEnum.PropertyName)
				{
					dtResult.Columns.Add(new DataColumn("JingquId",typeof(int)));
					dtResult.Columns.Add(new DataColumn("Jingqucode",typeof(string)));
					dtResult.Columns.Add(new DataColumn("Jingquname",typeof(string)));
					dtResult.Columns.Add(new DataColumn("Matchdomain",typeof(string)));
					dtResult.Columns.Add(new DataColumn("Navigation",typeof(string)));
					dtResult.Columns.Add(new DataColumn("Logo",typeof(string)));
					dtResult.Columns.Add(new DataColumn("Sumary",typeof(string)));
					dtResult.Columns.Add(new DataColumn("Guid",typeof(string)));
					dtResult.Columns.Add(new DataColumn("Showidx",typeof(int)));
					dtResult.Columns.Add(new DataColumn("Areaid",typeof(int)));
					dtResult.Columns.Add(new DataColumn("Priceinfo",typeof(string)));
					dtResult.Columns.Add(new DataColumn("Weatherinfo",typeof(string)));
					dtResult.Columns.Add(new DataColumn("Navigationswitch",typeof(bool)));
					dtResult.Columns.Add(new DataColumn("Parent",typeof(string)));
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
					dr["JingQu_ID"] = this.JingquId;
					dr["JingQuCode"] = this.Jingqucode;
					dr["JingQuName"] = this.Jingquname;
					dr["MatchDomain"] = this.Matchdomain;
					dr["navigation"] = this.Navigation;
					dr["Logo"] = this.Logo;
					dr["Sumary"] = this.Sumary;
					dr["GUID"] = this.Guid;
					dr["ShowIdx"] = this.Showidx;
					dr["AreaID"] = this.Areaid;
					dr["Priceinfo"] = this.Priceinfo;
					dr["weatherInfo"] = this.Weatherinfo;
					dr["NavigationSwitch"] = this.Navigationswitch;
					dr["parent"] = this.Parent;
				}
				else if (ColumnNameEnum.PropertyName == cne)
				{
					dr["JingquId"] = this.JingquId;
					dr["Jingqucode"] = this.Jingqucode;
					dr["Jingquname"] = this.Jingquname;
					dr["Matchdomain"] = this.Matchdomain;
					dr["Navigation"] = this.Navigation;
					dr["Logo"] = this.Logo;
					dr["Sumary"] = this.Sumary;
					dr["Guid"] = this.Guid;
					dr["Showidx"] = this.Showidx;
					dr["Areaid"] = this.Areaid;
					dr["Priceinfo"] = this.Priceinfo;
					dr["Weatherinfo"] = this.Weatherinfo;
					dr["Navigationswitch"] = this.Navigationswitch;
					dr["Parent"] = this.Parent;					
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
			/// 将DataRow转换成Jingqus对象
			/// </summary>
			/// <param name="dr">由CreateTable生成的DataTable通过NewRow得到的DataRow对象</param>
			/// <param name="cne">dr的列名映射方式:DB列名或属性名</param>
			/// <returns>Jingqus对象</returns>
			public static Jingqus Dr2Obj(DataRow dr,ColumnNameEnum cne)
			{
				if (dr == null)
				{
					throw new ArgumentNullException("dr");
				}
				Jingqus obj = new Jingqus();
				if (ColumnNameEnum.DBName == cne)
				{
					obj.JingquId = (dr["JingQu_ID"] == Convert.DBNull) ? 0  : (int)Convert.ChangeType(dr["JingQu_ID"],typeof(int));
					obj.Jingqucode = (dr["JingQuCode"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["JingQuCode"],typeof(string));
					obj.Jingquname = (dr["JingQuName"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["JingQuName"],typeof(string));
					obj.Matchdomain = (dr["MatchDomain"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["MatchDomain"],typeof(string));
					obj.Navigation = (dr["navigation"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["navigation"],typeof(string));
					obj.Logo = (dr["Logo"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Logo"],typeof(string));
					obj.Sumary = (dr["Sumary"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Sumary"],typeof(string));
					obj.Guid = (dr["GUID"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["GUID"],typeof(string));
					obj.Showidx = (dr["ShowIdx"] == Convert.DBNull) ? 0  : (int)Convert.ChangeType(dr["ShowIdx"],typeof(int));
					obj.Areaid = (dr["AreaID"] == Convert.DBNull) ? 0  : (int)Convert.ChangeType(dr["AreaID"],typeof(int));
					obj.Priceinfo = (dr["Priceinfo"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Priceinfo"],typeof(string));
					obj.Weatherinfo = (dr["weatherInfo"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["weatherInfo"],typeof(string));
					obj.Navigationswitch = (dr["NavigationSwitch"] == Convert.DBNull) ? false  : (bool)Convert.ChangeType(dr["NavigationSwitch"],typeof(bool));
					obj.Parent = (dr["parent"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["parent"],typeof(string));
				}
				else if (ColumnNameEnum.PropertyName == cne)
				{
					obj.JingquId = (dr["JingquId"] == Convert.DBNull) ? 0  : (int)Convert.ChangeType(dr["JingquId"],typeof(int));
					obj.Jingqucode = (dr["Jingqucode"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Jingqucode"],typeof(string));
					obj.Jingquname = (dr["Jingquname"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Jingquname"],typeof(string));
					obj.Matchdomain = (dr["Matchdomain"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Matchdomain"],typeof(string));
					obj.Navigation = (dr["Navigation"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Navigation"],typeof(string));
					obj.Logo = (dr["Logo"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Logo"],typeof(string));
					obj.Sumary = (dr["Sumary"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Sumary"],typeof(string));
					obj.Guid = (dr["Guid"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Guid"],typeof(string));
					obj.Showidx = (dr["Showidx"] == Convert.DBNull) ? 0  : (int)Convert.ChangeType(dr["Showidx"],typeof(int));
					obj.Areaid = (dr["Areaid"] == Convert.DBNull) ? 0  : (int)Convert.ChangeType(dr["Areaid"],typeof(int));
					obj.Priceinfo = (dr["Priceinfo"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Priceinfo"],typeof(string));
					obj.Weatherinfo = (dr["Weatherinfo"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Weatherinfo"],typeof(string));
					obj.Navigationswitch = (dr["Navigationswitch"] == Convert.DBNull) ? false  : (bool)Convert.ChangeType(dr["Navigationswitch"],typeof(bool));
					obj.Parent = (dr["Parent"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Parent"],typeof(string));		
				}
				
				return obj;
			}
			
			/// <summary>
			/// 将DataRow转换成Jingqus对象(默认列名映射为属性名)
			/// </summary>
			/// <returns>Jingqus对象</returns>
			public static Jingqus Dr2Obj(DataRow dr)
			{
				return Dr2Obj(dr,ColumnNameEnum.DBName);
			}
			
			/// <summary>
			/// 将DataTabe转换成的Jingqus对象集合
			/// </summary>
			/// <param name="dt">由CreateTable生成的DataTable</param>
			/// <param name="cne">dt的列名映射方式:DB列名或属性名</param>
			/// <returns>Jingqus对象的集合</returns>
			public static List<Jingqus>  Dt2Objs(DataTable dt,ColumnNameEnum cne)
			{
				if (dt == null)
				{
					throw new ArgumentNullException("dt");
				}
				
				 
				List<Jingqus> alResult = new List<Jingqus>();
				
				foreach(DataRow dr in dt.Rows)
				{
					alResult.Add(Dr2Obj(dr,cne));
				}
				
				return alResult;
			}

			/// <summary>
			/// 将DataTabe转换成的Jingqus对象集合(默认列名映射为属性名)
			/// </summary>
			/// <param name="dt">由CreateTable生成的DataTable</param>
			/// <returns>Jingqus对象的集合</returns>
			public static List<Jingqus> Dt2Objs(DataTable dt)
			{
				return Dt2Objs(dt,ColumnNameEnum.DBName);
			}
			
			/// <summary>
			/// 用objs的Jingqus对象集合填充DataTable
			/// </summary>
			/// <param name="dt">由CreateTable生成的DataTable</param>
			/// <param name="objs">Jingqus对象集合</param>
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
				
				foreach(Jingqus obj in objs)
				{
					DataRow dr = dt.NewRow();
					obj.FillDataRow(dr,cne);
					dt.Rows.Add(dr);
				}
			}

			/// <summary>
			/// 用objs的Jingqus对象集合填充DataTable(默认列名映射为属性名)
			/// </summary>
			/// <param name="dt">由CreateTable生成的DataTable</param>
			/// <param name="objs">Jingqus对象集合</param>
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
			Jingqus old = this.OldValue as Jingqus;
			if (old != null)
			{
					this.JingquId = old.JingquId;
					this.Jingqucode = old.Jingqucode;
					this.Jingquname = old.Jingquname;
					this.Matchdomain = old.Matchdomain;
					this.Navigation = old.Navigation;
					this.Logo = old.Logo;
					this.Sumary = old.Sumary;
					this.Guid = old.Guid;
					this.Showidx = old.Showidx;
					this.Areaid = old.Areaid;
					this.Priceinfo = old.Priceinfo;
					this.Weatherinfo = old.Weatherinfo;
					this.Navigationswitch = old.Navigationswitch;
					this.Parent = old.Parent;				
				this.OldValue = null;
			}
		}
		
		
		
		
		#region Jingqus实体的内部Key类
			/// <summary>
			/// Jingqus实体的Key类
			/// </summary>
			public class Key
			{
		
				private int m_JingquId;
				public int JingquId
				{
 					get 
					{ 
						 return m_JingquId; 
					}
					set 
					{ 
						m_JingquId = value;
					}
				}
		
				public Key(int pJingquId)
				{
					m_JingquId=pJingquId;

				}
			}
		#endregion
			/// <summary>
			/// 得到实体Jingqus的PK
			/// </summary>
			public Key GetKey()
			{
				return new Key(JingquId);				
			}
	
		
		#endregion
	}
}
