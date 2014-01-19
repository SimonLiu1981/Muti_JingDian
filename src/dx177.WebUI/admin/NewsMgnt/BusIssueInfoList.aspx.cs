using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using dx177.Business.Bus;
using dx177.Model.Bus;
using dx177.Business.DictBus;
using dx177.FrameWork;
using dx177.Model;

namespace dx177.WebUI.admin.NewsMgnt
{
    public partial class BusIssueInfoList : BasePage
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                IniData();
                ShowData();
            }
        }

        private void IniData()
        {
            Dict.Tag.BindListControl(drpType, "Issue", AppContext.CurrentMgtJingQuCode);
            drpType.Items.Insert(0, new ListItem("请选择", ""));
        }

        private void ShowData()
        {
            DataTable dt = BusIssueInfoBLL.GetInstance().GetIssueList(drpType.SelectedValue, txtTitle.Text, AppContext.CurrentMgtJingQuCode);
            dgNews.Data = dt;
            dgNews.DataBind();
        }


        protected void dgNews_ItemDataBound(object sender, DataGridItemEventArgs e)
        {
            if (e.Item.ItemType == ListItemType.AlternatingItem ||
               e.Item.ItemType == ListItemType.Item)
            {                
                e.Item.Cells[2].Text = Dict.Tag["Issue", e.Item.Cells[2].Text, 2052];
             
            }
        }

        protected void dgNews_ItemCommand(object source, DataGridCommandEventArgs e)
        {

            switch (e.CommandName)
            {
                case "Delete":
                    BusIssueInfo b = new BusIssueInfo();
                    b.Seqno = int.Parse(e.CommandArgument.ToString());
                    BusIssueInfoBLL.GetInstance().Delete(b);
                    btnSearch_Click(null, null);
                    break;
                case "Modify":
                    string url = UrlUtility.AddOrReplaceParam("BusIssueInfoPage.aspx", "seqno", e.CommandArgument.ToString(), true);
                    Response.Redirect(url);
                    break;
                default:
                    break;
            }
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            ShowData();
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            Response.Redirect("BusIssueInfoPage.aspx");
        }
    }
}
