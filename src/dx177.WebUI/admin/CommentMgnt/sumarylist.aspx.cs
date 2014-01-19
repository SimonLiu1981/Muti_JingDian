using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using dx177.Model.Bus.QueryO;
using dx177.Business.Bus;
using System.Data;
using dx177.FrameWork;
using dx177.Model;

namespace dx177.WebUI.admin.CommentMgnt
{
    public partial class sumarylist : BasePage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                InitData();
            }
        }
        /// <summary>
        /// 初始化数据
        /// </summary>
        private void InitData()
        {
            btnSearch_Click(null, null);
        }


        protected void dgNews_ItemCommand(object source, System.Web.UI.WebControls.DataGridCommandEventArgs e)
        {
            switch (e.CommandName)
            {
                case "Delete":

                   
                    break;
                default:

                    break;
            }
        }
        protected void dgNews_ItemDataBound(object sender, System.Web.UI.WebControls.DataGridItemEventArgs e)
        {
             

            if (e.Item.ItemType == ListItemType.AlternatingItem ||
                e.Item.ItemType == ListItemType.Item)
            {

                DataRowView dr = e.Item.DataItem as DataRowView;
                HyperLink lnkTitle = e.Item.FindControl("lnkTitle") as HyperLink;
                HyperLink lnkAllCount = e.Item.FindControl("lnkAllCount") as HyperLink;
                HyperLink lnkAllCount1 = e.Item.FindControl("lnkAllCount1") as HyperLink;
                HyperLink lnkNoReplyCount = e.Item.FindControl("lnkNoReplyCount") as HyperLink;
                HyperLink lnkNewCount = e.Item.FindControl("lnkNewCount") as HyperLink;
                string url = UrlUtility.AddOrReplaceParam("viewcomments.aspx", "r", Request.RawUrl, true);
                url = UrlUtility.AddOrReplaceParam(url, "type", dr["objType"].ToString(), true);
                url = UrlUtility.AddOrReplaceParam(url, "guid", dr["guid"].ToString(), true);

                lnkTitle.NavigateUrl = url;
                lnkAllCount.NavigateUrl = url;
                lnkAllCount1.NavigateUrl = url;
                string url1 = UrlUtility.AddOrReplaceParam(url, "isnew", "1", true);
                lnkNewCount.NavigateUrl = url1;
                string url2 = UrlUtility.AddOrReplaceParam(url, "isnoreply", "1", true);
                lnkNoReplyCount.NavigateUrl = url2;


                    
            }
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {

            CommentQuery1 query = new CommentQuery1();
            query.IsNew = cbxIsnew.Checked ? "1" : "";
            query.IsNoReply = cbxIsnoreply.Checked ? "1" : "";
            query.ObjTitle = txtTitle.Text;
            this.dgNews.Data = CommentBLL.GetInstance().SearchSummaryCommont(query, AppContext.CurrentMgtJingQuCode);
            this.dgNews.DataBind();
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
           
        }

    }
}
