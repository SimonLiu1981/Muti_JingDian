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
namespace dx177.WebUI.web.Sites
{
    public partial class detail : System.Web.UI.Page
    {
        public dx177.Model.Bus.Sites n = new dx177.Model.Bus.Sites();
        public int Seqno
        {
            get
            {
                if (Request.QueryString["seqno"] != null)
                {
                    return int.Parse(Request.QueryString["seqno"]);
                }
                return 0;
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            ((defaultMaster)Page.Master).NavId = "sites";
           
            IniData();
            //SEO 优化
            string className = SitetypeBLL.GetInstance().GetNewstypeByguid(n.Tguid).Title;

            dx177.Business.Bus.CommonBLL.GetInstance().IniPageKeyWord(this.Page, "Sitesdetail", new { Title = n.Title, Type = className });
        }

        private void IniData()
        {
            n = SitesBLL.GetInstance().Get(new dx177.Model.Bus.Sites.Key(this.Seqno));
            AddViewTimes(n);
        }

        public int AddViewTimes(dx177.Model.Bus.Sites Rest)
        {
            string ip = Request.ServerVariables.Get("Remote_Addr").ToString();
            if (!DiggBLL.GetInstance().ExistsIp(Rest.Guid, ip, DiggType.ViewTimes))
            {
                Rest.Viewtimes++;
                SitesBLL.GetInstance().Update(Rest);
                return 1;
            }
            else
            {
                return 0;
            }
        }


        /// <summary>
        /// 顶，踩
        /// </summary>
        /// <param name="up"></param>
        /// <param name="seqno"></param>
        /// <returns></returns>
        
        public string AddDigg(bool up, int seqno)
        {
            object obj = new object();
            dx177.Model.Bus.Sites cm = SitesBLL.GetInstance().Get(new dx177.Model.Bus.Sites.Key(seqno));
            if (cm != null)
            {
                string ip = HttpContext.Current.Request.ServerVariables.Get("Remote_Addr").ToString();
                if (!DiggBLL.GetInstance().ExistsIp(cm.Guid, ip, DiggType.Ding))
                {
                    if (up)
                    {
                        cm.Good++;
                    }
                    else
                    {
                        cm.Bad++;
                    }
                    SitesBLL.GetInstance().Update(cm);
                    obj = new { Message = "顶成功", Result = 1 };
                }
                else
                {

                    obj = new { Message = "你已经提交过了，请勿重复提交，谢谢！", Result = 0 };
                }
            }
            else
            {
                obj = new { Message = "对象不存在", Result = 0 };
            }
            return CommonUnitl.JavaScriptSerializerString(obj);
        }

    }
}
