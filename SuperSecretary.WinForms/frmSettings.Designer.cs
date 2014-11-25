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
            this.components = new System.ComponentModel.Container();
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
            this.lblDateFormatDisplay = new System.Windows.Forms.Label();
            this.cboDateFormatString = new System.Windows.Forms.ComboBox();
            this.lblDateFormattingHelp = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.gpbOptions = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMissingFolderName = new System.Windows.Forms.TextBox();
            this.rdoUseDefaultFolder = new System.Windows.Forms.RadioButton();
            this.rdoSkipFolder = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlMissingFolderOptions = new System.Windows.Forms.Panel();
            this.pnlFileExistsOptions = new System.Windows.Forms.Panel();
            this.rdoSkipFile = new System.Windows.Forms.RadioButton();
            this.rdoOverwriteFile = new System.Windows.Forms.RadioButton();
            this.gpbLogging.SuspendLayout();
            this.grpDateFormat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.gpbOptions.SuspendLayout();
            this.pnlMissingFolderOptions.SuspendLayout();
            this.pnlFileExistsOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtLogFilePath
            // 
            this.txtLogFilePath.Location = new System.Drawing.Point(6, 56);
            this.txtLogFilePath.Name = "txtLogFilePath";
            this.txtLogFilePath.Size = new System.Drawing.Size(367, 20);
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
            this.btnOK.Location = new System.Drawing.Point(310, 418);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 6;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(229, 418);
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
            this.gpbLogging.Location = new System.Drawing.Point(12, 325);
            this.gpbLogging.Name = "gpbLogging";
            this.gpbLogging.Size = new System.Drawing.Size(460, 87);
            this.gpbLogging.TabIndex = 9;
            this.gpbLogging.TabStop = false;
            this.gpbLogging.Text = "Logging";
            // 
            // btnChangeLogFolder
            // 
            this.btnChangeLogFolder.Location = new System.Drawing.Point(379, 54);
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
            this.btnCancel.Location = new System.Drawing.Point(391, 418);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // grpDateFormat
            // 
            this.grpDateFormat.Controls.Add(this.lblDateFormatDisplay);
            this.grpDateFormat.Controls.Add(this.cboDateFormatString);
            this.grpDateFormat.Controls.Add(this.lblDateFormattingHelp);
            this.grpDateFormat.Location = new System.Drawing.Point(12, 12);
            this.grpDateFormat.Name = "grpDateFormat";
            this.grpDateFormat.Size = new System.Drawing.Size(460, 161);
            this.grpDateFormat.TabIndex = 11;
            this.grpDateFormat.TabStop = false;
            this.grpDateFormat.Text = "Date Formatting";
            // 
            // lblDateFormatDisplay
            // 
            this.lblDateFormatDisplay.AutoSize = true;
            this.lblDateFormatDisplay.Location = new System.Drawing.Point(6, 115);
            this.lblDateFormatDisplay.Name = "lblDateFormatDisplay";
            this.lblDateFormatDisplay.Size = new System.Drawing.Size(0, 13);
            this.lblDateFormatDisplay.TabIndex = 13;
            // 
            // cboDateFormatString
            // 
            this.cboDateFormatString.FormattingEnabled = true;
            this.cboDateFormatString.Items.AddRange(new object[] {
            "yyyy",
            "yyyy\\\\MM",
            "yyyy\\\\MMMM",
            "yyyy\\\\MM\\\\dd",
            "yyyy\\\\MMMM\\\\dd"});
            this.cboDateFormatString.Location = new System.Drawing.Point(6, 131);
            this.cboDateFormatString.Name = "cboDateFormatString";
            this.cboDateFormatString.Size = new System.Drawing.Size(428, 21);
            this.cboDateFormatString.TabIndex = 12;
            this.cboDateFormatString.TextChanged += new System.EventHandler(this.cboDateFormatString_TextChanged);
            this.cboDateFormatString.Validating += new System.ComponentModel.CancelEventHandler(this.cboDateFormatString_Validating);
            // 
            // lblDateFormattingHelp
            // 
            this.lblDateFormattingHelp.Location = new System.Drawing.Point(9, 20);
            this.lblDateFormattingHelp.Name = "lblDateFormattingHelp";
            this.lblDateFormattingHelp.Size = new System.Drawing.Size(445, 83);
            this.lblDateFormattingHelp.TabIndex = 0;
            this.lblDateFormattingHelp.Text = resources.GetString("lblDateFormattingHelp.Text");
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // gpbOptions
            // 
            this.gpbOptions.Controls.Add(this.pnlFileExistsOptions);
            this.gpbOptions.Controls.Add(this.pnlMissingFolderOptions);
            this.gpbOptions.Controls.Add(this.label2);
            this.gpbOptions.Controls.Add(this.label1);
            this.gpbOptions.Controls.Add(this.txtMissingFolderName);
            this.gpbOptions.Location = new System.Drawing.Point(12, 180);
            this.gpbOptions.Name = "gpbOptions";
            this.gpbOptions.Size = new System.Drawing.Size(460, 139);
            this.gpbOptions.TabIndex = 12;
            this.gpbOptions.TabStop = false;
            this.gpbOptions.Text = "Sort Options";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(352, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "When a file does not have an attribute value defined (i.e. no Date taken):";
            // 
            // txtMissingFolderName
            // 
            this.txtMissingFolderName.Location = new System.Drawing.Point(92, 66);
            this.txtMissingFolderName.Name = "txtMissingFolderName";
            this.txtMissingFolderName.Size = new System.Drawing.Size(342, 20);
            this.txtMissingFolderName.TabIndex = 2;
            // 
            // rdoUseDefaultFolder
            // 
            this.rdoUseDefaultFolder.AutoSize = true;
            this.rdoUseDefaultFolder.Location = new System.Drawing.Point(87, 3);
            this.rdoUseDefaultFolder.Name = "rdoUseDefaultFolder";
            this.rdoUseDefaultFolder.Size = new System.Drawing.Size(147, 17);
            this.rdoUseDefaultFolder.TabIndex = 1;
            this.rdoUseDefaultFolder.TabStop = true;
            this.rdoUseDefaultFolder.Text = "Use Default Folder Name:";
            this.rdoUseDefaultFolder.UseVisualStyleBackColor = true;
            // 
            // rdoSkipFolder
            // 
            this.rdoSkipFolder.AutoSize = true;
            this.rdoSkipFolder.Location = new System.Drawing.Point(3, 3);
            this.rdoSkipFolder.Name = "rdoSkipFolder";
            this.rdoSkipFolder.Size = new System.Drawing.Size(78, 17);
            this.rdoSkipFolder.TabIndex = 0;
            this.rdoSkipFolder.TabStop = true;
            this.rdoSkipFolder.Text = "Skip Folder";
            this.rdoSkipFolder.UseVisualStyleBackColor = true;
            this.rdoSkipFolder.CheckedChanged += new System.EventHandler(this.rdoSkipFolder_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "When a file already exists in the destination:";
            // 
            // pnlMissingFolderOptions
            // 
            this.pnlMissingFolderOptions.Controls.Add(this.rdoSkipFolder);
            this.pnlMissingFolderOptions.Controls.Add(this.rdoUseDefaultFolder);
            this.pnlMissingFolderOptions.Location = new System.Drawing.Point(7, 36);
            this.pnlMissingFolderOptions.Name = "pnlMissingFolderOptions";
            this.pnlMissingFolderOptions.Size = new System.Drawing.Size(235, 24);
            this.pnlMissingFolderOptions.TabIndex = 5;
            // 
            // pnlFileExistsOptions
            // 
            this.pnlFileExistsOptions.Controls.Add(this.rdoOverwriteFile);
            this.pnlFileExistsOptions.Controls.Add(this.rdoSkipFile);
            this.pnlFileExistsOptions.Location = new System.Drawing.Point(7, 106);
            this.pnlFileExistsOptions.Name = "pnlFileExistsOptions";
            this.pnlFileExistsOptions.Size = new System.Drawing.Size(167, 23);
            this.pnlFileExistsOptions.TabIndex = 6;
            // 
            // rdoSkipFile
            // 
            this.rdoSkipFile.AutoSize = true;
            this.rdoSkipFile.Location = new System.Drawing.Point(2, 3);
            this.rdoSkipFile.Name = "rdoSkipFile";
            this.rdoSkipFile.Size = new System.Drawing.Size(65, 17);
            this.rdoSkipFile.TabIndex = 0;
            this.rdoSkipFile.TabStop = true;
            this.rdoSkipFile.Text = "Skip File";
            this.rdoSkipFile.UseVisualStyleBackColor = true;
            // 
            // rdoOverwriteFile
            // 
            this.rdoOverwriteFile.AutoSize = true;
            this.rdoOverwriteFile.Location = new System.Drawing.Point(73, 3);
            this.rdoOverwriteFile.Name = "rdoOverwriteFile";
            this.rdoOverwriteFile.Size = new System.Drawing.Size(89, 17);
            this.rdoOverwriteFile.TabIndex = 1;
            this.rdoOverwriteFile.TabStop = true;
            this.rdoOverwriteFile.Text = "Overwrite File";
            this.rdoOverwriteFile.UseVisualStyleBackColor = true;
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 450);
            this.Controls.Add(this.gpbOptions);
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
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.gpbOptions.ResumeLayout(false);
            this.gpbOptions.PerformLayout();
            this.pnlMissingFolderOptions.ResumeLayout(false);
            this.pnlMissingFolderOptions.PerformLayout();
            this.pnlFileExistsOptions.ResumeLayout(false);
            this.pnlFileExistsOptions.PerformLayout();
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
        private System.Windows.Forms.ComboBox cboDateFormatString;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Label lblDateFormatDisplay;
        private System.Windows.Forms.GroupBox gpbOptions;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMissingFolderName;
        private System.Windows.Forms.RadioButton rdoUseDefaultFolder;
        private System.Windows.Forms.RadioButton rdoSkipFolder;
        private System.Windows.Forms.Panel pnlFileExistsOptions;
        private System.Windows.Forms.RadioButton rdoOverwriteFile;
        private System.Windows.Forms.RadioButton rdoSkipFile;
        private System.Windows.Forms.Panel pnlMissingFolderOptions;
        private System.Windows.Forms.Label label2;
    }
}