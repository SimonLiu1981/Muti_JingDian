using System;
using System.Collections;
using System.Net;
namespace HiChina.UrlRewriter.Actions
{
	public sealed class RedirectAction : SetLocationAction, IRewriteCondition
	{
		private ArrayList _conditions = new ArrayList();
		private bool _permanent;
		public IList Conditions
		{
			get
			{
				return this._conditions;
			}
		}
		public RedirectAction(string location, bool permanent) : base(location)
		{
			if (location == null)
			{
				throw new ArgumentNullException("location");
			}
			this._permanent = permanent;
		}
		public override RewriteProcessing Execute(RewriteContext context)
		{
			if (context == null)
			{
				throw new ArgumentNullException("context");
			}
			base.Execute(context);
			if (this._permanent)
			{
				context.StatusCode = HttpStatusCode.MovedPermanently;
			}
			else
			{
				context.StatusCode = HttpStatusCode.Found;
			}
			return RewriteProcessing.StopProcessing;
		}
		public bool IsMatch(RewriteContext context)
		{
			foreach (IRewriteCondition rewriteCondition in this.Conditions)
			{
				if (!rewriteCondition.IsMatch(context))
				{
					return false;
				}
			}
			return true;
		}
	}
}
