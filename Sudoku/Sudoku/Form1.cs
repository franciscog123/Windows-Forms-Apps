using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace Sudoku
{
    public partial class sudokuFrm : Form
    {
        StreamReader inputFile;
        Random randomNumbers = new Random(); 
        Button[] buttonRay; //1D array of buttons,used in populate, button_keyPress, and cellMouseClick methods
        char[,] allCombos; //2D array, will hold all char from text file
        int charRayRowSize; //represents how many rows allCombos 2d char array has
        int charRayColSize; //represents how many columns allCombos 2D char arrray has
        int rand; //will hold randomly generated number
        bool terminated; //flag, set to true if unable to open file, prevents compilation errors

        Button[,] twoDButtonRay; //twoD array of buttons, used to check for duplicates in rows and columns
        Button[] quadrantOne; //oneD array of buttons, used to check top left quadrant of buttons for duplicates
        Button[] quadrantTwo; //oneD array of buttons, used to check top right quadrant of buttons for duplicates
        Button[] quadrantThree; //oneD array of buttons, used to check bottom left quadrant of buttons for duplicates
        Button[] quadrantFour; //oneD array of buttons, used to check bottom right quadrant of buttons for duplicates

        public sudokuFrm()
        {
            InitializeComponent();   
        }

        //returns a count of how many lines or rows the file has
        public int countFileRows()
        {
            int numLines = 0;
            
            //prevents compilation error if text file is not found
            if(!terminated)
            {
                while (inputFile.ReadLine() != null)
                {
                    numLines++;
                }
            }
            return numLines;
        }

        //returns how many characters are in the first row or line of text file
        public int countFileColumns()
        {
            string line = "";

            //prevents compilation error if text file is not found
            if (!terminated)
            {
                //resets StreamReader to beginning of file
                inputFile.DiscardBufferedData();
                inputFile.BaseStream.Seek(0, SeekOrigin.Begin);

                //reads first line in file, returns length of line
                line = inputFile.ReadLine();
            }      
            return line.Length;
        }

        //fills 2D character array with each character from text file
        private void fillCharArray()
        {
            string line = "";

            //prevents compilation error if text file is not found
            if (!terminated)
            {
                //resets StreamReader to beginning of file
                inputFile.DiscardBufferedData();
                inputFile.BaseStream.Seek(0, SeekOrigin.Begin);

                //populates 2D char array allCombos with each individual char in text file
                for (int row = 0; row < allCombos.GetLength(0); row++)
                {
                    line = inputFile.ReadLine();
                    for (int col = 0; col < allCombos.GetLength(1); col++)
                    {
                        allCombos[row, col] = line[col];
                    }
                }

                //close file
                inputFile.Close();
            } 
        }

        //populates all buttons with a random row from 2D char array
        private void populate()
        {
            //generate a random number that will be used as the row position for the 2D char array
            rand=randomNumbers.Next(charRayRowSize);

            //loops step through  a single random row in 2D char array
            for (int col = 0; col < allCombos.GetLength(1); col++)
            {
                //if there is a 0 in that position clears text and disables button in button array, otherwise displays number in the button
                if (allCombos[rand, col].Equals('0'))
                {
                    buttonRay[col].Text = "";
                    buttonRay[col].Enabled = true;
                }
                else
                {
                    buttonRay[col].Text = allCombos[rand, col].ToString();
                    buttonRay[col].Enabled = false;
                }
            }
            
            //sets the title of the form to the random row that is being used to fill button array
            this.Text = "Sudoku 4X4 (" + (rand+1) + " out of 12)";
        }

        private void checkBtn_Click(object sender, EventArgs e)
        {
            
            //Checks to see if player has put a value in each button, if not, ends the method 
            foreach(Button b in buttonRay)
            {
                if(b.Text=="")
                {
                    MessageBox.Show("Finish the puzzle first.\n     You can do it!", "Don't be lazy >:-(");
                    return;
                }
            }

            string num = "";
            string num2 = "";

            bool rowsHaveDuplicates = false;

            

            
            //checks for matching values in all rows
            for (int row=0;row<4;row++)
            {
                for (int x = 0; x < 3; x++)
                {
                    num = twoDButtonRay[row, x].Text;
                    for (int y = x + 1; y < 4; y++)
                    {
                        num2 = twoDButtonRay[row, y].Text;
                        if (num == num2)
                        {
                            rowsHaveDuplicates = true;
                        }
                    }
                }
            }
            

            bool colsHaveDuplicates = false;
          
            //checks for matching values in all columns
            for(int col=0;col<4;col++)
            {
                for (int x = 0; x < 3; x++)
                {
                    num = twoDButtonRay[x, col].Text;
                    for (int y = x + 1; y < 4; y++)
                    {
                        num2 = twoDButtonRay[y, col].Text;
                        if (num == num2)
                        {
                            colsHaveDuplicates = true;
                        }
                    }
                }
            }

            bool quadOneHasDuplicates = false;
            
            //checks first quadrant(4X4) values for duplicates 
            for(int x=0;x<3;x++)
            {
                num = quadrantOne[x].Text;
                for( int y = x+1; y < 4;y++)
                 {
                    num2 = quadrantOne[y].Text;
                    if(num==num2)
                    {
                        quadOneHasDuplicates = true;
                    }
                 }
            }

            bool quadTwoHasDuplicates = false;

            //checks second quadrant(4X4) values for duplicates 
            for (int x = 0; x < 3; x++)
            {
                num = quadrantTwo[x].Text;
                for (int y = x + 1; y < 4; y++)
                {
                    num2 = quadrantTwo[y].Text;
                    if (num == num2)
                    {
                        quadTwoHasDuplicates = true;
                    }
                }
            }

            bool quadThreeHasDuplicates = false;

            //checks third quadrant(4X4) values for duplicates 
            for (int x = 0; x < 3; x++)
            {
                num = quadrantThree[x].Text;
                for (int y = x + 1; y < 4; y++)
                {
                    num2 = quadrantThree[y].Text;
                    if (num == num2)
                    {
                        quadThreeHasDuplicates = true;
                    }
                }
            }

            bool quadFourHasDuplicates = false;

            //checks fourth quadrant(4X4) values for duplicates 
            for (int x = 0; x < 3; x++)
            {
                num = quadrantFour[x].Text;
                for (int y = x + 1; y < 4; y++)
                {
                    num2 = quadrantFour[y].Text;
                    if (num == num2)
                    {
                        quadFourHasDuplicates = true;
                    }
                }
            }

            //if(quadOneHasDuplicates)
            //if there are no matching values in all rows, columns, and quadrants, congratulates player. if not, tells player to keep trying. 
            if (rowsHaveDuplicates||colsHaveDuplicates||quadOneHasDuplicates||quadTwoHasDuplicates||quadThreeHasDuplicates||quadFourHasDuplicates)
            {
                MessageBox.Show("Sorry, you don't have the right answer yet.\n\t    Keep trying!","Don't give up!");
            }
            else
            {
                MessageBox.Show("Yay, you finished the puzzle!!!","Congratulations!");
            }
        }

        private void restartBtn_Click(object sender, EventArgs e)
        {
            populate();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void sudokuFrm_Load(object sender, EventArgs e)
        {
            //catch exception if unable to open file
            try
            {
                inputFile = File.OpenText("sudokuConfig.txt");
            }
            catch
            {
                MessageBox.Show("Error is I/O operation\nProgram will terminate now",
                   " === Error ===");
                terminated = true;  
                this.Close();
            }

            charRayRowSize = countFileRows();
            charRayColSize = countFileColumns();

            // Fill out the allCombos array with all every possible configration
            allCombos = new char[charRayRowSize, charRayColSize];
            fillCharArray();

            //reference each button array with appropriate buttons and positions
            buttonRay = new Button[] { loc1Btn, loc2Btn, loc3Btn, loc4Btn, loc5Btn, loc6Btn, loc7Btn, loc8Btn, loc9Btn, loc10Btn, loc11Btn, loc12Btn, loc13Btn, loc14Btn, loc15Btn, loc16Btn };
            twoDButtonRay = new Button[,] { { loc1Btn,loc2Btn,loc5Btn,loc6Btn }, {loc3Btn,loc4Btn,loc7Btn,loc8Btn}, {loc9Btn,loc10Btn,loc13Btn,loc14Btn}, { loc11Btn, loc12Btn, loc15Btn, loc16Btn } };
            quadrantOne = new Button[] {loc1Btn,loc2Btn, loc3Btn, loc4Btn };
            
            quadrantTwo = new Button[] { loc5Btn, loc6Btn, loc7Btn, loc8Btn };
            quadrantThree = new Button[] { loc9Btn, loc10Btn, loc11Btn, loc12Btn };
            quadrantFour = new Button[] { loc13Btn, loc14Btn, loc15Btn, loc16Btn };

            populate();
        }

        // If the user presses any button followed by a number (1-4) that nunber
        // appears as the text on the button
        // This method is the event handler for all 16 buttons
        private void button_KeyPress(object sender, KeyPressEventArgs e)
        {
            int input;
            if (int.TryParse(e.KeyChar.ToString(), out input))
            {
                // only make sure that user's input is 1 or 2 or 3 or 4
                if (input >= 1 && input <= 4)
                {
                    // Set the text current select button to the user key press
                    this.ActiveControl.Text = e.KeyChar.ToString();
                }
            }
            this.ActiveControl.BackColor = Color.WhiteSmoke;
        }

        // make the active button back color as white smoke
        private void CellMouseClick(object sender, MouseEventArgs e)
        {
            // change every back color of every cell to rogonal color
            foreach (Button b in buttonRay)
            {
                b.BackColor = Color.LightBlue;
            }
            // make the active button back color as light blue
            this.ActiveControl.BackColor = Color.WhiteSmoke;
        }
    }
}
