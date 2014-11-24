using System;
using System.Windows.Forms;
using SuperSecretary.Updates;

namespace SuperSecretary.WinForms
{
    public partial class frmAbout : Form
    {
        public frmAbout()
        {
            InitializeComponent();
            lblName.Text = Application.ProductName;
            lblVersion.Text = String.Format("Version: {0}", Application.ProductVersion);
            lblCompany.Text = Application.CompanyName;
        }

        private void btnCheckForUpdates_Click(object sender, EventArgs e)
        {
            var u = new Updater();
            if (u.UpdatesAvailable)
            {
                if (MessageBox.Show(String.Format("Version {0} is available.  Would you like to update now?  This will restart the application.", u.Latest.Version), Application.ProductName, MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    u.DownloadAndInstall();
                    Application.Exit();
                }
            }
        }
    }
}
