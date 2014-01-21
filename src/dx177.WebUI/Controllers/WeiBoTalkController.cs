using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace dx177.WebUI.Controllers
{
    public class WeiBoTalkController : ApiController
    {
        // GET api/weibotalk
        public A Get()
        {
            return new A { MyProperty="111" };
            
        }

        // GET api/weibotalk/5        
        public string Get(int id)
        {
            return "value";
        }

        // POST api/weibotalk
        public void Post([FromBody]string value)
        {
        }

        // PUT api/weibotalk/5
        public void Put(int id, [FromBody]string value)
        {
        }

        
        public void Delete(int id)
        {
        }
    }

    [Serializable]
    public class A
    {
        public string MyProperty { get; set; }
    }
}
