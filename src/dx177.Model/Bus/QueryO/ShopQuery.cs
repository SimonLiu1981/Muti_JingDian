using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace dx177.Model.Bus.QueryO
{
   public  class ShopQuery
   {
       string _Title = "";
       public string Title
       {
           get
           {
               return _Title;
           }
           set
           {
               _Title = value;
           }
       }

       string _OpenStatus = "";
       public string OpenStatus
       {
           get
           {
               return _OpenStatus;
           }
           set
           {
               _OpenStatus = value;
           }
       }

       string _BizType = "";
       public string BizType
       {
           get
           {
               return _BizType;
           }
           set
           {
               _BizType = value;
           }
       }


       string _Creator = "";
       public string Creator
       {
           get
           {
               return _Creator;
           }
           set
           {
               _Creator = value;
           }
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
