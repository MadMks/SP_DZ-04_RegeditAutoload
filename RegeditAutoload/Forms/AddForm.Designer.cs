namespace RegeditAutoload.Forms
{
    partial class AddForm
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
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.textBoxParameter = new System.Windows.Forms.TextBox();
            this.textBoxValue = new System.Windows.Forms.TextBox();
            this.buttonOverview = new System.Windows.Forms.Button();
            this.groupBoxParameter = new System.Windows.Forms.GroupBox();
            this.groupBoxValue = new System.Windows.Forms.GroupBox();
            this.groupBoxParameter.SuspendLayout();
            this.groupBoxValue.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(60, 195);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(95, 33);
            this.buttonOk.TabIndex = 0;
            this.buttonOk.Text = "Записать";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(196, 195);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(95, 33);
            this.buttonCancel.TabIndex = 1;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // textBoxParameter
            // 
            this.textBoxParameter.Location = new System.Drawing.Point(14, 24);
            this.textBoxParameter.MaxLength = 20;
            this.textBoxParameter.Name = "textBoxParameter";
            this.textBoxParameter.Size = new System.Drawing.Size(249, 21);
            this.textBoxParameter.TabIndex = 2;
            // 
            // textBoxValue
            // 
            this.textBoxValue.Location = new System.Drawing.Point(14, 23);
            this.textBoxValue.MaxLength = 16383;
            this.textBoxValue.Name = "textBoxValue";
            this.textBoxValue.Size = new System.Drawing.Size(299, 21);
            this.textBoxValue.TabIndex = 3;
            // 
            // buttonOverview
            // 
            this.buttonOverview.Location = new System.Drawing.Point(238, 52);
            this.buttonOverview.Name = "buttonOverview";
            this.buttonOverview.Size = new System.Drawing.Size(75, 23);
            this.buttonOverview.TabIndex = 6;
            this.buttonOverview.Text = "Обзор";
            this.buttonOverview.UseVisualStyleBackColor = true;
            this.buttonOverview.Click += new System.EventHandler(this.buttonOverview_Click);
            // 
            // groupBoxParameter
            // 
            this.groupBoxParameter.Controls.Add(this.textBoxParameter);
            this.groupBoxParameter.Location = new System.Drawing.Point(12, 12);
            this.groupBoxParameter.Name = "groupBoxParameter";
            this.groupBoxParameter.Size = new System.Drawing.Size(331, 59);
            this.groupBoxParameter.TabIndex = 7;
            this.groupBoxParameter.TabStop = false;
            this.groupBoxParameter.Text = "Параметр";
            // 
            // groupBoxValue
            // 
            this.groupBoxValue.Controls.Add(this.textBoxValue);
            this.groupBoxValue.Controls.Add(this.buttonOverview);
            this.groupBoxValue.Location = new System.Drawing.Point(12, 91);
            this.groupBoxValue.Name = "groupBoxValue";
            this.groupBoxValue.Size = new System.Drawing.Size(331, 88);
            this.groupBoxValue.TabIndex = 8;
            this.groupBoxValue.TabStop = false;
            this.groupBoxValue.Text = "Значение";
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 245);
            this.Controls.Add(this.groupBoxValue);
            this.Controls.Add(this.groupBoxParameter);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AddForm";
            this.Text = "Добавление параметра";
            this.groupBoxParameter.ResumeLayout(false);
            this.groupBoxParameter.PerformLayout();
            this.groupBoxValue.ResumeLayout(false);
            this.groupBoxValue.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.TextBox textBoxParameter;
        private System.Windows.Forms.TextBox textBoxValue;
        private System.Windows.Forms.Button buttonOverview;
        private System.Windows.Forms.GroupBox groupBoxParameter;
        private System.Windows.Forms.GroupBox groupBoxValue;
    }
}