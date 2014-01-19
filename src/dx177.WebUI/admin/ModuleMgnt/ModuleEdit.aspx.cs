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
using dx177.FrameWork;

namespace dx177.WebUI.admin.ModuleMgnt
{
    public partial class ModuleEdit : BasePage
    {
        public int Seqno
        {
            get
            {
                if (Request.QueryString["seqno"] == null)
                {
                    return 0;
                }
                return int.Parse(Request.QueryString["seqno"]);
            }
        }



        protected void Page_Load(object sender, EventArgs e)
        {
             
            if (!IsPostBack)
            {
                InitData();
            }
        }

        private void InitData()
        {

            dropModule.DataSource = ModuletypeBLL.GetInstance().GetModuleType("");
            dropModule.DataTextField = "title";
            dropModule.DataValueField = "code";
            dropModule.DataBind();
            dropModule.Items.Insert(0, new ListItem("请录入", ""));
            if (Seqno > 0)
            {
                Module rest = ModuleBLL.GetInstance().Get(new Module.Key(Seqno));
                if (rest != null)
                {
                    txtLink.Text = rest.Link;
                    txtShortDescrt.Text = rest.Shortdescrt;
                    txtShowIndex.Text = rest.Showidx.ToString();
                    txtTitle.Text = rest.Title;
                    UCSingleImgUpload1.ImgPath = rest.Imgfile;
                    dropModule.SelectedValue = rest.Modulecode;
                }
            }
        }


     
        public string Update( )
        {
             Module rest = new Module();
             if (Seqno > 0)
             {
                rest = ModuleBLL.GetInstance().Get(new Module.Key(Seqno));
             }
             rest.Link = txtLink.Text ;
             rest.Shortdescrt = txtShortDescrt.Text;
             rest.Showidx = int.Parse(txtShowIndex.Text  );
             rest.Title = txtTitle.Text;
             rest.Imgfile = UCSingleImgUpload1.ImgPath ;
             rest.Modulecode = dropModule.SelectedValue;
             ModuleBLL.GetInstance().Submit(rest);
            return "1";
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            Update();
            CommonScript.ServiceScript(this.Page, "  ReturnB();");
            
          //  Page.ClientScript.RegisterStartupScript(this.Page.GetType(), "", "<script language='javascript' type='text/javascript'> $(document).ready(function() {parent.RefeshBook();parent.tb_remove();});</script>");
        }

       
    }
}
