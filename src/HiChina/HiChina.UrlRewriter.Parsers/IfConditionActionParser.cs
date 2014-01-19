using HiChina.UrlRewriter.Actions;
using HiChina.UrlRewriter.Configuration;
using HiChina.UrlRewriter.Utilities;
using System;
using System.Collections;
using System.Configuration;
using System.Xml;
namespace HiChina.UrlRewriter.Parsers
{
	public class IfConditionActionParser : RewriteActionParserBase
	{
		public override string Name
		{
			get
			{
				return "if";
			}
		}
		public override bool AllowsNestedActions
		{
			get
			{
				return true;
			}
		}
		public override bool AllowsAttributes
		{
			get
			{
				return true;
			}
		}
		public override IRewriteAction Parse(XmlNode node, object config)
		{
			if (node == null)
			{
				throw new ArgumentNullException("node");
			}
			if (config == null)
			{
				throw new ArgumentNullException("config");
			}
			RewriterConfiguration config2 = config as RewriterConfiguration;
			ConditionalAction conditionalAction = new ConditionalAction();
			bool negative = node.LocalName == "unless";
			base.ParseConditions(node, conditionalAction.Conditions, negative, config);
			IfConditionActionParser.ReadActions(node, conditionalAction.Actions, config2);
			return conditionalAction;
		}
		private static void ReadActions(XmlNode node, IList actions, RewriterConfiguration config)
		{
			for (XmlNode xmlNode = node.FirstChild; xmlNode != null; xmlNode = xmlNode.NextSibling)
			{
				if (xmlNode.NodeType == XmlNodeType.Element)
				{
					IList parsers = config.ActionParserFactory.GetParsers(xmlNode.LocalName);
					if (parsers != null)
					{
						bool flag = false;
						foreach (IRewriteActionParser rewriteActionParser in parsers)
						{
							IRewriteAction rewriteAction = rewriteActionParser.Parse(xmlNode, config);
							if (rewriteAction != null)
							{
								flag = true;
								actions.Add(rewriteAction);
							}
						}
						if (!flag)
						{
							throw new ConfigurationErrorsException(MessageProvider.FormatString(Message.ElementNotAllowed, new object[]
							{
								node.FirstChild.Name
							}), node);
						}
					}
				}
			}
		}
	}
}
