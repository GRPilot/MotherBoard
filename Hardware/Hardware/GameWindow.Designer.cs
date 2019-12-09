namespace Hardware
{
    partial class GameWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameWindow));
            this.BackButton = new System.Windows.Forms.Button();
            this.PictureMB = new System.Windows.Forms.Panel();
            this.BiosPan = new System.Windows.Forms.Panel();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.PictureMB.SuspendLayout();
            this.MainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // BackButton
            // 
            this.BackButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BackButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackButton.ForeColor = System.Drawing.SystemColors.Control;
            this.BackButton.Location = new System.Drawing.Point(15, 551);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(92, 23);
            this.BackButton.TabIndex = 1;
            this.BackButton.Text = "Назад";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // PictureMB
            // 
            this.PictureMB.AllowDrop = true;
            this.PictureMB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PictureMB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(74)))));
            this.PictureMB.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PictureMB.BackgroundImage")));
            this.PictureMB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PictureMB.Controls.Add(this.BiosPan);
            this.PictureMB.Location = new System.Drawing.Point(0, 0);
            this.PictureMB.Name = "PictureMB";
            this.PictureMB.Size = new System.Drawing.Size(653, 538);
            this.PictureMB.TabIndex = 2;
            // 
            // BiosPan
            // 
            this.BiosPan.AllowDrop = true;
            this.BiosPan.BackColor = System.Drawing.Color.Silver;
            this.BiosPan.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BiosPan.BackgroundImage")));
            this.BiosPan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BiosPan.Location = new System.Drawing.Point(212, 337);
            this.BiosPan.Name = "BiosPan";
            this.BiosPan.Size = new System.Drawing.Size(109, 91);
            this.BiosPan.TabIndex = 3;
            this.BiosPan.DragEnter += new System.Windows.Forms.DragEventHandler(this.BiosPan_DragEnter);
            this.BiosPan.MouseEnter += new System.EventHandler(this.BiosPan_MouseEnter);
            this.BiosPan.MouseLeave += new System.EventHandler(this.BiosPan_MouseLeave);
            // 
            // MainPanel
            // 
            this.MainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainPanel.Controls.Add(this.PictureMB);
            this.MainPanel.Location = new System.Drawing.Point(6, 7);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Padding = new System.Windows.Forms.Padding(3);
            this.MainPanel.Size = new System.Drawing.Size(1109, 538);
            this.MainPanel.TabIndex = 3;
            // 
            // GameWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(1121, 585);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.MainPanel);
            this.MinimumSize = new System.Drawing.Size(1000, 500);
            this.Name = "GameWindow";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.Text = "GameWindow";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GameWindow_FormClosing);
            this.SizeChanged += new System.EventHandler(this.GameWindow_SizeChanged);
            this.PictureMB.ResumeLayout(false);
            this.MainPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Panel PictureMB;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Panel BiosPan;
    }
}