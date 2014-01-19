using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using dx177.Business.Bus;
using dx177.Model;
using dx177.Model.Bus;
using dx177.FrameWork;

namespace dx177.WebUI.admin.JingQuMgnt
{
    public partial class AreaList : BasePage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Jingqus jq = JingqusBLL.GetInstance().GetEntityByJingqucode(AppContext.CurrentMgtJingQuCode);
                lblJingQuName.Text = jq.Jingquname;
                this.txtJingQuID.Value = "0";
                this.btnAdd.Text = "新增[" + lblJingQuName.Text + "]区域";
                BindGrid();
            }
        }
        private void BindGrid()
        {
            this.dgNews.Data = JingquAreaBLL.GetInstance().GetByJingqucode(AppContext.CurrentMgtJingQuCode);
            this.dgNews.DataBind();                
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            JingquArea ja = new JingquArea();

            if (txtJingQuID.Value != "0")
            {
                ja = JingquAreaBLL.GetInstance().Get(new JingquArea.Key(int.Parse(this.txtJingQuID.Value)));
            }
            ja.Areaname = txtAreaName.Text;
            ja.Jinqqucode = AppContext.CurrentMgtJingQuCode;
            JingquAreaBLL.GetInstance().Submit(ja);
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
                    this.txtJingQuID.Value = e.CommandArgument.ToString();
                    JingquArea ja = JingquAreaBLL.GetInstance().Get(new JingquArea.Key(int.Parse(this.txtJingQuID.Value)));
                    txtAreaName.Text = ja.Areaname;
                    this.tdEdit.Visible = true;
                    break;
                default:

                    break;
            }
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            this.tdEdit.Visible = true;
            this.txtJingQuID.Value = "0";
            txtAreaName.Text = "";

        }
    }
}
