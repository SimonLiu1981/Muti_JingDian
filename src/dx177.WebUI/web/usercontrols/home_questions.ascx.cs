using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using dx177.Business.Bus;
using dx177.Model.Bus.QueryO;
using dx177.Model.Bus;

namespace dx177.WebUI.web.usercontrols
{
    public partial class home_questions : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            QuestionsQuery query = new QuestionsQuery();
            query.Orderby = "viewtimes";
            query.TopNumber = 15;
            IList<Questions> res = QuestionsBLL.GetInstance().Search(query);
            Repeater1.DataSource = res;
            Repeater1.DataBind();

        }
    }
}