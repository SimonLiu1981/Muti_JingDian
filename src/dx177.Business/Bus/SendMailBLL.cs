using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mail;
using dx177.Model.Bus;
using dx177_building;
namespace CampanyCMS.Business.Bus
{
  public   class SendMailBLL
  {
     #region 自动生成代码：取得相关实体

		/// <summary>
		/// 方法名称: ProductsTypeBLL
		/// 内容摘要: 构造函数进行初始化
		/// </summary>
         protected SendMailBLL()
		{
		}
         private static volatile SendMailBLL m_instance = null;
		/// <summary>
		/// 方法名称: GetInstance
		/// 内容摘要: 取得 ProductsTypeBLL 对象
		/// </summary>
		/// <returns>返回一个已经存在的实体</returns>
         public static SendMailBLL GetInstance()
		{
			// 通用的必要代码 iBatisNet双校检机制,如果实例不存在
			if (m_instance == null)
			{
                lock (typeof(SendMailBLL))
				{

					// 如果实例不存在
					if (m_instance == null)
					{

						// 创建一个的实例
                        m_instance = new SendMailBLL();
					}
				}
			}

			// 返回业务逻辑对象
			return m_instance;
		}
		
		#endregion

         public string MailTo = "";
         public string MailFrom = "";
         public string Subject = "";
         public string Body = "";
         public string Password = "";
         public string SmtpServer = "";
         public int IsHtml = 1;
         public string Bcc = "";
         public void sendMailMsg()
         {
             MailMessage mail = new MailMessage();
             mail.To = this.MailTo;
             if (!string.IsNullOrEmpty(this.Bcc))
                        mail.Bcc = this.Bcc;
             mail.From = this.MailFrom;
             mail.Subject = this.Subject;
             mail.Body = this.Body;
             mail.BodyFormat = this.IsHtml == 1 ? MailFormat.Html : MailFormat.Text;//设置为HTML格式 
             mail.Fields.Add("http://schemas.microsoft.com/cdo/configuration/sendusing", 2);
             mail.Fields.Add("http://schemas.microsoft.com/cdo/configuration/sendemailaddress", this.MailTo);
             mail.Fields.Add("http://schemas.microsoft.com/cdo/configuration/smtpaccountname", this.MailFrom);
             //设置为需要用户验证
             mail.Fields.Add("http://schemas.microsoft.com/cdo/configuration/smtpauthenticate", "1");
             //设置验证用户名(把my_username_here改为你的验证用户名） 
             mail.Fields.Add("http://schemas.microsoft.com/cdo/configuration/sendusername", this.MailFrom);
             //设置验证密码（把password改为你的验证密码） 
             mail.Fields.Add("http://schemas.microsoft.com/cdo/configuration/sendpassword", this.Password);
             SmtpMail.SmtpServer = SmtpServer;
             SmtpMail.Send(mail);
         }

         public static readonly  object obj = new object();
         public void SendMail(SendMailhotelorder  sorder)
         {
             string body = "";
             lock (SendMailBLL.obj)
             {
                 MailSetting r = sorder.mailsetting;
                 Hotelorder hotelorder = sorder.order;                  
                 if (r != null)
                 {
                     string mailto = "";
                     if (sorder.Issendorderemail > 0 && !string.IsNullOrEmpty( sorder.Email) ) 
                     {
                         mailto = ";" + sorder.Email;
                     }
                     this.Bcc = r.mail2;
                     this.MailFrom = r.Mail;
                     this.MailTo = r.mail1 + mailto;
                     this.SmtpServer = r.smtp;
                     this.Password = r.passwword;
                     string strbody = string.Format(@" {0}电话号码：{8},{1}酒店{5}间--{7},{2}价格, 入住时间:{3},离开时间:{4},总共{6}", hotelorder.Orderusername, hotelorder.Hotelname, hotelorder.Price, hotelorder.Begindate, hotelorder.Enddate, hotelorder.Roomcount, hotelorder.Totalmoney, hotelorder.Roomtitle, hotelorder.Personphone);
                     this.Body = strbody;
                     this.Subject = "有游客已在www.177dx.com下了订单，赶快联系旅客吧！";
                     this.sendMailMsg();
                 }
             }
         }


         


  }
}
