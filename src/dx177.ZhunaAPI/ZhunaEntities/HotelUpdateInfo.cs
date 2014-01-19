using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace dx177.ZhuNaAPI.ZhunaEntities
{
   [XmlRoot("hotel")]
    public class HotelUpdateInfoList
    {
        [XmlElement("hotelid")]
        public HotelUpdateInfo[] List { get; set; }
    }
 
    public class HotelUpdateInfo
    {
        [XmlAttribute("ct")]
        public int UpdateTime { get; set; }
        [XmlAttribute("id")]
        public int HotelId { get; set; }
    }
}
