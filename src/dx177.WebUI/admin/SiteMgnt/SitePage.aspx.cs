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
using dx177.Model.Bus;
using dx177.Business.Bus;
using dx177.FrameWork;
using dx177.Model;

namespace dx177.WebUI.admin.SiteMgnt
{
    public partial class SitePage : BasePage
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
                dateCreateDate.Text = DateTime.Now.ToString("yyyy-MM-dd");
                dateLasteUpdateDate.Text = DateTime.Now.ToString("yyyy-MM-dd");
                UCModelType1.IniData();
                IniData();
                ShowData();                
            }
            txtViewtimes.Attributes.Add("viewtimes_set_guid", txt1Guid.Value);
            txtGood.Attributes.Add("support_set_guid", txt1Guid.Value);
            txtBad.Attributes.Add("oppose_set_guid", txt1Guid.Value);
        }

        private void IniData()
        {
            SitesBLL.GetInstance().BindDropListTreeType(drpTguid, AppContext.CurrentMgtJingQuCode);
            drpTguid.Items.Insert(0, new ListItem("请选择", ""));
        }

        private void ShowData()
        {
            Sites n = SitesBLL.GetInstance().Get(new Sites.Key(this.Seqno));
            if (n != null)
            {
                UControl.CopyEntityToControl(this.Form1, n);
                UCSingleImgUpload1.ImgPath = n.Logo;
                txt1Guid.Value = n.Guid;
                fckContent.Value = n.Content;
                UCModelType1.setModuleType(n.Guid);
            }
        }



        private void Save()
        {
            Sites n = new Sites();
            if (Seqno > 0)
            {
                n = SitesBLL.GetInstance().Get(new Sites.Key(Seqno));
            }
            else
            {
                n.Guid = txt1Guid.Value;
            }
            UControl.CopyControlToEntity(this.Form1, n);
            n.Creator = AppContext.CurrentResuser.Username;
            n.Logo = UCSingleImgUpload1.ImgPath;
            n.Jingqucode = AppContext.CurrentMgtJingQuCode;
            n.Content = fckContent.Value;
            SitesBLL.GetInstance().Submit(n);

            ModuleBLL.GetInstance().Submit(UCModelType1.GetModuleType(), n.Guid);
            Response.Redirect("SiteList.aspx");
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            Save();
        }
    }
}
