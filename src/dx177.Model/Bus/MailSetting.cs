using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace dx177.Model.Bus
{
    [Serializable]
   public  class MailSetting
    {

        string _Mail = "";
        public string  Mail
        {
            get
            {
                return _Mail;
            }
            set
            {
                _Mail = value;
            }
        }


        string _passwword = "";
        public string passwword
        {
            get
            {
                return _passwword;
            }
            set
            {
                _passwword = value;
            }
        }


        string _smtp = "";
        public string smtp
        {
            get
            {
                return _smtp;
            }
            set
            {
                _smtp = value;
            }
        }

        string _mail1 = "";
        public string mail1
        {
            get
            {
                return _mail1;
            }
            set
            {
                _mail1 = value;
            }
        }


        string _mail2 = "";
        public string mail2
        {
            get
            {
                return _mail2;
            }
            set
            {
                _mail2 = value;
            }
        }
    }
}
