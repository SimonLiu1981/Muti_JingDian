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
using dx177.Business.Bus;
using dx177.Model.Bus;
using dx177.FrameWork;

namespace dx177.WebUI
{
    public partial class Home : System.Web.UI.MasterPage
    {
        protected string Navigation = string.Empty;
        protected string JingQuCode = string.Empty;
      
        protected void Page_Load(object sender, EventArgs e)
        {
            if (AppContext.JingQuCode != string.Empty)
            {                
                JingQuCode = AppContext.JingQuCode;
                Jingqus obj = JingqusBLL.GetInstance().GetEntityByJingqucode(JingQuCode);
                if (obj.Navigationswitch)
                {
                    Navigation = JingqusBLL.GetInstance().GetEntityByJingqucode(JingQuCode).Navigation;
                }
                else
                {

                    Navigation = new SystemDefinitionBLL().GetByBrandingCode(ConstantElements.JingQuNavigation).Value;
                }

                Navigation = Navigation.Replace("|JINGQUCODE|", JingQuCode);
                
            }

        }
    }
}
