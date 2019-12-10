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
    public partial class LearnWindow : Form
    {
        Form MainForm;
        bool isFormClosed;

        public LearnWindow(Form outMainForm)
        {
            MainForm = outMainForm;
            InitializeComponent();
            SetColorTheme(SettingWindow.BlackTheme);
            isFormClosed = true;
        }

        private void SetColorTheme(bool blackTheme)
        {
            if (blackTheme)
            {
                BackButton.ForeColor = SettingWindow.WhiteColorButtons;
                BackButton.BackColor = SettingWindow.BlackColorButtons;
                BackColor = SettingWindow.BlackColorMainPanel;
            }
            else
            {
                BackButton.ForeColor = SettingWindow.BlackColorButtons;
                BackButton.BackColor = SettingWindow.WhiteColorButtons; 
                BackColor = SettingWindow.WhiteColorMainPanel;
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            isFormClosed = false;
            MainForm.Show();
            Close();
        }

        private void LearnWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isFormClosed)
                Application.Exit();
        }


    }
}
