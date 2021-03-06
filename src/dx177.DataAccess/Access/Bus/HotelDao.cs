/*
版权所有：版权所有(C) 2013，321Nets
文件编号：M01_HotelDao.cs
文件名称：HotelBLL.cs
系统编号：Z0003007
系统名称：通用办公系统
模块编号：M01
模块名称：信息发布
设计文档：IOA_M01信息发布XDE建模.mdx
完成日期：2013-9-11
作　　者：
内容摘要：表[Hotel]对应的业务逻辑 BLL
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
    /// Hotel的BLL
    /// 该BLL已经生成了基本的业务操作，在自动生成的方法中已经提供了事务机制
    /// </summary>
    public class HotelDao
    {
        #region 自动生成代码：取得相关实体

        //数据库连接字符串(web.config来配置)
        //<add key="ConnectionString" value="Provider=Microsoft.Jet.OLEDB.4.0; Data Source=D:\\db1.mdb" />

        protected static string connectionString =
            string.Format(ConfigurationSettings.AppSettings["ConnectionNewString"],
                          System.Web.HttpContext.Current.Request.PhysicalApplicationPath);

        /// <summary>
        /// 方法名称: HotelDao
        /// 内容摘要: 构造函数进行初始化
        /// </summary>
        protected HotelDao()
        {
        }

        private static volatile HotelDao m_instance = null;
        /// <summary>
        /// 方法名称: GetInstance
        /// 内容摘要: 取得 HotelDao 对象
        /// </summary>
        /// <returns>返回一个已经存在的实体</returns>
        public static HotelDao GetInstance()
        {
            // 通用的必要代码 iBatisNet双校检机制,如果实例不存在
            if (m_instance == null)
            {
                lock (typeof(HotelDao))
                {

                    // 如果实例不存在
                    if (m_instance == null)
                    {

                        // 创建一个的实例
                        m_instance = new HotelDao();
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
        //private static Hotel DataReaderToEntity(IDataReader dataReader)
        //{
        //	Hotel obj = null;			
        //    while (dataReader.Read())
        //    {
        //		obj = new Hotel();

        //
        //	}
        //	return obj;
        //}	
        /// <summary>
        /// 将DataReader的属性值转化为实体类的属性值，返回实体类
        /// </summary>
        /// <param name="dataReader">有效的DataReader对象</param>
        /// <returns>实体类对象</returns>
        private Hotel DataRowToEntity(DataRow dataReader)
        {
            Hotel obj = new Hotel();


            if (dataReader["Seqno"] != DBNull.Value) obj.Seqno = (int)dataReader["Seqno"];
            if (dataReader["GUID"] != DBNull.Value) obj.Guid = (string)dataReader["GUID"];
            if (dataReader["Name"] != DBNull.Value) obj.Name = (string)dataReader["Name"];
            if (dataReader["City"] != DBNull.Value) obj.City = (string)dataReader["City"];
            if (dataReader["county"] != DBNull.Value) obj.County = (string)dataReader["county"];
            if (dataReader["Area"] != DBNull.Value) obj.Area = (string)dataReader["Area"];
            if (dataReader["Address"] != DBNull.Value) obj.Address = (string)dataReader["Address"];
            if (dataReader["Phone"] != DBNull.Value) obj.Phone = (string)dataReader["Phone"];
            if (dataReader["Line"] != DBNull.Value) obj.Line = (string)dataReader["Line"];
            if (dataReader["biz"] != DBNull.Value) obj.Biz = (string)dataReader["biz"];
            if (dataReader["Cost"] != DBNull.Value) obj.Cost = (double)dataReader["Cost"];
            if (dataReader["Website"] != DBNull.Value) obj.Website = (string)dataReader["Website"];
            if (dataReader["Logo"] != DBNull.Value) obj.Logo = (string)dataReader["Logo"];
            if (dataReader["Descr"] != DBNull.Value) obj.Descr = (string)dataReader["Descr"];
            if (dataReader["HotelType"] != DBNull.Value) obj.Hoteltype = (string)dataReader["HotelType"];
            if (dataReader["installationsStr"] != DBNull.Value) obj.Installationsstr = (string)dataReader["installationsStr"];
            if (dataReader["installationsVal"] != DBNull.Value) obj.Installationsval = (int)dataReader["installationsVal"];
            if (dataReader["CREATOR"] != DBNull.Value) obj.Creator = (string)dataReader["CREATOR"];
            if (dataReader["CREATE_DATE"] != DBNull.Value) obj.CreateDate = (DateTime)dataReader["CREATE_DATE"];
            if (dataReader["Laste_update_date"] != DBNull.Value) obj.LasteUpdateDate = (DateTime)dataReader["Laste_update_date"];
            if (dataReader["Laste_update_By"] != DBNull.Value) obj.LasteUpdateBy = (string)dataReader["Laste_update_By"];
            if (dataReader["QQ"] != DBNull.Value) obj.Qq = (string)dataReader["QQ"];
            if (dataReader["aliww"] != DBNull.Value) obj.Aliww = (string)dataReader["aliww"];
            if (dataReader["Tag"] != DBNull.Value) obj.Tag = (string)dataReader["Tag"];
            if (dataReader["Map"] != DBNull.Value) obj.Map = (string)dataReader["Map"];
            if (dataReader["ShowPr"] != DBNull.Value) obj.Showpr = (int)dataReader["ShowPr"];
            if (dataReader["Mobile"] != DBNull.Value) obj.Mobile = (string)dataReader["Mobile"];
            if (dataReader["Status"] != DBNull.Value) obj.Status = (int)dataReader["Status"];
            if (dataReader["MaxPrice"] != DBNull.Value) obj.Maxprice = (double)dataReader["MaxPrice"];
            if (dataReader["MinPrice"] != DBNull.Value) obj.Minprice = (double)dataReader["MinPrice"];
            if (dataReader["ViewTimes"] != DBNull.Value) obj.Viewtimes = (int)dataReader["ViewTimes"];
            if (dataReader["email"] != DBNull.Value) obj.Email = (string)dataReader["email"];
            if (dataReader["IsSendOrderEmail"] != DBNull.Value) obj.Issendorderemail = (int)dataReader["IsSendOrderEmail"];
            if (dataReader["JingQuCode"] != DBNull.Value) obj.Jingqucode = (string)dataReader["JingQuCode"];
            if (dataReader["RefType"] != DBNull.Value) obj.Reftype = (byte)dataReader["RefType"];
            if (dataReader["RefHotelID"] != DBNull.Value) obj.Refhotelid = (int)dataReader["RefHotelID"];

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
        public int Insert(Hotel entity)
		{
			int returnValue = -1;
			using (OleDbConnection connection = new OleDbConnection(connectionString))
            {   
				try
				{
				
					OleDbParameter p;
					string sqlCommand = "Insert into Hotel([GUID],[Name],[City],[county],[Area],[Address],[Phone],[Line],[biz],[Cost],[Website],[Logo],[Descr],[HotelType],[installationsStr],[installationsVal],[CREATOR],[CREATE_DATE],[Laste_update_date],[Laste_update_By],[QQ],[aliww],[Tag],[Map],[ShowPr],[Mobile],[Status],[MaxPrice],[MinPrice],[ViewTimes],[email],[IsSendOrderEmail],[JingQuCode],[RefType],[RefHotelID]) values (?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?,?);";
					using (OleDbCommand cmd = new OleDbCommand(sqlCommand,connection))
					{
						connection.Open();					
						
		p = new OleDbParameter("@GUID",OleDbType.VarChar);
		p.Value = entity.Guid;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@Name",OleDbType.VarChar);
		p.Value = entity.Name;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@City",OleDbType.VarChar);
		p.Value = entity.City;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@county",OleDbType.VarChar);
		p.Value = entity.County;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@Area",OleDbType.VarChar);
		p.Value = entity.Area;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@Address",OleDbType.VarChar);
		p.Value = entity.Address;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@Phone",OleDbType.VarChar);
		p.Value = entity.Phone;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@Line",OleDbType.VarChar);
		p.Value = entity.Line;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@biz",OleDbType.VarChar);
		p.Value = entity.Biz;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@Cost",OleDbType.Double);
		p.Value = entity.Cost;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@Website",OleDbType.VarChar);
		p.Value = entity.Website;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@Logo",OleDbType.VarChar);
		p.Value = entity.Logo;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@Descr",OleDbType.VarChar);
		p.Value = entity.Descr;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@HotelType",OleDbType.VarChar);
		p.Value = entity.Hoteltype;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@installationsStr",OleDbType.VarChar);
		p.Value = entity.Installationsstr;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@installationsVal",OleDbType.Integer);
		p.Value = entity.Installationsval;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@CREATOR",OleDbType.VarChar);
		p.Value = entity.Creator;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@CREATE_DATE",OleDbType.DBTimeStamp);
		p.Value = DateTime.Parse(entity.CreateDate.ToString("yyyy-MM-dd HH:mm:ss"));
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@Laste_update_date",OleDbType.DBTimeStamp);
		p.Value = DateTime.Parse(entity.LasteUpdateDate.ToString("yyyy-MM-dd HH:mm:ss"));
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@Laste_update_By",OleDbType.VarChar);
		p.Value = entity.LasteUpdateBy;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@QQ",OleDbType.VarChar);
		p.Value = entity.Qq;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@aliww",OleDbType.VarChar);
		p.Value = entity.Aliww;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@Tag",OleDbType.VarChar);
		p.Value = entity.Tag;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@Map",OleDbType.VarChar);
		p.Value = entity.Map;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@ShowPr",OleDbType.Integer);
		p.Value = entity.Showpr;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@Mobile",OleDbType.VarChar);
		p.Value = entity.Mobile;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@Status",OleDbType.Integer);
		p.Value = entity.Status;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@MaxPrice",OleDbType.Double);
		p.Value = entity.Maxprice;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@MinPrice",OleDbType.Double);
		p.Value = entity.Minprice;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@ViewTimes",OleDbType.Integer);
		p.Value = entity.Viewtimes;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@email",OleDbType.VarChar);
		p.Value = entity.Email;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@IsSendOrderEmail",OleDbType.Integer);
		p.Value = entity.Issendorderemail;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@JingQuCode",OleDbType.VarChar);
		p.Value = entity.Jingqucode;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@RefType",OleDbType.TinyInt);
		p.Value = entity.Reftype;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@RefHotelID",OleDbType.Integer);
		p.Value = entity.Refhotelid;
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
        public bool Update(Hotel entity)
		{
			bool returnValue = false;
			using (OleDbConnection connection = new OleDbConnection(connectionString))
            { 
			
				try
				{
					OleDbParameter p;
					string sqlCommand = "Update Hotel Set [GUID] = ?,[Name] = ?,[City] = ?,[county] = ?,[Area] = ?,[Address] = ?,[Phone] = ?,[Line] = ?,[biz] = ?,[Cost] = ?,[Website] = ?,[Logo] = ?,[Descr] = ?,[HotelType] = ?,[installationsStr] = ?,[installationsVal] = ?,[CREATOR] = ?,[CREATE_DATE] = ?,[Laste_update_date] = ?,[Laste_update_By] = ?,[QQ] = ?,[aliww] = ?,[Tag] = ?,[Map] = ?,[ShowPr] = ?,[Mobile] = ?,[Status] = ?,[MaxPrice] = ?,[MinPrice] = ?,[ViewTimes] = ?,[email] = ?,[IsSendOrderEmail] = ?,[JingQuCode] = ?,[RefType] = ?,[RefHotelID] = ? where [Seqno] =?  ";
					using (OleDbCommand cmd = new OleDbCommand(sqlCommand,connection))
					{
						connection.Open();					
						
		p = new OleDbParameter("@GUID",OleDbType.VarChar);
		p.Value = entity.Guid;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@Name",OleDbType.VarChar);
		p.Value = entity.Name;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@City",OleDbType.VarChar);
		p.Value = entity.City;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@county",OleDbType.VarChar);
		p.Value = entity.County;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@Area",OleDbType.VarChar);
		p.Value = entity.Area;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@Address",OleDbType.VarChar);
		p.Value = entity.Address;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@Phone",OleDbType.VarChar);
		p.Value = entity.Phone;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@Line",OleDbType.VarChar);
		p.Value = entity.Line;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@biz",OleDbType.VarChar);
		p.Value = entity.Biz;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@Cost",OleDbType.Double);
		p.Value = entity.Cost;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@Website",OleDbType.VarChar);
		p.Value = entity.Website;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@Logo",OleDbType.VarChar);
		p.Value = entity.Logo;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@Descr",OleDbType.VarChar);
		p.Value = entity.Descr;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@HotelType",OleDbType.VarChar);
		p.Value = entity.Hoteltype;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@installationsStr",OleDbType.VarChar);
		p.Value = entity.Installationsstr;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@installationsVal",OleDbType.Integer);
		p.Value = entity.Installationsval;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@CREATOR",OleDbType.VarChar);
		p.Value = entity.Creator;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@CREATE_DATE",OleDbType.DBTimeStamp);
		p.Value = DateTime.Parse(entity.CreateDate.ToString("yyyy-MM-dd HH:mm:ss"));
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@Laste_update_date",OleDbType.DBTimeStamp);
		p.Value = DateTime.Parse(entity.LasteUpdateDate.ToString("yyyy-MM-dd HH:mm:ss"));
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@Laste_update_By",OleDbType.VarChar);
		p.Value = entity.LasteUpdateBy;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@QQ",OleDbType.VarChar);
		p.Value = entity.Qq;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@aliww",OleDbType.VarChar);
		p.Value = entity.Aliww;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@Tag",OleDbType.VarChar);
		p.Value = entity.Tag;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@Map",OleDbType.VarChar);
		p.Value = entity.Map;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@ShowPr",OleDbType.Integer);
		p.Value = entity.Showpr;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@Mobile",OleDbType.VarChar);
		p.Value = entity.Mobile;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@Status",OleDbType.Integer);
		p.Value = entity.Status;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@MaxPrice",OleDbType.Double);
		p.Value = entity.Maxprice;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@MinPrice",OleDbType.Double);
		p.Value = entity.Minprice;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@ViewTimes",OleDbType.Integer);
		p.Value = entity.Viewtimes;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@email",OleDbType.VarChar);
		p.Value = entity.Email;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@IsSendOrderEmail",OleDbType.Integer);
		p.Value = entity.Issendorderemail;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@JingQuCode",OleDbType.VarChar);
		p.Value = entity.Jingqucode;
		cmd.Parameters.Add(p);
        p = new OleDbParameter("@RefType", OleDbType.TinyInt);
		p.Value = entity.Reftype;
		cmd.Parameters.Add(p);
		p = new OleDbParameter("@RefHotelID",OleDbType.Integer);
		p.Value = entity.Refhotelid;
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
        public Hotel SelectByID(Hotel.Key entity)
        {
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {

                try
                {
                    OleDbParameter p;
                    string sqlCommand = " select * From Hotel where [Seqno] = ?    ";
                    using (OleDbCommand cmd = new OleDbCommand(sqlCommand, connection))
                    {
                        connection.Open();

                        p = new OleDbParameter("@Seqno", DbType.Int32);
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

                string sqlCommand = "   select * From Hotel  ";
                using (OleDbCommand cmd = new OleDbCommand(sqlCommand, connection))
                {
                    connection.Open();
                    OleDbDataAdapter adp = new OleDbDataAdapter(sqlCommand, connection);
                    adp.SelectCommand = cmd;
                    DataTable dt = new DataTable();
                    adp.Fill(dt);
                    foreach (DataRow dr in dt.Rows)
                    {
                        ar.Add(DataRowToEntity(dr));
                    }
                    return ar;
                }
            }

        }
        public bool DeleteByID(Hotel.Key entity)
        {
            try
            {
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {

                    OleDbParameter p;
                    string sqlCommand = " delete From Hotel where [Seqno] = ?    ";
                    using (OleDbCommand cmd = new OleDbCommand(sqlCommand, connection))
                    {
                        connection.Open();

                        p = new OleDbParameter("@Seqno", DbType.Int32);
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
