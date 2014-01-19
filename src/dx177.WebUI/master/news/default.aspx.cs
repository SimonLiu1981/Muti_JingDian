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
using dx177.FrameWork;
using dx177.Business.Bus;

namespace dx177.WebUI.master.news
{
    public partial class _default : System.Web.UI.Page
    {

       

        private string typeCode
        {
            get
            {
                if (Request.QueryString["typeCode"] != null)
                {
                    return ComSafe.SafeValue(Request.QueryString["typeCode"]);
                }
                return string.Empty;
            }
        }

        
        
        
        public string strTpename = string.Empty;
        protected void Page_Load(object sender, EventArgs e)
        {
            
            strTpename = NewstypeBLL.GetInstance().GetNewstypeNameBycode(this.typeCode);
            Hashtable hs = new Hashtable();
            hs.Add("Title_TypeName", "新闻资讯" + strTpename);

            dx177.Business.Bus.CommonBLL.GetInstance().IniPageKeyWord(this.Page, "news", hs);

            ShowData();
        }

        private void ShowData()
        {
            DataTable dt = NewsBLL.GetInstance().Query(this.typeCode, string.Empty);
            LsHotelList.DataSource = dt;
            LsHotelList.DataBind();
       
        }

 
        protected void LsHotelList_PagePropertiesChanging(object sender, PagePropertiesChangingEventArgs e)
        {
            DataPager1.SetPageProperties(e.StartRowIndex, e.MaximumRows, false);
            ShowData();
        }

        protected void DataPager1_PreRender(object sender, EventArgs e)
        {
            DataPager pager = (DataPager)sender;
            new PagingHelper().ProcessPaging(pager, this);
        }
    }
}
