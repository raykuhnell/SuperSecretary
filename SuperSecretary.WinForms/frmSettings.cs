using System;
using System.Windows.Forms;

namespace SuperSecretary.WinForms
{
    public partial class frmSettings : Form
    {
        public frmSettings()
        {
            InitializeComponent();
            txtYearFormatString.Text = Settings.Default.YearFormatString;
            txtMonthFormatString.Text = Settings.Default.MonthFormatString;
            txtLogFilePath.Text = Settings.Default.LogFilePath;
        }

        private void Save()
        {
            Settings.Default.YearFormatString = txtYearFormatString.Text;
            Settings.Default.MonthFormatString = txtMonthFormatString.Text;
            Settings.Default.LogFilePath = txtLogFilePath.Text;
            Settings.Default.Save();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void btnSaveAndClose_Click(object sender, EventArgs e)
        {
            Save();
            this.Close();
        }
    }
}
