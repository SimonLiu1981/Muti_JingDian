using System;
using System.Collections;
using System.Reflection;
using System.Resources;
using System.Threading;
namespace HiChina.UrlRewriter.Utilities
{
	internal sealed class MessageProvider
	{
		private static Hashtable _messageCache = new Hashtable();
		private static ResourceManager _resources = new ResourceManager("HiChina.UrlRewriter.Messages", Assembly.GetExecutingAssembly());
		private MessageProvider()
		{
		}
		public static string FormatString(Message message, params object[] args)
		{
			object syncRoot;
			Monitor.Enter(syncRoot = MessageProvider._messageCache.SyncRoot);
			string text;
			try
			{
				if (MessageProvider._messageCache.ContainsKey(message))
				{
					text = (string)MessageProvider._messageCache[message];
				}
				else
				{
					text = MessageProvider._resources.GetString(message.ToString());
					MessageProvider._messageCache.Add(message, text);
				}
			}
			finally
			{
				Monitor.Exit(syncRoot);
			}
			return string.Format(text, args);
		}
	}
}
