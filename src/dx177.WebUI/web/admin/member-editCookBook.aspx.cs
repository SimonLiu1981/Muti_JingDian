using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using dx177.Model.Bus;
using dx177.Business.Bus;

namespace dx177.WebUI.web.admin
{
    public partial class member_editCookBook : System.Web.UI.Page
    {

        public string PGuid
        {
            get
            {
                if (Request.QueryString["PGuid"] == null)
                {
                    return "";
                }
                else
                {
                    return Request.QueryString["PGuid"];
                }
            }
        }

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


        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                txtGuid.Value = System.Guid.NewGuid().ToString();
                InitData();
            }
        }

        private void InitData()
        {
            if (Seqno != "0")
            {

                Cookbook rest = CookbookBLL.GetInstance().Get(new Cookbook.Key(int.Parse(Seqno)));
                if (rest != null)
                {
                    txtTitle.Text = rest.Name;
                    txtGuid.Value = rest.Guid;
                    txtPrice.Text = rest.Price;
                    txtShortContent.Text = rest.Shortcontent;
                    UCSingleImgUpload1.ImgPath = rest.Logo;
                    fckContent.Value = rest.Content;

                }
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            Cookbook rest = new Cookbook();
            if (Seqno != "0")
            {
                rest = CookbookBLL.GetInstance().Get(new Cookbook.Key(int.Parse(Seqno)));
            }
            rest.Name = txtTitle.Text;
            rest.Guid = txtGuid.Value;
            rest.Price = txtPrice.Text;
            rest.Pguid = PGuid;
            rest.Logo = UCSingleImgUpload1.ImgPath;
            rest.Shortcontent = txtShortContent.Text;
            rest.Content = fckContent.Value;
            CookbookBLL.GetInstance().Submit(rest);

            Page.ClientScript.RegisterStartupScript(this.Page.GetType(), "", "<script language='javascript' type='text/javascript'> $(document).ready(function() {parent.RefeshBook();parent.tb_remove();});</script>");
        }

        protected void btnReturn_Click(object sender, EventArgs e)
        {
            Page.ClientScript.RegisterStartupScript(this.Page.GetType(), "", "<script language='javascript' type='text/javascript'> $(document).ready(function() {parent.tb_remove();});</script>");
        }
    }
}
