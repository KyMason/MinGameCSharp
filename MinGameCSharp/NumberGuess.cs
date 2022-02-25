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
        public NumberGuess()
        {
            InitializeComponent();
            GenerateNum();
        }

        public int GenerateNum()
        {

            System.Random random = new System.Random();
            int correcNum = random.Next(100);
            return correcNum;
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

        }
    }
}
