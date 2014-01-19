using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using dx177.Business.Bus;
using dx177.Model.Bus;

namespace dx177.WebUI.admin
{
    public partial class SystemDefinitionSetting :BasePage
    {
        private string BC
        {
            get
            {
                return Request.QueryString["bc"];
            }
            
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                 SystemDefinition sd = new SystemDefinitionBLL().GetByBrandingCode(BC);
                 txtValue.Value = sd.Value;
                 txtDescription.Value = sd.Description;
                 lblBrandingCode.Text = sd.BrandingCode;
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SystemDefinition sd = new SystemDefinition();
            sd.Value = txtValue.Value;
            sd.Description = txtDescription.Value;
            sd.BrandingCode = lblBrandingCode.Text;
            new SystemDefinitionBLL().UpdateSystemDefinition(sd);
        }
    }
}
