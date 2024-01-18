using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace lab1_calculator
{
    public partial class Calculator : Form
    {
        int state = 0;

        public Calculator()
        {
            InitializeComponent();
        }

        private void enterNum(char num)
        {
            if (state != -1)
            {
                if (state == 0)
                    state = 1;
                else if (state == 2)
                    state = 3;

                display.Text += num;
            }
        }

        private void enterOperator(char op)
        {
            if (state == 1)
            {
                state = 2;
                display.Text += op;
            }
        }

        private void Eval(String expression)
        {
            DataTable table = new DataTable();

            if (expression.ToLower().IndexOf('.') == -1)
                expression += ".";

            try
            {
                display.Text = Convert.ToString(table.Compute(expression, String.Empty));
                state = 1;
            }
            catch (DivideByZeroException)
            {
                state = -1;
                display.Text = "Error: Division By Zero";
            }
            catch (EvaluateException)
            {
                state = -1;
                display.Text = "Math Error";
            }
            catch (SyntaxErrorException)
            {
                state = -1;
                display.Text = "Syntax Error";
            }
        }

        private String EvalRaw(String expression)
        {
            DataTable table = new DataTable();

            if (expression.ToLower().IndexOf('.') == -1)
                expression += ".";

            return Convert.ToString(table.Compute(expression, String.Empty));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            enterNum('1');
        }

        private void button2_Click(object sender, EventArgs e)
        {
            enterNum('2');
        }

        private void button3_Click(object sender, EventArgs e)
        {
            enterNum('3');
        }

        private void button4_Click(object sender, EventArgs e)
        {
            enterNum('4');
        }

        private void button5_Click(object sender, EventArgs e)
        {
            enterNum('5');
        }

        private void button6_Click(object sender, EventArgs e)
        {
            enterNum('6');
        }

        private void button7_Click(object sender, EventArgs e)
        {
            enterNum('7');
        }

        private void button8_Click(object sender, EventArgs e)
        {
            enterNum('8');
        }

        private void button9_Click(object sender, EventArgs e)
        {
            enterNum('9');
        }

        private void button10_Click(object sender, EventArgs e)
        {
            enterNum('0');
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            enterOperator('+');
        }

        private void subBtn_Click(object sender, EventArgs e)
        {
            enterOperator('-');
        }

        private void mulBtn_Click(object sender, EventArgs e)
        {
            enterOperator('*');
        }

        private void divBtn_Click(object sender, EventArgs e)
        {
            enterOperator('/');
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            state = 0;
            display.Text = "";
        }

        private void backspaceBtn_Click(object sender, EventArgs e)
        {
            if (state != -1)
                display.Text = display.Text.Substring(0, display.Text.Length - 1);
        }

        private void calcBtn_Click(object sender, EventArgs e)
        {
            if (state == 3)
                Eval(display.Text);
        }

        private void sqBtn_Click(object sender, EventArgs e)
        {
            if (state == 1)
            {
                string result;

                try
                {
                    result = EvalRaw(string.Format("{0} * {0}", display.Text));

                    char lastCharacter = result.ToCharArray().Last();
                    if (lastCharacter == '0')
                        result = result.Replace(".00", ".0");
                }
                catch (OverflowException)
                {
                    state = -1;
                    result = "Overflow";
                }

                display.Text = result;
            }
        }

        private void cubeBtn_Click(object sender, EventArgs e)
        {
            if (state == 1)
            {
                string result;

                try
                {
                    result = EvalRaw(string.Format("{0} * {0} * {0}", display.Text));

                    char lastCharacter = result.ToCharArray().Last();
                    if (lastCharacter == '0')
                        result = result.Replace(".00", ".0");
                }
                catch (OverflowException)
                {
                    state = -1;
                    result = "Overflow";
                }

                display.Text = result;
            }
        }

        private void logBtn_Click(object sender, EventArgs e)
        {
            if (state == 1)
                try
                {
                    long num = long.Parse(display.Text);

                    display.Text = Convert.ToString(Math.Log(num, Math.E));
                }
                catch (FormatException)
                {
                    state = -1;
                    display.Text = "Input parse error";
                }
                catch (OverflowException)
                {
                    state = -1;
                    display.Text = "Overflow";
                }
        }
    }
}
