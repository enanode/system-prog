using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            scrollText = scrollText.Substring(1, (scrollText.Length - 1)) + scrollText.Substring(0, 1);
            this.Text = scrollText;
        }
        private string scrollText = "доктор подходит к пациенту и говорит\r\nу меня две новости одна плохая другая тоже \r\nпациент отвечает\r\nну давайте с полохой\r\nу вас рак\r\nтак а другая плохая ?\r\nу вас альцгемер\r\nну хорошщо что не рак......";
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }
    }
}
