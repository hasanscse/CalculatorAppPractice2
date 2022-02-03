using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorAppPractice2
{
    public partial class CalculatorUi : Form
    {
        Calculator calculator = new Calculator();
        public CalculatorUi()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            
            calculator.firstNumber = Convert.ToInt32(firstNumberTextBox.Text);
            calculator.secondNumber = Convert.ToInt32(secondNumberTextBox.Text);

            string finalResult = calculator.Sum();

            resultTextBox.Text = finalResult;
        }

        private void SubtractButton_Click(object sender, EventArgs e)
        {
            calculator.firstNumber = Convert.ToInt32(firstNumberTextBox.Text);
            calculator.secondNumber = Convert.ToInt32(secondNumberTextBox.Text);

            string finalResult = calculator.Subs();
            resultTextBox.Text = finalResult;


        }

        private void MultiplyButton_Click(object sender, EventArgs e)
        {
            calculator.firstNumber = Convert.ToInt32(firstNumberTextBox.Text);
            calculator.secondNumber = Convert.ToInt32(secondNumberTextBox.Text);

            string finalResult = calculator.Multiply();
            resultTextBox.Text = finalResult;
        }

        private void DivideButton_Click(object sender, EventArgs e)
        {
            calculator.firstNumber = Convert.ToInt32(firstNumberTextBox.Text);
            calculator.secondNumber = Convert.ToInt32(secondNumberTextBox.Text);

            string finalResult = calculator.Divide();
            resultTextBox.Text = finalResult;
        }
    }
}
