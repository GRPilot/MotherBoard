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
    public partial class SettingWindow : Form
    {
        bool formClosed;
        Form mainFrom;
        public SettingWindow(Form OutMainForm)
        {
            mainFrom = OutMainForm;
            InitializeComponent();
            formClosed = true;
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            formClosed = false;
            mainFrom.Show();
            Close();
        }

        private void SettingWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (formClosed)
                mainFrom.Close();
        }
    }
}
