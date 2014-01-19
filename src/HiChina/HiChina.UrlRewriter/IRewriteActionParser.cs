using System;
using System.Xml;
namespace HiChina.UrlRewriter
{
	public interface IRewriteActionParser
	{
		string Name
		{
			get;
		}
		bool AllowsNestedActions
		{
			get;
		}
		bool AllowsAttributes
		{
			get;
		}
		IRewriteAction Parse(XmlNode node, object config);
	}
}
