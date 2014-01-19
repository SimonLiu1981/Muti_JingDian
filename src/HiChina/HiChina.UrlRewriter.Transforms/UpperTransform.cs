using System;
using System.Threading;
namespace HiChina.UrlRewriter.Transforms
{
	public sealed class UpperTransform : IRewriteTransform
	{
		public string Name
		{
			get
			{
				return "upper";
			}
		}
		public string ApplyTransform(string input)
		{
			if (input == null)
			{
				throw new ArgumentNullException("input");
			}
			return input.ToUpper(Thread.CurrentThread.CurrentCulture);
		}
	}
}
