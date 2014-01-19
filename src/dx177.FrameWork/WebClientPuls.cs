using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;

namespace dx177.FrameWork
{
    public class WebClientPlus : WebClient
    {

        private CookieContainer m_container = new CookieContainer();

        public CookieContainer CookieContainer
        {

            get { return m_container; }

            set { m_container = value; }

        }

        [System.Security.SecuritySafeCritical]//重要
        public WebClientPlus()

            : base()
        {

        }

        protected override WebRequest GetWebRequest(Uri address)
        {

            WebRequest request = base.GetWebRequest(address);

            if (request is HttpWebRequest)
            {

                (request as HttpWebRequest).CookieContainer = m_container;

            }

            return request;

        }

    }
}
