using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Xml.Linq;
using dx177.Business.DictBus;
using dx177.Model.Bus;
using dx177.Business.Bus;
using dx177.FrameWork;
using dx177.Model;

namespace dx177.WebUI.web.admin
{
    public partial class member_room:ResUserBasePage
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

        public string hotelGuid
        {
            get
            {
                if (Request.QueryString["hotelGuid"] != null)
                {
                    return Request.QueryString["hotelGuid"];
                }
                return string.Empty;
            }
            
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Hotel h = HotelBLL.GetInstance().GetHotelByGuid(hotelGuid);
                if (h == null)
                {
                    string s = " alert('请把录入酒店基础信息！');window.location.href='member-hotel.aspx';";
                    CommonScript.ResonseScript(this.Page, s);
                    return;
                }                 
                
                txt1Guid.Value = System.Guid.NewGuid().ToString();
                Dict.Tag.BindListControl(chklistInstallations, "RoomInst", AppContext.CurrentMgtJingQuCode);
                ShowData();
            }
        }

        private void ShowData()
        {
            Room r = RoomBLL.GetInstance().Get(new Room.Key(this.Seqno));
            if (r != null)
            {
                UControl.CopyEntityToControl(this.form1, r);                
                txt1Guid.Value = r.Guid;
                fckDesc.Value = r.Descr;
            }
            
        }

        private void Save()
        {
            Room r = new Room();
            if (Seqno > 0)
            {
                r = RoomBLL.GetInstance().Get(new Room.Key(Seqno));
                
            }
            else
            {
                r.Guid = txt1Guid.Value;
                r.CreateDate = DateTime.Now;
                r.Creator = AppContext.CurrentResuser.Username;
                r.Pguid = this.hotelGuid;
            }
            r.Descr = fckDesc.Value;         
            UControl.CopyControlToEntity(this.form1, r);            
            RoomBLL.GetInstance().Submit(r);
          //  ModuleBLL.GetInstance().Submit(UCModelType1.GetModuleType(), r.Guid);
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            Save();
            Response.Redirect("/member-roomlist.aspx?hotelGuid=" + Request.QueryString["hotelGuid"]);
        }
    }
}
