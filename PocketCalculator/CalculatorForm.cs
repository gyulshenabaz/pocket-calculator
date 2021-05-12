using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PocketCalculator
{
    public partial class CalculatorForm : Form
    {
        Calculator calculator;
        string operation = String.Empty;

        bool isOperation = false;
        bool isEqualButtonPressed = false;
        bool isNumberEntered = false;

        public CalculatorForm()
        {
            InitializeComponent();
            calculator = new Calculator();
            memoryIndicator_Label.Text = String.Empty;
        }

        #region Memory methods
        private void buttonMemoryClear_Click(object sender, EventArgs e)
        {
            calculator.MemoryClear();
            memoryIndicator_Label.Text = String.Empty;
        }

        private void button_MemoryRecall_Click(object sender, EventArgs e)
        {
            result.Text = calculator.MemoryValue.ToString();
        }

        private void button_MemoryStore_Click(object sender, EventArgs e)
        {
            calculator.MemoryStore(double.Parse(result.Text));
            memoryIndicator_Label.Text = calculator.MemoryValue != 0 ? "M" : String.Empty;
        }

        private void button_MemoryPlus_Click(object sender, EventArgs e)
        {
            calculator.MemoryAddition(double.Parse(result.Text));
        }

        private void button_MemoryMinus_Click(object sender, EventArgs e)
        {
            calculator.MemorySubtraction(double.Parse(result.Text));
        }

        #endregion

        private void button_Backspace_Click(object sender, EventArgs e)
        {
            if (result.Text.Length != 0)
            {
                result.Text = result.Text.Substring(0, result.Text.Length - 1);
            }

            if (result.Text.Length == 0)
            {
                result.Text = "0";
            }
        }

        private void button_Equal_Click(object sender, EventArgs e)
        {
            operationsResult.ResetText();

            if (isNumberEntered)
            {
                try
                {
                    calculator.Calculate(operation, double.Parse(result.Text));
                    result.Text = calculator.Value.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    operationsResult.ResetText();
                    calculator.Clear();
                    isOperation = false;
                }
            }
            else
            {
                result.Text = (double.Parse(result.Text)).ToString();
            }

            operation = String.Empty;

            isOperation = false;
            isEqualButtonPressed = true;
            isNumberEntered = false;
            calculator.Clear();
        }

        private void button_SquareRoot_Click(object sender, EventArgs e)
        {
            result.Text = Calculator.SquareRoot(double.Parse(result.Text)).ToString();
        }

        private void button_DivideOneByX_Click(object sender, EventArgs e)
        {
            try
            {
                result.Text = Calculator.OneDivideBy(double.Parse(result.Text)).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_Point_Click(object sender, EventArgs e)
        {
            if (!result.Text.Contains("."))
                result.Text = result.Text += ".";
            else if (isEqualButtonPressed)
            {
                result.Text = "0.";
                isEqualButtonPressed = false;
            }
        }

        private void button_Clear(object sender, EventArgs e)
        {
            result.Text = "0";
            operationsResult.ResetText();
            calculator.Clear();
            isEqualButtonPressed = false;
            isOperation = false;
        }

        private void button_ClearEntry_Click(object sender, EventArgs e)
        {
            result.Text = "0";
        }

        private void numberButton_Click(object sender, EventArgs e)
        {
            if (result.Text == "0" || isOperation)
            {
                result.Clear();
            }

            isOperation = false;
            isNumberEntered = true;

            var button = (Button)sender;

            if (isEqualButtonPressed)
            {
                result.Text = button.Text;
                isEqualButtonPressed = false;
            }
            else
            {
                result.Text += button.Text;
            }
        }

        private void button_Power_Click(object sender, EventArgs e)
        {
            result.Text = Calculator.PowerOfTwo(double.Parse(result.Text)).ToString();
        }

        private void button_PlusMinus_Click(object sender, EventArgs e)
        {
            if (isNumberEntered && result.Text != "0")
            {
                result.Text = (-double.Parse(result.Text)).ToString();
            }
        }

        private void button_Operator_Click(object sender, EventArgs e)
        {
            var button = (Button)sender;

            if (calculator.Value != 0 && !isOperation)
            {
                try
                {
                    operationsResult.Text += $"{result.Text} {operation} ";

                    calculator.Calculate(operation, double.Parse(result.Text));
                    result.Text = calculator.Value.ToString();

                    isNumberEntered = false;
                    isOperation = true;
                    operation = button.Text;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    operationsResult.ResetText();
                    calculator.Clear();
                }

            }
            else if (calculator.Value != 0 && isOperation)
            {
                operation = button.Text;
            }
            else
            {
                operation = button.Text;
                calculator.SetValue(double.Parse(result.Text));
                isNumberEntered = false;
                isOperation = true;

                operationsResult.Text = $"{calculator.Value} {operation} ";
            }
        }

        private void button_PercentageC_Click(object sender, EventArgs e)
        {
            result.Text = Calculator.Percentage(double.Parse(result.Text)).ToString();
        }

        private void result_TextChanged(object sender, EventArgs e)
        {
            if (result.Text.Length <= 11)
            {
                result.Font = new Font(result.Font.OriginalFontName, 30);
            }
            else if (result.Text.Length <= 17)
            {
                result.Font = new Font(result.Font.OriginalFontName, 20);
            }
            else
            {
                result.Font = new Font(result.Font.OriginalFontName, 15);
            }
        }

        private void operationsResult_TextChanged(object sender, EventArgs e)
        {
            if (operationsResult.Text.Length >= 40)
            {
                operationsResult.Font = new Font(result.Font.OriginalFontName, 7);
            }
        }

        private void button_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    button_Equal.PerformClick();
                    break;
                case Keys.Delete:
                    button_ClearEntry.PerformClick();
                    break;
                case Keys.Back:
                    button_Backspace.PerformClick();
                    break;
                case Keys.Add:
                case Keys.Oemplus:
                    button_Addition.PerformClick();
                    break;
                case Keys.Multiply:
                    button_Multiply.PerformClick();
                    break;
                case Keys.D0:
                case Keys.NumPad0:
                    button_Number_0.PerformClick();
                    break;
                case Keys.D1:
                case Keys.NumPad1:
                    button_Number_1.PerformClick();
                    break;
                case Keys.D2:
                case Keys.NumPad2:
                    button_Number_2.PerformClick();
                    break;
                case Keys.D3:
                case Keys.NumPad3:
                    button_Number_3.PerformClick();
                    break;
                case Keys.D4:
                case Keys.NumPad4:
                    button_Number_4.PerformClick();
                    break;
                case Keys.D5:
                case Keys.NumPad5:
                    button_Number_5.PerformClick();
                    break;
                case Keys.D6:
                case Keys.NumPad6:
                    button_Number_6.PerformClick();
                    break;
                case Keys.D7:
                case Keys.NumPad7:
                    button_Number_7.PerformClick();
                    break;
                case Keys.D8:
                case Keys.NumPad8:
                    button_Number_8.PerformClick();
                    break;
                case Keys.D9:
                case Keys.NumPad9:
                    button_Number_9.PerformClick();
                    break;
                case Keys.Subtract:
                case Keys.OemMinus:
                    button_Subtract.PerformClick();
                    break;
                case Keys.Decimal:
                case Keys.Oemcomma:
                case Keys.OemPeriod:
                    button_Point.PerformClick();
                    break;
                case Keys.Divide:
                case Keys.OemQuestion:
                    button_Divide.PerformClick();
                    break;
                default:
                    break;
            }
        }
    }
}
    

