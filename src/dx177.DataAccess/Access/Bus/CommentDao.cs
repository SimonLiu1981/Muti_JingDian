/*
版权所有：版权所有(C) 2012，321Nets
文件编号：M01_CommentDao.cs
文件名称：CommentBLL.cs
系统编号：Z0003007
系统名称：通用办公系统
模块编号：M01
模块名称：信息发布
设计文档：IOA_M01信息发布XDE建模.mdx
完成日期：2012-9-20
作　　者：
内容摘要：表[Comment]对应的业务逻辑 BLL
*/
using System;
using System.Data;
using System.Data.OleDb;
using System.Collections;
using System.Configuration;
 

using dx177.Model.Bus;

namespace dx177.Access.Bus
{
	/// <summary>
	/// Comment的BLL
	/// 该BLL已经生成了基本的业务操作，在自动生成的方法中已经提供了事务机制
	/// </summary>
	public class CommentDao 
	{
		#region 自动生成代码：取得相关实体

		//数据库连接字符串(web.config来配置)
		//<add key="ConnectionString" value="Provider=Microsoft.Jet.OLEDB.4.0; Data Source=D:\\db1.mdb" />
		
		protected static string connectionString =
			string.Format(ConfigurationSettings.AppSettings["ConnectionNewString"],
			              System.Web.HttpContext.Current.Request.PhysicalApplicationPath);

		/// <summary>
		/// 方法名称: CommentDao
		/// 内容摘要: 构造函数进行初始化
		/// </summary>
		protected CommentDao()
		{
		}

		private static volatile CommentDao m_instance = null;
		/// <summary>
		/// 方法名称: GetInstance
		/// 内容摘要: 取得 CommentDao 对象
		/// </summary>
		/// <returns>返回一个已经存在的实体</returns>
		public static CommentDao GetInstance()
		{
			// 通用的必要代码 iBatisNet双校检机制,如果实例不存在
			if (m_instance == null)
			{
				lock (typeof (CommentDao))
				{

					// 如果实例不存在
					if (m_instance == null)
					{

						// 创建一个的实例
						m_instance = new CommentDao();
					}
				}
			}

			// 返回业务逻辑对象
			return m_instance;
		}

		/// <summary>
		/// 将DataReader的属性值转化为实体类的属性值，返回实体类
		/// </summary>
		/// <param name="dataReader">有效的DataReader对象</param>
		/// <returns>实体类对象</returns>
		//private static Comment DataReaderToEntity(IDataReader dataReader)
		//{
		//	Comment obj = null;			
        //    while (dataReader.Read())
        //    {
		//		obj = new Comment();
		
		//
		//	}
		//	return obj;
		//}	
		/// <summary>
        /// 将DataReader的属性值转化为实体类的属性值，返回实体类
        /// </summary>
        /// <param name="dataReader">有效的DataReader对象</param>
        /// <returns>实体类对象</returns>
        private Comment DataRowToEntity(DataRow dataReader)
        {            
			Comment obj = new Comment();
		
		
		 if (dataReader["Seqno"]!= DBNull.Value) obj.Seqno = (int)dataReader["Seqno"];
		 if (dataReader["GUID"]!= DBNull.Value) obj.Guid = (string)dataReader["GUID"];
		 if (dataReader["PGUID"]!= DBNull.Value) obj.Pguid = (string)dataReader["PGUID"];
		 if (dataReader["Score1"]!= DBNull.Value) obj.Score1 = (decimal)dataReader["Score1"];
		 if (dataReader["Score2"]!= DBNull.Value) obj.Score2 = (decimal)dataReader["Score2"];
		 if (dataReader["Score3"]!= DBNull.Value) obj.Score3 = (decimal)dataReader["Score3"];
		 if (dataReader["Score4"]!= DBNull.Value) obj.Score4 = (decimal)dataReader["Score4"];
		 if (dataReader["Score5"]!= DBNull.Value) obj.Score5 = (decimal)dataReader["Score5"];
		 if (dataReader["Content"]!= DBNull.Value) obj.Content = (string)dataReader["Content"];
		 if (dataReader["IsNew"]!= DBNull.Value) obj.Isnew = (int)dataReader["IsNew"];
		 if (dataReader["IsShow"]!= DBNull.Value) obj.Isshow = (int)dataReader["IsShow"];
		 if (dataReader["ReplyContent"]!= DBNull.Value) obj.Replycontent = (string)dataReader["ReplyContent"];
		 if (dataReader["CREATOR"]!= DBNull.Value) obj.Creator = (string)dataReader["CREATOR"];
		 if (dataReader["CREATE_DATE"]!= DBNull.Value) obj.CreateDate = (DateTime)dataReader["CREATE_DATE"];
		 if (dataReader["AvgScore"]!= DBNull.Value) obj.Avgscore = (decimal)dataReader["AvgScore"];
		 if (dataReader["Good"]!= DBNull.Value) obj.Good = (int)dataReader["Good"];
		 if (dataReader["Bad"]!= DBNull.Value) obj.Bad = (int)dataReader["Bad"];
		 if (dataReader["ViewTimes"]!= DBNull.Value) obj.Viewtimes = (int)dataReader["ViewTimes"];
		 if (dataReader["email"]!= DBNull.Value) obj.Email = (string)dataReader["email"];
		 if (dataReader["phone"]!= DBNull.Value) obj.Phone = (string)dataReader["phone"];
			
			return obj;
		}	
		
