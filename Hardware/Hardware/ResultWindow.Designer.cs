namespace Hardware
{
    partial class ResultWindow
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
            this.MainPanel = new System.Windows.Forms.Panel();
            this.BackButton = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.Title = new System.Windows.Forms.TextBox();
            this.correctRes = new System.Windows.Forms.TextBox();
            this.incorrectRes = new System.Windows.Forms.TextBox();
            this.incor = new System.Windows.Forms.TextBox();
            this.cor = new System.Windows.Forms.TextBox();
            this.TitleProc = new System.Windows.Forms.TextBox();
            this.proc = new System.Windows.Forms.TextBox();
            this.MainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainPanel.Controls.Add(this.proc);
            this.MainPanel.Controls.Add(this.TitleProc);
            this.MainPanel.Controls.Add(this.incorrectRes);
            this.MainPanel.Controls.Add(this.correctRes);
            this.MainPanel.Controls.Add(this.Title);
            this.MainPanel.Controls.Add(this.incor);
            this.MainPanel.Controls.Add(this.cor);
            this.MainPanel.Location = new System.Drawing.Point(13, 13);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(344, 271);
            this.MainPanel.TabIndex = 0;
            // 
            // BackButton
            // 
            this.BackButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BackButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(68)))));
            this.BackButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BackButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BackButton.Location = new System.Drawing.Point(125, 290);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(135, 30);
            this.BackButton.TabIndex = 0;
            this.BackButton.Text = "Назад";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // Title
            // 
            this.Title.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(74)))));
            this.Title.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Title.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Title.ForeColor = System.Drawing.SystemColors.Window;
            this.Title.Location = new System.Drawing.Point(3, 3);
            this.Title.Multiline = true;
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            this.Title.Size = new System.Drawing.Size(338, 76);
            this.Title.TabIndex = 1;
            this.Title.Text = "Поздравляю";
            this.Title.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // correctRes
            // 
            this.correctRes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(74)))));
            this.correctRes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.correctRes.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.correctRes.ForeColor = System.Drawing.SystemColors.Window;
            this.correctRes.Location = new System.Drawing.Point(10, 85);
            this.correctRes.Multiline = true;
            this.correctRes.Name = "correctRes";
            this.correctRes.ReadOnly = true;
            this.correctRes.Size = new System.Drawing.Size(227, 57);
            this.correctRes.TabIndex = 2;
            this.correctRes.Text = "Количество верных ответов:";
            this.correctRes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // incorrectRes
            // 
            this.incorrectRes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(74)))));
            this.incorrectRes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.incorrectRes.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.incorrectRes.ForeColor = System.Drawing.SystemColors.Window;
            this.incorrectRes.Location = new System.Drawing.Point(24, 148);
            this.incorrectRes.Multiline = true;
            this.incorrectRes.Name = "incorrectRes";
            this.incorrectRes.ReadOnly = true;
            this.incorrectRes.Size = new System.Drawing.Size(226, 57);
            this.incorrectRes.TabIndex = 3;
            this.incorrectRes.Text = "Количество неверных ответов:";
            this.incorrectRes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // incor
            // 
            this.incor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(74)))));
            this.incor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.incor.Font = new System.Drawing.Font("Tahoma", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.incor.ForeColor = System.Drawing.Color.Red;
            this.incor.Location = new System.Drawing.Point(249, 144);
            this.incor.Multiline = true;
            this.incor.Name = "incor";
            this.incor.ReadOnly = true;
            this.incor.Size = new System.Drawing.Size(53, 61);
            this.incor.TabIndex = 4;
            this.incor.Text = "5";
            this.incor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cor
            // 
            this.cor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(74)))));
            this.cor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cor.Font = new System.Drawing.Font("Tahoma", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cor.ForeColor = System.Drawing.Color.Lime;
            this.cor.Location = new System.Drawing.Point(243, 84);
            this.cor.Multiline = true;
            this.cor.Name = "cor";
            this.cor.ReadOnly = true;
            this.cor.Size = new System.Drawing.Size(59, 58);
            this.cor.TabIndex = 5;
            this.cor.Text = "5";
            this.cor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TitleProc
            // 
            this.TitleProc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(74)))));
            this.TitleProc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TitleProc.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TitleProc.ForeColor = System.Drawing.SystemColors.Window;
            this.TitleProc.Location = new System.Drawing.Point(10, 219);
            this.TitleProc.Multiline = true;
            this.TitleProc.Name = "TitleProc";
            this.TitleProc.ReadOnly = true;
            this.TitleProc.Size = new System.Drawing.Size(227, 33);
            this.TitleProc.TabIndex = 6;
            this.TitleProc.Text = "Усовено знаний на:";
            this.TitleProc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // proc
            // 
            this.proc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(74)))));
            this.proc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.proc.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.proc.ForeColor = System.Drawing.SystemColors.Window;
            this.proc.Location = new System.Drawing.Point(243, 219);
            this.proc.Multiline = true;
            this.proc.Name = "proc";
            this.proc.ReadOnly = true;
            this.proc.Size = new System.Drawing.Size(73, 33);
            this.proc.TabIndex = 7;
            this.proc.Text = "100%";
            this.proc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ResultWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(370, 328);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.MainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ResultWindow";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ResultWindow";
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.TextBox proc;
        private System.Windows.Forms.TextBox TitleProc;
        private System.Windows.Forms.TextBox incorrectRes;
        private System.Windows.Forms.TextBox correctRes;
        private System.Windows.Forms.TextBox Title;
        private System.Windows.Forms.TextBox incor;
        private System.Windows.Forms.TextBox cor;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}