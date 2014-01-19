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
using dx177.Business.DictBus;
using dx177.Model.Bus.QueryO;
using dx177.Business.Bus;
using dx177.FrameWork;
using dx177.Model;

namespace dx177.WebUI.admin.ShopMgnt
{
    public partial class ShopList : BasePage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                Dict.Tag.BindListControl(drpShoptype, "Shoptype", AppContext.CurrentMgtJingQuCode);
                drpShoptype.Items.Insert(0, new ListItem("请选择", ""));
                ShowData();
            }
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            ShowData();
        }

        private void ShowData()
        {
            ShopQuery s = new ShopQuery();
            s.Title = txtTitle.Text;
            s.OpenStatus = "";
            s.BizType = drpShoptype.SelectedValue;
            s.JingQuCode = AppContext.CurrentMgtJingQuCode;
            DataTable dt = ShopBLL.GetInstance().GetShopData(s);
            dgShop.Data = dt;
            dgShop.DataBind();
        }


        protected void dgHotel_ItemDataBound(object sender, DataGridItemEventArgs e)
        {
            if (e.Item.ItemIndex > -1)
            {
                e.Item.Cells[3].Text = Dict.Tag["Shoptype", e.Item.Cells[3].Text, 2052];
                
            }
        }

        protected void dgHotel_ItemCommand(object source, DataGridCommandEventArgs e)
        {

            switch (e.CommandName)
            {
                case "Delete":
                    ShopBLL.GetInstance().RemoveByseqno(int.Parse(e.CommandArgument.ToString()));
                    btnSearch_Click(null, null);
                    break;
                case "Modify":
                    string url = UrlUtility.AddOrReplaceParam("ShopPage.aspx", "seqno", e.CommandArgument.ToString(), true);
                    Response.Redirect(url);
                    break;
                default:
                    break;
            }
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            Response.Redirect("ShopPage.aspx");
        }
    }
}
