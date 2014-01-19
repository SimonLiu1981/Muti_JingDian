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
    public partial class RoomPage : BasePage
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
            if (!IsPostBack)
            {
                txt1Guid.Value = System.Guid.NewGuid().ToString();

                Dict.Tag.BindListControl(chklistInstallations, "RoomInst", AppContext.CurrentMgtJingQuCode);
                UCModelType1.IniData();
                ShowData();
            }

            txtViewtimes.Attributes.Add("viewtimes_set_guid", txt1Guid.Value);
        }

        private void ShowData()
        {
            Room r = RoomBLL.GetInstance().Get(new Room.Key(this.Seqno));
            if (r != null)
            {
                UControl.CopyEntityToControl(this.Form1, r);
                txt1Guid.Value = r.Guid;
                fckContent.Value = r.Descr;
                
                UCModelType1.setModuleType(r.Guid);
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
            }
            r.Pguid = this.PGUID;
            UControl.CopyControlToEntity(this.Form1, r);
            r.CreateDate = DateTime.Now;
            r.Creator = AppContext.CurrentResuser.Username;
            r.Descr = fckContent.Value;
            RoomBLL.GetInstance().Submit(r);
            ModuleBLL.GetInstance().Submit(UCModelType1.GetModuleType(), r.Guid);
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            Save();
            Response.Redirect("RoomList.aspx?PGUID=" + this.PGUID);
        }
    }
}
