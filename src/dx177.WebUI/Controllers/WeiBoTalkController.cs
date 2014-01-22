using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web;
using System.Xml.Serialization;
using dx177.Model;
using dx177.Business;
using dx177.Model.WeiboTalk;

namespace dx177.WebUI.Controllers
{
    public class WeiBoTalkController : ApiController
    {
        public WeiBoTalkDBEntity Get()
        {
            return new WeiBoTalkDBEntity { guid = "11", CreateDate = DateTime.Now, seqno = 1 };
        }

        [HttpPost]
        public void Create()
        {            
            HttpContextBase context = (HttpContextBase)Request.Properties["MS_HttpContext"];
            HttpRequestBase request = context.Request;
            XmlSerializer xs = new XmlSerializer(typeof(WeiboTalkRQ));
            WeiboTalkRQ rq = xs.Deserialize(request.InputStream) as WeiboTalkRQ;

            DBContextDataContext db = new DBContextDataContext();
            List<WeiBoTalkDBEntity> listForDB = new List<WeiBoTalkDBEntity>();
            foreach (Item item in rq.Items.ItemCollection)
            {
                WeiBoTalkDBEntity ent = new WeiBoTalkDBEntity();
                ent.guid = new Guid().ToString();
                ent.talk = item.Talk;
                ent.JinqQuCode = item.JingQuCode;
                ent.CreateDate = item.CreateTime;
                ent.Keyval = item.Keyval;
                listForDB.Add(ent);

            }

            db.WeiBoTalkDBEntities.InsertAllOnSubmit(listForDB);
            db.SubmitChanges(); 

        } 
    }      
}
