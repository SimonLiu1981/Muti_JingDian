using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using dx177.Business.Bus;
using dx177.Model.Bus;
using dx177.Model;

namespace dx177.WebUI.web
{
    public partial class _default : System.Web.UI.Page
    {
         
        protected void Page_Load(object sender, EventArgs e)
        {
            dx177.Business.Bus.CommonBLL.GetInstance().IniPageKeyWord(this.Page, "default",null );

            string sql = @"select top 3 t.*,s.* from Restaurant t left join SumaryComment s on t.guid = s.pguid , Module  m
                            where t.status = 1 and  m.pguid = t.guid and m.modulecode='recommend' order by m.showidx desc ";
            rptHoteltj.DataSource = RestaurantBLL.GetInstance().GetDataTable(sql);
            rptHoteltj.DataBind();
            sql = @"select t.*,s.* from Restaurant t left join SumaryComment s on t.guid = s.pguid  
                            where t.status = 1 order by viewtimes desc";
            rptAll.DataSource = RestaurantBLL.GetInstance().GetDataTable(sql);
            rptAll.DataBind();

            rptFJ.DataSource = SitesBLL.GetInstance().Font_Search("viewtimes", 10, AppContext.JingQuCode);
            rptFJ.DataBind();

        }

        private object CommonBLL(defaultMaster defaultMaster)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// 分数传样式
        /// </summary>
        /// <param name="score"></param>
        /// <returns></returns>
        protected string SocreToCssStr(object score)
        {
            decimal s = decimal.Parse(score.ToString());
            return s.ToString("0.0").Replace(".","d");
        }
    }
}
