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
using dx177.Model.Bus;
using dx177.Business.Bus;
using dx177.FrameWork;
using dx177.Model;

namespace dx177.WebUI.admin.HotelMgnt
{
    public partial class HotelPage : BasePage
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
                Dict.Tag.BindListControl(drpHoteltype, "Hoteltype", AppContext.CurrentMgtJingQuCode);
                drpHoteltype.Items.Insert(0, new ListItem("请选择", "0"));

                Dict.Tag.BindListControl(drpArea, "AREA", AppContext.CurrentMgtJingQuCode);
                drpArea.Items.Insert(0, new ListItem("请选择", "0"));
                Dict.Tag.BindListControl(chklistInstallationsstr, "HoteInst", AppContext.CurrentMgtJingQuCode);
                Dict.Tag.BindListControl(rbtStatus, "OpenStatus", AppContext.CurrentMgtJingQuCode);
                UCModelType1.IniData();
                ShowData();
            }

            txtViewtimes.Attributes.Add("viewtimes_set_guid", txt1Guid.Value);
        }

        private void ShowData()
        {
            Hotel h = HotelBLL.GetInstance().Get(new Hotel.Key(this.Seqno));
            if (h != null)
            {
                UControl.CopyEntityToControl(this.Form1, h);
                
                txt1Guid.Value = h.Guid;
                UCModelType1.setModuleType(h.Guid);
                FckeDescr.Value = h.Descr;
            }
            //UCImgupload1.PGuid = txt1Guid.Value;
            //UCImgupload1.Seqno = Seqno.ToString();
        }

        private void Save()
        {
            Hotel h = new Hotel();
            if (Seqno > 0)
            {
                h = HotelBLL.GetInstance().Get(new Hotel.Key(Seqno));
            }
            else
            {
                h.Guid = txt1Guid.Value;
                h.Creator = AppContext.CurrentResuser.Username;
            }
            UControl.CopyControlToEntity(this.Form1, h);
            h.CreateDate = DateTime.Now;
           // h.Creator = AppContext.CurrentAdministrator.Username;
             
            h.Descr = FckeDescr.Value;
            h.Jingqucode = AppContext.CurrentMgtJingQuCode;
            HotelBLL.GetInstance().Submit(h);
            ModuleBLL.GetInstance().Submit(UCModelType1.GetModuleType(), h.Guid);
            Response.Redirect("HotelList.aspx");
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            Save();
        }

         
    }
}
