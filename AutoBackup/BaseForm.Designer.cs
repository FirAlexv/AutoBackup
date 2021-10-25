namespace AutoBackup
{
    partial class BaseForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_OK = new System.Windows.Forms.Button();
            this.button_Path_Backup = new System.Windows.Forms.Button();
            this.textBox_Path_Backup = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button_Path_Source = new System.Windows.Forms.Button();
            this.textBox_Path_Source = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // button_OK
            // 
            this.button_OK.Location = new System.Drawing.Point(318, 156);
            this.button_OK.Name = "button_OK";
            this.button_OK.Size = new System.Drawing.Size(75, 23);
            this.button_OK.TabIndex = 13;
            this.button_OK.Text = "OK";
            this.button_OK.UseVisualStyleBackColor = true;
            this.button_OK.Click += new System.EventHandler(this.button_OK_Click);
            // 
            // button_Path_Backup
            // 
            this.button_Path_Backup.Location = new System.Drawing.Point(366, 110);
            this.button_Path_Backup.Name = "button_Path_Backup";
            this.button_Path_Backup.Size = new System.Drawing.Size(27, 23);
            this.button_Path_Backup.TabIndex = 12;
            this.button_Path_Backup.Text = "...";
            this.button_Path_Backup.UseVisualStyleBackColor = true;
            this.button_Path_Backup.Click += new System.EventHandler(this.button_Path_Backup_Click);
            // 
            // textBox_Path_Backup
            // 
            this.textBox_Path_Backup.Location = new System.Drawing.Point(110, 112);
            this.textBox_Path_Backup.Name = "textBox_Path_Backup";
            this.textBox_Path_Backup.Size = new System.Drawing.Size(250, 20);
            this.textBox_Path_Backup.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Руть к бэкапу";
            // 
            // button_Path_Source
            // 
            this.button_Path_Source.Location = new System.Drawing.Point(366, 36);
            this.button_Path_Source.Name = "button_Path_Source";
            this.button_Path_Source.Size = new System.Drawing.Size(27, 23);
            this.button_Path_Source.TabIndex = 9;
            this.button_Path_Source.Text = "...";
            this.button_Path_Source.UseVisualStyleBackColor = true;
            this.button_Path_Source.Click += new System.EventHandler(this.button_Path_Source_Click);
            // 
            // textBox_Path_Source
            // 
            this.textBox_Path_Source.Location = new System.Drawing.Point(110, 38);
            this.textBox_Path_Source.Name = "textBox_Path_Source";
            this.textBox_Path_Source.Size = new System.Drawing.Size(250, 20);
            this.textBox_Path_Source.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Руть ичтоника";
            // 
            // BaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 219);
            this.Controls.Add(this.button_OK);
            this.Controls.Add(this.button_Path_Backup);
            this.Controls.Add(this.textBox_Path_Backup);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_Path_Source);
            this.Controls.Add(this.textBox_Path_Source);
            this.Controls.Add(this.label1);
            this.Name = "BaseForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_OK;
        private System.Windows.Forms.Button button_Path_Backup;
        private System.Windows.Forms.TextBox textBox_Path_Backup;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_Path_Source;
        private System.Windows.Forms.TextBox textBox_Path_Source;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
    }
}

