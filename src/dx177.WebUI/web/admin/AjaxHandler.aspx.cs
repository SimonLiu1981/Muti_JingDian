using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using dx177.FrameWork;
using dx177.Model;
using dx177.Model.Bus;
using dx177.Business.Bus;
using System.Web.Security;

namespace dx177.WebUI.web.admin
{
    public partial class AjaxHandler : System.Web.UI.Page
    {
        public string JsonString = string.Empty;

        public string MethodName
        {
            get
            { 
                return Request.QueryString["MethodName"];
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            switch (MethodName)
            {
                case "GetResUerInfo"://获得当前登录用户的信息
                    JsonString = CommonUnitl.JavaScriptSerializerString(GetResUerInfo());
                    break;

                case "Login"://登录用户
                    JsonString = CommonUnitl.JavaScriptSerializerString(UserLogin());
                    break;

                case "RegeditUser":
                    JsonString = CommonUnitl.JavaScriptSerializerString(RegeditUser());
                    break;

                case "RegeditUser_DualisticJudge":
                    JsonString = CommonUnitl.JavaScriptSerializerString(RegeditUser_DualisticJudge());
                    break;
            }
        }
        /// <summary>
        /// 判断用户是否存在
        /// </summary>
        /// <returns></returns>
        private ResUserAjaxResult RegeditUser_DualisticJudge()
        {
            ResUserAjaxResult reslut = new ResUserAjaxResult();
            string email = HttpUtility.UrlDecode(Request.QueryString["email"]);
            reslut.SesstionTimeOut = AppContext.CurrentResuser == null;
            Resuser user = ResuserBLL.GetInstance().GetResuserByUserName(email);
            if (user == null)
            {
                reslut.Result = new { Exists = false, Message = "用户名不存在" };
            }
            else
            {
                reslut.Result = new { Exists = true, Message = "用户名已经被注册" };
            }

            return reslut;
        }
        /// <summary>
        /// 注册用户
        /// </summary>
        /// <returns></returns>
        private ResUserAjaxResult RegeditUser()
        {
            ResUserAjaxResult reslut = new ResUserAjaxResult();
            
            string email = HttpUtility.UrlDecode(Request.QueryString["email"]);
            string pwd = HttpUtility.UrlDecode(Request.QueryString["pwd"]);
            string userType = HttpUtility.UrlDecode(Request.QueryString["userType"]);
            string jingquCode = HttpUtility.UrlDecode(Request.QueryString["jingquCode"]);
            Resuser user = new Resuser();
            user.Guid = System.Guid.NewGuid().ToString();
            user.Username = email;//登录帐号
            user.Email = email;
            user.Pwd = FormsAuthentication.HashPasswordForStoringInConfigFile(pwd, "MD5");
            user.Usertype = userType;
            user.CreateDate = DateTime.Now;
            user.Jingqucode = jingquCode;
            AppContext.CurrentResuser = user;
            reslut.SesstionTimeOut = AppContext.CurrentResuser == null;            
            ResuserBLL.GetInstance().Submit(user);
            HttpCookie c = new HttpCookie(CookieName.CurrentAdminJingQuCode.ToString(), user.Jingqucode);
            HttpCookie c1 = new HttpCookie(CookieName.CurrentAdminUserName.ToString(), user.Username);
            Response.AppendCookie(c);
            Response.AppendCookie(c1);
            reslut.Result = new { User = user, NavigationUrl = GetDefaultUrl(user) };
            return reslut;
        }
        
        /// <summary>
        /// 用户登录
        /// </summary>
        /// <returns></returns>
        private ResUserAjaxResult UserLogin()
        {
            ResUserAjaxResult reslut = new ResUserAjaxResult();
            reslut.SesstionTimeOut = AppContext.CurrentResuser == null;

            string username = HttpUtility.UrlDecode(Request.QueryString["username"]);
            string password = HttpUtility.UrlDecode(Request.QueryString["password"]);

            Resuser user = ResuserBLL.GetInstance().GetResuserByUserName(username);
            if (user == null)
            {
                reslut.Result = new { Result = 0, Message = "用户名不存在" };
            }
            else
            {
                if (user.Pwd == FormsAuthentication.HashPasswordForStoringInConfigFile(password, "MD5"))
                {
                    AppContext.CurrentResuser = user;
                 
                    reslut.SesstionTimeOut = false;
                    string url = GetDefaultUrl(user);

                    HttpCookie c = new HttpCookie(CookieName.CurrentAdminJingQuCode.ToString(), user.Jingqucode);
                    HttpCookie c1 = new HttpCookie(CookieName.CurrentAdminUserName.ToString(), user.Username);
                    Response.AppendCookie(c);
                    Response.AppendCookie(c1);
                    reslut.Result = new { Result = 1, Message = "登录成功！", User = user, NavigationUrl = url };
                }
                else
                {
                    HttpCookie c = new HttpCookie(CookieName.CurrentAdminJingQuCode.ToString(), string.Empty);
                    HttpCookie c1 = new HttpCookie(CookieName.CurrentAdminUserName.ToString(), string.Empty);
                    Response.AppendCookie(c);
                    Response.AppendCookie(c1);
                    reslut.Result = new { Result = 2, Message = "密码输入不正确！" };
                }
            }
            return reslut;
        }

        private static string GetDefaultUrl(Resuser user)
        {
            if (user == null) return string.Empty;

            string url = "/member-orders.aspx";//跳传默认页面'
            if (user.Usertype == ResUserType.OrdinaryUser.ToString("d"))
            {
                url = "/member-orders.aspx";//跳传默认页面'
            }
            else if (user.Usertype == ResUserType.HireCarUser.ToString("d"))
            {
                url = "/member-hirecarlist.aspx";//跳传默认页面'
            }
            else if (user.Usertype == ResUserType.HotelUser.ToString("d"))
            {
                url = "/member-hotel.aspx";//跳传默认页面'
            }
            else if (user.Usertype == ResUserType.RestaurantUser.ToString("d"))
            {
                url = "/member-Restaurantlist.aspx";//跳传默认页面'
            }
            else if (user.Usertype == ResUserType.WapUser.ToString("d"))
            {
                url = "/MyOrderList_9_1.aspx";//wap页面'
            }
            return url;
        }
        /// <summary>
        /// 返回用户登录信息
        /// </summary>
        /// <returns></returns>
        private ResUserAjaxResult GetResUerInfo()
        {
            ResUserAjaxResult reslut = new ResUserAjaxResult();
            
            reslut.SesstionTimeOut = AppContext.CurrentResuser == null;
            string url = GetDefaultUrl(AppContext.CurrentResuser);
            reslut.Result = new { User = AppContext.CurrentResuser, NavigationUrl = url };
            return reslut;
        }
    }
    /// <summary>
    /// 注册用户信息返回 
    /// </summary>
    public class ResUserAjaxResult
    {
        private bool _SesstionTimeOut = false;
        public bool SesstionTimeOut
        {
            get
            {
                return _SesstionTimeOut;
            }
            set
            {
                _SesstionTimeOut = value;
            }
        }

        private object _Result = null;
        public object Result
        {
            get
            {
                return _Result;
            }
            set
            {
                _Result = value;
            }
        }
    }
}

