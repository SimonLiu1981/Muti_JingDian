using System;
using System.Web;
namespace HiChina.UrlRewriter.Actions
{
	public class SetCookieAction : IRewriteAction
	{
		private string _name;
		private string _value;
		public string Name
		{
			get
			{
				return this._name;
			}
		}
		public string Value
		{
			get
			{
				return this._value;
			}
		}
		public SetCookieAction(string cookieName, string cookieValue)
		{
			if (cookieName == null)
			{
				throw new ArgumentNullException("cookieName");
			}
			if (cookieValue == null)
			{
				throw new ArgumentNullException("cookieValue");
			}
			this._name = cookieName;
			this._value = cookieValue;
		}
		public RewriteProcessing Execute(RewriteContext context)
		{
			if (context == null)
			{
				throw new ArgumentNullException("context");
			}
			HttpCookie cookie = new HttpCookie(this.Name, this.Value);
			context.Cookies.Add(cookie);
			return RewriteProcessing.ContinueProcessing;
		}
	}
}
