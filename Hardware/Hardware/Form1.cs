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
    public partial class MainWindow : Form
    {
        
        public MainWindow()
        {
            InitializeComponent();
            SetColorTheme(SettingWindow.BlackTheme);
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            GameWindow gw = new GameWindow(this);
            gw.Show();
        }

        private void SettingButton_Click(object sender, EventArgs e)
        {
            SettingWindow sw = new SettingWindow(this);
            Hide();
            sw.Show();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void SetColorTheme(bool isBlackColor)
        {
            if(isBlackColor)
            {
                BackColor = SettingWindow.BlackColorMainPanel;
                StartButton.ForeColor = (SettingButton.ForeColor = (ExitButton.ForeColor = SettingWindow.WhiteColorButtons));
                StartButton.BackColor = (SettingButton.BackColor = (ExitButton.BackColor = SettingWindow.BlackColorButtons));
            }
            else
            {
                BackColor = SettingWindow.WhiteColorMainPanel;
                StartButton.ForeColor = (SettingButton.ForeColor = (ExitButton.ForeColor = SettingWindow.BlackColorButtons));
                StartButton.BackColor = (SettingButton.BackColor = (ExitButton.BackColor = SettingWindow.WhiteColorButtons));
            }
        }

        private void MainWindow_VisibleChanged(object sender, EventArgs e) => SetColorTheme(SettingWindow.BlackTheme);
    }
}
