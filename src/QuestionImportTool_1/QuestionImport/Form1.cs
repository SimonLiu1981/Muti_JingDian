using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuestionImport
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataClasses1DataContext context = new DataClasses1DataContext();
            this.dataGridView1.DataSource = context.Temp_import_question.ToList();
            
        }

        private void btnGenerateXml_Click(object sender, EventArgs e)
        {

            string template = @"<?xml version=""1.0"" encoding=""UTF-8""?>
                            <qs:ImportQuestions xmlns:qs=""http://questions"" xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"">
                                {0}
                            </qs:ImportQuestions>";

            string questiontemplate = @"<qs:AddQuestion>
	                                <qs:Title><![CDATA[{0}]]></qs:Title>		
	                                <qs:Contents><![CDATA[{1}]]></qs:Contents>    
	                                <qs:JingQuCode>{4}</qs:JingQuCode>
	                                <qs:Qtype>{3}</qs:Qtype>	                                       
                                    {2}
                                </qs:AddQuestion>";

            string allreplytemplate = @"<qs:Replys>
		                                {0}
	                                </qs:Replys>";
            string onereplaytempate = @"<qs:Reply>
                                            <qs:ReplyContents><![CDATA[{0}]]></qs:ReplyContents>
                                            <qs:IsRight>{1}</qs:IsRight>
                                        </qs:Reply>";


            DataClasses1DataContext context = new DataClasses1DataContext();
            StringBuilder sbQuestion = new StringBuilder();
            int start = 0;
            int end = 0;
            if (txtStart.Text != string.Empty)
            {
                start = Convert.ToInt32(txtStart.Text);
            }
            if (txtEnd.Text != string.Empty)
            {
                end = Convert.ToInt32(txtEnd.Text);
            }
            foreach (Temp_import_question temp in context.Temp_import_question)
            {
                if (start > 0 && temp.Seqno < start)
                {
                    continue;
                }
                if (end > 0 && temp.Seqno > end)
                {
                    continue;
                }
                StringBuilder sbReply = new StringBuilder();
                if (!string.IsNullOrEmpty(temp.BestReply))
                {
                    sbReply.AppendFormat(onereplaytempate, InsertBR(temp.BestReply), 1).AppendLine();
                }
                if (!string.IsNullOrEmpty(temp.Reply1))
                {
                    sbReply.AppendFormat(onereplaytempate, InsertBR(temp.Reply1), 0).AppendLine();
                }
                if (!string.IsNullOrEmpty(temp.Reply2))
                {
                    sbReply.AppendFormat(onereplaytempate, InsertBR(temp.Reply2), 0).AppendLine();
                }
                string replys = "";
                if (sbReply.Length>0)
                {
                    replys = string.Format(allreplytemplate, sbReply.ToString());
                }

                sbQuestion.AppendFormat(questiontemplate, temp.Title, InsertBR(temp.pContent), replys, GetType(!string.IsNullOrEmpty(temp.pContent) ? temp.pContent : temp.Title), txtJingqucode.Text).AppendLine();
                  

            }
            string xmlOutput = string.Format(template, sbQuestion.ToString());

            textBox1.Text = xmlOutput;


        }

        int insertLength = 40;
        private string InsertBR(string source)
        {
            if (string.IsNullOrEmpty(source))
                return string.Empty;
            string tmp = source;
            StringBuilder res = new StringBuilder();
            int idx = 0;
            for (int i = 0; i < tmp.Length; i++)
            {
                idx++;       
                res.Append(tmp[i]);
                if (tmp[i] == '；' || tmp[i] == '。')
                {
                    idx = 0;
                    res.Append("<br/>");
                    res.AppendLine();
                }
               
            }
            return res.ToString();
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.A)
            {
                ((TextBox)sender).SelectAll();
            } 
        }

        private string GetType(string content)
        {
            string[] types = { "娱乐", "门票", "体验", "交通", "住宿", "饮食", "景点", "路线", "办事", "其他" };

            string res = "";
            foreach (string itype in types)
            {
                if (content.IndexOf(itype) > -1)
                {
                    res = itype;
                }
            }
            if (res == "")
            {
                res = "其他";
            }
            return res;
        }
    }
}
