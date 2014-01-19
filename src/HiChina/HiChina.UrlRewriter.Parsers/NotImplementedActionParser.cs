using HiChina.UrlRewriter.Actions;
using System;
using System.Xml;
namespace HiChina.UrlRewriter.Parsers
{
	public sealed class NotImplementedActionParser : RewriteActionParserBase
	{
		public override string Name
		{
			get
			{
				return "not-implemented";
			}
		}
		public override bool AllowsNestedActions
		{
			get
			{
				return false;
			}
		}
		public override bool AllowsAttributes
		{
			get
			{
				return false;
			}
		}
		public override IRewriteAction Parse(XmlNode node, object config)
		{
			return new NotImplementedAction();
		}
	}
}
