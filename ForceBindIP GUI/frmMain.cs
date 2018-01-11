using System;
using System.Diagnostics;
using System.IO;
using System.Net.NetworkInformation;
using System.Windows.Forms;

namespace ForceBindIP_GUI
{
    public partial class frmMain : Form
    {
        private readonly string[] RequieredFiles = new string[] {"BindIP.dll", "BindIP64.dll", "ForceBindIP.exe", "ForceBindIP64.exe"};

        public frmMain()
        {
            InitializeComponent();

            CheckRequieredFiles();

            btnOpenTargetApplication.Click += (sender, e) => OpenAppSelector();
            btnLaunch.Click += (sender , e) => LaunchApp();
            cmbNetworkAdapter.DropDown += (sender, e) => LoadAvailableNetworkAdapters();
        }

        private string ForceBindIPPath => Environment.CurrentDirectory;

        private string ForceBindExe => chk64b.Checked ? "ForceBindIP64.exe" : "ForceBindIP.exe";

        /// <summary>
        /// Check if all ForceBindIP files are in the directory
        /// </summary>
        private void CheckRequieredFiles()
        {
            string curDir = Environment.CurrentDirectory;
            foreach(string s in RequieredFiles)
            {
                if(!File.Exists(Path.Combine(curDir, s)))
                {
                    MessageBox.Show("Couldn't find ForceBindIP files", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Environment.Exit(-1);
                }
            }
        }

        /// <summary>
        /// Launch the selected app on the given network adapter
        /// </summary>
        private void LaunchApp()
        {
            try
            {
                string path = $"{ForceBindIPPath}\\{ForceBindExe}";
                string args = $"{((NetworkAdapterInfo)cmbNetworkAdapter.SelectedItem).IP} \"{txtTargetApp.Text}\"";
                ProcessStartInfo psi = new ProcessStartInfo();
                psi.FileName = path;
                psi.Arguments = args;
                psi.WorkingDirectory = Path.GetDirectoryName(txtTargetApp.Text);
                Process.Start(psi);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Open the application selector
        /// </summary>
        private void OpenAppSelector()
        {
            OpenFileDialog diag = new OpenFileDialog();
            diag.Filter = "Application (*.exe)|*.exe";
            diag.Multiselect = false;
            diag.Title = "Select a application to open";
            if (diag.ShowDialog() == DialogResult.OK)
                txtTargetApp.Text = diag.FileName;
        }

        /// <summary>
        /// Get all available network adapters
        /// </summary>
        private void LoadAvailableNetworkAdapters()
        {
            cmbNetworkAdapter.Items.Clear();
            foreach (NetworkInterface ni in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (ni.NetworkInterfaceType == NetworkInterfaceType.Wireless80211 || ni.NetworkInterfaceType == NetworkInterfaceType.Ethernet)
                {
                    foreach (UnicastIPAddressInformation ip in ni.GetIPProperties().UnicastAddresses)
                    {
                        if (ip.Address.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                            cmbNetworkAdapter.Items.Add(new NetworkAdapterInfo(ni.Name, ip.Address.ToString()));
                    }
                }
            }
        }

        private void CmbNetworkAdapter_DropDown(object sender, EventArgs e)
        {
            LoadAvailableNetworkAdapters();
        }
    }
}
