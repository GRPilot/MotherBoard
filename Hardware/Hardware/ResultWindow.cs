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
    public partial class ResultWindow : Form
    {
        Form MainForm;

        public ResultWindow(int corCount, int incorCount, Form outForm)
        {
            MainForm = outForm;
            InitializeComponent();
            SetColorTheme(SettingWindow.BlackTheme);

            cor.Text   = corCount.ToString();
            incor.Text = incorCount.ToString();

            int procents = (corCount * 100) / (corCount + incorCount);

            proc.Text = procents.ToString() + "%";
            if (procents < 50)
            {
                proc.ForeColor = Color.Red;
                Title.Text = "Я знаю, ты можешь лучше";
            }
            else if (procents <= 70)
            {
                proc.ForeColor = Color.Orange;
                Title.Text = "Это уже больше, чем у <рандомное_число> людей!";
            }
            else if (procents <= 90)
            {
                proc.ForeColor = Color.Green;
                Title.Text = "Ты можешь собой гордиться";
            }
            else
            {
                proc.ForeColor = Color.Gold;
                Title.Text = "Золотой голове - золотые проценты";
            }
        }

        public void SetColorTheme(bool isBlackColor)
        {
            if (isBlackColor)
            {
                BackColor = SettingWindow.BlackColorMainPanel;
                BackButton.BackColor = SettingWindow.BlackColorButtons;
                BackButton.ForeColor = SettingWindow.WhiteColorButtons;
            }
            else
            {
                BackColor = SettingWindow.WhiteColorMainPanel;
                BackButton.BackColor = SettingWindow.WhiteColorButtons;
                BackButton.ForeColor = SettingWindow.BlackColorButtons;
            }

            Title.BackColor = (correctRes.BackColor = (incorrectRes.BackColor = (TitleProc.BackColor = BackColor)));

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            MainForm.Enabled = true;
            Close();
        }
    }
}
