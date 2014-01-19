using System;
using System.Xml;
namespace HiChina.UrlRewriter
{
	public interface IRewriteConditionParser
	{
		IRewriteCondition Parse(XmlNode node);
	}
}
