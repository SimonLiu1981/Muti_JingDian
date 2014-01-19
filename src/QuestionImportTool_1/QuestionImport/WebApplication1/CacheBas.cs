using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Threading;

namespace WebApplication1
{
    public static class CacheBas
    {
        static System.Threading.ReaderWriterLockSlim readwl = new System.Threading.ReaderWriterLockSlim();
        public static string GetFromCache()
        {
            if (HttpRuntime.Cache["a123"] == null)
            {
                readwl.EnterWriteLock();
                HttpRuntime.Cache.Insert("a123", Idx, null, DateTime.Now.AddMinutes(1), TimeSpan.Zero, System.Web.Caching.CacheItemPriority.Default, Callback);
                readwl.ExitWriteLock();
            }

            readwl.EnterReadLock();
            try
            {
                return HttpRuntime.Cache["a123"].ToString();
            }
            finally
            {
                readwl.ExitReadLock();
            }
            
            
        }

      static  int  Idx = 1000;

        private static void Callback(string key, object value, System.Web.Caching.CacheItemRemovedReason reason)
        {
            readwl.EnterWriteLock();
            Idx++;
            Thread.Sleep(20000);
            HttpRuntime.Cache.Insert("a123", Idx, null, DateTime.Now.AddSeconds(10), TimeSpan.Zero, System.Web.Caching.CacheItemPriority.Default, Callback);
            readwl.ExitWriteLock();
        }
    }
}
