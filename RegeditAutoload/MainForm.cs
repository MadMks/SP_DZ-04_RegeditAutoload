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

                Console.WriteLine(run.ValueCount);

                foreach (var item in run.GetValueNames())
                {
                    listBox.Items.Add(item);
                }
            }
        }
    }
}
