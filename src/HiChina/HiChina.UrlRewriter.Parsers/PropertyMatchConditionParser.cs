using HiChina.UrlRewriter.Conditions;
using HiChina.UrlRewriter.Utilities;
using System;
using System.Configuration;
using System.Xml;
namespace HiChina.UrlRewriter.Parsers
{
	public sealed class PropertyMatchConditionParser : IRewriteConditionParser
	{
		public IRewriteCondition Parse(XmlNode node)
		{
			if (node == null)
			{
				throw new ArgumentNullException("node");
			}
			XmlNode namedItem = node.Attributes.GetNamedItem("property");
			if (namedItem == null)
			{
				return null;
			}
			string value = namedItem.Value;
			XmlNode namedItem2 = node.Attributes.GetNamedItem("match");
			if (namedItem2 != null)
			{
				return new PropertyMatchCondition(value, namedItem2.Value);
			}
			throw new ConfigurationErrorsException(MessageProvider.FormatString(Message.AttributeRequired, new object[]
			{
				"match"
			}), node);
		}
	}
}
