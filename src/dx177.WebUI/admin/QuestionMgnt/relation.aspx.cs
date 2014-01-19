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
using dx177.Model.Bus.QueryO;
using dx177.Model;
using System.Collections.Generic;
using dx177.Business.DictBus;

namespace dx177.WebUI.admin.QuestionMgnt
{
    public partial class relation :BasePage
    {
        protected string Seqno
        {
            get
            {
                return Request["seqno"];
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Dict.Tag.BindListControl(this.ddlStatus, "QuestionStatus", AppContext.CurrentMgtJingQuCode);
                this.ddlStatus.Items.Insert(0, new ListItem("请选择", ""));
                InitizalData();     
            }
        }

        private void InitizalData()
        {

            if (Seqno != string.Empty)
            {
                Questions rest = QuestionsBLL.GetInstance().Get(new Questions.Key(int.Parse(Seqno)));
                if (rest != null)
                {
                    txtOriginalGuid.Value = rest.Guid;
                    lblTitle.Text = rest.Title;
                    //绑定子答复列表
                    Repeater1.DataSource = QuestionralationsBLL.GetInstance().GetRelateQuestions(rest.Guid);
                    Repeater1.DataBind();

                    btnSearch_Click(null, null);
                }

            }
        }

        protected void btnDelSelectQuestion_Click(object sender, EventArgs e)
        {
            string guids = txtRelateGuids.Value;
            foreach (string tmp in guids.Split(','))
            {
                if (tmp != string.Empty)
                {
                    QuestionralationsBLL.GetInstance().DeleteRelation(txtOriginalGuid.Value, tmp);
                }
            }
            InitizalData();
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            QuestionsQuery query = new QuestionsQuery();
            query.Title = txtName.Text;
            query.QuestStatus = ddlStatus.SelectedValue;
            query.JingQuCode = AppContext.CurrentMgtJingQuCode;
            IList<Questions> res = QuestionsBLL.GetInstance().Search(query);

            DataTable dt = QuestionralationsBLL.GetInstance().GetRelateQuestions(txtOriginalGuid.Value);

            for (int i = res.Count;  i > 0; i--)
            {
                Questions obj = res[i-1];
                if (obj.Seqno.ToString() == Seqno)
                {
                    res.Remove(obj);
                }
                foreach (DataRow dr in dt.Rows)
                {
                    if (dr["seqno"].ToString() == obj.Seqno.ToString())
                    {
                        res.Remove(obj);
                    }                    
                }
                
            }
            this.dgNews.Data = res;
            this.dgNews.DataBind();

        }

        protected void dgNews_ItemDataBound(object sender, DataGridItemEventArgs e)
        {
            if (e.Item.ItemType == ListItemType.Header)
            {
                CheckBox cbxAll = e.Item.FindControl("chkAll") as CheckBox;
                if (cbxAll != null)
                    cbxAll.Attributes.Add("onclick", "javascript:return SelectAll('" + dgNews.ClientID + "');");
            }

        }

        protected void bntAddRelation_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgNews.Items.Count; i++)
            {
                CheckBox chkGrid = dgNews.Items[i].FindControl("chkGrid") as CheckBox;
                if (chkGrid.Checked)
                {
                    string GUID = dgNews.Items[i].Cells[0].Text;
                    QuestionralationsBLL.GetInstance().InsertRelation(txtOriginalGuid.Value, GUID);
                }
            }

            InitizalData();
        }

        protected void btnReturn_Click(object sender, EventArgs e)
        {
            Response.Redirect(Request.QueryString["r"]);
        }
    }
}
