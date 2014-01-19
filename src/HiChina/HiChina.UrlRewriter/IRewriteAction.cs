using System;
namespace HiChina.UrlRewriter
{
	public interface IRewriteAction
	{
		RewriteProcessing Execute(RewriteContext context);
	}
}
