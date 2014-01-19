using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using dx177.Model.Bus;
using dx177.Business.Bus;
using dx177.FrameWork;
using System.Web.Security;

namespace dx177.WebUI.admin.UserMgnt
{
    public partial class JingQuManager : BasePage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!base.IsSupperAdmin())
            {
                Logout();
                return;
            }
            if (!IsPostBack) {
                ddlJingQus.DataSource = JingqusBLL.GetInstance().Select();
                ddlJingQus.DataValueField = "JingQuCode";
                ddlJingQus.DataTextField= "JingQuName";
                ddlJingQus.DataBind();

                if (Request.QueryString["seqno"] != null)
                {
                    Resuser user = ResuserBLL.GetInstance().Get(new Resuser.Key(int.Parse(Request.QueryString["seqno"])));
                    if (user != null)
                    {
                        txtMailBox.Text = user.Email;
                        txtName.Text = user.Name;
                        ddlJingQus.SelectedValue = user.Jingqucode;
                        txtMobile.Text = user.Mobile;
                        txtPhone.Text = user.Phone;
                        //txtPassword.Text = user.Pwd;

                    }
                }
            }
        }

        protected void btnReturn_Click(object sender, EventArgs e)
        {
            Response.Redirect("JingQuManagerList.aspx");
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            Resuser user = null;
            if (Request.QueryString["seqno"] != null)
            {
                user = ResuserBLL.GetInstance().Get(new Resuser.Key(int.Parse(Request.QueryString["seqno"])));                
            }
            else
            {
                user = new Resuser();
            }

            user.Username = txtMailBox.Text;
            user.Email = txtMailBox.Text;
            user.Name = txtName.Text;
            user.Usertype = ResUserType.SupperJingQqAdmin.ToString("d");
            user.Jingqucode = ddlJingQus.SelectedValue;
            user.Mobile = txtMobile.Text;
            user.Phone = txtPhone.Text;
            if (txtPassword.Text.Trim() != string.Empty)
            {
                user.Pwd = FormsAuthentication.HashPasswordForStoringInConfigFile(txtPassword.Text, "MD5");         
            }
            ResuserBLL.GetInstance().Submit(user);

            btnReturn_Click(null, null);
        }
    }
}
