using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Caching;
using dx177.FrameWork;

namespace dx177.Business.DictBus
{
    public class CacheData
    {



        private string DependenciesKey = "DependenciesKey";

        private static volatile CacheData m_instance = null;
        /// <summary>
        /// 取得 CacheData 对象
        /// </summary>
        /// <remarks>
        /// 实现流程：
        ///     1.锁定类
        ///     2.获取对象实例 
        ///     3.结束
        /// </remarks>
        /// <returns>返回一个已经存在的实体</returns>
        public static CacheData GetInstance()
        {
            // 通用的必要代码 iBatisNet双校检机制,如果实例不存在
            if (m_instance == null)
            {
                lock (typeof(CacheData))
                {
                    // 如果实例不存在
                    if (m_instance == null)
                    {

                        // 创建一个的实例
                        m_instance = new CacheData();

                    }
                }
            }

            // 返回业务逻辑对象
            return m_instance;
        }

        /// <summary>
        /// 获取缓存数据
        /// </summary>
        public object this[string cacheName]
        {
            get
            {
                return HttpContext.Current.Cache[cacheName];
            }
            set
            {
                this[cacheName, TimeSpan.Zero] = value;
            }
        }

        /// <summary>
        /// 设置缓存数据(指定过期时间)
        /// </summary> 
        public object this[string cacheName, System.TimeSpan timeSpan]
        {
            set
            {
                if (HttpContext.Current.Cache[DependenciesKey] == null)
                {
                    HttpContext.Current.Cache.Add(DependenciesKey, DateTime.Now, null, DateTime.MaxValue, timeSpan, CacheItemPriority.High, null);

                }
                CacheDependency cacheDependency = new CacheDependency(null, new string[] { DependenciesKey });

                // 设置依赖项
                HttpContext.Current.Cache.Insert(cacheName,
                    value, cacheDependency, DateTime.MaxValue,
                    timeSpan, CacheItemPriority.High, null);
            }
        }


        /// <summary>
        /// 清除本地指定列表中的缓存,如列表为空则清除全部
        /// </summary>
        /// <param name="cacheName">缓存名列表</param>
        public void ClearLocalCache(params string[] cacheName)
        {
            if (cacheName.Length == 0)
            {
                HttpContext.Current.Cache[DependenciesKey] = DateTime.Now.ToString();
            }
            else
            {

                foreach (string cn in cacheName)
                {
                    try
                    {
                        if (HttpContext.Current.Cache[cn] != null)
                        {
                            HttpContext.Current.Cache.Remove(cn);
                        }
                    }
                    catch
                    {
                    }
                }
            }
        }


        /// <summary>
        /// 获取缓存数据
        /// </summary>
        public object this[CacheName cacheNameEnum]
        {
            get
            {
                return this[cacheNameEnum.ToString()];
            }
            set
            {

                this[cacheNameEnum.ToString()] = value;
            }
        }
    }
}
