using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace dx177_building.Model
{
    [Serializable]
    public  class HashDataMod
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


        string _HashKey = null;
        public string HashKey
        {
            get
            {
                return _HashKey;
            }
            set
            {
                _HashKey = value;
            }
        }
 
    }
}
