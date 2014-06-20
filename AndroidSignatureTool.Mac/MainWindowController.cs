
using System;
using System.Collections.Generic;
using System.Linq;
using MonoMac.Foundation;
using MonoMac.AppKit;
using System.IO;
using AndroidSignatureTool.Core;

namespace AndroidSignatureTool.Mac
{
	public partial class MainWindowController : MonoMac.AppKit.NSWindowController
	{
		#region Constructors

		// Called when created from unmanaged code
		public MainWindowController (IntPtr handle) : base (handle)
		{
			Initialize ();
		}
		
		// Called when created directly from a XIB file
		[Export ("initWithCoder:")]
		public MainWindowController (NSCoder coder) : base (coder)
		{
			Initialize ();
		}
		
		// Call to load from the XIB/NIB file
		public MainWindowController () : base ("MainWindow")
		{
			Initialize ();
		}
		
		// Shared initialization code
		void Initialize ()
		{
		}

		#endregion

		//strongly typed window accessor
		public new MainWindow Window {
			get {
				return (MainWindow)base.Window;
			}
		}

		Core.Helper helper = new AndroidSignatureTool.Core.Helper ();

		public override void WindowDidLoad ()
		{
			base.WindowDidLoad ();
 			
			textKeytool.StringValue = helper.FindKeytool ();

			buttonKeytool.Activated += (sender, e) => {
				NSOpenPanel panelOpen = new NSOpenPanel();

				var result = panelOpen.RunModal ();

				if (result != 0)
					textKeytool.StringValue = panelOpen.Url.Path.Replace ("keytool", "").TrimEnd ('/');
			};

			buttonOpenKeystore.Activated += (sender, e) => {
				NSOpenPanel panelOpen = new NSOpenPanel();
				panelOpen.Title = "Choose a .keystore file";
				panelOpen.AllowedFileTypes = new string[] { "keystore" };

				var result = panelOpen.RunModal ();

				if (result != 0) {
					textCustomKeystore.StringValue = panelOpen.Url.Path;
				}
			};

			buttonGenerate.Activated += (sender, e) => {

				SignatureInfo sig = null;

				var keytool = helper.FindKeytool ();

				if (string.IsNullOrEmpty (keytool)) {
					ShowAlert ("Unable to locate keytool", "Java Keytool is needed to generate signatures.  We were unable to automatically locate keytool.  Please enter the location manually.");
					return;
				}


				if (radioSource.SelectedRow == 0) {

					try { 
						sig = helper.GetSignaturesFromKeystore ();
					} catch (Exception ex) {
						ShowAlert ("Error Generating Signatures", ex.ToString ());
					}
				
				} else {

					if (!File.Exists (textCustomKeystore.StringValue ?? "")) {
						ShowAlert ("Invalid .Keystore File", "The .keystore file you selected was invalid or not found");
						return;
					}

					var keystore = textCustomKeystore.StringValue;
					var alias = textCustomAlias.StringValue ?? "";
					var storepass = textCustomStorePass.StringValue ?? "";
					var keypass = textCustomKeyPass.StringValue ?? "";

					try {
						sig = helper.GetSignaturesFromKeystore (keytool, keystore, alias, storepass, keypass);
					} catch (Exception ex) {
						ShowAlert ("Error Generating Signatures", ex.ToString ());
					}
				}

				if (sig != null) {
					textMd5.StringValue = sig.MD5;
					textSha1.StringValue = sig.SHA1;
				}
			};

			radioSource.Activated += (sender, e) => {

				var enabled = radioSource.SelectedRow == 1;

				buttonOpenKeystore.Enabled = enabled;
				textCustomAlias.Enabled = enabled;
				textCustomKeyPass.Enabled = enabled;
				textCustomKeystore.Enabled = enabled;
				textCustomStorePass.Enabled = enabled;
			};

			textMd5.Editable = false;
			textSha1.Editable = false;

			buttonCopyMd5.Activated += (sender, e) => {
				NSPasteboard.GeneralPasteboard.SetStringForType (textMd5.StringValue, NSPasteboard.NSStringType);
			};

			buttonCopySha1.Activated += (sender, e) => {
				NSPasteboard.GeneralPasteboard.SetStringForType (textSha1.StringValue, NSPasteboard.NSStringType);
			};
		}

		void ShowAlert (string title, string msg)
		{
			NSAlert alert = new NSAlert ();
			alert.MessageText = title;
			alert.InformativeText = msg;
			alert.AlertStyle = NSAlertStyle.Warning;
			alert.RunModal ();
		}
	}
}

