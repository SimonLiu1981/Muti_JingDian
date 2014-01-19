using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Web;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using dx177.Business;
using dx177.Business.Bus;
using dx177.Model.Bus;
using dx177.Model;
using System.Net;
using dx177.FrameWork;
using System.Web.Security;
 

namespace dx177.WebUI.Admin
{
	/// <summary>
	/// login ��ժҪ˵����
	/// </summary>
	public partial class login : System.Web.UI.Page
	{        

		protected void Page_Load(object sender, System.EventArgs e)
		{
			// �ڴ˴������û������Գ�ʼ��ҳ��
            string r = Request.QueryString["jingqucode"];
		}

		#region Web ������������ɵĴ���
		override protected void OnInit(EventArgs e)
		{
			//
			// CODEGEN: �õ����� ASP.NET Web ���������������ġ�
			//
			InitializeComponent();
			base.OnInit(e);
		}
		
		/// <summary>
		/// �����֧������ķ��� - ��Ҫʹ�ô���༭���޸�
		/// �˷��������ݡ�
		/// </summary>
		private void InitializeComponent()
		{    

        }
		#endregion

        
		protected void ibtnCancel_Click(object sender, System.Web.UI.ImageClickEventArgs e)
		{
		
		}

        protected void btnLogin_Click(object sender, EventArgs e)
        {

#if !DEBUG
            if (Session["RndCode"].ToString().ToUpper() != txtcode.Text.Trim().ToUpper()
                && System.Configuration.ConfigurationManager.AppSettings["NeedValidateCode"] == "1")
            {
                lblMsg.Text = "��֤�벻��ȷ!";
                return;
            }
#endif
            ResuserBLL lh = ResuserBLL.GetInstance();
            Resuser ad = lh.GetResuserByEmailName(txtName.Text);

            string pass = FormsAuthentication.HashPasswordForStoringInConfigFile(txtPassWord.Text, "MD5");

            if (ad != null && ad.Pwd == pass)
            {
                if (ad.Usertype == ResUserType.SupperJingQqAdmin.ToString("d"))
                {
                    if (!string.IsNullOrEmpty(AppContext.CurrentMgtJingQuCode) && ad.Jingqucode != AppContext.CurrentMgtJingQuCode)
                    {
                        lblMsg.Text = "�㲻�Ǹþ����Ĺ���Ա��";
                        return;
                    }
                    AppContext.CurrentResuser = ad;
                    HttpCookie c = new HttpCookie(CookieName.CurrentAdminJingQuCode.ToString(), ad.Jingqucode);
                    HttpCookie c1 = new HttpCookie(CookieName.CurrentAdminUserName.ToString(), ad.Username);
                    Response.AppendCookie(c);
                    Response.AppendCookie(c1);
                    Response.Redirect("~/admin/JingquManagementNavigation.aspx");
                }
                else if (ad.Usertype == ResUserType.SupperAdmin.ToString("d"))
                {
                    AppContext.CurrentResuser = ad;
                    HttpCookie c = new HttpCookie(CookieName.CurrentAdminJingQuCode.ToString(), ad.Jingqucode);
                    HttpCookie c1 = new HttpCookie(CookieName.CurrentAdminUserName.ToString(), ad.Username);
                    Response.AppendCookie(c);
                    Response.AppendCookie(c1);
                    Response.Redirect("~/admin/JingquManagementNavigation.aspx");
                }
                else
                {
                    lblMsg.Text = "�㲻�Ǹþ����Ĺ���Ա��";
                    return;                
                }                
            }
            else
            {
                HttpCookie c = new HttpCookie(CookieName.CurrentAdminJingQuCode.ToString(), string.Empty);
                HttpCookie c1 = new HttpCookie(CookieName.CurrentAdminUserName.ToString(), string.Empty);
                lblMsg.Text = "�û����������벻��ȷ!";
            }
        }
	}
}
