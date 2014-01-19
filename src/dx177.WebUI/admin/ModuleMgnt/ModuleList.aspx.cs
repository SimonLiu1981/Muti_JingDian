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
using dx177.Model.Bus.QueryO;
using dx177.Model.Bus;

namespace dx177.WebUI.admin.ModuleMgnt
{
    public partial class ModuleList :BasePage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                IniData();
                ShowData();
            }
        }

        private void IniData()
        {
           DataTable dt = ModuletypeBLL.GetInstance().GetModuleType("");
           drpModule.DataSource = dt;
           drpModule.DataTextField = "title";
           drpModule.DataValueField = "code";
           drpModule.DataBind();
           drpModule.Items.Insert(0, new ListItem("请选择", ""));
        }

        private void ShowData()
        {
            ModuleQuery q =new  ModuleQuery () ;
            q.code=drpModule.SelectedValue;
            q.Type=drpType.SelectedValue ;
            q.Title=txtTitle.Text ;
            dgModule.Data= ModuleBLL.GetInstance().GetData(q);
            dgModule.DataBind();
        
        }


        protected void dgHotel_ItemDataBound(object sender, DataGridItemEventArgs e)
        {
            if (e.Item.ItemIndex > -1)
            {
             //   e.Item.Cells[3].Text = Dict.Tag["Shoptype", e.Item.Cells[3].Text, 2052];

            }
        }

        protected void dgHotel_ItemCommand(object source, DataGridCommandEventArgs e)
        {

            switch (e.CommandName)
            {
                case "Delete":
                    Module m = new Module();  // ModuleBLL.GetInstance().Get(new Module.Key(int.Parse(e.CommandArgument.ToString())));
                    m.Seqno =int.Parse(e.CommandArgument.ToString());

                    ModuleBLL.GetInstance().Delete(m);
                    ShowData() ;
                    break;
                case "Modify":
                    //string url = UrlUtility.AddOrReplaceParam("ShopPage.aspx", "seqno", e.CommandArgument.ToString(), true);
                    //Response.Redirect(url);
                    break;
                default:
                    break;
            }
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            ShowData();
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgModule.Items.Count; i++)
            {
                 
                TextBox txtShowidx = dgModule.Items[i].FindControl("txtShowidx") as TextBox;
                if (txtShowidx != null && txtShowidx.Text!=string.Empty )
                {
                   Module m= ModuleBLL.GetInstance().Get(new Module.Key(int.Parse(dgModule.Items[i].Cells[0].Text)));
                   m.Showidx = int.Parse(txtShowidx.Text);
                   ModuleBLL.GetInstance().Update(m);
                }
            }
        }
    }
}
