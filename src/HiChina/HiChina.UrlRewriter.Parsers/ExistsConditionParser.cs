using HiChina.UrlRewriter.Conditions;
using System;
using System.Xml;
namespace HiChina.UrlRewriter.Parsers
{
	public sealed class ExistsConditionParser : IRewriteConditionParser
	{
		public IRewriteCondition Parse(XmlNode node)
		{
			if (node == null)
			{
				throw new ArgumentNullException("node");
			}
			XmlNode namedItem = node.Attributes.GetNamedItem("exists");
			if (namedItem != null)
			{
				return new ExistsCondition(namedItem.Value);
			}
			return null;
		}
	}
}
