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
namespace dx177.WebUI.admin.FriendLinkMgnt
{
    public partial class FriendLinkPage : BasePage
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

        public string Type
        {
            get
            {
                if (Request.QueryString["Type"] != null)
                {
                    return Request.QueryString["Type"];
                }
                return "";
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                txt1Guid.Value = System.Guid.NewGuid().ToString();

                dropType.DataSource = CommonBLL.GetInstance().GetSyscodeMap("Friendlink");
                dropType.DataTextField = "name";
                dropType.DataValueField = "val";
                dropType.DataBind();
                dropType.Items.Insert(0, new ListItem("请录入", ""));


                ShowData();
            }
        }

        

        

        private void ShowData()
        {
            Friendlink n = FriendlinkBLL.GetInstance().Get(new Friendlink.Key(this.Seqno));
            if (n != null)
            {
                UControl.CopyEntityToControl(this.Form1, n);
                UCSingleImgUpload1.ImgPath = n.Logo;
                txt1Guid.Value = n.Guid;
                dropType.SelectedValue = n.Type;
            }
        }



        private void Save()
        {
            Friendlink n = new Friendlink();
            if (Seqno > 0)
            {
                n = FriendlinkBLL.GetInstance().Get(new Friendlink.Key(Seqno));
            }
            else
            {
                n.Guid = txt1Guid.Value;
            }
             
            UControl.CopyControlToEntity(this.Form1, n);
            n.Type = dropType.SelectedValue;
            n.Creator = AppContext.CurrentResuser.Username;
            n.Logo = UCSingleImgUpload1.ImgPath;
            n.Jingqucode = AppContext.CurrentMgtJingQuCode;
            FriendlinkBLL.GetInstance().Submit(n);
            Response.Redirect("FriendLinkList.aspx");
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            Save();
        }
    }
}
