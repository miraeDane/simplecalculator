using System;

namespace Calculator
{
    public partial class Form1 : Form
    {
        double firstNum;
        string operation = "";
        bool isOperation = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void total_Click(object sender, EventArgs e)
        {

        }

        private void n0_Click(object sender, EventArgs e)
        {
            //if (textBox1.Text == "0" && textBox1.Text != null)
            //{
            //    textBox1.Text = "0";
            //}
            //else
            //{
            //    textBox1.Text = textBox1.Text + "0";
            //}

            AppendText("0");
        }

        private void decimalPnt_Click(object sender, EventArgs e)
        {
            //if (!textBox1.Text.Contains("."))
            //{
            //    if (textBox1.Text == "")
            //    {
            //        textBox1.Text = "0.";
            //    }
            //    else
            //    {
            //        textBox1.Text += ".";
            //    }
            //}
            AppendText(".");

        }

        private void n1_Click(object sender, EventArgs e)
        {
            //if (textBox1.Text == "0" && textBox1.Text != null)
            //{
            //    textBox1.Text = "1";
            //}
            //else
            //{
            //    textBox1.Text = textBox1.Text + "1";
            //}

            AppendText("1");
        }

        private void clear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            total.Text = "0";
            operation = "";
            isOperation = false;
        }

        private void n2_Click(object sender, EventArgs e)
        {
            //if (textBox1.Text == "0" && textBox1.Text != null)
            //{
            //    textBox1.Text = "2";
            //}
            //else
            //{
            //    textBox1.Text = textBox1.Text + "2";
            //}


            AppendText("2");
        }

        private void n3_Click(object sender, EventArgs e)
        {
            //if (textBox1.Text == "0" && textBox1.Text != null)
            //{
            //    textBox1.Text = "3";
            //}
            //else
            //{
            //    textBox1.Text = textBox1.Text + "3";
            //}


            AppendText("3");
        }

        private void n4_Click(object sender, EventArgs e)
        {
            //if (textBox1.Text == "0" && textBox1.Text != null)
            //{
            //    textBox1.Text = "4";
            //}
            //else
            //{
            //    textBox1.Text = textBox1.Text + "4";
            //}


                AppendText("4");
        }

        private void n5_Click(object sender, EventArgs e)
        {
            //if (textBox1.Text == "0" && textBox1.Text != null)
            //{
            //    textBox1.Text = "5";
            //}
            //else
            //{
            //    textBox1.Text = textBox1.Text + "5";
            //}


            AppendText("5");
        }

        private void n6_Click(object sender, EventArgs e)
        {
            //if (textBox1.Text == "0" && textBox1.Text != null)
            //{
            //    textBox1.Text = "6";
            //}
            //else
            //{
            //    textBox1.Text = textBox1.Text + "6";
            //}


            AppendText("6");
        }

        private void n7_Click(object sender, EventArgs e)
        {
            //if (textBox1.Text == "0" && textBox1.Text != null)
            //{
            //    textBox1.Text = "7";
            //}
            //else
            //{
            //    textBox1.Text = textBox1.Text + "7";
            //}

            AppendText("7");
              
        }

        private void n8_Click(object sender, EventArgs e)
        {
            //if (textBox1.Text == "0" && textBox1.Text != null)
            //{
            //    textBox1.Text = "8";
            //}
            //else
            //{
            //    textBox1.Text = textBox1.Text + "8";
            //}

            AppendText("7");
        }

        private void n9_Click(object sender, EventArgs e)
        {
            //if (textBox1.Text == "0" && textBox1.Text != null)
            //{
            //    textBox1.Text = "9";
            //}
            //else
            //{
            //    textBox1.Text = textBox1.Text + "9";
            //}
            AppendText("7");

        }

        private void add_Click(object sender, EventArgs e)
        {

            //if (!isOperation)
            //{
            //    firstNum = Convert.ToDouble(textBox1.Text);
            //    operation = "+";
            //    textBox1.Text += "+";
            //    isOperation = true;

            //}

            AppendText("+");

        }

        private void sub_Click(object sender, EventArgs e)
        {
            //if (!isOperation)
            //{
            //    firstNum = Convert.ToDouble(textBox1.Text);
            //    operation = "-";
            //    textBox1.Text += "-";
            //    isOperation = true;

            //}
            AppendText("-");
        }

        private void mul_Click(object sender, EventArgs e)
        {
            //if (!isOperation)
            //{
            //    firstNum = Convert.ToDouble(textBox1.Text);
            //    operation = "*";
            //    textBox1.Text += "*";
            //    isOperation = true;

            //}
            AppendText("*");
        }

        private void div_Click(object sender, EventArgs e)
        {
            ////if (!isOperation)
            ////{
            ////    firstNum = Convert.ToDouble(textBox1.Text);
            ////    operation = "/";
            ////    textBox1.Text += "/";
            ////    isOperation = true;

            ////}
            AppendText("/");
        }

        private void exponent_Click(object sender, EventArgs e)
        {
            //if (!isOperation)
            //{
            //    firstNum = Convert.ToDouble(textBox1.Text);
            //    operation = "^";
            //    textBox1.Text += "^";
            //    isOperation = true;

            //}
            AppendText("^");

        }

