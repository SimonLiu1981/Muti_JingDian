using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace dx177.ZhuNaAPI.ZhunaEntities
{
    [DataContract]
    public class City : ZhunaBase
    {
        [DataMember(Name = "reqdata")]
        public CityEntity[] CityList { get; set; }
    }

    [DataContract]
    public class CityEntity
    {
        [DataMember(Name = "id")]
        public int ID { get; set; }

        [DataMember(Name = "cid")]
        public string CityID { get; set; }

        [DataMember(Name = "pid")]
        public string PerentCityID { get; set; }

        [DataMember(Name = "pName")]
        public string PerentCityName { get; set; }

        [DataMember(Name = "cName")]
        public string CityName { get; set; }

        [DataMember(Name = "areaid")]
        public int AreaID { get; set; }

    }
}
