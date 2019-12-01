using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hardware.ItemsClass;
using System.IO;

namespace Hardware
{

    public partial class GameWindow : Form
    {
        bool formClosed;
        readonly Form mainFrom;

        Items[] items;

        public GameWindow(Form OutMainForm)
        {
            mainFrom = OutMainForm;
            InitializeComponent();
            DetailsPanel.AutoScroll = true;
            DetailsPanel.HorizontalScroll.Enabled = false;
            DetailsPanel.HorizontalScroll.Visible = false;
            
            SetColorTheme(SettingWindow.BlackTheme);
            formClosed = true;
            LoadItems();
            ShowItems();
            
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            formClosed = false;
            mainFrom.Show();
            Close();
        }

        private void GameWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (formClosed)
                mainFrom.Close();
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
        }

        void ShowItems()
        {
            Size size = new Size(
                DetailsPanel.Width - DetailsPanel.Padding.Horizontal - 20, 
                DetailsPanel.Height / 10 - DetailsPanel.Padding.Vertical
            );
            const float fontSize = 18.0f;

            for (int i = 0; i < items.Length; i++)
            {
                Label panel = new Label {
                    Size = size,
                    Text = items[i].GetName(),
                    BackColor = Color.FromArgb(78, 78, 80),
                    ForeColor = Color.White,
                    Location = new Point(
                        DetailsPanel.Padding.Left,
                        (size.Height + DetailsPanel.Padding.Vertical) * i
                    ),
                    Font = new Font(FontFamily.GenericSansSerif, fontSize),
                    TextAlign = ContentAlignment.MiddleCenter
                };

                DetailsPanel.Controls.Add(panel);
            }
        }
        void LoadItems(string file = @"C:\Users\79995\Documents\GitHub\MotherBoard\Hardware\Hardware\ItemsClass\items.txt")
        {
            try
            {
                int count = 0;
                string buff = "";
                StreamReader stream = new StreamReader(file);
                while (!stream.EndOfStream)
                {
                    buff = stream.ReadLine();
                    if (buff.Length > 0)
                        if (buff[0] == '#')
                            count++;
                }

                items = new Items[count];
                for (int j = 0; j < count; j++)
                    items[j] = new Items();
                stream.Close();
                stream = new StreamReader(file);

                int i = 0;
                while (!stream.EndOfStream && i < count)
                {
                    buff = Convert.ToChar(stream.Read()).ToString();
                    if (buff.Length > 0)
                        if (buff[0] == '#')
                        {
                            items[i].SetName(stream.ReadLine());
                            items[i].SetDescription(stream.ReadLine());
                            i++;
                        }
                }
            }
            catch (IOException e)
            {
                MessageBox.Show(e.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
