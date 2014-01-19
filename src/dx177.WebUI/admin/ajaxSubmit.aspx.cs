using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using dx177.FrameWork;
using dx177.Model.Bus;
using dx177.Business.Bus;
using dx177.Business.DictBus;
using dx177.Model;

namespace dx177.WebUI.admin
{
    public partial class ajaxSubmit : System.Web.UI.Page
    {
        public string MethodName
        {
            get
            {
                return Request.QueryString["MethodName"];
            }
        }


        protected void Page_Load(object sender, EventArgs e)
        {
            string JsonString = "";
            switch (MethodName)
            {
                case "ReplyQuestionSubmit"://获得当前登录用户的信息
                    JsonString = CommonUnitl.JavaScriptSerializerString(ReplyQuestionSubmit());
                    break;

                case "SyscodemapSubmit":
                    JsonString = CommonUnitl.JavaScriptSerializerString(SyscodemapSubmit());
                    break;
            }

            this.Response.Clear();
            this.Response.ContentEncoding = Encoding.UTF8;
            this.Response.ContentType = "application/json";            
            this.Response.Write(JsonString);
            this.Response.Flush();
            this.Response.End();
        }

        private bool SyscodemapSubmit()
        {
            Syscodemap rest = new Syscodemap();
            int seqno = int.Parse(Request["seqno"].ToString());
            if (seqno > 0)
            {
                rest = SyscodemapBLL.GetInstance().Get(new Syscodemap.Key(seqno));
            }
            string Name = HttpUtility.UrlDecode(Request["Name"].ToString());
            rest.Name = Name;
            string Type = HttpUtility.UrlDecode(Request["Type"].ToString());
            rest.Type = Type;
            string TypeName = HttpUtility.UrlDecode(Request["TypeName"].ToString());
            rest.Typename = TypeName;
            string val = HttpUtility.UrlDecode(Request["val"].ToString());
            rest.Val = val;
            SyscodemapBLL.GetInstance().Submit(rest, AppContext.CurrentMgtJingQuCode);
            return true;
        }

        private bool ReplyQuestionSubmit()
        {
            try
            {
                Replyquestion rest = new Replyquestion();
                int seqno = int.Parse(Request["seqno"].ToString());

                if (seqno > 0)
                {
                    rest = ReplyquestionBLL.GetInstance().Get(new Replyquestion.Key(seqno));
                }
                else
                {
                    rest.Guid = System.Guid.NewGuid().ToString();
                }
                bool isRight = Boolean.Parse(Request["isRight"].ToString());
                string content = HttpUtility.UrlDecode(Request["content"].ToString());
                rest.Isright = isRight ? 1 : 0;
                rest.Content = content;
                string pguid = Request["pguid"].ToString();
                rest.Pguid = pguid;
                ReplyquestionBLL.GetInstance().Submit(rest);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
