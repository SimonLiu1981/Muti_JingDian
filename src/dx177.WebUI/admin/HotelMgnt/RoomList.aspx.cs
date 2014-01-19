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
using dx177.Business.DictBus;
using dx177.FrameWork;
using dx177.Model;

namespace dx177.WebUI.admin.HotelMgnt
{
    public partial class RoomList : BasePage
    {
        public string PGUID
        {
            get
            {
                if (Request.QueryString["PGUID"] != null)
                {
                    return Request.QueryString["PGUID"];
                }
                return string.Empty;
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                Dict.Tag.BindListControl(drHotelType, "Hoteltype", AppContext.CurrentMgtJingQuCode);
                drHotelType.Items.Insert(0, new ListItem("请选择", "0"));
                btnSearch_Click(null, null);
            }
        }

        private void ShowData()
        { 
            RoomQuery rq=new RoomQuery() ;
            if (this.PGUID != string.Empty)
            {
                rq.PGuid=PGUID ;
            }
            else
            {
                rq.HotelName=txtName.Text ;
                rq.HotelType =drHotelType.SelectedValue ;
                rq.maxPrice=txtMaxPrice.Text==string.Empty ?10000: Convert.ToDecimal(txtMaxPrice.Text) ;
                rq.minPrice=txtMinPrice.Text==string.Empty ?0: Convert.ToDecimal(txtMinPrice.Text) ;
                rq.BeginDate=dateBegin.Text==string.Empty ?string.Empty :dateBegin.Text ;
                rq.EndDate =dateEnd.Text==string.Empty ?string.Empty :dateEnd.Text ;
            }
            DataTable dt = RoomBLL.GetInstance().GetRoom(rq);
            dgHotel.Data = dt;
            dgHotel.DataBind();
        }

        protected void dgRoom_ItemDataBound(object sender, DataGridItemEventArgs e)
        {

        }

        protected void dgRoom_ItemCommand(object source, DataGridCommandEventArgs e)
        {
           
            switch (e.CommandName)
            {
                case "Delete":
                    RoomBLL.GetInstance().RemoveBySeqno(int.Parse(e.CommandArgument.ToString()));
                    HotelBLL.GetInstance().UpdateHotelMaxMinPrice(this.PGUID);
                    btnSearch_Click(null, null);
                    break;
                case "Modify":
                    string url = UrlUtility.AddOrReplaceParam("RoomPage.aspx", "seqno", e.CommandArgument.ToString(), true);
                    url = UrlUtility.AddOrReplaceParam(url, "PGUID", this.PGUID, true);
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
            Response.Redirect("RoomPage.aspx?PGUID="+this.PGUID );
        }
    }
}
