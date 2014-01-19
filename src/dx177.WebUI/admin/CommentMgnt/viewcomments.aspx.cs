using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using dx177.Business.Bus;
using dx177.Model.Bus;
using dx177.Model.Bus.QueryO;
using System.Data;
using dx177.FrameWork;

namespace dx177.WebUI.admin.CommentMgnt
{
    public partial class viewcomments : BasePage
    {

        private string guid
        {
            get
            {
                return Request.QueryString["guid"];
            }
        }
        private string type
        {
            get
            {
                return Request.QueryString["type"];
            }
        }

        private string isnew
        {
            get
            {
                return Request.QueryString["isnew"];
            }
        }

        private string isnoreply
        {
            get
            {
                return Request.QueryString["isnoreply"];
            }
        }


        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                
                txtPGuid.Value = this.guid;
                if (!string.IsNullOrEmpty(isnew) &&
                isnew == "1")
                {
                    cbxIsnew.Checked = true;
                }
                if (!string.IsNullOrEmpty(isnoreply) &&
                    isnoreply == "1")
                {
                    cbxIsnoreply.Checked = true;
                }

                InitData();
            }
        }

        private void InitData()
        {
            Sumarycomment cs = SumarycommentBLL.GetInstance().GetSumarycommentByPGuid(guid);
            if (type == "1")
            {
                Hotel hh = HotelBLL.GetInstance().GetHotelByGuid(guid);
                lblObjTile.Text =string.Format("对酒店：《{0}》评论",hh.Name);
            }
            else if (type == "2") //饭店点
            {
                Restaurant res = RestaurantBLL.GetInstance().GetRestaurantByGuid(guid);
                lblObjTile.Text = string.Format("对饭店：《{0}》评论", res.Title);
            }
            else if (type == "3") //新闻点评
            {
                News res = NewsBLL.GetInstance().GetByGuid(guid);
                lblObjTile.Text = string.Format("对饭店：《{0}》评论", res.Title);
            }
            else if (type == "4") //景点点评
            {
                Sites res = SitesBLL.GetInstance().GetByGuid(guid);
                lblObjTile.Text = string.Format("对饭店：《{0}》评论", res.Title);
            }
            else if (type == "5") //景区点评
            {
                Jingqus res = JingqusBLL.GetInstance().GetByGuid(guid);
                lblObjTile.Text = string.Format("对景区：《{0}》评论", res.Jingquname);
            }

            Label1.Text = CommentBLL.GetInstance().GetSocre1Lable(type);
            Label2.Text = CommentBLL.GetInstance().GetSocre2Lable(type);
            Label3.Text = CommentBLL.GetInstance().GetSocre3Lable(type);
            Label4.Text = CommentBLL.GetInstance().GetSocre4Lable(type);
            UCJqueryRaty1.Score = cs.Score1;            
            UCJqueryRaty2.Score = cs.Score2;
            UCJqueryRaty3.Score = cs.Score3;            
            UCJqueryRaty4.Score = cs.Score4;            
            ratySummary.Score = cs.Avgscore;
            txtSummaryContent.Text = cs.Sumarycontent;
            btnQuery_Click(null, null);
            
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            Sumarycomment cs = SumarycommentBLL.GetInstance().GetSumarycommentByPGuid(guid);
            cs.Sumarycontent = txtSummaryContent.Text;
            SumarycommentBLL.GetInstance().Submit(cs);
        }

        protected void btnReturn_Click(object sender, EventArgs e)
        {
            if (Request.QueryString["r"] != null)
            {
                Response.Redirect(Request.QueryString["r"]);
            } 
        }

        protected void dgNews_ItemDataBound(object sender, DataGridItemEventArgs e)
        {
            if (e.Item.ItemType == ListItemType.AlternatingItem ||
                e.Item.ItemType == ListItemType.Item)
            {
                Label lblStatus = e.Item.FindControl("lblStatus") as Label;
                TextBox txtReplycontent = e.Item.FindControl("txtReplycontent") as TextBox;
                 
                DataRowView dr = e.Item.DataItem as DataRowView;
                if (dr["isnew"].ToString() == "1")
                {
                    lblStatus.Text += "<font color=red>新评</font><br/>";                    
                }
                if (dr["replycontent"].ToString() == "")
                {
                    lblStatus.Text += "<font color=gray>未回</font><br/>";
                }
                if (dr["isshow"].ToString() == "1")
                {
                    lblStatus.Text += "<font color=green>前显</font><br/>";
                }
                else
                {
                    lblStatus.Text += "<font color=green>前隐</font><br/>";
                }
                txtReplycontent.Text = dr["replycontent"].ToString();

                LinkButton btnIsShow = e.Item.FindControl("btnIsShow") as LinkButton;
                DataRowView dv = e.Item.DataItem as DataRowView;
                if (dr["isshow"].ToString() == "1")
                {
                    btnIsShow.Text = "隐藏";
                }
                else
                {
                    btnIsShow.Text = "显示";
                }

            }
        }

        protected void dgNews_ItemCommand(object source, DataGridCommandEventArgs e)
        {
             
            switch (e.CommandName)
            {
                case "Delete":
                    CommentBLL.GetInstance().RemoveComment(e.CommandArgument.ToString());

                    InitData();
                    break;
                case "Modify":
                    
                    break;
                case "IsShow":
                    LinkButton btnIsShow = e.Item.FindControl("btnIsShow") as LinkButton;
                    DataRowView dv = e.Item.DataItem as DataRowView;
                    Comment c = CommentBLL.GetInstance().Get(new Comment.Key(int.Parse(e.CommandArgument.ToString())));

                    c.Isshow = c.Isshow.Equals(1) ? 0 : 1;

                    CommentBLL.GetInstance().Submit(c);

                    btnQuery_Click(null, null);
                    break;
                default:
                    break;
            }
        }

    
        protected void btnQuery_Click(object sender, EventArgs e)
        {
            CommentQuery query = new CommentQuery();
            query.IsNew = cbxIsnew.Checked ? "1" : "";
            query.IsNoReply = cbxIsnoreply.Checked ? "1" : "";
            query.IsShow = cbxIsShow.Checked ? "1" : "";
            query.pguid = this.guid;
            query.Key = txtQueryContent.Text;
            this.dgNews.Data = CommentBLL.GetInstance().SearchComment(query);
            this.dgNews.DataBind();

        }

        protected void btnAddCommnet_Click(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            InitData();
        }

        protected void bntUpdate_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgNews.Items.Count; i++)
            {
                TextBox txtReplycontent = dgNews.Items[i].FindControl("txtReplycontent") as TextBox;
                if (txtReplycontent.Text != "")
                {
                    int seqno = int.Parse(dgNews.Items[i].Cells[0].Text);

                    Comment comment = CommentBLL.GetInstance().Get(new Comment.Key(seqno));
                    if (comment != null)
                    {
                        comment.Isnew = 0;
                        comment.Replycontent = txtReplycontent.Text;
                        CommentBLL.GetInstance().Update(comment);
                    }
                }
            }
            btnQuery_Click(null, null);
            CommonScript.AlertMessage(this.Page, "已更新！");
        }
    }
}
