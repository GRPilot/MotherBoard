using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hardware
{
    public partial class SettingWindow : Form
    {
        // Colors of application
        public static bool BlackTheme = true;
        public static readonly Color BlackColorMainPanel = Color.FromArgb(68, 68, 74);
        public static readonly Color BlackColorButtons   = Color.FromArgb(68, 68, 68);
        public static readonly Color WhiteColorMainPanel = Color.White;
        public static readonly Color WhiteColorButtons   = Color.FromArgb(225, 225, 225);

        // for closing
        bool formClosed;
        readonly Form mainFrom;
        public SettingWindow(Form OutMainForm)
        {
            mainFrom = OutMainForm;
            InitializeComponent();
            SetColorTheme(BlackTheme);
            formClosed = true;
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            formClosed = false;
            mainFrom.Show();
            Close();
        }

        private void SettingWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (formClosed)
                mainFrom.Close();
        }

        private void ChangeColorButton_Click(object sender, EventArgs e)
        {
            BlackTheme = !BlackTheme;
            SetColorTheme(BlackTheme);

        }

        private void SetColorTheme(bool isBlackTheme)
        {
            if (!isBlackTheme)
            {
                ChangeColorButton.Text = "Темный";
                BackColor = WhiteColorMainPanel;
                BackButton.ForeColor = (ChangeColorButton.ForeColor = BlackColorButtons);
                BackButton.BackColor = (ChangeColorButton.BackColor = WhiteColorButtons);
                TitleLabel.ForeColor = (DesignLabel.ForeColor = BlackColorMainPanel);
            }
            else
            {
                ChangeColorButton.Text = "Светлый";
                BackColor = BlackColorMainPanel;
                BackButton.ForeColor = (ChangeColorButton.ForeColor = WhiteColorButtons);
                BackButton.BackColor = (ChangeColorButton.BackColor = BlackColorButtons);
                TitleLabel.ForeColor = (DesignLabel.ForeColor = WhiteColorMainPanel);
            }
        }
    }
}
