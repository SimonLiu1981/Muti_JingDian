using System;
using System.Collections.Specialized;
namespace HiChina.UrlRewriter.Transforms
{
	public sealed class StaticMappingTransform : IRewriteTransform
	{
		private string _name;
		private StringDictionary _map;
		public string Name
		{
			get
			{
				return this._name;
			}
		}
		public StaticMappingTransform(string name, StringDictionary map)
		{
			this._name = name;
			this._map = map;
		}
		public string ApplyTransform(string input)
		{
			return this._map[input];
		}
	}
}
