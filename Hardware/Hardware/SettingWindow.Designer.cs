namespace Hardware
{
    partial class SettingWindow
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
            this.BackButton = new System.Windows.Forms.Button();
            this.BackPanel = new System.Windows.Forms.Panel();
            this.DesignLabel = new System.Windows.Forms.Label();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.ChangeColorButton = new System.Windows.Forms.Button();
            this.BackPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackButton.ForeColor = System.Drawing.SystemColors.Control;
            this.BackButton.Location = new System.Drawing.Point(3, 210);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(75, 23);
            this.BackButton.TabIndex = 0;
            this.BackButton.Text = "Назад";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // BackPanel
            // 
            this.BackPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BackPanel.Controls.Add(this.ChangeColorButton);
            this.BackPanel.Controls.Add(this.TitleLabel);
            this.BackPanel.Controls.Add(this.DesignLabel);
            this.BackPanel.Controls.Add(this.BackButton);
            this.BackPanel.Location = new System.Drawing.Point(13, 13);
            this.BackPanel.Name = "BackPanel";
            this.BackPanel.Size = new System.Drawing.Size(259, 236);
            this.BackPanel.TabIndex = 1;
            // 
            // DesignLabel
            // 
            this.DesignLabel.AutoSize = true;
            this.DesignLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DesignLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.DesignLabel.Location = new System.Drawing.Point(3, 52);
            this.DesignLabel.Name = "DesignLabel";
            this.DesignLabel.Size = new System.Drawing.Size(155, 20);
            this.DesignLabel.TabIndex = 1;
            this.DesignLabel.Text = "Цвет оформления:";
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TitleLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.TitleLabel.Location = new System.Drawing.Point(38, 0);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(191, 39);
            this.TitleLabel.TabIndex = 2;
            this.TitleLabel.Text = "Настройки";
            // 
            // ChangeColorButton
            // 
            this.ChangeColorButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.ChangeColorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChangeColorButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangeColorButton.ForeColor = System.Drawing.SystemColors.Control;
            this.ChangeColorButton.Location = new System.Drawing.Point(161, 52);
            this.ChangeColorButton.Margin = new System.Windows.Forms.Padding(0);
            this.ChangeColorButton.Name = "ChangeColorButton";
            this.ChangeColorButton.Size = new System.Drawing.Size(90, 23);
            this.ChangeColorButton.TabIndex = 3;
            this.ChangeColorButton.Text = "Светлый";
            this.ChangeColorButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ChangeColorButton.UseVisualStyleBackColor = false;
            this.ChangeColorButton.Click += new System.EventHandler(this.ChangeColorButton_Click);
            // 
            // SettingWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.BackPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(300, 300);
            this.Name = "SettingWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SettingWindow";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SettingWindow_FormClosing);
            this.BackPanel.ResumeLayout(false);
            this.BackPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Panel BackPanel;
        private System.Windows.Forms.Button ChangeColorButton;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label DesignLabel;
    }
}