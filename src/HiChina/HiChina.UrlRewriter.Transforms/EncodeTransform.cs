using System;
using System.Web;
namespace HiChina.UrlRewriter.Transforms
{
	public sealed class EncodeTransform : IRewriteTransform
	{
		public string Name
		{
			get
			{
				return "encode";
			}
		}
		public string ApplyTransform(string input)
		{
			return HttpUtility.UrlEncode(input);
		}
	}
}
