using System;
using System.Windows.Forms;

namespace SuperSecretary.WinForms
{
    public partial class frmSettings : Form
    {
        public frmSettings()
        {
            InitializeComponent();
            cboDateFormatString.Text = Settings.Default.DateFormatString;
            chkEnableLogging.Checked = Settings.Default.EnableLogging;
            txtLogFilePath.Text = Settings.Default.LogFilePath;
        }

        private void Save()
        {
            Settings.Default.DateFormatString = cboDateFormatString.Text;
            Settings.Default.EnableLogging = chkEnableLogging.Checked;
            Settings.Default.LogFilePath = txtLogFilePath.Text;
            Settings.Default.Save();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            if (!Validate())
            {
                Save();
            }         
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (!Validate())
            {
                Save();
                this.Close();
            }
        }

        private void btnChangeLogFolder_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                txtLogFilePath.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void cboDateFormatString_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            DateTime dateFormat;
            if (!DateTime.TryParse(cboDateFormatString.Text, out dateFormat))
            {
                errorProvider.SetError(cboDateFormatString, "Date format string is not in the correct format.");
            }
        }

        private void cboDateFormatString_TextChanged(object sender, EventArgs e)
        {
            try
            {
                lblDateFormatDisplay.Text = "Selected format: " + DateTime.Now.ToString(cboDateFormatString.Text);
            }
            catch (Exception ex)
            {

            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
