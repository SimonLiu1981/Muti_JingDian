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

namespace dx177.WebUI.Wapper.Ques
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

        private string qtype
        {
            get
            {
                if (Request.QueryString["qtype"] != null)
                {
                    return ComSafe.SafeValue(Request.QueryString["qtype"]);
                }
                return string.Empty;
            }
        }

        private string JqCode
        {
            get
            {
                if (Request.QueryString["JqCode"] != null)
                {
                    return ComSafe.SafeValue(Request.QueryString["JqCode"]);
                }
                return string.Empty;
            }
        }
        int pagesize = 15;
        public string strpage = "";

        protected void Page_Load(object sender, EventArgs e)
        {
            string strjqname = JingqusBLL.GetInstance().GetNameByJingqucode(this.JqCode); ;
            string strTpename = QsttypeBLL.GetInstance().GetQsttypeNameBycode(this.qtype);
            Hashtable hs = new Hashtable();
            hs.Add("Title_TypeName", strjqname + strTpename);
            dx177.Business.Bus.CommonBLL.GetInstance().IniPageKeyWord(this.Page, "question", hs);


            ShowData();
        }

        private void ShowData()
        {
            DataTable dt = QuestionsBLL.GetInstance().GetFont_Table(this.qtype, this.JqCode, this.currentIndex, pagesize);
            int RCount = QuestionsBLL.GetInstance().GetFont_TableRowCount(this.qtype, this.JqCode);
            RptData.DataSource = dt;
            RptData.DataBind();
            PageButton(RCount);
        }

        private void PageButton(int RecordCount)
        {
            PageButton p = new PageButton(@"\Templates\xml\hotel\sBUTTON.XML", string.Format("list.aspx?typeCode={0}&JqCode={1}&p=", this.qtype, this.JqCode));
            p.CurrentPageIndex = currentIndex;
            p.pageButtonCount = 10;
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
