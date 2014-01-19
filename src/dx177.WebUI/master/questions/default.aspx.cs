using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Xml.Linq;
using dx177.Business.Bus;
using dx177.Model;
using dx177.FrameWork;
using dx177.Model.Bus.QueryO;
using System.Text;

namespace dx177.WebUI.master.questions
{
    public partial class _default : System.Web.UI.Page
    {
        public string type
        {
            get
            {
                if (Request.QueryString["type"] != null)
                {
                    return ComSafe.SafeValue(Request.QueryString["type"]);
                }
                return string.Empty;
            }
        }

       
        protected void Page_Load(object sender, EventArgs e)
        {    
            string strTpename = QsttypeBLL.GetInstance().GetQsttypeNameBycode(this.type);
            Hashtable hs = new Hashtable();
            hs.Add("Title_TypeName", strTpename);
            dx177.Business.Bus.CommonBLL.GetInstance().IniPageKeyWord(this.Page, "question", hs);
            this.Repeater1.DataSource = QsttypeBLL.GetInstance().GetQsttypeList(AppContext.JingQuCode);
            this.Repeater1.DataBind();
            ShowData();


        }


        protected void LsHotelList_PagePropertiesChanging(object sender, PagePropertiesChangingEventArgs e)
        {
            DataPager1.SetPageProperties(e.StartRowIndex, e.MaximumRows, false);
            ShowData();
        }

        private void ShowData()
        {
            QuestionsQuery h = new QuestionsQuery();
            h.Qtype = this.type;           
            DataTable dt = QuestionsBLL.GetInstance().SearchData(h);
            lsQuestion.DataSource = dt;
            lsQuestion.DataBind();
            DataPager1.Visible = (dt.Rows.Count > DataPager1.PageSize);
        }


        protected void LsHotelList_ItemDataBound(object sender, ListViewItemEventArgs e)
        {

            if (e.Item.ItemType == ListViewItemType.DataItem)
            {

            }
        }

        protected string GetQuestionURL(string questionType)
        {
            string url = Request.RawUrl;

            foreach (string key in this.Request.QueryString.AllKeys)
            {
                url = UrlUtility.AddOrReplaceParam(url, key, Request.QueryString[key], true);
            }
            
            if (questionType != string.Empty)
            {
                url = UrlUtility.AddOrReplaceParam(url, "type", questionType, true);
            }
            else
            {
                url = UrlUtility.RemoveParam(url, "type");
            }

            if (url.IndexOf(ConstantElements.JingQuPrefix) != -1)
            {
                url = UrlUtility.RemoveParam(url, ConstantElements.QueryStringNameJQ);
            }

            return url;
        }

        protected void DataPager1_PreRender(object sender, EventArgs e)
        {
            DataPager pager = (DataPager)sender;
            new PagingHelper().ProcessPaging(pager, this);
        }

    }
}
