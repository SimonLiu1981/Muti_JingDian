using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace dx177.Business.DictBus
{
    public  class Dict
    {
        /// <summary>
        /// 多语言标签
        /// </summary>
        public static readonly Tag Tag = new Tag();

        /// <summary>
        /// 公用
        /// </summary>
        public static readonly CacheData CacheData = CacheData.GetInstance();



    }
}
