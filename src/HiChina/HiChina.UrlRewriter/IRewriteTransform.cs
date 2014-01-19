using System;
namespace HiChina.UrlRewriter
{
	public interface IRewriteTransform
	{
		string Name
		{
			get;
		}
		string ApplyTransform(string input);
	}
}
