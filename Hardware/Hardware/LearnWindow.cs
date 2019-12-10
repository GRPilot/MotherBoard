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

        enum ColorsOfElements
        {
            COE_STANDART,
            COE_RED,
            COR_GREEN,
            COR_BLUE
        }

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

        //TODO: доделать кнопки
        #region buttons

        private void Element_MouseEnter(object sender, EventArgs e)
        {
            PictureBox img = (PictureBox)sender;
            img.Image = Image.FromFile(getWayToElement(img.Name, ColorsOfElements.COR_BLUE));
        }
        private void Element_MouseLeave(object sender, EventArgs e)
        {
            PictureBox img = (PictureBox)sender;
            img.Image = Image.FromFile(getWayToElement(img.Name, ColorsOfElements.COE_STANDART));
        }



        #endregion

        private void Element_Click(object sender, EventArgs e)
        {
            PictureBox img = (PictureBox)sender;
            MessageBox.Show(GetElementInformation(img), img.Name, MessageBoxButtons.OK, MessageBoxIcon.Information);
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

                default:
                    outString += @"NONE";
                    break;
            }

            switch (color)
            {
                case ColorsOfElements.COE_STANDART:
                    outString += ".";
                    break;
                case ColorsOfElements.COE_RED:
                    outString += "_Red.";
                    break;
                case ColorsOfElements.COR_GREEN:
                    outString += "_Green.";
                    break;
                case ColorsOfElements.COR_BLUE:
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
