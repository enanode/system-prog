using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        [DllImport("shlwapi.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern bool PathCompactPathEx(
       System.Text.StringBuilder pszOut,
       string pszSrc,
       Int32 cchMax,
       Int32 dwFlags);
        private void button1_Click(object sender, EventArgs e)
        {
            // длинный путь к файлу
            string strPathFile =
            "C:\\Program Files\\7-Zip\\History.txt";
            StringBuilder sb = new StringBuilder(260);
            // оставляем 20 символов, остальное заменяем многоточием
            bool b = PathCompactPathEx(sb, strPathFile, 20 + 1, 0);
            // Выводим результат в текстовое поле
            textBox1.Text = sb.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
