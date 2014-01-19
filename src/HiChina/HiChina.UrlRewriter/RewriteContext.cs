using HiChina.UrlRewriter.Utilities;
using System;
using System.Collections.Specialized;
using System.Net;
using System.Text.RegularExpressions;
using System.Web;
namespace HiChina.UrlRewriter
{
	public sealed class RewriteContext
	{
		private RewriterEngine _engine;
		private string _method = string.Empty;
		private HttpStatusCode _statusCode = HttpStatusCode.OK;
		private string _location;
		private NameValueCollection _properties = new NameValueCollection();
		private NameValueCollection _headers = new NameValueCollection();
		private HttpCookieCollection _cookies = new HttpCookieCollection();
		private Match _lastMatch;
		private MapPath _mapPath;
		public string Location
		{
			get
			{
				return this._location;
			}
			set
			{
				this._location = value;
			}
		}
		public string Method
		{
			get
			{
				return this._method;
			}
		}
		public NameValueCollection Properties
		{
			get
			{
				return this._properties;
			}
		}
		public NameValueCollection Headers
		{
			get
			{
				return this._headers;
			}
		}
		public HttpStatusCode StatusCode
		{
			get
			{
				return this._statusCode;
			}
			set
			{
				this._statusCode = value;
			}
		}
		public HttpCookieCollection Cookies
		{
			get
			{
				return this._cookies;
			}
		}
		public Match LastMatch
		{
			get
			{
				return this._lastMatch;
			}
			set
			{
				this._lastMatch = value;
			}
		}
		internal RewriteContext(RewriterEngine engine, string rawUrl, string httpMethod, MapPath mapPath, NameValueCollection serverVariables, NameValueCollection headers, HttpCookieCollection cookies)
		{
			this._engine = engine;
			this._location = rawUrl;
			this._method = httpMethod;
			this._mapPath = mapPath;
			foreach (string name in serverVariables)
			{
				this._properties.Add(name, serverVariables[name]);
			}
			foreach (string name2 in headers)
			{
				this._properties.Add(name2, headers[name2]);
			}
			foreach (string name3 in cookies)
			{
				this._properties.Add(name3, cookies[name3].Value);
			}
		}
		public string MapPath(string url)
		{
			return this._mapPath(url);
		}
		public string Expand(string input)
		{
			return this._engine.Expand(this, input);
		}
		public string ResolveLocation(string location)
		{
			return this._engine.ResolveLocation(location);
		}
	}
}
