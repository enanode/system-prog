using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime dt = DateTime.UtcNow;
            Stopwatch sw = new Stopwatch();
            for (int i = 0; i < 10; i++)
            {
                sw.Start();
                for (int j = 0; j < 100000; j++)
                {
                    if (DateTime.UtcNow == dt)
                    {
                        /* do action */
                    }
                }
                MessageBox.Show(sw.ElapsedTicks.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            Stopwatch sw = new Stopwatch();
            for (int i = 0; i < 10; i++)
            {
                sw.Start();
                for (int j = 0; j < 100000; j++)
                {
                    if (DateTime.Now == dt)
                    {
                        /* do action */
                    }
                }
                MessageBox.Show(sw.ElapsedTicks.ToString());
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

