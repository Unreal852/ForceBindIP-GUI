using System;
using System.Diagnostics;
using System.IO;
using System.Net.NetworkInformation;
using System.Windows.Forms;

namespace ForceBindIP_GUI
{
    public partial class frmMain : Form
    {
        private Properties.Settings m_settings = Properties.Settings.Default;

        public frmMain()
        {
            InitializeComponent();

            btnSelectFBIPath.Click += OnSelectFBIPathClicked;
            btnOpenTargetApplication.Click += OnOpenAppClicked;
            btnLaunch.Click += OnLaunchClicked;

            ForceBindIPPath = AppSettings.FBIPath;

            LoadAvailableNetworkAdapters();
        }

        private Properties.Settings AppSettings => m_settings;

        public string ForceBindIPPath
        {
            get { return txtFBIPath.Text; }
            set
            {
                if (Directory.Exists(value) && txtFBIPath.Text != value)
                {
                    txtFBIPath.Text = value;
                    if (AppSettings.FBIPath != value)
                    {
                        AppSettings.FBIPath = value;
                        AppSettings.Save();
                        AppSettings.Reload();
                    }
                }
            }
        }

        public string ForceBindExe => chk64b.Checked ? "ForceBindIP64.exe" : "ForceBindIP.exe";

        private void OnSelectFBIPathClicked(object sender, EventArgs e)
        {
            FolderBrowserDialog diag = new FolderBrowserDialog();
            if (!String.IsNullOrEmpty(ForceBindIPPath) && ForceBindIPPath.Length > 0)
                diag.SelectedPath = ForceBindIPPath;
            diag.Description = "Choose the ForceBindIP install path";
            diag.ShowNewFolderButton = false;
            if(diag.ShowDialog() == DialogResult.OK)
                ForceBindIPPath = diag.SelectedPath;
        }

        private void OnOpenAppClicked(object sender, EventArgs e)
        {
            OpenFileDialog diag = new OpenFileDialog();
            diag.Filter = "Application (*.exe)|*.exe";
            diag.Multiselect = false;
            diag.Title = "Select a application to open";
            if (diag.ShowDialog() == DialogResult.OK)
                txtTargetApp.Text = diag.FileName;
        }

        private void OnLaunchClicked(object sender, EventArgs e)
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
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Get all available network adapters
        /// </summary>
        private void LoadAvailableNetworkAdapters()
        {
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

    }
}
