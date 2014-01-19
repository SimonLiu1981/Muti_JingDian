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
using dx177.Model.Bus;
using dx177.Business.Bus;
using dx177.Business.DictBus;
using System.Collections.Generic;
using dx177.FrameWork;
using dx177.Model;

namespace dx177.WebUI.web.questions
{
    public partial class Qdetail : System.Web.UI.Page
    {

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


        public string strGoodQuetion = "";
        public string AllQuestion = "";
        public Questions q = new Questions();
        public string strQuestion = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            ((defaultMaster)Page.Master).NavId = "questions";
            
            if (!IsPostBack)
            {
                txtMyAnswer.Value = string.Empty;
            }
            IniData();
            //string[] s = new string[] { className, className, className };
            dx177.Business.Bus.CommonBLL.GetInstance().IniPageKeyWord(this.Page, "questionsdetail", new { Title = q.Title, Type =Dict.Tag["QuestionType", q.Qtype, 2052] });
 

        }

        private void IniData()
        {
            
            q = QuestionsBLL.GetInstance().Get(new Questions.Key(this.Seqno));
            AddViewTimes(q);
            strQuestion = Dict.Tag["QuestionType", q.Qtype, 2052];
            Replyquestion r = ReplyquestionBLL.GetInstance().GetGoodQuestionByGuid(q.Guid);
            if (r != null)
            {
                string s = @" <h3 class='question_hright'><span class='question_cright'>采纳意见</span></h3>
                              <ul class='question_rightul'><li class='bring'><span style='color: #000'>回答者：{0} </span><span style='padding: 0 5px;color: #000'>  </span><span style='padding: 0 5px; color: #000'>时间：{1}</span> </li>
                              <li class='zctw'>{2}</li></ul>";
                strGoodQuetion = string.Format(s, r.Creator, r.CreateDate.ToString("yyyy-MM-dd"), r.Content);
            }

            IList<Replyquestion> il = ReplyquestionBLL.GetInstance().GetListByGuid(q.Guid);
            rpList.DataSource = il;
            rpList.DataBind();
        }

        public int AddViewTimes(Questions Rest)
        {
            string ip = Request.ServerVariables.Get("Remote_Addr").ToString();
            if (!DiggBLL.GetInstance().ExistsIp(Rest.Guid, ip, DiggType.ViewTimes))
            {
                Rest.Viewtimes++;
                QuestionsBLL.GetInstance().Update(Rest);
                return 1;
            }
            else
            {
                return 0;
            }
        }


         
        public string SubmitQuestion(string MyAnswer, string Pguid )
        {
            Replyquestion r = new Replyquestion();
            r.Content = MyAnswer;
            r.CreateDate = DateTime.Now;
            r.Creator = "";
            r.Guid = System.Guid.NewGuid().ToString();
            r.Pguid = Pguid;
            r.Creator = AppContext.CurrentResuser != null ? AppContext.CurrentResuser.Username : "匿名用户";
            ReplyquestionBLL.GetInstance().Submit(r);
            return "1";
        }


        protected void btnAnswer_Click(object sender, EventArgs e)
        {
            Replyquestion r = new Replyquestion();
            r.Content = txtMyAnswer.Value;
            r.CreateDate = DateTime.Now;
            r.Creator = "";
            r.Guid = System.Guid.NewGuid().ToString();
            r.Pguid = q.Guid;
            r.Creator = AppContext.CurrentResuser != null ? AppContext.CurrentResuser.Username : "匿名用户";
            ReplyquestionBLL.GetInstance().Submit(r);
            CommonScript.AlertMessage(this.Page, "提交成功！");
            txtMyAnswer.Value = string.Empty;
            IniData();
        }
    }
}
