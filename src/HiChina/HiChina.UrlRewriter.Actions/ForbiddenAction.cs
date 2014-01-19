using System;
using System.Net;
namespace HiChina.UrlRewriter.Actions
{
	public sealed class ForbiddenAction : SetStatusAction
	{
		public ForbiddenAction() : base(HttpStatusCode.Forbidden)
		{
		}
	}
}
