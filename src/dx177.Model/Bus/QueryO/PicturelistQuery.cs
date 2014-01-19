using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace dx177.Model.Bus.QueryO
{
    public  class PicturelistQuery
    {
        /// <summary>
        /// 图片标题
        /// </summary>
        public string Title
        {
            get;
            set;
        }

        /// <summary>
        /// 是否被用 1:备用
        /// </summary>
        public string hasUsed
        {
            get;
            set;
        }

        public string CreateBy
        {
            get;
            set;
        }


        string m_JingQuCode = "";
        public string JingQuCode
        {
            get
            {
                return m_JingQuCode;
            }
            set
            {
                m_JingQuCode = value;
            }
        }


    }
}
