using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using dx177.Business.DictBus;
using dx177.FrameWork;
using dx177.Model.Bus;
using dx177.Business.Bus;
using System.Data;
using System.Drawing;
using dx177.Model;

namespace dx177.WebUI.admin.QuestionMgnt
{
    public partial class edit : BasePage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                txtGuid.Value = System.Guid.NewGuid().ToString();
                Dict.Tag.BindListControl(this.rbtStatus, "QuestionStatus", AppContext.CurrentMgtJingQuCode);
                //Dict.Tag.BindListControl(this.rbtQuestType, "QuestionType");
                rbtStatus.SelectedValue = QuestionStatus.WaitSolved.ToString("d");

                tbMyReply.Visible = false;
                InitData();
            }

            txtViewtimes.Attributes.Add("viewtimes_set_guid", txtGuid.Value);
            
        }

        public string Seqno
        {
            get
            {
                if (Request.QueryString["seqno"] == null)
                {
                    return "";
                }
                return Request.QueryString["seqno"];
            }
        }
        /// <summary>
        /// 初始化数据
        /// </summary>
        private void InitData()
        {
            if (Seqno != string.Empty)
            {
                Questions rest = QuestionsBLL.GetInstance().Get(new Questions.Key(int.Parse(Seqno)));
                if (rest != null)
                {
                    tbMyReply.Visible = true;
                    fckContent.Value = rest.Content;
                    txtTitle.Text = rest.Title;
                    txtGuid.Value = rest.Guid;

                    rbtStatus.SelectedValue = rest.Status.ToString();
                    txtCreator.Text = rest.Creator;
                    txtViewtimes.Text = rest.Viewtimes.ToString();
                    txtClassLevel2.Value = rest.Qtype;
                    //绑定子答复列表
                    BindSubReplyList(txtGuid.Value);
                }
                
            }
            else
            {
                txtCreator.Text = AppContext.CurrentResuser.Username;
            }
        }

        private void BindSubReplyList(string guid)
        {

            this.dgNews.Data = ReplyquestionBLL.GetInstance().GetListByGuid(guid);
            this.dgNews.DataBind();
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            Questions rest =new Questions();

            if (Seqno != string.Empty)
            {
                rest = QuestionsBLL.GetInstance().Get(new Questions.Key(int.Parse(Seqno)));
            }
            else
            {
                if (AppContext.CurrentResuser != null)
                {
                    rest.Creator = AppContext.CurrentResuser.Username;
                }
            }
            rest.Content = fckContent.Value;
            rest.Title = txtTitle.Text;
            rest.Status = int.Parse(rbtStatus.SelectedValue);
            rest.Guid = txtGuid.Value;
            rest.Qtype = txtClassLevel2.Value ;
            rest.Creator = txtCreator.Text;
            rest.Jingqucode = AppContext.CurrentMgtJingQuCode;
            rest.Viewtimes = int.Parse(txtViewtimes.Text.Trim() != string.Empty ? txtViewtimes.Text.Trim() : "0");
            QuestionsBLL.GetInstance().Submit(rest);
            btnReturn_Click(null, null);
        }

        protected void btnReturn_Click(object sender, EventArgs e)
        {
            Response.Redirect(Request.QueryString["r"]);
        }

        protected void dgNews_ItemDataBound(object sender, DataGridItemEventArgs e)
        {
            if (e.Item.ItemType == ListItemType.AlternatingItem ||
                e.Item.ItemType == ListItemType.Item)
            {
                DataRowView dr = e.Item.DataItem as DataRowView;
                if (dr["isright"].ToString() == "1")
                {
                    e.Item.ForeColor = Color.FromArgb(0x646AAD30);
                }

            }
        }

        protected void dgNews_ItemCommand(object source, DataGridCommandEventArgs e)
        {
            switch (e.CommandName)
            {
                case "Delete":
                    Replyquestion quest = ReplyquestionBLL.GetInstance().Get(new Replyquestion.Key(int.Parse(e.CommandArgument.ToString())));
                    ReplyquestionBLL.GetInstance().Delete(quest);
                    QuestionsBLL.GetInstance().UpdateStatus(quest.Pguid);
                    BindSubReplyList(txtGuid.Value);
                    break;
                default:
                    break;
            }
        }
    }
}
