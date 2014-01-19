using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace dx177.ZhuNaAPI.ZhunaEntities
{
    [DataContract]
    public class CenterBinessDistrct : ZhunaBase
    {
        [DataMember(Name = "reqdata")]
        public CenterBinessDistrctEntity[] CBDList { get; set; }
    }

    [DataContract]
    public class CenterBinessDistrctEntity
    {
        [DataMember(Name = "cbd_id")]
        public string CBDID { get; set; }

        [DataMember(Name = "CityID")]
        public int CityID { get; set; }

         [DataMember(Name = "CBD_Name")]

        public string CBDName { get; set; }

        [DataMember(Name = "hotelnum")]
        public int HotelNumber { get; set; }
    }
}
