using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace dx177.Model.Bus.QueryO
{
    public class RoomQuery
    {
        string _PGuid = ""; 
        public string PGuid
        {
            get
            {
                return _PGuid;
            }
            set
            {
                _PGuid = value;
            }
        }
        string _HotelName = ""; 
        public string HotelName
        {
            get
            {
                return _HotelName;
            }
            set
            {
                _HotelName = value;
            }
        }
        string _HotelType = ""; 
        public string HotelType
        {
            get
            {
               return  _HotelType;
            }
            set
            {
                _HotelType = value;
            }
        }


        string _BeginDate = "1901-01-01"; 
        public string BeginDate
        {
            get
            {
                return _BeginDate;
            }
            set
            {
                _BeginDate = value;
            }
        }

        string _EndDate = "2049-12-31";
        public string EndDate
        {
            get
            {
                return _EndDate;
            }
            set
            {
                _EndDate = value;
            }
        }

        decimal _minPrice = 0;
        public decimal minPrice
        {
            get
            {
                return _minPrice;
            }
            set
            {
                _minPrice = value;
            }
        }
        decimal _maxPrice = 0;
        public decimal maxPrice
        {
            get
            {
                return _maxPrice;
            }
            set
            {
                _maxPrice = value;
            }
        
        }

    }
}
