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
            Hide();
            gw.Show();
        }

        private void LearnButton_Click(object sender, EventArgs e)
        {
            LearnWindow lw = new LearnWindow(this);
            Hide();
            lw.Show();
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
                LearnButton.ForeColor = (StartButton.ForeColor = (SettingButton.ForeColor = (ExitButton.ForeColor = SettingWindow.WhiteColorButtons)));
                LearnButton.BackColor = (StartButton.BackColor = (SettingButton.BackColor = (ExitButton.BackColor = SettingWindow.BlackColorButtons)));
            }
            else
            {
                BackColor = SettingWindow.WhiteColorMainPanel;
                LearnButton.ForeColor = StartButton.ForeColor = (SettingButton.ForeColor = (ExitButton.ForeColor = SettingWindow.BlackColorButtons));
                LearnButton.BackColor = StartButton.BackColor = (SettingButton.BackColor = (ExitButton.BackColor = SettingWindow.WhiteColorButtons));
            }
            linkLabel1.LinkColor = linkLabel1.BackColor;
        }

        private void MainWindow_VisibleChanged(object sender, EventArgs e) => SetColorTheme(SettingWindow.BlackTheme);

        private void Button_MouseEnter(object sender, EventArgs e)
        {
            switch (GetNumberOfButton(sender))
            {
                case 0:
                    StartButton.ForeColor = Color.Red;
                    break;
                case 1:
                    LearnButton.ForeColor = Color.Red;
                    break;
                case 2:
                    SettingButton.ForeColor = Color.Red;
                    break;
                case 3:
                    ExitButton.ForeColor = Color.Red;
                    break;

                default:
                    break;
            }
        }

        private void Button_MouseLeave(object sender, EventArgs e)
        {
            Color Black = SettingWindow.BlackColorButtons;
            Color White = SettingWindow.WhiteColorButtons;

            switch (GetNumberOfButton(sender))
            {
                case 0:
                    StartButton.BackColor = SettingWindow.BlackTheme ? Black : White;
                    StartButton.ForeColor = SettingWindow.BlackTheme ? White : Black;
                    break;
                case 1:
                    LearnButton.BackColor = SettingWindow.BlackTheme ? Black : White;
                    LearnButton.ForeColor = SettingWindow.BlackTheme ? White : Black;
                    break;
                case 2:
                    SettingButton.BackColor = SettingWindow.BlackTheme ? Black : White;
                    SettingButton.ForeColor = SettingWindow.BlackTheme ? White : Black;
                    break;
                case 3:
                    ExitButton.BackColor = SettingWindow.BlackTheme ? Black : White;
                    ExitButton.ForeColor = SettingWindow.BlackTheme ? White : Black;
                    break;

                default:    
                    break;
            }
        }

        private int GetNumberOfButton(object sender)
        {
            
            if (sender.ToString() == "System.Windows.Forms.Button, Text: Начать игру")
                return 0;
            if (sender.ToString() == "System.Windows.Forms.Button, Text: Учиться")
                return 1;
            if (sender.ToString() == "System.Windows.Forms.Button, Text: Настройки")
                return 2;
            if (sender.ToString() == "System.Windows.Forms.Button, Text: Выход")
                return 3;
            return -1;
        }

        private void linkLabel1_MouseEnter(object sender, EventArgs e) => linkLabel1.LinkColor = Color.Red;
        private void linkLabel1_MouseLeave(object sender, EventArgs e) => linkLabel1.LinkColor = linkLabel1.BackColor;

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => System.Diagnostics.Process.Start("https://vk.com/rusan.rusik") ;
    }
}
