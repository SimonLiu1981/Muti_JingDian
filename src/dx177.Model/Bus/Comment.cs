/*
版权所有：版权所有(C) 2012，中兴通讯
文件编号：M01_Comment.cs
文件名称：Comment.cs
系统编号：Z0003007
系统名称：通用办公系统
模块编号：M01
模块名称：信息发布
设计文档：IOA_M01信息发布XDE建模.mdx
完成日期：2012-9-20
作　　者：
内容摘要：表[Comment]对应的实体类
*/

using System;
using System.Collections;
using System.Data;
using System.Collections.Generic;


namespace dx177.Model.Bus
{
		/// <summary>
		/// 类 编 号：
		/// 类 名 称：Comment
		/// 内容摘要：
		/// </summary>
		
		[Serializable]
		public class Comment : BaseModel
		{
		#region 自动生成代码
		
			#region 重载Equals/GetHashCode
			/// <summary>
			/// 重载Equals			
			/// </summary>
			public override bool Equals (Object obj)
			{
				if (obj != null && obj is Comment)
				{
					if (obj == this)
						return true;
					Comment castObj = (Comment)obj; 
					
					if (!this.m_Seqno.Equals(castObj.Seqno))
						return false;
						
					if (!this.m_Guid.Equals(castObj.Guid))
						return false;
						
					if (!this.m_Pguid.Equals(castObj.Pguid))
						return false;
						
					if (!this.m_Score1.Equals(castObj.Score1))
						return false;
						
					if (!this.m_Score2.Equals(castObj.Score2))
						return false;
						
					if (!this.m_Score3.Equals(castObj.Score3))
						return false;
						
					if (!this.m_Score4.Equals(castObj.Score4))
						return false;
						
					if (!this.m_Score5.Equals(castObj.Score5))
						return false;
						
					if (!this.m_Content.Equals(castObj.Content))
						return false;
						
					if (!this.m_Isnew.Equals(castObj.Isnew))
						return false;
						
					if (!this.m_Isshow.Equals(castObj.Isshow))
						return false;
						
					if (!this.m_Replycontent.Equals(castObj.Replycontent))
						return false;
						
					if (!this.m_Creator.Equals(castObj.Creator))
						return false;
						
					if (!this.m_CreateDate.Equals(castObj.CreateDate))
						return false;
						
					if (!this.m_Avgscore.Equals(castObj.Avgscore))
						return false;
						
					if (!this.m_Good.Equals(castObj.Good))
						return false;
						
					if (!this.m_Bad.Equals(castObj.Bad))
						return false;
						
					if (!this.m_Viewtimes.Equals(castObj.Viewtimes))
						return false;
						
					if (!this.m_Email.Equals(castObj.Email))
						return false;
						
					if (!this.m_Phone.Equals(castObj.Phone))
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
					if ((object)m_Pguid != null)
					{
						hash = hash ^ m_Pguid.GetHashCode();
					}
						
					hash = hash <<  8;
					if ((object)m_Score1 != null)
					{
						hash = hash ^ m_Score1.GetHashCode();
					}
						
					hash = hash <<  8;
					if ((object)m_Score2 != null)
					{
						hash = hash ^ m_Score2.GetHashCode();
					}
						
					hash = hash <<  8;
					if ((object)m_Score3 != null)
					{
						hash = hash ^ m_Score3.GetHashCode();
					}
						
					hash = hash <<  8;
					if ((object)m_Score4 != null)
					{
						hash = hash ^ m_Score4.GetHashCode();
					}
						
					hash = hash <<  8;
					if ((object)m_Score5 != null)
					{
						hash = hash ^ m_Score5.GetHashCode();
					}
						
					hash = hash <<  8;
					if ((object)m_Content != null)
					{
						hash = hash ^ m_Content.GetHashCode();
					}
						
					hash = hash <<  8;
					if ((object)m_Isnew != null)
					{
						hash = hash ^ m_Isnew.GetHashCode();
					}
						
					hash = hash <<  8;
					if ((object)m_Isshow != null)
					{
						hash = hash ^ m_Isshow.GetHashCode();
					}
						
					hash = hash <<  8;
					if ((object)m_Replycontent != null)
					{
						hash = hash ^ m_Replycontent.GetHashCode();
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
					if ((object)m_Avgscore != null)
					{
						hash = hash ^ m_Avgscore.GetHashCode();
					}
						
					hash = hash <<  8;
					if ((object)m_Good != null)
					{
						hash = hash ^ m_Good.GetHashCode();
					}
						
					hash = hash <<  8;
					if ((object)m_Bad != null)
					{
						hash = hash ^ m_Bad.GetHashCode();
					}
						
					hash = hash <<  8;
					if ((object)m_Viewtimes != null)
					{
						hash = hash ^ m_Viewtimes.GetHashCode();
					}
						
					hash = hash <<  8;
					if ((object)m_Email != null)
					{
						hash = hash ^ m_Email.GetHashCode();
					}
						
					hash = hash <<  8;
					if ((object)m_Phone != null)
					{
						hash = hash ^ m_Phone.GetHashCode();
					}
						
					return hash; 
			}
			#endregion
			
			public Comment()
			{
				MarkNew();
			}						
			
			public Comment GetOldValue()
			{
				return OldValue as Comment;
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
		
		#region Pguid属性
			private string m_Pguid = String.Empty;
			/// <summary>
			/// 属性名称： Pguid
			/// 内容摘要： DB列名：PGUID[父GUID]
			///            DB类型：nvarchar(50)
			/// </summary>
			public string Pguid
			{
				get
					{
						return m_Pguid;
					}
				set
					{
						if (m_Pguid as object == null || !m_Pguid.Equals(value))
						{
							m_Pguid = value;
							MarkUpdated();
						}						
					}
			}
		#endregion
		
		#region Score1属性
			private decimal m_Score1 = 0.0M;
			/// <summary>
			/// 属性名称： Score1
			/// 内容摘要： DB列名：Score1[0-5分]
			///            DB类型：numeric(10,1)
			/// </summary>
			public decimal Score1
			{
				get
					{
						return m_Score1;
					}
				set
					{
						if (m_Score1 as object == null || !m_Score1.Equals(value))
						{
							m_Score1 = value;
							MarkUpdated();
						}						
					}
			}
		#endregion
		
		#region Score2属性
			private decimal m_Score2 = 0.0M;
			/// <summary>
			/// 属性名称： Score2
			/// 内容摘要： DB列名：Score2[0-5分]
			///            DB类型：numeric(10,1)
			/// </summary>
			public decimal Score2
			{
				get
					{
						return m_Score2;
					}
				set
					{
						if (m_Score2 as object == null || !m_Score2.Equals(value))
						{
							m_Score2 = value;
							MarkUpdated();
						}						
					}
			}
		#endregion
		
		#region Score3属性
			private decimal m_Score3 = 0.0M;
			/// <summary>
			/// 属性名称： Score3
			/// 内容摘要： DB列名：Score3[0-5分]
			///            DB类型：numeric(10,1)
			/// </summary>
			public decimal Score3
			{
				get
					{
						return m_Score3;
					}
				set
					{
						if (m_Score3 as object == null || !m_Score3.Equals(value))
						{
							m_Score3 = value;
							MarkUpdated();
						}						
					}
			}
		#endregion
		
		#region Score4属性
			private decimal m_Score4 = 0.0M;
			/// <summary>
			/// 属性名称： Score4
			/// 内容摘要： DB列名：Score4[0-5分]
			///            DB类型：numeric(10,1)
			/// </summary>
			public decimal Score4
			{
				get
					{
						return m_Score4;
					}
				set
					{
						if (m_Score4 as object == null || !m_Score4.Equals(value))
						{
							m_Score4 = value;
							MarkUpdated();
						}						
					}
			}
		#endregion
		
		#region Score5属性
			private decimal m_Score5 = 0.0M;
			/// <summary>
			/// 属性名称： Score5
			/// 内容摘要： DB列名：Score5[0-5分]
			///            DB类型：numeric(10,1)
			/// </summary>
			public decimal Score5
			{
				get
					{
						return m_Score5;
					}
				set
					{
						if (m_Score5 as object == null || !m_Score5.Equals(value))
						{
							m_Score5 = value;
							MarkUpdated();
						}						
					}
			}
		#endregion
		
		#region Content属性
			private string m_Content = String.Empty;
			/// <summary>
			/// 属性名称： Content
			/// 内容摘要： DB列名：Content[点评描述]
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
		
		#region Isnew属性
			private int m_Isnew = 0;
			/// <summary>
			/// 属性名称： Isnew
			/// 内容摘要： DB列名：IsNew[新点评(对于管理员而言的：1-.新,0浏览过)]
			///            DB类型：int
			/// </summary>
			public int Isnew
			{
				get
					{
						return m_Isnew;
					}
				set
					{
						if (m_Isnew as object == null || !m_Isnew.Equals(value))
						{
							m_Isnew = value;
							MarkUpdated();
						}						
					}
			}
		#endregion
		
		#region Isshow属性
			private int m_Isshow = 0;
			/// <summary>
			/// 属性名称： Isshow
			/// 内容摘要： DB列名：IsShow[是否显示]
			///            DB类型：int
			/// </summary>
			public int Isshow
			{
				get
					{
						return m_Isshow;
					}
				set
					{
						if (m_Isshow as object == null || !m_Isshow.Equals(value))
						{
							m_Isshow = value;
							MarkUpdated();
						}						
					}
			}
		#endregion
		
		#region Replycontent属性
			private string m_Replycontent = String.Empty;
			/// <summary>
			/// 属性名称： Replycontent
			/// 内容摘要： DB列名：ReplyContent[回复]
			///            DB类型：nvarchar(255)
			/// </summary>
			public string Replycontent
			{
				get
					{
						return m_Replycontent;
					}
				set
					{
						if (m_Replycontent as object == null || !m_Replycontent.Equals(value))
						{
							m_Replycontent = value;
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
			///            DB类型：nvarchar(50)
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
		
		#region Avgscore属性
			private decimal m_Avgscore = 0.0M;
			/// <summary>
			/// 属性名称： Avgscore
			/// 内容摘要： DB列名：AvgScore[平均分]
			///            DB类型：numeric(10,1)
			/// </summary>
			public decimal Avgscore
			{
				get
					{
						return m_Avgscore;
					}
				set
					{
						if (m_Avgscore as object == null || !m_Avgscore.Equals(value))
						{
							m_Avgscore = value;
							MarkUpdated();
						}						
					}
			}
		#endregion
		
		#region Good属性
			private int m_Good = 0;
			/// <summary>
			/// 属性名称： Good
			/// 内容摘要： DB列名：Good[顶]
			///            DB类型：int
			/// </summary>
			public int Good
			{
				get
					{
						return m_Good;
					}
				set
					{
						if (m_Good as object == null || !m_Good.Equals(value))
						{
							m_Good = value;
							MarkUpdated();
						}						
					}
			}
		#endregion
		
		#region Bad属性
			private int m_Bad = 0;
			/// <summary>
			/// 属性名称： Bad
			/// 内容摘要： DB列名：Bad[坏]
			///            DB类型：int
			/// </summary>
			public int Bad
			{
				get
					{
						return m_Bad;
					}
				set
					{
						if (m_Bad as object == null || !m_Bad.Equals(value))
						{
							m_Bad = value;
							MarkUpdated();
						}						
					}
			}
		#endregion
		
		#region Viewtimes属性
			private int m_Viewtimes = 0;
			/// <summary>
			/// 属性名称： Viewtimes
			/// 内容摘要： DB列名：ViewTimes[]
			///            DB类型：int
			/// </summary>
			public int Viewtimes
			{
				get
					{
						return m_Viewtimes;
					}
				set
					{
						if (m_Viewtimes as object == null || !m_Viewtimes.Equals(value))
						{
							m_Viewtimes = value;
							MarkUpdated();
						}						
					}
			}
		#endregion
		
		#region Email属性
			private string m_Email = String.Empty;
			/// <summary>
			/// 属性名称： Email
			/// 内容摘要： DB列名：email[]
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
		
		#region Phone属性
			private string m_Phone = String.Empty;
			/// <summary>
			/// 属性名称： Phone
			/// 内容摘要： DB列名：phone[]
			///            DB类型：nvarchar(50)
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
					dtResult.Columns.Add(new DataColumn("PGUID",typeof(string)));
					dtResult.Columns.Add(new DataColumn("Score1",typeof(decimal)));
					dtResult.Columns.Add(new DataColumn("Score2",typeof(decimal)));
					dtResult.Columns.Add(new DataColumn("Score3",typeof(decimal)));
					dtResult.Columns.Add(new DataColumn("Score4",typeof(decimal)));
					dtResult.Columns.Add(new DataColumn("Score5",typeof(decimal)));
					dtResult.Columns.Add(new DataColumn("Content",typeof(string)));
					dtResult.Columns.Add(new DataColumn("IsNew",typeof(int)));
					dtResult.Columns.Add(new DataColumn("IsShow",typeof(int)));
					dtResult.Columns.Add(new DataColumn("ReplyContent",typeof(string)));
					dtResult.Columns.Add(new DataColumn("CREATOR",typeof(string)));
					dtResult.Columns.Add(new DataColumn("CREATE_DATE",typeof(DateTime)));
					dtResult.Columns.Add(new DataColumn("AvgScore",typeof(decimal)));
					dtResult.Columns.Add(new DataColumn("Good",typeof(int)));
					dtResult.Columns.Add(new DataColumn("Bad",typeof(int)));
					dtResult.Columns.Add(new DataColumn("ViewTimes",typeof(int)));
					dtResult.Columns.Add(new DataColumn("email",typeof(string)));
					dtResult.Columns.Add(new DataColumn("phone",typeof(string)));
				}
				else if (cne == ColumnNameEnum.PropertyName)
				{
					dtResult.Columns.Add(new DataColumn("Seqno",typeof(int)));
					dtResult.Columns.Add(new DataColumn("Guid",typeof(string)));
					dtResult.Columns.Add(new DataColumn("Pguid",typeof(string)));
					dtResult.Columns.Add(new DataColumn("Score1",typeof(decimal)));
					dtResult.Columns.Add(new DataColumn("Score2",typeof(decimal)));
					dtResult.Columns.Add(new DataColumn("Score3",typeof(decimal)));
					dtResult.Columns.Add(new DataColumn("Score4",typeof(decimal)));
					dtResult.Columns.Add(new DataColumn("Score5",typeof(decimal)));
					dtResult.Columns.Add(new DataColumn("Content",typeof(string)));
					dtResult.Columns.Add(new DataColumn("Isnew",typeof(int)));
					dtResult.Columns.Add(new DataColumn("Isshow",typeof(int)));
					dtResult.Columns.Add(new DataColumn("Replycontent",typeof(string)));
					dtResult.Columns.Add(new DataColumn("Creator",typeof(string)));
					dtResult.Columns.Add(new DataColumn("CreateDate",typeof(DateTime)));
					dtResult.Columns.Add(new DataColumn("Avgscore",typeof(decimal)));
					dtResult.Columns.Add(new DataColumn("Good",typeof(int)));
					dtResult.Columns.Add(new DataColumn("Bad",typeof(int)));
					dtResult.Columns.Add(new DataColumn("Viewtimes",typeof(int)));
					dtResult.Columns.Add(new DataColumn("Email",typeof(string)));
					dtResult.Columns.Add(new DataColumn("Phone",typeof(string)));
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
					dr["PGUID"] = this.Pguid;
					dr["Score1"] = this.Score1;
					dr["Score2"] = this.Score2;
					dr["Score3"] = this.Score3;
					dr["Score4"] = this.Score4;
					dr["Score5"] = this.Score5;
					dr["Content"] = this.Content;
					dr["IsNew"] = this.Isnew;
					dr["IsShow"] = this.Isshow;
					dr["ReplyContent"] = this.Replycontent;
					dr["CREATOR"] = this.Creator;
					dr["CREATE_DATE"] = this.CreateDate;
					dr["AvgScore"] = this.Avgscore;
					dr["Good"] = this.Good;
					dr["Bad"] = this.Bad;
					dr["ViewTimes"] = this.Viewtimes;
					dr["email"] = this.Email;
					dr["phone"] = this.Phone;
				}
				else if (ColumnNameEnum.PropertyName == cne)
				{
					dr["Seqno"] = this.Seqno;
					dr["Guid"] = this.Guid;
					dr["Pguid"] = this.Pguid;
					dr["Score1"] = this.Score1;
					dr["Score2"] = this.Score2;
					dr["Score3"] = this.Score3;
					dr["Score4"] = this.Score4;
					dr["Score5"] = this.Score5;
					dr["Content"] = this.Content;
					dr["Isnew"] = this.Isnew;
					dr["Isshow"] = this.Isshow;
					dr["Replycontent"] = this.Replycontent;
					dr["Creator"] = this.Creator;
					dr["CreateDate"] = this.CreateDate;
					dr["Avgscore"] = this.Avgscore;
					dr["Good"] = this.Good;
					dr["Bad"] = this.Bad;
					dr["Viewtimes"] = this.Viewtimes;
					dr["Email"] = this.Email;
					dr["Phone"] = this.Phone;					
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
			/// 将DataRow转换成Comment对象
			/// </summary>
			/// <param name="dr">由CreateTable生成的DataTable通过NewRow得到的DataRow对象</param>
			/// <param name="cne">dr的列名映射方式:DB列名或属性名</param>
			/// <returns>Comment对象</returns>
			public static Comment Dr2Obj(DataRow dr,ColumnNameEnum cne)
			{
				if (dr == null)
				{
					throw new ArgumentNullException("dr");
				}
				Comment obj = new Comment();
				if (ColumnNameEnum.DBName == cne)
				{
					obj.Seqno = (dr["Seqno"] == Convert.DBNull) ? 0  : (int)Convert.ChangeType(dr["Seqno"],typeof(int));
					obj.Guid = (dr["GUID"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["GUID"],typeof(string));
					obj.Pguid = (dr["PGUID"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["PGUID"],typeof(string));
					obj.Score1 = (dr["Score1"] == Convert.DBNull) ? 0  : (decimal)Convert.ChangeType(dr["Score1"],typeof(decimal));
					obj.Score2 = (dr["Score2"] == Convert.DBNull) ? 0  : (decimal)Convert.ChangeType(dr["Score2"],typeof(decimal));
					obj.Score3 = (dr["Score3"] == Convert.DBNull) ? 0  : (decimal)Convert.ChangeType(dr["Score3"],typeof(decimal));
					obj.Score4 = (dr["Score4"] == Convert.DBNull) ? 0  : (decimal)Convert.ChangeType(dr["Score4"],typeof(decimal));
					obj.Score5 = (dr["Score5"] == Convert.DBNull) ? 0  : (decimal)Convert.ChangeType(dr["Score5"],typeof(decimal));
					obj.Content = (dr["Content"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Content"],typeof(string));
					obj.Isnew = (dr["IsNew"] == Convert.DBNull) ? 0  : (int)Convert.ChangeType(dr["IsNew"],typeof(int));
					obj.Isshow = (dr["IsShow"] == Convert.DBNull) ? 0  : (int)Convert.ChangeType(dr["IsShow"],typeof(int));
					obj.Replycontent = (dr["ReplyContent"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["ReplyContent"],typeof(string));
					obj.Creator = (dr["CREATOR"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["CREATOR"],typeof(string));
					obj.CreateDate = (dr["CREATE_DATE"] == Convert.DBNull) ? new DateTime(1900,1,1)  : (DateTime)Convert.ChangeType(dr["CREATE_DATE"],typeof(DateTime));
					obj.Avgscore = (dr["AvgScore"] == Convert.DBNull) ? 0  : (decimal)Convert.ChangeType(dr["AvgScore"],typeof(decimal));
					obj.Good = (dr["Good"] == Convert.DBNull) ? 0  : (int)Convert.ChangeType(dr["Good"],typeof(int));
					obj.Bad = (dr["Bad"] == Convert.DBNull) ? 0  : (int)Convert.ChangeType(dr["Bad"],typeof(int));
					obj.Viewtimes = (dr["ViewTimes"] == Convert.DBNull) ? 0  : (int)Convert.ChangeType(dr["ViewTimes"],typeof(int));
					obj.Email = (dr["email"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["email"],typeof(string));
					obj.Phone = (dr["phone"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["phone"],typeof(string));
				}
				else if (ColumnNameEnum.PropertyName == cne)
				{
					obj.Seqno = (dr["Seqno"] == Convert.DBNull) ? 0  : (int)Convert.ChangeType(dr["Seqno"],typeof(int));
					obj.Guid = (dr["Guid"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Guid"],typeof(string));
					obj.Pguid = (dr["Pguid"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Pguid"],typeof(string));
					obj.Score1 = (dr["Score1"] == Convert.DBNull) ? 0  : (decimal)Convert.ChangeType(dr["Score1"],typeof(decimal));
					obj.Score2 = (dr["Score2"] == Convert.DBNull) ? 0  : (decimal)Convert.ChangeType(dr["Score2"],typeof(decimal));
					obj.Score3 = (dr["Score3"] == Convert.DBNull) ? 0  : (decimal)Convert.ChangeType(dr["Score3"],typeof(decimal));
					obj.Score4 = (dr["Score4"] == Convert.DBNull) ? 0  : (decimal)Convert.ChangeType(dr["Score4"],typeof(decimal));
					obj.Score5 = (dr["Score5"] == Convert.DBNull) ? 0  : (decimal)Convert.ChangeType(dr["Score5"],typeof(decimal));
					obj.Content = (dr["Content"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Content"],typeof(string));
					obj.Isnew = (dr["Isnew"] == Convert.DBNull) ? 0  : (int)Convert.ChangeType(dr["Isnew"],typeof(int));
					obj.Isshow = (dr["Isshow"] == Convert.DBNull) ? 0  : (int)Convert.ChangeType(dr["Isshow"],typeof(int));
					obj.Replycontent = (dr["Replycontent"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Replycontent"],typeof(string));
					obj.Creator = (dr["Creator"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Creator"],typeof(string));
					obj.CreateDate = (dr["CreateDate"] == Convert.DBNull) ? new DateTime(1900,1,1)  : (DateTime)Convert.ChangeType(dr["CreateDate"],typeof(DateTime));
					obj.Avgscore = (dr["Avgscore"] == Convert.DBNull) ? 0  : (decimal)Convert.ChangeType(dr["Avgscore"],typeof(decimal));
					obj.Good = (dr["Good"] == Convert.DBNull) ? 0  : (int)Convert.ChangeType(dr["Good"],typeof(int));
					obj.Bad = (dr["Bad"] == Convert.DBNull) ? 0  : (int)Convert.ChangeType(dr["Bad"],typeof(int));
					obj.Viewtimes = (dr["Viewtimes"] == Convert.DBNull) ? 0  : (int)Convert.ChangeType(dr["Viewtimes"],typeof(int));
					obj.Email = (dr["Email"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Email"],typeof(string));
					obj.Phone = (dr["Phone"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Phone"],typeof(string));		
				}
				
				return obj;
			}
			
			/// <summary>
			/// 将DataRow转换成Comment对象(默认列名映射为属性名)
			/// </summary>
			/// <returns>Comment对象</returns>
			public static Comment Dr2Obj(DataRow dr)
			{
				return Dr2Obj(dr,ColumnNameEnum.DBName);
			}
			
			/// <summary>
			/// 将DataTabe转换成的Comment对象集合
			/// </summary>
			/// <param name="dt">由CreateTable生成的DataTable</param>
			/// <param name="cne">dt的列名映射方式:DB列名或属性名</param>
			/// <returns>Comment对象的集合</returns>
			public static List<Comment>  Dt2Objs(DataTable dt,ColumnNameEnum cne)
			{
				if (dt == null)
				{
					throw new ArgumentNullException("dt");
				}
				
				 
				List<Comment> alResult = new List<Comment>();
				
				foreach(DataRow dr in dt.Rows)
				{
					alResult.Add(Dr2Obj(dr,cne));
				}
				
				return alResult;
			}

			/// <summary>
			/// 将DataTabe转换成的Comment对象集合(默认列名映射为属性名)
			/// </summary>
			/// <param name="dt">由CreateTable生成的DataTable</param>
			/// <returns>Comment对象的集合</returns>
			public static List<Comment> Dt2Objs(DataTable dt)
			{
				return Dt2Objs(dt,ColumnNameEnum.DBName);
			}
			
			/// <summary>
			/// 用objs的Comment对象集合填充DataTable
			/// </summary>
			/// <param name="dt">由CreateTable生成的DataTable</param>
			/// <param name="objs">Comment对象集合</param>
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
				
				foreach(Comment obj in objs)
				{
					DataRow dr = dt.NewRow();
					obj.FillDataRow(dr,cne);
					dt.Rows.Add(dr);
				}
			}

			/// <summary>
			/// 用objs的Comment对象集合填充DataTable(默认列名映射为属性名)
			/// </summary>
			/// <param name="dt">由CreateTable生成的DataTable</param>
			/// <param name="objs">Comment对象集合</param>
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
			Comment old = this.OldValue as Comment;
			if (old != null)
			{
					this.Seqno = old.Seqno;
					this.Guid = old.Guid;
					this.Pguid = old.Pguid;
					this.Score1 = old.Score1;
					this.Score2 = old.Score2;
					this.Score3 = old.Score3;
					this.Score4 = old.Score4;
					this.Score5 = old.Score5;
					this.Content = old.Content;
					this.Isnew = old.Isnew;
					this.Isshow = old.Isshow;
					this.Replycontent = old.Replycontent;
					this.Creator = old.Creator;
					this.CreateDate = old.CreateDate;
					this.Avgscore = old.Avgscore;
					this.Good = old.Good;
					this.Bad = old.Bad;
					this.Viewtimes = old.Viewtimes;
					this.Email = old.Email;
					this.Phone = old.Phone;				
				this.OldValue = null;
			}
		}
		
		
		
		
		#region Comment实体的内部Key类
			/// <summary>
			/// Comment实体的Key类
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
			/// 得到实体Comment的PK
			/// </summary>
			public Key GetKey()
			{
				return new Key(Seqno);				
			}
	
		
		#endregion
	}
}
