using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace dx177_building.Model
{
  public  class PageCycleMod
  {
      string _Sql = null;
      public string Sql
      {
          get
          {
              return _Sql;
          }
          set
          {
              _Sql = value;
          }
      }

        string m_ReplaceCode = null;
      /// <summary>
      /// 页面上替换的串
      /// </summary>
      public string ReplaceCode
      {
          get
          {
              return m_ReplaceCode;
          }
          set
          {
              m_ReplaceCode = value;
          }
      }

        string m_xmlPath = null;
      /// <summary>
      /// XML路径
      /// </summary>
      public string xmlPath
      {
          get
          {
              return m_xmlPath;
          }
          set
          {
              m_xmlPath = value;
          }
      }
  }
}
