using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using dx177.FrameWork;
using System.Text;
using dx177.Model.Bus;
using dx177.Business.Bus;

namespace dx177.WebUI.admin
{
    public partial class ajaxHandler : System.Web.UI.Page
    {
        public string MethodName
        {
            get
            {
                return Request.QueryString["MethodName"];
            }
        }


        protected void Page_Load(object sender, EventArgs e)
        {
            string JsonString = "";
            switch (MethodName)
            {
               
                case "GetByAreadID":
                    JsonString = CommonUnitl.JavaScriptSerializerString(GetByAreadID());
                    break;
                case "ProvinceCity":
                    JsonString = CommonUnitl.JavaScriptSerializerString(ProvinceCity());
                    break;
                case "GetCommentCount":
                    JsonString = CommonUnitl.JavaScriptSerializerString(GetCommentCount());
                    break;
            }

            this.Response.Clear();
            this.Response.ContentEncoding = Encoding.UTF8;
            this.Response.ContentType = "application/json";
            this.Response.Write(JsonString);
            this.Response.Flush();
            this.Response.End();
        }

        private CommonArea GetByAreadID()
        {
            string Areaid = HttpUtility.UrlDecode(Request["Areaid"].ToString());

            return CommonAreaBLL.GetInstance().GetByAreaID(Areaid);

        }

        private object GetCommentCount()
        {
            string guid = HttpUtility.UrlDecode(Request["guid"].ToString());
            string count = CommentBLL.GetInstance().GetCommentCount(guid);

            return new { Number = count };

        }

        private List<CommonArea> ProvinceCity()
        {
            string Pid = HttpUtility.UrlDecode(Request["Pid"].ToString());

            int PAreadID = Convert.ToInt32(Pid);

            return CommonAreaBLL.GetInstance().GetByParentAreaID(PAreadID);
   
        }       

        
    }
}
