using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstWinFormsApp
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void btnNumber_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            ResultScreen.Text += button.Text; 
        }

        private string firstNumber = "";
        private string currentOperator = "";

        private void btnOperator_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            firstNumber = ResultScreen.Text;  
            currentOperator = button.Text;  
            ResultScreen.Text = "";  
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            double num1 = double.Parse(firstNumber);
            double num2 = double.Parse(ResultScreen.Text);
            double result = 0;

            switch (currentOperator)
            {
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "/":
                    if (num2 != 0)
                        result = num1 / num2;
                    else
                        MessageBox.Show("FBI OPEN UP");
                    break;
                case "%":
                    result = num1 % num2;
                    break;
            }

            ResultScreen.Text = result.ToString();
        }

        private void BackspaceButton_Click(object sender, EventArgs e)
        {
            if (ResultScreen.Text.Length > 0)
            {
                ResultScreen.Text = ResultScreen.Text.Substring(0, ResultScreen.Text.Length - 1);
            }
        }

        private void btnAC_Click(object sender, EventArgs e)
        {
            ResultScreen.Text = "";
        }
    }
}

// yeah its very simplistic calculator its just a start
