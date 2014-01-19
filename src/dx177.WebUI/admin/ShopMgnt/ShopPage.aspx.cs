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
using dx177.Business.DictBus;
using dx177.Model.Bus;
using dx177.Business.Bus;
using dx177.FrameWork;
using dx177.Model;

namespace dx177.WebUI.admin.ShopMgnt
{
    public partial class ShopPage : BasePage
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
            if (!IsPostBack)
            {
                txt1Guid.Value = System.Guid.NewGuid().ToString();
                Dict.Tag.BindListControl(drpBiztype, "Biztype", AppContext.CurrentMgtJingQuCode);
                drpBiztype.Items.Insert(0, new ListItem("请选择", "0"));
                Dict.Tag.BindListControl(drpArea, "AREA", AppContext.CurrentMgtJingQuCode);
                drpArea.Items.Insert(0, new ListItem("请选择", "0"));
                Dict.Tag.BindListControl(rbtStatus, "OpenStatus", AppContext.CurrentMgtJingQuCode);
                UCModelType1.IniData();
                ShowData();
            }
            txtViewtimes.Attributes.Add("viewtimes_set_guid", txt1Guid.Value);
        }

        private void ShowData()
        {
            Shop s = ShopBLL.GetInstance().Get(new Shop.Key(this.Seqno));
            if (s != null)
            {
                UControl.CopyEntityToControl(this.Form1, s);
                
                txt1Guid.Value = s.Guid;
                fckContent.Value = s.Content;
                UCModelType1.setModuleType(s.Guid);
            }
             
        }

        private void Save()
        {
            Shop s = new Shop();
            if (Seqno > 0)
            {
                s = ShopBLL.GetInstance().Get(new Shop.Key(Seqno));
            }
            else
            {
                s.Guid = txt1Guid.Value;
            }
            s.Jingqucode = AppContext.CurrentMgtJingQuCode;
            UControl.CopyControlToEntity(this.Form1, s);
            s.Content = fckContent.Value;
            s.CreateDate  = DateTime.Now;
            s.Creator = AppContext.CurrentResuser.Username;
            
            ShopBLL.GetInstance().Submit(s);

            ModuleBLL.GetInstance().Submit(UCModelType1.GetModuleType(), s.Guid);
            Response.Redirect("ShopList.aspx");
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            Save();
        }

    }
}
