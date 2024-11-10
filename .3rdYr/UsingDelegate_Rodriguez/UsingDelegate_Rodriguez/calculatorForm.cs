using System;
using System.Windows.Forms;

namespace UsingDelegate_Rodriguez
{
    public partial class calculatorForm : Form
    {
        private Calculator calculator;
        private CalculatorOperation calcOperation;     // calcOperation is declared as type Delegate CalculatorOperation
        public calculatorForm()
        {
            InitializeComponent();
            calculator = new Calculator();  // create an instance of Calculator class 
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            PerformOperation(calculator.Add);
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            PerformOperation(calculator.Subtract);
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            PerformOperation(calculator.Divide);
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            PerformOperation(calculator.Multiply);
        }
    }
}
