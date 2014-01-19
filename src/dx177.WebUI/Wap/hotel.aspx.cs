using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using dx177.Model.Bus;
using dx177.Business.Bus;
using dx177.Business.DictBus;

namespace dx177.WebUI.Wap
{
    public partial class hotel : System.Web.UI.Page
    {
        public Hotel h = new Hotel();
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

        protected void Page_Load(object sender, EventArgs e)
        {
            h = HotelBLL.GetInstance().Get(new Hotel.Key(this.Seqno));
            HotelTypeName = Dict.Tag["HotelType", h.Hoteltype, 2052];            
            AreaType = Dict.Tag["AREA", h.Area, 2052];
            dlRoom.DataSource = RoomBLL.GetInstance().GetRoom(new dx177.Model.Bus.QueryO.RoomQuery { PGuid= h.Guid });
            dlRoom.DataBind();
            IList<Picturelist> res = PicturelistBLL.GetInstance().GetPicsByGuid(h.Guid);
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
