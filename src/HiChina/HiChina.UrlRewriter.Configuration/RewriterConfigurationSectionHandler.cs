using System;
using System.Configuration;
using System.Xml;
namespace HiChina.UrlRewriter.Configuration
{
	public sealed class RewriterConfigurationSectionHandler : IConfigurationSectionHandler
	{
		object IConfigurationSectionHandler.Create(object parent, object configContext, XmlNode section)
		{
			return section;
		}
	}
}
