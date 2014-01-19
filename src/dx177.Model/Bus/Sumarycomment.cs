/*
版权所有：版权所有(C) 2011，刘建新
文件编号：M01_Sumarycomment.cs
文件名称：Sumarycomment.cs
系统编号：Z0003007
系统名称：通用办公系统
模块编号：M01
模块名称：信息发布
设计文档：IOA_M01信息发布XDE建模.mdx
完成日期：2011/3/24
作　　者：
内容摘要：表[SumaryComment]对应的实体类
*/

using System;
using System.Collections;
using System.Data;
using System.Collections.Generic;


namespace dx177.Model.Bus
{
		/// <summary>
		/// 类 编 号：
		/// 类 名 称：Sumarycomment
		/// 内容摘要：
		/// </summary>
		
		[Serializable]
		public class Sumarycomment : BaseModel
		{
		#region 自动生成代码
		
			#region 重载Equals/GetHashCode
			/// <summary>
			/// 重载Equals			
			/// </summary>
			public override bool Equals (Object obj)
			{
				if (obj != null && obj is Sumarycomment)
				{
					if (obj == this)
						return true;
					Sumarycomment castObj = (Sumarycomment)obj; 
					
					if (!this.m_Seqno.Equals(castObj.Seqno))
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
						
					if (!this.m_Scount1.Equals(castObj.Scount1))
						return false;
						
					if (!this.m_Scount2.Equals(castObj.Scount2))
						return false;
						
					if (!this.m_Scount3.Equals(castObj.Scount3))
						return false;
						
					if (!this.m_Scount4.Equals(castObj.Scount4))
						return false;
						
					if (!this.m_Scount5.Equals(castObj.Scount5))
						return false;
						
					if (!this.m_Avgscore.Equals(castObj.Avgscore))
						return false;
						
					if (!this.m_Sumarycontent.Equals(castObj.Sumarycontent))
						return false;
						
					if (!this.m_Lastcontent.Equals(castObj.Lastcontent))
						return false;
						
					if (!this.m_Replycontent.Equals(castObj.Replycontent))
						return false;
						
					if (!this.m_Isreply.Equals(castObj.Isreply))
						return false;
						
					if (!this.m_Creator.Equals(castObj.Creator))
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
					if ((object)m_Scount1 != null)
					{
						hash = hash ^ m_Scount1.GetHashCode();
					}
						
					hash = hash <<  8;
					if ((object)m_Scount2 != null)
					{
						hash = hash ^ m_Scount2.GetHashCode();
					}
						
					hash = hash <<  8;
					if ((object)m_Scount3 != null)
					{
						hash = hash ^ m_Scount3.GetHashCode();
					}
						
					hash = hash <<  8;
					if ((object)m_Scount4 != null)
					{
						hash = hash ^ m_Scount4.GetHashCode();
					}
						
					hash = hash <<  8;
					if ((object)m_Scount5 != null)
					{
						hash = hash ^ m_Scount5.GetHashCode();
					}
						
					hash = hash <<  8;
					if ((object)m_Avgscore != null)
					{
						hash = hash ^ m_Avgscore.GetHashCode();
					}
						
					hash = hash <<  8;
					if ((object)m_Sumarycontent != null)
					{
						hash = hash ^ m_Sumarycontent.GetHashCode();
					}
						
					hash = hash <<  8;
					if ((object)m_Lastcontent != null)
					{
						hash = hash ^ m_Lastcontent.GetHashCode();
					}
						
					hash = hash <<  8;
					if ((object)m_Replycontent != null)
					{
						hash = hash ^ m_Replycontent.GetHashCode();
					}
						
					hash = hash <<  8;
					if ((object)m_Isreply != null)
					{
						hash = hash ^ m_Isreply.GetHashCode();
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
						
					return hash; 
			}
			#endregion
			
			public Sumarycomment()
			{
				MarkNew();
			}						
			
			public Sumarycomment GetOldValue()
			{
				return OldValue as Sumarycomment;
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
		
		#region Pguid属性
			private string m_Pguid = String.Empty;
			/// <summary>
			/// 属性名称： Pguid
			/// 内容摘要： DB列名：PGUID[父GUID]
			///            DB类型：string
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
			private decimal m_Score1 = 0;
			/// <summary>
			/// 属性名称： Score1
			/// 内容摘要： DB列名：Score1[0-5分]
			///            DB类型：decimal
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
			private decimal m_Score2 = 0;
			/// <summary>
			/// 属性名称： Score2
			/// 内容摘要： DB列名：Score2[0-5分]
			///            DB类型：decimal
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
			private decimal m_Score3 = 0;
			/// <summary>
			/// 属性名称： Score3
			/// 内容摘要： DB列名：Score3[0-5分]
			///            DB类型：decimal
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
			private decimal m_Score4 = 0;
			/// <summary>
			/// 属性名称： Score4
			/// 内容摘要： DB列名：Score4[0-5分]
			///            DB类型：decimal
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
			private decimal m_Score5 = 0;
			/// <summary>
			/// 属性名称： Score5
			/// 内容摘要： DB列名：Score5[0-5分]
			///            DB类型：decimal
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
		
		#region Scount1属性
			private int m_Scount1 = 0;
			/// <summary>
			/// 属性名称： Scount1
			/// 内容摘要： DB列名：SCount1[点评1的数量]
			///            DB类型：int
			/// </summary>
			public int Scount1
			{
				get
					{
						return m_Scount1;
					}
				set
					{
						if (m_Scount1 as object == null || !m_Scount1.Equals(value))
						{
							m_Scount1 = value;
							MarkUpdated();
						}						
					}
			}
		#endregion
		
		#region Scount2属性
			private int m_Scount2 = 0;
			/// <summary>
			/// 属性名称： Scount2
			/// 内容摘要： DB列名：SCount2[点评2的数量]
			///            DB类型：int
			/// </summary>
			public int Scount2
			{
				get
					{
						return m_Scount2;
					}
				set
					{
						if (m_Scount2 as object == null || !m_Scount2.Equals(value))
						{
							m_Scount2 = value;
							MarkUpdated();
						}						
					}
			}
		#endregion
		
		#region Scount3属性
			private int m_Scount3 = 0;
			/// <summary>
			/// 属性名称： Scount3
			/// 内容摘要： DB列名：SCount3[点评3的数量]
			///            DB类型：int
			/// </summary>
			public int Scount3
			{
				get
					{
						return m_Scount3;
					}
				set
					{
						if (m_Scount3 as object == null || !m_Scount3.Equals(value))
						{
							m_Scount3 = value;
							MarkUpdated();
						}						
					}
			}
		#endregion
		
		#region Scount4属性
			private int m_Scount4 = 0;
			/// <summary>
			/// 属性名称： Scount4
			/// 内容摘要： DB列名：SCount4[点评4的数量]
			///            DB类型：int
			/// </summary>
			public int Scount4
			{
				get
					{
						return m_Scount4;
					}
				set
					{
						if (m_Scount4 as object == null || !m_Scount4.Equals(value))
						{
							m_Scount4 = value;
							MarkUpdated();
						}						
					}
			}
		#endregion
		
		#region Scount5属性
			private int m_Scount5 = 0;
			/// <summary>
			/// 属性名称： Scount5
			/// 内容摘要： DB列名：SCount5[点评5的数量]
			///            DB类型：int
			/// </summary>
			public int Scount5
			{
				get
					{
						return m_Scount5;
					}
				set
					{
						if (m_Scount5 as object == null || !m_Scount5.Equals(value))
						{
							m_Scount5 = value;
							MarkUpdated();
						}						
					}
			}
		#endregion
		
		#region Avgscore属性
			private decimal m_Avgscore = 0;
			/// <summary>
			/// 属性名称： Avgscore
			/// 内容摘要： DB列名：AvgScore[平均分]
			///            DB类型：decimal
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
		
		#region Sumarycontent属性
			private string m_Sumarycontent = String.Empty;
			/// <summary>
			/// 属性名称： Sumarycontent
			/// 内容摘要： DB列名：SumaryContent[综合点评]
			///            DB类型：string
			/// </summary>
			public string Sumarycontent
			{
				get
					{
						return m_Sumarycontent;
					}
				set
					{
						if (m_Sumarycontent as object == null || !m_Sumarycontent.Equals(value))
						{
							m_Sumarycontent = value;
							MarkUpdated();
						}						
					}
			}
		#endregion
		
		#region Lastcontent属性
			private string m_Lastcontent = String.Empty;
			/// <summary>
			/// 属性名称： Lastcontent
			/// 内容摘要： DB列名：LastContent[点评描述]
			///            DB类型：string
			/// </summary>
			public string Lastcontent
			{
				get
					{
						return m_Lastcontent;
					}
				set
					{
						if (m_Lastcontent as object == null || !m_Lastcontent.Equals(value))
						{
							m_Lastcontent = value;
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
			///            DB类型：string
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
		
		#region Isreply属性
			private int m_Isreply = 0;
			/// <summary>
			/// 属性名称： Isreply
			/// 内容摘要： DB列名：IsReply[是否回复]
			///            DB类型：int
			/// </summary>
			public int Isreply
			{
				get
					{
						return m_Isreply;
					}
				set
					{
						if (m_Isreply as object == null || !m_Isreply.Equals(value))
						{
							m_Isreply = value;
							MarkUpdated();
						}						
					}
			}
		#endregion
		
		#region Creator属性
			private string m_Creator = String.Empty;
			/// <summary>
			/// 属性名称： Creator
			/// 内容摘要： DB列名：CREATOR[用户]
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
					dtResult.Columns.Add(new DataColumn("PGUID",typeof(string)));
					dtResult.Columns.Add(new DataColumn("Score1",typeof(decimal)));
					dtResult.Columns.Add(new DataColumn("Score2",typeof(decimal)));
					dtResult.Columns.Add(new DataColumn("Score3",typeof(decimal)));
					dtResult.Columns.Add(new DataColumn("Score4",typeof(decimal)));
					dtResult.Columns.Add(new DataColumn("Score5",typeof(decimal)));
					dtResult.Columns.Add(new DataColumn("SCount1",typeof(int)));
					dtResult.Columns.Add(new DataColumn("SCount2",typeof(int)));
					dtResult.Columns.Add(new DataColumn("SCount3",typeof(int)));
					dtResult.Columns.Add(new DataColumn("SCount4",typeof(int)));
					dtResult.Columns.Add(new DataColumn("SCount5",typeof(int)));
					dtResult.Columns.Add(new DataColumn("AvgScore",typeof(decimal)));
					dtResult.Columns.Add(new DataColumn("SumaryContent",typeof(string)));
					dtResult.Columns.Add(new DataColumn("LastContent",typeof(string)));
					dtResult.Columns.Add(new DataColumn("ReplyContent",typeof(string)));
					dtResult.Columns.Add(new DataColumn("IsReply",typeof(int)));
					dtResult.Columns.Add(new DataColumn("CREATOR",typeof(string)));
					dtResult.Columns.Add(new DataColumn("CREATE_DATE",typeof(DateTime)));
				}
				else if (cne == ColumnNameEnum.PropertyName)
				{
					dtResult.Columns.Add(new DataColumn("Seqno",typeof(int)));
					dtResult.Columns.Add(new DataColumn("Pguid",typeof(string)));
					dtResult.Columns.Add(new DataColumn("Score1",typeof(decimal)));
					dtResult.Columns.Add(new DataColumn("Score2",typeof(decimal)));
					dtResult.Columns.Add(new DataColumn("Score3",typeof(decimal)));
					dtResult.Columns.Add(new DataColumn("Score4",typeof(decimal)));
					dtResult.Columns.Add(new DataColumn("Score5",typeof(decimal)));
					dtResult.Columns.Add(new DataColumn("Scount1",typeof(int)));
					dtResult.Columns.Add(new DataColumn("Scount2",typeof(int)));
					dtResult.Columns.Add(new DataColumn("Scount3",typeof(int)));
					dtResult.Columns.Add(new DataColumn("Scount4",typeof(int)));
					dtResult.Columns.Add(new DataColumn("Scount5",typeof(int)));
					dtResult.Columns.Add(new DataColumn("Avgscore",typeof(decimal)));
					dtResult.Columns.Add(new DataColumn("Sumarycontent",typeof(string)));
					dtResult.Columns.Add(new DataColumn("Lastcontent",typeof(string)));
					dtResult.Columns.Add(new DataColumn("Replycontent",typeof(string)));
					dtResult.Columns.Add(new DataColumn("Isreply",typeof(int)));
					dtResult.Columns.Add(new DataColumn("Creator",typeof(string)));
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
					dr["PGUID"] = this.Pguid;
					dr["Score1"] = this.Score1;
					dr["Score2"] = this.Score2;
					dr["Score3"] = this.Score3;
					dr["Score4"] = this.Score4;
					dr["Score5"] = this.Score5;
					dr["SCount1"] = this.Scount1;
					dr["SCount2"] = this.Scount2;
					dr["SCount3"] = this.Scount3;
					dr["SCount4"] = this.Scount4;
					dr["SCount5"] = this.Scount5;
					dr["AvgScore"] = this.Avgscore;
					dr["SumaryContent"] = this.Sumarycontent;
					dr["LastContent"] = this.Lastcontent;
					dr["ReplyContent"] = this.Replycontent;
					dr["IsReply"] = this.Isreply;
					dr["CREATOR"] = this.Creator;
					dr["CREATE_DATE"] = this.CreateDate;
				}
				else if (ColumnNameEnum.PropertyName == cne)
				{
					dr["Seqno"] = this.Seqno;
					dr["Pguid"] = this.Pguid;
					dr["Score1"] = this.Score1;
					dr["Score2"] = this.Score2;
					dr["Score3"] = this.Score3;
					dr["Score4"] = this.Score4;
					dr["Score5"] = this.Score5;
					dr["Scount1"] = this.Scount1;
					dr["Scount2"] = this.Scount2;
					dr["Scount3"] = this.Scount3;
					dr["Scount4"] = this.Scount4;
					dr["Scount5"] = this.Scount5;
					dr["Avgscore"] = this.Avgscore;
					dr["Sumarycontent"] = this.Sumarycontent;
					dr["Lastcontent"] = this.Lastcontent;
					dr["Replycontent"] = this.Replycontent;
					dr["Isreply"] = this.Isreply;
					dr["Creator"] = this.Creator;
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
			/// 将DataRow转换成Sumarycomment对象
			/// </summary>
			/// <param name="dr">由CreateTable生成的DataTable通过NewRow得到的DataRow对象</param>
			/// <param name="cne">dr的列名映射方式:DB列名或属性名</param>
			/// <returns>Sumarycomment对象</returns>
			public static Sumarycomment Dr2Obj(DataRow dr,ColumnNameEnum cne)
			{
				if (dr == null)
				{
					throw new ArgumentNullException("dr");
				}
				Sumarycomment obj = new Sumarycomment();
				if (ColumnNameEnum.DBName == cne)
				{
					obj.Seqno = (dr["Seqno"] == Convert.DBNull) ? 0  : (int)Convert.ChangeType(dr["Seqno"],typeof(int));
					obj.Pguid = (dr["PGUID"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["PGUID"],typeof(string));
					obj.Score1 = (dr["Score1"] == Convert.DBNull) ? 0  : (decimal)Convert.ChangeType(dr["Score1"],typeof(decimal));
					obj.Score2 = (dr["Score2"] == Convert.DBNull) ? 0  : (decimal)Convert.ChangeType(dr["Score2"],typeof(decimal));
					obj.Score3 = (dr["Score3"] == Convert.DBNull) ? 0  : (decimal)Convert.ChangeType(dr["Score3"],typeof(decimal));
					obj.Score4 = (dr["Score4"] == Convert.DBNull) ? 0  : (decimal)Convert.ChangeType(dr["Score4"],typeof(decimal));
					obj.Score5 = (dr["Score5"] == Convert.DBNull) ? 0  : (decimal)Convert.ChangeType(dr["Score5"],typeof(decimal));
					obj.Scount1 = (dr["SCount1"] == Convert.DBNull) ? 0  : (int)Convert.ChangeType(dr["SCount1"],typeof(int));
					obj.Scount2 = (dr["SCount2"] == Convert.DBNull) ? 0  : (int)Convert.ChangeType(dr["SCount2"],typeof(int));
					obj.Scount3 = (dr["SCount3"] == Convert.DBNull) ? 0  : (int)Convert.ChangeType(dr["SCount3"],typeof(int));
					obj.Scount4 = (dr["SCount4"] == Convert.DBNull) ? 0  : (int)Convert.ChangeType(dr["SCount4"],typeof(int));
					obj.Scount5 = (dr["SCount5"] == Convert.DBNull) ? 0  : (int)Convert.ChangeType(dr["SCount5"],typeof(int));
					obj.Avgscore = (dr["AvgScore"] == Convert.DBNull) ? 0  : (decimal)Convert.ChangeType(dr["AvgScore"],typeof(decimal));
					obj.Sumarycontent = (dr["SumaryContent"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["SumaryContent"],typeof(string));
					obj.Lastcontent = (dr["LastContent"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["LastContent"],typeof(string));
					obj.Replycontent = (dr["ReplyContent"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["ReplyContent"],typeof(string));
					obj.Isreply = (dr["IsReply"] == Convert.DBNull) ? 0  : (int)Convert.ChangeType(dr["IsReply"],typeof(int));
					obj.Creator = (dr["CREATOR"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["CREATOR"],typeof(string));
					obj.CreateDate = (dr["CREATE_DATE"] == Convert.DBNull) ? new DateTime(1900,1,1)  : (DateTime)Convert.ChangeType(dr["CREATE_DATE"],typeof(DateTime));
				}
				else if (ColumnNameEnum.PropertyName == cne)
				{
					obj.Seqno = (dr["Seqno"] == Convert.DBNull) ? 0  : (int)Convert.ChangeType(dr["Seqno"],typeof(int));
					obj.Pguid = (dr["Pguid"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Pguid"],typeof(string));
					obj.Score1 = (dr["Score1"] == Convert.DBNull) ? 0  : (decimal)Convert.ChangeType(dr["Score1"],typeof(decimal));
					obj.Score2 = (dr["Score2"] == Convert.DBNull) ? 0  : (decimal)Convert.ChangeType(dr["Score2"],typeof(decimal));
					obj.Score3 = (dr["Score3"] == Convert.DBNull) ? 0  : (decimal)Convert.ChangeType(dr["Score3"],typeof(decimal));
					obj.Score4 = (dr["Score4"] == Convert.DBNull) ? 0  : (decimal)Convert.ChangeType(dr["Score4"],typeof(decimal));
					obj.Score5 = (dr["Score5"] == Convert.DBNull) ? 0  : (decimal)Convert.ChangeType(dr["Score5"],typeof(decimal));
					obj.Scount1 = (dr["Scount1"] == Convert.DBNull) ? 0  : (int)Convert.ChangeType(dr["Scount1"],typeof(int));
					obj.Scount2 = (dr["Scount2"] == Convert.DBNull) ? 0  : (int)Convert.ChangeType(dr["Scount2"],typeof(int));
					obj.Scount3 = (dr["Scount3"] == Convert.DBNull) ? 0  : (int)Convert.ChangeType(dr["Scount3"],typeof(int));
					obj.Scount4 = (dr["Scount4"] == Convert.DBNull) ? 0  : (int)Convert.ChangeType(dr["Scount4"],typeof(int));
					obj.Scount5 = (dr["Scount5"] == Convert.DBNull) ? 0  : (int)Convert.ChangeType(dr["Scount5"],typeof(int));
					obj.Avgscore = (dr["Avgscore"] == Convert.DBNull) ? 0  : (decimal)Convert.ChangeType(dr["Avgscore"],typeof(decimal));
					obj.Sumarycontent = (dr["Sumarycontent"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Sumarycontent"],typeof(string));
					obj.Lastcontent = (dr["Lastcontent"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Lastcontent"],typeof(string));
					obj.Replycontent = (dr["Replycontent"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Replycontent"],typeof(string));
					obj.Isreply = (dr["Isreply"] == Convert.DBNull) ? 0  : (int)Convert.ChangeType(dr["Isreply"],typeof(int));
					obj.Creator = (dr["Creator"] == Convert.DBNull) ? null  : (string)Convert.ChangeType(dr["Creator"],typeof(string));
					obj.CreateDate = (dr["CreateDate"] == Convert.DBNull) ? new DateTime(1900,1,1)  : (DateTime)Convert.ChangeType(dr["CreateDate"],typeof(DateTime));		
				}
				
				return obj;
			}
			
			/// <summary>
			/// 将DataRow转换成Sumarycomment对象(默认列名映射为属性名)
			/// </summary>
			/// <returns>Sumarycomment对象</returns>
			public static Sumarycomment Dr2Obj(DataRow dr)
			{
				return Dr2Obj(dr,ColumnNameEnum.DBName);
			}
			
			/// <summary>
			/// 将DataTabe转换成的Sumarycomment对象集合
			/// </summary>
			/// <param name="dt">由CreateTable生成的DataTable</param>
			/// <param name="cne">dt的列名映射方式:DB列名或属性名</param>
			/// <returns>Sumarycomment对象的集合</returns>
			public static List<Sumarycomment> Dt2Objs(DataTable dt,ColumnNameEnum cne)
			{
				if (dt == null)
				{
					throw new ArgumentNullException("dt");
				}
				
				List<Sumarycomment> alResult = new List<Sumarycomment>();
				
				foreach(DataRow dr in dt.Rows)
				{
					alResult.Add(Dr2Obj(dr,cne));
				}
				
				return alResult;
			}

			/// <summary>
			/// 将DataTabe转换成的Sumarycomment对象集合(默认列名映射为属性名)
			/// </summary>
			/// <param name="dt">由CreateTable生成的DataTable</param>
			/// <returns>Sumarycomment对象的集合</returns>
			public static  List<Sumarycomment> Dt2Objs(DataTable dt)
			{
				return Dt2Objs(dt, ColumnNameEnum.DBName);
			}
			
			/// <summary>
			/// 用objs的Sumarycomment对象集合填充DataTable
			/// </summary>
			/// <param name="dt">由CreateTable生成的DataTable</param>
			/// <param name="objs">Sumarycomment对象集合</param>
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
				
				foreach(Sumarycomment obj in objs)
				{
					DataRow dr = dt.NewRow();
					obj.FillDataRow(dr,cne);
					dt.Rows.Add(dr);
				}
			}

			/// <summary>
			/// 用objs的Sumarycomment对象集合填充DataTable(默认列名映射为属性名)
			/// </summary>
			/// <param name="dt">由CreateTable生成的DataTable</param>
			/// <param name="objs">Sumarycomment对象集合</param>
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
			Sumarycomment old = this.OldValue as Sumarycomment;
			if (old != null)
			{
					this.Seqno = old.Seqno;
					this.Pguid = old.Pguid;
					this.Score1 = old.Score1;
					this.Score2 = old.Score2;
					this.Score3 = old.Score3;
					this.Score4 = old.Score4;
					this.Score5 = old.Score5;
					this.Scount1 = old.Scount1;
					this.Scount2 = old.Scount2;
					this.Scount3 = old.Scount3;
					this.Scount4 = old.Scount4;
					this.Scount5 = old.Scount5;
					this.Avgscore = old.Avgscore;
					this.Sumarycontent = old.Sumarycontent;
					this.Lastcontent = old.Lastcontent;
					this.Replycontent = old.Replycontent;
					this.Isreply = old.Isreply;
					this.Creator = old.Creator;
					this.CreateDate = old.CreateDate;				
				this.OldValue = null;
			}
		}
		
		
		
		
		#region Sumarycomment实体的内部Key类
			/// <summary>
			/// Sumarycomment实体的Key类
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
			/// 得到实体Sumarycomment的PK
			/// </summary>
			public Key GetKey()
			{
				return new Key(Seqno);				
			}
			
				
		#endregion
	}
}
