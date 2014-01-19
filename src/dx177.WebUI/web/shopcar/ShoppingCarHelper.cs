using System;
using System.Collections.Generic;
using System.Web;
  
  
using dx177.Model.Bus;
using dx177.Business.Bus;


namespace dx177.WebUI.web.shopcar
{
 

    public class ShoppingCarHelper
    {

        private static string m_ProductSeller = "m_ProductSeller";

        /// <summary>
        /// 当前产品卖出人
        /// </summary>
        public static string ProductSeller
        {
            get
            {
                if (HttpContext.Current.Session[m_ProductSeller] == null)
                {
                    HttpContext.Current.Session[m_ProductSeller] = string.Empty;
                }
                return HttpContext.Current.Session[m_ProductSeller] as string;
            }
            set
            {
                HttpContext.Current.Session[myChoseCarProductKey] = value;
            }
        }

        private static string m_MyUseraddressinfoEn = "myuseraddressinfoen";

        /// <summary>
        /// 我的英文地址
        /// </summary>
        public static Useraddressinfo MyUseraddressinfoEn
        {
            get
            {
                if (HttpContext.Current.Session[m_MyUseraddressinfoEn] == null)
                {
                    return null;
                }
                return HttpContext.Current.Session[m_MyUseraddressinfoEn] as Useraddressinfo;
            }
            set
            {
                HttpContext.Current.Session[m_MyUseraddressinfoEn] = value;
            }
        }


        public static int TotalNumber
        {
            get
            {
                int res = 0;
                foreach (ShoppingCarEntriy tmp in MyChoseProducts)
                {
                    res += tmp.Count;
                }
                return res;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        public static decimal TotalAmount
        {
            get
            {
                decimal res = 0;
                foreach (ShoppingCarEntriy tmp in MyChoseProducts)
                {
                    res += tmp.Total;                    
                }
                return res;
            }
        }


        /// <summary>
        /// 购物车的总重量。
        /// </summary>
        public static double TotalWeight
        {
            get
            {
                double  res = 0;
                foreach (ShoppingCarEntriy tmp in MyChoseProducts)
                {
                    if (!tmp.NotCarriage)
                    {
                        res += tmp.TotalWeight;
                    }                     
                }
                return res;
            }
        }


        private static string myChoseCarProductKey = "MyChoseProducts";

        public static List<ShoppingCarEntriy> MyChoseProducts
        {
            get
            {
                if (HttpContext.Current.Session[myChoseCarProductKey] == null)
                {
                    HttpContext.Current.Session[myChoseCarProductKey] = new List<ShoppingCarEntriy>();
                }
                return HttpContext.Current.Session[myChoseCarProductKey] as List<ShoppingCarEntriy>;
            }
            set
            {
                HttpContext.Current.Session[myChoseCarProductKey] = value;
            }
        }


        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="addProduct"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        public static bool AddProducts(string productID, int count)
        {
            bool f = false;
            foreach (ShoppingCarEntriy tmp in MyChoseProducts)
            {
                if (tmp.ProductId == productID)
                {
                    tmp.Count = tmp.Count + count;                    
                    f = true;
                }
            }
            if (!f)
            {
                ShoppingCarEntriy addProduct = new ShoppingCarEntriy();
                addProduct.Count = count;
                Products p=  ProductsBLL.GetInstance().Get(new Products.Key(int.Parse(productID)));
                if (p != null)
                {
                    addProduct.Seqno = MyChoseProducts.Count+1;
                    addProduct.ProductId = productID;
                    addProduct.Name = p.Title ;
                    addProduct.Price =Convert.ToDecimal( p.Nowprice )  ;
                    addProduct.ImgPath = p.Logo ;
                    addProduct.Owner = p.Creator ;
                    MyChoseProducts.Add(addProduct);
                }
            }
            return true;

        }

        /// <summary>
        /// 添加,如果没有找到就是直接更新这个数量到缓存。
        /// </summary>
        /// <param name="addProduct"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        public static bool AddProducts(ShoppingCarEntriy addProduct, int count)
        {
            bool f = false;
            foreach (ShoppingCarEntriy tmp in MyChoseProducts)
            {
                if (tmp.ProductId == addProduct.ProductId)
                {
                    tmp.Count = tmp.Count + count;
                   
                    f = true;
                }
            }
            if (!f)
            {
                addProduct.Count = count;
                MyChoseProducts.Add(addProduct);
            }
            
            return true;

        }

        /// <summary>
        /// 修改，如果不存在就增加
        /// </summary>
        /// <param name="productID"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        public static bool ModifyProducts(string productID, int count)
        {
            bool f = false;
            foreach (ShoppingCarEntriy tmp in MyChoseProducts)
            {
                if (tmp.ProductId == productID)
                {
                    tmp.Count = count;
                    f = true;
                }
            }
            if (!f)
            {
                ShoppingCarEntriy addProduct = new ShoppingCarEntriy();
                addProduct.Count = count;
                Products p = ProductsBLL.GetInstance().Get(new Products.Key(int.Parse(productID)));
                if (p != null)
                {
                    addProduct.Seqno = MyChoseProducts.Count + 1;
                    addProduct.ProductId = productID;
                    addProduct.Name = p.Title ;
                    addProduct.Price =Convert.ToDecimal( p.Nowprice  );
                    addProduct.ImgPath = p.Logo;
                    addProduct.Owner = p.Creator  ;
                    MyChoseProducts.Add(addProduct);
                }
            }
             
            return true;
        }


        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="delProduct"></param>
        /// <returns></returns>
        public static bool RemoveProducts(string productID)
        {
            ShoppingCarEntriy remove = null;

            foreach (ShoppingCarEntriy tmp in MyChoseProducts)
            {
                if (tmp.ProductId == productID)
                {
                    remove = tmp;
                }
            }
            if (remove != null) MyChoseProducts.Remove(remove);
            return true;
        }
         
    }
}
