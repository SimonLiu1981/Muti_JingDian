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
using dx177.FrameWork;
using dx177.Model.Bus;

namespace dx177.WebUI.Wapper.jingdia
{
    public partial class list : System.Web.UI.Page
    {
      

        public string k1
        {
            get
            {
                string _k1 = Request["k1"] == null ? "" : Request["k1"].ToString();
                return ComSafe.SafeValue(_k1);
            }
        }

        public string k0
        {
            get
            {
                string k0 = Request["k0"] == null ? "" : Request["k0"].ToString();
                return ComSafe.SafeValue(k0);
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            KeyWord();


            rpProvince.DataSource = CommonAreaBLL.GetInstance().GetProvince();
            rpProvince.DataBind();
            ShowData();

        }

        private void KeyWord()
        {
            string keyword1 = "";
            string keyword0 = "";

            if (k1 != string.Empty)
            {
                keyword1 = CommonAreaBLL.GetInstance().GetByAreaName(this.k1);
            }
            if (k0 != string.Empty)
            {
                keyword0 = CommonAreaBLL.GetInstance().GetByAreaName(this.k0);
            }

            Hashtable hs = new Hashtable();
            hs.Add("Title_TypeName", keyword0 + keyword1);
            dx177.Business.Bus.CommonBLL.GetInstance().IniPageKeyWord(this.Page, "jingqu", hs);

        }
        private void ShowData()
        {
            KeyWord();

            this.LsHotelList.DataSource = JingqusBLL.GetInstance().SearchByConditions(this.k1, this.k0);
            this.LsHotelList.DataBind();
        }
        protected void LsHotelList_ItemDataBound(object sender, ListViewItemEventArgs e)
        {
            if (e.Item.ItemType == ListViewItemType.DataItem)
            {

                HtmlInputHidden txtAreaId = e.Item.FindControl("txtAreaId") as HtmlInputHidden;
                Literal lblAddress = e.Item.FindControl("lblAddress") as Literal;

                if (txtAreaId.Value != "")
                {
                    CommonArea ca = CommonAreaBLL.GetInstance().Get(new CommonArea.Key(int.Parse(txtAreaId.Value)));
                    string template = "<a href='{0}'>{1}</a>";
                    if (ca.Depth == 1)
                    {
                        lblAddress.Text = string.Format(template, UrlUtility.AddOrReplaceParam("", "k0", ca.Areaid.ToString(), true), ca.Areaname); 
                    }
                    if (ca.Depth == 2)
                    {
                        CommonArea caparent = CommonAreaBLL.GetInstance().Get(new CommonArea.Key(ca.Pareaid));

                        lblAddress.Text = string.Format(template, UrlUtility.AddOrReplaceParam("", "k0", caparent.Areaid.ToString(), true), caparent.Areaname);

                        lblAddress.Text += "-" + string.Format(template, UrlUtility.AddOrReplaceParam("", "k0", ca.Areaid.ToString(), true), ca.Areaname);

                    }
                    if (ca.Depth == 3)
                    {
                        CommonArea caparent = CommonAreaBLL.GetInstance().Get(new CommonArea.Key(ca.Pareaid));
                        CommonArea caparentparent = CommonAreaBLL.GetInstance().Get(new CommonArea.Key(ca.Pareaid));

                        lblAddress.Text =  string.Format(template, UrlUtility.AddOrReplaceParam("", "k0", caparentparent.Areaid.ToString(), true), caparentparent.Areaname);

                        lblAddress.Text += "-" + string.Format(template, UrlUtility.AddOrReplaceParam("","k0",caparent.Areaid.ToString(),true), caparent.Areaname);

                        lblAddress.Text += "-" + string.Format(template, UrlUtility.AddOrReplaceParam("", "k0", ca.Areaid.ToString(), true), ca.Areaname); 
                    }
                    //BaseDictTagBLL.GetInstance().GetDictTag("HoteInst");
                    ////lbHotelnst
                }
            }
        }

        protected void LsHotelList_PagePropertiesChanging(object sender, PagePropertiesChangingEventArgs e)
        {

            DataPager1.SetPageProperties(e.StartRowIndex, e.MaximumRows, false);
            ShowData();
        }
        protected void DataPager1_PreRender(object sender, EventArgs e)
        {
            DataPager pager = (DataPager)sender;
            new PagingHelper().ProcessPaging(pager, this);
        }
        
    }
}
