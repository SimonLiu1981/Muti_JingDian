using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using dx177.Model.Bus;
using dx177.Model.Bus.QueryO;
using System.Data;
using dx177.Business.Bus;
using dx177.FrameWork;
using dx177.Business.DictBus;

namespace dx177.WebUI.web.hotel
{
    public partial class pics : System.Web.UI.Page
    {
        public Hotel h = new Hotel();
        public int Seqno
        {
            get
            {
                if (Request.QueryString["Seqno"] != null)
                {
                    return int.Parse(Request.QueryString["Seqno"]);
                }
                return 0;
            }
        }
        public string CommentCount = "";

        protected void Page_Load(object sender, EventArgs e)
        {
            ((defaultMaster)Page.Master).NavId = "hotel";
            IniData();
            if (!Page.IsPostBack)
            {
                ShowPicList();
            }
            string area = Dict.Tag["Area", h.Area , 2052];
            string HotelType = Dict.Tag["HotelType", h.Hoteltype , 2052];
            
            dx177.Business.Bus.CommonBLL.GetInstance().IniPageKeyWord(this.Page, "hotelpics", new { Name = h.Name, Area = area, HotelType = HotelType });
        }

        private void Room(string Guid)
        {
            RoomQuery r = new RoomQuery();
            r.PGuid = Guid;
            DataTable dt = RoomBLL.GetInstance().GetRoom(r);
            rpRoom.DataSource = dt;
            rpRoom.DataBind();
        }

        private void ShowPicList()
        {
            DataTable dt=HotelBLL.GetInstance().GetHotePicList(this.Seqno);
            lsPicList.DataSource = dt;
            lsPicList.DataBind();
            DataPager1.Visible = (dt.Rows.Count > DataPager1.PageSize);

        }

        private void IniData()
        {
            h = HotelBLL.GetInstance().Get(new Hotel.Key(this.Seqno));
            Room(h.Guid);
            CommentCount= CommentBLL.GetInstance().GetCommentCount(h.Guid);
        }
        
        protected void lsPicList_PagePropertiesChanging(object sender, PagePropertiesChangingEventArgs e)
        {
            DataPager1.SetPageProperties(e.StartRowIndex, e.MaximumRows, false);
            ShowPicList();
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

        private string GetPageLink(int page, int pageSelected)
        {
            string startstr = "";
            if (pageSelected != page)
            {
                startstr += string.Format("<a title=\"第{0}页\" href=\"{1}\">{0}</a>", page, GetUrl(page));
            }
            else
            {
                startstr += string.Format("<span class='current'>{0}</span>", page);
            }
            return startstr;
        }
        private string GetUrl(int page)
        {
            string url = Request.RawUrl;
            foreach (string key in this.Request.QueryString.AllKeys)
            {
                url = UrlUtility.AddOrReplaceParam(url, key, Request.QueryString[key], true);
            }
            url = UrlUtility.AddOrReplaceParam(url, "p", page.ToString(), true);
            url = UrlUtility.RemoveParam(url, "seqno");
            return url;
        }
    }
}
