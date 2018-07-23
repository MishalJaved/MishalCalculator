using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CAlculAtor
{
    public partial class Form1 : Form
    {
        double resultValue = 0;
        string operationPerfrmed = "";
        bool isOperationPerfrmed = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        

        private void button19_Click(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {
            if ((textBox1_Result.Text == "0")||isOperationPerfrmed)
                textBox1_Result.Clear();
                textBox1_Result.Text = textBox1_Result.Text + ".";
                isOperationPerfrmed = false;
            Button button= (Button)sender;
          /*  if (button.Text == ".")
            {
                if (!textBox1_Result.Text.Contains("."))
                {
                    textBox1_Result.Text = textBox1_Result.Text + button.Text;
                }
                else
                {
                    textBox1_Result.Text = textBox1_Result.Text + button.Text;
                }
            }*/
                
        }

        private void button16_Click(object sender, EventArgs e)
        {
            switch (operationPerfrmed)
            { 
                case"+":
                    textBox1_Result.Text = (resultValue + double.Parse(textBox1_Result.Text)).ToString();
                    break;

                case "-":
                    textBox1_Result.Text = (resultValue - double.Parse(textBox1_Result.Text)).ToString();
                    break;

                case "*":
                    textBox1_Result.Text = (resultValue * double.Parse(textBox1_Result.Text)).ToString();
                    break;

                case "/":
                    textBox1_Result.Text = (resultValue / double.Parse(textBox1_Result.Text)).ToString();
                    break;
            }
            resultValue = double.Parse(textBox1_Result.Text);
            labelOperationPerformed.Text = "";
        }

        private void buttonOne_Click(object sender, EventArgs e)
        {
            if ((textBox1_Result.Text == "0") || isOperationPerfrmed)
                textBox1_Result.Clear();
            textBox1_Result.Text = textBox1_Result.Text + "1";
            isOperationPerfrmed = false;
        }

        private void buttonTwo_Click(object sender, EventArgs e)
        {
            if ((textBox1_Result.Text == "0") || isOperationPerfrmed)
                textBox1_Result.Clear();
            textBox1_Result.Text = textBox1_Result.Text + "2";
            isOperationPerfrmed = false;
        }

        private void buttonThree_Click(object sender, EventArgs e)
        {
            if ((textBox1_Result.Text == "0") || isOperationPerfrmed)
                textBox1_Result.Clear();
            textBox1_Result.Text = textBox1_Result.Text + "3";
            isOperationPerfrmed = false;
        }

        private void buttonFour_Click(object sender, EventArgs e)
        {
            if ((textBox1_Result.Text == "0") || isOperationPerfrmed)
                textBox1_Result.Clear();
            textBox1_Result.Text = textBox1_Result.Text + "4";
            isOperationPerfrmed = false;
        }

        private void buttonFive_Click(object sender, EventArgs e)
        {
            if ((textBox1_Result.Text == "0") || isOperationPerfrmed)
                textBox1_Result.Clear();
            textBox1_Result.Text = textBox1_Result.Text + "5";
            isOperationPerfrmed = false;
        }

        private void buttonSix_Click(object sender, EventArgs e)
        {
            if ((textBox1_Result.Text == "0") || isOperationPerfrmed)
                textBox1_Result.Clear();
            textBox1_Result.Text = textBox1_Result.Text + "6";
            isOperationPerfrmed = false;
        }

        private void buttonSeven_Click(object sender, EventArgs e)
        {
            if ((textBox1_Result.Text == "0") || isOperationPerfrmed)
                textBox1_Result.Clear();
            textBox1_Result.Text = textBox1_Result.Text + "7";
            isOperationPerfrmed = false;
        }

        private void buttonEight_Click(object sender, EventArgs e)
        {
            if ((textBox1_Result.Text == "0") || isOperationPerfrmed)
                textBox1_Result.Clear();
            textBox1_Result.Text = textBox1_Result.Text + "8";
            isOperationPerfrmed = false;
        }

        private void buttonNine_Click(object sender, EventArgs e)
        {
            if ((textBox1_Result.Text == "0") || isOperationPerfrmed)
                textBox1_Result.Clear();
            textBox1_Result.Text = textBox1_Result.Text + "9";
            isOperationPerfrmed = false;
        }

        private void buttonZero_Click(object sender, EventArgs e)
        {
            if ((textBox1_Result.Text == "0") || isOperationPerfrmed)
                textBox1_Result.Clear();
            textBox1_Result.Text = textBox1_Result.Text + "0";
            isOperationPerfrmed = false;
        }

        private void operator_click(object sender, EventArgs e)
        {
           

        }

        private void buttonCE_Click(object sender, EventArgs e)
        {
            textBox1_Result.Text = "0";
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBox1_Result.Text = "0";
            resultValue = 0;
        }

        private void k(object sender, EventArgs e)
        {

        }

        private void ButtonOperator_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (resultValue != 0)
            {
                buttonEqual.PerformClick();
                operationPerfrmed = button.Text;
                isOperationPerfrmed = true;
                labelOperationPerformed.Text = resultValue + " " + operationPerfrmed;
            }
            else
            {
                operationPerfrmed = button.Text;
                resultValue = double.Parse(textBox1_Result.Text);
                isOperationPerfrmed = true;
                labelOperationPerformed.Text = resultValue + " " + operationPerfrmed;
            }
            }
    }
}
