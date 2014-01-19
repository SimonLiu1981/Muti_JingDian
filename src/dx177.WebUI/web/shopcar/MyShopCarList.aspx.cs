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
using dx177.FrameWork;
using dx177.Model;
using dx177_building;
using System.IO;
using dx177.Business.Bus;
using System.Collections.Generic;

namespace dx177.WebUI.web.shopcar
{
    public partial class MyShopCarList : System.Web.UI.Page
    {
        private string productid
        {
            get
            {
                if (Request.QueryString["productid"] != null)
                {
                    return ComSafe.SafeValue(Request.QueryString["productid"]);
                }
                return "0";
            }
        }

        private int Num
        {
            get
            {
                if (Request.QueryString["Num"] != null)
                {
                    try
                    {
                        return Convert.ToInt32(Request.QueryString["Num"]);
                    }
                    catch (Exception ex)
                    {
                        return 1;
                    }
                }
                return 1;
            }
        }
        public string strHtml = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ShoppingCarHelper.ModifyProducts(this.productid, Num);
                //显示选定的购物列表
            }
            InitData();
        }
        public object    ModifyProducts(string productid, int count)
        {
            
              ShoppingCarHelper.ModifyProducts(productid, count);
              return new { totalamout = ShoppingCarHelper.TotalAmount.ToString() };
        }

        public bool RemoveProducts(string productid)
        {
            return ShoppingCarHelper.RemoveProducts(productid);
        }


        
        private void InitData()
        {
            Hashtable hs = new Hashtable();
            if (ShoppingCarHelper.MyChoseProducts != null)
            {
                DataTable dt = DataExchange.NewDataTableForObjEntity(new ShoppingCarEntriy());
                foreach (ShoppingCarEntriy shoppingcarentriy in ShoppingCarHelper.MyChoseProducts)
                {
                    DataRow dr = dt.NewRow();
                    DataExchange.CopyEntityToDataRow(shoppingcarentriy, dr);
                    dt.Rows.Add(dr);
                }
                hs.Add("SHOPCARLIST", dt);
            }
            // ObjToEntity
            string savepath = "";
            string path = "~/Templates/xml/hotel/MyShopCarList.xml";
            strHtml = BuildPageHtml.GetPageHtml(path, ref savepath, hs);
            hs.Clear();
            hs.Add("TOTAL", ShoppingCarHelper.TotalAmount.ToString());
            strHtml = BuildCommon.GetHtmlByHash(hs, strHtml);
        }

 

    }
}
