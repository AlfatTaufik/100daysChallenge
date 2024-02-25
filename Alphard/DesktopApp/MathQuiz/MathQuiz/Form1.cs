using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathQuiz
{
    public partial class Form1 : Form
    {

        Random random = new Random();
        int addend1;
        int addend2;

        int minuend1;
        int minuend2;

        int multiend1;
        int multiend2;

        int dividen1;
        int divisor2;

        int timeLeft;
        public Form1()
        {
            InitializeComponent();
        }

        private void plusLeftTable_Click(object sender, EventArgs e)
        {

        }

        public void StartTheQuiz()
        {
            addend1 = random.Next(51);
            addend2 = random.Next(51);

            plusLeftTable.Text = addend1.ToString();
            plusRightTable.Text = addend2.ToString();

            sum.Value = 0;

            minuend1 = random.Next(50);
            minuend2 = random.Next(50);

            minusLeftTable.Text = minuend1.ToString();
            minusRightTable.Text = minuend2.ToString();

            difference.Value = 0;

            multiend1 = random.Next(5);
            multiend2 = random.Next(5);

            timesLeftTable.Text = multiend1.ToString();
            timeRightTable.Text = multiend2.ToString();

            product.Value = 0;

            dividen1 = random.Next(50);
            divisor2 = random.Next(50);

            dividedLeftTable.Text = dividen1.ToString();
            dividedRightTable.Text = divisor2.ToString();

            quotient.Value = 0;

            timeLeft = 40;
            timeLabel.Text = "30 Seconds";
            timer1.Start();
        }

        private bool CheckTheValue()
        {
            if (addend1 + addend2 == sum.Value && minuend1 - minuend2 == difference.Value && multiend1 * multiend2 == product.Value && dividen1 / divisor2 == difference.Value)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            StartTheQuiz();
            startButton.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        { 
            if (CheckTheValue())
            {
                timer1.Stop();
                MessageBox.Show("Good Job Brother");
                startButton.Enabled = true;
            }
            else if(timeLeft > 0)
            {
                timeLeft = timeLeft - 1;
                timeLabel.Text = timeLeft + " seconds";
            }
            else
            {
                timer1.Stop();
                timeLabel.Text = "Time Is Up !";
                MessageBox.Show("You didn't finish it", "Sorry");
                sum.Value = addend1 + addend2;
                difference.Value = minuend1 - minuend2;
                product.Value = multiend1 * multiend2;
                quotient.Value = dividen1 / divisor2;

                startButton.Enabled = true;
            }
        }
    }
}
