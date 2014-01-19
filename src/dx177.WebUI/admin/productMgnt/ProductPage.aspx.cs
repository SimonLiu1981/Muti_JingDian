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
using dx177.Model;

namespace dx177.WebUI.admin.productMgnt
{
    public partial class ProductPage : BasePage
    {
        public int Seqno
        {
            get
            {
                if (Request.QueryString["Seqno"] != null)
                {
                    return int.Parse(Request.QueryString["Seqno"]);
                }
                return 0;
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                txt1Guid.Value = System.Guid.NewGuid().ToString();
             
               
                UCModelType1.IniData();
                IniData();
                ShowData();
            }
        }

        private void IniData()
        {
            ProductsBLL.GetInstance().BindDropListTreeType(drpPtype);
            drpPtype.Items.Insert(0, new ListItem("请选择", ""));
        }

        private void ShowData()
        {
            Products n = ProductsBLL.GetInstance().Get(new Products.Key(this.Seqno));
            if (n != null)
            {
                UControl.CopyEntityToControl(this.Form1, n);
                UCSingleImgUpload1.ImgPath = n.Logo;
                txt1Guid.Value = n.Guid;
                fckContent.Value = n.Content;
                txtOther.Value = n.Others;
                UCModelType1.setModuleType(n.Guid);
            }
            UCImgupload1.PGuid = txt1Guid.Value;
            UCImgupload1.Seqno = Seqno.ToString();
        }



        private void Save()
        {
            Products n = new Products();
            if (Seqno > 0)
            {
                n = ProductsBLL.GetInstance().Get(new Products.Key(Seqno));
            }
            else
            {
                n.Guid = txt1Guid.Value;
            }
            UControl.CopyControlToEntity(this.Form1, n);
            n.Creator = AppContext.CurrentResuser.Username;
            n.Others = txtOther.Value;
            n.Content = fckContent.Value;
            n.Logo = UCSingleImgUpload1.ImgPath;
            ProductsBLL.GetInstance().Submit(n);
            ModuleBLL.GetInstance().Submit(UCModelType1.GetModuleType(), n.Guid);
            Response.Redirect("Productlist.aspx");
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            Save();
        }
    }
}
