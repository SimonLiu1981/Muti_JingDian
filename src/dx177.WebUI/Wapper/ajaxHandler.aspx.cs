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
using System.Web.Script.Serialization;
using dx177.Model.Bus;
using dx177.Model;
using dx177.Business.Bus;

namespace dx177.WebUI.Wapper
{
    public partial class ajaxHandler : System.Web.UI.Page
    {
        public string JsonString = string.Empty;
        public string MethodName
        {
            get
            {
                return Request.QueryString["MethodName"];
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            switch (MethodName)
            {
                case "SubmitComment":
                    JsonString = JavaScriptSerializerString(SubmitComment());
                    break;
                case "SubmitQuestion":
                    JsonString = JavaScriptSerializerString(SubmitQuestion());
                    break;
                    
            }
        }

        private object SubmitQuestion()
        {
            string MyAnswer = HttpUtility.UrlDecode(Request["MyAnswer"]);
            string Pguid = HttpUtility.UrlDecode(Request["Pguid"]); 
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

        private int SubmitComment()
        {
            string pguid = HttpUtility.UrlDecode(Request["pguid"]);
            string content = HttpUtility.UrlDecode(Request["content"]);
            string creator = HttpUtility.UrlDecode(Request["creator"]);
            float score1 = float.Parse(HttpUtility.UrlDecode(Request["score1"]));
            float score2 = float.Parse(HttpUtility.UrlDecode(Request["score2"]));
            float score3 = float.Parse(HttpUtility.UrlDecode(Request["score3"]));
            float score4 = float.Parse(HttpUtility.UrlDecode(Request["score4"]));
            

            Comment cs = new Comment();

            cs.Guid = System.Guid.NewGuid().ToString();
            cs.Score1 = decimal.Parse(score1.ToString("0.0"));
            cs.Score2 = decimal.Parse(score2.ToString("0.0"));
            cs.Score3 = decimal.Parse(score3.ToString("0.0"));
            cs.Score4 = decimal.Parse(score4.ToString("0.0"));
            cs.Content = content;
            cs.Creator = AppContext.CurrentResuser != null ? AppContext.CurrentResuser.Username : creator;
            cs.Pguid = pguid;
            CommentBLL.GetInstance().Submit(cs);
            return 1;
             
        }

        /// <summary>
        /// 反射实体变成对应的json格式
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public static string JavaScriptSerializerString(object p)
        {
            JavaScriptSerializer json = new JavaScriptSerializer();
            // 序列化对象为JSON字符串
            return json.Serialize(p);

        }
    }
}
