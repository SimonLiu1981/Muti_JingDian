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
using dx177.Model;
using dx177.Business.Bus;
using dx177.Model.Bus;
using dx177.FrameWork;
using System.Web.Security; 
 


namespace dx177.WebUI.admin.UserMgnt
{
	/// <summary>
	/// PassWordManager 的摘要说明。
	/// </summary>
	public partial class PassWordManager : BasePage
	{
         
      
		protected void Page_Load(object sender, System.EventArgs e)
		{
			// 在此处放置用户代码以初始化页面
		}

		 
        protected void btnSave_Click(object sender, System.EventArgs e)
        {
            Resuser a = AppContext.CurrentResuser;

            if (FormsAuthentication.HashPasswordForStoringInConfigFile(txtOldPassWord.Text, "MD5") != a.Pwd)
            {
                lblMsg.Visible = true;
                lblMsg.Text = "密码不正确!";
                return;
            }
            
            if (txtNewPassWord.Text == "" &&
                txtRepitPassWord.Text == "")
            {
                lblMsg.Visible = true;
                lblMsg.Text = "密码不能为空!";
                return;
            }
            if (txtNewPassWord.Text != txtRepitPassWord.Text )
            {
                lblMsg.Visible = true;
                lblMsg.Text = "两次输入的密码不正确!";
                return;
            }

            a.Pwd = FormsAuthentication.HashPasswordForStoringInConfigFile(txtNewPassWord.Text, "MD5");            
            ResuserBLL.GetInstance().Update(a);
            AppContext.CurrentResuser = a;
            PageTools.ShowMessage(this, "密码修改成功！");
        }
	}
}
