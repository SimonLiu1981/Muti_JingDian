using System;
using System.Data;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.IO;

namespace dx177.FrameWork
{
	/// <summary>
	/// cHTML ��ժҪ˵����
	/// </summary>
	public class  HtmlUitl
	{       
        public static void CreaetHTMLFile(string path,string strHtml)
        {

            StreamWriter sw = new StreamWriter(path,true,System.Text.Encoding.GetEncoding("GB2312")) ; 
            sw.Write(strHtml);
            sw.Close();
        }

        public static void CreaetHTMLFile(string path, string strHtml, string sEncoding)
        {
             Encoding c=Encoding.UTF8;
            if (sEncoding=="gb32")
            {
                 c =Encoding.GetEncoding("GB2312");
            }
            StreamWriter sw = new StreamWriter(path, true, c);
            sw.Write(strHtml);
            sw.Close();
        }

        public static string GetHTML(string path)
        {
            string strHtml="";
            StreamReader sr=new StreamReader( path,System.Text.Encoding.GetEncoding("GB2312"));
            while(sr.Read()!=-1)
            {
                strHtml = sr.ReadToEnd(); 
            }
            sr.Close();
            return strHtml;
        }
        /// <summary>
        /// ��ҳ���URL������ֵ
        /// </summary>
        /// <param name="Url">ԭURL</param>
        /// <param name="paramName">������</param>
        /// <param name="paramValue">����ֵ</param>
        /// <returns></returns>
        public static string AddOrReplacePageUrlParamer(string Url, string paramName, string paramValue)
        {

            paramValue = HttpUtility.UrlEncode(paramValue);
            int idxofParamName = 0;
            string last = "";
            string f1 = "";
            string f3 = "";

            if (Url.IndexOf("?") != -1)
            {
                #region
                string s = Url.ToLower();
                if (s.IndexOf("&" + paramName.ToLower()) == -1 && s.IndexOf("?" + paramName.ToLower()) == -1)
                {
                    //�����ڵ�ʱ��
                    if (Url.IndexOf("?") != -1)
                    {
                        Url += string.Format("&{0}={1}", paramName, paramValue);
                    }
                    else
                    {
                        Url += string.Format("?{0}={1}", paramName, paramValue);
                    }

                }
                else
                {
                    //���ڲ��� ?A=b/&A=b ������A����
                    if (s.IndexOf("&" + paramName.ToLower()) != -1)
                    {
                        //&A=b
                        idxofParamName = s.IndexOf("&" + paramName.ToLower());
                        f1 = Url.Substring(0, idxofParamName);
                        last = Url.Substring(idxofParamName + 1);

                        if (last.IndexOf("&") == -1)
                        {
                            f3 = "";
                        }
                        else
                        {
                            idxofParamName = last.IndexOf("&");
                            f3 = last.Substring(idxofParamName);
                        }
                        Url = f1 + string.Format("&{0}={1}", paramName, paramValue) + f3;
                    }
                    else if (s.IndexOf("?" + paramName.ToLower()) != -1)
                    {
                        //?A=b
                        idxofParamName = s.IndexOf("?" + paramName.ToLower());
                        f1 = Url.Substring(0, idxofParamName);
                        last = Url.Substring(idxofParamName + 1);

                        if (last.IndexOf("&") == -1)
                        {
                            f3 = "";
                        }
                        else
                        {
                            idxofParamName = last.IndexOf("&");
                            f3 = last.Substring(idxofParamName);
                        }
                        Url = f1 + string.Format("?{0}={1}", paramName, paramValue) + f3;
                    }
                }
                #endregion
            }
            else
            {
                //û���κβ���ʱ
                Url += string.Format("?{0}={1}", paramName, paramValue);
            }
            return Url;
        }

        /// <summary>
        /// ɾ��URL���ĳ������
        /// </summary>
        /// <param name="Url">ԭURL</param>
        /// <param name="paramName">������</param>
        /// <returns>ɾ���������URL��ַ</returns>
        public static string RemovePageUrlParamer(string Url, string paramName)
        {
            int idxofParamName = 0;
            string last = "";
            string f1 = "";
            string f3 = "";

            if (Url.IndexOf("?") != -1)
            {
                #region
                string s = Url.ToLower();
                if (s.IndexOf("&" + paramName.ToLower()) == -1 && s.IndexOf("?" + paramName.ToLower()) == -1)
                {
                    //�����ڵ�ʱ��
                    if (Url.IndexOf("?") != -1)
                    {
                        Url += string.Format("&", paramName);
                    }
                    else
                    {
                        Url += string.Format("?", paramName);
                    }

                }
                else
                {
                    //���ڲ��� ?A=b/&A=b ������A����
                    if (s.IndexOf("&" + paramName.ToLower()) != -1)
                    {
                        //&A=b
                        idxofParamName = s.IndexOf("&" + paramName.ToLower());
                        f1 = Url.Substring(0, idxofParamName);
                        last = Url.Substring(idxofParamName + 1);

                        if (last.IndexOf("&") == -1)
                        {
                            f3 = "";
                        }
                        else
                        {
                            idxofParamName = last.IndexOf("&");
                            f3 = last.Substring(idxofParamName+1);
                        }
                        Url = f1 + string.Format("&") + f3;
                    }
                    else if (s.IndexOf("?" + paramName.ToLower()) != -1)
                    {
                        //?A=b
                        idxofParamName = s.IndexOf("?" + paramName.ToLower());
                        f1 = Url.Substring(0, idxofParamName);
                        last = Url.Substring(idxofParamName + 1);

                        if (last.IndexOf("&") == -1)
                        {
                            f3 = "";
                        }
                        else
                        {
                            idxofParamName = last.IndexOf("&");
                            f3 = last.Substring(idxofParamName+1);
                        }
                        Url = f1 + "?" + f3;
                    }
                }
                #endregion
            }
            else
            {
                //û���κβ���ʱ
                //Url += string.Format("?{0}={1}", paramName);
            }
            return Url;
        }

