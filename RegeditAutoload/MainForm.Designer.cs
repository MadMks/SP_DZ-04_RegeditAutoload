namespace RegeditAutoload
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonUpgrade = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.comboBoxWays = new System.Windows.Forms.ComboBox();
            this.labelSectionSelection = new System.Windows.Forms.Label();
            this.listView = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // buttonUpgrade
            // 
            this.buttonUpgrade.Location = new System.Drawing.Point(507, 12);
            this.buttonUpgrade.Name = "buttonUpgrade";
            this.buttonUpgrade.Size = new System.Drawing.Size(75, 39);
            this.buttonUpgrade.TabIndex = 1;
            this.buttonUpgrade.Text = "Обновить";
            this.buttonUpgrade.UseVisualStyleBackColor = true;
            this.buttonUpgrade.Click += new System.EventHandler(this.buttonUpgrade_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(507, 71);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 39);
            this.buttonAdd.TabIndex = 2;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(507, 124);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 39);
            this.buttonDelete.TabIndex = 3;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // comboBoxWays
            // 
            this.comboBoxWays.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxWays.FormattingEnabled = true;
            this.comboBoxWays.Location = new System.Drawing.Point(12, 28);
            this.comboBoxWays.Name = "comboBoxWays";
            this.comboBoxWays.Size = new System.Drawing.Size(475, 21);
            this.comboBoxWays.TabIndex = 4;
            // 
            // labelSectionSelection
            // 
            this.labelSectionSelection.AutoSize = true;
            this.labelSectionSelection.Location = new System.Drawing.Point(15, 8);
            this.labelSectionSelection.Name = "labelSectionSelection";
            this.labelSectionSelection.Size = new System.Drawing.Size(88, 13);
            this.labelSectionSelection.TabIndex = 6;
            this.labelSectionSelection.Text = "Выбор раздела:";
            // 
            // listView
            // 
            this.listView.Location = new System.Drawing.Point(13, 64);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(474, 106);
            this.listView.TabIndex = 7;
            this.listView.UseCompatibleStateImageBehavior = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 184);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.labelSectionSelection);
            this.Controls.Add(this.comboBoxWays);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonUpgrade);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Настройка автозагрузки";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonUpgrade;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.ComboBox comboBoxWays;
        private System.Windows.Forms.Label labelSectionSelection;
        private System.Windows.Forms.ListView listView;
    }
}

