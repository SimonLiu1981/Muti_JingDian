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
using dx177.Business.DictBus;
using dx177.Model;

namespace dx177.WebUI.admin.Sys
{
    public partial class sysMapcodePage : BasePage
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

        public string type
        {
            get
            {
                if (Request.QueryString["type"] == null)
                {
                    return "";
                }
                return  Request.QueryString["type"] ;
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
            if (Seqno > 0)
            {
                Syscodemap rest = SyscodemapBLL.GetInstance().Get(new Syscodemap.Key(Seqno));
                if (rest != null)
                {
                    txtName.Text = rest.Name;
                    txttype.Text = rest.Type;
                    txtTypeName.Text = rest.Typename;
                    txtval.Text = rest.Val;
                }
            }
            else
            {
                txttype.Text = this.type;
            }
        }


        /// <summary>
        /// 回答
        /// </summary>
        /// <param name="seqno"></param>
        /// <param name="content"></param>
        /// <param name="bad"></param>
        /// <param name="good"></param>
        /// <param name="isRight"></param>
        /// <returns></returns>
        
        public string Update(int seqno, string Name, string val, string Type, string TypeName)
        {
            Syscodemap rest = new Syscodemap();
            if (seqno > 0)
            {
                rest = SyscodemapBLL.GetInstance().Get(new Syscodemap.Key(seqno));
            }
            rest.Name = Name;
            rest.Type = Type;
            rest.Typename = TypeName;
            rest.Val = val;
            SyscodemapBLL.GetInstance().Submit(rest, AppContext.CurrentMgtJingQuCode);
            return "1";
        }


    }
}
