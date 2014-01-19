using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Xml;
using dx177.Model;

namespace dx177.WebUI.web.admin
{
    public partial class UCLeftMenu : System.Web.UI.UserControl
    {
        public string CurrentMenuID = "";

        protected DataTable dt_2Menu;
        protected DataTable dt_MenuItem;
        protected DataSet ds_NavMenu;
        protected string sCurrentMenuID;


        protected void Page_Load(object sender, EventArgs e)
        {
            sCurrentMenuID = "1";
            ReadXMLMenu();
            BindDate_TopMenu();

        }

        public void ReadXMLMenu()
        {
            //读菜单XML文件，分别放入到两张表中。

            ds_NavMenu = new DataSet();
            dt_2Menu = new DataTable();
            dt_MenuItem = new DataTable();

            dt_2Menu.Columns.Add(new DataColumn("ID", typeof(System.String)));
            dt_2Menu.Columns.Add(new DataColumn("Text", typeof(System.String)));
            dt_2Menu.Columns.Add(new DataColumn("AdminType", typeof(System.String)));
            dt_2Menu.Columns.Add(new DataColumn("Show", typeof(System.Boolean)));


            dt_MenuItem.Columns.Add(new DataColumn("ParentID", typeof(System.String)));
            dt_MenuItem.Columns.Add(new DataColumn("Text", typeof(System.String)));
            dt_MenuItem.Columns.Add(new DataColumn("ImageUrl", typeof(System.String)));
            dt_MenuItem.Columns.Add(new DataColumn("NavigateUrl", typeof(System.String)));
            dt_MenuItem.Columns.Add(new DataColumn("AdminType", typeof(System.String)));
            dt_MenuItem.Columns.Add(new DataColumn("Show", typeof(System.Boolean)));
            dt_MenuItem.Columns.Add(new DataColumn("ID", typeof(System.String)));


            XmlDocument xd = new XmlDocument();
            xd.Load(Server.MapPath("~/web/admin/xml/navigationMenu.xml"));
            XmlNode nls = xd.SelectSingleNode(string.Format("//NavMenu//TopMenu[@ID='{0}']",  AppContext.CurrentResuser.Usertype));
            NodeOperate(nls);

            ds_NavMenu.Tables.Add(dt_2Menu);
            ds_NavMenu.Tables.Add(dt_MenuItem);
            DataColumn parentCol;
            DataColumn childCol;
            parentCol = dt_2Menu.Columns["ID"];
            childCol = dt_MenuItem.Columns["ParentID"];
            DataRelation rel;
            rel = new DataRelation("MenuRelation", parentCol, childCol);
            // Add the relation to the DataSet.
            ds_NavMenu.Relations.Add(rel);

        }
        public void NodeOperate(XmlNode xn1)
        {
            bool hasRight2 = true;
            bool hasRight = true;
            if (xn1.Name == "Menus")
            {
                //读顶层菜单
                DataRow dr_2Menu;
                dr_2Menu = dt_2Menu.NewRow();
                dr_2Menu[0] = xn1.Attributes["ID"].Value.ToString();
                dr_2Menu[1] = xn1.Attributes["Text"].Value.ToString();
                if (xn1.Attributes["AdminType"] != null)
                {
                    dr_2Menu["AdminType"] = xn1.Attributes["AdminType"].Value.ToString();
                }
                //需要判断

                if (dr_2Menu["AdminType"] != null
                     && dr_2Menu["AdminType"].ToString() != string.Empty)
                {
                    if (dr_2Menu["AdminType"].ToString() == "1")
                    {
                        hasRight2 &= false;
                    }
                }

               

                dr_2Menu["Show"] = hasRight2;
                dt_2Menu.Rows.Add(dr_2Menu);
            }
            //然后读这个菜单下面的子菜单
            else if (xn1.Name == "MenuItem")
            {
                DataRow dr_MenuItem;
                dr_MenuItem = dt_MenuItem.NewRow();
                dr_MenuItem["ID"] = xn1.Attributes["ID"].Value.ToString();
                dr_MenuItem[0] = xn1.ParentNode.Attributes["ID"].Value.ToString();
                dr_MenuItem[1] = xn1.Attributes["Text"].Value.ToString();
                //dr_MenuItem[2] = reader["ImageUrl"].ToString();
                if (xn1.Attributes["NavigateUrl"].Value.ToString().StartsWith("~/"))
                {
                    dr_MenuItem[3] = this.Page.ResolveUrl(xn1.Attributes["NavigateUrl"].Value.ToString());
                }
                else
                {
                    dr_MenuItem[3] = xn1.Attributes["NavigateUrl"].Value.ToString();
                }

                if (xn1.Attributes["AdminType"] != null)
                {
                    dr_MenuItem["AdminType"] = xn1.Attributes["AdminType"].Value.ToString();
                }
                //需要判断

                if (dr_MenuItem["AdminType"] != null
                     && dr_MenuItem["AdminType"].ToString() != string.Empty)
                {
                    if (dr_MenuItem["AdminType"].ToString() == "1")
                    {
                        hasRight &= false;
                    }
                }


                dr_MenuItem["Show"] = hasRight;


                dt_MenuItem.Rows.Add(dr_MenuItem);
            }

            if (xn1.HasChildNodes == true)
            {
                foreach (XmlNode childNode in xn1.ChildNodes)
                {
                    NodeOperate(childNode);
                }
            }
        }

        public void BindDate_TopMenu()
        {
            NavMenu_List.DataSource = dt_2Menu;
            NavMenu_List.DataBind();
        }
        protected void NavMenu_List_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            //Only consume the items in the parent datalist 
            //pertinent to nesting
            if (e.Item.ItemType == ListItemType.Item ||
                e.Item.ItemType == ListItemType.AlternatingItem)
            {
                //Now that the nested repeater is in scope, find it, 
                //cast it, and create a child view from
                //the datarelation name, and specify that view as the 
                //datasource.  Then bind the nested repeater!
                //string sMenuID = NavMenu_List.[e.Item.ItemIndex].ToString();
                Repeater MenuItem_List = (Repeater)e.Item.FindControl("MenuItem_List");
                if (MenuItem_List != null)
                {
                    MenuItem_List.DataSource =
                        ((DataRowView)e.Item.DataItem).CreateChildView("MenuRelation");
                    MenuItem_List.DataBind();
                }

            }
        }
    }



}