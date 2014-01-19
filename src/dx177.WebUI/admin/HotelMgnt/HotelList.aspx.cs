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
using dx177.Model.Bus.QueryO;
using dx177.FrameWork;
using dx177.Business.DictBus;
using dx177.Model;
using CampanyCMS.Model.Bus;

namespace dx177.WebUI.admin.HotelMgnt
{
    public partial class HotelList : BasePage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                Dict.Tag.BindListControl(drpHoteltype, "Hoteltype", AppContext.CurrentMgtJingQuCode);
                drpHoteltype.Items.Insert(0, new ListItem("请选择", ""));
                ShowData();
            }
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            ShowData();
        }

        private void ShowData()
        { 
            HotelQuery h=new HotelQuery () ;
            h.Name=txtName.Text ;
            h.Price1=txtMinPrice.Text.Trim()==string.Empty?0:decimal.Parse(txtMinPrice.Text);
            h.Price2=txtMaxPrice.Text.Trim()==string.Empty?100000:decimal.Parse(txtMaxPrice.Text);
            h.HotelType = drpHoteltype.SelectedValue;
            h.BeginDate=dateBegin.Text==string.Empty?"1901-01-01":dateBegin.Text ;
            h.EndDate=dateEnd.Text==string.Empty?"2049-12-31":dateEnd.Text ;
            h.JingQuCode = AppContext.CurrentMgtJingQuCode;
            DataTable dt = HotelBLL.GetInstance().GetHotelList(h);
            dgHotel.Data = dt;
            dgHotel.DataBind();
        }


        protected void dgHotel_ItemDataBound(object sender, DataGridItemEventArgs e)
        {
            if (e.Item.ItemType == ListItemType.Header)
            {
                CheckBox cbxAll = e.Item.FindControl("cbxAll") as CheckBox;
                if (cbxAll != null)
                    cbxAll.Attributes.Add("onclick", "javascript:return SelectAll('" + dgHotel.ClientID + "');");
            }

            if (e.Item.ItemType == ListItemType.AlternatingItem ||
                e.Item.ItemType == ListItemType.Item)
            {
                e.Item.Cells[4].Text = Dict.Tag["Hoteltype", e.Item.Cells[4].Text, 2052];
                e.Item.Cells[5].Text = Dict.Tag["Area", e.Item.Cells[5].Text, 2052];
                LinkButton btnDelete = e.Item.FindControl("btnDelete") as LinkButton;
                btnDelete.Attributes.Add("onclick", "return confirm('确认删除吗？') ;"); ;
                

                Label lblStatus = e.Item.FindControl("lblStatus") as Label;
                lblStatus.Text = Dict.Tag["OpenStatus", lblStatus.Text, 2052];
            }
        }

        protected void dgHotel_ItemCommand(object source, DataGridCommandEventArgs e)
        {
        
            switch (e.CommandName)
            {
                case "Delete":
                    HotelBLL.GetInstance().RemoveHotel(int.Parse(e.CommandArgument.ToString()));
                    btnSearch_Click(null, null);
                    break;
                case "Modify":
                    string url = UrlUtility.AddOrReplaceParam("HotelPage.aspx", "seqno", e.CommandArgument.ToString(), true);
                    Response.Redirect(url);
                    break;
                case "ViewComment":
                    string url1 = UrlUtility.AddOrReplaceParam("../CommentMgnt/viewcomments.aspx", "guid", e.CommandArgument.ToString(), true);
                    url1 = UrlUtility.AddOrReplaceParam(url1, "r", Request.RawUrl.ToString(), true);
                    url1 = UrlUtility.AddOrReplaceParam(url1, "type", "1", true);
                    Response.Redirect(url1);
                    break;
                default:
                    break;
            }
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            Response.Redirect("HotelPage.aspx");
        }

        protected void bntCreatePage_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgHotel.Items.Count; i++)
            {
                CheckBox chkGrid = dgHotel.Items[i].FindControl("chkGrid") as CheckBox;
                if (chkGrid.Checked)
                {
                    string seqno = dgHotel.Items[i].Cells[0].Text;
                    BuildPageBLL.BuildOnePage("酒店", AppContext.CurrentResuser.Username, seqno);
                }

            }

            CommonScript.AlertMessage(this.Page, "已成功");
        }
    }
}
