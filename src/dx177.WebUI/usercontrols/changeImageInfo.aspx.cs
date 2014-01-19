using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using dx177.Business.Bus;
using dx177.Model.Bus;

namespace dx177.WebUI.usercontrols
{
    public partial class changeImageInfo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            
            if (!IsPostBack)
            {
                Picturelist obj = PicturelistBLL.GetInstance().Get(new Picturelist.Key(int.Parse(Request.QueryString["picSeqno"])));
                Image1.ImageUrl = obj.Smallimgfile;
                txtTitle.Text = obj.Title;
                txtShowidx.Text = obj.Showidx.ToString();
            }

        }

        
        public string AjaxUpdateByPicsId(string seqno,string title,int showidx)
        {
            Picturelist obj = PicturelistBLL.GetInstance().Get(new Picturelist.Key(int.Parse(seqno)));
            obj.Title = title;
            obj.Showidx = showidx;
            PicturelistBLL.GetInstance().Submit(obj);
            return "1";
        }
    }
}
