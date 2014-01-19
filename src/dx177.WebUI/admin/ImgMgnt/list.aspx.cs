using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using dx177.Business.Bus;
using dx177.Model.Bus.QueryO;
using System.Data;
using dx177.Model;

namespace dx177.WebUI.admin.ImgMgnt
{
    public partial class list :BasePage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                ShowData();
            }
        }

        private void ShowData()
        {
            PicturelistQuery query = new PicturelistQuery();
            query.Title = txtName.Text;
            query.hasUsed = rbtList1.SelectedValue;
            query.JingQuCode = AppContext.CurrentMgtJingQuCode;
            dgNews.Data = PicturelistBLL.GetInstance().Search(query);
            dgNews.DataBind();
        }

        protected void dgNews_ItemCommand(object source, System.Web.UI.WebControls.DataGridCommandEventArgs e)
        {
            switch (e.CommandName)
            {
                case "Delete":

                    PicturelistBLL.GetInstance().Delete(int.Parse(e.CommandArgument.ToString()));
                    ShowData();
                    break;
                default:
                    
                    break;
            }
        }
        protected void dgNews_ItemDataBound(object sender, System.Web.UI.WebControls.DataGridItemEventArgs e)
        {
            if (e.Item.ItemType == ListItemType.Header)
            {
                CheckBox cbxAll = e.Item.FindControl("cbxAll") as CheckBox;
                if (cbxAll != null)
                    cbxAll.Attributes.Add("onclick", "javascript:return SelectAll('" + dgNews.ClientID + "');");
            }

            if (e.Item.ItemType == ListItemType.AlternatingItem ||
                e.Item.ItemType == ListItemType.Item)
            {

                DataRowView dr = e.Item.DataItem as DataRowView;

                HiddenField txtImgPath = e.Item.FindControl("txtImgPath") as HiddenField;
                HyperLink HyperLink1 = e.Item.FindControl("HyperLink1") as HyperLink;
                
                Label lblUsed = e.Item.FindControl("lblUsed") as Label;
                HyperLink1.ImageUrl = dr["smallimgfile"].ToString();
                HyperLink1.Attributes.Add("title", dr["title"].ToString());
                HyperLink1.Attributes.Add("rel", "showGrop");
                HyperLink1.NavigateUrl = dr["bigimgfile"].ToString();
                lblUsed.Text =DateTime.Parse(dr["createdate"].ToString()) > new DateTime(1900, 1, 1) ? "被用": "未用";               

            }
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            ShowData();
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            Response.Redirect("PiclinkPage.aspx");
        }

        protected void btnDel_Click(object sender, EventArgs e)
        {
            foreach (DataGridItem gvRow in dgNews.Items)
            {
                if (((CheckBox)(gvRow.Cells[0].FindControl("cbItem"))).Checked)
                {
                    HiddenField txtSeqno = gvRow.FindControl("txtSeqno") as HiddenField;

                    PicturelistBLL.GetInstance().Delete(int.Parse(txtSeqno.Value.ToString()));

                }
            }
            btnSearch_Click(null, null);
        }
    }
}
