using System;
using System.Net;
namespace HiChina.UrlRewriter.Actions
{
	public sealed class NotImplementedAction : SetStatusAction
	{
		public NotImplementedAction() : base(HttpStatusCode.NotImplemented)
		{
		}
	}
}
