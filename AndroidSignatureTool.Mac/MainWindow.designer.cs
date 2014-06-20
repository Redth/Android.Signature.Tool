// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoMac.Foundation;
using System.CodeDom.Compiler;

namespace AndroidSignatureTool.Mac
{
	[Register ("MainWindowController")]
	partial class MainWindowController
	{
		[Outlet]
		MonoMac.AppKit.NSButton buttonApk { get; set; }

		[Outlet]
		MonoMac.AppKit.NSButton buttonCopyMd5 { get; set; }

		[Outlet]
		MonoMac.AppKit.NSButton buttonCopySha1 { get; set; }

		[Outlet]
		MonoMac.AppKit.NSButton buttonCustomKeystore { get; set; }

		[Outlet]
		MonoMac.AppKit.NSButton buttonKeystore { get; set; }

		[Outlet]
		MonoMac.AppKit.NSButton buttonKeytool { get; set; }

		[Outlet]
		MonoMac.AppKit.NSTextField textKeytool { get; set; }

		[Outlet]
		MonoMac.AppKit.NSTextField textMd5 { get; set; }

		[Outlet]
		MonoMac.AppKit.NSTextField textSha1 { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (textKeytool != null) {
				textKeytool.Dispose ();
				textKeytool = null;
			}

			if (buttonKeytool != null) {
				buttonKeytool.Dispose ();
				buttonKeytool = null;
			}

			if (buttonKeystore != null) {
				buttonKeystore.Dispose ();
				buttonKeystore = null;
			}

			if (buttonApk != null) {
				buttonApk.Dispose ();
				buttonApk = null;
			}

			if (buttonCustomKeystore != null) {
				buttonCustomKeystore.Dispose ();
				buttonCustomKeystore = null;
			}

			if (textMd5 != null) {
				textMd5.Dispose ();
				textMd5 = null;
			}

			if (buttonCopyMd5 != null) {
				buttonCopyMd5.Dispose ();
				buttonCopyMd5 = null;
			}

			if (textSha1 != null) {
				textSha1.Dispose ();
				textSha1 = null;
			}

			if (buttonCopySha1 != null) {
				buttonCopySha1.Dispose ();
				buttonCopySha1 = null;
			}
		}
	}

	[Register ("MainWindow")]
	partial class MainWindow
	{
		
		void ReleaseDesignerOutlets ()
		{
		}
	}
}
