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
        private int scroll = 1;

        Items[] items;
        Label[] labels;

        public GameWindow(Form OutMainForm)
        {
            mainFrom = OutMainForm;
            InitializeComponent();
            MainPanel.MouseWheel += MainPanel_MouseWheel;
            
            SetColorTheme(SettingWindow.BlackTheme);
            formClosed = true;
            LoadItems();
            ShowLabels(labels);
            
        }

        private void MainPanel_MouseWheel(object sender, MouseEventArgs e)
        {
            int FullHeight = Padding.Vertical + (labels.Length + 3) * (labels[0].Height + MainPanel.Padding.Vertical);
            if (Size.Height <= FullHeight)
            {
                // если скролл находиться между началом и концом списка по выстое
                if (scroll > -(labels.Length * labels[0].Height) &&
                    scroll < labels[0].Height)
                    scroll += e.Delta;
                else if (scroll < -(labels.Length * labels[0].Height)) // Если ниже списка
                    scroll += Math.Abs(e.Delta);
                else                                                   // Выше списка
                    scroll -= Math.Abs(e.Delta);

                ShowLabels(labels, scroll);
            }
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

        void ShowLabels(Label[] label, int scrollControl = 1)
        { 
            for (int i = 0; i < label.Length; i++)
            {
                MainPanel.Controls.Remove(label[i]);
                label[i].BackColor = SettingWindow.BlackTheme ? Color.FromArgb(78, 78, 80) : Color.FromArgb(230, 230, 230);
                label[i].ForeColor = SettingWindow.BlackTheme ? SettingWindow.WhiteColorButtons : SettingWindow.BlackColorMainPanel;
                label[i].Location = new Point(
                    MainPanel.Width - label[i].Width,
                    (label[i].Height + Padding.Vertical) * i + Padding.Vertical + scrollControl
                );
                
                MainPanel.Controls.Add(label[i]);
                label[i].BringToFront();
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
                {
                    labels[i] = CreateLabel(i);
                    ControlExtension.Draggable(labels[i], true);
                }
            }
            catch (IOException e)
            {
                MessageBox.Show(e.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private Label CreateLabel(int i)
        {
            Size size = new Size(
                MainPanel.Width - PictureMB.Width - MainPanel.Padding.Horizontal - MainPanel.Margin.Horizontal,
                MainPanel.Height / 10 - Padding.Vertical
            );
            const float fontSize = 18.0f;

            Label label = new Label
            {
                Size = size,
                Text = items[i].GetName(),
                BackColor = SettingWindow.BlackTheme ? Color.FromArgb(78, 78, 80) : Color.FromArgb(230, 230, 230),
                ForeColor = SettingWindow.BlackTheme ? SettingWindow.WhiteColorButtons : SettingWindow.BlackColorMainPanel,
                Location = new Point(
                    Width - size.Width,
                    (size.Height + Padding.Vertical) * i + Padding.Vertical
                ),
                Font = new Font(FontFamily.GenericSansSerif, fontSize),
                TextAlign = ContentAlignment.MiddleCenter,
            };

            return label;
        }

        private void GameWindow_SizeChanged(object sender, EventArgs e) => ShowLabels(labels);
        
        private Label[] RemoveElement(Label[] list, int id)
        {
            Label[] output;
            if (id >= 0 && id < list.Length && list.Length > 1)
            {
                MainPanel.Controls.Remove(list[id]);
                output = new Label[list.Length - 1];

                for (int i = id; i < list.Length - 1; i++)
                    list[i] = list[i + 1];

                for (int i = 0; i < output.Length; i++)
                    output[i] = list[i];
            }
            else
                return list;

            return output;
        }

        private void BiosPan_MouseEnter(object sender, EventArgs e)
        {    
            BiosPan.BackgroundImage = Image.FromFile(@"C:\Users\79995\Documents\GitHub\MotherBoard\Hardware\Hardware\src\picture\elements_without_names\BIOS_Blue.png");
        }

        private void BiosPan_MouseLeave(object sender, EventArgs e)
        {
            BiosPan.BackgroundImage = Image.FromFile(@"C:\Users\79995\Documents\GitHub\MotherBoard\Hardware\Hardware\src\picture\elements_without_names\BIOS.png");
        }

        private void BiosPan_DragEnter(object sender, DragEventArgs e)
        {
            // Реагирует на текст, перетаскиваемый в него, но не на объекты

        }
    }
}
