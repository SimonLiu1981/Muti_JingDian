using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace dx177_building.Model
{
    [Serializable]
    public class BaseXmlMod
    {
        /// <summary>
        /// 静态页面的路径和替换代码数
        /// </summary>
        ChildHtmlMod[] M_ChildHtml = null;
        public ChildHtmlMod[] ChildHtmls
        {
            get
            {
                return M_ChildHtml;
            }
            set
            {
                M_ChildHtml = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        HashDataMod[] M_HashDataMod = null;
        public HashDataMod[] HashDataMods
        {
            get
            {
                return M_HashDataMod;
            }
            set
            {
                M_HashDataMod = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        DataHtmlMod[] M_DataHtmlMod = null;
        public DataHtmlMod[] DataHtmlMods
        {
            get
            {
                return M_DataHtmlMod;
            }
            set
            {
                M_DataHtmlMod = value;
            }
        }

        //string _KeyCode = "";
        //public string SaveHashKeyCode
        //{
        //    get
        //    {
        //        return _KeyCode;
        //    }
        //    set
        //    {
        //        _KeyCode = value;
        //    }
        //}

    }
}
