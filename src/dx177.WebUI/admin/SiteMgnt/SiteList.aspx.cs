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
using dx177.FrameWork;
using dx177.Model;
using CampanyCMS.Model.Bus;

namespace dx177.WebUI.admin.SiteMgnt
{
    public partial class SiteList : BasePage
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
            SitesBLL.GetInstance().BindDropListTreeType(drpType, AppContext.CurrentMgtJingQuCode);
            drpType.Items.Insert(0, new ListItem("请选择", ""));
        }

        private void ShowData()
        {
            DataTable dt = SitesBLL.GetInstance().GetSitesList(drpType.SelectedValue, txtTitle.Text, AppContext.CurrentMgtJingQuCode);
            dgSites.Data = dt;
            dgSites.DataBind();
        }


        protected void dgSites_ItemDataBound(object sender, DataGridItemEventArgs e)
        {

            if (e.Item.ItemType == ListItemType.Header)
            {
                CheckBox cbxAll = e.Item.FindControl("cbxAll") as CheckBox;
                if (cbxAll != null)
                    cbxAll.Attributes.Add("onclick", "javascript:return SelectAll('" + dgSites.ClientID + "');");
            }
        }

        protected void dgSites_ItemCommand(object source, DataGridCommandEventArgs e)
        {

            switch (e.CommandName)
            {
                case "Delete":
                    SitesBLL.GetInstance().RemoveBySeqno(int.Parse(e.CommandArgument.ToString()));
                    btnSearch_Click(null, null);
                    break;
                case "Modify":
                    string url = UrlUtility.AddOrReplaceParam("SitePage.aspx", "seqno", e.CommandArgument.ToString(), true);
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
            Response.Redirect("SitePage.aspx");
        }

        protected void bntCreatePage_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgSites.Items.Count; i++)
            {
                CheckBox chkGrid = dgSites.Items[i].FindControl("chkGrid") as CheckBox;
                if (chkGrid.Checked)
                {
                    string seqno = dgSites.Items[i].Cells[0].Text;
                    BuildPageBLL.BuildOnePage("景点", AppContext.CurrentResuser.Username, seqno);
                 
                }

            }
            CommonScript.AlertMessage(this.Page, "已成功");
        }
    }
}
