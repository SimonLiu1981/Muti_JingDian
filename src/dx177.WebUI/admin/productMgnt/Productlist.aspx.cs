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

namespace dx177.WebUI.admin.productMgnt
{
    public partial class Productlist : BasePage
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
            ProductsBLL.GetInstance().BindDropListTreeType(drpType);
            drpType.Items.Insert(0, new ListItem("请选择", ""));
        }

        private void ShowData()
        {
            DataTable dt = ProductsBLL.GetInstance().GetProductList(drpType.SelectedValue, txtTitle.Text,AppContext.GetCurrentName());
            dgNews.Data = dt;
            dgNews.DataBind();
        }


        protected void dgNews_ItemDataBound(object sender, DataGridItemEventArgs e)
        {

        }

        protected void dgNews_ItemCommand(object source, DataGridCommandEventArgs e)
        {

            switch (e.CommandName)
            {
                case "Delete":
                    ProductsBLL.GetInstance().RemoveBySeqno(int.Parse(e.CommandArgument.ToString()));
                    btnSearch_Click(null, null);
                    break;
                case "Modify":
                    string url = UrlUtility.AddOrReplaceParam("ProductPage.aspx", "seqno", e.CommandArgument.ToString(), true);
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
            Response.Redirect("ProductPage.aspx");
        }
    }
}
