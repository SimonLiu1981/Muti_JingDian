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
using dx177.FrameWork;

namespace dx177.WebUI.admin.FriendLinkMgnt
{
    public partial class FriendLinkList : BasePage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {

                dropType.DataSource = CommonBLL.GetInstance().GetSyscodeMap("Friendlink");
                dropType.DataTextField = "name";
                dropType.DataValueField = "val";
                dropType.DataBind();
                dropType.Items.Insert(0, new ListItem("请录入", ""));

                ShowData();
            }
        }

        

        private void ShowData()
        {
            DataTable dt = FriendlinkBLL.GetInstance().GetFriendlinkList(txtTitle.Text, dropType.SelectedValue);
            dgFriend.Data = dt;
            dgFriend.DataBind();
        }


        protected void dgNews_ItemDataBound(object sender, DataGridItemEventArgs e)
        {

        }

        protected void dgNews_ItemCommand(object source, DataGridCommandEventArgs e)
        {

            switch (e.CommandName)
            {
                case "Delete":
                    Friendlink f = new Friendlink();
                    f.Seqno = int.Parse(e.CommandArgument.ToString());
                    FriendlinkBLL.GetInstance().Delete(f);
                    btnSearch_Click(null, null);
                    break;
                case "Modify":
                    string url = UrlUtility.AddOrReplaceParam("FriendLinkPage.aspx", "seqno", e.CommandArgument.ToString(), true);
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
            Response.Redirect("FriendLinkPage.aspx");
        }
    }
}
