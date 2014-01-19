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
using dx177.Model;

namespace dx177.WebUI.admin.Order
{
    public partial class orderlist : BasePage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ShowData() ;
        }

        private void ShowData()
        {
            string Creator = AppContext.GetCurrentName();
            DataTable dt = OrderApplyBLL.GetInstance().SearchData(Creator);
           dgNews.Data = dt;
           dgNews.DataBind();
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {

        }

        protected void dgNews_ItemCommand(object source, DataGridCommandEventArgs e)
        {
            switch (e.CommandName)
            {
                case "Delete":
                    OrderApplyBLL.GetInstance().Remove(int.Parse(e.CommandArgument.ToString()));
                    ShowData();
                    break;
                default:
                    break;
            }
        }

        protected void dgNews_ItemDataBound(object sender, DataGridItemEventArgs e)
        {
            if (e.Item.ItemType == ListItemType.AlternatingItem ||
              e.Item.ItemType == ListItemType.Item)
            {
               
            }
        }
    }
}
