using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using dx177.Model.Bus;
using dx177.Business.Bus;
using dx177.FrameWork;

namespace dx177.WebUI.web.hirecar
{
    public partial class detail : System.Web.UI.Page
    {
        public string seqno
        {
            get
            {
                return ComSafe.SafeValue( Request.QueryString["seqno"]);
            }
        }
        protected Hirecar car = new Hirecar();
        protected void Page_Load(object sender, EventArgs e)
        {
            ((defaultMaster)Page.Master).NavId = "hirecar";
            if (!string.IsNullOrEmpty(seqno))
            {
                car = HirecarBLL.GetInstance().Get(new Hirecar.Key(int.Parse(seqno)));
                AddViewTimes(car);
            }
            dx177.Business.Bus.CommonBLL.GetInstance().IniPageKeyWord(this.Page, "hirecardetail", car);
        }

        public int AddViewTimes(Hirecar Rest)
        {
            string ip = Request.ServerVariables.Get("Remote_Addr").ToString();
            if (!DiggBLL.GetInstance().ExistsIp(Rest.Guid, ip, DiggType.ViewTimes))
            {
                Rest.Viewtimes++;
                HirecarBLL.GetInstance().Update(Rest);
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}
