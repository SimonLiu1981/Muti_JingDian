using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace dx177_building.Model
{
    [Serializable]
    public  class CallMethodArrMod
    {
        CallMethodMod[] _CallMethodMods = null;
        public CallMethodMod[] callmethodmods
        {
            get
            {
                return _CallMethodMods;
            }
            set
            {
                _CallMethodMods = value;
            }
        }
        SearchXmlFile[] _SearchXmlFiles = null;
        public SearchXmlFile[] SearchXmlFileS
        {
            get
            {
                return _SearchXmlFiles;
            }
            set
            {
                _SearchXmlFiles = value;
            }
        }

        string _CurrentEncoding = null;
        public string CurrentEncoding
        {
            get
            {
                return _CurrentEncoding;
            }
            set
            {
                _CurrentEncoding = value;
            }
        }

        string _Name = null;
        public string Name
        {
            get
            {
                return _Name;
            }
            set
            {
                _Name = value;
            }
        }
    }
}
