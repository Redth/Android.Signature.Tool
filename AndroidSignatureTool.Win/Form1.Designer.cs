namespace AndroidSignatureTool.Win
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textKeytool = new System.Windows.Forms.TextBox();
            this.buttonOpenKeytool = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.radioDefault = new System.Windows.Forms.RadioButton();
            this.radioCustom = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textStorePass = new System.Windows.Forms.TextBox();
            this.buttonOpenKeystore = new System.Windows.Forms.Button();
            this.textKeystore = new System.Windows.Forms.TextBox();
            this.textAlias = new System.Windows.Forms.TextBox();
            this.textKeyPass = new System.Windows.Forms.TextBox();
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textMd5 = new System.Windows.Forms.TextBox();
            this.textSha1 = new System.Windows.Forms.TextBox();
            this.buttonCopyMd5 = new System.Windows.Forms.Button();
            this.buttonSha1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Step 1: Locate Java keytool";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(408, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Use this tool to find the MD5 and SHA1 signatures for your .keystore and/or .apk " +
    "files";
            // 
            // textKeytool
            // 
            this.textKeytool.Location = new System.Drawing.Point(15, 54);
            this.textKeytool.Name = "textKeytool";
            this.textKeytool.Size = new System.Drawing.Size(427, 20);
            this.textKeytool.TabIndex = 2;
            // 
            // buttonOpenKeytool
            // 
            this.buttonOpenKeytool.Location = new System.Drawing.Point(448, 52);
            this.buttonOpenKeytool.Name = "buttonOpenKeytool";
            this.buttonOpenKeytool.Size = new System.Drawing.Size(52, 23);
            this.buttonOpenKeytool.TabIndex = 3;
            this.buttonOpenKeytool.Text = "...";
            this.buttonOpenKeytool.UseVisualStyleBackColor = true;
            this.buttonOpenKeytool.Click += new System.EventHandler(this.buttonOpenKeytool_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(306, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Step 2: Choose a source to generate signatures from";
            // 
            // radioDefault
            // 
            this.radioDefault.AutoSize = true;
            this.radioDefault.Checked = true;
            this.radioDefault.Location = new System.Drawing.Point(15, 108);
            this.radioDefault.Name = "radioDefault";
            this.radioDefault.Size = new System.Drawing.Size(266, 17);
            this.radioDefault.TabIndex = 5;
            this.radioDefault.TabStop = true;
            this.radioDefault.Text = "Default Xamarin.Android generated debug.keystore";
            this.radioDefault.UseVisualStyleBackColor = true;
            // 
            // radioCustom
            // 
            this.radioCustom.AutoSize = true;
            this.radioCustom.Location = new System.Drawing.Point(15, 131);
            this.radioCustom.Name = "radioCustom";
            this.radioCustom.Size = new System.Drawing.Size(248, 17);
            this.radioCustom.TabIndex = 6;
            this.radioCustom.Text = "Choose your own custom created .keystore file:";
            this.radioCustom.UseVisualStyleBackColor = true;
            this.radioCustom.CheckedChanged += new System.EventHandler(this.radioCustom_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Keystore File:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Alias:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 216);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Store Password:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 242);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Key Password:";
            // 
            // textStorePass
            // 
            this.textStorePass.Enabled = false;
            this.textStorePass.Location = new System.Drawing.Point(121, 213);
            this.textStorePass.Name = "textStorePass";
            this.textStorePass.Size = new System.Drawing.Size(321, 20);
            this.textStorePass.TabIndex = 11;
            // 
            // buttonOpenKeystore
            // 
            this.buttonOpenKeystore.Enabled = false;
            this.buttonOpenKeystore.Location = new System.Drawing.Point(448, 159);
            this.buttonOpenKeystore.Name = "buttonOpenKeystore";
            this.buttonOpenKeystore.Size = new System.Drawing.Size(52, 23);
            this.buttonOpenKeystore.TabIndex = 12;
            this.buttonOpenKeystore.Text = "...";
            this.buttonOpenKeystore.UseVisualStyleBackColor = true;
            this.buttonOpenKeystore.Click += new System.EventHandler(this.buttonOpenKeystore_Click);
            // 
            // textKeystore
            // 
            this.textKeystore.Enabled = false;
            this.textKeystore.Location = new System.Drawing.Point(121, 161);
            this.textKeystore.Name = "textKeystore";
            this.textKeystore.Size = new System.Drawing.Size(321, 20);
            this.textKeystore.TabIndex = 13;
            // 
            // textAlias
            // 
            this.textAlias.Enabled = false;
            this.textAlias.Location = new System.Drawing.Point(121, 187);
            this.textAlias.Name = "textAlias";
            this.textAlias.Size = new System.Drawing.Size(321, 20);
            this.textAlias.TabIndex = 14;
            // 
            // textKeyPass
            // 
            this.textKeyPass.Enabled = false;
            this.textKeyPass.Location = new System.Drawing.Point(121, 239);
            this.textKeyPass.Name = "textKeyPass";
            this.textKeyPass.Size = new System.Drawing.Size(321, 20);
            this.textKeyPass.TabIndex = 15;
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.Location = new System.Drawing.Point(171, 283);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(178, 23);
            this.buttonGenerate.TabIndex = 16;
            this.buttonGenerate.Text = "Generate Signatures";
            this.buttonGenerate.UseVisualStyleBackColor = true;
            this.buttonGenerate.Click += new System.EventHandler(this.buttonGenerate_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 327);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(197, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Step 3: Here are your Signatures:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(31, 354);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "MD5 Signature:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(31, 380);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "SHA1 Signature:";
            // 
            // textMd5
            // 
            this.textMd5.Location = new System.Drawing.Point(121, 351);
            this.textMd5.Name = "textMd5";
            this.textMd5.ReadOnly = true;
            this.textMd5.Size = new System.Drawing.Size(321, 20);
            this.textMd5.TabIndex = 20;
            // 
            // textSha1
            // 
            this.textSha1.Location = new System.Drawing.Point(121, 377);
            this.textSha1.Name = "textSha1";
            this.textSha1.ReadOnly = true;
            this.textSha1.Size = new System.Drawing.Size(321, 20);
            this.textSha1.TabIndex = 21;
            // 
            // buttonCopyMd5
            // 
            this.buttonCopyMd5.Location = new System.Drawing.Point(448, 349);
            this.buttonCopyMd5.Name = "buttonCopyMd5";
            this.buttonCopyMd5.Size = new System.Drawing.Size(52, 23);
            this.buttonCopyMd5.TabIndex = 22;
            this.buttonCopyMd5.Text = "Copy";
            this.buttonCopyMd5.UseVisualStyleBackColor = true;
            this.buttonCopyMd5.Click += new System.EventHandler(this.buttonCopyMd5_Click);
            // 
            // buttonSha1
            // 
            this.buttonSha1.Location = new System.Drawing.Point(448, 375);
            this.buttonSha1.Name = "buttonSha1";
            this.buttonSha1.Size = new System.Drawing.Size(52, 23);
            this.buttonSha1.TabIndex = 23;
            this.buttonSha1.Text = "Copy";
            this.buttonSha1.UseVisualStyleBackColor = true;
            this.buttonSha1.Click += new System.EventHandler(this.buttonSha1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 421);
            this.Controls.Add(this.buttonSha1);
            this.Controls.Add(this.buttonCopyMd5);
            this.Controls.Add(this.textSha1);
            this.Controls.Add(this.textMd5);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.buttonGenerate);
            this.Controls.Add(this.textKeyPass);
            this.Controls.Add(this.textAlias);
            this.Controls.Add(this.textKeystore);
            this.Controls.Add(this.buttonOpenKeystore);
            this.Controls.Add(this.textStorePass);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.radioCustom);
            this.Controls.Add(this.radioDefault);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonOpenKeytool);
            this.Controls.Add(this.textKeytool);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Android Signature Tool";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textKeytool;
        private System.Windows.Forms.Button buttonOpenKeytool;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioDefault;
        private System.Windows.Forms.RadioButton radioCustom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textStorePass;
        private System.Windows.Forms.Button buttonOpenKeystore;
        private System.Windows.Forms.TextBox textKeystore;
        private System.Windows.Forms.TextBox textAlias;
        private System.Windows.Forms.TextBox textKeyPass;
        private System.Windows.Forms.Button buttonGenerate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textMd5;
        private System.Windows.Forms.TextBox textSha1;
        private System.Windows.Forms.Button buttonCopyMd5;
        private System.Windows.Forms.Button buttonSha1;
    }
}

