namespace SuperSecretary.WinForms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSettings));
            this.txtLogFilePath = new System.Windows.Forms.TextBox();
            this.lblLogFolder = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnApply = new System.Windows.Forms.Button();
            this.gpbLogging = new System.Windows.Forms.GroupBox();
            this.btnChangeLogFolder = new System.Windows.Forms.Button();
            this.chkEnableLogging = new System.Windows.Forms.CheckBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.grpDateFormat = new System.Windows.Forms.GroupBox();
            this.lblDateFormattingHelp = new System.Windows.Forms.Label();
            this.txtDateFormatString = new System.Windows.Forms.TextBox();
            this.gpbLogging.SuspendLayout();
            this.grpDateFormat.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtLogFilePath
            // 
            this.txtLogFilePath.Location = new System.Drawing.Point(6, 56);
            this.txtLogFilePath.Name = "txtLogFilePath";
            this.txtLogFilePath.Size = new System.Drawing.Size(323, 20);
            this.txtLogFilePath.TabIndex = 2;
            // 
            // lblLogFolder
            // 
            this.lblLogFolder.AutoSize = true;
            this.lblLogFolder.Location = new System.Drawing.Point(6, 40);
            this.lblLogFolder.Name = "lblLogFolder";
            this.lblLogFolder.Size = new System.Drawing.Size(60, 13);
            this.lblLogFolder.TabIndex = 5;
            this.lblLogFolder.Text = "Log Folder:";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(272, 243);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 6;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(191, 243);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(75, 23);
            this.btnApply.TabIndex = 7;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // gpbLogging
            // 
            this.gpbLogging.Controls.Add(this.btnChangeLogFolder);
            this.gpbLogging.Controls.Add(this.chkEnableLogging);
            this.gpbLogging.Controls.Add(this.lblLogFolder);
            this.gpbLogging.Controls.Add(this.txtLogFilePath);
            this.gpbLogging.Location = new System.Drawing.Point(12, 150);
            this.gpbLogging.Name = "gpbLogging";
            this.gpbLogging.Size = new System.Drawing.Size(416, 87);
            this.gpbLogging.TabIndex = 9;
            this.gpbLogging.TabStop = false;
            this.gpbLogging.Text = "Log";
            // 
            // btnChangeLogFolder
            // 
            this.btnChangeLogFolder.Location = new System.Drawing.Point(335, 54);
            this.btnChangeLogFolder.Name = "btnChangeLogFolder";
            this.btnChangeLogFolder.Size = new System.Drawing.Size(75, 23);
            this.btnChangeLogFolder.TabIndex = 6;
            this.btnChangeLogFolder.Text = "Change...";
            this.btnChangeLogFolder.UseVisualStyleBackColor = true;
            this.btnChangeLogFolder.Click += new System.EventHandler(this.btnChangeLogFolder_Click);
            // 
            // chkEnableLogging
            // 
            this.chkEnableLogging.AutoSize = true;
            this.chkEnableLogging.Location = new System.Drawing.Point(7, 20);
            this.chkEnableLogging.Name = "chkEnableLogging";
            this.chkEnableLogging.Size = new System.Drawing.Size(100, 17);
            this.chkEnableLogging.TabIndex = 0;
            this.chkEnableLogging.Text = "Enable Logging";
            this.chkEnableLogging.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(353, 243);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // grpDateFormat
            // 
            this.grpDateFormat.Controls.Add(this.txtDateFormatString);
            this.grpDateFormat.Controls.Add(this.lblDateFormattingHelp);
            this.grpDateFormat.Location = new System.Drawing.Point(12, 12);
            this.grpDateFormat.Name = "grpDateFormat";
            this.grpDateFormat.Size = new System.Drawing.Size(416, 132);
            this.grpDateFormat.TabIndex = 11;
            this.grpDateFormat.TabStop = false;
            this.grpDateFormat.Text = "Date Formatting";
            // 
            // lblDateFormattingHelp
            // 
            this.lblDateFormattingHelp.Location = new System.Drawing.Point(9, 20);
            this.lblDateFormattingHelp.Name = "lblDateFormattingHelp";
            this.lblDateFormattingHelp.Size = new System.Drawing.Size(401, 83);
            this.lblDateFormattingHelp.TabIndex = 0;
            this.lblDateFormattingHelp.Text = resources.GetString("lblDateFormattingHelp.Text");
            // 
            // txtDateFormatString
            // 
            this.txtDateFormatString.Location = new System.Drawing.Point(7, 106);
            this.txtDateFormatString.Name = "txtDateFormatString";
            this.txtDateFormatString.Size = new System.Drawing.Size(403, 20);
            this.txtDateFormatString.TabIndex = 1;
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 273);
            this.Controls.Add(this.grpDateFormat);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.gpbLogging);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.btnOK);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSettings";
            this.Text = "SuperSecretary Settings";
            this.gpbLogging.ResumeLayout(false);
            this.gpbLogging.PerformLayout();
            this.grpDateFormat.ResumeLayout(false);
            this.grpDateFormat.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtLogFilePath;
        private System.Windows.Forms.Label lblLogFolder;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.GroupBox gpbLogging;
        private System.Windows.Forms.CheckBox chkEnableLogging;
        private System.Windows.Forms.Button btnChangeLogFolder;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.GroupBox grpDateFormat;
        private System.Windows.Forms.Label lblDateFormattingHelp;
        private System.Windows.Forms.TextBox txtDateFormatString;
    }
}