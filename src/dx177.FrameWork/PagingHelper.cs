using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.UI.WebControls;
using System.Web.UI;
using System.Web;

namespace dx177.FrameWork
{
    public class PagingHelper
    {
        private string withOutQueryField = string.Empty;

        public void ProcessPaging(DataPager pager, Page p)
        {
            
            withOutQueryField = p.Request.RawUrl;            
            foreach (string key in p.Request.QueryString.AllKeys)
            {
               
                withOutQueryField = UrlUtility.AddOrReplaceParam(withOutQueryField, key, p.Request.QueryString[key], true);               
            }

            if (withOutQueryField.ToUpper().IndexOf("JQ_") != -1)
            {
                withOutQueryField = UrlUtility.RemoveParam(withOutQueryField, ConstantElements.QueryStringNameJQ);
            }

            pager.Controls.Clear();
            pager.Attributes.Add("class", "pages");
            int count = pager.TotalRowCount;
            int pageSize = pager.PageSize;

            int pagesCount = count / pageSize + (count % pageSize == 0 ? 0 : 1);
            int pageSelected = pager.StartRowIndex / pageSize + 1;

            string pfirst = string.Format("<A title='首页' href=\"{0}\">首页</a>", GetUrl(1, pager,p ));
            string ppre = string.Format("<A title='上页' href=\"{0}\">上页</a>", GetUrl(pageSelected - 1, pager, p));
            string pnext = string.Format("<A title='下页' href=\"{0}\">下页</a>", GetUrl(pageSelected + 1, pager,p));
            string plast = string.Format("<A title='尾页' href=\"{0}\">尾页</a>", GetUrl(pagesCount, pager,p));

            StringBuilder builder = new StringBuilder();

            int tmppageSize = 11;

            int end = pageSelected + tmppageSize / 2;
            if (end < tmppageSize)
            {
                end = tmppageSize;
            }
            if (end > pagesCount)
            {
                end = pagesCount;
            }

            int start = end - tmppageSize + 1 > 0 ? end - tmppageSize + 1 : 1;

            if (pagesCount > 1)
            {
                if (pageSelected > 1)
                {
                    builder.Append(pfirst).Append(ppre);
                }

                for (int i = start; i <= end; ++i)
                {
                    builder.Append(GetPageLink(i, pageSelected, pager, p));
                }

                if (pageSelected < pagesCount)
                {
                    builder.Append(pnext).Append(plast);
                }

                Literal ltt = new Literal();
                ltt.Text = builder.ToString();
                pager.Controls.Add(ltt);
            }


        }


        private string GetUrl(int page, DataPager pager,  Page p)
        {
            string url = withOutQueryField;
            url = UrlUtility.AddOrReplaceParam(url, pager.QueryStringField, page.ToString(), true);
            return url;
        }

        private string GetPageLink(int page, int pageSelected, DataPager pager, Page p)
        {
            string startstr = "";
            if (pageSelected != page)
            {
                startstr += string.Format("<a title=\"第{0}页\" href=\"{1}\">{0}</a>", page, GetUrl(page, pager, p));
            }
            else
            {
                startstr += string.Format("<strong>{0}</strong>", page);
            }
            return startstr;
        }

    }
}
