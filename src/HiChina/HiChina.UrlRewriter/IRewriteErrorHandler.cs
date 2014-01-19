using System;
using System.Web;
namespace HiChina.UrlRewriter
{
	public interface IRewriteErrorHandler
	{
		void HandleError(HttpContext context);
	}
}
