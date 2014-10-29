namespace SuperSecretary.WinForms
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.txtSource = new System.Windows.Forms.TextBox();
            this.btnSelectSource = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDestination = new System.Windows.Forms.TextBox();
            this.btnSelectDestination = new System.Windows.Forms.Button();
            this.cbProperty = new System.Windows.Forms.ComboBox();
            this.btnGo = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoYear = new System.Windows.Forms.RadioButton();
            this.rdoMonth = new System.Windows.Forms.RadioButton();
            this.chkSubdirectories = new System.Windows.Forms.CheckBox();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbProperties = new System.Windows.Forms.ListBox();
            this.btnAddProperty = new System.Windows.Forms.Button();
            this.btnRemoveProperty = new System.Windows.Forms.Button();
            this.lblPreview = new System.Windows.Forms.Label();
            this.clbFileTypes = new System.Windows.Forms.CheckedListBox();
            this.btnScan = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.chkCopy = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSource
            // 
            this.txtSource.Enabled = false;
            this.txtSource.Location = new System.Drawing.Point(82, 34);
            this.txtSource.Name = "txtSource";
            this.txtSource.Size = new System.Drawing.Size(289, 20);
            this.txtSource.TabIndex = 0;
            // 
            // btnSelectSource
            // 
            this.btnSelectSource.Location = new System.Drawing.Point(377, 32);
            this.btnSelectSource.Name = "btnSelectSource";
            this.btnSelectSource.Size = new System.Drawing.Size(75, 23);
            this.btnSelectSource.TabIndex = 1;
            this.btnSelectSource.Text = "Select...";
            this.btnSelectSource.UseVisualStyleBackColor = true;
            this.btnSelectSource.Click += new System.EventHandler(this.btnSelectSource_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Source:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Destination:";
            // 
            // txtDestination
            // 
            this.txtDestination.Enabled = false;
            this.txtDestination.Location = new System.Drawing.Point(82, 60);
            this.txtDestination.Name = "txtDestination";
            this.txtDestination.Size = new System.Drawing.Size(289, 20);
            this.txtDestination.TabIndex = 4;
            // 
            // btnSelectDestination
            // 
            this.btnSelectDestination.Location = new System.Drawing.Point(377, 58);
            this.btnSelectDestination.Name = "btnSelectDestination";
            this.btnSelectDestination.Size = new System.Drawing.Size(75, 23);
            this.btnSelectDestination.TabIndex = 5;
            this.btnSelectDestination.Text = "Select...";
            this.btnSelectDestination.UseVisualStyleBackColor = true;
            this.btnSelectDestination.Click += new System.EventHandler(this.btnSelectDestination_Click);
            // 
            // cbProperty
            // 
            this.cbProperty.Enabled = false;
            this.cbProperty.FormattingEnabled = true;
            this.cbProperty.Location = new System.Drawing.Point(12, 170);
            this.cbProperty.Name = "cbProperty";
            this.cbProperty.Size = new System.Drawing.Size(195, 21);
            this.cbProperty.TabIndex = 6;
            // 
            // btnGo
            // 
            this.btnGo.Enabled = false;
            this.btnGo.Location = new System.Drawing.Point(377, 408);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(75, 23);
            this.btnGo.TabIndex = 7;
            this.btnGo.Text = "Go!";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(12, 408);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(359, 23);
            this.progressBar.Step = 1;
            this.progressBar.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Sort by:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoYear);
            this.groupBox1.Controls.Add(this.rdoMonth);
            this.groupBox1.Location = new System.Drawing.Point(248, 311);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(204, 69);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sort Options";
            // 
            // rdoYear
            // 
            this.rdoYear.AutoSize = true;
            this.rdoYear.Enabled = false;
            this.rdoYear.Location = new System.Drawing.Point(7, 42);
            this.rdoYear.Name = "rdoYear";
            this.rdoYear.Size = new System.Drawing.Size(107, 17);
            this.rdoYear.TabIndex = 14;
            this.rdoYear.Text = "Sort by Year Only";
            this.rdoYear.UseVisualStyleBackColor = true;
            // 
            // rdoMonth
            // 
            this.rdoMonth.AutoSize = true;
            this.rdoMonth.Checked = true;
            this.rdoMonth.Enabled = false;
            this.rdoMonth.Location = new System.Drawing.Point(7, 19);
            this.rdoMonth.Name = "rdoMonth";
            this.rdoMonth.Size = new System.Drawing.Size(137, 17);
            this.rdoMonth.TabIndex = 13;
            this.rdoMonth.TabStop = true;
            this.rdoMonth.Text = "Sort by Month and Year";
            this.rdoMonth.UseVisualStyleBackColor = true;
            // 
            // chkSubdirectories
            // 
            this.chkSubdirectories.AutoSize = true;
            this.chkSubdirectories.Checked = true;
            this.chkSubdirectories.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSubdirectories.Location = new System.Drawing.Point(235, 91);
            this.chkSubdirectories.Name = "chkSubdirectories";
            this.chkSubdirectories.Size = new System.Drawing.Size(136, 17);
            this.chkSubdirectories.TabIndex = 12;
            this.chkSubdirectories.Text = "Recurse Subdirectories";
            this.chkSubdirectories.UseVisualStyleBackColor = true;
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(464, 24);
            this.menuStrip.TabIndex = 14;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.aboutToolStripMenuItem.Text = "About SuperSecretary";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // lbProperties
            // 
            this.lbProperties.Enabled = false;
            this.lbProperties.FormattingEnabled = true;
            this.lbProperties.Location = new System.Drawing.Point(12, 194);
            this.lbProperties.Name = "lbProperties";
            this.lbProperties.Size = new System.Drawing.Size(195, 186);
            this.lbProperties.TabIndex = 15;
            // 
            // btnAddProperty
            // 
            this.btnAddProperty.Enabled = false;
            this.btnAddProperty.Location = new System.Drawing.Point(213, 168);
            this.btnAddProperty.Name = "btnAddProperty";
            this.btnAddProperty.Size = new System.Drawing.Size(29, 23);
            this.btnAddProperty.TabIndex = 16;
            this.btnAddProperty.Text = "+";
            this.btnAddProperty.UseVisualStyleBackColor = true;
            this.btnAddProperty.Click += new System.EventHandler(this.btnAddProperty_Click);
            // 
            // btnRemoveProperty
            // 
            this.btnRemoveProperty.Enabled = false;
            this.btnRemoveProperty.Location = new System.Drawing.Point(213, 197);
            this.btnRemoveProperty.Name = "btnRemoveProperty";
            this.btnRemoveProperty.Size = new System.Drawing.Size(29, 23);
            this.btnRemoveProperty.TabIndex = 17;
            this.btnRemoveProperty.Text = "-";
            this.btnRemoveProperty.UseVisualStyleBackColor = true;
            this.btnRemoveProperty.Click += new System.EventHandler(this.btnRemoveProperty_Click);
            // 
            // lblPreview
            // 
            this.lblPreview.AutoSize = true;
            this.lblPreview.Location = new System.Drawing.Point(12, 383);
            this.lblPreview.Name = "lblPreview";
            this.lblPreview.Size = new System.Drawing.Size(120, 13);
            this.lblPreview.TabIndex = 18;
            this.lblPreview.Text = "Output Folder Structure:";
            // 
            // clbFileTypes
            // 
            this.clbFileTypes.Enabled = false;
            this.clbFileTypes.FormattingEnabled = true;
            this.clbFileTypes.Location = new System.Drawing.Point(248, 170);
            this.clbFileTypes.Name = "clbFileTypes";
            this.clbFileTypes.Size = new System.Drawing.Size(204, 109);
            this.clbFileTypes.TabIndex = 19;
            // 
            // btnScan
            // 
            this.btnScan.Location = new System.Drawing.Point(377, 87);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(75, 23);
            this.btnScan.TabIndex = 20;
            this.btnScan.Text = "Scan";
            this.btnScan.UseVisualStyleBackColor = true;
            this.btnScan.Click += new System.EventHandler(this.btnScan_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(252, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "File Types:";
            // 
            // chkCopy
            // 
            this.chkCopy.AutoSize = true;
            this.chkCopy.Checked = true;
            this.chkCopy.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkCopy.Location = new System.Drawing.Point(248, 286);
            this.chkCopy.Name = "chkCopy";
            this.chkCopy.Size = new System.Drawing.Size(191, 17);
            this.chkCopy.TabIndex = 22;
            this.chkCopy.Text = "Copy and leave source files intact?";
            this.chkCopy.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 443);
            this.Controls.Add(this.chkCopy);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnScan);
            this.Controls.Add(this.clbFileTypes);
            this.Controls.Add(this.lblPreview);
            this.Controls.Add(this.btnRemoveProperty);
            this.Controls.Add(this.lbProperties);
            this.Controls.Add(this.btnAddProperty);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chkSubdirectories);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.cbProperty);
            this.Controls.Add(this.btnSelectDestination);
            this.Controls.Add(this.txtDestination);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSelectSource);
            this.Controls.Add(this.txtSource);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Name = "frmMain";
            this.Text = "SuperSecretary";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.TextBox txtSource;
        private System.Windows.Forms.Button btnSelectSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDestination;
        private System.Windows.Forms.Button btnSelectDestination;
        private System.Windows.Forms.ComboBox cbProperty;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkSubdirectories;
        private System.Windows.Forms.RadioButton rdoYear;
        private System.Windows.Forms.RadioButton rdoMonth;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ListBox lbProperties;
        private System.Windows.Forms.Button btnAddProperty;
        private System.Windows.Forms.Button btnRemoveProperty;
        private System.Windows.Forms.Label lblPreview;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.CheckedListBox clbFileTypes;
        private System.Windows.Forms.Button btnScan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkCopy;
    }
}

