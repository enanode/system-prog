using System.ComponentModel;

namespace _2._1___2._10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string partBookTitle = first.Text;
            string insertText = second.Text;
            string bookTitle = partBookTitle.Insert(3, insertText);
            MessageBox.Show(bookTitle);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string bookTitle = first.Text;
            int position = Convert.ToInt32(second.Text);
            bookTitle = bookTitle.Remove(position);
            MessageBox.Show(bookTitle);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string bookTitle = first.Text;
            // Извлекаем подстроку с шестой позиции с размером в три символа
            bookTitle = bookTitle.Substring(5, 3);
            MessageBox.Show(bookTitle);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string str1 = first.Text;
            string str2 = second.Text;
            int i = str2.IndexOf(str1);
            if (i >= 0) MessageBox.Show(str1 + " входит в строку " + str2);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string tankman = first.Text;
            string dog = second.Text;
            int all = int.Parse(tankman) + int.Parse(dog);
            MessageBox.Show(all.ToString());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int charCode = Convert.ToInt32(first.Text);
            char specialChar = Convert.ToChar(charCode);
            first.Text = specialChar.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int charCode = 0x00AE;
            char specialChar = Convert.ToChar(charCode);
            first.Text += specialChar.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            System.String FiveStars = new System.String('*', 5);
            first.Text = FiveStars;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string AutoName = first.Text;
            int PriceAuto = Convert.ToInt32(second.Text);
            MessageBox.Show(String.Format("Стоимость {0} равна {1:0.0;c}", AutoName, PriceAuto));

        }

        private void button9_Click(object sender, EventArgs e)
        {
            // Задаем цвет
            Color clr = Color.Green;
            // Получим имя выбранного цвета
            first.Text =
            (TypeDescriptor.GetConverter(clr).ConvertToString(clr));
            // Обратная задача. Конвертируем название цвета Green в объект Color
            clr = (Color)TypeDescriptor.GetConverter(
            typeof(Color)).ConvertFromString(second.Text);
            // Закрашиваем форму в выбранный цвет
            this.BackColor = clr;
        }
    }
}