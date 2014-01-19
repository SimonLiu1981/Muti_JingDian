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
using System.IO;
using System.Xml;
using dx177.Model.Bus;
using dx177.Business.Bus;
using dx177.FrameWork;
using CampanyCMS.Model.Bus;

namespace dx177.WebUI
{
    public partial class AddQs : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        public void SaveXml(HtmlInputFile UploadFile, string foder)
        {
            string sss = UploadFile.PostedFile.FileName;
            if (string.IsNullOrEmpty(sss)) return;
            FileInfo info = new FileInfo(sss);
            //if (!Directory.Exists(foder))
            //{
            //    Directory.CreateDirectory(foder);
            //}
            string fileName = "qustion" + DateTime.Now.Ticks.ToString() + info.Extension;
            string patch = Server.MapPath("/") + foder + @"\";
            UploadFile.PostedFile.SaveAs(Path.Combine(patch, fileName));
            XmlDocument xd = new XmlDocument();
            xd.Load(Path.Combine(patch, fileName));
            XmlNodeList s = xd.GetElementsByTagName("Question");
            List<Questions> qustlist = new List<Questions>();

        }

        public   void SaveFile(HtmlInputFile UploadFile, string foder)
        {
            try
            {
               
                string sss = UploadFile.PostedFile.FileName;
                if (string.IsNullOrEmpty(sss)) return;
                FileInfo info = new FileInfo(sss);
                //if (!Directory.Exists(foder))
                //{
                //    Directory.CreateDirectory(foder);
                //}
                string fileName = "qustion" + DateTime.Now.Ticks.ToString() + info.Extension;
                string patch =Server.MapPath("/") +foder+ @"\";
           
                UploadFile.PostedFile.SaveAs(Path.Combine(patch, fileName));


                XmlDocument xd = new XmlDocument();
                xd.Load(Path.Combine(patch, fileName));
                XmlNodeList s = xd.GetElementsByTagName("Question");
                List<Questions> qustlist = new List<Questions>();

                foreach (XmlNode nls in s)
                {
                    
                    Questions q = new Questions();
                    q.Title = nls.Attributes["Title"].Value.ToString();
                    q.Content = nls.Attributes["Content"].Value.ToString().Replace("\r\n", "<br/>");
                    q.Creator = nls.Attributes["Creator"].Value.ToString();
                    q.Jingqucode = nls.Attributes["Jingqucode"].Value.ToString();
                    q.Qtype = QsttypeBLL.GetInstance().GetQstGuid(nls.Attributes["QType"].Value.ToString());
                    q.Guid = StringUtil.getGuid();
                    DateTime otime;
                    if (nls.Attributes["CreateDate"].Value.ToString() != string.Empty && DateTime.TryParse(nls.Attributes["CreateDate"].Value.ToString(), out otime))
                    {
                        q.CreateDate = otime;
                    }
                  
                    QuestionsBLL.GetInstance().Insert(q);
                    bool hasRight = false;
                    int i = 1;
                    while (true)
                    {
                        if (nls.Attributes["ReplyContent" + i.ToString()] != null)
                        {
                            Replyquestion r = new Replyquestion();
                            r.Guid = StringUtil.getGuid();
                            r.Content = nls.Attributes["ReplyContent" + i.ToString()].Value.Replace("\r\n", "<br/>");
                            r.Isright = nls.Attributes["Isright" + i.ToString()] == null ? 0 : 1;
                            if (r.Isright == 1 && !hasRight)
                            {
                                hasRight = true;
                            }
                            else
                            {
                                r.Isright = 0;                            
                            }
                            r.Creator = nls.Attributes["Creator" + i.ToString()].Value.ToString();
                            r.Pguid = q.Guid;
                            DateTime otime1;
                            if (nls.Attributes["CreateDate" + i.ToString()].Value.ToString() != string.Empty && DateTime.TryParse(nls.Attributes["CreateDate" + i.ToString()].Value.ToString(), out otime1))
                            {
                                r.CreateDate = otime1;
                            }
                            ReplyquestionBLL.GetInstance().Insert(r);
                            i++;
                        }
                        else
                        {
                            break;
                        }
                    }

                    if (i > 0)
                    {
                        q.Status = 1;
                        if (hasRight)
                        {
                            q.Status = 2;
                        }
                    }
                    else
                    {
                        q.Status = 0;
                    }
                    QuestionsBLL.GetInstance().Update(q); 
                    BuildPageBLL.BuildOnePage("问题", q.Creator, q.Seqno.ToString());
                }
                CommonScript.AlertMessage(this.Page, "保存成功！");
            }
            catch (Exception e)
            {
                Label1.Text = e.Message.ToString();
            }
           
        }


        protected void Button1_Click(object sender, EventArgs e)
        {
            SaveFile(File1, @"qustionxml");
        }
    }
}
