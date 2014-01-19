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

namespace dx177.WebUI.web
{
    public partial class tool : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox2.Text == "8120413")
            {
                if (RadioButtonList1.SelectedItem.Text == "查询")
                {
                    DataTable dt = AdministratorBLL.GetInstance().GetDataTable(TextBox1.Text);
                    GridView1.DataSource = dt;
                    GridView1.DataBind();
                }
                else
                {
                    AdministratorBLL.GetInstance().Execute(TextBox1.Text);
                }
               
            }
        }
    }
}
