using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using dx177.Business;
using dx177.Business.Bus;
using dx177.DataAccess.Access;
using dx177.Model.Bus;

namespace dx177.WebUI.Controllers
{
    public class JQController : Controller
    {

        [OutputCache(CacheProfile = "MyProfile", VaryByParam = "jingqucode")]
        public ActionResult Index(string jingqucode)
        {
            
            var entity = JingqusBLL.GetInstance().GetEntityByJingqucode(jingqucode);
            ViewBag.Entity = entity;
            ViewBag.JQ = entity.Jingqucode;
            ViewBag.Title = entity.Jingquname;
            ViewBag.Sites = Sites.Dt2Objs(SitesBLL.GetInstance().Font_Search(null, 5, jingqucode));
            ViewBag.Pics = PicturelistBLL.GetInstance().GetPicsByGuid(entity.Guid);
            ViewBag.Hotels = Hotel.Dt2Objs(HotelBLL.GetInstance().RecommendHotel(jingqucode));
            ViewBag.JQList = Jingqus.Dt2Objs(JingqusBLL.GetInstance().SearchByConditions(string.Empty,entity.Areaid.ToString()));
            DBContextDataContext db = new DBContextDataContext();
           

            ViewBag.QuestionTyps = Qsttype.Dt2Objs(DBTool.ExecuteDataTable(string.Format(@"SELECT *  FROM [hds0040800_db].[dbo].[QstType] t
                                                  where exists (select 1 from Questions q where q.QType = t.[GUID] and q.JingQuCode='{0}')", jingqucode))) ;


            ViewBag.Questions = (from t in db.QstType1
                                 join ccc in db.Questions1 on t.GUID equals ccc.QType
                                 orderby ccc.Seqno descending
                                 where ccc.JingQuCode.Equals(jingqucode)
                                 select new QuestionWithTypeName
                                 {
                                     Seqno = ccc.Seqno,
                                     Code = t.Code,
                                     TypeTile = t.Title,
                                     Title = ccc.Title,
                                     CreateDate = ccc.CREATE_DATE.Value
                                 }).Take(10).ToList();


            ViewBag.LatestNews = (from o in db.News1
                                  orderby o.Seqno descending
                                  where o.JingQuCode.Equals(jingqucode)
                                  select o).Take(6).ToList();

            ViewBag.LYGL = (from o in db.News1
                            orderby o.Seqno descending
                            join t in db.NewsType1 on o.TGUID equals t.GUID
                            where o.JingQuCode.Equals(jingqucode) && t.Code.Equals("LYGL")
                            select o).Take(6).ToList();

            return View();
        }

        public class QuestionWithTypeName : Questions
        {
            public string TypeTile { get; set; }
            public string Code { get; set; }
        }

    }
}
