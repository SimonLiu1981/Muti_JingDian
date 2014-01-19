using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace dx177_building.Model
{
    [Serializable]
    public class BaseXmlData
    {
        /// <summary>
        /// 静态页面的路径和替换代码数
        /// </summary>
        Hashtable  M_ChildHtml = null;
        public Hashtable  HasChildHtmls
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
        
        Hashtable M_HasData = null;
        public Hashtable HasData
        {
            get
            {
                return M_HasData;
            }
            set
            {
                M_HasData = value;
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


        string _KeyCode = "";
        public string SaveHashKeyCode
        {
            get
            {
                return _KeyCode;
            }
            set
            {
                _KeyCode = value;
            }
        }


    }
}
