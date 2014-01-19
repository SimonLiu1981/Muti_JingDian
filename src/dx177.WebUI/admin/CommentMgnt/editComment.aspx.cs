using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using dx177.Model.Bus;
using dx177.Business.Bus;
using dx177.Model;

namespace dx177.WebUI.admin.CommentMgnt
{
    public partial class editComment : System.Web.UI.Page
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

        private string pguid
        {
            get
            {
                return Request.QueryString["pguid"];
            }
        }
        private string type
        {
            get
            {
                return Request.QueryString["type"];
            }
        }


        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                txtGuid.Value = System.Guid.NewGuid().ToString();
                if (AppContext.CurrentResuser != null)
                {
                    txtCreator.Text = AppContext.CurrentResuser.Username;
                    
                }
                InitData();
            }
            txtGood.Attributes.Add("support_set_guid", txtGuid.Value);
            txtBad.Attributes.Add("oppose_set_guid", txtGuid.Value);
        }


        private void InitData()
        {

            Label1.Text = CommentBLL.GetInstance().GetSocre1Lable(type);
            Label2.Text = CommentBLL.GetInstance().GetSocre2Lable(type);
            Label3.Text = CommentBLL.GetInstance().GetSocre3Lable(type);
            Label4.Text = CommentBLL.GetInstance().GetSocre4Lable(type);
            if (Seqno != "0")
            {
                Comment cs = CommentBLL.GetInstance().Get(new Comment.Key(int.Parse(Seqno)));
                if (cs.Isnew == 1)
                {
                    cs.Isnew = 0;
                    CommentBLL.GetInstance().Update(cs);
                }
                txtGuid.Value = cs.Guid;
                UCJqueryRaty1.Score = cs.Score1;
                
                UCJqueryRaty2.Score = cs.Score2;
                
                UCJqueryRaty3.Score = cs.Score3;
                
                UCJqueryRaty4.Score = cs.Score4;
                

                txtCreator.Text = cs.Creator;
                txtGood.Text = cs.Good.ToString();
                txtBad.Text = cs.Bad.ToString();
                txtContent.Text = cs.Content;
                txtReplyContent.Text = cs.Replycontent;
                chkIsShow.Checked = cs.Isshow == 1;
            }

        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            Comment cs = new Comment();
            if (Seqno != "0")
            {
                cs = CommentBLL.GetInstance().Get(new Comment.Key(int.Parse(Seqno)));
            }
            cs.Guid = txtGuid.Value;
            cs.Score1 = UCJqueryRaty1.Score;
            cs.Score2 = UCJqueryRaty2.Score;
            cs.Score3 = UCJqueryRaty3.Score;
            cs.Score4 = UCJqueryRaty4.Score;
            cs.Content = txtContent.Text;
            cs.Replycontent = txtReplyContent.Text;
            cs.Bad = int.Parse(txtBad.Text);
            cs.Good = int.Parse(txtGood.Text);
            cs.Creator = txtCreator.Text;
            cs.Pguid = pguid;
            cs.Isshow = chkIsShow.Checked ? 1 : 0;
            CommentBLL.GetInstance().Submit(cs);
            Page.ClientScript.RegisterStartupScript(this.Page.GetType(), "", "<script language='javascript' type='text/javascript'> $(document).ready(function() {parent.RefeshInfo();parent.tb_remove();});</script>");

        }
    }
}
