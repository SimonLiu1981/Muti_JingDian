using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using dx177.Model.Bus;
using dx177.Business.Bus;
using dx177.Model.Bus.QueryO;

namespace dx177.WebUI.web.usercontrols
{
    public partial class right_hireCar : System.Web.UI.UserControl
    {
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

        private string m_ModuleCode;
        public string ModuleCode
        {
            get
            {
                return m_ModuleCode;
            }
            set
            {
                m_ModuleCode = value;
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            IList<Hirecar> res = HirecarBLL.GetInstance().Font_Search( this.ModuleCode );
            IList<Hirecar> band = new List<Hirecar>();
            int all = res.Count;
            if (MaxCount > 0)
            {
                if (MaxCount < all)
                {
                    all = MaxCount;
                }
            }
            for (int i = 0; i < all; i++)
            {
                band.Add(res[i]);
            }
            this.Repeater1.DataSource = band;
            this.Repeater1.DataBind();

        }
    }
}