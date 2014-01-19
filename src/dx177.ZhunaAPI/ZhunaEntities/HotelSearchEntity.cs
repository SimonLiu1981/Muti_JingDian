using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace dx177.ZhuNaAPI.ZhunaEntities
{
    [DataContract]
    public class HotelSearch : ZhunaBase
    {
        [DataMember(Name = "reqdata")]
        public HotelSearchEntity[] HotelList { get; set; }
    }

    [DataContract]
    public class HotelSearchEntity
    {
        [DataMember(Name = "ID")]
        public int HotelId { get; set; }

        [DataMember(Name = "HotelName")]
        public string HotelName { get; set; }

        [DataMember(Name = "Address")]
        public string Address { get; set; }

        [DataMember(Name = "Picture")]
        public string Picture { get; set; }


        public string JingQuName { get; set; }


    }
}
