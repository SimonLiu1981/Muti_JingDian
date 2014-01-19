using HiChina.UrlRewriter.Conditions;
using System;
using System.Xml;
namespace HiChina.UrlRewriter.Parsers
{
	public sealed class UrlMatchConditionParser : IRewriteConditionParser
	{
		public IRewriteCondition Parse(XmlNode node)
		{
			if (node == null)
			{
				throw new ArgumentNullException("node");
			}
			XmlNode namedItem = node.Attributes.GetNamedItem("url");
			if (namedItem != null)
			{
				return new UrlMatchCondition(namedItem.Value);
			}
			return null;
		}
	}
}
