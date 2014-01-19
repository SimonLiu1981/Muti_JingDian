using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace dx177_building.Model
{
   [Serializable]
   public class CycleDataTableMod
   {
       private CycleDataMod[]  _CycleDataMods = null;
       public CycleDataMod[] CycleDataMods
       {
           get
           {
               return _CycleDataMods;
           }
           set
           {
                 _CycleDataMods = value;
           }
       }

       private string  M_SavePath = null;
       public string SavePath
       {
           get
           {
               return M_SavePath;
           }
           set
           {
                 M_SavePath = value;
           }
       }
   }
}
