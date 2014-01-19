using System;
using System.Threading;
namespace HiChina.UrlRewriter.Transforms
{
	public sealed class LowerTransform : IRewriteTransform
	{
		public string Name
		{
			get
			{
				return "lower";
			}
		}
		public string ApplyTransform(string input)
		{
			if (input == null)
			{
				throw new ArgumentNullException("input");
			}
			return input.ToLower(Thread.CurrentThread.CurrentCulture);
		}
	}
}
