using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using dx177.Business.Bus;
using dx177.FrameWork;
using dx177.Model.Bus;

namespace dx177.WebUI.admin.JingQuMgnt
{
    public partial class List : BasePage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!base.IsSupperAdmin())
            {
                Logout();
                return;
            }
            if (!IsPostBack)
            {
                txtCommonAreaID.Value = "0";

                BindGrid();
            }
        }

        private void BindGrid()
        {
            this.dgNews.Data = JingqusBLL.GetInstance().Select();
            this.dgNews.DataBind();
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            Jingqus ja = new Jingqus();
            ja.Guid = StringUtil.getGuid();
            List<string> lssubjingqu = new List<string>();
            if (txtJingQuID.Value != "0")
            {
                ja = JingqusBLL.GetInstance().Get(new Jingqus.Key(int.Parse(this.txtJingQuID.Value)));
              
                for (int i = 0; i < chkChildJingQu.Items.Count; i++)
                {
                    if (chkChildJingQu.Items[i].Selected)
                        lssubjingqu.Add(chkChildJingQu.Items[i].Value);
                }
            }
            ja.Jingqucode = txtJingQuCode.Text;
            ja.Jingquname = txtJingQuName.Text;
            ja.Matchdomain = txtMatchDomain.Text;
            ja.Showidx = int.Parse(txtShowIdx.Text);
            ja.Navigation = txtNavigation.Value;
            ja.Sumary = fckContent.Value;
            ja.Areaid = int.Parse(txtCommonAreaID.Value);
            ja.Priceinfo = txtPriceinfo.Text.Trim();
            ja.Weatherinfo = txtWeatherInfo.Text.Trim();
            ja.Navigationswitch = chbNavigationSwitch.Checked;
            JingqusBLL.GetInstance().Submit(ja, lssubjingqu);

            CommonScript.AlertMessage(this, "编辑成功！");
            BindGrid();

            this.tdEdit.Attributes.Add("style", "display:none");
            
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
                    Jingqus ja = JingqusBLL.GetInstance().Get(new Jingqus.Key(int.Parse(this.txtJingQuID.Value)));
                    txtJingQuName.Text = ja.Jingquname;
                    txtJingQuID.Value = ja.JingquId.ToString();
                    txtJingQuCode.Text = ja.Jingqucode;
                    txtMatchDomain.Text = ja.Matchdomain;
                    fckContent.Value = ja.Sumary;
                    txtNavigation.Value = ja.Navigation;
                    txt1Guid.Value = ja.Guid;
                    txtShowIdx.Text = ja.Showidx.ToString();
                    txtCommonAreaID.Value = ja.Areaid.ToString();
                    txtPriceinfo.Text = ja.Priceinfo;
                    txtWeatherInfo.Text = ja.Weatherinfo;
                    chbNavigationSwitch.Checked = ja.Navigationswitch;
                    if (ja.Areaid > 0 && string.IsNullOrEmpty(ja.Parent))
                    {
                       List<Jingqus> JingqusArr = JingqusBLL.GetInstance().GetJinQusByAreaid(ja.Areaid, ja.JingquId);
                       chkChildJingQu.DataValueField = "Jingqucode";
                       chkChildJingQu.DataTextField = "Jingquname";
                       chkChildJingQu.DataSource = JingqusArr;
                       chkChildJingQu.DataBind();
                       List<Jingqus>  ChildJingqusArr= JingqusBLL.GetInstance().GetJinQusByParent(ja.Jingqucode);
                       if (ChildJingqusArr != null && ChildJingqusArr.Count > 0)
                       {
                           for (int i = 0; i < chkChildJingQu.Items.Count; i++)
                           {
                               foreach (Jingqus j in JingqusArr)
                               {
                                   if (chkChildJingQu.Items[i].Value == j.Jingqucode)
                                   {
                                       chkChildJingQu.Items[i].Selected = true;
                                   }
                               }
                           }
                       }
                    }

                    this.tdEdit.Attributes.Add("style", "display:");
                    break;
                default:

                    break;
            }
        }


        protected void btnReturn_Click(object sender, EventArgs e)
        {

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            this.tdEdit.Attributes.Add("style", "display:");
            this.txtJingQuID.Value = "0";
            txtJingQuName.Text = string.Empty;
            txtJingQuCode.Text = string.Empty;
            txtMatchDomain.Text = string.Empty;
            fckContent.Value = string.Empty;
            txtShowIdx.Text = "0";
            txtCommonAreaID.Value = "0";
            txtNavigation.Value = string.Empty;
            txtWeatherInfo.Text = string.Empty;
            txtPriceinfo.Text = string.Empty;
            chbNavigationSwitch.Checked = false;
        }

        protected void ChildJingquGrid_ItemCommand(object source, DataGridCommandEventArgs e)
        {

        }
    }
}
