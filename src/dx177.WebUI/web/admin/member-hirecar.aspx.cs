using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using dx177.Model.Bus;
using dx177.Business.Bus;
using dx177.FrameWork;
using dx177.Model;

namespace dx177.WebUI.web.admin
{
    public partial class member_publish_hirecar : ResUserBasePage
    {
        /// <summary>
        /// 租车ID
        /// </summary>
        public string Seqno
        {
            get {
                return Request.QueryString["seqno"];
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                txtGuid.Value = System.Guid.NewGuid().ToString();
                InitData();
            }
            
        }

        /// <summary>
        /// 初始化数据
        /// </summary>
        private void InitData()
        {
            if (!string.IsNullOrEmpty(Seqno))
            {
                Hirecar rest = HirecarBLL.GetInstance().Get(new Hirecar.Key(int.Parse(Seqno)));
                if (rest != null)
                {
                    txtGuid.Value = rest.Guid;
                    txtTitle.Text = rest.Title;
                    txtRange.Text = rest.Range;
                    txtLinkman.Text = rest.Linkman;
                    txtTelnumber.Text = rest.Telnumber;
                    txtPrice.Text = rest.Price;
                    txtPersoncount.Text = rest.Personcount.ToString();
                    txtCarType.Text = rest.Cartype;
                    
                    txtShortContent.Text = rest.Shortcontent;
                    fckContent.Value = rest.Content;                    
                }
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            Hirecar rest = new Hirecar();
            if (!string.IsNullOrEmpty(Seqno))
            {
                rest = HirecarBLL.GetInstance().Get(new Hirecar.Key(int.Parse(Seqno)));
            }
            else
            {
                rest.Status = (int)OpenStatus.Application;
                rest.Creator = AppContext.CurrentResuser.Username;
            }
            rest.Guid = txtGuid.Value;
            rest.Title = txtTitle.Text;
            rest.Range = txtRange.Text;
            rest.Linkman = txtLinkman.Text;
            rest.Telnumber = txtTelnumber.Text;
            rest.Price = txtPrice.Text;
            rest.Personcount = txtPersoncount.Text;
            rest.Cartype = txtCarType.Text;
            //rest.Status = int.Parse(rbtStatus.SelectedValue);
            rest.Shortcontent = txtShortContent.Text;
            rest.Content = fckContent.Value;
            rest.Jingqucode = AppContext.JingQuCode;
            rest.Status = (int)OpenStatus.Application;
            //rest.Qq = txtQq.Text;
            //rest.Aliww = txtAliww.Text;
            //rest.Showpr = txtShowpr.Text == string.Empty ? 0 : int.Parse(txtShowpr.Text);
            //rest.Viewtimes = txtViewtimes.Text == string.Empty ? 0 : int.Parse(txtViewtimes.Text);

            HirecarBLL.GetInstance().Submit(rest);

            if (!string.IsNullOrEmpty(Request.QueryString["r"]))
            {
                Response.Redirect(Request.QueryString["r"]);
            }
            else
            {
                Response.Redirect("/member-hirecarlist.aspx");                
            }            
        }

    }
}
