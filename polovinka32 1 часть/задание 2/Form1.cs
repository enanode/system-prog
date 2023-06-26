using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // Create a Random object called randomizer 
        // to generate random numbers.
        Random randomizer = new Random();
        // These integer variables store the numbers 
        // for the addition problem. 
        int addend1;
        int addend2;
        // These integer variables store the numbers 
        // for the subtraction problem. 
        int minuend;
        int subtrahend;

        // These integer variables store the numbers 
        // for the multiplication problem. 
        int multiplicand;
        int multiplier;

        // These integer variables store the numbers 
        // for the division problem. 
        int dividend;
        int divisor;

        // This integer variable keeps track of the 
        // remaining time.
        int timeLeft;
        public void StartTheQuiz()

        {

            // Fill in the addition problem.
            // Generate two random numbers to add.
            // Store the values in the variables 'addend1' and 'addend2'.
            addend1 = randomizer.Next(51);
            addend2 = randomizer.Next(51);

            // Convert the two randomly generated numbers
            // into strings so that they can be displayed
            // in the label controls.
            label3.Text = addend1.ToString();
            label5.Text = addend2.ToString();

            // 'sum' is the name of the NumericUpDown control.
            // This step makes sure its value is zero before
            // adding any values to it.
            numericUpDown1.Value = 0;

            // Fill in the subtraction problem.
            minuend = randomizer.Next(1, 101);
            subtrahend = randomizer.Next(1, minuend);
            label6.Text = minuend.ToString();
            label10.Text = subtrahend.ToString();
            numericUpDown2.Value = 0;

            // Fill in the multiplication problem.
            multiplicand = randomizer.Next(2, 11);
            multiplier = randomizer.Next(2, 11);
            label9.Text = multiplicand.ToString();
            label13.Text = multiplier.ToString();
            numericUpDown3.Value = 0;

            // Fill in the division problem.
            divisor = randomizer.Next(2, 11);
            int temporaryQuotient = randomizer.Next(2, 11);
            dividend = divisor * temporaryQuotient;
            label15.Text = dividend.ToString();
            label17.Text = divisor.ToString();
            numericUpDown4.Value = 0;


            timeLeft = 30;
            label2.Text = "30 seconds";
            timer1.Start();


        }
        /// <summary>
        /// Check the answers to see if the user got everything right.
        /// </summary>
        /// <returns>True if the answer's correct, false otherwise.</returns>
        /// 
        private bool CheckTheAnswer()
        {
            if ((addend1 + addend2 == numericUpDown1.Value)
                && (minuend - subtrahend == numericUpDown2.Value)
                && (multiplicand * multiplier == numericUpDown3.Value)
                && (dividend / divisor == numericUpDown4.Value))
                return true;
            else
                return false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void answer_Enter(object sender, EventArgs e)
        {
            // Select the whole answer in the NumericUpDown control.
            NumericUpDown answerBox = sender as NumericUpDown;

            if (answerBox != null)
            {
                int lengthOfAnswer = answerBox.Value.ToString().Length;
                answerBox.Select(0, lengthOfAnswer);
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            StartTheQuiz();
            button1.Enabled = false;
        }

        private void timer1_Tick_2(object sender, EventArgs e)
        {
            if (CheckTheAnswer())
            {
                // If CheckTheAnswer() returns true, then the user 
                // got the answer right. Stop the timer  
                // and show a MessageBox.
                timer1.Stop();
                MessageBox.Show("Вы получили правильные ответы на все вопросы!",
                                "Поздравляю!");
                button1.Enabled = true;
            }
            else if (timeLeft > 0)
            {
                // If CheckTheAnswer() returns false, keep counting
                // down. Decrease the time left by one second and 
                // display the new time left by updating the 
                // Time Left label.
                timeLeft = timeLeft - 1;
                label2.Text = timeLeft + "seconds";
            }
            else
            {
                // If the user ran out of time, stop the timer, show
                // a MessageBox, and fill in the answers.
                timer1.Stop();
                label2.Text = "Время вышло!";
                MessageBox.Show("Вы не закончили вовремя", "Извините!!");
                numericUpDown1.Value = addend1 + addend2;
                numericUpDown2.Value = minuend - subtrahend;
                numericUpDown3.Value = multiplicand * multiplier;
                numericUpDown4.Value = dividend / divisor;
                button1.Enabled = true;
            }
        }
    }
}
