using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace dx177.Model.Bus.QueryO
{
    public class QuestionsQuery
    {
        public string Title
        {
            get;
            set;
        }

        public string QuestStatus
        {
            get;
            set;
        }

        public string Orderby
        {
            get;
            set;
        }

        public string Qtype
        {
            get;
            set;
        }
        public string Creator
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

        public int TopNumber{ get; set; }
    }
}
