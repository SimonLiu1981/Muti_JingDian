using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace dx177_building.Model
{
    [Serializable]
   public  class TreeMod
   {
       /// <summary>
       /// 
       /// </summary>
       TreeDataMod[] M_TreeDataMod = null;
       public TreeDataMod[] TreeDataArr
       {
           get
           {
               return M_TreeDataMod;
           }
           set
           {
               M_TreeDataMod = value;
           }
       }
       string _KeyCode = null;
       public string KeyCode
       {
           get
           {
               return _KeyCode;
           }
           set
           {
               _KeyCode = value;
           }
       }
        /// <summary>
        /// 
        /// </summary>
        string m_SavePath = "";
        public string SavePath
        {
            get
            {
                return m_SavePath;
            }
            set
            {
                m_SavePath = value;
            }
        }
   }
}
