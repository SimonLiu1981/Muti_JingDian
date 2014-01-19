using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Collections;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace dx177.Model
{
    /// <summary>
    /// 所有实体的基类
    /// </summary>	
    [Serializable]
    abstract public class BaseModel : ICloneable, IEditableObject
    {
        #region 自动生成代码
        private bool m_isDeleted = false;		//Delete标记
        private bool m_isUpdated = false;		//Update标记
        private bool m_isNew = false;		//AddNew标记
        private bool m_isChanged = false; 		//在修改后调用过AcceptChange()或EndEdit则为false，未调用则为true
        protected BaseModel OldValue = null;	//上一次调用BeginEdit()方法前的值

        public enum ColumnNameEnum
        {
            DBName = 1,			//使用DB列名构造DataTable
            PropertyName = 2	//使用实体属性名构造DataTable
        };

        /// <summary>
        /// 实体是否做过改变(有Delete或Update或New标记之一)
        /// </summary>
        public virtual bool IsChanged()
        {
            //return IsDeleted() || IsNew() || IsUpdated();
            return m_isChanged;
        }

        /// <summary>
        /// 实体是否标记为已删除
        /// </summary>
        public virtual bool IsDeleted()
        {
            return m_isDeleted;
        }

        /// <summary>
        /// 实体是否标记为新建
        /// </summary>		
        public virtual bool IsNew()
        {
            return m_isNew;
        }

        /// <summary>
        /// 实体是否标记为更新过
        /// </summary>
        public virtual bool IsUpdated()
        {
            return m_isUpdated;
        }

        /// <summary>
        /// 标记实体为新建
        /// </summary>		
        protected void MarkNew()
        {
            m_isNew = true;
            m_isChanged = true;
        }

        /// <summary>
        /// 标记实体为更新过
        /// </summary>
        protected void MarkUpdated()
        {
            m_isUpdated = true;
            m_isChanged = true;
        }

        /// <summary>
        /// 标记实体已删除
        /// </summary>		
        public virtual void MarkDeleted()
        {
            m_isDeleted = true;
            m_isChanged = true;
        }

        /// <summary>
        /// 实现深度Clone
        /// </summary>
        public virtual object Clone()
        {
            MemoryStream stream = new MemoryStream();
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(stream, this);
            stream.Position = 0;
            return formatter.Deserialize(stream);
        }

        /// <summary>
        /// 接受实体的变化(默认不保存原值)，EndEdit 方法被隐式调用，以便终止任何编辑
        /// </summary>
        public virtual void AcceptChange()
        {
            if (m_isChanged)
            {
                //并不调用m_isDeleted = false;是因为需要继续标记该对象已被删除
                m_isChanged = false;
                m_isUpdated = false;
                m_isNew = false;
                this.OldValue = null;//清空保留值			
            }
        }

        /// <summary>
        /// 接受实体集合中所有实体的变化
        /// </summary>
        /// <param name="models"></param>
        static public void AcceptChange(IList models)
        {
            foreach (object o in models)
            {
                BaseModel bm = o as BaseModel;
                if (bm == null)
                {
                    throw new ArgumentException("An element is not 'BaseModel' derived object", "models");
                }
                bm.AcceptChange();
            }
        }

        /// <summary>
        /// 从models中得到变化了的实体集合
        /// </summary>
        /// <param name="models">待检测的实体</param>
        /// <param name="bCloneElem">是否将变化了实体Clone一份后再加入结果集</param>
        /// <returns></returns>
        static public IList GetChanges(IList models, bool bCloneElem)
        {
            ArrayList alResult = new ArrayList();
            foreach (object o in models)
            {
                BaseModel bm = o as BaseModel;
                if (bm == null)
                {
                    throw new ArgumentException("An element is not 'BaseModel' derived object", "models");
                }
                if (bm.IsChanged())
                {
                    if (bCloneElem)
                    {
                        bm = bm.Clone() as BaseModel;
                    }
                    alResult.Add(bm);
                }
            }
            return alResult;
        }

        /// <summary>
        /// 从models中得到变化了的实体集合(缺省不Clone变化的实体)
        /// </summary>
        /// <param name="models">待检测的实体</param>
        /// <returns></returns>
        static public IList GetChanges(IList models)
        {
            return GetChanges(models, false);
        }

        #region IEditableObject 实现

        /// <summary>
        /// 开始编辑,如果已经调用过BeginEdit则忽略再次调用
        /// </summary>		
        public void BeginEdit()
        {
            if (this.OldValue == null)
            {//如果已经调用过BeginEdit则忽略再次调用
                this.OldValue = this.Clone() as BaseModel;
            }
        }

        /// <summary>
        /// 结束编辑,同时清空OldValue
        /// </summary>
        public void EndEdit()
        {
            this.AcceptChange();
        }

        /// <summary>
        /// 取消编辑,恢复到上次有效调用BeginEdit前的状态
        /// </summary>		
        public abstract void CancelEdit();
        #endregion

        #endregion
    }
}