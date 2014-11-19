using System;
using System.Windows.Forms;

namespace SuperSecretary.WinForms
{
    public partial class frmSettings : Form
    {
        public frmSettings()
        {
            InitializeComponent();
            txtDateFormatString.Text = Settings.Default.DateFormatString;
            chkEnableLogging.Checked = Settings.Default.EnableLogging;
            txtLogFilePath.Text = Settings.Default.LogFilePath;
        }

        private void Save()
        {
            Settings.Default.DateFormatString = txtDateFormatString.Text;
            Settings.Default.EnableLogging = chkEnableLogging.Checked;
            Settings.Default.LogFilePath = txtLogFilePath.Text;
            Settings.Default.Save();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Save();
            this.Close();
        }

        private void btnChangeLogFolder_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                txtLogFilePath.Text = folderBrowserDialog.SelectedPath;
            }
        }
    }
}
