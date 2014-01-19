using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
 

using dx177.Business;
using dx177.FrameWork;
using dx177.Business.Bus;
using dx177.WebUI.admin;
 

namespace dx177.WebUI.Admin.Frame
{
    public partial class main : BasePage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                OrderInfoInit();

                ProductInfoInit();

                MessageInfoInit();
            }
        }

 
        private void MessageInfoInit()
        {
            
            
        }

        private void ProductInfoInit()
        {
             
        }

        private void OrderInfoInit()
        {
             
        }
    }
}
