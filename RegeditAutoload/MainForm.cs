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
        public MainForm()
        {
            InitializeComponent();

            Load += MainForm_Load;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ShowProgram();
        }

        private void ShowProgram()
        {
            using (RegistryKey currentUserKey = Registry.CurrentUser)
            {
                RegistryKey software = currentUserKey.OpenSubKey("Software");
                RegistryKey microsoft = software.OpenSubKey("Microsoft");
                RegistryKey windows = microsoft.OpenSubKey("Windows");
                RegistryKey currentVersion = windows.OpenSubKey("CurrentVersion");
                RegistryKey run = currentVersion.OpenSubKey("Run");

                string pathRun = @"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Run";
                OpenPathSubKey(pathRun);

                //Console.WriteLine(currentUserKey);

                //foreach (var item in run.GetValueNames())
                //{
                //    listBox.Items.Add(item);
                //}
            }
        }

        private void OpenPathSubKey(string pathSubKey)
        {
            string HK = pathSubKey.Substring(0, pathSubKey.IndexOf('\\'));
            RegistryKey key = GetHKRegistryKey(HK);

            foreach (var item in pathSubKey.Substring(pathSubKey.IndexOf('\\')).Split('\\'))
            {
                key = key.OpenSubKey(item);
            }

            Console.WriteLine(key.ValueCount);
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
    }
}
