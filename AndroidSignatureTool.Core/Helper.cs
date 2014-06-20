using System;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;
using Xamarin.AndroidTools.Sdks;

namespace AndroidSignatureTool.Core
{
	public class Helper
	{
		public Helper ()
		{
		}

		string FindKeytoolMac ()
		{
			// This is where VM's are stored...
			var java = "/System/Library/Java/JavaVirtualMachines/";

			var keytool = string.Empty;
			if (Directory.Exists (java)) {
				foreach (var dir in Directory.GetDirectories (java)) {

					var kt = Path.Combine (dir, "Contents/Home/bin/keytool");
					if (File.Exists (kt)) {
						keytool = kt;
					}
				}
			}

			if (string.IsNullOrEmpty (keytool)) {
				keytool = "/usr/bin/keytool";

				if (!File.Exists (keytool))
					keytool = string.Empty;
			}
			return keytool;
		}

		string FindKeytoolWin ()
		{
			string javahome = string.Empty;
			string subkey = @"SOFTWARE\JavaSoft\Java Development Kit";

			foreach (var wow64 in new[] { RegistryEx.Wow64.Key32, RegistryEx.Wow64.Key64 }) {
				//string key_name = string.Format (@"{0}\{1}\{2}", "HKLM", subkey, "CurrentVersion");
				var currentVersion = RegistryEx.GetValueString (RegistryEx.LocalMachine, subkey, "CurrentVersion", wow64);

				if (!string.IsNullOrEmpty (currentVersion)) {

					// No matter what the CurrentVersion is, look for 1.6 or 1.7
					if (CheckRegistryKeyForExecutable (RegistryEx.LocalMachine, subkey + "\\" + "1.6", "JavaHome", wow64, "bin", "keytool.exe"))
						javahome = RegistryEx.GetValueString (RegistryEx.LocalMachine, subkey + "\\" + "1.6", "JavaHome", wow64);

					if (CheckRegistryKeyForExecutable (RegistryEx.LocalMachine, subkey + "\\" + "1.7", "JavaHome", wow64, "bin", "keytool.exe"))
						javahome = RegistryEx.GetValueString (RegistryEx.LocalMachine, subkey + "\\" + "1.7", "JavaHome", wow64);
				}
			}

			if (!string.IsNullOrEmpty (javahome)) {

				var keytool = Path.Combine (javahome, "bin", "keytool.exe");

				if (File.Exists (keytool))
					return keytool;
			}

			// We ran out of things to check..
			return string.Empty;
		}

		public string FindKeytool ()
		{
			if (PlatformDetection.IsMac)
				return FindKeytoolMac ();
		
			return FindKeytoolWin ();		
		}


		string FindDebugKeystoreMac ()
		{
			var path = Path.Combine (Environment.GetFolderPath (Environment.SpecialFolder.UserProfile), ".local/share/Xamarin/Mono for Android/debug.keystore");
			return path;
		}

		string FindDebugKeystoreWin ()
		{
			var path = Path.Combine (Environment.GetFolderPath (Environment.SpecialFolder.UserProfile), @"AppData\Local\Xamarin\Mono for Android\debug.keystore");
			return path;
		}

		public string FindDebugKeystore ()
		{
			if (PlatformDetection.IsMac)
				return FindDebugKeystoreMac ();

			return FindDebugKeystoreWin ();		
		}

		public SignatureInfo GetSignaturesFromKeystore (string keytool = null, string keystore = null, string alias = null, string storepass = null, string keypass = null)
		{
			if (string.IsNullOrEmpty (keystore))
				keystore = FindDebugKeystore ();

			if (string.IsNullOrEmpty (keytool))
				keytool = FindKeytool ();

			if (string.IsNullOrEmpty (alias))
				alias = "androiddebugkey";
			if (string.IsNullOrEmpty (storepass))
				storepass = "android";
			if (string.IsNullOrEmpty (keypass))
				keypass = "android";

			var sbOut = new StringBuilder ();

			var p = new System.Diagnostics.Process ();
			p.StartInfo = new System.Diagnostics.ProcessStartInfo (keytool, string.Format ("-list -v -keystore \"{0}\" -alias {1} -storepass {2} -keypass {3}", keystore, alias, storepass, keypass));
			p.StartInfo.UseShellExecute = false;
			p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.CreateNoWindow = true;
			p.OutputDataReceived += (sender, e) => {
				sbOut.Append (e.Data);
			};

			p.Start ();
			p.BeginOutputReadLine ();
			p.WaitForExit ();

			var sig = GetSignatures (sbOut.ToString ());

			Console.WriteLine (sbOut);

			return sig;
		}

		public SignatureInfo GetSignaturesFromApk (string apkFile)
		{
			return null;
		}

		SignatureInfo GetSignatures(string output)
		{
			var rxMd5 = "MD5:\\s+(?<sig>[A-Za-z0-9:]+)";
			var rxSha1 = "SHA1:\\s+(?<sig>[A-Za-z0-9:]+)";

			var md5 = Regex.Match (output, rxMd5, RegexOptions.Singleline | RegexOptions.IgnoreCase);
			var sha1 = Regex.Match (output, rxSha1, RegexOptions.Singleline | RegexOptions.IgnoreCase);

			var md5sig = string.Empty;
			var sha1sig = string.Empty;

			if (md5 != null && md5.Success) {
				if (md5.Groups ["sig"] != null && md5.Groups ["sig"] != null && md5.Groups ["sig"].Success)
					md5sig = md5.Groups ["sig"].Value;
			}

			if (sha1 != null && sha1.Success) {
				if (sha1.Groups ["sig"] != null && sha1.Groups ["sig"] != null && sha1.Groups ["sig"].Success)
					sha1sig = sha1.Groups ["sig"].Value;
			}

			if (!string.IsNullOrEmpty (md5sig) && !string.IsNullOrEmpty (sha1sig))
				return new SignatureInfo { MD5 = md5sig, SHA1 = sha1sig };

			throw new Exception ("Failed to get Signatures using Keytool: " + output);
		}

		private bool CheckRegistryKeyForExecutable (UIntPtr key, string subkey, string valueName, RegistryEx.Wow64 wow64, string subdir, string exe)
		{
			string key_name = string.Format (@"{0}\{1}\{2}", key == RegistryEx.CurrentUser ? "HKCU" : "HKLM", subkey, valueName);

			var path = RegistryEx.GetValueString (key, subkey, valueName, wow64);
			if (string.IsNullOrEmpty (path))
				path = null;

			if (path == null) {
				return false;
			}

			if (!File.Exists (Path.Combine (path, subdir, exe))) {
				return false;
			}

			return true;
		}
	}

	public class SignatureInfo
	{
		public string MD5 { get;set; }
		public string SHA1 { get;set; }
	}
}

