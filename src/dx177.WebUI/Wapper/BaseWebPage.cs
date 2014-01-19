using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using dx177.Model;
using System.Collections.Generic;
using dx177.Model.Bus;
using System.Collections;
using dx177.Business.Bus;

namespace dx177.WebUI.Wapper
{
    public class BaseWebPage : System.Web.UI.Page
    {
        

        protected string DomainNameByJingQuCode
        {
            get
            {
                if (!string.IsNullOrEmpty(AppContext.JingQuCode))
                {
                    return FindDomainCode(AppContext.JingQuCode);
                }
                return string.Empty;
            }
        }

        string FindDomainCode(string jingqucode)
        {
            if (Application["JingQus"] == null)
            {
                List<Jingqus> listJingqu = new List<Jingqus>();
                IList il = JingqusBLL.GetInstance().Select();
                foreach (Jingqus tmp in il)
                {
                    listJingqu.Add(tmp);
                }
                Application["JingQus"] = listJingqu;
            }

            List<Jingqus> listJingqu1 = (List<Jingqus>)Application["JingQus"];

            if (listJingqu1 == null || listJingqu1.Count == 0)
            {
                return string.Empty;
            }
            foreach (Jingqus tmp in listJingqu1)
            {
                if (tmp.Jingqucode.ToLower().Equals(jingqucode.ToLower()))
                {
                    return tmp.Matchdomain;
                }
            }
            return string.Empty;
        }

    }
}
