using System;
namespace HiChina.UrlRewriter.Actions
{
	public class AddHeaderAction : IRewriteAction
	{
		private string _header;
		private string _value;
		public string Header
		{
			get
			{
				return this._header;
			}
		}
		public string Value
		{
			get
			{
				return this._value;
			}
		}
		public AddHeaderAction(string header, string value)
		{
			if (header == null)
			{
				throw new ArgumentNullException("header");
			}
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			this._header = header;
			this._value = value;
		}
		public RewriteProcessing Execute(RewriteContext context)
		{
			if (context == null)
			{
				throw new ArgumentNullException("context");
			}
			context.Headers.Add(this.Header, this.Value);
			return RewriteProcessing.ContinueProcessing;
		}
	}
}
