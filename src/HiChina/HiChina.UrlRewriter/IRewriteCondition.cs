using System;
namespace HiChina.UrlRewriter
{
	public interface IRewriteCondition
	{
		bool IsMatch(RewriteContext context);
	}
}
