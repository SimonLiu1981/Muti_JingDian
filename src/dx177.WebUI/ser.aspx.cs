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
using dx177.Business.Bus;
using dx177.Model.Bus;
using System.Text.RegularExpressions;

namespace dx177.WebUI
{
    public partial class ser : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
               
        }

        protected void Button1_Click(object sender, EventArgs e)
        {


            if (txtpassword.Text == "8120413")
            {
                if (RadioButtonList1.SelectedItem.Value == "H")
                {
                    SaveHotelAsk(txtcontent.Text);
                }
                else if (RadioButtonList1.SelectedItem.Value == "A")
                {
                    SaveQuestion(txtcontent.Text);
                }
                else 
                {
                    SaveReply(txtcontent.Text);
                }
                txtcontent.Text = string.Empty;
            }
        }



        private void SaveHotelAsk(string txt)
        {
            string[] ar = txt.Split(new char[] { '|', '|' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string s in ar)
            {

                string[] content = s.Split(new char[] { '$', '$' }, StringSplitOptions.RemoveEmptyEntries);   
                Comment c = new Comment();
                c.Content = content[0];
                c.Pguid = HotelBLL.GetInstance().Get(new Hotel.Key(int.Parse(content[1]))).Guid;
                c.Guid = System.Guid.NewGuid().ToString();
                c.CreateDate = DateTime.Now;
                if (content.Length == 3)
                {
                    c.Replycontent = content[2];
                }
                CommentBLL.GetInstance().Insert(c);
            }
        }


        private void SaveQuestion(string txt)
        {

            string[] ar = txt.Split(new char[] { '|', '|' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string s in ar)
            {
                string[] content = s.Split(new char[] { '$', '$' }, StringSplitOptions.RemoveEmptyEntries);   
                Questions c = new Questions();
                c.Title = content[0];
                c.Content = content[1];
                c.Creator = content[2];
                c.Guid = System.Guid.NewGuid().ToString();
                c.CreateDate = DateTime.Now;
                c.Qtype = content[3];
                QuestionsBLL.GetInstance().Insert(c);
            }
        }


        private void SaveReply(string txt)
        {
            string[] ar = txt.Split(new char[] { '|', '|' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string s in ar)
            {
                string[] content = s.Split(new char[] { '$', '$' }, StringSplitOptions.RemoveEmptyEntries);   
                Replyquestion c = new Replyquestion();
                c.Content = content[0];
                c.Creator = content[1];
                c.Pguid = ReplyquestionBLL.GetInstance().Get(new Replyquestion.Key(int.Parse(content[2]))).Guid;
                c.Guid = System.Guid.NewGuid().ToString();
                c.CreateDate = DateTime.Now;
                c.Isright =int.Parse ( content[3]) ;
                ReplyquestionBLL.GetInstance().Insert(c);
            }
        }
    }
}
