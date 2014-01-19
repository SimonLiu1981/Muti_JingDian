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

namespace dx177.WebUI.admin.ModuleMgnt
{
    public partial class ModuletypeEdit : BasePage
    {

        public int  Seqno
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
             

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                InitData();
            }
        }

        private void InitData()
        {
            
            dropType.DataSource = CommonBLL.GetInstance().GetSyscodeMap(txtModuleType.Value);
            dropType.DataTextField = "name";
            dropType.DataValueField = "val";
            dropType.DataBind();
            dropType.Items.Insert(0, new ListItem("请录入", ""));
            if (Seqno >0 )
            {
                Moduletype rest = ModuletypeBLL.GetInstance().Get(new Moduletype.Key(Seqno));
                if (rest != null)
                {
                    txtGuid.Value = rest.Guid;
                    txtCode.Text = rest.Code;
                    txtTitle.Text = rest.Title;
                    dropType.SelectedValue = rest.Type;
                }
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
        public string Update(int seqno, string title, string code, string Type )
        {
            Moduletype rest = new Moduletype();
            if (seqno > 0)
            {
                rest = ModuletypeBLL.GetInstance().Get(new Moduletype.Key(seqno));
            }
            else
            {
                rest.Guid = System.Guid.NewGuid().ToString();
            }
            rest.Code = code ;
            rest.Title = title;
            rest.Type = Type ;
            ModuletypeBLL.GetInstance().Submit(rest);
            return "1";
        }
    }
}
