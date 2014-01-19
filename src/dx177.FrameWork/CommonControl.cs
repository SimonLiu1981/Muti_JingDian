using System;
using System.Collections.Generic;
using System.Text;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace dx177.FrameWork
{
    public class CommonControl
    {

        public static void BindDorpList(DropDownList dl, DataTable dt, string TextField, string ValueField)
        {
            dl.DataSource = dt;
            dl.DataTextField = TextField;
            dl.DataValueField = ValueField;
            dl.DataBind();
        }

        public static string GetChecklistSelectValue(CheckBoxList ch)
        {
            string rvalue = "";
            for (int i = 0; i < ch.Items.Count; i++)
            {
                if (ch.Items[i].Selected)
                {
                    rvalue += ch.Items[i].Value + ",";
                }
            }
            rvalue = rvalue.Trim(',');
            return rvalue;
        }

      
    }
}
