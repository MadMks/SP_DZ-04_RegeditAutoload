using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegeditAutoload
{
    public partial class MainForm : Form
    {
        private RegistryKey registryKey = null;
        string pathRun = @"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Run";

        public MainForm()
        {
            InitializeComponent();

            Load += MainForm_Load;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            DisableButtons();

            registryKey = GetLastSubKeyInPath(pathRun);

            ShowPrograms(registryKey);

            listBox.SelectedIndexChanged += ListBox_SelectedIndexChanged;

            //RegistryKey software = currentUserKey.OpenSubKey("Software");
            //RegistryKey microsoft = software.OpenSubKey("Microsoft");
            //RegistryKey windows = microsoft.OpenSubKey("Windows");
            //RegistryKey currentVersion = windows.OpenSubKey("CurrentVersion");
            //RegistryKey run = currentVersion.OpenSubKey("Run");
        }

        private void ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox.SelectedIndex == -1)
            {
                DisableButtons();
            }
            else
            {
                EnableButtons();
            }
        }

        private void DisableButtons()
        {
            buttonAdd.Enabled = false;
            buttonDelete.Enabled = false;
        }

        private void EnableButtons()
        {
            buttonAdd.Enabled = true;
            buttonDelete.Enabled = true;
        }

        private void ShowPrograms(RegistryKey key)
        {
            listBox.Items.Clear();

            foreach (var item in key.GetValueNames())
            {
                listBox.Items.Add(item);
            }
        }

        /// <summary>
        /// Получить последний подраздел в пути.
        /// </summary>
        /// <param name="pathSubKey">Полный путь.</param>
        private RegistryKey GetLastSubKeyInPath(string pathSubKey)
        {
            string HK = pathSubKey.Substring(0, pathSubKey.IndexOf('\\'));
            string path = pathSubKey.Substring(pathSubKey.IndexOf('\\'));
            RegistryKey key = GetHKRegistryKey(HK);

            foreach (var item in path.Split('\\'))
            {
                key = key.OpenSubKey(item);
            }

            return key;
        }

        private RegistryKey GetHKRegistryKey(string hK)
        {
            switch (hK)
            {
                case "HKEY_CLASSES_ROOT":
                    return Registry.ClassesRoot;
                case "HKEY_CURRENT_USER":
                    return Registry.CurrentUser;
                case "HKEY_LOCAL_MACHINE":
                    return Registry.LocalMachine;
                case "HKEY_USERS":
                    return Registry.Users;
                case "HKEY_CURRENT_CONFIG":
                    return Registry.CurrentConfig;
                default:
                    return Registry.CurrentUser;
            }
        }

        private void buttonUpgrade_Click(object sender, EventArgs e)
        {
            DisableButtons();

            ShowPrograms(registryKey);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {

        }
    }
}
