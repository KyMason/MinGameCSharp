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
        char userLetter;

        string[] wordsArray = { "fishy","funky","lemonade","whisker","southern","spider","dormant","shelf","blanket","video",
            "guinea","ruins","survey","parents","himself","bingo","saber","bench","paying","moustache"};
        string choseWord;

        bool correclet1 = false;
        bool correclet2 = false;
        bool correclet3 = false;
        bool correclet4 = false;
        bool correclet5 = false;
        bool correclet6 = false;
        bool correclet7 = false;
        bool correclet8 = false;
        bool correclet9 = false;

        int incoCount = 0;
        int winCount = 0;

        public WordGuess()
        {
            InitializeComponent();
            RandomStart();
        }

        public void RandomStart()
        {
            LetterBox1.Text = "";
            LetterBox2.Text = "";
            letterBox3.Text = "";
            letterBox4.Text = "";
            letterBox5.Text = "";
            letterBox6.Text = "";
            letterBox7.Text = "";
            letterBox8.Text = "";
            letterBox9.Text = "";
            wrongBox1.Text = "";
            wrongBox2.Text = "";
            wrongBox3.Text = "";
            wrongBox4.Text = "";
            wrongBox5.Text = "";
            incoCount = 0;

            letterBox6.Visible = true;
            letterBox7.Visible = true;
            letterBox8.Visible = true;
            letterBox9.Visible = true;

            enterButton.Enabled = true;
            userInpBox1.Enabled = true;
            AgainButton.Enabled = false;

            System.Random random = new System.Random();
            int i = random.Next(21);
            choseWord = wordsArray[i];

            if (choseWord.Length == 5)
            {
                letterBox6.Visible = false;
                letterBox7.Visible = false;
                letterBox8.Visible = false;
                letterBox9.Visible = false;
            }
            else if (choseWord.Length == 6)
            {
                letterBox7.Visible = false;
                letterBox8.Visible = false;
                letterBox9.Visible = false;
            }
            else if (choseWord.Length == 7)
            {
                letterBox8.Visible = false;
                letterBox9.Visible = false;
            }
            else if (choseWord.Length == 8)
                letterBox9.Visible = false;

        }

        private void WordHang_Load(object sender, EventArgs e)
        {
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            if (char.IsLetter(userInpBox1.Text, 0))
            {
                userLetter = userInpBox1.Text[0];
                infoBox.Text = userInpBox1.Text;
            }
            else
                infoBox.Text = "Please enter a letter.";

            MatchCheck(userLetter);
        }
        
        public void MatchCheck(char userLetter)
        {
            char choseletter1 = choseWord[0];
            char choseletter2 = choseWord[1];
            char choseletter3 = choseWord[2];
            char choseletter4 = choseWord[3];
            char choseletter5 = choseWord[4];
            char choseletter6 = (char)1;
            char choseletter7=(char)1;
            char choseletter8=(char)1;
            char choseletter9=(char)1;

            switch (choseWord.Length)
            {
                case 6:
                    choseletter6 = choseWord[5];
                    break;
                case 7:
                    choseletter6 = choseWord[5];
                    choseletter7 = choseWord[6];
                    break;
                case 8:
                    choseletter6 = choseWord[5];
                    choseletter7 = choseWord[6];
                    choseletter8 = choseWord[7];
                    break;
                case 9:
                    choseletter6 = choseWord[5];
                    choseletter7 = choseWord[6];
                    choseletter8 = choseWord[7];
                    choseletter9 = choseWord[8];
                    break;
            }

            if (userLetter == choseletter1 && correclet1 == false)
            {
                correclet1 = true;
                LetterBox1.Text = choseletter1.ToString();
            }
            else if (userLetter == choseletter2 && correclet2 == false)
            {
                correclet2 = true;
                LetterBox2.Text = choseletter2.ToString();
            }
            else if (userLetter == choseletter3 && correclet3 == false)
            {
                correclet3 = true;
                letterBox3.Text = choseletter3.ToString();
            }
            else if (userLetter == choseletter4 && correclet4 == false)
            {
                correclet4 = true;
                letterBox4.Text = choseletter4.ToString();
            }
            else if (userLetter == choseletter5 && correclet5 == false)
            {
                correclet5 = true;
                letterBox5.Text = choseletter5.ToString();
            }
            else if (userLetter == choseletter6 && correclet6 == false)
            {
                correclet6 = true;
                letterBox6.Text = choseletter6.ToString();
            }
            else if (userLetter == choseletter7 && correclet7 == false)
            {
                correclet7 = true;
                letterBox7.Text = choseletter7.ToString();
            }
            else if (userLetter == choseletter8 && correclet8 == false)
            {
                correclet8 = true;
                letterBox8.Text = choseletter8.ToString();
            }
            else if (userLetter == choseletter9 && correclet9 == false)
            {
                correclet9 = true;
                letterBox9.Text = choseletter9.ToString();
            }
            else
            {
                incoCount++;
                infoBox.Text = "That is incorrect. Try again.";
            }
            if (incoCount == 1)
                wrongBox1.Text = userLetter.ToString();
            else if (incoCount == 2)
                wrongBox2.Text = userLetter.ToString();
            else if (incoCount == 3)
                wrongBox3.Text = userLetter.ToString();
            else if (incoCount == 4)
                wrongBox4.Text = userLetter.ToString();
            else if (incoCount == 5)
                wrongBox5.Text = userLetter.ToString();
            else if (incoCount == 6)
                LostState();
  
            switch (choseWord.Length)
            {
                case 6:
                    if (correclet1 == true && correclet2 == true && correclet3 == true && correclet4 == true && correclet5 == true && correclet6 == true)
                        WonState();
                    break;
                case 7:
                    if (correclet1 == true && correclet2 == true && correclet3 == true && correclet4 == true && correclet5 == true && correclet6 == true && correclet7 == true)
                        WonState();
                    break;
                case 8:
                    if (correclet1 == true && correclet2 == true && correclet3 == true && correclet4 == true && correclet5 == true && correclet6 == true && correclet7 == true && correclet8 == true)
                        WonState();
                    break;
                case 9:
                    if (correclet1 == true && correclet2 == true && correclet3 == true && correclet4 == true && correclet5 == true && correclet6 == true && correclet7 == true && correclet8 == true && correclet9 == true)
                        WonState();
                    break;
                default:
                    if (correclet1 == true && correclet2 == true && correclet3 == true && correclet4 == true && correclet5 == true)
                        WonState();
                    break;
            }

        }
        public void LostState()
        {
            userInpBox1.Enabled = false;
            enterButton.Enabled = false;
            AgainButton.Enabled = true;

            correclet1 = false;
            correclet2 = false;
            correclet3 = false;
            correclet4 = false;
            correclet5 = false;
            correclet6 = false;
            correclet7 = false;
            correclet8 = false;
            correclet9 = false;

            infoBox.Text = "You lost";
        }
       public void WonState()
        {
            enterButton.Enabled = false;
            userInpBox1.Enabled = false;
            AgainButton.Enabled = true;

            winCount++;
            pointTrack.Text = winCount.ToString();

            correclet1 = false;
            correclet2 = false;
            correclet3 = false;
            correclet4 = false;
            correclet5 = false;
            correclet6 = false;
            correclet7 = false;
            correclet8 = false;
            correclet9 = false;

            infoBox.Text = "You Win!";
        }

        private void AgainButton_Click(object sender, EventArgs e)
        {
            RandomStart();
        }

    }
}
