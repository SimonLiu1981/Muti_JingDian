﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.18052
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace dx177.Business
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="hds0040800_db")]
	public partial class DBContextDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region 可扩展性方法定义
    partial void OnCreated();
    #endregion
		
		public DBContextDataContext() : 
				base(global::dx177.Business.Properties.Settings.Default.DataAccessQuickStart, mappingSource)
		{
			OnCreated();
		}
		
		public DBContextDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DBContextDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DBContextDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DBContextDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Questions1> Questions1
		{
			get
			{
				return this.GetTable<Questions1>();
			}
		}
		
		public System.Data.Linq.Table<QstType1> QstType1
		{
			get
			{
				return this.GetTable<QstType1>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Questions")]
	public partial class Questions1
	{
		
		private int _Seqno;
		
		private string _GUID;
		
		private string _Title;
		
		private string _QType;
		
		private string _Content;
		
		private System.Nullable<int> _Status;
		
		private string _CREATOR;
		
		private System.Nullable<System.DateTime> _CREATE_DATE;
		
		private System.Nullable<int> _ShowIdx;
		
		private System.Nullable<int> _ViewTimes;
		
		private string _Owner;
		
		private string _Siteid;
		
		private string _Cityid;
		
		private string _JingQuCode;
		
		public Questions1()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Seqno", AutoSync=AutoSync.Always, DbType="Int NOT NULL IDENTITY", IsDbGenerated=true)]
		public int Seqno
		{
			get
			{
				return this._Seqno;
			}
			set
			{
				if ((this._Seqno != value))
				{
					this._Seqno = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GUID", DbType="NVarChar(50)")]
		public string GUID
		{
			get
			{
				return this._GUID;
			}
			set
			{
				if ((this._GUID != value))
				{
					this._GUID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Title", DbType="NVarChar(255)")]
		public string Title
		{
			get
			{
				return this._Title;
			}
			set
			{
				if ((this._Title != value))
				{
					this._Title = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_QType", DbType="NVarChar(50)")]
		public string QType
		{
			get
			{
				return this._QType;
			}
			set
			{
				if ((this._QType != value))
				{
					this._QType = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Content", DbType="Text", UpdateCheck=UpdateCheck.Never)]
		public string Content
		{
			get
			{
				return this._Content;
			}
			set
			{
				if ((this._Content != value))
				{
					this._Content = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Status", DbType="Int")]
		public System.Nullable<int> Status
		{
			get
			{
				return this._Status;
			}
			set
			{
				if ((this._Status != value))
				{
					this._Status = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CREATOR", DbType="NVarChar(50)")]
		public string CREATOR
		{
			get
			{
				return this._CREATOR;
			}
			set
			{
				if ((this._CREATOR != value))
				{
					this._CREATOR = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CREATE_DATE", DbType="DateTime")]
		public System.Nullable<System.DateTime> CREATE_DATE
		{
			get
			{
				return this._CREATE_DATE;
			}
			set
			{
				if ((this._CREATE_DATE != value))
				{
					this._CREATE_DATE = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ShowIdx", DbType="Int")]
		public System.Nullable<int> ShowIdx
		{
			get
			{
				return this._ShowIdx;
			}
			set
			{
				if ((this._ShowIdx != value))
				{
					this._ShowIdx = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ViewTimes", DbType="Int")]
		public System.Nullable<int> ViewTimes
		{
			get
			{
				return this._ViewTimes;
			}
			set
			{
				if ((this._ViewTimes != value))
				{
					this._ViewTimes = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Owner", DbType="NVarChar(50)")]
		public string Owner
		{
			get
			{
				return this._Owner;
			}
			set
			{
				if ((this._Owner != value))
				{
					this._Owner = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Siteid", DbType="NVarChar(50)")]
		public string Siteid
		{
			get
			{
				return this._Siteid;
			}
			set
			{
				if ((this._Siteid != value))
				{
					this._Siteid = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Cityid", DbType="NVarChar(50)")]
		public string Cityid
		{
			get
			{
				return this._Cityid;
			}
			set
			{
				if ((this._Cityid != value))
				{
					this._Cityid = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_JingQuCode", DbType="NVarChar(20)")]
		public string JingQuCode
		{
			get
			{
				return this._JingQuCode;
			}
			set
			{
				if ((this._JingQuCode != value))
				{
					this._JingQuCode = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.QstType")]
	public partial class QstType1
	{
		
		private int _Seqno;
		
		private string _GUID;
		
		private string _PGUID;
		
		private string _Title;
		
		private string _Code;
		
		private string _ShortContent;
		
		private string _Content;
		
		private string _CREATOR;
		
		private System.Nullable<System.DateTime> _CREATE_DATE;
		
		private System.Nullable<System.DateTime> _Laste_update_date;
		
		private string _Laste_update_By;
		
		private string _JingQuCode;
		
		public QstType1()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Seqno", AutoSync=AutoSync.Always, DbType="Int NOT NULL IDENTITY", IsDbGenerated=true)]
		public int Seqno
		{
			get
			{
				return this._Seqno;
			}
			set
			{
				if ((this._Seqno != value))
				{
					this._Seqno = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GUID", DbType="NVarChar(50)")]
		public string GUID
		{
			get
			{
				return this._GUID;
			}
			set
			{
				if ((this._GUID != value))
				{
					this._GUID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PGUID", DbType="NVarChar(50)")]
		public string PGUID
		{
			get
			{
				return this._PGUID;
			}
			set
			{
				if ((this._PGUID != value))
				{
					this._PGUID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Title", DbType="NVarChar(255)")]
		public string Title
		{
			get
			{
				return this._Title;
			}
			set
			{
				if ((this._Title != value))
				{
					this._Title = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Code", DbType="NVarChar(50)")]
		public string Code
		{
			get
			{
				return this._Code;
			}
			set
			{
				if ((this._Code != value))
				{
					this._Code = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ShortContent", DbType="NVarChar(50)")]
		public string ShortContent
		{
			get
			{
				return this._ShortContent;
			}
			set
			{
				if ((this._ShortContent != value))
				{
					this._ShortContent = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Content", DbType="Text", UpdateCheck=UpdateCheck.Never)]
		public string Content
		{
			get
			{
				return this._Content;
			}
			set
			{
				if ((this._Content != value))
				{
					this._Content = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CREATOR", DbType="NVarChar(50)")]
		public string CREATOR
		{
			get
			{
				return this._CREATOR;
			}
			set
			{
				if ((this._CREATOR != value))
				{
					this._CREATOR = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CREATE_DATE", DbType="DateTime")]
		public System.Nullable<System.DateTime> CREATE_DATE
		{
			get
			{
				return this._CREATE_DATE;
			}
			set
			{
				if ((this._CREATE_DATE != value))
				{
					this._CREATE_DATE = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Laste_update_date", DbType="DateTime")]
		public System.Nullable<System.DateTime> Laste_update_date
		{
			get
			{
				return this._Laste_update_date;
			}
			set
			{
				if ((this._Laste_update_date != value))
				{
					this._Laste_update_date = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Laste_update_By", DbType="NVarChar(50)")]
		public string Laste_update_By
		{
			get
			{
				return this._Laste_update_By;
			}
			set
			{
				if ((this._Laste_update_By != value))
				{
					this._Laste_update_By = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_JingQuCode", DbType="NVarChar(20)")]
		public string JingQuCode
		{
			get
			{
				return this._JingQuCode;
			}
			set
			{
				if ((this._JingQuCode != value))
				{
					this._JingQuCode = value;
				}
			}
		}
	}
}
#pragma warning restore 1591
