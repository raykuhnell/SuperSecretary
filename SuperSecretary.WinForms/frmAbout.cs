using System;
using System.Windows.Forms;

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
    }
}
