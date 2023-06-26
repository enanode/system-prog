using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string AutoName;
            AutoName = "BMW";
            textBox1.Text =
            String.Format("Стоимость {0} равна {1:0.0;c}", AutoName, 12000000);
        }
    }
}
