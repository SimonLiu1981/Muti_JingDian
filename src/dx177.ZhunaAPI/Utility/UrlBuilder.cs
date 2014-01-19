using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.Specialized;

namespace dx177.ZhuNaAPI.Utility
{
    public static class UrlBuilder
    {
        public static string GetUrlByConfiguration(string specified, NameValueCollection nameValueColl)
        {
            string url = System.Configuration.ConfigurationManager.AppSettings[specified];
            string agent_id = System.Configuration.ConfigurationManager.AppSettings["agent_id"];
            string agent_md = System.Configuration.ConfigurationManager.AppSettings["agent_md"];
            url = UrlUtility.AddOrReplaceParam(url, "agent_id", agent_id, false);
            url = UrlUtility.AddOrReplaceParam(url, "agent_md", agent_md, false);

            if (nameValueColl != null)
            {
                url = UrlUtility.AddOrReplaceParam(url, nameValueColl);
            }
            return url;
        }
    }
}
