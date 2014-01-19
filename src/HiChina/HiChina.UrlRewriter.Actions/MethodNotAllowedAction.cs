using System;
using System.Net;
namespace HiChina.UrlRewriter.Actions
{
	public sealed class MethodNotAllowedAction : SetStatusAction
	{
		public MethodNotAllowedAction() : base(HttpStatusCode.MethodNotAllowed)
		{
		}
	}
}
