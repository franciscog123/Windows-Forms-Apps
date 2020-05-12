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
    public partial class CardIdForm : Form
    {
        public CardIdForm()
        {
            InitializeComponent();
        }

        private void KSpdPicBox_Click(object sender, EventArgs e)
        {
            CardNameLbl.Text = "King of Spades";
        }

        private void JkrPicBox_Click(object sender, EventArgs e)
        {
            CardNameLbl.Text = "Joker Black";
        }

        private void ASpsPicBox_Click(object sender, EventArgs e)
        {
            CardNameLbl.Text = "Ace of Spades";
        }

        private void EightDmdPicBox_Click(object sender, EventArgs e)
        {
            CardNameLbl.Text = "Eight of Diamonds";
        }

        private void TwoClbPicBox_Click(object sender, EventArgs e)
        {
            CardNameLbl.Text = " Two of Clubs";
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
