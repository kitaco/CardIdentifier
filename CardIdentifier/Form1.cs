using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CardIdentifier
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void twoclubsPicBox_Click(object sender, EventArgs e)
        {
            cardLabel.Text = "Two of Clubs";
        }

        private void acediamondsPicBox_Click(object sender, EventArgs e)
        {
            cardLabel.Text = "Ace of Diamonds";
        }

        private void eightspadesPicBox_Click(object sender, EventArgs e)
        {
            cardLabel.Text = "Eight of Spades";
        }

        private void kingheartsPicBox_Click(object sender, EventArgs e)
        {
            cardLabel.Text = "King of Hearts";
        }

        private void queenheartsPicBox_Click(object sender, EventArgs e)
        {
            cardLabel.Text = "Queen of Hearts";
        }
    }
}
