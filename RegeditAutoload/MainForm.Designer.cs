﻿namespace RegeditAutoload
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
            this.listBox = new System.Windows.Forms.ListBox();
            this.buttonUpgrade = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.comboBoxWays = new System.Windows.Forms.ComboBox();
            this.buttonYourSection = new System.Windows.Forms.Button();
            this.labelSectionSelection = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(12, 64);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(333, 160);
            this.listBox.TabIndex = 0;
            // 
            // buttonUpgrade
            // 
            this.buttonUpgrade.Location = new System.Drawing.Point(362, 64);
            this.buttonUpgrade.Name = "buttonUpgrade";
            this.buttonUpgrade.Size = new System.Drawing.Size(75, 23);
            this.buttonUpgrade.TabIndex = 1;
            this.buttonUpgrade.Text = "Обновить";
            this.buttonUpgrade.UseVisualStyleBackColor = true;
            this.buttonUpgrade.Click += new System.EventHandler(this.buttonUpgrade_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(362, 128);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 2;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(362, 198);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 3;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = true;
            // 
            // comboBoxWays
            // 
            this.comboBoxWays.FormattingEnabled = true;
            this.comboBoxWays.Location = new System.Drawing.Point(12, 28);
            this.comboBoxWays.Name = "comboBoxWays";
            this.comboBoxWays.Size = new System.Drawing.Size(333, 21);
            this.comboBoxWays.TabIndex = 4;
            // 
            // buttonYourSection
            // 
            this.buttonYourSection.Location = new System.Drawing.Point(362, 12);
            this.buttonYourSection.Name = "buttonYourSection";
            this.buttonYourSection.Size = new System.Drawing.Size(75, 39);
            this.buttonYourSection.TabIndex = 5;
            this.buttonYourSection.Text = "Свой раздел";
            this.buttonYourSection.UseVisualStyleBackColor = true;
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 236);
            this.Controls.Add(this.labelSectionSelection);
            this.Controls.Add(this.buttonYourSection);
            this.Controls.Add(this.comboBoxWays);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonUpgrade);
            this.Controls.Add(this.listBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Настройка автозагрузки";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Button buttonUpgrade;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.ComboBox comboBoxWays;
        private System.Windows.Forms.Button buttonYourSection;
        private System.Windows.Forms.Label labelSectionSelection;
    }
}

