using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using dx177.Business;
using PagedList;
using dx177.Business.Bus;
using dx177.Model.Bus;

namespace dx177.WebUI.Controllers
{
    public class WeibolistController : Controller
    {
        //
        // GET: /Weibolist/
        public ActionResult Index(string jingqucode, int? p)
        {
            DBContextDataContext db = new DBContextDataContext();
            var entity = JingqusBLL.GetInstance().GetEntityByJingqucode(jingqucode);
            ViewBag.Entity = entity;
            ViewBag.JQ = entity.Jingqucode;
            ViewBag.Title = entity.Jingquname;
            ViewBag.Sites = Sites.Dt2Objs(SitesBLL.GetInstance().Font_Search(null, 5, jingqucode));
            ViewBag.Questions = (from t in db.QstType1
                                 join ccc in db.Questions1 on t.GUID equals ccc.QType
                                 orderby ccc.Seqno descending
                                 where ccc.JingQuCode.Equals(jingqucode)
                                 select new dx177.WebUI.Controllers.JQController.QuestionWithTypeName
                                 {
                                     Seqno = ccc.Seqno,
                                     Code = t.Code,
                                     TypeTile = t.Title,
                                     Title = ccc.Title,
                                     CreateDate = ccc.CREATE_DATE.Value
                                 }).Take(5).ToList();

            int pageNumber = 1;
            if (p.HasValue && p.Value > 0)
            {
                pageNumber = p.Value;
            }
            

            var talklist = (from o in db.WeiBoTalkDBEntities
                           where o.JinqQuCode.Equals(jingqucode)
                           orderby o.seqno descending
                          select o).ToList();           
            
            return View(talklist.ToPagedList(pageNumber, 10));
        }

    }
}
