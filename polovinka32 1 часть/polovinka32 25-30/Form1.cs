using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _25
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static DateTime EasterDate(int year)
        {
            int Y = year;
            int a = Y % 19;
            int b = Y / 100;
            int c = Y % 100;
            int d = b / 4;
            int e = b % 4;
            int f = (b + 8) / 25;
            int g = (b - f + 1) / 3;

            int h = (19 * a + b - d - g + 15) % 30;
            int i = c / 4;
            int k = c % 4;
            int L = (32 + 2 * e + 2 * i - h - k) % 7;
            int m = (a + 11 * h + 22 * L) / 451;
            int month = (h + L - 7 * m + 114) / 31;
            int day = ((h + L - 7 * m + 114) % 31) + 1;
            DateTime dt = new DateTime(year, month, day);
            return dt;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(EasterDate(2006).ToLongDateString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int parrots = 38;
            MessageBox.Show(parrots.ToString("X8"));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int f = Int32.Parse(textBox1.Text);
            textBox1.Text = Convert.ToString(f, 2);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int f = Int32.Parse(textBox2.Text);
            MessageBox.Show(Convert.ToString(f, 8));
            MessageBox.Show(Convert.ToString(f, 16));
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string numstring = textBox3.Text;
            bool bResult1;
            bResult1 = Information.IsNumeric(numstring);
            MessageBox.Show("Является ли " + numstring + " числом: " + bResult1);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        static bool IsNumeric(object Expression)
        {

            bool isNum;
            double retNum;
            isNum = Double.TryParse(Convert.ToString(Expression),
            System.Globalization.NumberStyles.Any,
            System.Globalization.NumberFormatInfo.InvariantInfo, out retNum);

            return isNum;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Является ли " + textBox4.Text +
            " числом: " + IsNumeric(textBox4.Text));
        }
    }
}
