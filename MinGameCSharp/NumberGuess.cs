using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MinGameCSharp
{
    public partial class NumberGuess : Form
    {
        int guessNum;
        int correcNum;
        int incorrectCount = 0;
        int pointTotal = 0;

        public NumberGuess()
        {
            InitializeComponent();
            GenerateNum();
        }

        public void GenerateNum()
        {
            System.Random random = new System.Random();
            correcNum = random.Next(100);
        }

        public void waitRoom()
        {
            infoBox.Text = "Please enter a number 1-100";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            infoBox.Text = "";
            try
            {
                guessNum = int.Parse(userInpBox.Text);
            }
            catch
            {
                waitRoom();
            }
            if (guessNum > 100)
                waitRoom();
            if (guessNum < 1)
                waitRoom();
            CheckforMatch();
        }

        private void CheckforMatch()
        {

            string ineq = "";

            if (guessNum == correcNum)
            {
                infoBox.Text = "Congrats you did it!";
                againButton.Enabled = true;
                button1.Enabled = false;
                pointTotal++;
            }
            incorrectCount++;
            if (incorrectCount == 9)
            {
                infoBox.Text = "Sorry the correct number is " + correcNum + ".";
                againButton.Enabled = true;
                button1.Enabled = false;
            }

            if (guessNum < correcNum)
            {
                ineq = ">";
                infoBox.Text = "Too low";
            }
            else if (guessNum > correcNum)
            {
                ineq = "<";
                infoBox.Text = "Too high";
            }
            else
                ineq = "=";

            switch (incorrectCount)
            {
                case 1:
                    ineqBox1.Text = ineq;
                    inNumBox1.Text = guessNum.ToString();
                    break;
                case 2:
                    ineqBox2.Text = ineq;
                    inNumBox2.Text = guessNum.ToString();
                    break;
                case 3:
                    ineqBox3.Text = ineq;
                    inNumBox3.Text = guessNum.ToString();
                    break;
                case 4:
                    ineqBox4.Text = ineq;
                    inNumBox4.Text = guessNum.ToString();
                    break;
                case 5:
                    ineqBox5.Text = ineq;
                    inNumBox5.Text = guessNum.ToString();
                    break;
                case 6:
                    ineqBox6.Text = ineq;
                    inNumBox6.Text = guessNum.ToString();
                    break;
                case 7:
                    ineqBox7.Text = ineq;
                    inNumBox7.Text = guessNum.ToString();
                    break;
                case 8:
                    ineqBox8.Text = ineq;
                    inNumBox8.Text = guessNum.ToString();
                    break;
                case 9:
                    ineqBox9.Text = ineq;
                    inNumBox9.Text = guessNum.ToString();
                    break;
            }
            pointDisplay.Text = pointTotal.ToString();
        }
        private void againButton_Click(object sender, EventArgs e)
        {
            incorrectCount = 0;
            button1.Enabled = true;
            againButton.Enabled = false;
            infoBox.Text = "";

            ineqBox1.Text = "";
            inNumBox1.Text = "";
            ineqBox2.Text = "";
            inNumBox2.Text = "";
            ineqBox3.Text = "";
            inNumBox3.Text = "";
            ineqBox4.Text = "";
            inNumBox4.Text = "";
            ineqBox5.Text = "";
            inNumBox5.Text = "";
            ineqBox6.Text = "";
            inNumBox6.Text = "";
            ineqBox7.Text = "";
            inNumBox7.Text = "";
            ineqBox8.Text = "";
            inNumBox8.Text = "";
            ineqBox9.Text = "";
            inNumBox9.Text = "";

            GenerateNum();
        }
    }
}
