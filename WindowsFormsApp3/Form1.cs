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
        double temp;

        void ClearEvent()
        {
            foreach (Delegate d in CalcEvent.GetInvocationList())
            {
                CalcEvent -= (Calculate)d;
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
            char ch = textBoxCalc.Text[0];
            textBoxCalc.Text = temp.ToString() + ch + textBoxTotal.Text;
            textBoxTotal.Text = (CalcEvent.Invoke(temp, Double.Parse(textBoxTotal.Text))).ToString();
            ClearEvent();
        }

        private void buttonCalc_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
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
            temp = Double.Parse(textBoxTotal.Text);
            textBoxCalc.Text = button.Text + textBoxTotal.Text;
            textBoxTotal.Text = "";
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
    }
}
