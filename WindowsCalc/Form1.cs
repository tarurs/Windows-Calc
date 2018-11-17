using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsCalc
{
    public partial class Form1 : Form
    {
        double value = 0;
        string operation = "";
        bool operation_pressed = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            if ((ResultTextBox.Text == "0") || (operation_pressed))
                ResultTextBox.Clear();

            operation_pressed = false;
            Button b = (Button)sender;
            ResultTextBox.Text = ResultTextBox.Text + b.Text;
        }

        private void buttonCE_Click(object sender, EventArgs e)
        {
            ResultTextBox.Text = "0";
            firstValue.Text = "";
        }

        private void MathOperation_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            operation = b.Text;
            value = double.Parse(ResultTextBox.Text);
            operation_pressed = true;
            firstValue.Text = value + " " + operation;
        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            
            firstValue.Text = "";
            switch (operation)
            {
                case "*":
                    ResultTextBox.Text = (value * double.Parse(ResultTextBox.Text)).ToString();
                    break;

                case "/":
                    if (value == 0 || ResultTextBox.Text == "0")
                    {
                        ResultTextBox.Text = "0";
                        break;
                    }
                    ResultTextBox.Text = (value / double.Parse(ResultTextBox.Text)).ToString();
                    break;

                case "-":
                    ResultTextBox.Text = (value - double.Parse(ResultTextBox.Text)).ToString();
                    break;

                case "+":
                    ResultTextBox.Text = (value + double.Parse(ResultTextBox.Text)).ToString();
                    break;

                default:
                    break;
            }
            
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            ResultTextBox.Text = "0";
            value = 0;
            firstValue.Text = "";
        }

        private void buttonPoint_Click(object sender, EventArgs e)
        {
            if(!ResultTextBox.Text.Contains(","))
            ResultTextBox.Text = ResultTextBox.Text + ",";
        }

    }
}
