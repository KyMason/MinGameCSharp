using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MinGameCSharp
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WordGuess WH = new WordGuess();
            WH.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NumberGuess NG = new NumberGuess();
            NG.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TicTac TT = new TicTac();
            TT.Show();
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {

        }
    }
}
