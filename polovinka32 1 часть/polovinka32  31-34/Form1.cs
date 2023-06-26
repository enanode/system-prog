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

namespace _31
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Guid newGuid = Guid.NewGuid();
            textBox1.Text = newGuid.ToString("N");
        }

        enum Cats { Рыжик = 3, Барсик = 5, Мурзик, Васька, Пушок };

        private void button2_Click(object sender, EventArgs e)
        {
            string[] catNames = Enum.GetNames(typeof(Cats));
            foreach (string s in catNames)
            {
                listBox1.Items.Add(s);
            }
            int[] valCats = (int[])Enum.GetValues(typeof(Cats));
            foreach (int val in valCats)
            {
                listBox1.Items.Add(val.ToString());
            }
            MessageBox.Show(catNames[3].ToString());
            MessageBox.Show(valCats[3].ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
                string[] allcolors =
                Enum.GetNames(typeof(System.Drawing.KnownColor));
                listBox2.Items.Clear();

                listBox2.Items.AddRange(allcolors);

            }

        private void button4_Click(object sender, EventArgs e)
        {
            Object ColorEnum;
            ColorEnum = Enum.Parse(typeof(KnownColor), listBox2.Text);
            KnownColor SelectedColor = (KnownColor)ColorEnum;
            BackColor = Color.FromKnownColor(SelectedColor);
        }
    }
    }

