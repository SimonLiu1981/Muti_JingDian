using HiChina.UrlRewriter.Utilities;
using System;
using System.Collections;
namespace HiChina.UrlRewriter.Configuration
{
	public class ConditionParserPipeline : CollectionBase
	{
		public void AddParser(string parserType)
		{
			this.AddParser((IRewriteConditionParser)TypeHelper.Activate(parserType, null));
		}
		public void AddParser(IRewriteConditionParser parser)
		{
			base.InnerList.Add(parser);
		}
	}
}
