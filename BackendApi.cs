using System;
using System.Runtime.InteropServices;

namespace WPFSample
{
#pragma warning disable CS0618 // Type or member is obsolete
	[ClassInterface(ClassInterfaceType.AutoDual)]
#pragma warning restore CS0618 // Type or member is obsolete
	[ComVisible(true)]
	public class BackendApi
	{
		public string Callback(string itemId)
		{
			Console.WriteLine(itemId);
			return itemId;
		}
	}
}
