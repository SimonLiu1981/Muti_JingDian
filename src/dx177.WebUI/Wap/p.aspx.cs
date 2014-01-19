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
using dx177.Business.Bus;
using dx177.Model.Bus;
using System.Collections.Generic;

namespace dx177.WebUI.Wap
{
    public partial class p : System.Web.UI.Page
    {
        public Products pl = new Products();
        public int Seqno
        {
            get
            {
                if (Request.QueryString["Seqno"] != null)
                {
                    return int.Parse(Request.QueryString["Seqno"]);
                }
                return 0;
            }
        }
        protected string HotelTypeName = "";
        protected string AreaType = "";
        protected string productTypeName="";
        protected void Page_Load(object sender, EventArgs e)
        {
            pl = ProductsBLL.GetInstance().Get(new Products.Key(this.Seqno));
            productTypeName = ProductstypeBLL.GetInstance().GetProductstypeByguid(pl.Ptype ).Title ;
            //dlRoom.DataSource = RoomBLL.GetInstance().GetRoom(new dx177.Model.Bus.QueryO.RoomQuery { PGuid = h.Guid });
            //dlRoom.DataBind();
            IList<Picturelist> res = PicturelistBLL.GetInstance().GetPicsByGuid(pl.Guid);
            List<Picturelist> res1 = new List<Picturelist>();
            foreach (Picturelist tmp in res)
            {
                if (res1.Count < 2)
                {
                    res1.Add(tmp);
                }
            }

          

            dlPics.DataSource = res1;
            dlPics.DataBind();
        }
    }
}
