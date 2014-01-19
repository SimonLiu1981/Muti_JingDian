using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace dx177_building.Model
{
    [Serializable]
    public class HtmlDataForReplace
    {
        /// <summary>
        /// 静态页面的路径和替换代码数
        /// </summary>
        Hashtable M_ChildHtml = null;
        public Hashtable HasChildHtmls
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
        List<DataHtmlMod> M_DataHtmlModArr = null;
        public List<DataHtmlMod> DataHtmlModArr
        {
            get
            {
                return M_DataHtmlModArr;
            }
            set
            {
                M_DataHtmlModArr = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        object M_obj = null;
        public object obj
        {
            get
            {
                return M_obj;
            }
            set
            {
                M_obj = value;
            }
        }
        /// <summary>
        /// 合并数据源
        /// </summary>
        /// <param name="hs"></param>
        public void MergeHasData(Hashtable hs)
        {
            Common.Common.MergeHash(hs, this.HasData);
        }
        /// <summary>
        /// 合并子Html部分
        /// </summary>
        /// <param name="hs"></param>
        public void MergeHasChildHtmls(Hashtable hs)
        {
            Common.Common.MergeHash(hs, this.HasChildHtmls);
        }

        /// <summary>
        /// 合并DataHtml部分
        /// </summary>
        /// <param name="DataHtmlArr"></param>
        public void MergeDataHtml(DataHtmlMod[] DataHtmlArr)
        {
            if (DataHtmlArr == null) return;
            foreach (DataHtmlMod c in DataHtmlArr)
            {
                bool b = false;
                if (DataHtmlModArr == null) {
                    DataHtmlModArr = new List<DataHtmlMod>();
                }
                foreach (DataHtmlMod t in DataHtmlModArr)
                {
                    if (string.IsNullOrEmpty(t.ReplaceCode))
                        t.ReplaceCode = t.HasKey;
                    if (string.IsNullOrEmpty(c.ReplaceCode))
                        c.ReplaceCode = c.HasKey;

                    if (t.ReplaceCode.ToUpper() == c.ReplaceCode.ToUpper())
                    {
                        b = true;
                        break;
                    }
                }
                if (!b)
                {
                    this.DataHtmlModArr.Add(c);
                }
            }
        }
    }
}
