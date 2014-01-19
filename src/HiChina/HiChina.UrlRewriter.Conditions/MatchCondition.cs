using System;
using System.Text.RegularExpressions;
namespace HiChina.UrlRewriter.Conditions
{
	public abstract class MatchCondition : IRewriteCondition
	{
		private Regex _pattern;
		public Regex Pattern
		{
			get
			{
				return this._pattern;
			}
		}
		protected MatchCondition(string pattern)
		{
			if (pattern == null)
			{
				throw new ArgumentNullException("pattern");
			}
			this._pattern = new Regex(pattern, RegexOptions.IgnoreCase);
		}
		public abstract bool IsMatch(RewriteContext context);
	}
}
