using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _13_1_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
            {
                textBox1.Text = ReverseString(textBox1.Text);

                //string str = Fill.Text;
                //StringBuilder revStr = new StringBuilder(str.Length);
                //if (String.IsNullOrEmpty(str))
                //{
                //MessageBox.Show("Введите что-нибудь");
                //}
                //else
                //{
                //for (int count = str.Length - 1; count > -1; count--)
                //{
                //revStr.Append(str[count]);
                //}
                //revStr.ToString();
                //}

            }
            public static string ReverseString(string str)
            {
                // Проверка на непустоту строки.
                if (string.IsNullOrEmpty(str))
                {
                    return str;
                }
                // Создадим объект StringBuilder с нужной длиной.
                StringBuilder revStr = new StringBuilder(str.Length);
                // Перебираем в цикле все символы
                // и присоединяем каждый символ к StringBuilder
                for (int count = str.Length - 1; count > -1; count--)
                {
                    revStr.Append(str[count]);
                }
                // Возвращаем перевернутую строку
                return revStr.ToString();
            }
        }
    }
