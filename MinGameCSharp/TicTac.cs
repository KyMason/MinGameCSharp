using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MinGameCSharp
{
    public partial class TicTac : Form
    {
        bool turnStarter = true;
        int points = 0;

        int oneone;
        int onetwo;
        int onethree;
        int twoone;
        int twotwo;
        int twothree;
        int threeone;
        int threetwo;
        int threethree;

        public TicTac()
        {
            InitializeComponent();
            gameStart();
        }
        static void counter ()
        { 
        
        }

        public void gameStart()
        {

             oneone=0;
             onetwo=0;
             onethree=0;
             twoone=0;
             twotwo=0;
             twothree=0;
             threeone=0;
            threetwo=0;
             threethree =0;


            if (turnStarter)
                userTurn();
            else
                computerTurn();
        }
        public void userTurn()
        {

            if (oneone<2)
                button11.Enabled = true;
            if (onetwo<2)
                button12.Enabled = true;
            if(onethree<2)
                button13.Enabled = true;
            if(twoone<2)
                button21.Enabled = true;
            if(twotwo<2)
                button22.Enabled = true;
            if(twothree<2)
                button23.Enabled = true;
            if(threeone<2)
                button31.Enabled = true;
            if(threetwo<2)
                button32.Enabled = true;
            if(threethree<2)
                button33.Enabled = true;

        }
        public void computerTurn()
        {
            button11.Enabled = false;
            button12.Enabled = false;
            button13.Enabled = false;
            button21.Enabled = false;
            button22.Enabled = false;
            button23.Enabled = false;
            button31.Enabled = false;
            button32.Enabled = false;
            button33.Enabled = false;

            System.Random random = new System.Random();
            int i = random.Next(9);

            if (i == 0 && oneone < 2)
                button11.BackColor = Color.Blue;
            else if (i == 1 && onetwo < 2)
                button12.BackColor = Color.Blue;
            else if (i == 2 && onethree < 2)
                button12.BackColor = Color.Blue;
            else if (i == 3 && twoone < 2)
                button12.BackColor = Color.Blue;
            else if (i == 4 && twotwo < 2)
                button12.BackColor = Color.Blue;
            else if (i == 5 && twothree < 2)
                button12.BackColor = Color.Blue;
            else if (i == 6 && threeone < 2)
                button12.BackColor = Color.Blue;
            else if (i == 7 && threetwo < 2)
                button12.BackColor = Color.Blue;
            else if (i == 8 && threethree < 2)
                button12.BackColor = Color.Blue;
            else
                computerTurn();

            userTurn();
        }

        private void againButton_Click(object sender, EventArgs e)
        {
            if (turnStarter)
                turnStarter = false;
            else
                turnStarter = true;

            gameStart();

        }

        private void button11_Click(object sender, EventArgs e)
        {
            oneone = 3;
            button11.BackColor = Color.Red;
            computerTurn();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            onetwo = 3;
            button12.BackColor = Color.Red;
            computerTurn();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            onethree = 3;
            button13.BackColor = Color.Red;
            computerTurn();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            twoone = 3;
            button21.BackColor = Color.Red;
            computerTurn();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            twotwo = 3;
            button22.BackColor = Color.Red;
            computerTurn();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            twothree = 3;
            button23.BackColor = Color.Red;
            computerTurn();
        }

        private void button31_Click(object sender, EventArgs e)
        {
            threeone = 3;
            button31.BackColor = Color.Red;
            computerTurn();
        }

        private void button32_Click(object sender, EventArgs e)
        {
            threetwo = 3;
            button32.BackColor = Color.Red;
            computerTurn();
        }

        private void button33_Click(object sender, EventArgs e)
        {
            threethree = 3;
            button33.BackColor = Color.Red;
            computerTurn();
        }
    }
}

/*user is red and computer is blue.
 * every red is one point and every blue is 10 points
 * if a full row, full column, or full diagonal = 3 then user win
 * if a full row, full column, or full diagonal = 30 then computer wins
 * if all buttons pushed and none of above happen then draw
 */
