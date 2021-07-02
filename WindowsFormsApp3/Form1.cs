using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public delegate double Calculate(double n1, double n2);
        public event Calculate CalcEvent;
        double? temp;

        void ClearEvent()
        {
            try
            {
                foreach (Delegate d in CalcEvent.GetInvocationList())
                {
                    CalcEvent -= (Calculate)d;
                }
            }
            catch (Exception)
            {

            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        double Plus(double n1, double n2)
        {
            return n1 + n2;
        }

        double Minus(double n1, double n2)
        {
            return n1 - n2;
        }

        double Mult(double n1, double n2)
        {
            return n1 * n2;
        }

        double Div(double n1, double n2)
        {
            try
            {
                return n1 / n2;
            }
            catch (DivideByZeroException)
            {
                textBoxTotal.Text = "ERROR! Division by zero!";
                System.Threading.Thread.Sleep(2000);
                return 0;
            }
        }

        private void buttonEquals_Click(object sender, EventArgs e)
        {
            if((sender as Button).Text == "%")
            {
                textBoxTotal.Text = (Double.Parse(textBoxTotal.Text) / 100).ToString();
            }
            char ch = textBoxCalc.Text[textBoxCalc.Text.Length - 1];
            textBoxCalc.Text = temp.ToString() + ch + textBoxTotal.Text;
            textBoxTotal.Text = textBoxTotal.Text == "" ? textBoxTotal.Text : (CalcEvent.Invoke(temp ?? 0, Double.Parse(textBoxTotal.Text))).ToString();
            ClearEvent();
        }

        private void buttonCalc_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            ClearEvent();
            switch (button.Text)
            {
                case "+":
                    CalcEvent += Plus;
                    break;
                case "-":
                    CalcEvent += Minus;
                    break;
                case "*":
                    CalcEvent += Mult;
                    break;
                case "/":
                    CalcEvent += Div;
                    break;
            }
            try
            { 
                double tmptmptmp = Double.Parse(textBoxTotal.Text);
                temp = tmptmptmp;
            }
            catch(Exception) { }
            finally
            {
                if (textBoxCalc.Text.Length > 0)
                {
                    if (textBoxCalc.Text[textBoxCalc.Text.Length - 1] == '+' ||
                        textBoxCalc.Text[textBoxCalc.Text.Length - 1] == '-' ||
                        textBoxCalc.Text[textBoxCalc.Text.Length - 1] == '*' ||
                        textBoxCalc.Text[textBoxCalc.Text.Length - 1] == '/')
                    {
                        if (textBoxTotal.Text == "")
                        {
                            textBoxTotal.Text = textBoxCalc.Text.Substring(0, textBoxCalc.Text.Length - 1);
                        }
                    }
                }
                textBoxCalc.Text = textBoxTotal.Text + button.Text;
                textBoxTotal.Text = "";
            }
        }

        private void buttonClearAll_Click(object sender, EventArgs e)
        {
            textBoxTotal.Text = "";
            textBoxCalc.Text = "";
        }

        private void buttonNegative_Click(object sender, EventArgs e)
        {
            textBoxTotal.Text = (-(Double.Parse(textBoxTotal.Text))).ToString();
        }

        void numericButton_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            textBoxTotal.Text = textBoxTotal.Text == "0" || textBoxTotal.Text == "" ? button.Text : textBoxTotal.Text + button.Text;
        }

        private void buttonClearLast_Click(object sender, EventArgs e)
        {
            textBoxTotal.Text = "";
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxTotal.Text = textBoxTotal.Text.Length > 0 ? textBoxTotal.Text.Substring(0, textBoxTotal.Text.Length - 1) : "";
        }

        private void buttonPeriod_Click(object sender, EventArgs e)
        {
            if (!textBoxTotal.Text.Contains(',') && textBoxTotal.Text.Length > 0)
            {
                textBoxTotal.Text += ',';
            }
        }
    }
}