		/// <summary>
		/// 插入对象
		/// </summary>
		/// <param name="entity">
		/// 实体里的主键被赋值
		///	</param>
		/// <returns>
		/// 返回当前插入的主键值
		///</returns>
		public int Insert(Comment entity)
		{
			int returnValue = -1;
			using (OleDbConnection connection = new OleDbConnection(connectionString))
            {   
				try
				{
				
					OleDbParameter p;
					string sqlCommand = "Insert into Comment([GUID],[PGUID],[Score1],[Score2],[Score3],[Score4],[Score5],[Content],[IsNew],[IsShow],[ReplyContent],[CREATOR],[CREATE_DATE],[AvgScore],[Good],[Bad],[ViewTimes],[email],[phone]) values (?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?);";
					using (OleDbCommand cmd = new OleDbCommand(sqlCommand,connection))
					{
						connection.Open();					
						
		p = new OleDbParameter("@GUID",OleDbType.VarChar);
		p.Value = entity.Guid;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@PGUID",OleDbType.VarChar);
		p.Value = entity.Pguid;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@Score1",OleDbType.Decimal);
		p.Value = entity.Score1;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@Score2",OleDbType.Decimal);
		p.Value = entity.Score2;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@Score3",OleDbType.Decimal);
		p.Value = entity.Score3;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@Score4",OleDbType.Decimal);
		p.Value = entity.Score4;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@Score5",OleDbType.Decimal);
		p.Value = entity.Score5;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@Content",OleDbType.VarChar);
		p.Value = entity.Content;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@IsNew",OleDbType.Integer);
		p.Value = entity.Isnew;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@IsShow",OleDbType.Integer);
		p.Value = entity.Isshow;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@ReplyContent",OleDbType.VarChar);
		p.Value = entity.Replycontent;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@CREATOR",OleDbType.VarChar);
		p.Value = entity.Creator;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@CREATE_DATE",OleDbType.DBTimeStamp);
		p.Value = DateTime.Parse(entity.CreateDate.ToString("yyyy-MM-dd HH:mm:ss"));
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@AvgScore",OleDbType.Decimal);
		p.Value = entity.Avgscore;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@Good",OleDbType.Integer);
		p.Value = entity.Good;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@Bad",OleDbType.Integer);
		p.Value = entity.Bad;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@ViewTimes",OleDbType.Integer);
		p.Value = entity.Viewtimes;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@email",OleDbType.VarChar);
		p.Value = entity.Email;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@phone",OleDbType.VarChar);
		p.Value = entity.Phone;
		cmd.Parameters.Add(p);			
						cmd.ExecuteNonQuery();
						
						sqlCommand = "SELECT @@IDENTITY AS ID";
												
						cmd.CommandText = sqlCommand;
						object o = cmd.ExecuteScalar();
						entity.Seqno =  Convert.ToInt32(o);;
						returnValue = entity.Seqno;
					}	
				}
				catch
				{	
					if (connection.State == ConnectionState.Open)
					{
						connection.Close();
					}
				}				
			}
			return returnValue;
		}
		/// <summary>
        /// 更新对象
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
		public bool Update(Comment entity)
		{
			bool returnValue = false;
			using (OleDbConnection connection = new OleDbConnection(connectionString))
            { 
			
				try
				{
					OleDbParameter p;
					string sqlCommand = "Update Comment Set [GUID] = ?,[PGUID] = ?,[Score1] = ?,[Score2] = ?,[Score3] = ?,[Score4] = ?,[Score5] = ?,[Content] = ?,[IsNew] = ?,[IsShow] = ?,[ReplyContent] = ?,[CREATOR] = ?,[CREATE_DATE] = ?,[AvgScore] = ?,[Good] = ?,[Bad] = ?,[ViewTimes] = ?,[email] = ?,[phone] = ? where [Seqno] =?  ";
					using (OleDbCommand cmd = new OleDbCommand(sqlCommand,connection))
					{
						connection.Open();					
						
		p = new OleDbParameter("@GUID",OleDbType.VarChar);
		p.Value = entity.Guid;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@PGUID",OleDbType.VarChar);
		p.Value = entity.Pguid;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@Score1",OleDbType.Decimal);
		p.Value = entity.Score1;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@Score2",OleDbType.Decimal);
		p.Value = entity.Score2;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@Score3",OleDbType.Decimal);
		p.Value = entity.Score3;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@Score4",OleDbType.Decimal);
		p.Value = entity.Score4;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@Score5",OleDbType.Decimal);
		p.Value = entity.Score5;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@Content",OleDbType.VarChar);
		p.Value = entity.Content;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@IsNew",OleDbType.Integer);
		p.Value = entity.Isnew;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@IsShow",OleDbType.Integer);
		p.Value = entity.Isshow;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@ReplyContent",OleDbType.VarChar);
		p.Value = entity.Replycontent;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@CREATOR",OleDbType.VarChar);
		p.Value = entity.Creator;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@CREATE_DATE",OleDbType.DBTimeStamp);
		p.Value = DateTime.Parse(entity.CreateDate.ToString("yyyy-MM-dd HH:mm:ss"));
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@AvgScore",OleDbType.Decimal);
		p.Value = entity.Avgscore;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@Good",OleDbType.Integer);
		p.Value = entity.Good;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@Bad",OleDbType.Integer);
		p.Value = entity.Bad;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@ViewTimes",OleDbType.Integer);
		p.Value = entity.Viewtimes;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@email",OleDbType.VarChar);
		p.Value = entity.Email;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@phone",OleDbType.VarChar);
		p.Value = entity.Phone;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@Seqno",OleDbType.Integer);
		p.Value = entity.Seqno;
		cmd.Parameters.Add(p);			
						cmd.ExecuteNonQuery();						
					}					
					returnValue = true;
				}
				catch
				{
					if (connection.State == ConnectionState.Open)
					{
						connection.Close();
					}
				}
			}
			return returnValue;	
		}
			
