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

        private void Button_MouseEnter(object sender, EventArgs e)
        {
            switch (GetNumberOfButton(sender))
            {
                case 0:
                    StartButton.ForeColor = Color.Red;
                    break;
                case 1:
                    SettingButton.ForeColor = Color.Red;
                    break;
                case 2:
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
                    SettingButton.BackColor = SettingWindow.BlackTheme ? Black : White;
                    SettingButton.ForeColor = SettingWindow.BlackTheme ? White : Black;
                    break;
                case 2:
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
            if (sender.ToString() == "System.Windows.Forms.Button, Text: Настройки")
                return 1;
            if (sender.ToString() == "System.Windows.Forms.Button, Text: Выход")
                return 2;
            return -1;
        }
    }
}
