using HiChina.UrlRewriter.Conditions;
using System;
using System.Xml;
namespace HiChina.UrlRewriter.Parsers
{
	public sealed class MethodConditionParser : IRewriteConditionParser
	{
		public IRewriteCondition Parse(XmlNode node)
		{
			if (node == null)
			{
				throw new ArgumentNullException("node");
			}
			XmlNode namedItem = node.Attributes.GetNamedItem("method");
			if (namedItem != null)
			{
				return new MethodCondition(namedItem.Value);
			}
			return null;
		}
	}
}
