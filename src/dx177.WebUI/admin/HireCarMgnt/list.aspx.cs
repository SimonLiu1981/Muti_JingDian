using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using dx177.Model.Bus;
using dx177.Business.Bus;
using dx177.Model.Bus.QueryO;
using dx177.Business.DictBus;
using dx177.FrameWork;
using dx177.Model;
using CampanyCMS.Model.Bus;

namespace dx177.WebUI.admin.HireCarMgnt
{
    public partial class list :BasePage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Dict.Tag.BindListControl(this.ddlStatus, "OpenStatus", AppContext.CurrentMgtJingQuCode);
                InitData();
            }
        }

        private void InitData()
        {

            btnSearch_Click(null, null);
            
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            HireCarQuery query = new HireCarQuery();
            query.Title = txtName.Text;
            query.OpenStatus = ddlStatus.SelectedValue;
            query.JingQuCode = AppContext.CurrentMgtJingQuCode;

            IList<Hirecar> li = HirecarBLL.GetInstance().Search(query);
            this.dgNews.Data = li;
            this.dgNews.DataBind(); 
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            string url = UrlUtility.AddOrReplaceParam("edit.aspx", "r", Request.RawUrl, true);
            Response.Redirect(url);
        }

        protected void dgNews_ItemCommand(object source, DataGridCommandEventArgs e)
        {

            HirecarBLL bll = HirecarBLL.GetInstance();
            switch (e.CommandName)
            {
                case "Delete":
                    HirecarBLL.GetInstance().RemoveHirecar(e.CommandArgument.ToString());
                    btnSearch_Click(null, null);
                    break;
                case "Modify":
                    string url = UrlUtility.AddOrReplaceParam("edit.aspx", "r", Request.RawUrl, true);
                    url = UrlUtility.AddOrReplaceParam(url, "seqno", e.CommandArgument.ToString(), true);
                    Response.Redirect(url);
                    break;
                default:
                    break;
            }
        }

        protected void dgNews_ItemDataBound(object sender, DataGridItemEventArgs e)
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
                
                Label lblStatus = e.Item.FindControl("lblStatus") as Label;
                lblStatus.Text = Dict.Tag["OpenStatus", lblStatus.Text, 2052];

            }
        }

        protected void bntCreatePage_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgNews.Items.Count; i++)
            {
                CheckBox chkGrid = dgNews.Items[i].FindControl("chkGrid") as CheckBox;
                if (chkGrid.Checked)
                {
                    string seqno = dgNews.Items[i].Cells[0].Text;
                    BuildPageBLL.BuildOnePage("租车", AppContext.CurrentResuser.Username, seqno);
                   
                }

            }

            CommonScript.AlertMessage(this.Page, "已成功");
        }
    }
}
