using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using dx177.Business.DictBus;
using dx177.FrameWork;
using dx177.Model.Bus;
using dx177.Business.Bus;
using dx177.Model;

namespace dx177.WebUI.web.admin
{
    public partial class member_publish_Restaurant : ResUserBasePage
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
                Dict.Tag.BindListControl(drpRestaurantType, "RestaurantType", AppContext.JingQuCode);
                drpRestaurantType.Items.Insert(0, new ListItem("请选择", ""));
                Dict.Tag.BindListControl(drpArea, "AREA", AppContext.JingQuCode);
                drpArea.Items.Insert(0, new ListItem("请选择", ""));

                InitData();
                RefeshCookBook();
            }
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
                     
                    drpArea.SelectedValue = rest.Area;
                    drpRestaurantType.SelectedValue = rest.Restauranttype;
                    txtShortContent.Text = rest.Shortcontent; 
                }
            }
        }

        private void RefeshCookBook()
        {
            //绑定菜谱
            this.lvCookBookList.DataSource = CookbookBLL.GetInstance().GetCookBookByPGuid(txtGuid.Value);
            this.lvCookBookList.DataBind();
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
                rest.Status = (int)OpenStatus.Application;
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
            //rest.Map = txtMap.Text;
            //rest.Qq = txtQQ.Text;
            
            //rest.Aliww = txtAliww.Text;

            rest.Jingqucode = AppContext.JingQuCode;
            rest.Area = drpArea.SelectedValue;
            rest.Restauranttype = drpRestaurantType.SelectedValue;
            //rest.Showpr = txtShowpr.Text == string.Empty ? 0 : int.Parse(txtShowpr.Text);
            //rest.Viewtimes = txtViewtimes.Text == string.Empty ? 0 : int.Parse(txtViewtimes.Text);
            RestaurantBLL.GetInstance().Submit(rest);
            //ModuleBLL.GetInstance().Submit(UCModelType1.GetModuleType(), rest.Guid);

            if (!string.IsNullOrEmpty(Request.QueryString["r"]))
            {
                Response.Redirect(Request.QueryString["r"]);
            }
            else
            {
                Response.Redirect("/member-Restaurantlist.aspx");
            }     
        }

        protected void btnAddCookBook_Click(object sender, EventArgs e)
        {

        }

        protected void lvCookBookList_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
             
            switch (e.CommandName)
            {
                case "Delete1":
                    CookbookBLL.GetInstance().RemoveBySeqno(int.Parse(e.CommandArgument.ToString()));
                    RefeshCookBook();
                    break;
            }
        }

        protected void btnSearchCookBook_Click(object sender, EventArgs e)
        {
            RefeshCookBook();
        }
    }
}
