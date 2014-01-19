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
using System.Collections.Generic;

namespace dx177.WebUI.usercontrols
{
    public partial class UCModelType : System.Web.UI.UserControl
    {
          string _Type = "";

        public string Type
        {
            get
            {
                return _Type;
            }
            set
            {
                _Type = value;
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            

        }

        public void IniData()
        {
            DataTable dt = ModuletypeBLL.GetInstance().GetModuleType(this.Type);
            chkModeType.DataSource = dt;
            chkModeType.DataTextField = "title";
            chkModeType.DataValueField = "code";
            chkModeType.DataBind();
        }

        public List<string>  GetModuleType()
        {
            List<string> il = new List<string>();
            for (int i = 0; i < chkModeType.Items.Count; i++)
            {
                if (chkModeType.Items[i].Selected)
                {
                    il.Add(chkModeType.Items[i].Value);
                }
            }
            return il;
        }


        public void setModuleType(string PGuid)
        {
            List<string > il =  ModuleBLL.GetInstance().GetModuleByGuid(PGuid);
            if (il != null && il.Count>0)
            {
                foreach (string s in il)
                {
                    for (int i = 0; i < chkModeType.Items.Count; i++)
                    {
                        if (chkModeType.Items[i].Value.ToUpper() == s.ToUpper())
                        {
                            chkModeType.Items[i].Selected = true;
                        }
                    }
                }
            }
        }
    }
}