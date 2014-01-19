using System;
using System.Web;
namespace HiChina.UrlRewriter.Transforms
{
	public sealed class DecodeTransform : IRewriteTransform
	{
		public string Name
		{
			get
			{
				return "decode";
			}
		}
		public string ApplyTransform(string input)
		{
			return HttpUtility.UrlDecode(input);
		}
	}
}
