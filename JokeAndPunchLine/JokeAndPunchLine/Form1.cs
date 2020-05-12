using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JokeAndPunchLine
{
    public partial class JokeForm : Form
    {
        bool clicked = false;

        public JokeForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void setupBtn_Click(object sender, EventArgs e)
        {
            ResultLbl.Text = "What did the pirate say when he turned 80?";
            clicked = true;
        }

        private void PunchlineLbl_Click(object sender, EventArgs e)
        {
            if (clicked)
            {
                ResultLbl.Text = "Aye Matey";
            }
            else
            {
                MessageBox.Show("You have to read the setup first!","Hold On!");
            }
        }
    }
}
