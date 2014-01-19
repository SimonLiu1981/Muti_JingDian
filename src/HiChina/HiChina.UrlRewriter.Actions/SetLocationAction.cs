using System;
namespace HiChina.UrlRewriter.Actions
{
	public abstract class SetLocationAction : IRewriteAction
	{
		private string _location;
		public string Location
		{
			get
			{
				return this._location;
			}
		}
		protected SetLocationAction(string location)
		{
			if (location == null)
			{
				throw new ArgumentNullException("location");
			}
			this._location = location;
		}
		public virtual RewriteProcessing Execute(RewriteContext context)
		{
			if (context == null)
			{
				throw new ArgumentNullException("context");
			}
			context.Location = context.ResolveLocation(context.Expand(this.Location));
			return RewriteProcessing.StopProcessing;
		}
	}
}
