using System;
using System.Net;
namespace HiChina.UrlRewriter.Actions
{
	public class SetStatusAction : IRewriteAction
	{
		private HttpStatusCode _statusCode;
		public HttpStatusCode StatusCode
		{
			get
			{
				return this._statusCode;
			}
		}
		public SetStatusAction(HttpStatusCode statusCode)
		{
			this._statusCode = statusCode;
		}
		public virtual RewriteProcessing Execute(RewriteContext context)
		{
			if (context == null)
			{
				throw new ArgumentNullException("context");
			}
			context.StatusCode = this.StatusCode;
			if (this.StatusCode >= HttpStatusCode.MultipleChoices)
			{
				return RewriteProcessing.StopProcessing;
			}
			return RewriteProcessing.ContinueProcessing;
		}
	}
}
