using System;
using System.Text;
namespace HiChina.UrlRewriter.Transforms
{
	public sealed class Base64DecodeTransform : IRewriteTransform
	{
		public string Name
		{
			get
			{
				return "base64";
			}
		}
		public string ApplyTransform(string input)
		{
			return Encoding.UTF8.GetString(Convert.FromBase64String(input));
		}
	}
}
