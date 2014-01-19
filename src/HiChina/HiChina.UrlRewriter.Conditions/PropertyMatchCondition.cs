using System;
using System.Text.RegularExpressions;
namespace HiChina.UrlRewriter.Conditions
{
	public sealed class PropertyMatchCondition : MatchCondition
	{
		private string _propertyName = string.Empty;
		public string PropertyName
		{
			get
			{
				return this._propertyName;
			}
		}
		public PropertyMatchCondition(string propertyName, string pattern) : base(pattern)
		{
			if (propertyName == null)
			{
				throw new ArgumentNullException("propertyName");
			}
			if (pattern == null)
			{
				throw new ArgumentNullException("pattern");
			}
			this._propertyName = propertyName;
		}
		public override bool IsMatch(RewriteContext context)
		{
			if (context == null)
			{
				throw new ArgumentNullException("context");
			}
			string text = context.Properties[this.PropertyName];
			if (text == null)
			{
				return false;
			}
			Match match = base.Pattern.Match(text);
			if (match.Success)
			{
				context.LastMatch = match;
				return true;
			}
			return false;
		}
	}
}
