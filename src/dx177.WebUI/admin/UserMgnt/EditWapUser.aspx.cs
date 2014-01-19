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
using dx177.Model.Bus;
using dx177.FrameWork;

namespace dx177.WebUI.admin.UserMgnt
{
    public partial class EditWapUser : System.Web.UI.Page
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
            if (!Page.IsPostBack)
            {
                 
                ShowData();
            }
        }

        private void ShowData()
        {
            Resuser resuser = ResuserBLL.GetInstance().Get(new dx177.Model.Bus.Resuser.Key(this.Seqno));
            if (resuser != null)
            {
                UControl.CopyEntityToControl(this.Form1, resuser);
            }
        }

        private void Save()
        {
            if (Seqno > 0)
            {
                Resuser n = ResuserBLL.GetInstance().Get(new Resuser.Key(Seqno));
                UControl.CopyControlToEntity(this.Form1, n);
                ResuserBLL.GetInstance().Update(n);
            }
            Page.ClientScript.RegisterStartupScript(this.Page.GetType(), "", "<script language='javascript' type='text/javascript'> $(document).ready(function() {parent.RefeshBook();parent.tb_remove();});</script>");
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
              Save();
        }

        protected void btnReturn_Click(object sender, EventArgs e)
        {
            Page.ClientScript.RegisterStartupScript(this.Page.GetType(), "", "<script language='javascript' type='text/javascript'> $(document).ready(function() {parent.RefeshBook();parent.tb_remove();});</script>");
   
        }
    }
}
