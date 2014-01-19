using System;
using System.Collections;
namespace HiChina.UrlRewriter.Actions
{
	public sealed class RewriteAction : SetLocationAction, IRewriteCondition
	{
		private ArrayList _conditions = new ArrayList();
		private RewriteProcessing _processing;
		public IList Conditions
		{
			get
			{
				return this._conditions;
			}
		}
		public RewriteAction(string location, RewriteProcessing processing) : base(location)
		{
			this._processing = processing;
		}
		public override RewriteProcessing Execute(RewriteContext context)
		{
			base.Execute(context);
			return this._processing;
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
