using System;
using System.Windows.Forms;
using PluginsAPI;
using System.Runtime.InteropServices;
using Microsoft.Win32;

namespace FocaPluginExample
{
    public partial class FrmPluginExample : Form
    {
        [DllImport("wininet.dll")]
        public static extern bool InternetSetOption(IntPtr hInternet, int dwOption, IntPtr lpBuffer, int dwBufferLength);
        public const int INTERNET_OPTION_SETTINGS_CHANGED = 39;
        public const int INTERNET_OPTION_REFRESH = 37;
        bool settingsReturn, refreshReturn;
        public FrmPluginExample()
        {
            InitializeComponent();
            CheckProxyStatus();
        }

        private void CheckProxyStatus()
        {
            RegistryKey registry = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Internet Settings", true);
            int isEnabled = (int)registry.GetValue("ProxyEnable");
            string proxy = (string)registry.GetValue("ProxyServer");
            var proxyArray = proxy.Split(new char[] { ':' });
            string ip = proxyArray[0];
            string port = proxyArray[1];

            if (isEnabled.Equals(1))
            {
                proxyEnabled.Checked = true;
                lblDomain.Text = ip;
                txtPort.Text = port;
            }

        }

        private void btnSendFoca_Click(object sender, EventArgs e)
        {
            try
            {
                var ip = lblDomain.Text;
                var port = txtPort.Text;
                if (proxyEnabled.Checked)
                {
                    SetGlobalProxy(ip, port);
                }
                else
                {
                    TurnOffGlobalProxy();
                }
            }
            catch
            {
                MessageBox.Show(@"Invalid proxy settings", "", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }


        /// <summary>
        /// Set Windows global proxy to internet settings
        /// </summary>
        /// <param name="value"></param>
        private void SetGlobalProxy(string ip, string port)
        {
            RegistryKey registry = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Internet Settings", true);
            registry.SetValue("ProxyEnable", 1);
            registry.SetValue("ProxyServer", $"{ip}:{port}");

            // These lines implement the Interface in the beginning of program 
            // They cause the OS to refresh the settings, causing IP to realy update
            settingsReturn = InternetSetOption(IntPtr.Zero, INTERNET_OPTION_SETTINGS_CHANGED, IntPtr.Zero, 0);
            refreshReturn = InternetSetOption(IntPtr.Zero, INTERNET_OPTION_REFRESH, IntPtr.Zero, 0);
        }

        private void TurnOffGlobalProxy()
        {

            RegistryKey registry = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Internet Settings", true);
            registry.SetValue("ProxyEnable", 0);

            // These lines implement the Interface in the beginning of program 
            // They cause the OS to refresh the settings, causing IP to realy update
            settingsReturn = InternetSetOption(IntPtr.Zero, INTERNET_OPTION_SETTINGS_CHANGED, IntPtr.Zero, 0);
            refreshReturn = InternetSetOption(IntPtr.Zero, INTERNET_OPTION_REFRESH, IntPtr.Zero, 0);
        }
    }
}
