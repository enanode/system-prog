using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string firstletter = textBox1.Text;
            string secondletter = textBox3.Text;

            int all = int.Parse(textBox3.Text) + int.Parse(textBox1.Text);
            textBox2.Text += all.ToString();
        }
    }
}
