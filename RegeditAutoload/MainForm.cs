﻿using Microsoft.Win32;
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

        private List<RegistryKey> registryKeysOpen = null;

        public MainForm()
        {
            InitializeComponent();

            Load += MainForm_Load;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            registryKeysOpen = new List<RegistryKey>();

            ListviewSetting();

            DisableButtons();

            registryKey = GetLastSubKeyInPath(pathRun);

            ShowPrograms(registryKey);

            //listBox.SelectedIndexChanged += ListBox_SelectedIndexChanged;
            listView.ItemSelectionChanged += ListView_ItemSelectionChanged;
            this.FormClosing += MainForm_FormClosing;
            // TODO: при изменение пути комбоБокса - закрывать предыдущий ключ
            comboBoxWays.SelectedIndexChanged += ComboBoxWays_SelectedIndexChanged;

            //RegistryKey software = currentUserKey.OpenSubKey("Software");
            //RegistryKey microsoft = software.OpenSubKey("Microsoft");
            //RegistryKey windows = microsoft.OpenSubKey("Windows");
            //RegistryKey currentVersion = windows.OpenSubKey("CurrentVersion");
            //RegistryKey run = currentVersion.OpenSubKey("Run");
        }

        private void ListView_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (listView.SelectedItems.Count == 0)
            {
                DisableButtons();
            }
            else
            {
                EnableButtons();
            }
        }

        private void ListviewSetting()
        {
            listView.View = View.Details;
            listView.FullRowSelect = true;
            listView.MultiSelect = false;

            listView.Columns.Add("Параметр", 100);
            listView.Columns.Add("Значение", 200);
        }

        private void ComboBoxWays_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Закрываем открытый ключ.
            registryKey.Close();

            // TODO: проработать получение из комбо
            // Получаем новый ключ по выбрвнному пути.
            //registryKey = GetLastSubKeyInPath(item in combo)
            //ShowPrograms(registryKey);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CloseAllSubKey();
        }

        private void CloseAllSubKey()
        {
            this.registryKeysOpen.Reverse();
            foreach (var item in registryKeysOpen)
            {
                item.Close();
            }
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
            listView.Items.Clear();

            if (key != null)
            {
                foreach (var item in key.GetValueNames())
                {
                    listBox.Items.Add(item + " : " + key.GetValue(item));

                    ListViewItem listViewItem = new ListViewItem(item);
                    listViewItem.SubItems.Add(
                        (key.GetValue(item) as string)
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
            DisableButtons();

            ShowPrograms(registryKey);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            //Console.WriteLine(registryKey.GetValueNames()[listBox.SelectedIndex]);
            //registryKey.DeleteValue(registryKey.GetValueNames()[listBox.SelectedIndex]);
            if (listView.SelectedItems.Count != 0)
            {
                Console.WriteLine("> " + listView.SelectedItems[0].Text);
                registryKey.DeleteValue(listView.SelectedItems[0].Text);
            }


            ShowPrograms(registryKey);
        }
    }
}
