using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using dx177.FrameWork;
using System.IO;

namespace dx177.WebUI.usercontrols
{
    public partial class UCSingleImgUpload : System.Web.UI.UserControl
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

        public string ImgPath
        {
            get
            {
                return txtImgPath.Value;
            }
            set
            {
                txtImgPath.Value = value;
            }
        }

        protected string OldPicturePath
        {
            get
            {
                return txtOldPath.Value;
            }
            set
            {
                txtOldPath.Value = value;
            }
            
        }

        protected string ShowImgPath
        { 
            get
            {
                if (ViewState["ShowImgPath"] == null)
                {
                    ViewState["ShowImgPath"] = "/usercontrols/no_uploadPicture.gif";
                }
                return ViewState["ShowImgPath"] as string;
            }
            set
            {
                ViewState["ShowImgPath"] = value;
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {

            Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "swfobject", "<script type=\"text/javascript\" src=\"" + this.ResolveUrl("~/Plugin/JqueryUploadify/swfobject.js") + "\"></script>");
            Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "uploadify", "<script type=\"text/javascript\" src=\"" + this.ResolveUrl("~/Plugin/JqueryUploadify/jquery.uploadify.v2.1.0.min.js") + "\"></script>");

             
            
            if (ImgPath != "")
            {
                ShowImgPath = ImgPath;
            }
            else
            {
                ShowImgPath =  "/usercontrols/no_uploadPicture.gif";
            }
            OldPicturePath = ImgPath;
             
        }

        
        public string AjaxDeleteFile(string ImgPath)
        {
            if (File.Exists(System.Web.HttpContext.Current.Server.MapPath(ImgPath)))
            {
                File.Delete(System.Web.HttpContext.Current.Server.MapPath(ImgPath));
            }
            return CommonUnitl.JavaScriptSerializerString(new { ImgPath = "", ShowImgPath = "/usercontrols/no_uploadPicture.gif" });
        }
        
    }
}