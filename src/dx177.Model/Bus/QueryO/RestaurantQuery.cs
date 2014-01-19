using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace dx177.Model.Bus.QueryO
{
    public class RestaurantQuery
    {
        public string Title
        {
            get;
            set;
        }

        public string OpenStatus
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

         

    }
}
