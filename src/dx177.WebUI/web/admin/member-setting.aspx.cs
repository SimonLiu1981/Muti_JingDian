using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using dx177.Model;
using dx177.Model.Bus;
using dx177.Business.Bus;
using dx177.FrameWork;

namespace dx177.WebUI.web.admin
{
    public partial class member_setting : ResUserBasePage
    {
        protected string UserName = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            UserName = AppContext.CurrentResuser.Username;
            if (!IsPostBack)
            {
                if (AppContext.CurrentResuser != null)
                {
                    
                    txtName.Text = AppContext.CurrentResuser.Name;
                    if (AppContext.CurrentResuser.Sex != string.Empty)
                    {
                        rbtSex.SelectedValue = AppContext.CurrentResuser.Sex;
                    }
                    dateBrithday.Text = AppContext.CurrentResuser.Brithday;
                    txtEmail.Text = AppContext.CurrentResuser.Email;
                    txtMsn.Text = AppContext.CurrentResuser.Msn;
                    txtQq.Text = AppContext.CurrentResuser.Qq;
                    txtPhone.Text = AppContext.CurrentResuser.Mobile;
                }
            }
            
        }

        /// <summary>
        /// 保存资料
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnSave_Click(object sender, EventArgs e)
        {
            AppContext.CurrentResuser.Sex = rbtSex.SelectedValue;
            AppContext.CurrentResuser.Name = txtName.Text;
            AppContext.CurrentResuser.Brithday = dateBrithday.Text;
            AppContext.CurrentResuser.Email = txtEmail.Text;
            AppContext.CurrentResuser.Msn = txtMsn.Text;
            AppContext.CurrentResuser.Qq = txtQq.Text;
            AppContext.CurrentResuser.Mobile = txtPhone.Text;
            ResuserBLL.GetInstance().Submit(AppContext.CurrentResuser);
            PageTools.ShowMessage(this, "修改资料提交成功！");

        }
        /// <summary>
        /// 保存密码
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnSave1_Click(object sender, EventArgs e)
        {
            if (AppContext.CurrentResuser.Pwd != txtOldPwd.Text)
            {
                PageTools.ShowMessage(this, "旧密码输入不正确！");
            }
            else
            {
                AppContext.CurrentResuser.Pwd = txtNewPwd.Text;
                ResuserBLL.GetInstance().Submit(AppContext.CurrentResuser);
                PageTools.ShowMessage(this, "修改密码提交成功！");
            }
        }

    }
}
