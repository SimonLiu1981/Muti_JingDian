using HiChina.UrlRewriter.Utilities;
using System;
using System.Net;
namespace HiChina.UrlRewriter.Conditions
{
	public sealed class AddressCondition : IRewriteCondition
	{
		private IPRange _range;
		public AddressCondition(string pattern)
		{
			if (pattern == null)
			{
				throw new ArgumentNullException("pattern");
			}
			this._range = IPRange.Parse(pattern);
		}
		public bool IsMatch(RewriteContext context)
		{
			if (context == null)
			{
				throw new ArgumentNullException("context");
			}
			string text = context.Properties["REMOTE_ADDR"];
			return text != null && this._range.InRange(IPAddress.Parse(text));
		}
	}
}
