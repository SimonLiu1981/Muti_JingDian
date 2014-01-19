using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using dx177.Business.DictBus;
using dx177.FrameWork;
using dx177.Model.Bus.QueryO;
using dx177.Model.Bus;
using dx177.Business.Bus;
using dx177.Model;
using CampanyCMS.Model.Bus;

namespace dx177.WebUI.admin.QuestionMgnt
{
    public partial class list : BasePage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Dict.Tag.BindListControl(this.ddlStatus, "QuestionStatus",AppContext.CurrentMgtJingQuCode);
                this.ddlStatus.Items.Insert(0, new ListItem("请选择", ""));
                InitData();
            }
        }

        private void InitData()
        {

            btnSearch_Click(null, null);
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            string url = UrlUtility.AddOrReplaceParam("edit.aspx", "r", Request.RawUrl, true);
            Response.Redirect(url);
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            QuestionsQuery query = new QuestionsQuery();
            query.Title = txtName.Text;
            query.QuestStatus = ddlStatus.SelectedValue;
            query.JingQuCode = AppContext.CurrentMgtJingQuCode;
            this.dgNews.Data= QuestionsBLL.GetInstance().Search(query);
            this.dgNews.DataBind();

        }

        protected void dgNews_ItemCommand(object source, DataGridCommandEventArgs e)
        {
            switch (e.CommandName)
            {
                case "Delete":
                    QuestionsBLL.GetInstance().RemoveQuestions(e.CommandArgument.ToString());
                    btnSearch_Click(null, null);
                    break;
                case "Modify":
                    string url = UrlUtility.AddOrReplaceParam("edit.aspx", "r", Request.RawUrl, true);
                    url = UrlUtility.AddOrReplaceParam(url, "seqno", e.CommandArgument.ToString(), true);
                    Response.Redirect(url);
                    break;
                case "Relate":
                    string url1 = UrlUtility.AddOrReplaceParam("relation.aspx", "r", Request.RawUrl, true);
                    url1 = UrlUtility.AddOrReplaceParam(url1, "seqno", e.CommandArgument.ToString(), true);
                    Response.Redirect(url1);

                    break;
                default:
                    break;
            }
        }

        protected void dgNews_ItemDataBound(object sender, DataGridItemEventArgs e)
        {
            if (e.Item.ItemType == ListItemType.Header)
            {
                CheckBox cbxAll = e.Item.FindControl("chkAll") as CheckBox;
                if (cbxAll != null)
                    cbxAll.Attributes.Add("onclick", "javascript:return SelectAll('" + dgNews.ClientID + "');");
            }

            if (e.Item.ItemType == ListItemType.AlternatingItem ||
                e.Item.ItemType == ListItemType.Item)
            {
               

                Label lblStatus = e.Item.FindControl("lblStatus") as Label;
                lblStatus.Text = Dict.Tag[(QuestionStatus)int.Parse(lblStatus.Text)];
                
                Label lblQtype = e.Item.FindControl("lblQtype") as Label;
               Qsttype q= QsttypeBLL.GetInstance().GetQsttypeByguid(lblQtype.Text);
               if (q != null)
               {
                   lblQtype.Text = q.Title;
               }
              //  lblQtype.Text = Dict.Tag[(QuestionType)int.Parse(lblQtype.Text)];
                
            }

        }

        protected void bntCreatePage_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgNews.Items.Count; i++)
            {
                CheckBox chkGrid = dgNews.Items[i].FindControl("chkGrid") as CheckBox;
                if (chkGrid.Checked)
                {
                    string  seqno =  dgNews.Items[i].Cells[0].Text ;
                    BuildPageBLL.BuildOnePage("问题", AppContext.CurrentResuser.Username , seqno);
                }
            
            }

            CommonScript.AlertMessage(this.Page, "已成功");
        }
    }
}
