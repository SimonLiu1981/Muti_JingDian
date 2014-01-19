using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using dx177.Model.Bus;
using dx177.Access.Bus;
using System.Collections;
using System.Data;

namespace dx177.Business.Bus
{
    public partial class OrderApplyItemBLL : BaseBLL<OrderApplyItem>
    {

        /// <summary>
        /// 1提示定单明细
        /// 2更新数据库的产品数量。
        /// </summary>
        /// <param name="list"></param>
        /// <param name="orderID"></param>
        public void Submit(List<OrderApplyItem> list, string orderID)
        {
            string sql = string.Format("delete from Order_Apply_Item where Order_Apply_ID={0} ", orderID);
            this.Execute(sql);

            foreach (OrderApplyItem tmp in list)
            {

                this.Insert(tmp);
                //更新数据库数量
                Products p = ProductsBLL.GetInstance().Get(new Products.Key(tmp.ProductId));
                if (p != null)
                {
                    p.Stock = p.Stock > tmp.Count ? p.Stock - tmp.Count : 0;
                    ProductsBLL.GetInstance().Update(p);
                }
            }
        }


        public DataTable GetData(int orderID)
        {
            string sql = string.Format("select *  from Order_Apply_Item where Order_Apply_ID={0} ", orderID);
            return this.GetDataTable(sql);
        }

        public void DeleteByorderid(int orderID)
        {
            string sql = string.Format("delete  from Order_Apply_Item where Order_Apply_ID={0} ", orderID);
            this.Execute(sql);
        }

    }


    #region 代码自动生成
    /// <summary>
    /// Products的BLL
    /// 该BLL已经生成了基本的业务操作，在自动生成的方法中已经提供了事务机制
    /// </summary>
    public partial class OrderApplyItemBLL : BaseBLL<OrderApplyItem>
    {
        #region 自动生成代码：取得相关实体

        /// <summary>
        /// 方法名称: ProductsBLL
        /// 内容摘要: 构造函数进行初始化
        /// </summary>
        protected OrderApplyItemBLL()
        {
        }
        private static volatile OrderApplyItemBLL m_instance = null;
        /// <summary>
        /// 方法名称: GetInstance
        /// 内容摘要: 取得 ProductsBLL 对象
        /// </summary>
        /// <returns>返回一个已经存在的实体</returns>
        public static OrderApplyItemBLL GetInstance()
        {
            // 通用的必要代码 iBatisNet双校检机制,如果实例不存在
            if (m_instance == null)
            {
                lock (typeof(OrderApplyItemBLL))
                {

                    // 如果实例不存在
                    if (m_instance == null)
                    {

                        // 创建一个的实例
                        m_instance = new OrderApplyItemBLL();
                    }
                }
            }

            // 返回业务逻辑对象
            return m_instance;
        }

        #endregion

        #region 自动生成代码：基本业务公开函数


        /// <summary>
        /// 方法名称: Get
        /// 内容摘要: 由键值获取一个实体对象
        /// </summary>
        /// <returns>Products</returns>
        public OrderApplyItem Get(OrderApplyItem.Key key)
        {
            return OrderApplyItemDao.GetInstance().SelectByID(key);
        }
        /// <summary>
        /// 方法名称: Select
        /// 内容摘要: 基本查询，不带任何条件的查询
        /// </summary>
        public IList Select()
        {
            return OrderApplyItemDao.GetInstance().SelectAll();
        }
        /// <summary>
        /// 方法名称: Insert
        /// 内容摘要: 插入一条新纪录
        /// </summary>
        /// <returns>int</returns>
        public int Insert(OrderApplyItem  obj)
        {
            return OrderApplyItemDao.GetInstance().Insert(obj);
        }

        /// <summary>
        /// 方法名称: Update
        /// 内容摘要: 更新一条新纪录
        /// </summary>
        /// <returns>int</returns>
        public int Update(OrderApplyItem  obj)
        {
            OrderApplyItemDao.GetInstance().Update(obj);
            return 1;
        }

        /// <summary>
        /// 方法名称: Delete
        /// 内容摘要: 删除一条新纪录
        /// </summary>
        /// <returns>int</returns>
        public int Delete(OrderApplyItem  obj)
        {
            OrderApplyItemDao.GetInstance().DeleteByID(obj.GetKey());
            return 1;
        }


        #endregion

    }
    #endregion
}
