using System;
using System.Text;
namespace HiChina.UrlRewriter.Transforms
{
	public sealed class Base64Transform : IRewriteTransform
	{
		public string Name
		{
			get
			{
				return "base64decode";
			}
		}
		public string ApplyTransform(string input)
		{
			return Convert.ToBase64String(Encoding.UTF8.GetBytes(input));
		}
	}
}
