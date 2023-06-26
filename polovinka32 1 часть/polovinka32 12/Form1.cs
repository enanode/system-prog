using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace _12_1_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Взять текст из текстового поля
            // Например, А роза упала на лапу Азора
            string myString = textBox1.Text;
            // Используем встроенную функцию Visual Basic
            textBox1.Text = Strings.StrReverse(myString);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
