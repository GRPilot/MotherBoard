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
            this.MotherBoardPicture = new System.Windows.Forms.PictureBox();
            this.BackButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MotherBoardPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // MotherBoardPicture
            // 
            this.MotherBoardPicture.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MotherBoardPicture.Image = ((System.Drawing.Image)(resources.GetObject("MotherBoardPicture.Image")));
            this.MotherBoardPicture.Location = new System.Drawing.Point(12, 12);
            this.MotherBoardPicture.MinimumSize = new System.Drawing.Size(680, 550);
            this.MotherBoardPicture.Name = "MotherBoardPicture";
            this.MotherBoardPicture.Size = new System.Drawing.Size(680, 550);
            this.MotherBoardPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MotherBoardPicture.TabIndex = 0;
            this.MotherBoardPicture.TabStop = false;
            // 
            // BackButton
            // 
            this.BackButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BackButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackButton.ForeColor = System.Drawing.SystemColors.Control;
            this.BackButton.Location = new System.Drawing.Point(12, 577);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(92, 23);
            this.BackButton.TabIndex = 1;
            this.BackButton.Text = "Назад";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // GameWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(999, 612);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.MotherBoardPicture);
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "GameWindow";
            this.Text = "GameWindow";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GameWindow_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.MotherBoardPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox MotherBoardPicture;
        private System.Windows.Forms.Button BackButton;
    }
}