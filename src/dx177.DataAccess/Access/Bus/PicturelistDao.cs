/*
版权所有：版权所有(C) 2012，321Nets
文件编号：M01_PicturelistDao.cs
文件名称：PicturelistBLL.cs
系统编号：Z0003007
系统名称：通用办公系统
模块编号：M01
模块名称：信息发布
设计文档：IOA_M01信息发布XDE建模.mdx
完成日期：2012/6/24
作　　者：
内容摘要：表[PictureList]对应的业务逻辑 BLL
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
	/// Picturelist的BLL
	/// 该BLL已经生成了基本的业务操作，在自动生成的方法中已经提供了事务机制
	/// </summary>
	public class PicturelistDao 
	{
		#region 自动生成代码：取得相关实体

		//数据库连接字符串(web.config来配置)
		//<add key="ConnectionString" value="Provider=Microsoft.Jet.OLEDB.4.0; Data Source=D:\\db1.mdb" />
		
		protected static string connectionString =
			string.Format(ConfigurationSettings.AppSettings["ConnectionNewString"],
			              System.Web.HttpContext.Current.Request.PhysicalApplicationPath);

		/// <summary>
		/// 方法名称: PicturelistDao
		/// 内容摘要: 构造函数进行初始化
		/// </summary>
		protected PicturelistDao()
		{
		}

		private static volatile PicturelistDao m_instance = null;
		/// <summary>
		/// 方法名称: GetInstance
		/// 内容摘要: 取得 PicturelistDao 对象
		/// </summary>
		/// <returns>返回一个已经存在的实体</returns>
		public static PicturelistDao GetInstance()
		{
			// 通用的必要代码 iBatisNet双校检机制,如果实例不存在
			if (m_instance == null)
			{
				lock (typeof (PicturelistDao))
				{

					// 如果实例不存在
					if (m_instance == null)
					{

						// 创建一个的实例
						m_instance = new PicturelistDao();
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
		//private static Picturelist DataReaderToEntity(IDataReader dataReader)
		//{
		//	Picturelist obj = null;			
        //    while (dataReader.Read())
        //    {
		//		obj = new Picturelist();
		
		//
		//	}
		//	return obj;
		//}	
		/// <summary>
        /// 将DataReader的属性值转化为实体类的属性值，返回实体类
        /// </summary>
        /// <param name="dataReader">有效的DataReader对象</param>
        /// <returns>实体类对象</returns>
        private Picturelist DataRowToEntity(DataRow dataReader)
        {            
			Picturelist obj = new Picturelist();
		
		
		 if (dataReader["Seqno"]!= DBNull.Value) obj.Seqno = (int)dataReader["Seqno"];
		 if (dataReader["PGUID"]!= DBNull.Value) obj.Pguid = (string)dataReader["PGUID"];
		 if (dataReader["Title"]!= DBNull.Value) obj.Title = (string)dataReader["Title"];
		 if (dataReader["BigImgFile"]!= DBNull.Value) obj.Bigimgfile = (string)dataReader["BigImgFile"];
		 if (dataReader["ShowIdx"]!= DBNull.Value) obj.Showidx = (int)dataReader["ShowIdx"];
		 if (dataReader["SmallImgFile"]!= DBNull.Value) obj.Smallimgfile = (string)dataReader["SmallImgFile"];
		 if (dataReader["CREATOR"]!= DBNull.Value) obj.Creator = (string)dataReader["CREATOR"];
		 if (dataReader["CREATE_DATE"]!= DBNull.Value) obj.CreateDate = (DateTime)dataReader["CREATE_DATE"];
		 if (dataReader["ViewTimes"]!= DBNull.Value) obj.Viewtimes = (int)dataReader["ViewTimes"];
		 if (dataReader["Descprition"]!= DBNull.Value) obj.Descprition = (string)dataReader["Descprition"];
		 if (dataReader["JingQuCode"]!= DBNull.Value) obj.Jingqucode = (string)dataReader["JingQuCode"];
			
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
		public int Insert(Picturelist entity)
		{
			int returnValue = -1;
			using (OleDbConnection connection = new OleDbConnection(connectionString))
            {   
				try
				{
				
					OleDbParameter p;
					string sqlCommand = "Insert into PictureList([PGUID],[Title],[BigImgFile],[ShowIdx],[SmallImgFile],[CREATOR],[CREATE_DATE],[ViewTimes],[Descprition],[JingQuCode]) values (?,?,?,?,?,?,?,?,?,?);";
					using (OleDbCommand cmd = new OleDbCommand(sqlCommand,connection))
					{
						connection.Open();					
						
		p = new OleDbParameter("@PGUID",OleDbType.VarChar);
		p.Value = entity.Pguid;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@Title",OleDbType.VarChar);
		p.Value = entity.Title;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@BigImgFile",OleDbType.VarChar);
		p.Value = entity.Bigimgfile;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@ShowIdx",OleDbType.Integer);
		p.Value = entity.Showidx;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@SmallImgFile",OleDbType.VarChar);
		p.Value = entity.Smallimgfile;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@CREATOR",OleDbType.VarChar);
		p.Value = entity.Creator;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@CREATE_DATE",OleDbType.DBTimeStamp);
		p.Value = DateTime.Parse(entity.CreateDate.ToString("yyyy-MM-dd HH:mm:ss"));
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@ViewTimes",OleDbType.Integer);
		p.Value = entity.Viewtimes;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@Descprition",OleDbType.VarChar);
		p.Value = entity.Descprition;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@JingQuCode",OleDbType.VarChar);
		p.Value = entity.Jingqucode;
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
		public bool Update(Picturelist entity)
		{
			bool returnValue = false;
			using (OleDbConnection connection = new OleDbConnection(connectionString))
            { 
			
				try
				{
					OleDbParameter p;
					string sqlCommand = "Update PictureList Set [PGUID] = ?,[Title] = ?,[BigImgFile] = ?,[ShowIdx] = ?,[SmallImgFile] = ?,[CREATOR] = ?,[CREATE_DATE] = ?,[ViewTimes] = ?,[Descprition] = ?,[JingQuCode] = ? where [Seqno] =?  ";
					using (OleDbCommand cmd = new OleDbCommand(sqlCommand,connection))
					{
						connection.Open();					
						
		p = new OleDbParameter("@PGUID",OleDbType.VarChar);
		p.Value = entity.Pguid;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@Title",OleDbType.VarChar);
		p.Value = entity.Title;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@BigImgFile",OleDbType.VarChar);
		p.Value = entity.Bigimgfile;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@ShowIdx",OleDbType.Integer);
		p.Value = entity.Showidx;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@SmallImgFile",OleDbType.VarChar);
		p.Value = entity.Smallimgfile;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@CREATOR",OleDbType.VarChar);
		p.Value = entity.Creator;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@CREATE_DATE",OleDbType.DBTimeStamp);
		p.Value = DateTime.Parse(entity.CreateDate.ToString("yyyy-MM-dd HH:mm:ss"));
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@ViewTimes",OleDbType.Integer);
		p.Value = entity.Viewtimes;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@Descprition",OleDbType.VarChar);
		p.Value = entity.Descprition;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@JingQuCode",OleDbType.VarChar);
		p.Value = entity.Jingqucode;
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
		public Picturelist SelectByID(Picturelist.Key entity)
        {
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
            
				try
				{
					OleDbParameter p;
					string sqlCommand = " select * From PictureList where [Seqno] = ?    ";
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
			
				string sqlCommand = "   select * From PictureList  ";
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
		public bool DeleteByID(Picturelist.Key entity)
        {
			try
			{
				using (OleDbConnection connection = new OleDbConnection(connectionString))
				{
            	
					OleDbParameter p;
					string sqlCommand = " delete From PictureList where [Seqno] = ?    ";
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
		