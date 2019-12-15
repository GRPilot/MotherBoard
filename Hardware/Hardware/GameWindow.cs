using System;
using System.Drawing;
using System.Windows.Forms;
using Hardware.ItemsClass;
using System.IO;

namespace Hardware
{

    public partial class GameWindow : Form
    {
        bool formClosed;
        readonly Form mainFrom;
        private int scroll = 1;
        private int CorrecrtScore   = 0;
        private int IncorrecrtScore = 0;
        private string directory;

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
            directory = Environment.CurrentDirectory;
            SetColorTheme(SettingWindow.BlackTheme);
            formClosed = true;
            LoadItems();
            ShowLabels(labels, 1, true);
            
        }

        #region list
        

        private void    MainPanel_MouseWheel(object sender, MouseEventArgs e)
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
        private void    LoadItems(string file = null)
        {
            try
            {
                if (file == null)
                    file = directory + @"\Items.txt";
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
                    //labels[i].Draggable(true);
                    labels[i].MouseDown += Item_MouseDown;
                    labels[i].MouseUp   += Item_MouseUp;
                }
            }
            catch (IOException e)
            {
                MessageBox.Show(e.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private Label   CreateLabel(int i)
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
        private Label[] RemoveElement(Label[] list, string name)
        {
            Label[] output;
            int id = -1;

            for (int i = 0; i < list.Length; i++)
                if (list[i].Text == name)
                {
                    MainPanel.Controls.Remove(list[i]);
                    id = i;
                    break;
                }

            if (id != -1)
            {
                output = new Label[list.Length - 1];

                for (int i = id; i < list.Length - 1; i++)
                    list[i] = list[i + 1];

                for (int i = 0; i < output.Length; i++)
                    output[i] = list[i];
            }
            else return list;

            return output;
        }
        private string  GetElementName(Panel pan)
        {
            switch (pan.Name)
            {
                case "SocetPicture":
                    return "Сокет процессора.";

                case "VGA_DVIPicture":
                    return "Разъем VGA(DVI) монитора";

                case "LanPicture":
                    return "Разъем локальной сети";

                case "AudioPicture":
                    return "Audio";

                case "SuperIOPicture":
                    return "Super I/O";

                case "CDPicture":
                    return "Разъем CD";

                case "IE1394Picture":
                    return "IEEE 1394";

                case "USBPicture":
                    return "Разъемы USB";

                case "PCI1Picture":
                    return "Разъем PCI1";

                case "PCI_Ex1Picture":
                    return "Разъем PCI-Ex1";

                case "PCI_Ex16Picture":
                    return "Разъем PCI-Ex16";

                case "MCHPicture":
                    return "MCH (Memory Controller Hub) ";

                case "SataPicture":
                    return "Разъемы SATA";

                case "ICHPicture":
                    return "ICH (I/O Controller Hub)";

                case "BIOSPicture":
                    return "BIOS";

                case "CMOSPowPicture":
                    return "Питание CMOS";

                case "DDR2Picture":
                    return "DDR2 SDRAM ";

                case "PataPicture":
                    return "Разъем PATA (IDE)";

                case "PowerPicture":
                    return "Разъем питания";


                default:
                    return "Не найдено";

            }
        }
        private string  getWayToElement(string name, ColorsOfElements color)
        {
            // CHANGE ИЗМЕНИТЬ CHANGE ИЗМЕНИТЬ CHANGE ИЗМЕНИТЬ CHANGE ИЗМЕНИТЬ CHANGE ИЗМЕНИТЬ CHANGE ИЗМЕНИТЬ CHANGE ИЗМЕНИТЬ CHANGE ИЗМЕНИТЬ
            string outString = directory + @"\elements_without_names\";

            switch (name)
            {
                case "SocetPicture":
                    outString += @"_SOCET";
                    break;
                case "VGA_DVIPicture":
                    outString += @"_VGA_DVI";
                    break;
                case "LanPicture":
                    outString += @"_LAN";
                    break;
                case "AudioPicture":
                    outString += @"_Audio";
                    break;
                case "SuperIOPicture":
                    outString += @"_SuperIO";
                    break;
                case "CDPicture":
                    outString += @"_CD";
                    break;
                case "IE1394Picture":
                    outString += @"_IE1394";
                    break;
                case "USBPicture":
                    outString += @"_USB2";
                    break;
                case "PCI1Picture":
                    outString += @"_PCI1";
                    break;
                case "PCI_Ex1Picture":
                    outString += @"_PCI-Ex1";
                    break;
                case "PCI_Ex16Picture":
                    outString += @"_PCI-Ex16";
                    break;
                case "MCHPicture":
                    outString += @"_MCH";
                    break;
                case "SataPicture":
                    outString += @"_SATA2";
                    break;
                case "ICHPicture":
                    outString += @"_ICH";
                    break;
                case "BIOSPicture":
                    outString += @"_BIOS";
                    break;
                case "CMOSPowPicture":
                    outString += @"_CMOSPower";
                    break;
                case "DDR2Picture":
                    outString += @"_DDR2";
                    break;
                case "PataPicture":
                    outString += @"_Pata2";
                    break;
                case "PowerPicture":
                    outString += @"_Power";
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

        #endregion

        #region UI
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
        public  void SetColorTheme(bool isBlackColor)
        {
            if (isBlackColor)
            {
                BackColor = SettingWindow.BlackColorMainPanel;
                BackButton.BackColor = SettingWindow.BlackColorButtons;
                BackButton.ForeColor = SettingWindow.WhiteColorButtons;
                PictureMB.BackColor  = SettingWindow.BlackColorMainPanel;
            }
            else
            {
                BackColor = SettingWindow.WhiteColorMainPanel;
                BackButton.BackColor = SettingWindow.WhiteColorButtons;
                BackButton.ForeColor = SettingWindow.BlackColorButtons;
                PictureMB.BackColor = SettingWindow.WhiteColorMainPanel;
            }
        }
        private void ShowLabels(Label[] label, int scrollControl = 1, bool isRandomize = false)
        {
            try
            {
                if (isRandomize)
                {
                    Random rand = new Random(DateTime.Now.Second);

                    for (int i = 0; i < label.Length; i++)
                    {
                        Label temp = label[i];
                        int newPos = rand.Next(0, label.Length - 1);
                        label[i] = label[newPos];
                        label[newPos] = temp;
                    }
                }
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
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void GameWindow_SizeChanged(object sender, EventArgs e) => ShowLabels(labels);
        private void Element_MouseEnter(object sender, EventArgs e)
        {
            Panel obj = (Panel)sender;
            string locationOfImg = getWayToElement(obj.Name, ColorsOfElements.COE_BLUE);
            if (locationOfImg != null)
                obj.BackgroundImage = Image.FromFile(locationOfImg);
        }
        private void Element_MouseLeave(object sender, EventArgs e)
        {
            Panel obj = (Panel)sender;
            string locationOfImg = getWayToElement(obj.Name, ColorsOfElements.COE_STANDART);
            if (locationOfImg != null)
                obj.BackgroundImage = Image.FromFile(locationOfImg);
        }

        #endregion

        #region Drag&Drop

        private void Picture_DragEnter(object sender, DragEventArgs e)
        {
            Panel obj = (Panel)sender;
            string locationOfImg = getWayToElement(obj.Name, ColorsOfElements.COE_BLUE);
            
            if (locationOfImg != null)
                obj.BackgroundImage = Image.FromFile(locationOfImg);

            if (e.Data.GetDataPresent(DataFormats.Text, true))
                e.Effect = DragDropEffects.All;
        }
        private void Picture_DragLeave(object sender, EventArgs e)
        {
            Panel obj = (Panel)sender;
            string locationOfImg = getWayToElement(obj.Name, ColorsOfElements.COE_STANDART);
            if (locationOfImg != null)
                obj.BackgroundImage = Image.FromFile(locationOfImg);
        }
        private void Picture_DragDrop(object sender, DragEventArgs e)
        {
            Panel obj = (Panel)sender;
            string nameOfElem = GetElementName(obj);
            string nameOfItem = e.Data.GetData(DataFormats.Text).ToString();

            Text = nameOfElem + ' ' + nameOfItem;

            obj.AllowDrop = false;
            obj.Enabled   = false;

            if (nameOfElem == nameOfItem)
            {
                obj.BackgroundImage = Image.FromFile(getWayToElement(obj.Name, ColorsOfElements.COE_GREEN));
                CorrecrtScore++;
            }
            else
            {
                obj.BackgroundImage = Image.FromFile(getWayToElement(obj.Name, ColorsOfElements.COE_RED));
                IncorrecrtScore++;
            }

            labels = RemoveElement(labels, nameOfElem);
            ShowLabels(labels);

            if (CorrecrtScore + IncorrecrtScore == 19)
            {
                ResultWindow rw = new ResultWindow(CorrecrtScore, IncorrecrtScore, this);
                Enabled = false;
                rw.Show();
            }
        }

        private void Item_MouseUp(object sender, MouseEventArgs e)
        {
            Label item = (Label)sender;

        }
        private void Item_MouseDown(object sender, MouseEventArgs e)
        {
            Label item = (Label)sender;
            item.DoDragDrop(item.Text, DragDropEffects.Move);
        }

        #endregion

        
    }
}
