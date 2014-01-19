using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using dx177.ZhuNaAPI.ZhunaEntities;

namespace dx177.ZhuNaAPI.Utility
{
    public static class RegParseTools
    {
        public static List<string> MatchCollection(string pattern,string source)
        {
            List<string> ls = new List<string>();
            Regex reg = new Regex(pattern, RegexOptions.Compiled);
            Match m = reg.Match(source);

            while (m.Success)
            {

                ls.Add(uncode(m.Groups["imgUrl"].Value.Replace("\\/", "/")));
                m = m.NextMatch();
            }

            return ls;
        }
        public static string uncode(string str)
        {
            string outStr = "";
            Regex reg = new Regex(@"(?i)\\u([0-9a-f]{4})");
            outStr = reg.Replace(str, delegate(Match m1)
            {
                return ((char)Convert.ToInt32(m1.Groups[1].Value, 16)).ToString();
            });
            return outStr;
        }

        public static HotelPics GetHotelPics(string source)
        {
            HotelPics res = new HotelPics();
            string hotelnameex = "(?is)\"picture\":\"(?<imgUrl>.[^\\\"]*)\"";
            string hotelpictureex = "(?is)\"picture\":\"(?<imgUrl>.[^\\\"]*)\"";
            string pic500ex = "\"pic500\":\"(?<imgUrl>.[^\\\"]*)\"";
            string pic160ex = "\"pic160\":\"(?<imgUrl>.[^\\\"]*)\"";
            string titleex = "\"title\":\"(?<imgUrl>.[^\\\"]*)\"";
            List<string> tmp = MatchCollection(hotelpictureex, source);
            res.IndentityPicture = tmp[0];
            List<string> tmp1 = MatchCollection(hotelnameex, source);
            res.HotelName = tmp1[0];
            res.Pics = new List<HotelPicEntity>();
            List<string> p500list = MatchCollection(pic500ex, source);            
            List<string> p160list = MatchCollection(pic160ex, source);
            List<string> titlelist = MatchCollection(titleex, source);
            int total = p500list.Count;

            for (int i = 0; i < total; i++)
            {
                HotelPicEntity t = new HotelPicEntity();
                t.Pic500 = p500list[i];
                t.pic160 = p160list[i];
                t.Title = titlelist[i];
                res.Pics.Add(t);
            }

            return res;
        }
    }


    
}
