using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using dx177.Model.Bus;
using dx177.Business.Bus;
using dx177.Model;
using dx177.FrameWork;
using dx177.Business.DictBus;

namespace dx177.WebUI.admin.RestaurantMgnt
{
    public partial class edit : BasePage
    {

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
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                txtGuid.Value = System.Guid.NewGuid().ToString();
                Dict.Tag.BindListControl(rbtStatus, "OpenStatus", AppContext.CurrentMgtJingQuCode);
                rbtStatus.SelectedValue = OpenStatus.Approvaled.ToString("d");
                Dict.Tag.BindListControl(drpRestaurantType, "RestaurantType", AppContext.CurrentMgtJingQuCode);
                drpRestaurantType.Items.Insert(0, new ListItem("请选择", ""));
                Dict.Tag.BindListControl(drpArea, "AREA", AppContext.CurrentMgtJingQuCode);
                drpArea.Items.Insert(0, new ListItem("请选择", ""));
                UCModelType1.IniData();
                InitData();
                RefeshCookBook();
            }

            txtViewtimes.Attributes.Add("viewtimes_set_guid", txtGuid.Value);
            
        }
        private void InitData()
        {
            if (Seqno != string.Empty)
            {
                Restaurant rest = RestaurantBLL.GetInstance().Get(new Restaurant.Key(int.Parse(Seqno)));
                if (rest != null)
                {
                    txtGuid.Value = rest.Guid;
                    txtTitle.Text = rest.Title;
                                       
                    txtAddress.Text = rest.Address;
                    txtLinkMan.Text = rest.Linkman;
                    txtTelNumber.Text = rest.Telnumber;
                    txtCost.Text = rest.Cost.ToString("0.0");
                    txtFavorable.Text = rest.Favorable;
                    fckContent.Value = rest.Content;
                    rbtStatus.SelectedValue = rest.Status.ToString();
                    drpArea.SelectedValue = rest.Area;
                    drpRestaurantType.SelectedValue = rest.Restauranttype;
                    txtShortContent.Text = rest.Shortcontent;
                    txtMap.Text = rest.Map;
                    txtQQ.Text = rest.Qq;
                    txtViewtimes.Text = rest.Viewtimes.ToString();
                    txtShowpr.Text = rest.Showpr.ToString();
                    txtAliww.Text = rest.Aliww;
                    fckContent.Value = rest.Content;
                    UCModelType1.setModuleType(rest.Guid);
                }
            }
           
        }

        private void RefeshCookBook()
        {
            //绑定菜谱
            this.dgNews.Data = CookbookBLL.GetInstance().GetCookBookByPGuid(txtGuid.Value);
            this.dgNews.DataBind();
        }

        protected void dgNews_ItemCommand(object source, DataGridCommandEventArgs e)
        {
             CookbookBLL bll = CookbookBLL.GetInstance();
             switch (e.CommandName)
             {
                 case "Delete":

                     CookbookBLL.GetInstance().RemoveBySeqno(int.Parse(e.Item.Cells[0].Text));
                     RefeshCookBook();
                     break;
             }

        }

        protected void dgNews_ItemDataBound(object sender, DataGridItemEventArgs e)
        {

        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            Restaurant rest = new Restaurant();
            if (Seqno != string.Empty)
            {
                rest = RestaurantBLL.GetInstance().Get(new Restaurant.Key(int.Parse(Seqno)));
            }
            else
            {
                rest.Creator = AppContext.CurrentResuser.Username;
                rest.CreateDate = DateTime.Now;
            }
            rest.Guid = txtGuid.Value;
            rest.Title = txtTitle.Text;
           
            rest.Address = txtAddress.Text;
            rest.Linkman = txtLinkMan.Text;
            rest.Telnumber = txtTelNumber.Text;
            rest.Cost = double.Parse(txtCost.Text);
            rest.Favorable = txtFavorable.Text;
            rest.Content = fckContent.Value;
            rest.Shortcontent = txtShortContent.Text;
            rest.Map = txtMap.Text;
            rest.Qq = txtQQ.Text;
            rest.Status = int.Parse(rbtStatus.SelectedValue);
            rest.Aliww = txtAliww.Text;
            rest.Jingqucode = AppContext.CurrentMgtJingQuCode;
            
            rest.Area = drpArea.SelectedValue;
            rest.Restauranttype = drpRestaurantType.SelectedValue;
            rest.Showpr =txtShowpr.Text==string.Empty ?0: int.Parse(txtShowpr.Text);
            rest.Viewtimes = txtViewtimes.Text == string.Empty ? 0 : int.Parse(txtViewtimes.Text);
            rest.Content = fckContent.Value;
            RestaurantBLL.GetInstance().Submit(rest);
            ModuleBLL.GetInstance().Submit(UCModelType1.GetModuleType(), rest.Guid);
            btnReturn_Click(null, null);
        }

        protected void btnReturn_Click(object sender, EventArgs e)
        {
            Response.Redirect(Request.QueryString["r"]);
        }

        
        

        protected void btnRefeshBook_Click(object sender, EventArgs e)
        {
            RefeshCookBook();
        }
    }
}
