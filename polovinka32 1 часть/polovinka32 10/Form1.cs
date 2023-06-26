using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Задаем цвет
            Color clr = Color.Green;
            // Получим имя выбранного цвета
            textBox1.Text =
            (TypeDescriptor.GetConverter(clr).ConvertToString(clr));
            // Обратная задача. Конвертируем название цвета Green в объект Color
            clr = (Color)TypeDescriptor.GetConverter(
            typeof(Color)).ConvertFromString("Green");
            // Закрашиваем форму в выбранный цвет
            this.BackColor = clr;
        }
    }
}
