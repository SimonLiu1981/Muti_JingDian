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
using dx177.Model;

namespace dx177.WebUI.admin.Sys
{
    public partial class sysMapcodeList : BasePage
    {
        public string Type
        {
            get
            {
                if (Request.QueryString["type"] != null)
                {
                    return Request.QueryString["type"];
                }
                return "";
            }
            
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                IniData();
            }
        }

        private void IniData()
        {
            DataTable dt = SyscodemapBLL.GetInstance().GetSyscodemapListBytype(this.Type, txttypename.Text, txtname.Text, AppContext.CurrentMgtJingQuCode);
            dgData.Data = dt;
            dgData.DataBind();
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            IniData();
        }


        protected void dgData_ItemCommand(object source, DataGridCommandEventArgs e)
        {
            switch (e.CommandName)
            {
                case "Delete":
                    Syscodemap b = new Syscodemap();
                    b.SyscodemapId = int.Parse(e.Item.Cells[0].Text);
                    SyscodemapBLL.GetInstance().Delete(b);
                    IniData();
                    break;
                default:
                    break;
            }
        }

        protected void dgData_ItemDataBound(object sender, DataGridItemEventArgs e)
        {
            if (e.Item.ItemType == ListItemType.AlternatingItem ||
                e.Item.ItemType == ListItemType.Item)
            {
                LinkButton btnDelete = e.Item.FindControl("btnDelete") as LinkButton;
                btnDelete.Attributes.Add("onclick", "return confirm('确认删除吗？') ;"); ;
            }

        }
    }
}