        //private void equals_Click(object sender, EventArgs e)
        //{
        //    //double secondNum;
        //    //double result = Convert.ToDouble(total.Text);

        //    //string[] numbers = textBox1.Text.Split(new char[] { '+', '-', '*', '/' }, 2);
        //    //secondNum = Convert.ToDouble(numbers[1]);


        //    //switch (operation)
        //    //{
        //    //    case "+":
        //    //        result = firstNum + secondNum;
        //    //        break;
        //    //    case "-":
        //    //        result = firstNum - secondNum;
        //    //        break;
        //    //    case "*":
        //    //        result = firstNum * secondNum;
        //    //        break;
        //    //    case "/":
        //    //        result = secondNum != 0 ? firstNum / secondNum : double.NaN;
        //    //        break;
        //    //    default:
        //    //        result = 0;
        //    //        break;
        //    //}

        //    ////textBox1.Text = result.ToString();
        //    //total.Text = result.ToString();
        //    //firstNum = result;
        //    //operation = "";
        //    //isOperation = false;

        //    try
        //    {
        //        string expression = textBox1.Text;
        //        double result = EvaluateExpression(expression);
        //        //textBox1.Text = result.ToString();
        //        total.Text = result.ToString();
        //        firstNum = result;
        //        operation = "";
        //        isOperation = false;
        //    }
        //    catch (Exception ex)
        //    {
        //        textBox1.Text = "Error";
        //        total.Text = "Error";
        //    }

        //}

        private void backspace_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            }
            if (textBox1.Text == "")
            {
                textBox1.Text = "0";
            }
        }


        private void parOpen_Click(object sender, EventArgs e)
        {
            //if (textBox1.Text == "0" && textBox1.Text != null)
            //{
            //    textBox1.Text = "(";
            //}
            //else
            //{
            //    textBox1.Text = textBox1.Text + "(";
            //}
            AppendText("(");
        }

        private void parClose_Click(object sender, EventArgs e)
        {
            //if (textBox1.Text == "0" && textBox1.Text != null)
            //{
            //    textBox1.Text = ")";
            //}
            //else
            //{
            //    textBox1.Text = textBox1.Text + ")";
            //}

            AppendText(")");
        }



        private void equals_Click(object sender, EventArgs e)
        {
            try
            {
                string expression = textBox1.Text;
                double result = EvaluateExpression(expression);
                textBox1.Text = result.ToString();
                total.Text = result.ToString();
                firstNum = result;
                operation = "";
                isOperation = false;
            }
            catch (Exception ex)
            {
                textBox1.Text = "Error";
                total.Text = "Error";
            }
        }

        

        private void AppendText(string value)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = value;
            }
            else
            {
                textBox1.Text += value;
            }
        }

        private void AppendOperator(string value)
        {
            if (!isOperation)
            {
                textBox1.Text += value;
                isOperation = true;
            }
        }

        private double EvaluateExpression(string expression)
        {
            string postfix = ConvertToPostfix(expression);
            return EvaluatePostfix(postfix);
        }

        private string ConvertToPostfix(string infix)
        {
            Stack<char> stack = new Stack<char>();
            string postfix = "";
            bool wasOperator = false;

            foreach (char c in infix)
            {
                if (char.IsDigit(c) || c == '.')
                {
                    postfix += c;
                    wasOperator = false;
                }
                else if (c == '(')
                {
                    stack.Push(c);
                    wasOperator = false;
                }
                else if (c == ')')
                {
                    while (stack.Count > 0 && stack.Peek() != '(')
                    {
                        postfix += " " + stack.Pop();
                    }
                    stack.Pop(); // Remove the '(' from the stack
                    wasOperator = false;
                }
                else if (IsOperator(c))
                {
                    postfix += " ";
                    while (stack.Count > 0 && Precedence(stack.Peek()) >= Precedence(c))
                    {
                        postfix += stack.Pop() + " ";
                    }
                    stack.Push(c);
                    wasOperator = true;
                }
            }
            while (stack.Count > 0)
            {
                postfix += " " + stack.Pop();
            }
            return postfix;
        }

        private double EvaluatePostfix(string postfix)
        {
            Stack<double> stack = new Stack<double>();
            string[] tokens = postfix.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string token in tokens)
            {
                if (double.TryParse(token, out double number))
                {
                    stack.Push(number);
                }
                else if (IsOperator(token[0]))
                {
                    double b = stack.Pop();
                    double a = stack.Pop();
                    stack.Push(ApplyOperator(a, b, token[0]));
                }
            }
            return stack.Pop();
        }

        private bool IsOperator(char c)
        {
            return c == '+' || c == '-' || c == '*' || c == '/' || c == '^';
        }

        private int Precedence(char c)
        {
            if (c == '+' || c == '-') return 1;
            if (c == '*' || c == '/') return 2;
            if (c == '^') return 3;
            return 0;
        }

        private double ApplyOperator(double a, double b, char op)
        {
            switch (op)
            {
                case '+': return a + b;
                case '-': return a - b;
                case '*': return a * b;
                case '/': return b != 0 ? a / b : double.NaN;
                case '^': return Math.Pow(a, b);
                default: return 0;
            }
        }


    }
}
