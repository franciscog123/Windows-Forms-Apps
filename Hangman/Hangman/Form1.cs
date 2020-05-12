using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hangman
{
    public partial class hangmanFrm : Form
    {
        Random randomNumbers = new Random(); 
        int rand; //stores random number
        int numTries; //stores which try the user is on
        int numGuessed; //stores the user input number
        Boolean youWin = false; //flag, becomes true when number is guessed correctly

        public hangmanFrm()
        {
            InitializeComponent();
            rand = randomNumbers.Next(100)+1; //generate random number from 1 to 100, sets it to variable rand
            inputTxtBox.Focus(); 
        }

        //checks which try the user is on and displays appropriate image
        private void GuessBtn_Click(object sender, EventArgs e)
        {
            //increments number of tries each time button is clicked
            numTries++;

            switch(numTries)
            {
                case 1:
                    hangmanPicBox.Image = Hangman.Properties.Resources.hangman01;
                    checkNumber(); 
                    break;
                case 2:
                    hangmanPicBox.Image = Hangman.Properties.Resources.hangman02;
                    checkNumber();
                    break;
                case 3:
                    hangmanPicBox.Image = Hangman.Properties.Resources.hangman05;
                    checkNumber();
                    break;
                case 4:
                    hangmanPicBox.Image = Hangman.Properties.Resources.hangman06;
                    checkNumber();
                    break;
                case 5:
                    hangmanPicBox.Image = Hangman.Properties.Resources.hangman07;
                    checkNumber();
                    break;
                case 6:
                    //ends game, if user does not guess correct number shows appropriate image and prompt, ends current game
                    checkNumber();
                    if(youWin==false)
                    {
                        hangmanPicBox.Image = Hangman.Properties.Resources.dead;
                        resultLbl.Text = "Mwa ha ha... \nI knew you would fail...\nThe number was " + rand;
                        gameOver();
                    }
                    break;
            }
            inputTxtBox.Text = "";
            inputTxtBox.Focus();
        }

        //checks if user enters a valid integer, if valid integer, checks if input number is less than, greater than, or equal to random number
        private void checkNumber()
        {
            
            if(Int32.TryParse(inputTxtBox.Text, out numGuessed) && numGuessed >= 1 && numGuessed <= 100)
            {
                if (numGuessed < rand)
                {
                    resultLbl.Text = "The number is greater than " + numGuessed;
                }
                else if (numGuessed > rand)
                {
                    resultLbl.Text = "The number is less than " + numGuessed;
                }
                else
                {
                    //if user input number is equal to random number displays appropriate image, sets flag to true, ends current game
                    resultLbl.Text = "You win...\nthis time";
                    hangmanPicBox.Image = Hangman.Properties.Resources.yay;
                    youWin = true;
                    gameOver();
                }
            }
            //if user does not enter a valid integer, displays appropriate prompt
            else
            {
                resultLbl.Text = "You will regret that.  Enter a valid number you fool!";
            }
           
        }

        //disables appropriate controls, makes newGame group box and radio buttons visible
        private void gameOver()
        {
            inputTxtBox.Enabled = false;
            GuessBtn.Enabled = false;
            newGameGrpBox.Visible = true;
            yesRadBtn.Visible = true;
            noRadBtn.Visible = true;
        }

        //resets form
        private void yesRadBtn_CheckedChanged(object sender, EventArgs e)
        {
            resetForm();
        }

        //closes form
        private void noRadBtn_CheckedChanged(object sender, EventArgs e)
        {
            this.Close();
        }

        //resets all variables and controls to initial values and states
        private void resetForm()
        {
            rand = randomNumbers.Next(100) + 1;
            numTries = 0;
            numGuessed = 0;
            youWin = false;

            inputTxtBox.Enabled = true;
            GuessBtn.Enabled = true;
            newGameGrpBox.Visible = false;
            yesRadBtn.Visible = false;
            noRadBtn.Visible = false;

            resultLbl.Text = "Enter your guess below";
            inputTxtBox.Text = "";

            yesRadBtn.Checked = false;
            noRadBtn.Checked = false;
            inputTxtBox.Focus();
            hangmanPicBox.Image = Hangman.Properties.Resources.Hangman_Game_red;
        }
    }
}
