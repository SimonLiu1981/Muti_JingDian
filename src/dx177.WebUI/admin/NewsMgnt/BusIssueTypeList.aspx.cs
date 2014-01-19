using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using dx177.Business.Bus;
using dx177.Model.Bus;
using dx177.Model;
using dx177.FrameWork;

namespace dx177.WebUI.admin.NewsMgnt
{
    public partial class BusIssueTypeList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Jingqus jq = JingqusBLL.GetInstance().GetEntityByJingqucode(AppContext.CurrentMgtJingQuCode);
                lblJingQuName.Text = jq.Jingquname;
                this.txtIssueTypeID.Value = "0";
                this.btnAdd.Text = "新增[" + lblJingQuName.Text + "]文章类型";
                BindGrid();
            }
        }

        private void BindGrid()
        {
            this.dgNews.Data = BusIssueTypeBLL.GetInstance().GetByJingqucode(AppContext.CurrentMgtJingQuCode);
            this.dgNews.DataBind();   
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            BusIssueType ja = new BusIssueType();

            if (txtIssueTypeID.Value != "0")
            {
                ja = BusIssueTypeBLL.GetInstance().Get(new BusIssueType.Key(int.Parse(this.txtIssueTypeID.Value)));
            }
            ja.BusIssueTypeName = txtTypeName.Text;
            ja.Jinqqucode = AppContext.CurrentMgtJingQuCode;
            BusIssueTypeBLL.GetInstance().Submit(ja);
            CommonScript.AlertMessage(this, "编辑成功！");
            BindGrid();
            this.tdEdit.Visible = false;
        }

        protected void btnReturn_Click(object sender, EventArgs e)
        {

        }


        protected void dgNews_ItemDataBound(object sender, DataGridItemEventArgs e)
        {


        }

        protected void dgNews_ItemCommand(object source, DataGridCommandEventArgs e)
        {
            switch (e.CommandName)
            {
                case "Delete":


                    break;
                case "Modify":
                    this.txtIssueTypeID.Value = e.CommandArgument.ToString();
                    BusIssueType ja = BusIssueTypeBLL.GetInstance().Get(new BusIssueType.Key(int.Parse(this.txtIssueTypeID.Value)));
                    txtTypeName.Text = ja.BusIssueTypeName;
                    this.tdEdit.Visible = true;
                    break;
                default:

                    break;
            }
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            this.tdEdit.Visible = true;
            this.txtIssueTypeID.Value = "0";
            txtTypeName.Text = "";

        }
    }
}
