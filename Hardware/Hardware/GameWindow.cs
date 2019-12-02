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
using Microsoft.VisualBasic.CompilerServices;

namespace Hardware
{

    public partial class GameWindow : Form
    {
        bool formClosed;
        readonly Form mainFrom;

        Items[] items;
        Label[] labels;

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
            ShowLabels(labels);
            
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

        void ShowLabels(Label[] label)
        {
            
            for (int i = 0; i < items.Length; i++)
            {
                //TODO: DragDrop labels
                
                
                DetailsPanel.Controls.Add(label[i]);
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
                labels = new Label[count];
                for (int i = 0; i < count; i++)
                    items[i] = new Items();

                stream.Close();
                stream = new StreamReader(file);

                int id = 0;
                while (!stream.EndOfStream && id < count)
                {
                    buff = Convert.ToChar(stream.Read()).ToString();
                    if (buff.Length > 0)
                        if (buff[0] == '#')
                        {
                            items[id].SetName(stream.ReadLine());
                            items[id].SetDescription(stream.ReadLine());
                            id++;
                        }
                }

                for (int i = 0; i < count; i++)
                    labels[i] = CreateLabel(i);
            }
            catch (IOException e)
            {
                MessageBox.Show(e.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private Label CreateLabel(int i)
        {
            Size size = new Size(
                DetailsPanel.Width - DetailsPanel.Padding.Horizontal - 20,
                DetailsPanel.Height / 10 - DetailsPanel.Padding.Vertical
            );
            const float fontSize = 18.0f;
            
            Label label = new Label
            {
                Size = size,
                Text = items[i].GetName(),
                BackColor = SettingWindow.BlackTheme ? Color.FromArgb(78, 78, 80) : Color.FromArgb(230, 230, 230),
                ForeColor = SettingWindow.BlackTheme ? SettingWindow.WhiteColorButtons : SettingWindow.BlackColorMainPanel,
                Location = new Point(
                    DetailsPanel.Padding.Left,
                    (size.Height + DetailsPanel.Padding.Vertical) * i
                ),
                Font = new Font(FontFamily.GenericSansSerif, fontSize),
                TextAlign = ContentAlignment.MiddleCenter,
            };

            return label;
        }
    }
}
