using System;
using System.Collections;
using System.Collections.Generic;
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
using dx177.WebUI.Improt;
using System.Xml.Serialization;
using System.IO;
using System.Text;
using dx177.Model.Bus;
using dx177.Business.Bus;
using dx177.FrameWork;
using CampanyCMS.Model.Bus;
using System.Xml;

namespace dx177.WebUI.ImportTool
{
    public partial class imQuestions : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private void SaveQuestion(string xmlString)
        {
            XmlSerializer mySerializer = new XmlSerializer(typeof(ImportQuestions));

            byte[] bstr = Encoding.UTF8.GetBytes(xmlString);
            MemoryStream ms = new MemoryStream(bstr);
            ImportQuestions iim = (ImportQuestions)mySerializer.Deserialize(ms);

            string fileName = "QuestionSetting.xml";
            string patch = Server.MapPath("/");
            XmlDocument xd = new XmlDocument();
            xd.Load(Path.Combine(patch, fileName));

            foreach (AddQuestion item in iim.AddQuestionCollection)
            {
                if (JingqusBLL.GetInstance().GetEntityByJingqucode(item.JingQuCode) == null || string.IsNullOrEmpty(item.Title))
                {
                    continue;
                }

                if (JingqusBLL.GetInstance().FindByTitle(item.Title))
                {
                    continue;
                }
                string Createtors = GetxmlValue(xd, "Createtor");
                string Answer = GetxmlValue(xd, "Answer");


                int SpanDays = int.Parse(GetxmlValue(xd, "Day"));

                DateTime DCreateDate = CreateDate(-SpanDays);
                DateTime DCreateDate2 = GetNextDate(DCreateDate);

                Questions q = new Questions();
                q.Title = item.Title;
                q.Content = item.Contents.Replace("\r\n", "<br/>");
                q.Creator = Createtors;



                q.Jingqucode = item.JingQuCode;
                q.Qtype = QsttypeBLL.GetInstance().GetQstGuid(item.Qtype.ToString());
                q.Guid = StringUtil.getGuid();
                q.CreateDate = DateTime.Now;
                if (item.__CreateDateSpecified)
                {
                    q.CreateDate = item.CreateDate;
                }
                else
                {
                    q.CreateDate = DCreateDate;
                }
                QuestionsBLL.GetInstance().Insert(q);


                bool hasRight = false;
                foreach (Reply re in item.Replys.ReplyCollection)
                {
                    DCreateDate2 = GetNextDate(DCreateDate2);
                    Replyquestion r = new Replyquestion();
                    r.Guid = StringUtil.getGuid();
                    r.Content = re.ReplyContents;
                    if (re.IsRight && !hasRight)
                    {
                        r.Isright = re.IsRight ? 1 : 0;
                        hasRight = true;
                    }
                    r.Creator = GetxmlValue(xd, "Answer");
                    r.Pguid = q.Guid;
                    r.CreateDate = DateTime.Now;
                    if (re.__ReplyDateSpecified)
                    {
                        r.CreateDate = re.__ReplyDate;
                    }
                    else
                    {
                        r.CreateDate = DCreateDate2;
                    }
                    ReplyquestionBLL.GetInstance().Insert(r);

                }
                if (item.Replys.ReplyCollection.Count > 0)
                {
                    q.Status = 1;
                }
                else
                {
                    q.Status = 0;
                }
                if (hasRight)
                {
                    q.Status = 2;
                }
                QuestionsBLL.GetInstance().Update(q);
                try
                {
                    BuildPageBLL.BuildOnePage("问题", q.Creator, q.Seqno.ToString());
                }
                catch (Exception ex)
                {
                    CommonScript.AlertMessage(this.Page, "失败");
                    return;
                }

            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string xmlString = TextBox1.Text.Trim();
            
           string[] ArrxmlString =xmlString.Split(new char[]{'@','|','@'}) ;
           foreach (string s in ArrxmlString)
           {
               if (!string.IsNullOrEmpty(s))
                       SaveQuestion(s);
           }

            CommonScript.AlertMessage(this.Page, "已成功");
           // TextBox1.Text = string.Empty;
        }


       
        private string GetxmlValue(XmlDocument xd ,string TagName)
        {
            XmlNodeList xmlAnswers = xd.GetElementsByTagName(TagName);
            Random ra = new Random(unchecked((int)DateTime.Now.Ticks));
            int rnum = ra.Next(0, xmlAnswers.Count);
            return  xmlAnswers[rnum].Attributes["value"].Value.ToString(); 
        }


       /// <summary>
       /// 创建时间
       /// </summary>
       /// <param name="v"></param>
       /// <returns></returns>
        private DateTime CreateDate(int v)
        {
            string s = DateTime.Now.AddDays(v).ToString("yyyy-MM-dd");
            s = s + " " + GetHhMmSs();

            return DateTime.Parse(s);
        }

        /// <summary>
        /// 获得下一个时间
        /// </summary>
        /// <param name="d"></param>
        /// <returns></returns>
        private DateTime GetNextDate(DateTime d)
        {
            TimeSpan s = d.AddDays(50) - d;
            Random ra = new Random(unchecked((int)DateTime.Now.Ticks));
            int total = (int)s.TotalSeconds;

            int ss = ra.Next(0, total);
            return d.AddSeconds(ss);
        }

        /// <summary>
        /// 获得随机 时分秒
        /// </summary>
        /// <returns></returns>
        public string GetHhMmSs()
        {
            Random ra = new Random(unchecked((int)DateTime.Now.Ticks));
            int h = GetHh();
            int m = ra.Next(0, 60);
            int s = ra.Next(0, 60);
            return h.ToString() + ":" + m.ToString() + ":" + s.ToString();
        }

        public int   GetHh()
        {
            List<int> ls = new List<int>();
            Random ra = new Random(unchecked((int)DateTime.Now.Ticks));
            int h7 = ra.Next(0, 2);//深夜上网的不多   级数是2
            GetNum(ls, 2, h7);
            int h8 = ra.Next(2, 7);//太晚了上网的人很少  级数是1
            GetNum(ls, 1, h8);
            int h1 = ra.Next(7, 9); //只是上网的人不多   级数是2 
            GetNum(ls, 2, h1);
            int h2 = ra.Next(9, 13);//工作时间，比较多人上网  级数是5
            GetNum(ls, 5, h2);
            int h3 = ra.Next(13, 15);//休息时间比较少人上网   级数是3
            GetNum(ls, 3, h3);
            int h4 = ra.Next(15, 18);//比较多人上网  级数是7
            GetNum(ls, 7, h4);
            int h5 = ra.Next(18, 20);//吃饭时间相对没那么多 级数是4
            GetNum(ls, 4, h5);
            int h6 = ra.Next(20, 24);//比较多人上网     级数是8
            GetNum(ls, 8, h6);
            int lsnum= ra.Next(0, ls.Count );
           return ls[lsnum];
        }

        private void GetNum(List<int> ls,int num ,int val)
        {
            for (int i=0; i < num; i++)
            {
                ls.Add(val);
            }
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        
    }
}
