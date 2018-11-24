using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegeditAutoload.Forms
{
    public partial class AddForm : Form
    {
        public string Parameter
        {
            get { return textBoxParameter.Text; }
        }
        public string Value
        {
            get { return textBoxValue.Text; }
        }

        public AddForm()
        {
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            if (textBoxParameter.Text.Length != 0
                && textBoxValue.Text.Length != 0)
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Нужно заполнить все поля!");
            }
        }

        private void buttonOverview_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                textBoxValue.Text = openFileDialog.FileName;
            }
        }
    }
}
