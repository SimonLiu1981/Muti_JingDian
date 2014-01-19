using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using dx177.Business;
using System.Data;
using System.Xml;
using dx177.FrameWork;
using dx177.WebUI.admin;
using dx177.Model;
using dx177.Business.Bus;

namespace dx177.WebUI.Admin.Frame
{
    public partial class FrameTop : BasePage
    {
        protected DataTable dt_TopMenu;
        protected DataTable dt_MenuItem;
        protected DataSet ds_NavMenu;
        protected string sCurrentMenuID;
        protected string currentLocation;
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                if (AppContext.CurrentMgtJingQuCode == string.Empty)
                {
                    currentLocation = "系统管理页面";
                }
                else
                {

                    currentLocation = JingqusBLL.GetInstance().GetEntityByJingqucode(AppContext.CurrentMgtJingQuCode).Jingquname + "景区-管理页面";
                }
                ReadXMLMenu();
                BindNemu();
            }
        }


        private void ReadXMLMenu()
        {

            ds_NavMenu = new DataSet();
            dt_TopMenu = new DataTable();
            dt_MenuItem = new DataTable();

            DataRow dr_TopMenu;
            dt_TopMenu.Columns.Add(new DataColumn("ID", typeof(System.String)));
            dt_TopMenu.Columns.Add(new DataColumn("NavigateUrl", typeof(System.String)));
            dt_TopMenu.Columns.Add(new DataColumn("Text", typeof(System.String)));
            dt_TopMenu.Columns.Add(new DataColumn("AdminType", typeof(System.String)));
            dt_TopMenu.Columns.Add(new DataColumn("RigthDepId", typeof(System.String)));
            dt_TopMenu.Columns.Add(new DataColumn("Show", typeof(System.Boolean)));
            dt_TopMenu.Columns.Add(new DataColumn("BackGroupClass", typeof(System.String)));
            XmlDocument xd = new XmlDocument();
            if (AppContext.CurrentMgtJingQuCode == string.Empty)
            {
                if (AppContext.CurrentResuser.Usertype == ResUserType.SupperAdmin.ToString("d"))
                {
                    xd.Load(Server.MapPath("AdminNavMenu.xml"));
                }
                else
                {
                    Logout();
                }
            }
            else
            {
                xd.Load(Server.MapPath("NavMenu.xml"));
            }
            
            XmlNodeList nls = xd.SelectNodes("//NavMenu//TopMenu");
            foreach (XmlNode tmp in nls)
            {
                dr_TopMenu = dt_TopMenu.NewRow();
                dr_TopMenu["Text"] = tmp.Attributes["Text"].Value.ToString();
                dr_TopMenu["ID"] = tmp.Attributes["ID"].Value.ToString();
                dr_TopMenu["BackGroupClass"] = tmp.Attributes["BackGroupClass"].Value.ToString();
                dr_TopMenu["NavigateUrl"] = UrlUtility.AddOrReplaceParam(tmp.Attributes["NavigateUrl"].Value.ToString(),
                                "topID", tmp.Attributes["ID"].Value.ToString(), true);

                if (dr_TopMenu["NavigateUrl"].ToString().StartsWith("~/"))
                {
                    dr_TopMenu["NavigateUrl"] = this.Page.ResolveUrl(dr_TopMenu["NavigateUrl"].ToString());
                }
                if (tmp.Attributes["AdminType"] != null)
                {
                    dr_TopMenu["AdminType"] = tmp.Attributes["AdminType"].Value.ToString();
                }

                if (tmp.Attributes["RigthDepId"] != null)
                {
                    dr_TopMenu["RigthDepId"] = tmp.Attributes["RigthDepId"].Value.ToString();
                }
                //权限判断
                bool hasRight = true;

                //需要判断
                //if (AppContext.Userinfo.Depid != null
                //    && AppContext.Userinfo.UserType == 0)
                //{
                //    if (dr_TopMenu["RigthDepId"] != null && dr_TopMenu["RigthDepId"].ToString() != string.Empty)
                //    {
                //        if (dr_TopMenu["RigthDepId"].ToString().IndexOf(AppContext.Userinfo.Depid) != -1)
                //        {
                //            hasRight &= true;
                //        }
                //        else
                //        {
                //            hasRight &= false;
                //        }
                //    }
                //}
                //需要判断
                
                    if (dr_TopMenu["AdminType"] != null
                         && dr_TopMenu["AdminType"].ToString() != string.Empty)
                    {
                        if (dr_TopMenu["AdminType"].ToString() == "1")
                        {
                            hasRight &= false;
                        }
                    }
                

                dr_TopMenu["Show"] = hasRight;
                dt_TopMenu.Rows.Add(dr_TopMenu);

                if (tmp.Attributes["Defualt"] != null &&
                    tmp.Attributes["Defualt"].Value.ToLower().Trim() == "true")
                {
                    sCurrentMenuID = tmp.Attributes["ID"].Value.ToString();
                }
            }

        }

        protected string IsDisplayed(Object aa)
        {
            return ((bool)aa) ? "" : "none";

        }


        private void BindNemu()
        {

            this.NavMenu_List.DataSource = dt_TopMenu;
            NavMenu_List.DataBind();
            this.rpBack.DataSource = dt_TopMenu;
            rpBack.DataBind();

        }

        protected void NavMenu_List_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            //Only consume the items in the parent datalist 
            //pertinent to nesting
            if (e.Item.ItemType == ListItemType.Item ||
                e.Item.ItemType == ListItemType.AlternatingItem)
            {
            }
        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            AppContext.CurrentResuser = null;
            
            Response.Write("<SCRIPT> top.location.href='../login.aspx'; </SCRIPT>");

        }




    }
}
