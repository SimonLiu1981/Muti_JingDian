using System;
using System.Text.RegularExpressions;
using System.Threading;
namespace HiChina.UrlRewriter.Conditions
{
	public sealed class UrlMatchCondition : IRewriteCondition
	{
		private Regex _regex;
		private string _pattern;
		public string Pattern
		{
			get
			{
				return this._pattern;
			}
		}
		public UrlMatchCondition(string pattern)
		{
			if (pattern == null)
			{
				throw new ArgumentNullException("pattern");
			}
			this._pattern = pattern;
		}
		public bool IsMatch(RewriteContext context)
		{
			if (context == null)
			{
				throw new ArgumentNullException("context");
			}
			if (this._regex == null)
			{
				Monitor.Enter(this);
				try
				{
					if (this._regex == null)
					{
						this._regex = new Regex(context.ResolveLocation(this.Pattern), RegexOptions.IgnoreCase);
					}
				}
				finally
				{
					Monitor.Exit(this);
				}
			}
			Match match = this._regex.Match(context.Location);
			if (match.Success)
			{
				context.LastMatch = match;
				return true;
			}
			return false;
		}
	}
}
