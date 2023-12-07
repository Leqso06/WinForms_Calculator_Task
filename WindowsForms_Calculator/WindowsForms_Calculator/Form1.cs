using System;
using System.Windows.Forms;

namespace WindowsForms_Calculator
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private bool _numIsDecimal;
        private double _value1;
        private double _value2;
        private double _result;
        private string _operator;

        private void NumberClick(object sender, EventArgs e)
        {
            string buttonText = (sender as Button).Text;

            if (buttonText == "." && (_numIsDecimal || numbersTxt.Text == _operator))
            {
                return;
            }

            if (buttonText == "." && !_numIsDecimal)
            {
                _numIsDecimal = true;
            }

            if (numbersTxt.Text == "0" || numbersTxt.Text == _operator)
            {
                numbersTxt.Clear();
                _numIsDecimal = false;
            }

            if(numbersTxt.Text == _result.ToString())
            {
                if (buttonText == ".")
                {
                    numbersTxt.Text = "0";
                    _numIsDecimal = false;
                }
                else
                {
                    numbersTxt.Clear();
                }
                _result = 0;
            }


            numbersTxt.Text += buttonText;
        }

        private void Clear(object sender, EventArgs e)
        {
            numbersTxt.Text = "0";
            ClearData();
        }

        private void ClearEntry(object sender, EventArgs e)
        {
            numbersTxt.Text = "0";
        }

        private void Operation(object sender, EventArgs e)
        {
            if (_operator != null)
            {
                Calculation(null, null);
            }

            _operator = (sender as Button).Text;
            _value1 = Double.Parse(numbersTxt.Text);
            numbersTxt.Text = _operator;
        }

        private void Calculation(object sender, EventArgs e)
        {
            if (numbersTxt.Text == _operator)
            {
                return;
            }

            _value2 = Double.Parse(numbersTxt.Text);

            if (_value2 == 0 && _operator == "÷")
            {
                MessageBox.Show("Cannot divide by zero");
                ClearData();
                return;
            }

            switch (_operator)
            {
                case "+":
                    _result = _value1 + _value2;
                    break;

                case "-":
                    _result = _value1 - _value2;
                    break;

                case "x":
                    _result = _value1 * _value2;
                    break;

                case "÷":
                    _result = _value1 / _value2;
                    break;
            }

            ClearData();
            numbersTxt.Text = _result.ToString();
        }

        private void ClearData()
        {
            _value1 = _value2 = 0;
            _operator = null;
            _numIsDecimal = false;
        }

        private void negativeNum_Click(object sender, EventArgs e)
        {
            double num; 
            if (Double.TryParse(numbersTxt.Text, out num) && (num > 0 || num < 0))
            {
                num *= -1;
                numbersTxt.Text = num.ToString();
            }
        }
    }
}
