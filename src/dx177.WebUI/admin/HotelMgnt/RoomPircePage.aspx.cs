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
using dx177.Model.Bus;
using dx177.Model;
using dx177.Business.Bus;

namespace dx177.WebUI.admin.HotelMgnt
{
    public partial class RoomPircePage : BasePage
    {
         

        private string RGuid
        {
            get
            {
                if (Request.QueryString["RGuid"] != null)
                {
                    return Request.QueryString["RGuid"];
                }
                return "";
            }
        }

        private string HGuid
        {
            get
            {
                if (Request.QueryString["HGuid"] != null)
                {
                    return Request.QueryString["HGuid"];
                }
                return "";
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                Room r = RoomBLL.GetInstance().GetRoom(this.RGuid);
                lbRoomTitle.Text = r.Roomtitle;
                ShowData();
            }
        }

        private void ShowData()
        {
            
            dgRoomPrice.Data =  RoompriceBLL.GetInstance().GetRoomprice(this.RGuid);
            dgRoomPrice.DataBind();
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            Roomprice r = new Roomprice();
            r.CreateDate = DateTime.Now;
            r.Creator = AppContext.GetCurentUserName();
            r.Edate = DateTime.Parse(dateEnd.Text);
            r.Sdate = DateTime.Parse(dateStar.Text);
            r.Price = Convert.ToDouble(txtPrice.Text);
            r.Pguid = this.RGuid ;
            RoompriceBLL.GetInstance().Insert(r);
            Clear();
            ShowData();
        }

        private void Clear()
        {
            dateStar.Text = "";
            dateEnd.Text = "";
            txtPrice.Text = "";
        }

        protected void dgRoomPrice_ItemCommand(object source, DataGridCommandEventArgs e)
        {
            switch (e.CommandName)
            {
                case "Delete":
                    Roomprice obj = new Roomprice();
                    obj.Seqno = int.Parse(e.CommandArgument.ToString());
                    RoompriceBLL.GetInstance().Delete(obj);
                    ShowData();
                    break;
                default:
                    break;
            }
        }

        protected void dgRoomPrice_ItemDataBound(object sender, DataGridItemEventArgs e)
        {

        }

        protected void btnReturn_Click(object sender, EventArgs e)
        {
            Response.Redirect("RoomList.aspx?PGUID=" + this.HGuid);
        }
    }
}
