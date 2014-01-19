using HiChina.UrlRewriter.Errors;
using HiChina.UrlRewriter.Logging;
using HiChina.UrlRewriter.Transforms;
using HiChina.UrlRewriter.Utilities;
using System;
using System.Collections;
using System.Collections.Specialized;
using System.Configuration;
using System.Xml;
namespace HiChina.UrlRewriter.Configuration
{
	public sealed class RewriterConfigurationReader
	{
		private RewriterConfigurationReader()
		{
		}
		public static object Read(XmlNode section)
		{
			if (section == null)
			{
				throw new ArgumentNullException("section");
			}
			RewriterConfiguration rewriterConfiguration = RewriterConfiguration.Create();
			foreach (XmlNode xmlNode in section.ChildNodes)
			{
				if (xmlNode.NodeType == XmlNodeType.Element)
				{
					if (xmlNode.LocalName == "error-handler")
					{
						RewriterConfigurationReader.ReadErrorHandler(xmlNode, rewriterConfiguration);
					}
					else
					{
						if (xmlNode.LocalName == "default-documents")
						{
							RewriterConfigurationReader.ReadDefaultDocuments(xmlNode, rewriterConfiguration);
						}
						else
						{
							if (xmlNode.LocalName == "register")
							{
								if (xmlNode.Attributes["parser"] != null)
								{
									RewriterConfigurationReader.ReadRegisterParser(xmlNode, rewriterConfiguration);
								}
								else
								{
									if (xmlNode.Attributes["transform"] != null)
									{
										RewriterConfigurationReader.ReadRegisterTransform(xmlNode, rewriterConfiguration);
									}
									else
									{
										if (xmlNode.Attributes["logger"] != null)
										{
											RewriterConfigurationReader.ReadRegisterLogger(xmlNode, rewriterConfiguration);
										}
									}
								}
							}
							else
							{
								if (xmlNode.LocalName == "mapping")
								{
									RewriterConfigurationReader.ReadMapping(xmlNode, rewriterConfiguration);
								}
								else
								{
									RewriterConfigurationReader.ReadRule(xmlNode, rewriterConfiguration);
								}
							}
						}
					}
				}
			}
			return rewriterConfiguration;
		}
		private static void ReadRegisterTransform(XmlNode node, RewriterConfiguration config)
		{
			XmlNode xmlNode = node.Attributes["transform"];
			if (xmlNode == null)
			{
				throw new ConfigurationErrorsException(MessageProvider.FormatString(Message.AttributeRequired, new object[]
				{
					"transform"
				}), node);
			}
			if (node.ChildNodes.Count > 0)
			{
				throw new ConfigurationErrorsException(MessageProvider.FormatString(Message.ElementNoElements, new object[]
				{
					"register"
				}), node);
			}
			IRewriteTransform rewriteTransform = TypeHelper.Activate(xmlNode.Value, null) as IRewriteTransform;
			if (rewriteTransform != null)
			{
				config.TransformFactory.AddTransform(rewriteTransform);
			}
		}
		private static void ReadRegisterLogger(XmlNode node, RewriterConfiguration config)
		{
			XmlNode xmlNode = node.Attributes["logger"];
			if (xmlNode == null)
			{
				throw new ConfigurationErrorsException(MessageProvider.FormatString(Message.AttributeRequired, new object[]
				{
					"logger"
				}), node);
			}
			if (node.ChildNodes.Count > 0)
			{
				throw new ConfigurationErrorsException(MessageProvider.FormatString(Message.ElementNoElements, new object[]
				{
					"register"
				}), node);
			}
			IRewriteLogger rewriteLogger = TypeHelper.Activate(xmlNode.Value, null) as IRewriteLogger;
			if (rewriteLogger != null)
			{
				config.Logger = rewriteLogger;
			}
		}
		private static void ReadRegisterParser(XmlNode node, RewriterConfiguration config)
		{
			XmlNode xmlNode = node.Attributes["parser"];
			if (xmlNode == null)
			{
				throw new ConfigurationErrorsException(MessageProvider.FormatString(Message.AttributeRequired, new object[]
				{
					"parser"
				}), node);
			}
			if (node.ChildNodes.Count > 0)
			{
				throw new ConfigurationErrorsException(MessageProvider.FormatString(Message.ElementNoElements, new object[]
				{
					"register"
				}), node);
			}
			object obj = TypeHelper.Activate(xmlNode.Value, null);
			IRewriteActionParser rewriteActionParser = obj as IRewriteActionParser;
			if (rewriteActionParser != null)
			{
				config.ActionParserFactory.AddParser(rewriteActionParser);
			}
			IRewriteConditionParser rewriteConditionParser = obj as IRewriteConditionParser;
			if (rewriteConditionParser != null)
			{
				config.ConditionParserPipeline.AddParser(rewriteConditionParser);
			}
		}
		private static void ReadDefaultDocuments(XmlNode node, RewriterConfiguration config)
		{
			foreach (XmlNode xmlNode in node.ChildNodes)
			{
				if (xmlNode.NodeType == XmlNodeType.Element && xmlNode.LocalName == "document")
				{
					config.DefaultDocuments.Add(xmlNode.InnerText);
				}
			}
		}
		private static void ReadErrorHandler(XmlNode node, RewriterConfiguration config)
		{
			XmlNode xmlNode = node.Attributes["code"];
			if (xmlNode == null)
			{
				throw new ConfigurationErrorsException(MessageProvider.FormatString(Message.AttributeRequired, new object[]
				{
					"code"
				}), node);
			}
			XmlNode xmlNode2 = node.Attributes["type"];
			XmlNode xmlNode3 = node.Attributes["url"];
			if (xmlNode2 == null && xmlNode3 == null)
			{
				throw new ConfigurationErrorsException(MessageProvider.FormatString(Message.AttributeRequired, new object[]
				{
					"url"
				}), node);
			}
			IRewriteErrorHandler rewriteErrorHandler;
			if (xmlNode2 != null)
			{
				rewriteErrorHandler = (TypeHelper.Activate(xmlNode2.Value, null) as IRewriteErrorHandler);
				if (rewriteErrorHandler == null)
				{
					throw new ConfigurationErrorsException(MessageProvider.FormatString(Message.InvalidTypeSpecified, new object[0]));
				}
			}
			else
			{
				rewriteErrorHandler = new DefaultErrorHandler(xmlNode3.Value);
			}
			config.ErrorHandlers.Add(Convert.ToInt32(xmlNode.Value), rewriteErrorHandler);
		}
		private static void ReadMapping(XmlNode node, RewriterConfiguration config)
		{
			XmlNode xmlNode = node.Attributes["name"];
			StringDictionary stringDictionary = new StringDictionary();
			foreach (XmlNode xmlNode2 in node.ChildNodes)
			{
				if (xmlNode2.NodeType == XmlNodeType.Element)
				{
					if (!(xmlNode2.LocalName == "map"))
					{
						throw new ConfigurationErrorsException(MessageProvider.FormatString(Message.ElementNotAllowed, new object[]
						{
							xmlNode2.LocalName
						}), node);
					}
					XmlNode xmlNode3 = xmlNode2.Attributes["from"];
					if (xmlNode3 == null)
					{
						throw new ConfigurationErrorsException(MessageProvider.FormatString(Message.AttributeRequired, new object[]
						{
							"from"
						}), node);
					}
					XmlNode xmlNode4 = xmlNode2.Attributes["to"];
					if (xmlNode4 == null)
					{
						throw new ConfigurationErrorsException(MessageProvider.FormatString(Message.AttributeRequired, new object[]
						{
							"to"
						}), node);
					}
					stringDictionary.Add(xmlNode3.Value, xmlNode4.Value);
				}
			}
			config.TransformFactory.AddTransform(new StaticMappingTransform(xmlNode.Value, stringDictionary));
		}
		private static void ReadRule(XmlNode node, RewriterConfiguration config)
		{
			bool flag = false;
			IList parsers = config.ActionParserFactory.GetParsers(node.LocalName);
			if (parsers != null)
			{
				foreach (IRewriteActionParser rewriteActionParser in parsers)
				{
					if (!rewriteActionParser.AllowsNestedActions && node.ChildNodes.Count > 0)
					{
						throw new ConfigurationErrorsException(MessageProvider.FormatString(Message.ElementNoElements, new object[]
						{
							rewriteActionParser.Name
						}), node);
					}
					if (!rewriteActionParser.AllowsAttributes && node.Attributes.Count > 0)
					{
						throw new ConfigurationErrorsException(MessageProvider.FormatString(Message.ElementNoAttributes, new object[]
						{
							rewriteActionParser.Name
						}), node);
					}
					IRewriteAction rewriteAction = rewriteActionParser.Parse(node, config);
					if (rewriteAction != null)
					{
						config.Rules.Add(rewriteAction);
						flag = true;
						break;
					}
				}
			}
			if (!flag)
			{
				throw new ConfigurationErrorsException(MessageProvider.FormatString(Message.ElementNotAllowed, new object[]
				{
					node.LocalName
				}), node);
			}
		}
	}
}
