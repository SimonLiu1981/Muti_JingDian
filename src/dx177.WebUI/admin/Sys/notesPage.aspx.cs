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
using dx177.Model.Bus;
using dx177_building;

namespace dx177.WebUI.admin.Sys
{
    public partial class notesPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                ShowData();
            }
        }

        private void ShowData()
        {
            try
            {
                notes r = new notes();
                r = XmlData.XmlDeserialize(r.GetType(), "~/notes.xml") as notes;
                if (r != null)
                {
                    txtNoteDescr.Text = r.NoteDescr;
                    txtOrderAlertDescr.Text = r.OrderAlertDescr;
                    txtOrderButtonDescr.Text = r.OrderButtonDescr;
                    chkIsshow.Checked = r.orderButtonIsShow > 0 ? true : false;
                }
            }
            catch
            { }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            notes r = new notes();
            r.NoteDescr = txtNoteDescr.Text;
            r.OrderAlertDescr = txtOrderAlertDescr.Text;
            r.OrderButtonDescr = txtOrderButtonDescr.Text;
            r.orderButtonIsShow = chkIsshow.Checked ? 1 : 0;
            XmlData.Serialize(r, "~/notes.xml");
        }
    }
}
