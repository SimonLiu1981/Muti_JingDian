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

namespace dx177.WebUI.admin.NewsMgnt
{
    public partial class NewsPage : BasePage
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
            NewsBLL.GetInstance().BindDropListTreeType(drpTguid);
            drpTguid.Items.Insert(0, new ListItem("请选择", ""));
        }

        private void ShowData()
        {
            News n = NewsBLL.GetInstance().Get(new News.Key(this.Seqno));
            if (n != null)
            {
                UControl.CopyEntityToControl(this.Form1, n);
                UCSingleImgUpload1.ImgPath = n.Logo;
                txt1Guid.Value = n.Guid;
                UCModelType1.setModuleType(n.Guid);
                fckContent.Value = n.Content;
            }
        }



        private void Save()
        {
            News n = new News();
            if (Seqno > 0)
            {
                n = NewsBLL.GetInstance().Get(new News.Key(Seqno));
            }
            else
            {
                n.Guid = txt1Guid.Value;
            }
            UControl.CopyControlToEntity(this.Form1, n);
            n.Creator = AppContext.CurrentResuser.Username;
            n.Logo = UCSingleImgUpload1.ImgPath;
            n.Content = fckContent.Value;
            n.Jingqucode = AppContext.CurrentMgtJingQuCode;
            NewsBLL.GetInstance().Submit(n);
            ModuleBLL.GetInstance().Submit(UCModelType1.GetModuleType(), n.Guid);
            Response.Redirect("NewsList.aspx");
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            Save();
        }
    }
}
