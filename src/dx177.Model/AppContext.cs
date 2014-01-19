using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using dx177.Model.Bus;
using System.Configuration;
using dx177.FrameWork;
using System.Web;

namespace dx177.Model
{
    public class AppContext
    {

        private static volatile AppContext m_instance = null;

        /// <summary>
        /// 取得 AppContext 对象的单键实例
        /// </summary>
        /// <remarks>  
        /// 实现流程： 
        ///        1.锁定类  
        ///        2.获取对象实例  
        ///        3.结束 
        /// </remarks> 
        /// <returns>返回一个已经存在的实体</returns>
        public static AppContext GetInstance()
        {
            // 通用的必要代码 iBatisNet双校检机制,如果实例不存在 
            if (m_instance == null)
            {
                lock (typeof(AppContext))
                {
                    // 如果实例不存在 
                    if (m_instance == null)
                    {
                        // 创建一个的实例 
                        m_instance = new AppContext();
                    }
                }
            }

            // 返回业务逻辑对象
            return m_instance;
        }


        public int mLCID = 2052;

        /// <summary> 
        /// 语言标识
        /// </summary>
        public static int LCID
        {
            get
            {
                // 修改日志1 开始
                int ID = Convert.ToInt16(ConfigurationSettings.AppSettings["MLM.DefaultLangID"]);
                // 修改日志1 结束
                string key = SessionName.LCID.ToString();
                try
                {
                    if (HttpContext.Current.Session[key] != null)
                    {
                        ID = (int)HttpContext.Current.Session[key];
                    }
                }
                catch
                {
                }
                return ID;
            }
            set
            {
                //判断session是否为空
                if (HttpContext.Current.Session != null)
                {
                    string key = SessionName.LCID.ToString();
                    HttpContext.Current.Session[key] = value;
                }
                else
                {
                    AppContext.GetInstance().mLCID = value;
                }
            }
        }

        public static bool IsEnglish
        {
            get { return LCID != 2052; }
        }


        /// <summary>
        /// 返回中英文
        /// </summary>
        /// <param name="CnString"></param>
        /// <param name="EnString"></param>
        /// <returns></returns>
        public static string CnEn(string CnString, string EnString)
        {
            if (IsEnglish)
            {
                return EnString;
            }
            return CnString;
        }

        /// <summary>
        /// 当前前台登录用户
        /// </summary>
        public static Resuser CurrentResuser
        {
            get
            {
                Resuser o = null;
                string key = SessionName.ResUser.ToString();
                try
                {
                    if (HttpContext.Current.Session[key] != null)
                    {
                        o = (Resuser)HttpContext.Current.Session[key];
                    }
                }
                catch
                {
                }
                return o;
            }
            set
            {
                string key = SessionName.ResUser.ToString();
                HttpContext.Current.Session[key] = value;                
            }
        }

        public static string CurrentMgtJingQuCode
        {
            get
            {
                string o = string.Empty;
                string key = SessionName.CurrentMgtJingQuCode.ToString();
                try
                {
                    if (HttpContext.Current.Session[key] != null)
                    {
                        o = (string)HttpContext.Current.Session[key];
                    }
                }
                catch
                {
                }
                return o;
            }
            set
            {
                string key = SessionName.CurrentMgtJingQuCode.ToString();
                HttpContext.Current.Session[key] = value;
            }
        }


        /// <summary>
        /// 当前前台登录用户
        /// </summary>
        public static string JingQuCode
        {
            get
            {
                if (!string.IsNullOrEmpty(HttpContext.Current.Request["jingqucode"]))
                {
                    return HttpContext.Current.Request["jingqucode"];
                }               
                return string.Empty;
            }
        }

        public static Jingqus CurrentJingqus
        {
            get
            {                
                Jingqus o = null;
                string key = SessionName.JingQu.ToString();
                try
                {
                    if (HttpContext.Current.Session[key] != null)
                    {
                        o = (Jingqus)HttpContext.Current.Session[key];
                    }                    
                }
                catch
                {
                }
                return o;
            }
            set
            {
                string key = SessionName.JingQu.ToString();
                HttpContext.Current.Session[key] = value;
            }
             
        }


        ///// <summary> 
        ///// 当前后台管理员用户
        ///// </summary>
        //public static Administrator CurrentAdministrator
        //{
        //    get
        //    {
        //        Administrator o = null;
        //        string key = SessionName.Administrator.ToString();
        //        try
        //        {
        //            if (HttpContext.Current.Session[key] != null)
        //            {
        //                o = (Administrator)HttpContext.Current.Session[key];
        //            }
        //        }
        //        catch
        //        {
        //        }
        //        return o;
        //    }
        //    set
        //    {
        //        string key = SessionName.Administrator.ToString();
        //        HttpContext.Current.Session[key] = value;
        //        //文件路径
              

        //    }
        //}


        


        private static string _ApplicationPath = "";

        /// <summary>
        /// 站点的相对路径
        /// </summary>
        public static string ApplicationPath
        {
            get
            {
                if (_ApplicationPath == "")
                {
                    _ApplicationPath = System.Web.HttpContext.Current.Request.ApplicationPath;
                }
                return _ApplicationPath;
            }
        }


 
        public static string  GetCurrentName()
        {

            return AppContext.CurrentResuser.Username ;
        }

        static  Encoding _CurrentEncoding = Encoding.GetEncoding("gb2312");
        public static Encoding CurrentEncoding
        {
            get
            {
                return _CurrentEncoding;
            }
            set
            {
                _CurrentEncoding = value;
            }
        }

        public static string  GetCurentUserName()
        {

            return string.Empty;
        }

        public static string Admin = "admin";

    }
}
