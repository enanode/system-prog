using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _22
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime date1 = new DateTime(1945, 5, 9); // Первая дата
            DateTime date2 = new DateTime(2007, 8, 21); // Вторая дата
                                                        // Вычисляем разницу в днях при помощи перечисления DateInterval.Day
            long diff = DateAndTime.DateDiff(DateInterval.Day, date1, date2,
            FirstDayOfWeek.Monday, FirstWeekOfYear.System);
            // Выводим результат в заголовке формы
            this.Text = diff.ToString();
        }
    }
}
