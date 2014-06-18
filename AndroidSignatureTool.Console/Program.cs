using System;

namespace AndroidSignatureTool.Console
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			AndroidSignatureTool.Core.Helper helper = new AndroidSignatureTool.Core.Helper ();
			var sigs = helper.GetSignaturesFromKeystore ();

			if (sigs != null) {
				System.Console.WriteLine ("MD5:  {0}", sigs.MD5);
				System.Console.WriteLine ("SHA1: {0}", sigs.SHA1);
			}
		}
	}
}
