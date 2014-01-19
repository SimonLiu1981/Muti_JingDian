using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using dx177.Business.Bus;
using dx177.FrameWork;
using dx177.Model.Bus;

namespace dx177.WebUI.admin.UserMgnt
{
    public partial class JingQuManagerList : BasePage
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!base.IsSupperAdmin())
            {
                Logout();
                return;
            }
            if (!Page.IsPostBack)
            {
                ShowData();
            }
        }

        private void ShowData()
        {

            DataTable dt = ResuserBLL.GetInstance().GetResuserList(ResUserType.SupperJingQqAdmin.ToString("d"));
            dgWapUserlist.Data = dt;
            dgWapUserlist.DataBind();
        }


        protected void btnSearch_Click(object sender, EventArgs e)
        {
            ShowData();
        }
        protected void dgWapUserlist_ItemCommand(object source, DataGridCommandEventArgs e)
        {
            switch (e.CommandName)
            {
                case "Delete":
                    Resuser usr = ResuserBLL.GetInstance().Get(new Resuser.Key(int.Parse(e.CommandArgument.ToString())));
                    ResuserBLL.GetInstance().Delete(usr);
                    btnSearch_Click(null, null);
                    break;
                case "Modify":
                    string url = UrlUtility.AddOrReplaceParam("JingQuManager.aspx", "seqno", e.CommandArgument.ToString(), true);
                    Response.Redirect(url);
                    break;
                default:
                    break;
            }
        }

        protected void dgWapUserlist_ItemDataBound(object sender, DataGridItemEventArgs e)
        {
            if (e.Item.ItemType == ListItemType.AlternatingItem ||
             e.Item.ItemType == ListItemType.Item)
            {

                Label lblManageJingQu = e.Item.FindControl("lblManageJingQu") as Label;
                lblManageJingQu.Text = JingqusBLL.GetInstance().GetEntityByJingqucode(lblManageJingQu.Text).Jingquname;
            }
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {

            
            Response.Redirect("JingQuManager.aspx");
        }
    }
}
