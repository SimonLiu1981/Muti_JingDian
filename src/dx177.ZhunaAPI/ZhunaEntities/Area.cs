using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace dx177.ZhuNaAPI.ZhunaEntities
{
    [DataContract]
    public class Area : ZhunaBase
    {
        [DataMember(Name = "reqdata")]
        public AreaEntity[] AreaList { get; set; }
    }

    [DataContract]
    public class AreaEntity
    {
        [DataMember(Name = "cbd_id")]
        public string ID { get; set; }

        /// <summary>
        /// cbd_name	string	商圈名称
        /// </summary>
        [DataMember(Name = "CBD_Name")]
        public string Name { get; set; }
         
        /// <summary>
        /// cityid	string	城市id
        /// </summary>
        [DataMember(Name = "CityID")]
        public string CityID { get; set; } 

        /// <summary>
        /// hotelnum	int	酒店数量
        /// </summary>
        [DataMember(Name = "hotelnum")]
        public int HotelNum { get; set; }

    }
}
