using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using System.Text.RegularExpressions;

namespace dx177.FrameWork
{
    public static class HtmlHelpers
    {

        public static string Truncate(string input, int length)
        {
            if (input.Length <= length)
            {
                return input;
            }
            else
            {
                return input.Substring(0, length) + "...";
            }
        }

        public static string RevmoeHtmlTag(string input)
        {
            return Regex.Replace(input, "<.*?>", string.Empty);  
        }
    }
}
