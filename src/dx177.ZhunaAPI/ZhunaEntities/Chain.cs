using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace dx177.ZhuNaAPI.ZhunaEntities
{
    [DataContract]
    public class Chain : ZhunaBase
    {
        [DataMember(Name = "reqdata")]
        public ChainEntity[] ChainList { get; set; }
    }

    [DataContract]
    public class ChainEntity
    {
        [DataMember(Name = "id")]
        public int ChainId { get; set; }

        [DataMember(Name = "lsname")]
        public string ChainFullName { get; set; }

        [DataMember(Name = "liansuo")]
        public string ChainName { get; set; }

        [DataMember(Name = "tupian")]
        public string Picture { get; set; }

        [DataMember(Name = "ls")]
        public string ShortName { get; set; }

        [DataMember(Name = "hotelnum")]
        public int HotelNumber { get; set; }


        /// <summary>
        /// （0经济1豪华2舒适3高档）
        /// </summary>
        [DataMember(Name = "jibie")]
        public int ChainLevel { get; set; }
    }
}
