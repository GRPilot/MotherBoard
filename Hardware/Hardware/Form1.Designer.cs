namespace Hardware
{
    partial class MainWindow
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
            this.StartButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SettingButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // StartButton
            // 
            this.StartButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.StartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartButton.ForeColor = System.Drawing.SystemColors.Control;
            this.StartButton.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.StartButton.Location = new System.Drawing.Point(74, 196);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(167, 40);
            this.StartButton.TabIndex = 0;
            this.StartButton.Text = "Начать игру";
            this.StartButton.UseVisualStyleBackColor = false;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ExitButton);
            this.panel1.Controls.Add(this.SettingButton);
            this.panel1.Controls.Add(this.StartButton);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(309, 336);
            this.panel1.TabIndex = 1;
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.ForeColor = System.Drawing.SystemColors.Control;
            this.ExitButton.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.ExitButton.Location = new System.Drawing.Point(74, 287);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(167, 40);
            this.ExitButton.TabIndex = 2;
            this.ExitButton.Text = "Выход";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // SettingButton
            // 
            this.SettingButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.SettingButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SettingButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingButton.ForeColor = System.Drawing.SystemColors.Control;
            this.SettingButton.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.SettingButton.Location = new System.Drawing.Point(74, 242);
            this.SettingButton.Name = "SettingButton";
            this.SettingButton.Size = new System.Drawing.Size(167, 40);
            this.SettingButton.TabIndex = 1;
            this.SettingButton.Text = "Настройки";
            this.SettingButton.UseVisualStyleBackColor = false;
            this.SettingButton.Click += new System.EventHandler(this.SettingButton_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(334, 361);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(350, 400);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hardware";
            this.VisibleChanged += new System.EventHandler(this.MainWindow_VisibleChanged);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button SettingButton;
        private System.Windows.Forms.Button ExitButton;
    }
}

