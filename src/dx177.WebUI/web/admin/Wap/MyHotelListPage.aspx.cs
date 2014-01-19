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
using dx177.Model;
using dx177.FrameWork;
using dx177.Business.Bus;
using dx177.Model.Bus;

namespace dx177.WebUI.web.admin.Wap
{
    public partial class MyHotelListPage : ResUserBasePage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                InitDataSearch();
            }
        }


        private void InitDataSearch()
        {
            DataTable dt = HotelBLL.GetInstance().GetMyHotelList(AppContext.CurrentResuser.Username);
            this.lvHotelList.DataSource = dt;
            this.lvHotelList.DataBind();
        }


        protected void DataPager1_PreRender(object sender, EventArgs e)
        {
            DataPager pager = (DataPager)sender;
            pager.Controls.Clear();
            int count = pager.TotalRowCount;
            int pageSize = pager.PageSize;
            int pagesCount = count / pageSize + (count % pageSize == 0 ? 0 : 1);
            int pageSelected = pager.StartRowIndex / pageSize + 1;
            string pret = string.Format("<span class='page_up link01'><A title='上一页' href=\"{0}\">上一页</a></span>", GetUrl(pageSelected - 1));
            string next = string.Format("<span class='page_down link01'><A title='下一页' href=\"{0}\">下一页</a></span>", GetUrl(pageSelected + 1));
            if (pagesCount > 1)
            {
                if (pageSelected == 1)
                {
                    pret = "";
                }
                if (pageSelected == pagesCount)
                {
                    next = "";
                }
                string Res = "";

                for (int i = 1; i <= pagesCount; ++i)
                {
                    Res += GetPageLink(i, pageSelected);
                }
                Literal ltt = new Literal();
                ltt.Text = pret + Res + next;
                pager.Controls.Add(ltt);
            }

        }
        private string GetUrl(int page)
        {
            string url = Request.RawUrl;

            url = UrlUtility.AddOrReplaceParam(url, "p", page.ToString(), true);

            return url;
        }

        private string GetPageLink(int i, int pageSelected)
        {
            string startstr = "";
            if (pageSelected != i)
            {
                startstr += string.Format("<a title=\"第{0}页\" href=\"{0}\">{1}</a>", GetUrl(i), i);
            }
            else
            {
                startstr += string.Format("<span class='current'>{0}</span>", i);
            }
            return startstr;
        }

        protected void lvHotelList_PagePropertiesChanging(object sender, PagePropertiesChangingEventArgs e)
        {
            DataPager1.SetPageProperties(e.StartRowIndex, e.MaximumRows, false);
            InitDataSearch();
        }

        protected void bntDelete_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lvHotelList.Items.Count; i++)
            {
                CheckBox chk1 = lvHotelList.Items[i].FindControl("chk") as CheckBox;
                if (chk1 != null && chk1.Checked )
                {
                    Label lbSeqno = lvHotelList.Items[i].FindControl("lbSeqno") as Label;
                    int seqno = 0;
                    if (lbSeqno != null && lbSeqno.Text != string.Empty)
                    {
                        Myhotellist m=new Myhotellist() ;
                        m.Seqno =int.Parse(lbSeqno.Text) ;
                        MyhotellistBLL.GetInstance().Delete(m);
                    }
                }
            }
            InitDataSearch();
        }

        protected void bntSave_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lvHotelList.Items.Count; i++)
            {
                CheckBox chk1 = lvHotelList.Items[i].FindControl("chk") as CheckBox;
                if (chk1 != null && chk1.Checked)
                {
                    Label lbguid = lvHotelList.Items[i].FindControl("lbguid") as Label;
                    TextBox txtShowindex = lvHotelList.Items[i].FindControl("txtShowIndex") as TextBox;
                    Myhotellist m =new Myhotellist() ;
                    m.Pguid =lbguid.Text  ;
                    m.Showindex = txtShowindex.Text==string.Empty ?0:int.Parse(txtShowindex.Text ) ;
                    m.Creator = AppContext.CurrentResuser.Username;
                    MyhotellistBLL.GetInstance().Subimt(m);
                }
            }

            InitDataSearch();
        }

        protected void chk_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < lvHotelList.Items.Count; i++)
            {
                CheckBox chk1 = lvHotelList.Items[i].FindControl("chk") as CheckBox;
                if (chk1 != null)
                {
                    chk1.Checked = chk.Checked;
                }
            }
        }

        
    }
}
