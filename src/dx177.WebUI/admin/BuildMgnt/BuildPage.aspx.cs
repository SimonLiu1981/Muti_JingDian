using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

using System.Text;
using dx177_building.Model;
using dx177_building;
using System.IO;
using dx177.WebUI.admin;
using dx177.Model;
using CampanyCMS.Model.Bus;
using dx177.FrameWork;


namespace dx177.WebUI.admin.BuildMgnt
{
    public partial class BuildPage : BasePage
    {
        public string Defaulthomepage = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            Defaulthomepage = "#";
            if (!Page.IsPostBack)
            {
               string  path = @"~/Templates/xml/hotel/CallMethodArrMod.xml";
                DataTable dt = BuildPageBLL.GetHtmlPageName(path);
                chkList.DataTextField = "name";
                chkList.DataValueField = "keyvalue";
                chkList.DataSource = dt;
                chkList.DataBind();
            }
        }

        private  void addDataRow(string v,string f,DataTable dt)
        {
            DataRow dr = dt.NewRow();
            dr["fvale"] = v;
            dr["ftext"] = f;
            dt.Rows.Add(dr);
        }

        protected void bntCreate_Click(object sender, EventArgs e)
        {
            BuildPageBLL.GobalPara(this, AppContext.CurrentResuser);            
            string getchkList =","+ CommonControl.GetChecklistSelectValue(chkList)+",";
            string path = @"~/Templates/xml/hotel/CallMethodArrMod.xml";
            CallMethodArrMod CallArr=new CallMethodArrMod() ;
            CallArr = XmlData.XmlDeserialize(CallArr.GetType(), path) as CallMethodArrMod;
            if (CallArr.CurrentEncoding.ToUpper()== "UTF8")
            {
                AppContext.CurrentEncoding = Encoding.UTF8;
            }
            else
            {
                AppContext.CurrentEncoding = Encoding.GetEncoding("gb2312");
            }
            foreach (CallMethodMod c in CallArr.callmethodmods)
            {
                if (getchkList.IndexOf(c.Name) != -1)
                {
                    FuntionParaMod f = new FuntionParaMod();
                    f.CycleSql = c.CycleSql ;
                    f.ParaArr = c.ParaValue;
                    f.Sql = c.Sql;
                    f.Type = c.Type;
                    f.xmlPath = c.xmlPath; 
                    BuildPageBLL.CreateHtml(f);
                }
            }
        }

        protected void cbAll_CheckedChanged(object sender, EventArgs e)
        {
            foreach (ListItem it in chkList.Items)
            {
                it.Selected = cbAll.Checked;
            }
            
        }
    }
}
