using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using dx177.Model.Bus;
using System.Data;
using dx177.Access.Bus;

namespace dx177.Business.Bus
{
    public class QuestionralationsBLL : BaseBLL<Questionralations>
    {

        public DataTable GetRelateQuestions(string guid)
        {
            string sql = @"select * from questions where guid  in (select t.RalateQuestionGUIDB as QuestionGUID  from QuestionRalations t 
                        where t.RalateQuestionGUIDA = '{0}' and t.RalateQuestionGUIDB !='{0}'
                        union
                        select t.RalateQuestionGUIDA  from QuestionRalations t 
                        where t.RalateQuestionGUIDB = '{0}' and t.RalateQuestionGUIDA !='{0}') 
                        and GUID != '{0}'";
            sql = string.Format(sql, guid);
            DataTable dt = this.GetDataTable(sql);
            return dt;
        }

        public bool DeleteRelation(string guidA, string guidB)
        {
            string sql = @"delete from QuestionRalations 
                           where (RalateQuestionGUIDB ='{0}' and RalateQuestionGUIDA ='{1}')
                           or (RalateQuestionGUIDA = '{0}' and RalateQuestionGUIDB ='{1}')";

            sql = string.Format(sql, guidA, guidB);
            this.Execute(sql);
            return true;
        }

        public bool InsertRelation(string guidA, string guidB)
        {
            DeleteRelation(guidA, guidB);
            Questionralations qr = new Questionralations();
            qr.Ralatequestionguida = guidA;
            qr.Ralatequestionguidb = guidB;
            QuestionralationsDao.GetInstance().Insert(qr);
            return true;
        }



        /// <summary>
		/// 方法名称: BaseDictTagBLL
		/// 内容摘要: 构造函数进行初始化
		/// </summary>
        protected QuestionralationsBLL()
		{
		}
        private static volatile QuestionralationsBLL m_instance = null;
		/// <summary>
		/// 方法名称: GetInstance
		/// 内容摘要: 取得 BaseDictTagBLL 对象
		/// </summary>
		/// <returns>返回一个已经存在的实体</returns>
        public static QuestionralationsBLL GetInstance()
		{
			// 通用的必要代码 iBatisNet双校检机制,如果实例不存在
			if (m_instance == null)
			{
                lock (typeof(QuestionralationsBLL))
				{

					// 如果实例不存在
					if (m_instance == null)
					{

						// 创建一个的实例
                        m_instance = new QuestionralationsBLL();
					}
				}
			}

			// 返回业务逻辑对象
			return m_instance;
		}
		
    }
}