		/// <summary>
		/// 通过主键取得实体
		/// </summary>
		/// <param name="entity"> 主键 </param>
		/// <returns>实体对象</returns>
		public Comment SelectByID(Comment.Key entity)
        {
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
            
				try
				{
					OleDbParameter p;
					string sqlCommand = " select * From Comment where [Seqno] = ?    ";
					using (OleDbCommand cmd = new OleDbCommand(sqlCommand,connection))
					{   					
						connection.Open();				
						
		p = new OleDbParameter("@Seqno",DbType.Int32);
		p.Value = entity.Seqno;
		cmd.Parameters.Add(p);
						OleDbDataAdapter adp = new OleDbDataAdapter(sqlCommand, connection);
						adp.SelectCommand = cmd;
						DataTable dt = new DataTable();
						adp.Fill(dt);
						if (dt.Rows.Count > 0)
						{
							return DataRowToEntity(dt.Rows[0]);
						}
						else
						{
							return null;
						}
					} 
				}
				catch
				{
					if (connection.State == ConnectionState.Open)
					{
						connection.Close();
					}
					return null;
				}
           }
        }
		
		public IList SelectAll()
        {
            ArrayList ar = new ArrayList();
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
			
				string sqlCommand = "   select * From Comment  ";
				using (OleDbCommand cmd = new OleDbCommand(sqlCommand,connection))
                {
                    connection.Open();	                    
                    OleDbDataAdapter adp = new OleDbDataAdapter(sqlCommand, connection);
                    adp.SelectCommand = cmd;                    
                    DataTable dt = new DataTable();
                    adp.Fill(dt);
                    foreach(DataRow dr in dt.Rows)
                    {
                        ar.Add(DataRowToEntity(dr));
                    }
                    return ar;
                }                 
            }
			
        }
		public bool DeleteByID(Comment.Key entity)
        {
			try
			{
				using (OleDbConnection connection = new OleDbConnection(connectionString))
				{
            	
					OleDbParameter p;
					string sqlCommand = " delete From Comment where [Seqno] = ?    ";
					using (OleDbCommand cmd = new OleDbCommand(sqlCommand,connection))
					{     
						connection.Open();				
						
		p = new OleDbParameter("@Seqno",DbType.Int32);
		p.Value = entity.Seqno;
		cmd.Parameters.Add(p);								
                        cmd.ExecuteNonQuery();
                        return true;
                    }
                }
            }
            catch
            {
                return false;
            }
        }					
		#endregion
		
	}	
}		
		