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
using dx177.Model;

namespace dx177.WebUI.web.admin
{
    public partial class member_editqueston : ResUserBasePage
    {
        public string Seqno
        {
            get
            {
                return Request.QueryString["seqno"];
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {            
            if (!IsPostBack)
            {
                txtGuid.Value = System.Guid.NewGuid().ToString();

                Dict.Tag.BindListControl(this.rbtQuestionStatus, "QuestionStatus", AppContext.JingQuCode);
                //ict.Tag.BindListControl(this.rbtQuestionType, "QuestionType");
                this.rbtQuestionType.DataSource = QsttypeBLL.GetInstance().GetQsttypeList(string.Empty);
                rbtQuestionType.DataTextField = "title";
                rbtQuestionType.DataValueField = "guid";
                this.rbtQuestionType.DataBind();
                rbtQuestionStatus.SelectedValue = QuestionStatus.WaitSolved.ToString("d");
                rbtQuestionStatus.Enabled = false;
               
                InitData();
            }
        }
        /// <summary>
        /// 初始化数据
        /// </summary>
        private void InitData()
        {
            if (!string.IsNullOrEmpty(Seqno))
            {
                Questions q = QuestionsBLL.GetInstance().Get(new Questions.Key(int.Parse(Seqno)));
                txtTitle.Text = q.Title;
                txtContent.Text = q.Content;
                rbtQuestionStatus.SelectedValue = q.Status.ToString();
                rbtQuestionType.SelectedValue = q.Qtype;
                txtGuid.Value = q.Guid;
                //绑定子答复列表
                BindSubReplyList(txtGuid.Value);
            }
        }

        private void BindSubReplyList(string guid)
        {

            this.lvRQestions.DataSource = ReplyquestionBLL.GetInstance().GetListByGuid(guid);
            this.lvRQestions.DataBind();
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            Questions rest = new Questions();

            if (!string.IsNullOrEmpty(Seqno))
            {
                rest = QuestionsBLL.GetInstance().Get(new Questions.Key(int.Parse(Seqno)));
            }
            else
            {
                rest.Creator = AppContext.CurrentResuser == null ? "匿名用户" : AppContext.CurrentResuser.Username;
            }
            rest.Content = txtContent.Text;
            rest.Title = txtTitle.Text;
            rest.Status = int.Parse(rbtQuestionStatus.SelectedValue);
            rest.Guid = txtGuid.Value;
            rest.Qtype = rbtQuestionType.SelectedValue;
            QuestionsBLL.GetInstance().Submit(rest);
             
            btnBlack_Click(null, null);
        }

        protected void lvRQestions_PagePropertiesChanging(object sender, PagePropertiesChangingEventArgs e)
        {

        }

        protected void btnBlack_Click(object sender, EventArgs e)
        {
            if (Request.QueryString["r"] != null)
            {
                Response.Redirect(Request.QueryString["r"]);
            }
            else
            {
                Response.Redirect("/member-myquestons.aspx");
            }
        }

        protected void lvRQestions_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            switch (e.CommandName)
            { 
                case "SetRight":
                    Replyquestion rest = new Replyquestion();
                    if (int.Parse(e.CommandArgument.ToString()) > 0)
                    {
                        rest = ReplyquestionBLL.GetInstance().Get(new Replyquestion.Key(int.Parse(e.CommandArgument.ToString())));
                    }
                    rest.Isright = rest.Isright == 1 ? 0 : 1;
                    ReplyquestionBLL.GetInstance().Submit(rest);
                    InitData();                    
                    break;
            }
        }

        protected void lvRQestions_ItemDataBound(object sender, ListViewItemEventArgs e)
        {
            if (e.Item.ItemType == ListViewItemType.DataItem)
            {
                LinkButton lbtnSetRight = e.Item.FindControl("lbtnSetRight") as LinkButton;
                Replyquestion rest = ReplyquestionBLL.GetInstance().Get(new Replyquestion.Key(int.Parse(lbtnSetRight.CommandArgument.ToString())));
                lbtnSetRight.Text = rest.Isright == 1 ? "是" : "否";
                lbtnSetRight.OnClientClick = rest.Isright == 1 ? "return confirm('你确认取消此最佳答复吗？');" : "return confirm('你确认设定为最佳答复吗？');";
               
            }
        }
    }
}
