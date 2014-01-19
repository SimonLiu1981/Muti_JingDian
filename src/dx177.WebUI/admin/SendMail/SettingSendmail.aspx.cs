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

namespace dx177.WebUI.admin.SendMail
{
    public partial class SettingSendmail : System.Web.UI.Page
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
                MailSetting r = new MailSetting();
                r = XmlData.XmlDeserialize(r.GetType(), "~/MailSetting.xml") as MailSetting;
                if (r != null)
                {
                    txtMail.Text = r.Mail;
                    txtmail1.Text = r.mail1;
                    txtmail2.Text = r.mail2;
                    txtpasswword.Text = r.passwword;
                    txtsmtp.Text = r.smtp;
                }
            }
            catch
            { }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            MailSetting r = new MailSetting();
            r.Mail = txtMail.Text;
            r.mail1 = txtmail1.Text;
            r.mail2 = txtmail2.Text;
            r.passwword = txtpasswword.Text;
            r.smtp = txtsmtp.Text;
            XmlData.Serialize(r, "~/MailSetting.xml");
        }
    }
}
