using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using dx177_building.Model;

namespace dx177_building
{
   public  class GobalContent
   {
       public static Hashtable GabolHashPara
       {
           get
           {
               if (HttpContext.Current.Session["GabolHashPara"] != null)
               {
                   return HttpContext.Current.Session["GabolHashPara"] as Hashtable;
               }
               return null ;
           }
           set
           {
               HttpContext.Current.Session["GabolHashPara"] = value;
           }
       }

       public static Encoding CurrentEncoding
       {
           get
           {
               if (HttpContext.Current.Session["Encoding"] != null)
               {
                   return (Encoding)HttpContext.Current.Session["Encoding"];
               }
               return Encoding.UTF8;
           }
           set
           {
               HttpContext.Current.Session["Encoding"] = value;
           }
       }

       

       public static string UserName
       {
           get
           {
               if (HttpContext.Current.Session["UserName"] != null)
               {
                   return HttpContext.Current.Session["UserName"].ToString();
               }
               return string.Empty;
           }
           set
           {
               HttpContext.Current.Session["UserName"] = value;
           }
       }


       public static Hashtable GobalBaseHash
       {
           get
           {
               if (HttpContext.Current.Session["GobalHash"] != null)
               {
                   return HttpContext.Current.Session["GobalHash"] as Hashtable;
               }
               return null ;
           }
           set
           {
               HttpContext.Current.Session["GobalHash"] = value;
           }
       }

       public static void GobalBaseHashAdd(string key, object obj)
       {
           Hashtable hs = GobalContent.GobalBaseHash;
           if (hs == null)
           {
               hs = new Hashtable();
           }
           hs.Remove(key);
           hs.Add(key, obj);
           GobalContent.GobalBaseHash = hs;
       }
  
   }
}
