using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace dx177_building.Model
{
    [Serializable]
    public class PageButtonLinkMod
    {
        /// <summary>
        /// 非当前的button
        /// </summary>
        string _ButtonLink = "";
        public string ButtonLink
        {
            get
            {
                return _ButtonLink;
            }
            set
            {
                _ButtonLink = value;
            }
        }

        /// <summary>
        /// 显示
        /// </summary>
        string _ShowPageDescr = "";
        public string ShowPageDescr
        {
            get
            {
                return _ShowPageDescr;
            }
            set
            {
                _ShowPageDescr = value;
            }
        }

        /// <summary>
        /// 最后一页的代码
        /// </summary>
        string _LastPage = "";
        public string LastPage
        {
            get
            {
                return _LastPage;
            }
            set
            {
                _LastPage = value;
            }
        }
        /// <summary>
        /// 第一页的代码
        /// </summary>
        string _FirstPage = "";
        public string FirstPage
        {
            get
            {
                return _FirstPage;
            }
            set
            {
                _FirstPage = value;
            }
        }

        /// <summary>
        /// 第一页的代码
        /// </summary>
        string _PrePage = "";
        public string PrePage
        {
            get
            {
                return _PrePage;
            }
            set
            {
                _PrePage = value;
            }
        }


        /// <summary>
        /// 下一页
        /// </summary>
        string _NextPage = "";
        public string NextPage
        {
            get
            {
                return _NextPage;
            }
            set
            {
                _NextPage = value;
            }
        }
        /// <summary>
        /// 当前的button
        /// </summary>
        string _CurrentPageHtml = "";
        public string CurrentPageHtml
        {
            get
            {
                return _CurrentPageHtml;
            }
            set
            {
                _CurrentPageHtml = value;
            }
        }
    }
}
