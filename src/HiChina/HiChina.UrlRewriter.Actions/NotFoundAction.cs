using System;
using System.Net;
namespace HiChina.UrlRewriter.Actions
{
	public sealed class NotFoundAction : SetStatusAction
	{
		public NotFoundAction() : base(HttpStatusCode.NotFound)
		{
		}
	}
}