        #region html �滻����

        private object HtmlObj = null;

        private string HtmlContent ="";


        /// <summary>
        ///  �����滻 	#?GroupTeamType?#  �ö���� .GroupTeamType ����ֵ
        /// </summary>
        /// <param name="htmlContent"></param>
        /// <param name="htmlObj"></param>
        public HtmlUitl(string htmlContent , object htmlObj)
        {
            HtmlObj = htmlObj;
            HtmlContent = htmlContent;
        }

        /// <summary>
        /// ȡ���滻��� HtmlContent
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return MapContent(HtmlContent);
        }


        /// <summary>
        /// Maps a business object's properties to placeholders
        /// of the submitted content.
        /// </summary>
        /// <param name="content">A string containing placeholder tags. Check
        /// the class summary to get the proper placeholder format.</param>
        /// <returns></returns>
        private string MapContent(string content)
        {
            StringBuilder builder = new StringBuilder(content);
            string pattern = @"#\?(?'property'\S+?)\?#";
            return Regex.Replace(content, pattern, new MatchEvaluator(RegexMatchEvaluation), RegexOptions.ExplicitCapture); 
        }


        /// <summary>
        /// Retrieves the property name from a placeholder and
        /// tries to get a property value from the business
        /// object.
        /// </summary>
        /// <param name="match">Regex match.</param>
        /// <returns>The property value, if existing. If the property
        /// is <c>null</c>, <c>String.Empty</c> is being returned. If
        /// no property is available, the unchanged placeholder is
        /// returned.</returns>
        private string RegexMatchEvaluation(Match match)
        {
            //get the property name (named group of the regex)
            string propertyName = match.Groups["property"].Value;
	      
            //try to get a property handle from the business object
            PropertyInfo pi = this.HtmlObj.GetType().GetProperty(propertyName);
	      
            //do not replace anything if no such property exists
            if (pi == null) 
            {
                return match.Value;
            }

            //return the property value
            object propertyValue = pi.GetValue(HtmlObj, null);
            if (propertyValue != null)
            {
                return propertyValue.ToString();
            }
            else
            {
                return string.Empty;
            }
        }

        #endregion 


        public string RemoveHtmlTag(string html)
        {
            Regex regex1 =
                  new Regex(@"<script[\s\S]+</script *>",
                  RegexOptions.IgnoreCase);
            Regex regex2 =
                  new Regex(@" href *= *[\s\S]*script *:",
                  RegexOptions.IgnoreCase);
            Regex regex3 =
                  new Regex(@" no[\s\S]*=",
                  RegexOptions.IgnoreCase);
            Regex regex4 =
                  new Regex(@"<iframe[\s\S]+</iframe *>",
                  RegexOptions.IgnoreCase);
            Regex regex5 =
                  new Regex(@"<frameset[\s\S]+</frameset *>",
                  RegexOptions.IgnoreCase);
            Regex regex6 =
                  new Regex(@"\<img[^\>]+\>",
                  RegexOptions.IgnoreCase);
            Regex regex7 =
                  new Regex(@"</p>",
                  RegexOptions.IgnoreCase);
            Regex regex8 =
                  new Regex(@"<p>",
                  RegexOptions.IgnoreCase);
            Regex regex9 =
                  new Regex(@"<[^>]*>",
                  RegexOptions.IgnoreCase);

            html = regex1.Replace(html, ""); //����<script></script>��� 
            html = regex2.Replace(html, ""); //����href=javascript: (<A>) ���� 
            html = regex3.Replace(html, " _disibledevent="); //���������ؼ���on...�¼� 
            html = regex4.Replace(html, ""); //����iframe 
            html = regex5.Replace(html, ""); //����frameset 
            html = regex6.Replace(html, ""); //����frameset 
            html = regex7.Replace(html, ""); //����frameset 
            html = regex8.Replace(html, ""); //����frameset 
            html = regex9.Replace(html, "");
            html = html.Replace(" ", "");
            html = html.Replace("</strong>", "");
            html = html.Replace("<strong>", "");
            return html;
        }

	}
}
