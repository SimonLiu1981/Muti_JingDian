using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace dx177.ZhuNaAPI.ZhunaEntities
{
    [DataContract]
    public class ZhunaBase
    {
        [DataMember(Name = "retHeader")]
        public ZhunaHeader ResponseHeader { get; set; }
        [DataMember(Name = "retcode")]
        public string ResponseCode { get; set; }
    }

    [DataContract]
    public class ZhunaHeader
    {
        [DataMember(Name = "totalput")]
        public int TotalCount { get; set; }
    }

}
