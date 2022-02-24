using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MinGameCSharp
{
    public partial class WordGuess : Form
    {
        char choseLetter;

        string[] wordsArray= new string [20];

        public WordGuess()
        {
            InitializeComponent();
        }

        public void RandomStart()
        {
            System.Random random = new System.Random();
            int i = random.Next(21);
            string choseWord = wordsArray[i];
           
        }

        private void WordHang_Load(object sender, EventArgs e)
        {

        }

        private void enterButton_Click(object sender, EventArgs e)
        {

            if (char.IsLetter(userInpBox1.Text, 0))
            {
                choseLetter = userInpBox1.Text[0];
                infoBox.Text = userInpBox1.Text;
            }
            else
                infoBox.Text = "Please enter a letter.";

        }
        private void checkMatch()
        {

        }

    }
}
