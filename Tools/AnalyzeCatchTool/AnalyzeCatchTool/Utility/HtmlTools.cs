using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml;

namespace AnalyzeCatchTool.Utility
{
    public class HtmlTools
    {
        public static string uncode(string str)
        {
            string outStr = "";
            Regex reg = new Regex(@"(?i)\\u([0-9a-f]{4})");
            outStr = reg.Replace(str, delegate(Match m1)
            {
                return ((char)Convert.ToInt32(m1.Groups[1].Value, 16)).ToString();
            });

            reg = new Regex(@"(http|ftp|https):\/\/[\w\-_]+(\.[\w\-_]+)+([\w\-\.,@?^=%&amp;:/~\+#]*[\w\-\@?^=%&amp;/~\+#])?");
            outStr = reg.Replace(outStr, delegate(Match m1)
            {
                return string.Empty;
            });
            return outStr.Replace("\\n", "").Replace("\\r", "").Replace("\\t", "");
        }


      
    }
}
