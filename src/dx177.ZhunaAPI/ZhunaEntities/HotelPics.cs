using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace dx177.ZhuNaAPI.ZhunaEntities
{    
    [DataContract]
    public class HotelPics 
    {
        public string HotelName { get; set; }

        public string IndentityPicture { get; set; }

        public List<HotelPicEntity> Pics { get; set; }
    }



    [DataContract]
    public class HotelPicEntity
    {
        public string Title { get; set; }

        public string Pic500 { get; set; }

        public string pic160 { get; set; }
    }
}
