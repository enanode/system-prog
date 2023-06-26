using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _23
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime dt1, dt2;
            TimeSpan delta;
            //dt1 = DateTime.Parse(textBox1.Text);
            dt1 = DateTime.Parse(dateTimePicker1.Text);
            dt2 = DateTime.Parse(dateTimePicker2.Text);
            delta = dt1 - dt2;
            MessageBox.Show(delta.Days.ToString());
        }
       }
  }

