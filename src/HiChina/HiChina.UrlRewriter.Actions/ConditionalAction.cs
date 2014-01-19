using System;
using System.Collections;
namespace HiChina.UrlRewriter.Actions
{
	public class ConditionalAction : IRewriteAction, IRewriteCondition
	{
		private ArrayList _actions = new ArrayList();
		private ArrayList _conditions = new ArrayList();
		public IList Conditions
		{
			get
			{
				return this._conditions;
			}
		}
		public IList Actions
		{
			get
			{
				return this._actions;
			}
		}
		public virtual bool IsMatch(RewriteContext context)
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
		public virtual RewriteProcessing Execute(RewriteContext context)
		{
			for (int i = 0; i < this.Actions.Count; i++)
			{
				IRewriteCondition rewriteCondition = this.Actions[i] as IRewriteCondition;
				if (rewriteCondition == null || rewriteCondition.IsMatch(context))
				{
					IRewriteAction rewriteAction = this.Actions[i] as IRewriteAction;
					RewriteProcessing rewriteProcessing = rewriteAction.Execute(context);
					if (rewriteProcessing != RewriteProcessing.ContinueProcessing)
					{
						return rewriteProcessing;
					}
				}
			}
			return RewriteProcessing.ContinueProcessing;
		}
	}
}
