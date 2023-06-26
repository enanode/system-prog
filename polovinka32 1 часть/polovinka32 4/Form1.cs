using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str1 = "кол";
            string str2 = "Царь-колокол";
            int i = str2.IndexOf(str1);
            if (i >= 0) MessageBox.Show(str1 + " входит в строку " + str2);
        }
    }
}
