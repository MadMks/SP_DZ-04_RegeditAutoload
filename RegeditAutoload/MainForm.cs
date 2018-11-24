using Microsoft.Win32;
using RegeditAutoload.Forms;
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
        private List<RegistryKey> registryKeysOpen = null;

        string[] keyPaths = null;

        public MainForm()
        {
            InitializeComponent();

            Load += MainForm_Load;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            registryKeysOpen = new List<RegistryKey>();

            CreatingKeyPath();
            comboBoxWays.Items.AddRange(keyPaths);
            comboBoxWays.SelectedIndex = 0;

            ListviewSetting();

            DisableDelButtons();

            registryKey = GetLastSubKeyInPath(comboBoxWays.SelectedItem.ToString());
            ShowPrograms(registryKey);
            

            listView.ItemSelectionChanged += ListView_ItemSelectionChanged;
            this.FormClosing += MainForm_FormClosing;
            comboBoxWays.SelectedIndexChanged += ComboBoxWays_SelectedIndexChanged;
        }

        private void CreatingKeyPath()
        {
            keyPaths = new string[]
            {
                @"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Run",
                @"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Run",
                @"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\RunOnce",
                @"HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\RunOnce"
            };
        }

        private void ListView_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (listView.SelectedItems.Count == 0)
            {
                DisableDelButtons();
            }
            else
            {
                EnableDelButtons();
            }
        }

        private void ListviewSetting()
        {
            listView.View = View.Details;
            listView.FullRowSelect = true;
            listView.MultiSelect = false;

            listView.Columns.Add("Параметр", 100);
            listView.Columns.Add("Значение", 370);
        }

        private void ComboBoxWays_SelectedIndexChanged(object sender, EventArgs e)
        {
            CloseAllSubKey();
            
            registryKey = GetLastSubKeyInPath(comboBoxWays.SelectedItem.ToString());
            ShowPrograms(registryKey);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CloseAllSubKey();
        }

        private void CloseAllSubKey()
        {
            if (registryKeysOpen.Count > 0)
            {
                this.registryKeysOpen.Reverse();
                foreach (var item in registryKeysOpen)
                {
                    item.Close();
                }
            }
        }
        
        private void DisableDelButtons()
        {
            buttonDelete.Enabled = false;
        }

        private void EnableDelButtons()
        {
            buttonDelete.Enabled = true;
        }

        private void ShowPrograms(RegistryKey key)
        {
            listView.Items.Clear();

            if (key != null)
            {
                foreach (string parameter in key.GetValueNames())
                {
                    ListViewItem listViewItem = new ListViewItem(parameter);
                    listViewItem.SubItems.Add(
                        key.GetValue(parameter).ToString()
                        );

                    listView.Items.Add(listViewItem);
                }
            }
            else
            {
                MessageBox.Show("Указанного раздела не существует.",
                    "Ошибка открытия раздела",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
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

            try
            {
                registryKeysOpen.Clear();
                
                foreach (var item in path.Split('\\'))
                {
                    key = key.OpenSubKey(item, true);
                    registryKeysOpen.Add(key);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Невозможно открыть раздел.\n"
                    + ex.Message,
                    "Ошибка в имени раздела",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return null;
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
                    MessageBox.Show("Неправильное имя основного раздела!",
                        "Ошибка открытия раздела",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return Registry.CurrentUser;
            }
        }

        private void buttonUpgrade_Click(object sender, EventArgs e)
        {
            DisableDelButtons();

            ShowPrograms(registryKey);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            AddForm addForm = new AddForm();
            
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                registryKey.SetValue(
                    addForm.Parameter,
                    addForm.Value
                    );

                ShowPrograms(registryKey);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (listView.SelectedItems.Count != 0)
            {
                registryKey.DeleteValue(listView.SelectedItems[0].Text);
            }
            
            ShowPrograms(registryKey);
        }
    }
}
