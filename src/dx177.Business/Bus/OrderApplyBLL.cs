using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using dx177.Model.Bus;
using dx177.Access.Bus;
using System.Collections;
using System.Data;
using dx177.Model;

namespace dx177.Business.Bus
{
    public partial class OrderApplyBLL : BaseBLL<OrderApply>
    {


        /// <summary>
        /// 提交
        /// </summary>
        /// <param name="obj"></param>
        public void Submit(OrderApply obj)
        {
            obj.LastUpdateDate = DateTime.Now;
            if (obj.OrderApplyId > 0)
            {

                this.Update(obj);
            }
            else
            {
                obj.CreateDate = DateTime.Now;
                this.Insert(obj);
                obj.OrderNo = DateTime.Now.ToString("yyyyMMdd") + obj.OrderApplyId.ToString().PadLeft(10, '0');
                this.Update(obj);
            }
        }

        /// <summary>
        /// 没有
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="list"></param>
        public void Submit(OrderApply obj, List<ShoppingCarEntriy> list)
        {
            Submit(obj);

            List<OrderApplyItem> listItem = new List<OrderApplyItem>();

            foreach (ShoppingCarEntriy tmp in list)
            {
                OrderApplyItem addnew = new OrderApplyItem();
                addnew.ProductId = int.Parse(tmp.ProductId);
                addnew.OrderApplyId = obj.OrderApplyId;
                addnew.LasteUpdateDate = DateTime.Now;
                addnew.CreateDate = DateTime.Now;
                addnew.Count = list.Count;
                addnew.Tatol = Convert.ToDouble(tmp.Total);
                addnew.Vaild = 1;
                addnew.ProductName = tmp.Name;
                addnew.Count = tmp.Count;
                addnew.UnitPrice = Convert.ToDouble(tmp.Price);
                listItem.Add(addnew);
            }
            OrderApplyItemBLL.GetInstance().Submit(listItem, obj.OrderApplyId.ToString());
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Orderid"></param>
        public void Remove(int  Orderid)
        {
            OrderApply a = OrderApplyBLL.GetInstance().Get(new OrderApply.Key(Orderid));
            this.Delete(a);
            OrderApplyItemBLL.GetInstance().DeleteByorderid(Orderid ) ; 
        }

        public DataTable SearchData(string Creator)
        {
            string sql = "select  *  from Order_Apply where product_seller='{0}' or '{0}'='{1}' or  ''='{0}'  order by Order_Apply_ID desc ";
            sql = string.Format(sql, Creator, AppContext.Admin);
            return  this.GetDataTable(sql);
        }

    }


    #region 代码自动生成
    /// <summary>
    /// Products的BLL
    /// 该BLL已经生成了基本的业务操作，在自动生成的方法中已经提供了事务机制
    /// </summary>
    public partial class OrderApplyBLL : BaseBLL<OrderApply>
    {
        #region 自动生成代码：取得相关实体

        /// <summary>
        /// 方法名称: ProductsBLL
        /// 内容摘要: 构造函数进行初始化
        /// </summary>
        protected OrderApplyBLL()
        {
        }
        private static volatile OrderApplyBLL m_instance = null;
        /// <summary>
        /// 方法名称: GetInstance
        /// 内容摘要: 取得 ProductsBLL 对象
        /// </summary>
        /// <returns>返回一个已经存在的实体</returns>
        public static OrderApplyBLL GetInstance()
        {
            // 通用的必要代码 iBatisNet双校检机制,如果实例不存在
            if (m_instance == null)
            {
                lock (typeof(OrderApplyBLL))
                {

                    // 如果实例不存在
                    if (m_instance == null)
                    {

                        // 创建一个的实例
                        m_instance = new OrderApplyBLL();
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
        public OrderApply Get(OrderApply.Key key)
        {
            return OrderApplyDao.GetInstance().SelectByID(key);
        }
        /// <summary>
        /// 方法名称: Select
        /// 内容摘要: 基本查询，不带任何条件的查询
        /// </summary>
        public IList Select()
        {
            return OrderApplyDao.GetInstance().SelectAll();
        }
        /// <summary>
        /// 方法名称: Insert
        /// 内容摘要: 插入一条新纪录
        /// </summary>
        /// <returns>int</returns>
        public int Insert(OrderApply obj)
        {
            return OrderApplyDao.GetInstance().Insert(obj);
        }

        /// <summary>
        /// 方法名称: Update
        /// 内容摘要: 更新一条新纪录
        /// </summary>
        /// <returns>int</returns>
        public int Update(OrderApply obj)
        {
            OrderApplyDao.GetInstance().Update(obj);
            return 1;
        }

        /// <summary>
        /// 方法名称: Delete
        /// 内容摘要: 删除一条新纪录
        /// </summary>
        /// <returns>int</returns>
        public int Delete(OrderApply obj)
        {
            OrderApplyDao.GetInstance().DeleteByID(obj.GetKey());
            return 1;
        }


        #endregion

    }
    #endregion
}
