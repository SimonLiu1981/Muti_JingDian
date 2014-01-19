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
using dx177.Model;
using dx177.FrameWork;
using dx177.Business.Bus;

namespace dx177.WebUI.admin
{
    public partial class JingquManagementNavigation : BasePage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                AppContext.CurrentMgtJingQuCode = string.Empty;
                linkToManagement.Visible = AppContext.CurrentResuser.Usertype == ResUserType.SupperAdmin.ToString("d");
                this.dgNews.Data = JqingqumanagerBLL.GetInstance().GetMyManageJingQus(AppContext.CurrentResuser);
                dgNews.DataBind();
            }
        }


        protected void dgNews_ItemDataBound(object sender, DataGridItemEventArgs e)
        {
          
        }

        protected void dgNews_ItemCommand(object source, DataGridCommandEventArgs e)
        {

            switch (e.CommandName)
            {               
                case "Manage":
                    string jingqucode = e.CommandArgument.ToString();
                    AppContext.CurrentMgtJingQuCode = jingqucode;
                    Response.Redirect("frame/index.aspx");
                    break;
                default:
                    break;
            }
        }
    }
}
