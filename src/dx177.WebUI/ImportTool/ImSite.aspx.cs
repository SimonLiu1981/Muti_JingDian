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
using dx177_building;
using dx177.WebUI.HotelInfoImport;
using dx177.Business.Bus;
using dx177.Model.Bus;
using System.Collections.Generic;
using dx177.FrameWork;

namespace dx177.WebUI.ImportTool
{
    public partial class ImSite : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string spath=path() ;

            SiteList h = XmlData.XmlDeserialize(typeof(SiteList), spath) as SiteList;
            List<Sites> ls = new List<Sites>();
            foreach (Site s in h.SiteListArr)
            {
                Sites si = new Sites();
                si.Title = s.Title;
                si.Logo = s.Logo;
                si.Content = s.Content;
                si.Jingqucode = s.JingQuCode;
                si.Creator = s.Code;
                si.CreateDate = DateTime.Now;
                si.LasteUpdateBy = s.Code;
                si.LasteUpdateDate = DateTime.Now;
                ls.Add(si);
            }
            SitesBLL.GetInstance().SubitList(ls);
            CommonScript.AlertMessage(this.Page, "已成功！");
        }

        public string path()
        {
          //  string path = HttpContext.Current.Request.PhysicalPath.Replace("ImSite.aspx","");
           // string path = HttpContext.Current.Request.Url.OriginalString.Replace("ImSite.aspx", "") ;
            return   @"~/ImportTool/site/SiteList.xml";
        }
    }
}
