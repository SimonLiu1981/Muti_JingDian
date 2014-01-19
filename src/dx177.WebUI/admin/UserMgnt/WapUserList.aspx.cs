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
using dx177.FrameWork;

namespace dx177.WebUI.admin.UserMgnt
{
    public partial class WapUserList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                ShowData();
            }
        }

        private void ShowData()
        {
            DataTable dt =ResuserBLL.GetInstance().GetResuserList(ResUserType.WapUser.ToString("d"));
            dgWapUserlist.Data = dt;
            dgWapUserlist.DataBind();
        }


        protected void btnSearch_Click(object sender, EventArgs e)
        {
            ShowData();
        }

        protected void dgWapUserlist_ItemCommand(object source, DataGridCommandEventArgs e)
        {

        }

        protected void dgWapUserlist_ItemDataBound(object sender, DataGridItemEventArgs e)
        {

        }
    }
}
