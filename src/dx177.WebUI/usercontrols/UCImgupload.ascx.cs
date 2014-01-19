using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using dx177.FrameWork;
using dx177.Business.Bus;
using dx177.Model.Bus;

namespace dx177.WebUI.usercontrols
{
    public partial class UCImgupload : System.Web.UI.UserControl
    {

        public string PGuid
        {
            get
            {
                if (ViewState["PGuid"] == null)
                {
                    ViewState["PGuid"] = System.Guid.NewGuid().ToString();
                }

                return ViewState["PGuid"] as string;                
            }
            set
            {
                ViewState["PGuid"] = value;
            }
        }

        public string Seqno
        {
            get
            {
                if (ViewState["Seqno"] == null)
                {
                    ViewState["Seqno"] = "";
                }

                return ViewState["Seqno"] as string;
            }
            set
            {
                ViewState["Seqno"] = value;
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "swfobject", "<script type=\"text/javascript\" src=\"" + this.ResolveUrl("~/Plugin/JqueryUploadify/swfobject.js") + "\"></script>");
            Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "uploadify", "<script type=\"text/javascript\" src=\"" + this.ResolveUrl("~/Plugin/JqueryUploadify/jquery.uploadify.v2.1.0.min.js") + "\"></script>");

        }

        public string AjaxGetPicsByGuid(string guid)
        {
            return CommonUnitl.JavaScriptSerializerString(PicturelistBLL.GetInstance().GetPicsByGuid(guid));
        }
        public string AjaxDeleteByPicsId(string seqno)
        {             
            PicturelistBLL.GetInstance().Delete(int.Parse(seqno));
            return "1";
        }
    }
}