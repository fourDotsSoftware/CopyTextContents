namespace CopyTextContents
{
    partial class frmSettings
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.chkCopyTextContents = new System.Windows.Forms.CheckBox();
            this.chkCopyTextContentsEncoding = new System.Windows.Forms.CheckBox();
            this.chkSubFolders = new System.Windows.Forms.CheckBox();
            this.chkHeader = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(199, 345);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(119, 30);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(61, 345);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(119, 30);
            this.btnOK.TabIndex = 5;
            this.btnOK.Text = "&OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // chkCopyTextContents
            // 
            this.chkCopyTextContents.AutoSize = true;
            this.chkCopyTextContents.BackColor = System.Drawing.Color.Transparent;
            this.chkCopyTextContents.Location = new System.Drawing.Point(33, 101);
            this.chkCopyTextContents.Name = "chkCopyTextContents";
            this.chkCopyTextContents.Size = new System.Drawing.Size(119, 17);
            this.chkCopyTextContents.TabIndex = 8;
            this.chkCopyTextContents.Text = "Copy Text Contents";
            this.chkCopyTextContents.UseVisualStyleBackColor = false;
            // 
            // chkCopyTextContentsEncoding
            // 
            this.chkCopyTextContentsEncoding.AutoSize = true;
            this.chkCopyTextContentsEncoding.BackColor = System.Drawing.Color.Transparent;
            this.chkCopyTextContentsEncoding.Location = new System.Drawing.Point(33, 134);
            this.chkCopyTextContentsEncoding.Name = "chkCopyTextContentsEncoding";
            this.chkCopyTextContentsEncoding.Size = new System.Drawing.Size(189, 17);
            this.chkCopyTextContentsEncoding.TabIndex = 9;
            this.chkCopyTextContentsEncoding.Text = "Copy Text Contents with Encoding";
            this.chkCopyTextContentsEncoding.UseVisualStyleBackColor = false;
            // 
            // chkSubFolders
            // 
            this.chkSubFolders.AutoSize = true;
            this.chkSubFolders.BackColor = System.Drawing.Color.Transparent;
            this.chkSubFolders.Location = new System.Drawing.Point(33, 260);
            this.chkSubFolders.Name = "chkSubFolders";
            this.chkSubFolders.Size = new System.Drawing.Size(343, 17);
            this.chkSubFolders.TabIndex = 10;
            this.chkSubFolders.Text = "Copy also Text Contents of Subfolder Files when selecting a Folder.";
            this.chkSubFolders.UseVisualStyleBackColor = false;
            // 
            // chkHeader
            // 
            this.chkHeader.AutoSize = true;
            this.chkHeader.BackColor = System.Drawing.Color.Transparent;
            this.chkHeader.Location = new System.Drawing.Point(33, 228);
            this.chkHeader.Name = "chkHeader";
            this.chkHeader.Size = new System.Drawing.Size(299, 17);
            this.chkHeader.TabIndex = 11;
            this.chkHeader.Text = "Add a File Header when copying Contents of multiple Files";
            this.chkHeader.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(382, 67);
            this.label2.TabIndex = 12;
            this.label2.Text = "Please specify which Menu Items will be visible in the Windows Explorer Right Cli" +
                "ck Menu.\r\n\r\nTo change the Settings again, run the CopyTextContents application.";
            // 
            // frmSettings
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(398, 399);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chkHeader);
            this.Controls.Add(this.chkSubFolders);
            this.Controls.Add(this.chkCopyTextContentsEncoding);
            this.Controls.Add(this.chkCopyTextContents);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSettings";
            this.Text = "Copy Text Contents - Settings";
            this.Load += new System.EventHandler(this.frmSettings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.CheckBox chkCopyTextContents;
        private System.Windows.Forms.CheckBox chkCopyTextContentsEncoding;
        private System.Windows.Forms.CheckBox chkSubFolders;
        private System.Windows.Forms.CheckBox chkHeader;
        private System.Windows.Forms.Label label2;
    }
}
