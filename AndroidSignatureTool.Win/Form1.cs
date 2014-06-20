using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AndroidSignatureTool.Win
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        AndroidSignatureTool.Core.Helper helper = new Core.Helper();

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonOpenKeytool_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog();
            ofd.Title = "Browse to Keytool.exe";
            ofd.Filter = "Keytool.exe|keytool.exe";
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                textKeytool.Text = ofd.FileName;
            }
        }

        private void buttonOpenKeystore_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog();
            ofd.Title = "Open .keystore file";
            ofd.FileName = ".keystore|*.keystore";
            if (ofd.ShowDialog () == System.Windows.Forms.DialogResult.OK)
            {
                textKeystore.Text = ofd.FileName;
            }
        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            var keytool = textKeytool.Text;
            if (string.IsNullOrEmpty(keytool))
            {
                ShowMsg("Unable to locate keytool.exe", "Java's keystore.exe utility is required to generate signatures.  Please manually locate keytool.exe.");
                return;
            }

            AndroidSignatureTool.Core.SignatureInfo sig = null;

            if (radioDefault.Checked)
            {
                try { sig = helper.GetSignaturesFromKeystore(keytool); }
                catch (Exception ex)
                {
                    ShowMsg("Failed To Generate Signature", ex.ToString());
                    return;
                }
            }
            else
            {
                var keystore = textKeystore.Text;

                if (!System.IO.File.Exists (keystore))
                {
                    ShowMsg ("Cannot find Keystore", "Please enter a valid path to your custom .keystore file");
                    return;
                }

                var alias = textAlias.Text;
                var storepass = textStorePass.Text;
                var keypass = textKeyPass.Text;

                try { sig = helper.GetSignaturesFromKeystore (keytool, keystore, alias, storepass, keypass); }
                catch (Exception ex)
                {
                    ShowMsg ("Failed to Generate Signatures", ex.ToString());
                }
            }

            if (sig != null)
            {
                textMd5.Text = sig.MD5;
                textSha1.Text = sig.SHA1;
            }
        }

        private void buttonCopyMd5_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textMd5.Text);
        }

        private void buttonSha1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textSha1.Text);
        }

        void ShowMsg (string title, string msg)
        {
            MessageBox.Show(this, msg, title);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textKeytool.Text = helper.FindKeytool();
        }

        private void radioCustom_CheckedChanged(object sender, EventArgs e)
        {
            var enabled = radioCustom.Checked;

            textAlias.Enabled = enabled;
            textKeystore.Enabled = enabled;
            textKeyPass.Enabled = enabled;
            textStorePass.Enabled = enabled;
            buttonOpenKeystore.Enabled = enabled;
        }
    }
}
