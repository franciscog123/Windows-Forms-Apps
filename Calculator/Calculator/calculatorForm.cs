using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class calculatorForm : Form
    {
        //string variables that will hold string values of numbers entered
        string stringVal1 = "";
        string stringVal2 = "";

        //values that will be added to get the total, used in calc method
        double value1 = 0.0;
        double value2 = 0.0;

        char symbol = ' '; //will hold +, -, X, or /

        double total = 0.0; //will store total value

        bool isOperatorPressed = false; //flag, will be true if an operator(+,-,*,/) is pressed 

        public calculatorForm()
        {
            InitializeComponent();
            displayTxtBox.Cursor = Cursors.Arrow;//prevents cursor from being displayed
                                                
                                                   //this.KeyPress +=
                                                 // new KeyPressEventHandler(calculatorForm_KeyPress);
            this.KeyPress += CalculatorForm_KeyPress;
            //displayTxtBox.KeyPress +=
               // new KeyPressEventHandler(displayTxtBox_KeyPress);
        }

        private void calculatorForm_Load(object sender, EventArgs e)
        {

        }

        private void zeroBtn_Click(object sender, EventArgs e)
        {
            displayTxtBox.Text += "0"; //appends 0 to textbox  
            equalBtn.Focus();
        }

        private void oneBtn_Click(object sender, EventArgs e)
        {
            displayTxtBox.Text += "1"; //appends 1 to textbox 
            equalBtn.Focus();

        }

        private void twoBtn_Click(object sender, EventArgs e)
        {
            displayTxtBox.Text += "2"; //appends 2 to textbox 
            equalBtn.Focus();

        }

        private void threeBtn_Click(object sender, EventArgs e)
        {
            displayTxtBox.Text += "3"; //appends 3 to textbox 
            equalBtn.Focus();

        }

        private void fourBtn_Click(object sender, EventArgs e)
        {
            displayTxtBox.Text += "4"; //appends 4 to textbox 
            equalBtn.Focus();

        }

        private void fiveBtn_Click(object sender, EventArgs e)
        {
            displayTxtBox.Text += "5"; //appends 5 to textbox 
            equalBtn.Focus();

        }

        private void sixBtn_Click(object sender, EventArgs e)
        {
            displayTxtBox.Text += "6"; //appends 6 to textbox 
            equalBtn.Focus();

        }

        private void sevenBtn_Click(object sender, EventArgs e)
        {
            displayTxtBox.Text += "7"; //appends 7 to textbox 
            equalBtn.Focus();

        }

        private void eightBtn_Click(object sender, EventArgs e)
        {
            displayTxtBox.Text += "8"; //appends 8 to textbox
            equalBtn.Focus();

        }

        private void nineBtn_Click(object sender, EventArgs e)
        {
            displayTxtBox.Text += "9"; //appends 9 to textbox 
            equalBtn.Focus();

        }

        private void decimalBtn_Click(object sender, EventArgs e)
        {
            //checks to see if a decimal is not already in the textbox
            if (!displayTxtBox.Text.Contains("."))
            {
                displayTxtBox.Text += "."; //adds decimal to textbox and displays it
            }
            equalBtn.Focus();

        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            //clears textbox
            displayTxtBox.Text = "";

            //clears and resets any stored values
            isOperatorPressed = false;
            symbol = ' ';
            stringVal1 = "";
            stringVal2 = "";
            total = 0.0;
            value1 = 0;
            value2 = 0.0;
            equalBtn.Focus();

        }

        private void backspaceBtn_Click(object sender, EventArgs e)
        {
            //checks to see if textbox is not empty
            if (displayTxtBox.Text.Length != 0)
            {
                displayTxtBox.Text = displayTxtBox.Text.Substring(0, displayTxtBox.Text.Length - 1);
            }
            equalBtn.Focus();

        }

        private void plusBtn_Click(object sender, EventArgs e)
        {
            //checks to see if textbox is not empty
            if (displayTxtBox.Text!="")
            {
                if (isOperatorPressed) //checks if an operator button(+, -, X, /) has been pressed previously
                {
                    calc(); //calls calc method, performs calculation based on previously selected operator
                    stringVal1 = displayTxtBox.Text; //sets string currently in textbox to stringVal1
                    displayTxtBox.Text = "";
                    symbol = '+'; //ensures addition will be performed next time calc method is called
                    isOperatorPressed = true; //turns flag on, ensures that code in if(isOperatorPressed) will be executed next time an operator button is clicked 
                }
                else
                {
                    stringVal1 = displayTxtBox.Text; //sets string currently in textbox to stringVal1
                    displayTxtBox.Text = "";
                    symbol = '+'; //ensures addition will be performed next time calc method is called
                    isOperatorPressed = true; //turns flag on, ensures that code in if(isOperatorPressed) will be executed next time an operator button is clicked 
                }
            }
            equalBtn.Focus();

        }

        private void minusBtn_Click(object sender, EventArgs e)
        {
            //checks to see if textbox is not empty
            if (displayTxtBox.Text!="")
            {
                if (isOperatorPressed) //checks if an operator button(+, -, X, /) has been pressed previously
                {
                    calc(); //calls calc method, performs calculation based on previously selected operator
                    stringVal1 = displayTxtBox.Text; //sets string currently in textbox to stringVal1
                    displayTxtBox.Text = "";
                    symbol = '-'; //ensures subtraction will be performed next time calc method is called
                    isOperatorPressed = true; //turns flag on, ensures that code in if(isOperatorPressed) will be executed next time an operator button is clicked 
                }
                else
                {
                    stringVal1 = displayTxtBox.Text; //sets string currently in textbox to stringVal1
                    displayTxtBox.Text = "";
                    symbol = '-'; //ensures subtraction will be performed next time calc method is called
                    isOperatorPressed = true; //turns flag on, ensures that code in if(isOperatorPressed) will be executed next time an operator button is clicked 
                }
            }
            equalBtn.Focus();

        }

        private void multiplyBtn_Click(object sender, EventArgs e)
        {
            //checks to see if textbox is not empty
            if (displayTxtBox.Text!="")
            {
                if (isOperatorPressed) //checks if an operator button(+, -, X, /) has been pressed previously
                {
                    calc(); //calls calc method, performs calculation based on previously selected operator
                    stringVal1 = displayTxtBox.Text; //sets string currently in textbox to stringVal1
                    displayTxtBox.Text = "";
                    symbol = 'X'; //ensures multiplication will be performed next time calc method is called
                    isOperatorPressed = true; //turns flag on, ensures that code in if(isOperatorPressed) will be executed next time an operator button is clicked 
                }
                else
                {
                    stringVal1 = displayTxtBox.Text; //sets string currently in textbox to stringVal1
                    displayTxtBox.Text = "";
                    symbol = 'X'; //ensures multiplication will be performed next time calc method is called
                    isOperatorPressed = true; //turns flag on, ensures that code in if(isOperatorPressed) will be executed next time an operator button is clicked 
                }
            }
            equalBtn.Focus();

        }

        private void divideBtn_Click(object sender, EventArgs e)
        {
            //checks to see if textbox is not empty
            if (displayTxtBox.Text!="")
            {
                if (isOperatorPressed) //checks if an operator button(+, -, X, /) has been pressed previously
                {
                    calc(); //calls calc method, performs calculation based on previously selected operator
                    stringVal1 = displayTxtBox.Text; //sets string currently in textbox to stringVal1
                    displayTxtBox.Text = "";
                    symbol = '/'; //ensures division will be performed next time calc method is called
                    isOperatorPressed = true; //turns flag on, ensures that code in if(isOperatorPressed) will be executed next time an operator button is clicked 
                }
                else
                {
                    stringVal1 = displayTxtBox.Text; //sets string currently in textbox to stringVal1
                    displayTxtBox.Text = "";
                    symbol = '/'; //ensures division will be performed next time calc method is called
                    isOperatorPressed = true; //turns flag on, ensures that code in if(isOperatorPressed) will be executed next time an operator button is clicked 
                }
            }
            equalBtn.Focus();
        }

        private void equalBtn_Click(object sender, EventArgs e)
        {
            if (symbol != ' ') //checks if +,-, X , or / buttons have been clicked first, if none of these buttons have been clicked, does nothing
            {
                calc(); //calls calc method, performs calculation based on previously selected operator
                isOperatorPressed = false; //resets flag
                symbol = ' '; //resets symbol
            }
        }

        public void calc() //performs calculation based on previously selected operator
        {
            if (displayTxtBox.Text != "")  //checks to see if textbox is not empty
            {
                stringVal2 = displayTxtBox.Text; //sets value in textbox to stringVal2

                //convert stored string number variables to doubles
                double.TryParse(stringVal1, out value1);
                double.TryParse(stringVal2, out value2);

                switch (symbol) //performs addition, subtraction, multiplication, or division based on previous operator selected
                {
                    //performs addition
                    case '+':
                        total = value1 + value2;
                        break;
                    //performs subtraction
                    case '-':
                        total = value1 - value2;
                        break;
                    //performs multiplication
                    case 'X':
                        total = value1 * value2;
                        break;
                    //performs division
                    case '/':
                        total = value1 / value2;
                        break;
                }
                
                displayTxtBox.Text = total.ToString(); //displays total in textbox
            }
        }

        //detects 0-9, +, -, *, /, backspace, esc, decimal, enter keys pressed at form level, selects appropriate click methods based on keys pressed
        private void CalculatorForm_KeyPress(object sender, KeyPressEventArgs e)
        {
               switch (e.KeyChar)
                {
                    case (char)13:
                        equalBtn.PerformClick();
                        e.Handled = true;
                        break;
                    case (char)8:
                        backspaceBtn.PerformClick();
                         e.Handled = true;
                         break;
                    case (char)27:
                        clearBtn.PerformClick();
                        e.Handled = true;
                         break;
                    case (char)46:
                        decimalBtn.PerformClick();
                        e.Handled = true;
                        break;
                    case (char)43:
                        plusBtn.PerformClick();
                        e.Handled = true;
                        break;
                    case (char)45:
                        minusBtn.PerformClick();
                        e.Handled = true;
                        break;
                    case (char)42:
                        multiplyBtn.PerformClick();
                        e.Handled = true;
                        break;
                    case (char)47:
                        divideBtn.PerformClick();
                        e.Handled = true;
                        break;
                    case (char)48:
                        zeroBtn.PerformClick();
                        e.Handled = true;
                        break;
                    case (char)49:
                        oneBtn.PerformClick();
                        e.Handled = true;
                        break;
                    case (char)50:
                        twoBtn.PerformClick();
                        e.Handled = true;
                        break;
                    case (char)51:
                        threeBtn.PerformClick();
                        e.Handled = true;
                        break;
                    case (char)52:
                        fourBtn.PerformClick();
                        e.Handled = true;
                        break;
                    case (char)53:
                        fiveBtn.PerformClick();
                        e.Handled = true;
                        break;
                    case (char)54:
                        sixBtn.PerformClick();
                        e.Handled = true;
                        break;
                    case (char)55:
                        sevenBtn.PerformClick();
                        e.Handled = true;
                        break;
                    case (char)56:
                        eightBtn.PerformClick();
                        e.Handled = true;
                        break;
                    case (char)57:
                        nineBtn.PerformClick();
                        e.Handled = true;
                        break;
                }
        }
    }
}
