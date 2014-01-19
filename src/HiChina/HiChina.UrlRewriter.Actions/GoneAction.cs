using System;
using System.Net;
namespace HiChina.UrlRewriter.Actions
{
	public sealed class GoneAction : SetStatusAction
	{
		public GoneAction() : base(HttpStatusCode.Gone)
		{
		}
	}
}
