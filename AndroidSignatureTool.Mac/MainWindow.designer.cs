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
		MonoMac.AppKit.NSButton buttonCopyMd5 { get; set; }

		[Outlet]
		MonoMac.AppKit.NSButton buttonCopySha1 { get; set; }

		[Outlet]
		MonoMac.AppKit.NSButton buttonGenerate { get; set; }

		[Outlet]
		MonoMac.AppKit.NSButton buttonKeytool { get; set; }

		[Outlet]
		MonoMac.AppKit.NSButton buttonOpenKeystore { get; set; }

		[Outlet]
		MonoMac.AppKit.NSMatrix radioSource { get; set; }

		[Outlet]
		MonoMac.AppKit.NSTextField textCustomAlias { get; set; }

		[Outlet]
		MonoMac.AppKit.NSTextField textCustomKeyPass { get; set; }

		[Outlet]
		MonoMac.AppKit.NSTextField textCustomKeystore { get; set; }

		[Outlet]
		MonoMac.AppKit.NSTextField textCustomStorePass { get; set; }

		[Outlet]
		MonoMac.AppKit.NSTextField textKeytool { get; set; }

		[Outlet]
		MonoMac.AppKit.NSTextField textMd5 { get; set; }

		[Outlet]
		MonoMac.AppKit.NSTextField textSha1 { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (buttonOpenKeystore != null) {
				buttonOpenKeystore.Dispose ();
				buttonOpenKeystore = null;
			}

			if (buttonCopyMd5 != null) {
				buttonCopyMd5.Dispose ();
				buttonCopyMd5 = null;
			}

			if (buttonCopySha1 != null) {
				buttonCopySha1.Dispose ();
				buttonCopySha1 = null;
			}

			if (buttonGenerate != null) {
				buttonGenerate.Dispose ();
				buttonGenerate = null;
			}

			if (buttonKeytool != null) {
				buttonKeytool.Dispose ();
				buttonKeytool = null;
			}

			if (radioSource != null) {
				radioSource.Dispose ();
				radioSource = null;
			}

			if (textCustomAlias != null) {
				textCustomAlias.Dispose ();
				textCustomAlias = null;
			}

			if (textCustomKeyPass != null) {
				textCustomKeyPass.Dispose ();
				textCustomKeyPass = null;
			}

			if (textCustomKeystore != null) {
				textCustomKeystore.Dispose ();
				textCustomKeystore = null;
			}

			if (textCustomStorePass != null) {
				textCustomStorePass.Dispose ();
				textCustomStorePass = null;
			}

			if (textKeytool != null) {
				textKeytool.Dispose ();
				textKeytool = null;
			}

			if (textMd5 != null) {
				textMd5.Dispose ();
				textMd5 = null;
			}

			if (textSha1 != null) {
				textSha1.Dispose ();
				textSha1 = null;
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
