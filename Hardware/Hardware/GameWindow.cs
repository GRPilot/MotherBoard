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

        enum ColorsOfElements
        {
            COE_STANDART,
            COE_RED,
            COE_GREEN,
            COE_BLUE
        }

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
        void LoadItems(string file = @"C:\Users\79995\Documents\GitHub\MotherBoard\Hardware\Hardware\ItemsClass\Items.txt")
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
                    labels[i].MouseDown += GameWindow_MouseDown;
                    labels[i].MouseUp += GameWindow_MouseUp;
                }
            }
            catch (IOException e)
            {
                MessageBox.Show(e.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #region Returning Elements

        Point startPos;

        private void GameWindow_MouseDown(object sender, MouseEventArgs e)
        {
            Label obj = (Label)sender;
            startPos = new Point(obj.Location.X, obj.Location.Y);
        }

        private void GameWindow_MouseUp(object sender, MouseEventArgs e)
        {
            Label obj = (Label)sender;
            obj.Location = startPos;
        }

        #endregion

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

        // ПОДУМАЙ, НИНАД ИЛИ НАД

        private void Picture_DragEnter(object sender, DragEventArgs e)
        {
            Panel obj = (Panel)sender;
            string locationOfImg = getWayToElement(obj.Name, ColorsOfElements.COE_BLUE);
            if (locationOfImg != null)
                obj.BackgroundImage = Image.FromFile(locationOfImg);
            e.Effect = DragDropEffects.Move;
        }

        private void Picture_DragDrop(object sender, DragEventArgs e)
        {
            Panel obj = (Panel)sender;
            string locationOfImg = getWayToElement(obj.Name, ColorsOfElements.COE_RED);
            if (locationOfImg != null)
                obj.BackgroundImage = Image.FromFile(locationOfImg);

        }

        private string GetElementInformation(PictureBox img)
        {
            switch (img.Name)
            {
                case "SocetPicture":
                    return "SOCKET (сокет) - гнездо, в которое устанавливается микросхема со штырьковыми выводами.";

                case "VGA_DVIPicture":
                    return "VGA (VIDEO GRAFICS ARRAY, видеографическая решетка) - видеоадаптер, доддерживающий текстовый и графический режимы.";

                case "LanPicture":
                    return "LAN (LOCAL AREA NETWORK, локальная вычислительная сеть) - сеть, ограниченная пределами определенной территории.";

                case "AudioPicture":
                    return "Разъем аудио";

                case "SuperIOPicture":
                    return "(контроллер ввода/вывода) - объединяет интерфейсы различных низкочастотных устройств. Включает в себя следующие функции:\n" +
                           "1.контроллер дисковода флоппи;\n" +
                           "2.параллельный порт(LPT)(обычно используется для принтеров);\n" +
                           "3.один или более последовательных(COM) портов;\n" +
                           "4.интерфейс мыши;\n" +
                           "5.интерфейс клавиатуры.";

                case "CDPicture":
                    return "CD";

                case "IE1394Picture":
                    return "IEEE 1394 (FireWire, i - Link) - последовательная высокоскоростная шина, предназначенная для обмена цифровой информацией между компьютером и другими электронными устройствами.";

                case "USBPicture":
                    return "Порты подключения USB слотов";

                case "PCI1Picture":
                    return "PCI (Periphecal Component Interconnect) - соединение периферийных компонентов, параллельная мультиплексная шина общего назначения с пакетной передачей данных.";

                case "PCI_Ex1Picture":
                    return "PCI (Periphecal Component Interconnect) - соединение периферийных компонентов, параллельная мультиплексная шина общего назначения с пакетной передачей данных.";

                case "PCI_Ex16Picture":
                    return "PCI(Periphecal Component Interconnect) - соединение периферийных компонентов, параллельная мультиплексная шина общего назначения с пакетной передачей данных.";

                case "MCHPicture":
                    return "Контроллер-концентратор памяти— северный мост (англ. northbridge). Обеспечивает взаимодействие центрального процессора (ЦП) с памятью и видеоадаптером (PCI Express).";

                case "SataPicture":
                    return "SATA (Serial Advanced Technologe Attanchment) - последовательная дифференциальная универсальная шина (интерфейс) жесткого диска.";

                case "ICHPicture":
                    return "Контроллер-концентратор ввода-вывода — южный мост (англ. southbridge). Обеспечивает взаимодействие между ЦП и жестким диском, картами PCI, интерфейсами IDE, SATA, USB и пр. ";

                case "BIOSPicture":
                    return "BIOS";

                case "CMOSPowPicture":
                    return "CMOS (Complementaty Metal-Oxide Semiconductor, комплиментарный металло-оксидный полупроводник (КМОП)) - технология изготовления схем, используемая  для хранения  некоторых параметров компьютера при отключении его блока питания. Микросхема CMOS памяти использует в качестве источника питания -батарею.";

                case "DDR2Picture":
                    return "DDR2 (Double-Data-Rate Two Synchronous Dynamic Random Access Memory — синхронная динамическая память с произвольным доступом и удвоенной скоростью передачи данных, второе поколение) — это тип оперативной памяти используемой в вычислительной технике в качестве оперативной и видеопамяти.Внешне - 240 контактов(по 120 с каждой стороны). ";

                case "PataPicture":
                    return "PATA (Parallel Advanced Technology Attachment) - параллельная шина (интерфейс) жесткого диска.";

                case "PowerPicture":
                    return "Разъем питания";


                default:
                    return "Не найдено";

            }
        }
        private string getWayToElement(string name, ColorsOfElements color)
        {
            // CHANGE ИЗМЕНИТЬ CHANGE ИЗМЕНИТЬ CHANGE ИЗМЕНИТЬ CHANGE ИЗМЕНИТЬ CHANGE ИЗМЕНИТЬ CHANGE ИЗМЕНИТЬ CHANGE ИЗМЕНИТЬ CHANGE ИЗМЕНИТЬ
            string outString = @"C:\Users\79995\Documents\GitHub\MotherBoard\Hardware\Hardware\src\picture\elements\";

            switch (name)
            {
                case "SocetPicture":
                    outString += @"SOCET";
                    break;
                case "VGA_DVIPicture":
                    outString += @"VGA_DVI";
                    break;
                case "LanPicture":
                    outString += @"LAN";
                    break;
                case "AudioPicture":
                    outString += @"Audio";
                    break;
                case "SuperIOPicture":
                    outString += @"SuperIO";
                    break;
                case "CDPicture":
                    outString += @"CD";
                    break;
                case "IE1394Picture":
                    outString += @"13942";
                    break;
                case "USBPicture":
                    outString += @"USB2";
                    break;
                case "PCI1Picture":
                    outString += @"PCI1";
                    break;
                case "PCI_Ex1Picture":
                    outString += @"PCI-Ex1";
                    break;
                case "PCI_Ex16Picture":
                    outString += @"PCI-Ex16";
                    break;
                case "MCHPicture":
                    outString += @"MCH";
                    break;
                case "SataPicture":
                    outString += @"SATA2";
                    break;
                case "ICHPicture":
                    outString += @"ICH";
                    break;
                case "BIOSPicture":
                    outString += @"BIOS";
                    break;
                case "CMOSPowPicture":
                    outString += @"CMOSPower";
                    break;
                case "DDR2Picture":
                    outString += @"DDR2";
                    break;
                case "PataPicture":
                    outString += @"Pata2";
                    break;
                case "PowerPicture":
                    outString += @"Power";
                    break;

                default: return null;
            }

            switch (color)
            {
                case ColorsOfElements.COE_STANDART:
                    outString += ".";
                    break;
                case ColorsOfElements.COE_RED:
                    outString += "_Red.";
                    break;
                case ColorsOfElements.COE_GREEN:
                    outString += "_Green.";
                    break;
                case ColorsOfElements.COE_BLUE:
                    outString += "_Blue.";
                    break;
            }

            if (!(name == "AudioPicture" || name == "VGA_DVIPicture"))
                outString += "jpg";
            else
                outString += "png";

            return outString;
        }

        
    }
}
