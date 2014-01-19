using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using dx177.Business.Bus;
using dx177.Model.Bus;

namespace dx177.WebUI.web.usercontrols
{
    public partial class home_new : System.Web.UI.UserControl
    {
        private string m_NewsTypeCode;
        public string NewsTypeCode
        {
            get
            {
                return m_NewsTypeCode;
            }
            set
            {
                m_NewsTypeCode = value;
            }
        }

        private string m_OrderBy;
        public string OrderBy
        {
            get
            {
                return m_OrderBy;
            }
            set
            {
                m_OrderBy = value;
            }
        }
        private int m_MaxCount = 0;
        public int MaxCount
        {
            get
            {
                return m_MaxCount;
            }
            set
            {
                m_MaxCount = value;
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            IList<News> res = NewsBLL.GetInstance().Font_Search(OrderBy, NewsTypeCode, MaxCount, string.Empty);

            this.Repeater1.DataSource = res;
            this.Repeater1.DataBind();
        }
    }
}