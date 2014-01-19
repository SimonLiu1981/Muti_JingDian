using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using dx177_building;
using dx177.Business.Bus;
using System.Text.RegularExpressions;
using dx177.Model;
using dx177_building.Model;
 
using dx177.Model.Bus;
using System.Collections;
using System.Web.UI;
using System.IO;
using dx177.FrameWork;
using System.Web;

namespace CampanyCMS.Model.Bus
{
    public class BuildPageBLL
    {

        public static void CreateHtml(RunType r, object obj)
        {
            GobalContent.GobalBaseHash = null;

            switch (r)
            { 
                case RunType.Product :

                    break;
                case RunType.ProductType:

                    break;
                case RunType.News:

                    break;
                case RunType.NewsType:

                    break;
                case RunType.Issue:

                    break;
                case RunType.Others:

                    break;
                default :
                    break;
            }
        }

        public static void CreateHtml(FuntionParaMod f)
        {
            switch (f.Type)
            { 
                case "LISTS" :
                    CreateListPages(f);
                    break;
                case "LIST":
                    CreateListPage(f);
                    break;
                case "PAGES":
                    CreatePages(f);
                    break;
                default :
                    CreatePage(f);
                    break;
            }
        }

        public  static void CreateListPages(FuntionParaMod f)
        {
            string sql = f.CycleSql.Replace("|CREATEBY|", AppContext.GetCurrentName());
            f.Sql = f.Sql.Replace("|CREATEBY|", AppContext.GetCurrentName());
            DataTable dt = NewsBLL.GetInstance().GetDataTable(sql);
            foreach (DataRow dr in dt.Rows)
            {
                sql = DataToHtml.ObjToHtml(dr, f.Sql);
                DataTable Temp = NewsBLL.GetInstance().GetDataTable(sql);
                if (Temp != null && Temp.Rows.Count > 0)
                {
                    BuildingSearchListHtml.CreatePageList(Temp, f.xmlPath, f.ParaArr, dr["TYPECODE"].ToString());
                }
            }
        }

        public static void  CreateListPage(FuntionParaMod f) 
        {
            string[] Parr = Regex.Split(f.ParaArr, "@%");
            string link = Parr[0];
            string TypeCode = Parr[1];
            f.Sql = f.Sql.Replace("|CREATEBY|", AppContext.GetCurrentName());
            DataTable dt = NewsBLL.GetInstance().GetDataTable(f.Sql);
            BuildingSearchListHtml.CreatePageList(dt, f.xmlPath, link, TypeCode);
        }

        public static void CreatePages(FuntionParaMod f)
        {
            f.Sql = f.Sql.Replace("|CREATEBY|", AppContext.GetCurrentName());
            DataTable dt = NewsBLL.GetInstance().GetDataTable(f.Sql);
            foreach (DataRow dr in dt.Rows)
            {
                BuildPageHtml.BuildPage(dr, f.xmlPath );
            }
        }

        public static void CreatePage(FuntionParaMod f)
        {
            f.Sql = f.Sql.Replace("|CREATEBY|", AppContext.GetCurrentName());
            DataTable dt = NewsBLL.GetInstance().GetDataTable(f.Sql);
            BuildPageHtml.BuildPage(dt.Rows[0], f.xmlPath);
        }

        public static void CreatePage(string xmlPath , object obj)
        {
            BuildPageHtml.BuildPage(obj, xmlPath);
        }

        public static Encoding GetEncoding(string f)
        {
            CallMethodArrMod xm = XmlData.XmlDeserialize(typeof(CallMethodArrMod), f) as CallMethodArrMod;
            if (xm.CurrentEncoding.ToLower() == "utf8")
            {
                return Encoding.UTF8;
            }
            return Encoding.GetEncoding("gb2312");
        }

        public static DataTable GetHtmlPageName(string xmlPath)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("name");
            dt.Columns.Add("keyvalue");
            CallMethodArrMod xm = XmlData.XmlDeserialize(typeof(CallMethodArrMod), xmlPath) as CallMethodArrMod;
            for (int i = 0; i < xm.callmethodmods.Length; i++)
            {
                DataRow dr = dt.NewRow();
                dr["name"] = xm.callmethodmods[i].Name;
                dr["keyvalue"] = xm.callmethodmods[i].Name;
                dt.Rows.Add(dr);
            }
            return dt;
        }

        public static void GobalPara(Page p, Resuser ad)
        { 
            Hashtable h=new Hashtable () ;
            h.Add("CREATEBY",ad.Username  ) ;
            h.Add("WEBFILEPATH", "~/");//这个是创建HTML代码人路径
            h.Add("RESOLVEURL",p.ResolveUrl("~/"));//这个站点配制的虚拟路径,如：
            GobalContent.GabolHashPara = h;
            GobalContent.UserName = ad.Username;
            GobalContent.GobalBaseHash = null;
            string path = Path.Combine("~/Templates/xml/hotel/", "CallMethodArrMod.xml");
            GobalContent.CurrentEncoding = GetEncoding(path);
        }

        public static void BuildOnePage( string Name, string UserName,string keyval)
        {
            Resuser ad = new Resuser();
            ad.Username = UserName;
             Page page = HttpContext.Current.CurrentHandler as  Page;
             BuildPageBLL.GobalPara(page, ad);
            string path = @"~/Templates/xml/hotel/CreatePageMethod.xml";
            CallMethodArrMod CallArr = new CallMethodArrMod();
            CallArr = XmlData.XmlDeserialize(CallArr.GetType(), path) as CallMethodArrMod;
            if (CallArr.CurrentEncoding.ToUpper() == "UTF8")
            {
                AppContext.CurrentEncoding = Encoding.UTF8;
            }
            else
            {
                AppContext.CurrentEncoding = Encoding.GetEncoding("gb2312");
            }
            foreach (CallMethodMod c in CallArr.callmethodmods)
            {
                if (c.Name == Name)
                {

                    c.Sql = string.Format(c.Sql, keyval);
                    c.Sql = c.Sql.Replace("|CREATEBY|", UserName);
                    DataTable dt = NewsBLL.GetInstance().GetDataTable(c.Sql);
                    if (dt != null && dt.Rows.Count > 0)
                    {
                        BuildPageHtml.BuildPage(dt.Rows[0], c.xmlPath);
                    }
                    break;
                }
            }
        
        }

    }
}