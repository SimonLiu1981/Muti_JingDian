using System;
using System.Collections.Generic;
using System.Text;
using dx177_building;
using dx177_building.Model;


namespace dx177_building
{
    public class PageButton
    {
        #region 
        int _CurrentPageIndex = 0;
        public int CurrentPageIndex
        {
            get
            {
                return _CurrentPageIndex;
            }
            set
            {
                _CurrentPageIndex = value;
            }
        }
        int _pageButtonCount = 0;
        public int pageButtonCount
        {
            get
            {
                return _pageButtonCount;
            }
            set
            {
                _pageButtonCount = value;
            }
        }
        int _PageCount = 0;
        public int PageCount
        {
            get
            {
                return _PageCount;
            }
            set
            {
                _PageCount = value;
            }
        }
        int _ItemCount = 0;
        public int ItemCount
        {
            get
            {
                return _ItemCount;
            }
            set
            {
                _ItemCount = value;
            }
        }

        PageButtonHtmlMod m_ButtonHtml = null;
        public PageButtonHtmlMod ButtonHtml
        {
            get
            {
                return m_ButtonHtml;
            }
            set
            {
                m_ButtonHtml = value;
            }
        }
        #endregion

        public PageButton(string XmlPath)
        {
            this.ButtonHtml = XmlData.XmlDeserialize(typeof(PageButtonHtmlMod) , XmlPath) as PageButtonHtmlMod;
        }

        public PageButton(string XmlPath,string strLink)
        {
            this.ButtonHtml = XmlData.XmlDeserialize(typeof(PageButtonHtmlMod), XmlPath) as PageButtonHtmlMod;
            this.ButtonHtml.Link = strLink;
            this.ButtonHtml.ButtonLink = this.ButtonHtml.ButtonLink.Replace("|LINK|", strLink);
            this.ButtonHtml.CurrentPageHtml = this.ButtonHtml.CurrentPageHtml.Replace("|LINK|", strLink);
            this.ButtonHtml.FirstPage = this.ButtonHtml.FirstPage.Replace("|LINK|", strLink);
            this.ButtonHtml.LastPage = this.ButtonHtml.LastPage.Replace("|LINK|", strLink);
            this.ButtonHtml.NextPage = this.ButtonHtml.NextPage.Replace("|LINK|", strLink);
            this.ButtonHtml.PrePage = this.ButtonHtml.PrePage.Replace("|LINK|", strLink);
            this.ButtonHtml.ShowPageDescr = this.ButtonHtml.ShowPageDescr.Replace("|LINK|", strLink);

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="num6"></param>
        /// <param name="pageIndex"></param>
        /// <returns></returns>
        public string CreatePageNumButton(int num6, int pageIndex)
        {
            StringBuilder sp = new StringBuilder();
            for (int i = num6; i <= pageIndex; i++)
            {
                string text2 = i.ToString();
                if (i == (this.CurrentPageIndex))
                {
                    sp.Append(this.ButtonHtml.CurrentPageHtml.Replace("|CURRENTPAGEHTML|", text2));
                }
                else
                {
                    sp.Append(this.ButtonHtml.ButtonLink.Replace("|BUTTONLINK|", i.ToString()));
                }
            }
            return sp.ToString();
        }
 

        public string CretePageFirstButton()
        {
            if (this.PageCount <= 0)
            {
                return "";
            }
            else
            {
                return this.ButtonHtml.FirstPage.Replace("|FIRSTPAGE|", "1");
            }
        }

        public string CretePageLastButton()
        {
            if (this.PageCount <= 0)
            {
                return "";
            }
            else
            {
                return this.ButtonHtml.LastPage.Replace("|LASTPAGE|", this.PageCount.ToString());
            }
        }


        public string CretePrePage()
        {
            int nexvalue = this.CurrentPageIndex -1;
            if (this.PageCount <= 0) return "";
            if (this.CurrentPageIndex <=1)
            {
                nexvalue = this.CurrentPageIndex ;
            }
            return this.ButtonHtml.PrePage.Replace("|PREPAGE|", nexvalue.ToString());
 
        }

        public string CreteNextPage()
        {
            int nexvalue = this.CurrentPageIndex ;
            if (this.PageCount <= 0) return "";

            if (this.CurrentPageIndex < this.PageCount )
            {
                nexvalue = this.CurrentPageIndex + 1;
            }
            return this.ButtonHtml.NextPage.Replace("|NEXTPAGE|", nexvalue.ToString());
        }

        public string CreatePageShowNum()
        {
            string strReutun = this.ButtonHtml.ShowPageDescr.Replace("CURRENTPAGEINDEX", (this.CurrentPageIndex + 1).ToString());
            strReutun = strReutun.Replace("PAGECOUNT", this.PageCount.ToString());
            strReutun = strReutun.Replace("ITEMCOUNT", this.ItemCount.ToString());
            return strReutun;
        }


        public void CreatePageNum(ref int EndPageIndex, ref int BiginPageIndex)
        {
            int pageCount = this.PageCount;
            int pagebuttoncount = this.pageButtonCount;
            //判断button数是否大于page的数量
            if (this.PageCount < this.pageButtonCount)
            {
                pagebuttoncount = this.PageCount;
            }
            BiginPageIndex = 1;
            EndPageIndex = pagebuttoncount;
            int num7 = 0;
            //当前页的是最后一页则完成下面的逻辑
            if ((this.CurrentPageIndex + 1) > EndPageIndex)
            {
                int CurrentListPageCount = this.CurrentPageIndex / this.pageButtonCount;
                if (CurrentListPageCount > 0)
                {
                    BiginPageIndex = this.CurrentPageIndex - (this.pageButtonCount) / 2;  
                }
                else
                {
                    BiginPageIndex = 1;
                }
                //如果页数不是整的buttoncount则，否则。
                num7 = BiginPageIndex + this.pageButtonCount - pageCount;
                if (num7 > 0)
                {
                    EndPageIndex = pageCount;
                }
                else
                {
                    EndPageIndex = this.pageButtonCount + BiginPageIndex;
                }
            }
        }

        public string MainBindpage()
        {
            #region 算法
            int pageIndex = 0;
            int num6 = 0;
            CreatePageNum(ref pageIndex, ref num6);
            #endregion
            StringBuilder sp = new StringBuilder();
            //首页
            string strFirstButton = CretePageFirstButton();
            sp.Append(strFirstButton);
            string strprepage = CretePrePage();
            sp.Append(strprepage);
            #region 生成数字页码
            string strPageNumButton = CreatePageNumButton(num6, pageIndex);
            sp.Append(strPageNumButton);
            #endregion

            string strNextPage = CreteNextPage();
            sp.Append(strNextPage);
            string strLastButton = CretePageLastButton();
            sp.Append(strLastButton);
            string strShowPageCount = CreatePageShowNum();
            sp.Append(strShowPageCount);
            return sp.ToString();
        }
    }
}
