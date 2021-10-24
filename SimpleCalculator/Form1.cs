using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class simpleCalculator : Form
    { 
        string first = "";
        string second = "";
        char function;
        double result = 0.0;
        string userInput = "";

        public simpleCalculator()
        {
            InitializeComponent();
        }

        private void num1_Click(object sender, EventArgs e)
        {
            numDisplay.Text = "";

            userInput += "1";

            numDisplay.Text += userInput;
        }

        private void num2_Click(object sender, EventArgs e)
        {
            numDisplay.Text = "";
            userInput += "2";

            numDisplay.Text += userInput;
        }

        private void num3_Click(object sender, EventArgs e)
        {
            numDisplay.Text = "";
            userInput += "3";

            numDisplay.Text += userInput;
        }

        private void num4_Click(object sender, EventArgs e)
        {
            numDisplay.Text = "";
            userInput += "4";
            numDisplay.Text += userInput;
        }

        private void num5_Click(object sender, EventArgs e)
        {
            numDisplay.Text = "";
            userInput += "5";

            numDisplay.Text += userInput;
        }

        private void num6_Click(object sender, EventArgs e)
        {
            numDisplay.Text = "";
            userInput += "6";

            numDisplay.Text += userInput;
        }

        private void num7_Click(object sender, EventArgs e)
        {
            numDisplay.Text = "";
            userInput += "7";

            numDisplay.Text += userInput;
        }

        private void num8_Click(object sender, EventArgs e)
        {
            numDisplay.Text = "";
            userInput += "8";

            numDisplay.Text += userInput;
        }

        private void num9_Click(object sender, EventArgs e)
        {
            numDisplay.Text = "";
            userInput += "9";

            numDisplay.Text += userInput;
        }

        private void num0_Click(object sender, EventArgs e)
        {
            numDisplay.Text = "";
            userInput += "0";

            numDisplay.Text += userInput;
        }

        private void butDecimal_Click(object sender, EventArgs e)
        {
            numDisplay.Text += ".";
        }

        private void butEqual_Click(object sender, EventArgs e)
        {
            second = userInput;
            double firstNum, secondNum;
            firstNum = Convert.ToDouble(first);
            secondNum = Convert.ToDouble(second);
            //Plus
            if (function == '+')
            {
                result = firstNum + secondNum;
                numDisplay.Text = result.ToString();

            }
            //Minus
            else if (function == '-')
            {
                result = firstNum - secondNum;
                numDisplay.Text = result.ToString();
            }
            //Divide
            else if (function == '/')
            {
                if (secondNum == '0')
                {
                    numDisplay.Text = "Nah";
                }
                else
                {
                    result = firstNum / secondNum;

                    numDisplay.Text = result.ToString();
                }
            }
            //Multiply
            else if (function == '*')
            {
                result = firstNum * secondNum;
                numDisplay.Text = result.ToString();
            }

        }

        private void butPlus_Click(object sender, EventArgs e)
        {

            function = '+';
            first = userInput;
            userInput = "";
        }

        private void butMinus_Click(object sender, EventArgs e)
        {
            function = '-';
            first = userInput;
            userInput = "";
        }

        private void butMultiply_Click(object sender, EventArgs e)
        {
            function = '*';
            first = userInput;
            userInput = "";
        }

        private void butDivide_Click(object sender, EventArgs e)
        {
            function = '/';
            first = userInput;
            userInput = "";
        }

        private void butBackSpace_Click(object sender, EventArgs e)
        {

        }

        private void butClear_Click(object sender, EventArgs e)
        {
            first = "";
            second = "";
            userInput = "";
            result = 0.0;
            numDisplay.Text = "0";

        }

        private void butPercent_Click(object sender, EventArgs e)
        {
            numDisplay.Text += "%";
        }
    }
}
