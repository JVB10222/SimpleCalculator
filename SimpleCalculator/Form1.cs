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
        Double resultValue = 0;
        string operatorClicked = "";
        bool isOperatorClicked = false;
        public void PerformClick();


        public simpleCalculator()
        {
            InitializeComponent();
        }

        private void numClick(object sender, EventArgs e)
        {
            if (numDisplay.Text == "0" || (isOperatorClicked))
            {
                numDisplay.Clear();
            }
            Button button = (Button)sender;
            isOperatorClicked = false;
            if (button.Text == ".")
            {
                if (!numDisplay.Text.Contains("."))
                {
                    numDisplay.Text = numDisplay.Text + button.Text;
                }
            }
            else
            {
                numDisplay.Text = numDisplay.Text + button.Text;
            }

        }

        private void butDecimal_Click(object sender, EventArgs e)
        {
            numDisplay.Text += ".";
        }
        
        private void operatorClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operatorClicked = button.Text;
            resultValue = Double.Parse(numDisplay.Text);
            if (resultValue != 0)
            {
                operatorEqualClick.PerformClick();
                operatorClicked = button.Text;
                isOperatorClicked = true;
            }
            else
            {
                operatorClicked = button.Text;
                resultValue = Double.Parse(numDisplay.Text);
                isOperatorClicked = true;
            }

            operatorClicked = button.Text;
            resultValue = Double.Parse(numDisplay.Text);
        

        }

        private void butBackSpace_Click(object sender, EventArgs e)
        {

        }

        private void butClear_Click(object sender, EventArgs e)
        {
            numDisplay.Text = "0";
            resultValue = 0;
        }

        private void butPercent_Click(object sender, EventArgs e)
        {
            numDisplay.Text += "%";
        }

        public void operatorEqualClick(object sender, EventArgs e)
        {
            switch (operatorClicked)
            {
                case "+":
                    numDisplay.Text = (resultValue + Double.Parse(numDisplay.Text)).ToString();
                    break;
                case "-":
                    numDisplay.Text = (resultValue - Double.Parse(numDisplay.Text)).ToString();
                    break;
                case "*":
                    numDisplay.Text = (resultValue * Double.Parse(numDisplay.Text)).ToString();
                    break;
                case "/":
                    numDisplay.Text = (resultValue / Double.Parse(numDisplay.Text)).ToString();
                    break;
                default:
                    break;
            }
        }

        private void simpleCalculator_Load(object sender, EventArgs e)
        {

        }
    }
}