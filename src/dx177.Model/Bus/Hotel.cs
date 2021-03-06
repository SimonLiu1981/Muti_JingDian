/*
版权所有：版权所有(C) 2013，中兴通讯
文件编号：M01_Hotel.cs
文件名称：Hotel.cs
系统编号：Z0003007
系统名称：通用办公系统
模块编号：M01
模块名称：信息发布
设计文档：IOA_M01信息发布XDE建模.mdx
完成日期：2013-9-11
作　　者：
内容摘要：表[Hotel]对应的实体类
*/

using System;
using System.Collections;
using System.Data;
using System.Collections.Generic;


namespace dx177.Model.Bus
{
    /// <summary>
    /// 类 编 号：
    /// 类 名 称：Hotel
    /// 内容摘要：
    /// </summary>

    [Serializable]
    public class Hotel : BaseModel
    {
        #region 自动生成代码

        #region 重载Equals/GetHashCode
        /// <summary>
        /// 重载Equals			
        /// </summary>
        public override bool Equals(Object obj)
        {
            if (obj != null && obj is Hotel)
            {
                if (obj == this)
                    return true;
                Hotel castObj = (Hotel)obj;

                if (!this.m_Seqno.Equals(castObj.Seqno))
                    return false;

                if (!this.m_Guid.Equals(castObj.Guid))
                    return false;

                if (!this.m_Name.Equals(castObj.Name))
                    return false;

                if (!this.m_City.Equals(castObj.City))
                    return false;

                if (!this.m_County.Equals(castObj.County))
                    return false;

                if (!this.m_Area.Equals(castObj.Area))
                    return false;

                if (!this.m_Address.Equals(castObj.Address))
                    return false;

                if (!this.m_Phone.Equals(castObj.Phone))
                    return false;

                if (!this.m_Line.Equals(castObj.Line))
                    return false;

                if (!this.m_Biz.Equals(castObj.Biz))
                    return false;

                if (!this.m_Cost.Equals(castObj.Cost))
                    return false;

                if (!this.m_Website.Equals(castObj.Website))
                    return false;

                if (!this.m_Logo.Equals(castObj.Logo))
                    return false;

                if (!this.m_Descr.Equals(castObj.Descr))
                    return false;

                if (!this.m_Hoteltype.Equals(castObj.Hoteltype))
                    return false;

                if (!this.m_Installationsstr.Equals(castObj.Installationsstr))
                    return false;

                if (!this.m_Installationsval.Equals(castObj.Installationsval))
                    return false;

                if (!this.m_Creator.Equals(castObj.Creator))
                    return false;

                if (!this.m_CreateDate.Equals(castObj.CreateDate))
                    return false;

                if (!this.m_LasteUpdateDate.Equals(castObj.LasteUpdateDate))
                    return false;

                if (!this.m_LasteUpdateBy.Equals(castObj.LasteUpdateBy))
                    return false;

                if (!this.m_Qq.Equals(castObj.Qq))
                    return false;

                if (!this.m_Aliww.Equals(castObj.Aliww))
                    return false;

                if (!this.m_Tag.Equals(castObj.Tag))
                    return false;

                if (!this.m_Map.Equals(castObj.Map))
                    return false;

                if (!this.m_Showpr.Equals(castObj.Showpr))
                    return false;

                if (!this.m_Mobile.Equals(castObj.Mobile))
                    return false;

                if (!this.m_Status.Equals(castObj.Status))
                    return false;

                if (!this.m_Maxprice.Equals(castObj.Maxprice))
                    return false;

                if (!this.m_Minprice.Equals(castObj.Minprice))
                    return false;

                if (!this.m_Viewtimes.Equals(castObj.Viewtimes))
                    return false;

                if (!this.m_Email.Equals(castObj.Email))
                    return false;

                if (!this.m_Issendorderemail.Equals(castObj.Issendorderemail))
                    return false;

                if (!this.m_Jingqucode.Equals(castObj.Jingqucode))
                    return false;

                if (!this.m_Reftype.Equals(castObj.Reftype))
                    return false;

                if (!this.m_Refhotelid.Equals(castObj.Refhotelid))
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

            hash = hash << 8;
            if ((object)m_Seqno != null)
            {
                hash = hash ^ m_Seqno.GetHashCode();
            }

            hash = hash << 8;
            if ((object)m_Guid != null)
            {
                hash = hash ^ m_Guid.GetHashCode();
            }

            hash = hash << 8;
            if ((object)m_Name != null)
            {
                hash = hash ^ m_Name.GetHashCode();
            }

            hash = hash << 8;
            if ((object)m_City != null)
            {
                hash = hash ^ m_City.GetHashCode();
            }

            hash = hash << 8;
            if ((object)m_County != null)
            {
                hash = hash ^ m_County.GetHashCode();
            }

            hash = hash << 8;
            if ((object)m_Area != null)
            {
                hash = hash ^ m_Area.GetHashCode();
            }

            hash = hash << 8;
            if ((object)m_Address != null)
            {
                hash = hash ^ m_Address.GetHashCode();
            }

            hash = hash << 8;
            if ((object)m_Phone != null)
            {
                hash = hash ^ m_Phone.GetHashCode();
            }

            hash = hash << 8;
            if ((object)m_Line != null)
            {
                hash = hash ^ m_Line.GetHashCode();
            }

            hash = hash << 8;
            if ((object)m_Biz != null)
            {
                hash = hash ^ m_Biz.GetHashCode();
            }

            hash = hash << 8;
            if ((object)m_Cost != null)
            {
                hash = hash ^ m_Cost.GetHashCode();
            }

            hash = hash << 8;
            if ((object)m_Website != null)
            {
                hash = hash ^ m_Website.GetHashCode();
            }

            hash = hash << 8;
            if ((object)m_Logo != null)
            {
                hash = hash ^ m_Logo.GetHashCode();
            }

            hash = hash << 8;
            if ((object)m_Descr != null)
            {
                hash = hash ^ m_Descr.GetHashCode();
            }

            hash = hash << 8;
            if ((object)m_Hoteltype != null)
            {
                hash = hash ^ m_Hoteltype.GetHashCode();
            }

            hash = hash << 8;
            if ((object)m_Installationsstr != null)
            {
                hash = hash ^ m_Installationsstr.GetHashCode();
            }

            hash = hash << 8;
            if ((object)m_Installationsval != null)
            {
                hash = hash ^ m_Installationsval.GetHashCode();
            }

            hash = hash << 8;
            if ((object)m_Creator != null)
            {
                hash = hash ^ m_Creator.GetHashCode();
            }

            hash = hash << 8;
            if ((object)m_CreateDate != null)
            {
                hash = hash ^ m_CreateDate.GetHashCode();
            }

            hash = hash << 8;
            if ((object)m_LasteUpdateDate != null)
            {
                hash = hash ^ m_LasteUpdateDate.GetHashCode();
            }

            hash = hash << 8;
            if ((object)m_LasteUpdateBy != null)
            {
                hash = hash ^ m_LasteUpdateBy.GetHashCode();
            }

            hash = hash << 8;
            if ((object)m_Qq != null)
            {
                hash = hash ^ m_Qq.GetHashCode();
            }

            hash = hash << 8;
            if ((object)m_Aliww != null)
            {
                hash = hash ^ m_Aliww.GetHashCode();
            }

            hash = hash << 8;
            if ((object)m_Tag != null)
            {
                hash = hash ^ m_Tag.GetHashCode();
            }

            hash = hash << 8;
            if ((object)m_Map != null)
            {
                hash = hash ^ m_Map.GetHashCode();
            }

            hash = hash << 8;
            if ((object)m_Showpr != null)
            {
                hash = hash ^ m_Showpr.GetHashCode();
            }

            hash = hash << 8;
            if ((object)m_Mobile != null)
            {
                hash = hash ^ m_Mobile.GetHashCode();
            }

            hash = hash << 8;
            if ((object)m_Status != null)
            {
                hash = hash ^ m_Status.GetHashCode();
            }

            hash = hash << 8;
            if ((object)m_Maxprice != null)
            {
                hash = hash ^ m_Maxprice.GetHashCode();
            }

            hash = hash << 8;
            if ((object)m_Minprice != null)
            {
                hash = hash ^ m_Minprice.GetHashCode();
            }

            hash = hash << 8;
            if ((object)m_Viewtimes != null)
            {
                hash = hash ^ m_Viewtimes.GetHashCode();
            }

            hash = hash << 8;
            if ((object)m_Email != null)
            {
                hash = hash ^ m_Email.GetHashCode();
            }

            hash = hash << 8;
            if ((object)m_Issendorderemail != null)
            {
                hash = hash ^ m_Issendorderemail.GetHashCode();
            }

            hash = hash << 8;
            if ((object)m_Jingqucode != null)
            {
                hash = hash ^ m_Jingqucode.GetHashCode();
            }

            hash = hash << 8;
            if ((object)m_Reftype != null)
            {
                hash = hash ^ m_Reftype.GetHashCode();
            }

            hash = hash << 8;
            if ((object)m_Refhotelid != null)
            {
                hash = hash ^ m_Refhotelid.GetHashCode();
            }

            return hash;
        }
        #endregion

        public Hotel()
        {
            MarkNew();
        }

        public Hotel GetOldValue()
        {
            return OldValue as Hotel;
        }

        #region Seqno属性
        private int m_Seqno = 0;
        /// <summary>
        /// 属性名称： Seqno
        /// 内容摘要： DB列名：Seqno[]
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

        #region Name属性
        private string m_Name = String.Empty;
        /// <summary>
        /// 属性名称： Name
        /// 内容摘要： DB列名：Name[]
        ///            DB类型：nvarchar(200)
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

        #region County属性
        private string m_County = String.Empty;
        /// <summary>
        /// 属性名称： County
        /// 内容摘要： DB列名：county[]
        ///            DB类型：nvarchar(50)
        /// </summary>
        public string County
        {
            get
            {
                return m_County;
            }
            set
            {
                if (m_County as object == null || !m_County.Equals(value))
                {
                    m_County = value;
                    MarkUpdated();
                }
            }
        }
        #endregion

        #region Area属性
        private string m_Area = String.Empty;
        /// <summary>
        /// 属性名称： Area
        /// 内容摘要： DB列名：Area[]
        ///            DB类型：nvarchar(50)
        /// </summary>
        public string Area
        {
            get
            {
                return m_Area;
            }
            set
            {
                if (m_Area as object == null || !m_Area.Equals(value))
                {
                    m_Area = value;
                    MarkUpdated();
                }
            }
        }
        #endregion

        #region Address属性
        private string m_Address = String.Empty;
        /// <summary>
        /// 属性名称： Address
        /// 内容摘要： DB列名：Address[]
        ///            DB类型：nvarchar(255)
        /// </summary>
        public string Address
        {
            get
            {
                return m_Address;
            }
            set
            {
                if (m_Address as object == null || !m_Address.Equals(value))
                {
                    m_Address = value;
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

        #region Line属性
        private string m_Line = String.Empty;
        /// <summary>
        /// 属性名称： Line
        /// 内容摘要： DB列名：Line[]
        ///            DB类型：nvarchar(255)
        /// </summary>
        public string Line
        {
            get
            {
                return m_Line;
            }
            set
            {
                if (m_Line as object == null || !m_Line.Equals(value))
                {
                    m_Line = value;
                    MarkUpdated();
                }
            }
        }
        #endregion

        #region Biz属性
        private string m_Biz = String.Empty;
        /// <summary>
        /// 属性名称： Biz
        /// 内容摘要： DB列名：biz[]
        ///            DB类型：nvarchar(255)
        /// </summary>
        public string Biz
        {
            get
            {
                return m_Biz;
            }
            set
            {
                if (m_Biz as object == null || !m_Biz.Equals(value))
                {
                    m_Biz = value;
                    MarkUpdated();
                }
            }
        }
        #endregion

        #region Cost属性
        private double m_Cost = 0.0;
        /// <summary>
        /// 属性名称： Cost
        /// 内容摘要： DB列名：Cost[]
        ///            DB类型：float
        /// </summary>
        public double Cost
        {
            get
            {
                return m_Cost;
            }
            set
            {
                if (m_Cost as object == null || !m_Cost.Equals(value))
                {
                    m_Cost = value;
                    MarkUpdated();
                }
            }
        }
        #endregion

        #region Website属性
        private string m_Website = String.Empty;
        /// <summary>
        /// 属性名称： Website
        /// 内容摘要： DB列名：Website[]
        ///            DB类型：nvarchar(50)
        /// </summary>
        public string Website
        {
            get
            {
                return m_Website;
            }
            set
            {
                if (m_Website as object == null || !m_Website.Equals(value))
                {
                    m_Website = value;
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
        ///            DB类型：nvarchar(200)
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

        #region Descr属性
        private string m_Descr = String.Empty;
        /// <summary>
        /// 属性名称： Descr
        /// 内容摘要： DB列名：Descr[]
        ///            DB类型：text
        /// </summary>
        public string Descr
        {
            get
            {
                return m_Descr;
            }
            set
            {
                if (m_Descr as object == null || !m_Descr.Equals(value))
                {
                    m_Descr = value;
                    MarkUpdated();
                }
            }
        }
        #endregion

        #region Hoteltype属性
        private string m_Hoteltype = String.Empty;
        /// <summary>
        /// 属性名称： Hoteltype
        /// 内容摘要： DB列名：HotelType[]
        ///            DB类型：nvarchar(50)
        /// </summary>
        public string Hoteltype
        {
            get
            {
                return m_Hoteltype;
            }
            set
            {
                if (m_Hoteltype as object == null || !m_Hoteltype.Equals(value))
                {
                    m_Hoteltype = value;
                    MarkUpdated();
                }
            }
        }
        #endregion

        #region Installationsstr属性
        private string m_Installationsstr = String.Empty;
        /// <summary>
        /// 属性名称： Installationsstr
        /// 内容摘要： DB列名：installationsStr[]
        ///            DB类型：nvarchar(255)
        /// </summary>
        public string Installationsstr
        {
            get
            {
                return m_Installationsstr;
            }
            set
            {
                if (m_Installationsstr as object == null || !m_Installationsstr.Equals(value))
                {
                    m_Installationsstr = value;
                    MarkUpdated();
                }
            }
        }
        #endregion

        #region Installationsval属性
        private int m_Installationsval = 0;
        /// <summary>
        /// 属性名称： Installationsval
        /// 内容摘要： DB列名：installationsVal[]
        ///            DB类型：int
        /// </summary>
        public int Installationsval
        {
            get
            {
                return m_Installationsval;
            }
            set
            {
                if (m_Installationsval as object == null || !m_Installationsval.Equals(value))
                {
                    m_Installationsval = value;
                    MarkUpdated();
                }
            }
        }
        #endregion

        #region Creator属性
        private string m_Creator = String.Empty;
        /// <summary>
        /// 属性名称： Creator
        /// 内容摘要： DB列名：CREATOR[]
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
        private DateTime m_CreateDate = new DateTime(1900, 1, 1);
        /// <summary>
        /// 属性名称： CreateDate
        /// 内容摘要： DB列名：CREATE_DATE[]
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
        private DateTime m_LasteUpdateDate = new DateTime(1900, 1, 1);
        /// <summary>
        /// 属性名称： LasteUpdateDate
        /// 内容摘要： DB列名：Laste_update_date[]
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

        #region LasteUpdateBy属性
        private string m_LasteUpdateBy = String.Empty;
        /// <summary>
        /// 属性名称： LasteUpdateBy
        /// 内容摘要： DB列名：Laste_update_By[]
        ///            DB类型：nvarchar(50)
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

        #region Qq属性
        private string m_Qq = String.Empty;
        /// <summary>
        /// 属性名称： Qq
        /// 内容摘要： DB列名：QQ[]
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

        #region Aliww属性
        private string m_Aliww = String.Empty;
        /// <summary>
        /// 属性名称： Aliww
        /// 内容摘要： DB列名：aliww[]
        ///            DB类型：nvarchar(50)
        /// </summary>
        public string Aliww
        {
            get
            {
                return m_Aliww;
            }
            set
            {
                if (m_Aliww as object == null || !m_Aliww.Equals(value))
                {
                    m_Aliww = value;
                    MarkUpdated();
                }
            }
        }
        #endregion

        #region Tag属性
        private string m_Tag = String.Empty;
        /// <summary>
        /// 属性名称： Tag
        /// 内容摘要： DB列名：Tag[]
        ///            DB类型：nvarchar(255)
        /// </summary>
        public string Tag
        {
            get
            {
                return m_Tag;
            }
            set
            {
                if (m_Tag as object == null || !m_Tag.Equals(value))
                {
                    m_Tag = value;
                    MarkUpdated();
                }
            }
        }
        #endregion

        #region Map属性
        private string m_Map = String.Empty;
        /// <summary>
        /// 属性名称： Map
        /// 内容摘要： DB列名：Map[]
        ///            DB类型：text
        /// </summary>
        public string Map
        {
            get
            {
                return m_Map;
            }
            set
            {
                if (m_Map as object == null || !m_Map.Equals(value))
                {
                    m_Map = value;
                    MarkUpdated();
                }
            }
        }
        #endregion

        #region Showpr属性
        private int m_Showpr = 0;
        /// <summary>
        /// 属性名称： Showpr
        /// 内容摘要： DB列名：ShowPr[]
        ///            DB类型：int
        /// </summary>
        public int Showpr
        {
            get
            {
                return m_Showpr;
            }
            set
            {
                if (m_Showpr as object == null || !m_Showpr.Equals(value))
                {
                    m_Showpr = value;
                    MarkUpdated();
                }
            }
        }
        #endregion

        #region Mobile属性
        private string m_Mobile = String.Empty;
        /// <summary>
        /// 属性名称： Mobile
        /// 内容摘要： DB列名：Mobile[]
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

        #region Status属性
        private int m_Status = 0;
        /// <summary>
        /// 属性名称： Status
        /// 内容摘要： DB列名：Status[]
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

        #region Maxprice属性
        private double m_Maxprice = 0.0;
        /// <summary>
        /// 属性名称： Maxprice
        /// 内容摘要： DB列名：MaxPrice[]
        ///            DB类型：float
        /// </summary>
        public double Maxprice
        {
            get
            {
                return m_Maxprice;
            }
            set
            {
                if (m_Maxprice as object == null || !m_Maxprice.Equals(value))
                {
                    m_Maxprice = value;
                    MarkUpdated();
                }
            }
        }
        #endregion

        #region Minprice属性
        private double m_Minprice = 0.0;
        /// <summary>
        /// 属性名称： Minprice
        /// 内容摘要： DB列名：MinPrice[]
        ///            DB类型：float
        /// </summary>
        public double Minprice
        {
            get
            {
                return m_Minprice;
            }
            set
            {
                if (m_Minprice as object == null || !m_Minprice.Equals(value))
                {
                    m_Minprice = value;
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

        #region Issendorderemail属性
        private int m_Issendorderemail = 0;
        /// <summary>
        /// 属性名称： Issendorderemail
        /// 内容摘要： DB列名：IsSendOrderEmail[]
        ///            DB类型：int
        /// </summary>
        public int Issendorderemail
        {
            get
            {
                return m_Issendorderemail;
            }
            set
            {
                if (m_Issendorderemail as object == null || !m_Issendorderemail.Equals(value))
                {
                    m_Issendorderemail = value;
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

        #region Reftype属性
        private byte m_Reftype = 0;
        /// <summary>
        /// 属性名称： Reftype
        /// 内容摘要： DB列名：RefType[]
        ///            DB类型：tinyint
        /// </summary>
        public byte Reftype
        {
            get
            {
                return m_Reftype;
            }
            set
            {
                if (m_Reftype as object == null || !m_Reftype.Equals(value))
                {
                    m_Reftype = value;
                    MarkUpdated();
                }
            }
        }
        #endregion

        #region Refhotelid属性
        private int m_Refhotelid = 0;
        /// <summary>
        /// 属性名称： Refhotelid
        /// 内容摘要： DB列名：RefHotelID[]
        ///            DB类型：int
        /// </summary>
        public int Refhotelid
        {
            get
            {
                return m_Refhotelid;
            }
            set
            {
                if (m_Refhotelid as object == null || !m_Refhotelid.Equals(value))
                {
                    m_Refhotelid = value;
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
        static public DataTable CreateDataTable(string tableName, ColumnNameEnum cne)
        {
            DataTable dtResult = new DataTable(tableName);

            if (cne == ColumnNameEnum.DBName)
            {
                dtResult.Columns.Add(new DataColumn("Seqno", typeof(int)));
                dtResult.Columns.Add(new DataColumn("GUID", typeof(string)));
                dtResult.Columns.Add(new DataColumn("Name", typeof(string)));
                dtResult.Columns.Add(new DataColumn("City", typeof(string)));
                dtResult.Columns.Add(new DataColumn("county", typeof(string)));
                dtResult.Columns.Add(new DataColumn("Area", typeof(string)));
                dtResult.Columns.Add(new DataColumn("Address", typeof(string)));
                dtResult.Columns.Add(new DataColumn("Phone", typeof(string)));
                dtResult.Columns.Add(new DataColumn("Line", typeof(string)));
                dtResult.Columns.Add(new DataColumn("biz", typeof(string)));
                dtResult.Columns.Add(new DataColumn("Cost", typeof(double)));
                dtResult.Columns.Add(new DataColumn("Website", typeof(string)));
                dtResult.Columns.Add(new DataColumn("Logo", typeof(string)));
                dtResult.Columns.Add(new DataColumn("Descr", typeof(string)));
                dtResult.Columns.Add(new DataColumn("HotelType", typeof(string)));
                dtResult.Columns.Add(new DataColumn("installationsStr", typeof(string)));
                dtResult.Columns.Add(new DataColumn("installationsVal", typeof(int)));
                dtResult.Columns.Add(new DataColumn("CREATOR", typeof(string)));
                dtResult.Columns.Add(new DataColumn("CREATE_DATE", typeof(DateTime)));
                dtResult.Columns.Add(new DataColumn("Laste_update_date", typeof(DateTime)));
                dtResult.Columns.Add(new DataColumn("Laste_update_By", typeof(string)));
                dtResult.Columns.Add(new DataColumn("QQ", typeof(string)));
                dtResult.Columns.Add(new DataColumn("aliww", typeof(string)));
                dtResult.Columns.Add(new DataColumn("Tag", typeof(string)));
                dtResult.Columns.Add(new DataColumn("Map", typeof(string)));
                dtResult.Columns.Add(new DataColumn("ShowPr", typeof(int)));
                dtResult.Columns.Add(new DataColumn("Mobile", typeof(string)));
                dtResult.Columns.Add(new DataColumn("Status", typeof(int)));
                dtResult.Columns.Add(new DataColumn("MaxPrice", typeof(double)));
                dtResult.Columns.Add(new DataColumn("MinPrice", typeof(double)));
                dtResult.Columns.Add(new DataColumn("ViewTimes", typeof(int)));
                dtResult.Columns.Add(new DataColumn("email", typeof(string)));
                dtResult.Columns.Add(new DataColumn("IsSendOrderEmail", typeof(int)));
                dtResult.Columns.Add(new DataColumn("JingQuCode", typeof(string)));
                dtResult.Columns.Add(new DataColumn("RefType", typeof(bool)));
                dtResult.Columns.Add(new DataColumn("RefHotelID", typeof(int)));
            }
            else if (cne == ColumnNameEnum.PropertyName)
            {
                dtResult.Columns.Add(new DataColumn("Seqno", typeof(int)));
                dtResult.Columns.Add(new DataColumn("Guid", typeof(string)));
                dtResult.Columns.Add(new DataColumn("Name", typeof(string)));
                dtResult.Columns.Add(new DataColumn("City", typeof(string)));
                dtResult.Columns.Add(new DataColumn("County", typeof(string)));
                dtResult.Columns.Add(new DataColumn("Area", typeof(string)));
                dtResult.Columns.Add(new DataColumn("Address", typeof(string)));
                dtResult.Columns.Add(new DataColumn("Phone", typeof(string)));
                dtResult.Columns.Add(new DataColumn("Line", typeof(string)));
                dtResult.Columns.Add(new DataColumn("Biz", typeof(string)));
                dtResult.Columns.Add(new DataColumn("Cost", typeof(double)));
                dtResult.Columns.Add(new DataColumn("Website", typeof(string)));
                dtResult.Columns.Add(new DataColumn("Logo", typeof(string)));
                dtResult.Columns.Add(new DataColumn("Descr", typeof(string)));
                dtResult.Columns.Add(new DataColumn("Hoteltype", typeof(string)));
                dtResult.Columns.Add(new DataColumn("Installationsstr", typeof(string)));
                dtResult.Columns.Add(new DataColumn("Installationsval", typeof(int)));
                dtResult.Columns.Add(new DataColumn("Creator", typeof(string)));
                dtResult.Columns.Add(new DataColumn("CreateDate", typeof(DateTime)));
                dtResult.Columns.Add(new DataColumn("LasteUpdateDate", typeof(DateTime)));
                dtResult.Columns.Add(new DataColumn("LasteUpdateBy", typeof(string)));
                dtResult.Columns.Add(new DataColumn("Qq", typeof(string)));
                dtResult.Columns.Add(new DataColumn("Aliww", typeof(string)));
                dtResult.Columns.Add(new DataColumn("Tag", typeof(string)));
                dtResult.Columns.Add(new DataColumn("Map", typeof(string)));
                dtResult.Columns.Add(new DataColumn("Showpr", typeof(int)));
                dtResult.Columns.Add(new DataColumn("Mobile", typeof(string)));
                dtResult.Columns.Add(new DataColumn("Status", typeof(int)));
                dtResult.Columns.Add(new DataColumn("Maxprice", typeof(double)));
                dtResult.Columns.Add(new DataColumn("Minprice", typeof(double)));
                dtResult.Columns.Add(new DataColumn("Viewtimes", typeof(int)));
                dtResult.Columns.Add(new DataColumn("Email", typeof(string)));
                dtResult.Columns.Add(new DataColumn("Issendorderemail", typeof(int)));
                dtResult.Columns.Add(new DataColumn("Jingqucode", typeof(string)));
                dtResult.Columns.Add(new DataColumn("Reftype", typeof(bool)));
                dtResult.Columns.Add(new DataColumn("Refhotelid", typeof(int)));
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
            return CreateDataTable(null, cne);
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
        public void FillDataRow(DataRow dr, ColumnNameEnum cne)
        {
            if (dr == null)
            {
                throw new ArgumentNullException("dr");
            }
            if (ColumnNameEnum.DBName == cne)
            {
                dr["Seqno"] = this.Seqno;
                dr["GUID"] = this.Guid;
                dr["Name"] = this.Name;
                dr["City"] = this.City;
                dr["county"] = this.County;
                dr["Area"] = this.Area;
                dr["Address"] = this.Address;
                dr["Phone"] = this.Phone;
                dr["Line"] = this.Line;
                dr["biz"] = this.Biz;
                dr["Cost"] = this.Cost;
                dr["Website"] = this.Website;
                dr["Logo"] = this.Logo;
                dr["Descr"] = this.Descr;
                dr["HotelType"] = this.Hoteltype;
                dr["installationsStr"] = this.Installationsstr;
                dr["installationsVal"] = this.Installationsval;
                dr["CREATOR"] = this.Creator;
                dr["CREATE_DATE"] = this.CreateDate;
                dr["Laste_update_date"] = this.LasteUpdateDate;
                dr["Laste_update_By"] = this.LasteUpdateBy;
                dr["QQ"] = this.Qq;
                dr["aliww"] = this.Aliww;
                dr["Tag"] = this.Tag;
                dr["Map"] = this.Map;
                dr["ShowPr"] = this.Showpr;
                dr["Mobile"] = this.Mobile;
                dr["Status"] = this.Status;
                dr["MaxPrice"] = this.Maxprice;
                dr["MinPrice"] = this.Minprice;
                dr["ViewTimes"] = this.Viewtimes;
                dr["email"] = this.Email;
                dr["IsSendOrderEmail"] = this.Issendorderemail;
                dr["JingQuCode"] = this.Jingqucode;
                dr["RefType"] = this.Reftype;
                dr["RefHotelID"] = this.Refhotelid;
            }
            else if (ColumnNameEnum.PropertyName == cne)
            {
                dr["Seqno"] = this.Seqno;
                dr["Guid"] = this.Guid;
                dr["Name"] = this.Name;
                dr["City"] = this.City;
                dr["County"] = this.County;
                dr["Area"] = this.Area;
                dr["Address"] = this.Address;
                dr["Phone"] = this.Phone;
                dr["Line"] = this.Line;
                dr["Biz"] = this.Biz;
                dr["Cost"] = this.Cost;
                dr["Website"] = this.Website;
                dr["Logo"] = this.Logo;
                dr["Descr"] = this.Descr;
                dr["Hoteltype"] = this.Hoteltype;
                dr["Installationsstr"] = this.Installationsstr;
                dr["Installationsval"] = this.Installationsval;
                dr["Creator"] = this.Creator;
                dr["CreateDate"] = this.CreateDate;
                dr["LasteUpdateDate"] = this.LasteUpdateDate;
                dr["LasteUpdateBy"] = this.LasteUpdateBy;
                dr["Qq"] = this.Qq;
                dr["Aliww"] = this.Aliww;
                dr["Tag"] = this.Tag;
                dr["Map"] = this.Map;
                dr["Showpr"] = this.Showpr;
                dr["Mobile"] = this.Mobile;
                dr["Status"] = this.Status;
                dr["Maxprice"] = this.Maxprice;
                dr["Minprice"] = this.Minprice;
                dr["Viewtimes"] = this.Viewtimes;
                dr["Email"] = this.Email;
                dr["Issendorderemail"] = this.Issendorderemail;
                dr["Jingqucode"] = this.Jingqucode;
                dr["Reftype"] = this.Reftype;
                dr["Refhotelid"] = this.Refhotelid;
            }
        }

        /// <summary>
        /// 用当前对象值填充DaraRow(默认列名映射为属性名)
        /// </summary>
        /// <param name="dr">由CreateTable生成的DataTable通过NewRow得到的DataRow对象</param>
        public void FillDataRow(DataRow dr)
        {
            this.FillDataRow(dr, ColumnNameEnum.PropertyName);
        }

        /// <summary>
        /// 将DataRow转换成Hotel对象
        /// </summary>
        /// <param name="dr">由CreateTable生成的DataTable通过NewRow得到的DataRow对象</param>
        /// <param name="cne">dr的列名映射方式:DB列名或属性名</param>
        /// <returns>Hotel对象</returns>
        public static Hotel Dr2Obj(DataRow dr, ColumnNameEnum cne)
        {
            if (dr == null)
            {
                throw new ArgumentNullException("dr");
            }
            Hotel obj = new Hotel();
            if (ColumnNameEnum.DBName == cne)
            {
                obj.Seqno = (dr["Seqno"] == Convert.DBNull) ? 0 : (int)Convert.ChangeType(dr["Seqno"], typeof(int));
                obj.Guid = (dr["GUID"] == Convert.DBNull) ? null : (string)Convert.ChangeType(dr["GUID"], typeof(string));
                obj.Name = (dr["Name"] == Convert.DBNull) ? null : (string)Convert.ChangeType(dr["Name"], typeof(string));
                obj.City = (dr["City"] == Convert.DBNull) ? null : (string)Convert.ChangeType(dr["City"], typeof(string));
                obj.County = (dr["county"] == Convert.DBNull) ? null : (string)Convert.ChangeType(dr["county"], typeof(string));
                obj.Area = (dr["Area"] == Convert.DBNull) ? null : (string)Convert.ChangeType(dr["Area"], typeof(string));
                obj.Address = (dr["Address"] == Convert.DBNull) ? null : (string)Convert.ChangeType(dr["Address"], typeof(string));
                obj.Phone = (dr["Phone"] == Convert.DBNull) ? null : (string)Convert.ChangeType(dr["Phone"], typeof(string));
                obj.Line = (dr["Line"] == Convert.DBNull) ? null : (string)Convert.ChangeType(dr["Line"], typeof(string));
                obj.Biz = (dr["biz"] == Convert.DBNull) ? null : (string)Convert.ChangeType(dr["biz"], typeof(string));
                obj.Cost = (dr["Cost"] == Convert.DBNull) ? 0.0 : (double)Convert.ChangeType(dr["Cost"], typeof(double));
                obj.Website = (dr["Website"] == Convert.DBNull) ? null : (string)Convert.ChangeType(dr["Website"], typeof(string));
                obj.Logo = (dr["Logo"] == Convert.DBNull) ? null : (string)Convert.ChangeType(dr["Logo"], typeof(string));
                obj.Descr = (dr["Descr"] == Convert.DBNull) ? null : (string)Convert.ChangeType(dr["Descr"], typeof(string));
                obj.Hoteltype = (dr["HotelType"] == Convert.DBNull) ? null : (string)Convert.ChangeType(dr["HotelType"], typeof(string));
                obj.Installationsstr = (dr["installationsStr"] == Convert.DBNull) ? null : (string)Convert.ChangeType(dr["installationsStr"], typeof(string));
                obj.Installationsval = (dr["installationsVal"] == Convert.DBNull) ? 0 : (int)Convert.ChangeType(dr["installationsVal"], typeof(int));
                obj.Creator = (dr["CREATOR"] == Convert.DBNull) ? null : (string)Convert.ChangeType(dr["CREATOR"], typeof(string));
                obj.CreateDate = (dr["CREATE_DATE"] == Convert.DBNull) ? new DateTime(1900, 1, 1) : (DateTime)Convert.ChangeType(dr["CREATE_DATE"], typeof(DateTime));
                obj.LasteUpdateDate = (dr["Laste_update_date"] == Convert.DBNull) ? new DateTime(1900, 1, 1) : (DateTime)Convert.ChangeType(dr["Laste_update_date"], typeof(DateTime));
                obj.LasteUpdateBy = (dr["Laste_update_By"] == Convert.DBNull) ? null : (string)Convert.ChangeType(dr["Laste_update_By"], typeof(string));
                obj.Qq = (dr["QQ"] == Convert.DBNull) ? null : (string)Convert.ChangeType(dr["QQ"], typeof(string));
                obj.Aliww = (dr["aliww"] == Convert.DBNull) ? null : (string)Convert.ChangeType(dr["aliww"], typeof(string));
                obj.Tag = (dr["Tag"] == Convert.DBNull) ? null : (string)Convert.ChangeType(dr["Tag"], typeof(string));
                obj.Map = (dr["Map"] == Convert.DBNull) ? null : (string)Convert.ChangeType(dr["Map"], typeof(string));
                obj.Showpr = (dr["ShowPr"] == Convert.DBNull) ? 0 : (int)Convert.ChangeType(dr["ShowPr"], typeof(int));
                obj.Mobile = (dr["Mobile"] == Convert.DBNull) ? null : (string)Convert.ChangeType(dr["Mobile"], typeof(string));
                obj.Status = (dr["Status"] == Convert.DBNull) ? 0 : (int)Convert.ChangeType(dr["Status"], typeof(int));
                obj.Maxprice = (dr["MaxPrice"] == Convert.DBNull) ? 0.0 : (double)Convert.ChangeType(dr["MaxPrice"], typeof(double));
                obj.Minprice = (dr["MinPrice"] == Convert.DBNull) ? 0.0 : (double)Convert.ChangeType(dr["MinPrice"], typeof(double));
                obj.Viewtimes = (dr["ViewTimes"] == Convert.DBNull) ? 0 : (int)Convert.ChangeType(dr["ViewTimes"], typeof(int));
                obj.Email = (dr["email"] == Convert.DBNull) ? null : (string)Convert.ChangeType(dr["email"], typeof(string));
                obj.Issendorderemail = (dr["IsSendOrderEmail"] == Convert.DBNull) ? 0 : (int)Convert.ChangeType(dr["IsSendOrderEmail"], typeof(int));
                obj.Jingqucode = (dr["JingQuCode"] == Convert.DBNull) ? null : (string)Convert.ChangeType(dr["JingQuCode"], typeof(string));
                obj.Reftype = (dr["RefType"] == Convert.DBNull) ? byte.Parse("0") : Convert.ToByte(dr["RefType"]);
                obj.Refhotelid = (dr["RefHotelID"] == Convert.DBNull) ? 0 : (int)Convert.ChangeType(dr["RefHotelID"], typeof(int));
            }
            else if (ColumnNameEnum.PropertyName == cne)
            {
                obj.Seqno = (dr["Seqno"] == Convert.DBNull) ? 0 : (int)Convert.ChangeType(dr["Seqno"], typeof(int));
                obj.Guid = (dr["Guid"] == Convert.DBNull) ? null : (string)Convert.ChangeType(dr["Guid"], typeof(string));
                obj.Name = (dr["Name"] == Convert.DBNull) ? null : (string)Convert.ChangeType(dr["Name"], typeof(string));
                obj.City = (dr["City"] == Convert.DBNull) ? null : (string)Convert.ChangeType(dr["City"], typeof(string));
                obj.County = (dr["County"] == Convert.DBNull) ? null : (string)Convert.ChangeType(dr["County"], typeof(string));
                obj.Area = (dr["Area"] == Convert.DBNull) ? null : (string)Convert.ChangeType(dr["Area"], typeof(string));
                obj.Address = (dr["Address"] == Convert.DBNull) ? null : (string)Convert.ChangeType(dr["Address"], typeof(string));
                obj.Phone = (dr["Phone"] == Convert.DBNull) ? null : (string)Convert.ChangeType(dr["Phone"], typeof(string));
                obj.Line = (dr["Line"] == Convert.DBNull) ? null : (string)Convert.ChangeType(dr["Line"], typeof(string));
                obj.Biz = (dr["Biz"] == Convert.DBNull) ? null : (string)Convert.ChangeType(dr["Biz"], typeof(string));
                obj.Cost = (dr["Cost"] == Convert.DBNull) ? 0.0 : (double)Convert.ChangeType(dr["Cost"], typeof(double));
                obj.Website = (dr["Website"] == Convert.DBNull) ? null : (string)Convert.ChangeType(dr["Website"], typeof(string));
                obj.Logo = (dr["Logo"] == Convert.DBNull) ? null : (string)Convert.ChangeType(dr["Logo"], typeof(string));
                obj.Descr = (dr["Descr"] == Convert.DBNull) ? null : (string)Convert.ChangeType(dr["Descr"], typeof(string));
                obj.Hoteltype = (dr["Hoteltype"] == Convert.DBNull) ? null : (string)Convert.ChangeType(dr["Hoteltype"], typeof(string));
                obj.Installationsstr = (dr["Installationsstr"] == Convert.DBNull) ? null : (string)Convert.ChangeType(dr["Installationsstr"], typeof(string));
                obj.Installationsval = (dr["Installationsval"] == Convert.DBNull) ? 0 : (int)Convert.ChangeType(dr["Installationsval"], typeof(int));
                obj.Creator = (dr["Creator"] == Convert.DBNull) ? null : (string)Convert.ChangeType(dr["Creator"], typeof(string));
                obj.CreateDate = (dr["CreateDate"] == Convert.DBNull) ? new DateTime(1900, 1, 1) : (DateTime)Convert.ChangeType(dr["CreateDate"], typeof(DateTime));
                obj.LasteUpdateDate = (dr["LasteUpdateDate"] == Convert.DBNull) ? new DateTime(1900, 1, 1) : (DateTime)Convert.ChangeType(dr["LasteUpdateDate"], typeof(DateTime));
                obj.LasteUpdateBy = (dr["LasteUpdateBy"] == Convert.DBNull) ? null : (string)Convert.ChangeType(dr["LasteUpdateBy"], typeof(string));
                obj.Qq = (dr["Qq"] == Convert.DBNull) ? null : (string)Convert.ChangeType(dr["Qq"], typeof(string));
                obj.Aliww = (dr["Aliww"] == Convert.DBNull) ? null : (string)Convert.ChangeType(dr["Aliww"], typeof(string));
                obj.Tag = (dr["Tag"] == Convert.DBNull) ? null : (string)Convert.ChangeType(dr["Tag"], typeof(string));
                obj.Map = (dr["Map"] == Convert.DBNull) ? null : (string)Convert.ChangeType(dr["Map"], typeof(string));
                obj.Showpr = (dr["Showpr"] == Convert.DBNull) ? 0 : (int)Convert.ChangeType(dr["Showpr"], typeof(int));
                obj.Mobile = (dr["Mobile"] == Convert.DBNull) ? null : (string)Convert.ChangeType(dr["Mobile"], typeof(string));
                obj.Status = (dr["Status"] == Convert.DBNull) ? 0 : (int)Convert.ChangeType(dr["Status"], typeof(int));
                obj.Maxprice = (dr["Maxprice"] == Convert.DBNull) ? 0.0 : (double)Convert.ChangeType(dr["Maxprice"], typeof(double));
                obj.Minprice = (dr["Minprice"] == Convert.DBNull) ? 0.0 : (double)Convert.ChangeType(dr["Minprice"], typeof(double));
                obj.Viewtimes = (dr["Viewtimes"] == Convert.DBNull) ? 0 : (int)Convert.ChangeType(dr["Viewtimes"], typeof(int));
                obj.Email = (dr["Email"] == Convert.DBNull) ? null : (string)Convert.ChangeType(dr["Email"], typeof(string));
                obj.Issendorderemail = (dr["Issendorderemail"] == Convert.DBNull) ? 0 : (int)Convert.ChangeType(dr["Issendorderemail"], typeof(int));
                obj.Jingqucode = (dr["Jingqucode"] == Convert.DBNull) ? null : (string)Convert.ChangeType(dr["Jingqucode"], typeof(string));
                obj.Reftype = (dr["Reftype"] == Convert.DBNull) ? byte.Parse("0") : Convert.ToByte(dr["RefType"]);
                obj.Refhotelid = (dr["Refhotelid"] == Convert.DBNull) ? 0 : (int)Convert.ChangeType(dr["Refhotelid"], typeof(int));
            }

            return obj;
        }

        /// <summary>
        /// 将DataRow转换成Hotel对象(默认列名映射为属性名)
        /// </summary>
        /// <returns>Hotel对象</returns>
        public static Hotel Dr2Obj(DataRow dr)
        {
            return Dr2Obj(dr, ColumnNameEnum.DBName);
        }

        /// <summary>
        /// 将DataTabe转换成的Hotel对象集合
        /// </summary>
        /// <param name="dt">由CreateTable生成的DataTable</param>
        /// <param name="cne">dt的列名映射方式:DB列名或属性名</param>
        /// <returns>Hotel对象的集合</returns>
        public static List<Hotel> Dt2Objs(DataTable dt, ColumnNameEnum cne)
        {
            if (dt == null)
            {
                throw new ArgumentNullException("dt");
            }


            List<Hotel> alResult = new List<Hotel>();

            foreach (DataRow dr in dt.Rows)
            {
                alResult.Add(Dr2Obj(dr, cne));
            }

            return alResult;
        }

        /// <summary>
        /// 将DataTabe转换成的Hotel对象集合(默认列名映射为属性名)
        /// </summary>
        /// <param name="dt">由CreateTable生成的DataTable</param>
        /// <returns>Hotel对象的集合</returns>
        public static List<Hotel> Dt2Objs(DataTable dt)
        {
            return Dt2Objs(dt, ColumnNameEnum.DBName);
        }

        /// <summary>
        /// 用objs的Hotel对象集合填充DataTable
        /// </summary>
        /// <param name="dt">由CreateTable生成的DataTable</param>
        /// <param name="objs">Hotel对象集合</param>
        /// <param name="cne">dt的列名映射方式:DB列名或属性名</param>
        public static void FillDataTable(DataTable dt, IList objs, ColumnNameEnum cne)
        {
            if (dt == null)
            {
                throw new ArgumentNullException("dt");
            }
            if (objs == null)
            {
                throw new ArgumentNullException("objs");
            }

            foreach (Hotel obj in objs)
            {
                DataRow dr = dt.NewRow();
                obj.FillDataRow(dr, cne);
                dt.Rows.Add(dr);
            }
        }

        /// <summary>
        /// 用objs的Hotel对象集合填充DataTable(默认列名映射为属性名)
        /// </summary>
        /// <param name="dt">由CreateTable生成的DataTable</param>
        /// <param name="objs">Hotel对象集合</param>
        public static void FillDataTable(DataTable dt, IList objs)
        {
            FillDataTable(dt, objs, ColumnNameEnum.PropertyName);
        }
        #endregion

        /// <summary>
        /// 取消编辑,恢复到上次有效调用BeginEdit前的状态,并清空保留值
        /// </summary>
        public override void CancelEdit()
        {
            Hotel old = this.OldValue as Hotel;
            if (old != null)
            {
                this.Seqno = old.Seqno;
                this.Guid = old.Guid;
                this.Name = old.Name;
                this.City = old.City;
                this.County = old.County;
                this.Area = old.Area;
                this.Address = old.Address;
                this.Phone = old.Phone;
                this.Line = old.Line;
                this.Biz = old.Biz;
                this.Cost = old.Cost;
                this.Website = old.Website;
                this.Logo = old.Logo;
                this.Descr = old.Descr;
                this.Hoteltype = old.Hoteltype;
                this.Installationsstr = old.Installationsstr;
                this.Installationsval = old.Installationsval;
                this.Creator = old.Creator;
                this.CreateDate = old.CreateDate;
                this.LasteUpdateDate = old.LasteUpdateDate;
                this.LasteUpdateBy = old.LasteUpdateBy;
                this.Qq = old.Qq;
                this.Aliww = old.Aliww;
                this.Tag = old.Tag;
                this.Map = old.Map;
                this.Showpr = old.Showpr;
                this.Mobile = old.Mobile;
                this.Status = old.Status;
                this.Maxprice = old.Maxprice;
                this.Minprice = old.Minprice;
                this.Viewtimes = old.Viewtimes;
                this.Email = old.Email;
                this.Issendorderemail = old.Issendorderemail;
                this.Jingqucode = old.Jingqucode;
                this.Reftype = old.Reftype;
                this.Refhotelid = old.Refhotelid;
                this.OldValue = null;
            }
        }




        #region Hotel实体的内部Key类
        /// <summary>
        /// Hotel实体的Key类
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
                m_Seqno = pSeqno;

            }
        }
        #endregion
        /// <summary>
        /// 得到实体Hotel的PK
        /// </summary>
        public Key GetKey()
        {
            return new Key(Seqno);
        }


        #endregion
    }
}
