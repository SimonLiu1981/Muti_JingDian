using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using dx177.Business.DictBus;
using dx177.Model.Bus;
using dx177.Business.Bus;
using dx177.FrameWork;
using dx177.Model;

namespace dx177.WebUI.web.admin
{
    public partial class member_publish_hotel : ResUserBasePage
    {
        public int Seqno
        {
            get
            {
                if (Request.QueryString["Seqno"] != null)
                {
                    return int.Parse(Request.QueryString["Seqno"]);
                }
                return 0;
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                txt1Guid.Value = System.Guid.NewGuid().ToString();
                Dict.Tag.BindListControl(drpHoteltype, "Hoteltype", AppContext.JingQuCode);
                drpHoteltype.Items.Insert(0, new ListItem("请选择", "0"));
                Dict.Tag.BindListControl(drpArea, "AREA", AppContext.JingQuCode);
                drpArea.Items.Insert(0, new ListItem("请选择", "0"));
                Dict.Tag.BindListControl(chklistInstallationsstr, "HoteInst", AppContext.JingQuCode);
               // Dict.Tag.BindListControl(rbtStatus, "OpenStatus");
               // UCModelType1.IniData();
                ShowData();
            }
        }

        private void ShowData()
        {
            Hotel h =null;
            if (Seqno != 0)
            {
                h = HotelBLL.GetInstance().Get(new Hotel.Key(Seqno));
            }            
            if (h != null)
            {
                UControl.CopyEntityToControl(this.form1, h);
                fckDesc.Value = h.Descr;
                txt1Guid.Value = h.Guid;
                lbstatus.Text = Dict.Tag["OpenStatus", h.Status.ToString(), 2052];
                if (lbstatus.Text == "")
                {
                    lbstatus.Text = Dict.Tag["OpenStatus", OpenStatus.Application.ToString("d"), 2052]; ;
                } 
               // UCModelType1.setModuleType(h.Guid);
            }
            
        }

        private void Save()
        {
            Hotel h = null;
            if (Seqno != 0)
            {
                h = HotelBLL.GetInstance().Get(new Hotel.Key(Seqno));
            }
            if (h == null)
            {
                h = new Hotel();
                h.Guid = txt1Guid.Value;
                h.Status = (int)OpenStatus.Application;
                h.Creator = AppContext.CurrentResuser.Username;
                h.CreateDate = DateTime.Now;
            }
            h.Status = (int)OpenStatus.Application;
            h.Descr = fckDesc.Value;
            h.Jingqucode = AppContext.JingQuCode;
            UControl.CopyControlToEntity(this.form1, h);            
            HotelBLL.GetInstance().Submit(h);
            Response.Redirect("/member-hotellist.aspx");
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            Save();
        }
    }
}
