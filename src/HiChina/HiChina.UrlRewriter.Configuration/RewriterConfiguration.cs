using HiChina.UrlRewriter.Logging;
using HiChina.UrlRewriter.Parsers;
using HiChina.UrlRewriter.Transforms;
using HiChina.UrlRewriter.Utilities;
using System;
using System.Collections;
using System.Collections.Specialized;
using System.Configuration;
using System.IO;
using System.Reflection;
using System.Threading;
using System.Web;
using System.Web.Caching;
using System.Xml;
namespace HiChina.UrlRewriter.Configuration
{
	public class RewriterConfiguration
	{
		private static object SyncObject = new object();
		private IRewriteLogger _logger = new NullLogger();
		private Hashtable _errorHandlers = new Hashtable();
		private ArrayList _rules = new ArrayList();
		private ActionParserFactory _actionParserFactory;
		private ConditionParserPipeline _conditionParserPipeline;
		private TransformFactory _transformFactory;
		private StringCollection _defaultDocuments;
		private string _xPoweredBy;
		private static string _cacheName = typeof(RewriterConfiguration).AssemblyQualifiedName;
		public IList Rules
		{
			get
			{
				return this._rules;
			}
		}
		public ActionParserFactory ActionParserFactory
		{
			get
			{
				return this._actionParserFactory;
			}
		}
		public TransformFactory TransformFactory
		{
			get
			{
				return this._transformFactory;
			}
		}
		public ConditionParserPipeline ConditionParserPipeline
		{
			get
			{
				return this._conditionParserPipeline;
			}
		}
		public IDictionary ErrorHandlers
		{
			get
			{
				return this._errorHandlers;
			}
		}
		public IRewriteLogger Logger
		{
			get
			{
				return this._logger;
			}
			set
			{
				this._logger = value;
			}
		}
		public StringCollection DefaultDocuments
		{
			get
			{
				return this._defaultDocuments;
			}
		}
		internal string XPoweredBy
		{
			get
			{
				return this._xPoweredBy;
			}
		}
		public static RewriterConfiguration Current
		{
			get
			{
				RewriterConfiguration rewriterConfiguration = HttpRuntime.Cache.Get(RewriterConfiguration._cacheName) as RewriterConfiguration;
				if (rewriterConfiguration == null)
				{
					object syncObject;
					Monitor.Enter(syncObject = RewriterConfiguration.SyncObject);
					try
					{
						rewriterConfiguration = (HttpRuntime.Cache.Get(RewriterConfiguration._cacheName) as RewriterConfiguration);
						if (rewriterConfiguration == null)
						{
							rewriterConfiguration = RewriterConfiguration.Load();
						}
					}
					finally
					{
						Monitor.Exit(syncObject);
					}
				}
				return rewriterConfiguration;
			}
		}
		internal RewriterConfiguration()
		{
			this._xPoweredBy = MessageProvider.FormatString(Message.ProductName, new object[]
			{
				Assembly.GetExecutingAssembly().GetName().Version.ToString(3)
			});
			this._actionParserFactory = new ActionParserFactory();
			this._actionParserFactory.AddParser(new IfConditionActionParser());
			this._actionParserFactory.AddParser(new UnlessConditionActionParser());
			this._actionParserFactory.AddParser(new AddHeaderActionParser());
			this._actionParserFactory.AddParser(new SetCookieActionParser());
			this._actionParserFactory.AddParser(new SetPropertyActionParser());
			this._actionParserFactory.AddParser(new RewriteActionParser());
			this._actionParserFactory.AddParser(new RedirectActionParser());
			this._actionParserFactory.AddParser(new SetStatusActionParser());
			this._actionParserFactory.AddParser(new ForbiddenActionParser());
			this._actionParserFactory.AddParser(new GoneActionParser());
			this._actionParserFactory.AddParser(new NotAllowedActionParser());
			this._actionParserFactory.AddParser(new NotFoundActionParser());
			this._actionParserFactory.AddParser(new NotImplementedActionParser());
			this._conditionParserPipeline = new ConditionParserPipeline();
			this._conditionParserPipeline.AddParser(new AddressConditionParser());
			this._conditionParserPipeline.AddParser(new HeaderMatchConditionParser());
			this._conditionParserPipeline.AddParser(new MethodConditionParser());
			this._conditionParserPipeline.AddParser(new PropertyMatchConditionParser());
			this._conditionParserPipeline.AddParser(new ExistsConditionParser());
			this._conditionParserPipeline.AddParser(new UrlMatchConditionParser());
			this._transformFactory = new TransformFactory();
			this._transformFactory.AddTransform(new DecodeTransform());
			this._transformFactory.AddTransform(new EncodeTransform());
			this._transformFactory.AddTransform(new LowerTransform());
			this._transformFactory.AddTransform(new UpperTransform());
			this._transformFactory.AddTransform(new Base64Transform());
			this._transformFactory.AddTransform(new Base64DecodeTransform());
			this._defaultDocuments = new StringCollection();
		}
		public static RewriterConfiguration Create()
		{
			return new RewriterConfiguration();
		}
		public static RewriterConfiguration Load()
		{
			XmlNode xmlNode = ConfigurationManager.GetSection("rewriter") as XmlNode;
			RewriterConfiguration rewriterConfiguration = null;
			XmlNode namedItem = xmlNode.Attributes.GetNamedItem("file");
			if (namedItem != null)
			{
				string filename = HttpContext.Current.Server.MapPath(namedItem.Value);
				rewriterConfiguration = RewriterConfiguration.LoadFromFile(filename);
				if (rewriterConfiguration != null)
				{
					CacheDependency dependencies = new CacheDependency(filename);
					HttpRuntime.Cache.Add(RewriterConfiguration._cacheName, rewriterConfiguration, dependencies, DateTime.Now.AddHours(1.0), TimeSpan.Zero, CacheItemPriority.Normal, null);
				}
			}
			if (rewriterConfiguration == null)
			{
				rewriterConfiguration = RewriterConfiguration.LoadFromNode(xmlNode);
				HttpRuntime.Cache.Add(RewriterConfiguration._cacheName, rewriterConfiguration, null, DateTime.Now.AddHours(1.0), TimeSpan.Zero, CacheItemPriority.Normal, null);
			}
			return rewriterConfiguration;
		}
		public static RewriterConfiguration LoadFromFile(string filename)
		{
			if (File.Exists(filename))
			{
				XmlDocument xmlDocument = new XmlDocument();
				xmlDocument.Load(filename);
				return RewriterConfiguration.LoadFromNode(xmlDocument.DocumentElement);
			}
			return null;
		}
		public static RewriterConfiguration LoadFromNode(XmlNode node)
		{
			return (RewriterConfiguration)RewriterConfigurationReader.Read(node);
		}
	}
}
