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
using dx177.Model.Bus;
using dx177.Business.Bus;
using dx177.Model.Bus.QueryO;
using dx177.Model;

namespace dx177.WebUI.Wapper.comm
{
    public partial class comments : System.Web.UI.Page
    {
        protected string CommentTitle = string.Empty;

        protected string ComType
        {
            get
            {
                return Request["ct"];
            }
        }

        protected string Pguid
        {
            get
            {
                return Request["pguid"];
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Pguid))
            {
                Response.Redirect("~/");
                return;
            }
            if (Request["email"] != null)
            {
                //提交点评
                Comment c = new Comment();
                c.Email = Request["email"];
                c.Phone = Request["phone"];
                c.Content = Request["Content"];
                c.Creator = AppContext.CurrentResuser != null ? AppContext.CurrentResuser.Username : "匿名用户";
                c.CreateDate = DateTime.Now;
                c.Isshow = 0;
                c.Isnew = 1;
                c.Pguid = Pguid;
                c.Guid = StringUtil.getGuid();
                CommentBLL.GetInstance().Submit(c);
                CommonScript.AlertMessage(this.Page, "您的点评提交成功，我门会及时处理！");
            }

            if (ComType == CommentType.饭店.ToString("d"))
            {
                Restaurant res = RestaurantBLL.GetInstance().GetRestaurantByGuid(this.Pguid);
                this.CommentTitle = "[饭店]_" + res.Title;
            }
            else if (ComType == CommentType.景点.ToString("d"))
            {
                Sites res = SitesBLL.GetInstance().GetByGuid(Pguid);
                this.CommentTitle = "[景点]_" + res.Title;
            }
            else if (ComType == CommentType.景区.ToString("d"))
            {
                Jingqus res = JingqusBLL.GetInstance().GetByGuid(Pguid);
                this.CommentTitle = "[景区]_" + res.Jingquname;
            }
            else if (ComType == CommentType.酒店.ToString("d"))
            {
                Hotel hh = HotelBLL.GetInstance().GetHotelByGuid(Pguid);
                this.CommentTitle = "[酒店]_" + hh.Name;
            }
            else if (ComType == CommentType.新闻.ToString("d"))
            {
                News res = NewsBLL.GetInstance().GetByGuid(Pguid);
                this.CommentTitle = "[新闻]_" + res.Title;
            }

            Hashtable hs = new Hashtable();
            hs.Add("Title", CommentTitle);
            dx177.Business.Bus.CommonBLL.GetInstance().IniPageKeyWord(this.Page, "comment", hs);

            ShowData();

        }
        protected void LsHotelList_PagePropertiesChanging(object sender, PagePropertiesChangingEventArgs e)
        {

            DataPager1.SetPageProperties(e.StartRowIndex, e.MaximumRows, false);
            ShowData();
        }

        private void ShowData()
        {
            CommentQuery query = new CommentQuery();
            query.pguid = Pguid;
            query.IsShow = "1";

            this.LsHotelList.DataSource = CommentBLL.GetInstance().SearchComment(query);
            this.LsHotelList.DataBind();

        }


        protected void LsHotelList_ItemDataBound(object sender, ListViewItemEventArgs e)
        {
            if (e.Item.ItemType == ListViewItemType.DataItem)
            {
                //// txtGuid.Value
                //HtmlInputHidden txtGuid = e.Item.FindControl("txtGuid") as HtmlInputHidden;
                //RoomQuery r = new RoomQuery();
                //r.PGuid = txtGuid.Value;
                //Repeater RpRoom = e.Item.FindControl("RpRoom") as Repeater;
                //RpRoom.DataSource = RoomBLL.GetInstance().GetRoom(r);
                //RpRoom.DataBind();

                ////BaseDictTagBLL.GetInstance().GetDictTag("HoteInst");
                //////lbHotelnst
            }
        }

        protected void DataPager1_PreRender(object sender, EventArgs e)
        {
            DataPager pager = (DataPager)sender;
            new PagingHelper().ProcessPaging(pager, this);
        }
    }
}
