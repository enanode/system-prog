using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _21
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime curdate = DateTime.Now;
            // Прибавляем семь дней к текущей дате
            DateTime mydate = curdate.AddDays(7);
            MessageBox.Show(mydate.ToShortDateString());
        }
    }
}
