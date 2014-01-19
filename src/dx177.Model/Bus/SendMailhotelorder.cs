using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace dx177.Model.Bus
{
    
   public   class SendMailhotelorder
    {

       Hotelorder _order = null;

       public Hotelorder order
       {
           get
           {
               return _order;
           }
           set
           {
               _order = value;
           }
       }


       MailSetting _mailsetting = null;

       public MailSetting mailsetting
       {
           get
           {
               return _mailsetting;
           }
           set
           {
               _mailsetting = value;
           }
       }


       int _Issendorderemail = 0;

       public int  Issendorderemail
       {
           get
           {
               return _Issendorderemail;
           }
           set
           {
               _Issendorderemail = value;
           }
       }



       string  _Email = "" ;

       public string  Email
       {
           get
           {
               return _Email;
           }
           set
           {
               _Email = value;
           }
       }
    }
}
