using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

      
        private void button1_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(textBox1.Text);
            int y = Convert.ToInt32(textBox2.Text);
            int z = Convert.ToInt32(textBox3.Text);
            MessageBox.Show(" Наибольшее число из трех: " +
            FindMax3(x, y, z) + "  Наименьшее число из трех: " +
            FindMin3(x, y, z));
        }
        public static int FindMax3(int a, int b, int c)
        {
            int max;
            max = Math.Max(a, Math.Max(b, c));
            return max;
        }
        public static int FindMin3(int a, int b, int c)
        {
            int min;
            min = Math.Min(a, Math.Min(b, c));
            return min;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int text = Convert.ToInt32(textBox4.Text);
            String[] s = Regex.Split("Январь Февраль Март Апрель Май Июнь Июль Август Сентябрь Октябрь Ноябрь Декабрь", " ");
            MessageBox.Show(s[text]);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int degrees = Convert.ToInt32(textBox5.Text);
            double radians = (Math.PI / 180) * degrees;
            MessageBox.Show(Convert.ToString(radians));
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int radians = Convert.ToInt32(textBox6.Text);
            double degrees = (180 / Math.PI) * radians;
            MessageBox.Show(Convert.ToString(degrees));
        }
    }
}
