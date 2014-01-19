using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace dx177.Model.Bus.QueryO
{
   public  class HotelQuery
   {
       /// <summary>
       /// 酒店名
       /// </summary>
       public string Name
       {
           get;
           set;
       }

       /// <summary>
       /// 酒店类型
       /// </summary>
       public string HotelType
       {
           get;
           set;
       }

       string _BeginDate = "1901-01-01";
       /// <summary>
       /// 创建开始时间
       /// </summary>
       public string BeginDate
       {
           get
           {
               return _BeginDate;
           }
           set
           {
               if (value != string.Empty)
               {
                   _BeginDate = value;
               }
               
           }
       }

       string _EndDate = "2049-12-12";
       /// <summary>
       /// 创建结束时间
       /// </summary>
       public string EndDate
       {
           get
           {
               return _EndDate;
           }
           set
           {

               if (value != string.Empty)
               {
                   _EndDate = value;
               }
           }
       }


       /// <summary>
       /// 设置一个默认值
       /// </summary>
       decimal _Price1 = 0;
       /// <summary>
       /// 价格1
       /// </summary>
       public decimal Price1
       {
           get
           {
               return _Price1;
           }
           set
           {
               _Price1 = value;
           }
       }

       /// <summary>
       /// 设置一个默认值
       /// </summary>
       decimal _Price2 = 10000000;
       /// <summary>
       /// 价格2
       /// </summary>
       public decimal Price2
       {
           get
           {
               return _Price2;
           }
           set
           {
               _Price2 = value;
           }
       }

       string _Area = string.Empty;
       /// <summary>
       /// 
       /// </summary>
       public string Area
       {
           get
           {
               return _Area;
           }
           set
           {
               _Area = value;
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

       string _JingQuCode = "";
       public string JingQuCode
       {
           get
           {
               return _JingQuCode;
           }
           set
           {
               _JingQuCode = value;
           }
       }
       
   
   }
}
