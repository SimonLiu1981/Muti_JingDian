using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using dx177.FrameWork;
using dx177.Business.DictBus;
using dx177.Business.Bus;
using dx177.Model.Bus.QueryO;
using dx177.Model.Bus;
using System.IO;
using dx177.Model;

namespace dx177.WebUI.admin.RestaurantMgnt
{
    public partial class list : BasePage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                InitData(); 
            }
        }

        private void InitData()
        {
            ddlStatus.Items.Clear();
            Dict.Tag.BindListControl(this.ddlStatus, "OpenStatus", AppContext.CurrentMgtJingQuCode);
            ddlStatus.Items.Insert(0, new ListItem("请选择", ""));

            btnSearch_Click(null, null);
        }
        protected void btnAdd_Click(object sender, EventArgs e)
        {
            string url = UrlUtility.AddOrReplaceParam("edit.aspx", "r", Request.RawUrl, true);
            Response.Redirect(url);
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            RestaurantQuery query = new RestaurantQuery();
            query.Title = txtName.Text;
            query.OpenStatus = ddlStatus.SelectedValue;
            query.JingQuCode = AppContext.CurrentMgtJingQuCode;            
            this.dgNews.Data = RestaurantBLL.GetInstance().Search(query);
            this.dgNews.DataBind();
        }

        protected void dgNews_ItemDataBound(object sender, DataGridItemEventArgs e)
        {
            if (e.Item.ItemType == ListItemType.AlternatingItem ||
                e.Item.ItemType == ListItemType.Item)
            {
                Label lblRestaurantType = e.Item.FindControl("lblRestaurantType") as Label;
                lblRestaurantType.Text = Dict.Tag["RestaurantType", lblRestaurantType.Text, 2052];

                Label lblStatus = e.Item.FindControl("lblStatus") as Label;
                lblStatus.Text = Dict.Tag["OpenStatus", lblStatus.Text, 2052];

            }
        }

        protected void dgNews_ItemCommand(object source, DataGridCommandEventArgs e)
        {

            RestaurantBLL bll = RestaurantBLL.GetInstance();
            switch (e.CommandName)
            {
                case "Delete":
                    RestaurantBLL.GetInstance().RemoveRestaurant(e.CommandArgument.ToString());                   
                    btnSearch_Click(null, null);
                    break;
                case "Modify":
                    string url = UrlUtility.AddOrReplaceParam("edit.aspx", "r", Request.RawUrl, true);
                    url = UrlUtility.AddOrReplaceParam(url, "seqno", e.CommandArgument.ToString(), true);
                    Response.Redirect(url);
                    break;
                case "ViewComment":
                    string url1 = UrlUtility.AddOrReplaceParam("../CommentMgnt/viewcomments.aspx", "guid", e.CommandArgument.ToString(), true);
                    url1 = UrlUtility.AddOrReplaceParam(url1, "r", Request.RawUrl.ToString(), true);
                    url1 = UrlUtility.AddOrReplaceParam(url1, "type", "2", true);
                    Response.Redirect(url1);
                    break;
                default:
                    break;
            }

        }
    }
}
