﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace _11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fill = textBox1.Text;
            if (string.IsNullOrEmpty(fill))
            {
                MessageBox.Show(string.Concat("Введите имя"));
            }
            else
            {
                MessageBox.Show(string.Concat("Hello, ", fill));
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
