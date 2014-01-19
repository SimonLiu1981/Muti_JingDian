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


namespace dx177.WebUI.admin.Sys
{
    public partial class BaseDicttypeList : BasePage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                ShowData();
            }
        }

        private void ShowData()
        {
            DataTable dt = BaseDictTypeBLL.GetInstance().GetDictTagType();

            this.dgData.Data = dt;
            this.dgData.DataBind();
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            Add();
            CommonScript.AlertMessage(this.Page, "保存成功！");
        }

        private void Add()
        {
            BaseDictType b = new BaseDictType();
            b.Title = txtTitle.Text;
            b.Code = txtcode.Text;
            BaseDictTypeBLL.GetInstance().Insert(b);
            ShowData();
        }

        protected void dgData_ItemCommand(object source, DataGridCommandEventArgs e)
        {
           
            switch (e.CommandName)
            {
                case "Delete":
                    BaseDictType b = new BaseDictType();
                    b.Seqno = int.Parse(e.Item.Cells[0].Text);
                    BaseDictTypeBLL.GetInstance().Delete(b);
                    ShowData();
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
                TextBox txtTitle = e.Item.FindControl("txtTitle") as TextBox;
                TextBox txtCode = e.Item.FindControl("txtCode") as TextBox;
                LinkButton btnDelete = e.Item.FindControl("btnDelete") as LinkButton;
                btnDelete.Attributes.Add("onclick", "return confirm('确认删除吗？') ;"); ;
            }


           
        }

        protected void bntAllSave_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgData.Items.Count; i++)
            {
                int seqno = int.Parse(dgData.Items[i].Cells[0].Text);
                TextBox txtTitle = dgData.Items[i].FindControl("txtTitle") as TextBox;
                TextBox txtCode = dgData.Items[i].FindControl("txtCode") as TextBox;
                BaseDictType basedicttype = BaseDictTypeBLL.GetInstance().Get(new BaseDictType.Key(seqno));
                if (basedicttype != null)
                {
                    basedicttype.Title = txtTitle.Text;
                    basedicttype.Code = txtCode.Text;
                    BaseDictTypeBLL.GetInstance().Update(basedicttype);
                }
            }
            CommonScript.AlertMessage(this.Page, "已更新！");
        }

 
    }
}
