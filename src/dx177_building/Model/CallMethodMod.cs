using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace dx177_building.Model
{
    [Serializable]
    public   class CallMethodMod
    {
        /// <summary>
        /// 参数值用@%分开
        /// </summary>
        string _ParaValue = "";
        public string ParaValue
        {
            get
            {
                return _ParaValue;
            }
            set
            {
                _ParaValue = value;
            }
        }
        string _Type = "";
        public string Type
        {
            get
            {
                return _Type;
            }
            set
            {
                _Type = value;
            }
        }

        string _Sql = "";
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

        string _CycleSql = "";
        public string CycleSql
        {
            get
            {
                return _CycleSql;
            }
            set
            {
                _CycleSql = value;
            }
        }

        string _xmlPath = string.Empty;
        public string xmlPath
        {
            get
            {
                return _xmlPath;
            }
            set
            {
                _xmlPath = value;
            }
        }

        string _Name = "";
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

        string _RunType = "";
        public string RunType
        {
            get
            {
                return _RunType;
            }
            set
            {
                _RunType = value;
            }
        }

    }
}
