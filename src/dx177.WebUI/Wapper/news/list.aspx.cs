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
using dx177.Business.Bus;
using dx177.Model.Bus;
using System.Collections.Generic;
using dx177.FrameWork;
namespace dx177.WebUI.Wapper.news
{
    public partial class list : System.Web.UI.Page
    {

        public int currentIndex
        {
            get
            {
                if (Request.QueryString["p"] != null)
                {
                    return int.Parse(Request.QueryString["p"]);
                }
                return 1;
            }
        }

        private string typeCode
        {
            get
            {
                if (Request.QueryString["typeCode"] != null)
                {
                    return ComSafe.SafeValue(Request.QueryString["typeCode"]);
                }
                return string.Empty ;
            }
        }

        private string JqCode
        {
            get
            {
                if (Request.QueryString[ConstantElements.QueryStringNameJQ] != null)
                {
                    return ComSafe.SafeValue(Request.QueryString[ConstantElements.QueryStringNameJQ]);
                }
                return string.Empty;
            }
        }

        int pagesize = 15;
        public string strpage = "";

        public string strjqname = string.Empty;
        public string strTpename = string.Empty;
        protected void Page_Load(object sender, EventArgs e)
        {
            strjqname = JingqusBLL.GetInstance().GetNameByJingqucode(this.JqCode); ;
            strTpename = NewstypeBLL.GetInstance().GetNewstypeNameBycode(this.typeCode);
            Hashtable hs = new Hashtable();
            hs.Add("Title_TypeName", strjqname + strTpename);
            dx177.Business.Bus.CommonBLL.GetInstance().IniPageKeyWord(this.Page, "news", hs);

            ShowData();
        }

        private void ShowData()
        {
            DataTable dt = NewsBLL.GetInstance().GetFont_Table(this.typeCode, this.JqCode, this.currentIndex, pagesize);
            int RCount=NewsBLL.GetInstance().GetFont_TableRowCount(this.typeCode, this.JqCode);
            RptData.DataSource = dt;
            RptData.DataBind();
            PageButton(RCount);
        }

        private void PageButton(int RecordCount )
        {

            PageButton p = new PageButton(@"\Templates\xml\hotel\sBUTTON.XML", string.Format("/JQ_{1}/news?typeCode={0}&p=", this.typeCode, this.JqCode));
            p.CurrentPageIndex = currentIndex;
            p.pageButtonCount = 15;
            p.PageCount = GetPageCount(RecordCount, pagesize);
            p.ItemCount = RecordCount;
            strpage = p.MainBindpage();
        
        }

        private int GetPageCount(int RecordCount, int TdCount)
        {
            if (RecordCount % TdCount == 0)
            {
                return RecordCount / TdCount;
            }

            return RecordCount / TdCount + 1;
        }
    }
}
