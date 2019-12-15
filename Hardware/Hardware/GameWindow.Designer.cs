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
            this.MainPanel = new System.Windows.Forms.Panel();
            this.PictureMB = new System.Windows.Forms.Panel();
            this.SataPicture = new System.Windows.Forms.Panel();
            this.ICHPicture = new System.Windows.Forms.Panel();
            this.BIOSPicture = new System.Windows.Forms.Panel();
            this.CMOSPowPicture = new System.Windows.Forms.Panel();
            this.IE1394Picture = new System.Windows.Forms.Panel();
            this.USBPicture = new System.Windows.Forms.Panel();
            this.PataPicture = new System.Windows.Forms.Panel();
            this.PCI1Picture = new System.Windows.Forms.Panel();
            this.PCI_Ex16Picture = new System.Windows.Forms.Panel();
            this.SuperIOPicture = new System.Windows.Forms.Panel();
            this.CDPicture = new System.Windows.Forms.Panel();
            this.LanPicture = new System.Windows.Forms.Panel();
            this.VGA_DVIPicture = new System.Windows.Forms.Panel();
            this.PCI_Ex1Picture = new System.Windows.Forms.Panel();
            this.MCHPicture = new System.Windows.Forms.Panel();
            this.PowerPicture = new System.Windows.Forms.Panel();
            this.DDR2Picture = new System.Windows.Forms.Panel();
            this.SocetPicture = new System.Windows.Forms.Panel();
            this.AudioPicture = new System.Windows.Forms.Panel();
            this.MainPanel.SuspendLayout();
            this.PictureMB.SuspendLayout();
            this.SuspendLayout();
            // 
            // BackButton
            // 
            this.BackButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BackButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BackButton.ForeColor = System.Drawing.SystemColors.Control;
            this.BackButton.Location = new System.Drawing.Point(6, 627);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(102, 28);
            this.BackButton.TabIndex = 1;
            this.BackButton.Text = "Назад";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
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
            this.MainPanel.Size = new System.Drawing.Size(1172, 614);
            this.MainPanel.TabIndex = 3;
            // 
            // PictureMB
            // 
            this.PictureMB.AllowDrop = true;
            this.PictureMB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PictureMB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(74)))));
            this.PictureMB.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PictureMB.BackgroundImage")));
            this.PictureMB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PictureMB.Controls.Add(this.SataPicture);
            this.PictureMB.Controls.Add(this.ICHPicture);
            this.PictureMB.Controls.Add(this.BIOSPicture);
            this.PictureMB.Controls.Add(this.CMOSPowPicture);
            this.PictureMB.Controls.Add(this.IE1394Picture);
            this.PictureMB.Controls.Add(this.USBPicture);
            this.PictureMB.Controls.Add(this.PataPicture);
            this.PictureMB.Controls.Add(this.PCI1Picture);
            this.PictureMB.Controls.Add(this.PCI_Ex16Picture);
            this.PictureMB.Controls.Add(this.SuperIOPicture);
            this.PictureMB.Controls.Add(this.CDPicture);
            this.PictureMB.Controls.Add(this.LanPicture);
            this.PictureMB.Controls.Add(this.VGA_DVIPicture);
            this.PictureMB.Controls.Add(this.PCI_Ex1Picture);
            this.PictureMB.Controls.Add(this.MCHPicture);
            this.PictureMB.Controls.Add(this.PowerPicture);
            this.PictureMB.Controls.Add(this.DDR2Picture);
            this.PictureMB.Controls.Add(this.SocetPicture);
            this.PictureMB.Location = new System.Drawing.Point(0, 0);
            this.PictureMB.Name = "PictureMB";
            this.PictureMB.Size = new System.Drawing.Size(769, 614);
            this.PictureMB.TabIndex = 2;
            // 
            // SataPicture
            // 
            this.SataPicture.AllowDrop = true;
            this.SataPicture.BackgroundImage = global::Hardware.Properties.Resources.SATA2;
            this.SataPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SataPicture.Location = new System.Drawing.Point(9, 366);
            this.SataPicture.Name = "SataPicture";
            this.SataPicture.Size = new System.Drawing.Size(63, 165);
            this.SataPicture.TabIndex = 17;
            this.SataPicture.DragDrop += new System.Windows.Forms.DragEventHandler(this.Picture_DragDrop);
            this.SataPicture.DragEnter += new System.Windows.Forms.DragEventHandler(this.Picture_DragEnter);
            this.SataPicture.DragLeave += new System.EventHandler(this.Picture_DragLeave);
            this.SataPicture.MouseEnter += new System.EventHandler(this.Element_MouseEnter);
            this.SataPicture.MouseLeave += new System.EventHandler(this.Element_MouseLeave);
            // 
            // ICHPicture
            // 
            this.ICHPicture.AllowDrop = true;
            this.ICHPicture.BackgroundImage = global::Hardware.Properties.Resources._ICH;
            this.ICHPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ICHPicture.Location = new System.Drawing.Point(113, 426);
            this.ICHPicture.Name = "ICHPicture";
            this.ICHPicture.Size = new System.Drawing.Size(69, 94);
            this.ICHPicture.TabIndex = 16;
            this.ICHPicture.DragDrop += new System.Windows.Forms.DragEventHandler(this.Picture_DragDrop);
            this.ICHPicture.DragEnter += new System.Windows.Forms.DragEventHandler(this.Picture_DragEnter);
            this.ICHPicture.DragLeave += new System.EventHandler(this.Picture_DragLeave);
            this.ICHPicture.MouseEnter += new System.EventHandler(this.Element_MouseEnter);
            this.ICHPicture.MouseLeave += new System.EventHandler(this.Element_MouseLeave);
            // 
            // BIOSPicture
            // 
            this.BIOSPicture.AllowDrop = true;
            this.BIOSPicture.BackgroundImage = global::Hardware.Properties.Resources._BIOS;
            this.BIOSPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BIOSPicture.Location = new System.Drawing.Point(202, 427);
            this.BIOSPicture.Name = "BIOSPicture";
            this.BIOSPicture.Size = new System.Drawing.Size(40, 50);
            this.BIOSPicture.TabIndex = 15;
            this.BIOSPicture.DragDrop += new System.Windows.Forms.DragEventHandler(this.Picture_DragDrop);
            this.BIOSPicture.DragEnter += new System.Windows.Forms.DragEventHandler(this.Picture_DragEnter);
            this.BIOSPicture.DragLeave += new System.EventHandler(this.Picture_DragLeave);
            this.BIOSPicture.MouseEnter += new System.EventHandler(this.Element_MouseEnter);
            this.BIOSPicture.MouseLeave += new System.EventHandler(this.Element_MouseLeave);
            // 
            // CMOSPowPicture
            // 
            this.CMOSPowPicture.AllowDrop = true;
            this.CMOSPowPicture.BackgroundImage = global::Hardware.Properties.Resources._CMOSPower;
            this.CMOSPowPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CMOSPowPicture.Location = new System.Drawing.Point(264, 381);
            this.CMOSPowPicture.Name = "CMOSPowPicture";
            this.CMOSPowPicture.Size = new System.Drawing.Size(100, 106);
            this.CMOSPowPicture.TabIndex = 14;
            this.CMOSPowPicture.DragDrop += new System.Windows.Forms.DragEventHandler(this.Picture_DragDrop);
            this.CMOSPowPicture.DragEnter += new System.Windows.Forms.DragEventHandler(this.Picture_DragEnter);
            this.CMOSPowPicture.DragLeave += new System.EventHandler(this.Picture_DragLeave);
            this.CMOSPowPicture.MouseEnter += new System.EventHandler(this.Element_MouseEnter);
            this.CMOSPowPicture.MouseLeave += new System.EventHandler(this.Element_MouseLeave);
            // 
            // IE1394Picture
            // 
            this.IE1394Picture.AllowDrop = true;
            this.IE1394Picture.BackgroundImage = global::Hardware.Properties.Resources._IE1394;
            this.IE1394Picture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.IE1394Picture.Location = new System.Drawing.Point(6, 111);
            this.IE1394Picture.Name = "IE1394Picture";
            this.IE1394Picture.Size = new System.Drawing.Size(33, 71);
            this.IE1394Picture.TabIndex = 13;
            this.IE1394Picture.DragDrop += new System.Windows.Forms.DragEventHandler(this.Picture_DragDrop);
            this.IE1394Picture.DragEnter += new System.Windows.Forms.DragEventHandler(this.Picture_DragEnter);
            this.IE1394Picture.DragLeave += new System.EventHandler(this.Picture_DragLeave);
            this.IE1394Picture.MouseEnter += new System.EventHandler(this.Element_MouseEnter);
            this.IE1394Picture.MouseLeave += new System.EventHandler(this.Element_MouseLeave);
            // 
            // USBPicture
            // 
            this.USBPicture.AllowDrop = true;
            this.USBPicture.BackgroundImage = global::Hardware.Properties.Resources._USB2;
            this.USBPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.USBPicture.Location = new System.Drawing.Point(7, 183);
            this.USBPicture.Name = "USBPicture";
            this.USBPicture.Size = new System.Drawing.Size(32, 133);
            this.USBPicture.TabIndex = 12;
            this.USBPicture.DragDrop += new System.Windows.Forms.DragEventHandler(this.Picture_DragDrop);
            this.USBPicture.DragEnter += new System.Windows.Forms.DragEventHandler(this.Picture_DragEnter);
            this.USBPicture.DragLeave += new System.EventHandler(this.Picture_DragLeave);
            this.USBPicture.MouseEnter += new System.EventHandler(this.Element_MouseEnter);
            this.USBPicture.MouseLeave += new System.EventHandler(this.Element_MouseLeave);
            // 
            // PataPicture
            // 
            this.PataPicture.AllowDrop = true;
            this.PataPicture.BackgroundImage = global::Hardware.Properties.Resources._Pata2;
            this.PataPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PataPicture.Location = new System.Drawing.Point(115, 538);
            this.PataPicture.Name = "PataPicture";
            this.PataPicture.Size = new System.Drawing.Size(263, 50);
            this.PataPicture.TabIndex = 11;
            this.PataPicture.DragDrop += new System.Windows.Forms.DragEventHandler(this.Picture_DragDrop);
            this.PataPicture.DragEnter += new System.Windows.Forms.DragEventHandler(this.Picture_DragEnter);
            this.PataPicture.DragLeave += new System.EventHandler(this.Picture_DragLeave);
            this.PataPicture.MouseEnter += new System.EventHandler(this.Element_MouseEnter);
            this.PataPicture.MouseLeave += new System.EventHandler(this.Element_MouseLeave);
            // 
            // PCI1Picture
            // 
            this.PCI1Picture.AllowDrop = true;
            this.PCI1Picture.BackgroundImage = global::Hardware.Properties.Resources._PCI1;
            this.PCI1Picture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PCI1Picture.Location = new System.Drawing.Point(115, 105);
            this.PCI1Picture.Name = "PCI1Picture";
            this.PCI1Picture.Size = new System.Drawing.Size(84, 275);
            this.PCI1Picture.TabIndex = 10;
            this.PCI1Picture.DragDrop += new System.Windows.Forms.DragEventHandler(this.Picture_DragDrop);
            this.PCI1Picture.DragEnter += new System.Windows.Forms.DragEventHandler(this.Picture_DragEnter);
            this.PCI1Picture.DragLeave += new System.EventHandler(this.Picture_DragLeave);
            this.PCI1Picture.MouseEnter += new System.EventHandler(this.Element_MouseEnter);
            this.PCI1Picture.MouseLeave += new System.EventHandler(this.Element_MouseLeave);
            // 
            // PCI_Ex16Picture
            // 
            this.PCI_Ex16Picture.AllowDrop = true;
            this.PCI_Ex16Picture.BackgroundImage = global::Hardware.Properties.Resources._PCI_Ex16;
            this.PCI_Ex16Picture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PCI_Ex16Picture.Location = new System.Drawing.Point(238, 142);
            this.PCI_Ex16Picture.Name = "PCI_Ex16Picture";
            this.PCI_Ex16Picture.Size = new System.Drawing.Size(40, 219);
            this.PCI_Ex16Picture.TabIndex = 9;
            this.PCI_Ex16Picture.DragDrop += new System.Windows.Forms.DragEventHandler(this.Picture_DragDrop);
            this.PCI_Ex16Picture.DragEnter += new System.Windows.Forms.DragEventHandler(this.Picture_DragEnter);
            this.PCI_Ex16Picture.DragLeave += new System.EventHandler(this.Picture_DragLeave);
            this.PCI_Ex16Picture.MouseEnter += new System.EventHandler(this.Element_MouseEnter);
            this.PCI_Ex16Picture.MouseLeave += new System.EventHandler(this.Element_MouseLeave);
            // 
            // SuperIOPicture
            // 
            this.SuperIOPicture.AllowDrop = true;
            this.SuperIOPicture.BackgroundImage = global::Hardware.Properties.Resources._superIO;
            this.SuperIOPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SuperIOPicture.Location = new System.Drawing.Point(72, 26);
            this.SuperIOPicture.Name = "SuperIOPicture";
            this.SuperIOPicture.Size = new System.Drawing.Size(66, 63);
            this.SuperIOPicture.TabIndex = 8;
            this.SuperIOPicture.DragDrop += new System.Windows.Forms.DragEventHandler(this.Picture_DragDrop);
            this.SuperIOPicture.DragEnter += new System.Windows.Forms.DragEventHandler(this.Picture_DragEnter);
            this.SuperIOPicture.DragLeave += new System.EventHandler(this.Picture_DragLeave);
            this.SuperIOPicture.MouseEnter += new System.EventHandler(this.Element_MouseEnter);
            this.SuperIOPicture.MouseLeave += new System.EventHandler(this.Element_MouseLeave);
            // 
            // CDPicture
            // 
            this.CDPicture.AllowDrop = true;
            this.CDPicture.BackgroundImage = global::Hardware.Properties.Resources._CD;
            this.CDPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CDPicture.Location = new System.Drawing.Point(302, 80);
            this.CDPicture.Name = "CDPicture";
            this.CDPicture.Size = new System.Drawing.Size(43, 65);
            this.CDPicture.TabIndex = 7;
            this.CDPicture.DragDrop += new System.Windows.Forms.DragEventHandler(this.Picture_DragDrop);
            this.CDPicture.DragEnter += new System.Windows.Forms.DragEventHandler(this.Picture_DragEnter);
            this.CDPicture.DragLeave += new System.EventHandler(this.Picture_DragLeave);
            this.CDPicture.MouseEnter += new System.EventHandler(this.Element_MouseEnter);
            this.CDPicture.MouseLeave += new System.EventHandler(this.Element_MouseLeave);
            // 
            // LanPicture
            // 
            this.LanPicture.AllowDrop = true;
            this.LanPicture.BackgroundImage = global::Hardware.Properties.Resources._LAN;
            this.LanPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LanPicture.Location = new System.Drawing.Point(462, 6);
            this.LanPicture.Name = "LanPicture";
            this.LanPicture.Size = new System.Drawing.Size(61, 39);
            this.LanPicture.TabIndex = 6;
            this.LanPicture.DragDrop += new System.Windows.Forms.DragEventHandler(this.Picture_DragDrop);
            this.LanPicture.DragEnter += new System.Windows.Forms.DragEventHandler(this.Picture_DragEnter);
            this.LanPicture.DragLeave += new System.EventHandler(this.Picture_DragLeave);
            this.LanPicture.MouseEnter += new System.EventHandler(this.Element_MouseEnter);
            this.LanPicture.MouseLeave += new System.EventHandler(this.Element_MouseLeave);
            // 
            // VGA_DVIPicture
            // 
            this.VGA_DVIPicture.AllowDrop = true;
            this.VGA_DVIPicture.BackgroundImage = global::Hardware.Properties.Resources._VGA_DVI;
            this.VGA_DVIPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.VGA_DVIPicture.Location = new System.Drawing.Point(600, 0);
            this.VGA_DVIPicture.Name = "VGA_DVIPicture";
            this.VGA_DVIPicture.Size = new System.Drawing.Size(99, 71);
            this.VGA_DVIPicture.TabIndex = 5;
            this.VGA_DVIPicture.DragDrop += new System.Windows.Forms.DragEventHandler(this.Picture_DragDrop);
            this.VGA_DVIPicture.DragEnter += new System.Windows.Forms.DragEventHandler(this.Picture_DragEnter);
            this.VGA_DVIPicture.DragLeave += new System.EventHandler(this.Picture_DragLeave);
            this.VGA_DVIPicture.MouseEnter += new System.EventHandler(this.Element_MouseEnter);
            this.VGA_DVIPicture.MouseLeave += new System.EventHandler(this.Element_MouseLeave);
            // 
            // PCI_Ex1Picture
            // 
            this.PCI_Ex1Picture.AllowDrop = true;
            this.PCI_Ex1Picture.BackgroundImage = global::Hardware.Properties.Resources._PCI_Ex1;
            this.PCI_Ex1Picture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PCI_Ex1Picture.Location = new System.Drawing.Point(383, 45);
            this.PCI_Ex1Picture.Name = "PCI_Ex1Picture";
            this.PCI_Ex1Picture.Size = new System.Drawing.Size(37, 143);
            this.PCI_Ex1Picture.TabIndex = 4;
            this.PCI_Ex1Picture.DragDrop += new System.Windows.Forms.DragEventHandler(this.Picture_DragDrop);
            this.PCI_Ex1Picture.DragEnter += new System.Windows.Forms.DragEventHandler(this.Picture_DragEnter);
            this.PCI_Ex1Picture.DragLeave += new System.EventHandler(this.Picture_DragLeave);
            this.PCI_Ex1Picture.MouseEnter += new System.EventHandler(this.Element_MouseEnter);
            this.PCI_Ex1Picture.MouseLeave += new System.EventHandler(this.Element_MouseLeave);
            // 
            // MCHPicture
            // 
            this.MCHPicture.AllowDrop = true;
            this.MCHPicture.BackgroundImage = global::Hardware.Properties.Resources._MCH;
            this.MCHPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MCHPicture.Location = new System.Drawing.Point(361, 235);
            this.MCHPicture.Name = "MCHPicture";
            this.MCHPicture.Size = new System.Drawing.Size(80, 102);
            this.MCHPicture.TabIndex = 3;
            this.MCHPicture.DragDrop += new System.Windows.Forms.DragEventHandler(this.Picture_DragDrop);
            this.MCHPicture.DragEnter += new System.Windows.Forms.DragEventHandler(this.Picture_DragEnter);
            this.MCHPicture.DragLeave += new System.EventHandler(this.Picture_DragLeave);
            this.MCHPicture.MouseEnter += new System.EventHandler(this.Element_MouseEnter);
            this.MCHPicture.MouseLeave += new System.EventHandler(this.Element_MouseLeave);
            // 
            // PowerPicture
            // 
            this.PowerPicture.AllowDrop = true;
            this.PowerPicture.BackgroundImage = global::Hardware.Properties.Resources._Power;
            this.PowerPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PowerPicture.Location = new System.Drawing.Point(488, 541);
            this.PowerPicture.Name = "PowerPicture";
            this.PowerPicture.Size = new System.Drawing.Size(218, 47);
            this.PowerPicture.TabIndex = 2;
            this.PowerPicture.DragDrop += new System.Windows.Forms.DragEventHandler(this.Picture_DragDrop);
            this.PowerPicture.DragEnter += new System.Windows.Forms.DragEventHandler(this.Picture_DragEnter);
            this.PowerPicture.DragLeave += new System.EventHandler(this.Picture_DragLeave);
            this.PowerPicture.MouseEnter += new System.EventHandler(this.Element_MouseEnter);
            this.PowerPicture.MouseLeave += new System.EventHandler(this.Element_MouseLeave);
            // 
            // DDR2Picture
            // 
            this.DDR2Picture.AllowDrop = true;
            this.DDR2Picture.BackgroundImage = global::Hardware.Properties.Resources._DDR2;
            this.DDR2Picture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DDR2Picture.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.DDR2Picture.Location = new System.Drawing.Point(388, 381);
            this.DDR2Picture.Name = "DDR2Picture";
            this.DDR2Picture.Size = new System.Drawing.Size(352, 130);
            this.DDR2Picture.TabIndex = 1;
            this.DDR2Picture.DragDrop += new System.Windows.Forms.DragEventHandler(this.Picture_DragDrop);
            this.DDR2Picture.DragEnter += new System.Windows.Forms.DragEventHandler(this.Picture_DragEnter);
            this.DDR2Picture.DragLeave += new System.EventHandler(this.Picture_DragLeave);
            this.DDR2Picture.MouseEnter += new System.EventHandler(this.Element_MouseEnter);
            this.DDR2Picture.MouseLeave += new System.EventHandler(this.Element_MouseLeave);
            // 
            // SocetPicture
            // 
            this.SocetPicture.AllowDrop = true;
            this.SocetPicture.BackgroundImage = global::Hardware.Properties.Resources._SOCET;
            this.SocetPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SocetPicture.Location = new System.Drawing.Point(490, 175);
            this.SocetPicture.Name = "SocetPicture";
            this.SocetPicture.Size = new System.Drawing.Size(163, 141);
            this.SocetPicture.TabIndex = 0;
            this.SocetPicture.DragDrop += new System.Windows.Forms.DragEventHandler(this.Picture_DragDrop);
            this.SocetPicture.DragEnter += new System.Windows.Forms.DragEventHandler(this.Picture_DragEnter);
            this.SocetPicture.DragLeave += new System.EventHandler(this.Picture_DragLeave);
            this.SocetPicture.MouseEnter += new System.EventHandler(this.Element_MouseEnter);
            this.SocetPicture.MouseLeave += new System.EventHandler(this.Element_MouseLeave);
            // 
            // AudioPicture
            // 
            this.AudioPicture.AllowDrop = true;
            this.AudioPicture.BackgroundImage = global::Hardware.Properties.Resources._Audio;
            this.AudioPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AudioPicture.Location = new System.Drawing.Point(270, 7);
            this.AudioPicture.Name = "AudioPicture";
            this.AudioPicture.Size = new System.Drawing.Size(81, 53);
            this.AudioPicture.TabIndex = 7;
            this.AudioPicture.DragDrop += new System.Windows.Forms.DragEventHandler(this.Picture_DragDrop);
            this.AudioPicture.DragEnter += new System.Windows.Forms.DragEventHandler(this.Picture_DragEnter);
            this.AudioPicture.DragLeave += new System.EventHandler(this.Picture_DragLeave);
            this.AudioPicture.MouseEnter += new System.EventHandler(this.Element_MouseEnter);
            this.AudioPicture.MouseLeave += new System.EventHandler(this.Element_MouseLeave);
            // 
            // GameWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.AudioPicture);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.MainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1200, 700);
            this.MinimumSize = new System.Drawing.Size(1000, 500);
            this.Name = "GameWindow";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GameWindow";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GameWindow_FormClosing);
            this.SizeChanged += new System.EventHandler(this.GameWindow_SizeChanged);
            this.MainPanel.ResumeLayout(false);
            this.PictureMB.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Panel PictureMB;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Panel SocetPicture;
        private System.Windows.Forms.Panel DDR2Picture;
        private System.Windows.Forms.Panel PCI_Ex1Picture;
        private System.Windows.Forms.Panel MCHPicture;
        private System.Windows.Forms.Panel PowerPicture;
        private System.Windows.Forms.Panel PCI_Ex16Picture;
        private System.Windows.Forms.Panel SuperIOPicture;
        private System.Windows.Forms.Panel CDPicture;
        private System.Windows.Forms.Panel LanPicture;
        private System.Windows.Forms.Panel VGA_DVIPicture;
        private System.Windows.Forms.Panel AudioPicture;
        private System.Windows.Forms.Panel IE1394Picture;
        private System.Windows.Forms.Panel USBPicture;
        private System.Windows.Forms.Panel PataPicture;
        private System.Windows.Forms.Panel PCI1Picture;
        private System.Windows.Forms.Panel SataPicture;
        private System.Windows.Forms.Panel ICHPicture;
        private System.Windows.Forms.Panel BIOSPicture;
        private System.Windows.Forms.Panel CMOSPowPicture;
    }
}