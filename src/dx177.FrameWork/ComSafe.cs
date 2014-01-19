using System;
using System.Collections.Generic;
using System.Text;

namespace dx177.FrameWork
{
  public  class ComSafe
  {
      /// <summary>
      /// 防止用'注入sql 
      /// </summary>
      /// <param name="v"></param>
      /// <returns></returns>
      public static  string SafeValue(string v)
      {
          v = v.Replace("'", "");
          return v;
      }
  
  }
}
