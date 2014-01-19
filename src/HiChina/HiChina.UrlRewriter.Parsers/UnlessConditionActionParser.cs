using System;
namespace HiChina.UrlRewriter.Parsers
{
	public class UnlessConditionActionParser : IfConditionActionParser
	{
		public override string Name
		{
			get
			{
				return "unless";
			}
		}
	}
}
