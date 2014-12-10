using System;
using System.Linq;
using System.Windows.Forms;
using SuperSecretary;
using SuperSecretary.Events;
using SuperSecretary.Handlers;
using System.IO;

namespace SuperSecretary.WinForms
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            txtSource.Text = Settings.Default.LastSourcePath;
            txtDestination.Text = Settings.Default.LastDestinationPath;

            // Load handler plugins.
            try
            {
                if (Directory.Exists(Settings.Default.PluginsDirectory))
                {
                    var hm = HandlerManager.Instance;
                    foreach (string file in Directory.GetFiles(Settings.Default.PluginsDirectory, "*.dll"))
                    {
                        hm.LoadAssembly(file);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred loading plugins.  Please check the plugins directory and restart the application.", Application.ProductName);
            }            
        }

        private void btnSelectSource_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                txtSource.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void btnSelectDestination_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                txtDestination.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            string source = txtSource.Text;
            string destination = txtDestination.Text;

            if (String.IsNullOrEmpty(source))
            {
                MessageBox.Show("No source folder selected.", Application.ProductName);
                return;
            }
            if (String.IsNullOrEmpty(destination))
            {
                if (MessageBox.Show("No destination has been selected.  The files will be rearranged in the current directory.  Is this OK?", Application.ProductName, MessageBoxButtons.YesNo) == DialogResult.No)
                    return;
            }

            string[] properties = new string[lbProperties.Items.Count];
            for (int i = 0; i < lbProperties.Items.Count; i++)
            {
                properties[i] = lbProperties.Items[i].ToString();
            }

            Settings.Default.LastSourcePath = source;
            Settings.Default.LastDestinationPath = destination;
            Settings.Default.Save();

            EngineOptions options = new EngineOptions() { 
                RecurseSubdirectories = chkSubdirectories.Checked,
                Copy = chkCopy.Checked,
                FileExtensions = clbFileTypes.CheckedItems.Cast<String>().ToArray(),
                DateFormatString = Settings.Default.DateFormatString,
                SkipFolder = Settings.Default.SkipFolder,
                MissingFolderName = Settings.Default.MissingFolderName,
                OverwriteExistingFiles = Settings.Default.OverwriteExistingFiles
            };
            Engine engine = new Engine(source, destination, properties, options);
            engine.OnProgressUpdate += Engine_ProgressUpdate;

            try
            {
                engine.Process();                
            }
            catch (UnauthorizedAccessException ex)
            {
                MessageBox.Show("An error occurred trying to access files.  " + ex.Message, Application.ProductName);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unknown error occurred.  " + ex.Message, Application.ProductName);
            }

            if (Settings.Default.EnableLogging)
            {
                Log.Save(Settings.Default.LogFilePath);
            }
            MessageBox.Show("Process completed!");
        }

        private void Engine_ProgressUpdate(object sender, ProgressEventArgs e)
        {
            Log.Write(e.Status);
            progressBar.Maximum = e.Total;
            progressBar.PerformStep();
        }

        private void RefreshPreview()
        {
            btnGo.Enabled = lbProperties.Items.Count > 0;

            string folder = "";
            foreach(var item in lbProperties.Items)
            {
                folder += "/" + item.ToString();
            }
            lblPreview.Text = "Output Folder Structure: " + folder;
        }

        private void btnAddProperty_Click(object sender, EventArgs e)
        {
            lbProperties.Items.Add(cbProperty.Text);
            RefreshPreview();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSettings settings = new frmSettings();
            settings.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnScan_Click(object sender, EventArgs e)
        {
            clbFileTypes.Items.Clear();
            var result = Engine.Scan(txtSource.Text, chkSubdirectories.Checked);

            if (result.Success)
            {
                clbFileTypes.Items.AddRange(result.Extensions);
                cbProperty.Items.AddRange(HandlerManager.Instance.Handlers.Keys.ToArray());

                cbProperty.Enabled = true;
                lbProperties.Enabled = true;
                btnAddProperty.Enabled = true;
                btnRemoveProperty.Enabled = true;
                clbFileTypes.Enabled = true;
            }
            else
            {
                MessageBox.Show("The source directory could not be scanned.  Please make sure that you have permission to the directory and try again.", Application.ProductName);
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAbout about = new frmAbout();
            about.Show();
        }

        private void btnRemoveProperty_Click(object sender, EventArgs e)
        {
            for (int i = lbProperties.SelectedItems.Count - 1; i >= 0; i--)
            {
                lbProperties.Items.Remove(lbProperties.SelectedItems[i]);
            }
            RefreshPreview();
        }
    }
}
