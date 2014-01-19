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

namespace dx177.WebUI.admin.ModuleMgnt
{
    public partial class ModuleTypeList : BasePage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                inidata();
                ShowData();
            }
        }

        private void inidata()
        {
            drpType.DataSource = CommonBLL.GetInstance().GetSyscodeMap(txtModuleType.Value);
            drpType.DataTextField = "name";
            drpType.DataValueField = "val";
            drpType.DataBind();
            drpType.Items.Insert(0, new ListItem("请录入", ""));

        }

        public void ShowData()
        {

            DataTable dt = ModuletypeBLL.GetInstance().GetModuleType(drpType.SelectedValue);
            dgModule.Data = dt;
            dgModule.DataBind();
        }

        protected void dgModule_ItemDataBound(object sender, DataGridItemEventArgs e)
        {
            if (e.Item.ItemIndex > -1)
            {

                DataTable dt =CommonBLL.GetInstance().GetSyscodeMap(txtModuleType.Value);
                Label lbType = e.Item.FindControl("lbType") as Label;
                DataRow[] dataArr = dt.Select("val='" + lbType.Text + "'");
                if (dataArr!=null && dataArr.Length>0)
                {
                    lbType.Text = dataArr[0]["name"].ToString();
                }

                //   e.Item.Cells[3].Text = Dict.Tag["Shoptype", e.Item.Cells[3].Text, 2052];

            }
        }

        protected void dgModule_ItemCommand(object source, DataGridCommandEventArgs e)
        {

            switch (e.CommandName)
            {
                case "Delete":
                    Moduletype m = new Moduletype();  // ModuleBLL.GetInstance().Get(new Module.Key(int.Parse(e.CommandArgument.ToString())));
                    m.Seqno = int.Parse(e.CommandArgument.ToString());

                    ModuletypeBLL.GetInstance().Delete(m);
                    ShowData();
                    break;
                   
                default:
                    break;
            }
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            ShowData();
        }
    }
}
