using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using dx177.Model.Bus.QueryO;
using dx177.Business.DictBus;
using dx177.FrameWork;
using dx177.Model.Bus;
using dx177.Business.Bus;
using dx177.Model;

namespace dx177.WebUI.admin.HotelMgnt
{
    public partial class orderList : BasePage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                rbtStatus.Items.Clear();
                Dict.Tag.BindListControl(rbtStatus, "HotelOrderStatus",AppContext.CurrentMgtJingQuCode);
                this.rbtStatus.Items.Insert(0, new ListItem("请选择", ""));
                this.rbtStatus.SelectedValue = "";
                btnSearch_Click(null, null);
            }
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            HotelOrderQuery query = new HotelOrderQuery();
            query.Enddate = dateEnd.Text;
            query.Begindate = dateBegin.Text;
            query.Orderno = txtOrderNO.Text;
            query.OrderStatus = rbtStatus.SelectedValue;
            query.HotelCreator = AppContext.GetCurrentName();
            query.JingQuCode = AppContext.CurrentMgtJingQuCode;
            this.dgNews.Data = HotelorderBLL.GetInstance().Search(query, AppContext.CurrentMgtJingQuCode);
            this.dgNews.DataBind();
        }

        protected void dgNews_ItemCommand(object source, DataGridCommandEventArgs e)
        { 
            switch (e.CommandName)
            {
                case "Delete":
                    HotelorderBLL.GetInstance().RemoveHotelOrder(int.Parse(e.CommandArgument.ToString()));
                    btnSearch_Click(null, null);
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
                Label lblStatus = e.Item.FindControl("lblStatus") as Label;
                lblStatus.Text = Dict.Tag[((HotelOrderStatus)int.Parse(lblStatus.Text))];

            }
        }
    }
}
