using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace dx177.ZhuNaAPI.ZhunaEntities
{
    

    [DataContract]
    public class ZNHotel : ZhunaBase
    {
        [DataMember(Name = "reqdata")]
        public HotelEntity Detail { get; set; }
    }

    [DataContract]
    public class HotelEntity
    {
        [DataMember(Name = "id")]
        public int HotelId { get; set; }

        [DataMember(Name = "hotelname")]
        public string HotelName { get; set; }

        [DataMember(Name = "address")]
        public string Address { get; set; }

        [DataMember(Name = "picture")]
        public string Picture { get; set; }

        [DataMember(Name = "x")]
        public string X { get; set; }

        [DataMember(Name = "y")]
        public string Y { get; set; }


        [DataMember(Name = "content")]
        public string content { get; set; } 

        [DataMember(Name = "jianshu")]
        public string jianshu { get; set; }


        [DataMember(Name = "min_jiage")]
        public int? min_jiage { get; set; }

        [DataMember(Name = "max_jiangjin")]
        public int? max_jiangjin { get; set; }

        /// <summary>
        /// 酒店荣誉（特色）
        /// </summary>
        [DataMember(Name = "teshe")]
        public string teshe { get; set; }

        /// <summary>
        /// 纬度
        /// </summary>
        [DataMember(Name = "lat")]
        public string Lat { get; set; }

        /// <summary>
        /// 经度
        /// </summary>
        [DataMember(Name = "lng")]
        public string Lng { get; set; }

        /// <summary>
        /// 百度地图纬度
        /// </summary>
        [DataMember(Name = "baidu_lat")]
        public string BaiduLat { get; set; }

        /// <summary>
        /// 百度地图经度
        /// </summary>
        [DataMember(Name = "baidu_lng")]
        public string BaiduLng { get; set; }

        [DataMember(Name = "tags")]
        public string tags { get; set; }

        /// <summary>
        /// 娱乐信息
        /// </summary>
        [DataMember(Name = "yulejianshen")]
        public string yulejianshen { get; set; }

        /// <summary>
        /// 交通指南
        /// </summary>
        [DataMember(Name = "traffic_zhinan")]
        public string traffic_zhinan { get; set; }

        [DataMember(Name = "xingji")]
        public int xingji { get; set; }
         
    }
}
