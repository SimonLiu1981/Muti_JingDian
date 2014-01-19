using HiChina.UrlRewriter.Configuration;
using HiChina.UrlRewriter.Utilities;
using System;
using System.Web;
namespace HiChina.UrlRewriter
{
	public sealed class RewriterHttpModule : IHttpModule
	{
		private static RewriterEngine _rewriter = new RewriterEngine(new HttpContextFacade(), RewriterConfiguration.Current);
		public static RewriterConfiguration Configuration
		{
			get
			{
				return RewriterConfiguration.Current;
			}
		}
		public static string OriginalQueryString
		{
			get
			{
				return RewriterHttpModule._rewriter.OriginalQueryString;
			}
			set
			{
				RewriterHttpModule._rewriter.OriginalQueryString = value;
			}
		}
		public static string QueryString
		{
			get
			{
				return RewriterHttpModule._rewriter.QueryString;
			}
			set
			{
				RewriterHttpModule._rewriter.QueryString = value;
			}
		}
		public static string RawUrl
		{
			get
			{
				return RewriterHttpModule._rewriter.RawUrl;
			}
			set
			{
				RewriterHttpModule._rewriter.RawUrl = value;
			}
		}
		void IHttpModule.Init(HttpApplication context)
		{
			context.BeginRequest += new EventHandler(this.BeginRequest);
		}
		void IHttpModule.Dispose()
		{
		}
		public static string ResolveLocation(string location)
		{
			return RewriterHttpModule._rewriter.ResolveLocation(location);
		}
		private void BeginRequest(object sender, EventArgs e)
		{
			HttpContext.Current.Response.AddHeader("X-Powered-By", RewriterHttpModule.Configuration.XPoweredBy);
			RewriterHttpModule._rewriter.Rewrite();
		}
	}
}
