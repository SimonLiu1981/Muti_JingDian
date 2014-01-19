using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using dx177.Model.Bus;
using dx177.Business.Bus;

namespace dx177.WebUI.admin.QuestionMgnt
{
    public partial class Reply : System.Web.UI.Page
    {

        public string Seqno
        {
            get
            {
                if (Request.QueryString["seqno"] == null)
                {
                    return "0";
                }
                return Request.QueryString["seqno"];
            }
        }
        public string pguid
        {
            get
            {
                if (Request.QueryString["pguid"] == null)
                {
                    return "";
                }
                return Request.QueryString["pguid"];
            }
        }
        
        /// <summary>
        /// 初始化数据
        /// </summary>
        private void InitData()
        {
            if (Seqno != "0")
            {
                Replyquestion rest = ReplyquestionBLL.GetInstance().Get(new Replyquestion.Key(int.Parse(Seqno)));
                if (rest != null)
                {
                    txtGuid.Value = rest.Guid;
                    fckContent.Value = rest.Content;
                    txtBad.Text = rest.Bad.ToString();
                    txtGood.Text = rest.Good.ToString();
                    chkIsRight.Checked = rest.Isright == 1;
                }
            }
            if (pguid != "")
            {
                Questions q = QuestionsBLL.GetInstance().GetByGuid(pguid);

                lblTitle.Text = q.Title;
                lblContent.Text = q.Content;
            }            
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            txtGuid.Value = System.Guid.NewGuid().ToString();
            
            if (!IsPostBack)
            {
                InitData();                
            }
            txtGood.Attributes.Add("support_set_guid", txtGuid.Value);
            txtBad.Attributes.Add("oppose_set_guid", txtGuid.Value);
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {

        }
        
    }
}
