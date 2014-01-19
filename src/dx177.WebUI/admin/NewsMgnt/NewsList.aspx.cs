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

namespace dx177.WebUI.admin.NewsMgnt
{
    public partial class NewsList : BasePage
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
            NewsBLL.GetInstance().BindDropListTreeType(drpType);
            drpType.Items.Insert(0, new ListItem("请选择", ""));
        }

        private void ShowData()
        {
           DataTable dt = NewsBLL.GetInstance().GetNewsList(drpType.SelectedValue, txtTitle.Text,AppContext.GetCurrentName() , AppContext.CurrentMgtJingQuCode );
           dgNews.Data = dt;
           dgNews.DataBind();
        }


        protected void dgNews_ItemDataBound(object sender, DataGridItemEventArgs e)
        {
            if (e.Item.ItemType == ListItemType.Header)
            {
                CheckBox cbxAll = e.Item.FindControl("cbxAll") as CheckBox;
                if (cbxAll != null)
                    cbxAll.Attributes.Add("onclick", "javascript:return SelectAll('" + dgNews.ClientID + "');");
            }
        }

        protected void dgNews_ItemCommand(object source, DataGridCommandEventArgs e)
        {

            switch (e.CommandName)
            {
                case "Delete":
                    NewsBLL.GetInstance().RemoveBySeqno(int.Parse(e.CommandArgument.ToString()));
                    btnSearch_Click(null, null);
                    break;
                case "Modify":
                    string url = UrlUtility.AddOrReplaceParam("NewsPage.aspx", "seqno", e.CommandArgument.ToString(), true);
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
            Response.Redirect("NewsPage.aspx");
        }

        protected void bntCreatePage_Click(object sender, EventArgs e)
        {
           
            for (int i = 0; i < dgNews.Items.Count; i++)
            {
                CheckBox chkGrid = dgNews.Items[i].FindControl("chkGrid") as CheckBox;
                if (chkGrid.Checked)
                {
                    string seqno = dgNews.Items[i].Cells[0].Text;
                    BuildPageBLL.BuildOnePage("新闻", AppContext.CurrentResuser.Username, seqno);
                }

            }

            CommonScript.AlertMessage(this.Page, "已成功");
        }
    }
}
