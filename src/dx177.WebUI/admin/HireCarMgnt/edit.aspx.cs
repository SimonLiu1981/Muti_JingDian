using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
 
using dx177.FrameWork;
using dx177.Business.DictBus;
using dx177.Model.Bus;
using dx177.Business.Bus;
using dx177.Model;

namespace dx177.WebUI.admin.HireCarMgnt
{
    public partial class eidt : BasePage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                txtGuid.Value = System.Guid.NewGuid().ToString();
                Dict.Tag.BindListControl(rbtStatus, "OpenStatus", AppContext.CurrentMgtJingQuCode);
                rbtStatus.SelectedValue = OpenStatus.Approvaled.ToString("d");//默认。。
                UCModelType1.IniData();
                InitData();
                
            }
            txtViewtimes.Attributes.Add("viewtimes_set_guid", txtGuid.Value);
        }

        public string Seqno
        {
            get
            {
                if (Request.QueryString["seqno"] == null)
                {
                    return "";
                }
                return Request.QueryString["seqno"];
            }
        }
        /// <summary>
        /// 初始化数据
        /// </summary>
        private void InitData()
        {
            if (Seqno != string.Empty)
            {
                Hirecar rest = HirecarBLL.GetInstance().Get(new Hirecar.Key(int.Parse(Seqno)));
                if (rest != null)
                {
                    txtGuid.Value = rest.Guid;
                    txtTitle.Text = rest.Title;
                   
                    txtRange.Text = rest.Range;
                    txtLinkman.Text = rest.Linkman;
                    txtTelnumber.Text = rest.Telnumber;
                    txtPrice.Text = rest.Price;
                    txtPersoncount.Text = rest.Personcount.ToString();
                    txtCarType.Text = rest.Cartype;
                    rbtStatus.SelectedValue = rest.Status.ToString();
                    txtShortContent.Text = rest.Shortcontent;
                    fckContent.Value = rest.Content;
                    txtQq.Text = rest.Qq;
                    txtAliww.Text = rest.Aliww;
                    txtViewtimes.Text = rest.Viewtimes.ToString();
                    txtShowpr.Text = rest.Showpr.ToString();
                    fckContent.Value = rest.Content;
                    UCModelType1.setModuleType(rest.Guid);
                }
            }
          
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {

            Hirecar rest = new Hirecar();
            if (Seqno != string.Empty)
            {
                rest = HirecarBLL.GetInstance().Get(new Hirecar.Key(int.Parse(Seqno)));
            }
            else
            {
                rest.Creator = AppContext.CurrentResuser.Username;
            }
            rest.Guid = txtGuid.Value;
            rest.Title = txtTitle.Text;
            
            rest.Range = txtRange.Text;
            rest.Linkman = txtLinkman.Text;
            rest.Telnumber = txtTelnumber.Text;
            rest.Price = txtPrice.Text;
            rest.Personcount = txtPersoncount.Text;
            rest.Cartype = txtCarType.Text;
            rest.Status= int.Parse(rbtStatus.SelectedValue);
            rest.Shortcontent = txtShortContent.Text;
            rest.Content = fckContent.Value;
            rest.Qq = txtQq.Text;
            rest.Aliww = txtAliww.Text;
            rest.Showpr = txtShowpr.Text == string.Empty ? 0 : int.Parse(txtShowpr.Text);
            rest.Viewtimes = txtViewtimes.Text == string.Empty ? 0 : int.Parse(txtViewtimes.Text);
            rest.Content = fckContent.Value;
            rest.Jingqucode = AppContext.CurrentMgtJingQuCode;
            HirecarBLL.GetInstance().Submit(rest);
            ModuleBLL.GetInstance().Submit(UCModelType1.GetModuleType(), rest.Guid);
            btnReturn_Click(null, null);
        }

        protected void btnReturn_Click(object sender, EventArgs e)
        {
            Response.Redirect(Request.QueryString["r"]);
        }

        
        
    }
}
