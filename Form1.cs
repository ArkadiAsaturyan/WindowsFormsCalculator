using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsCalculator
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        string input;
        decimal num1, num2;
        char mathOperator;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.ActiveControl = textBox1;
            /*  RichTextBox richTextBox = new RichTextBox();
              richTextBox.SelectionBackColor = Color.White;
              richTextBox.SelectionColor = Color.White;
              */


        }

        private void btn_Equals_Click(object sender, EventArgs e)
        {

            input = textBox1.Text;


            if (input.Contains('+'))
            {
                mathOperator = '+';
                num1 = decimal.Parse(input.Substring(0, textBox1.Text.IndexOf(mathOperator)));
                num2 = decimal.Parse(
                    input.Substring(textBox1.Text.IndexOf(mathOperator) + 1, input.Length - textBox1.Text.IndexOf(mathOperator) - 1)
                    );

                textBox2.Text = textBox1.Text;
                textBox1.Text = (num1 + num2).ToString();
            }

            else if (input.Contains('*'))
            {
                mathOperator = '*';
                num1 = decimal.Parse(input.Substring(0, textBox1.Text.IndexOf(mathOperator)));
                num2 = decimal.Parse(
                    input.Substring(textBox1.Text.IndexOf(mathOperator) + 1, input.Length - textBox1.Text.IndexOf(mathOperator) - 1)
                    );

                textBox2.Text = textBox1.Text;
                textBox1.Text = (num1 * num2).ToString();
            }

            else if (input.Contains('/'))
            {
                mathOperator = '/';
                num1 = decimal.Parse(input.Substring(0, textBox1.Text.IndexOf(mathOperator)));
                num2 = decimal.Parse(
                    input.Substring(textBox1.Text.IndexOf(mathOperator) + 1, input.Length - textBox1.Text.IndexOf(mathOperator) - 1)
                    );

                textBox2.Text = textBox1.Text;
                textBox1.Text = (num1 / num2).ToString();
            }

            else if (input.Contains('-'))
            {
                mathOperator = '-';
                num1 = decimal.Parse(input.Substring(0, textBox1.Text.IndexOf(mathOperator)));
                num2 = decimal.Parse(
                    input.Substring(textBox1.Text.IndexOf(mathOperator) + 1, input.Length - textBox1.Text.IndexOf(mathOperator) - 1)
                    );

                textBox2.Text = textBox1.Text;
                textBox1.Text = (num1 - num2).ToString();
            }

            this.ActiveControl = textBox1;
            textBox1.SelectionStart = 0;
            textBox1.SelectionLength = textBox1.Text.Length;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_C_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
            textBox2.Text = null;
            this.ActiveControl = textBox1;
            textBox1.SelectionStart = 0;
            textBox1.SelectionLength = 1;
        }

        private void btn_Sqrt_Click(object sender, EventArgs e)
        {
            double sqrtNumber;
            if (textBox1.Text.Length > 0)
            {
                double textbox1Number = double.Parse(textBox1.Text);
                sqrtNumber = Math.Sqrt(textbox1Number);
                textBox2.Text = "√" + textBox1.Text;
                textBox1.Text = sqrtNumber.ToString();
            }
            else
            {
                this.ActiveControl = textBox1;

            }

            this.ActiveControl = textBox1;
            textBox1.SelectionStart = 0;
            textBox1.SelectionLength = textBox1.Text.Length;

        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1";
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";

        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";

        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";

        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";

        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";

        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";
        }

        private void btn_Plus_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "+";
        }

        private void btn_Minus_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "-";

        }

        private void btn_Multiply_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "*";

        }

        private void btn_Devide_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "/";

        }

        private void btn_0_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";

        }

        private void btn_BackSpace_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            }

            this.ActiveControl = textBox1;

            textBox1.SelectionStart = textBox1.Text.Length;

        }

        private void btn_Point_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ",";
        }

        private void btn_PlusMinus_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0) return;
            if (textBox1.Text[0] != '-')
            {
                textBox1.Text = "-" + textBox1.Text;
            }

            else
            {
                textBox1.Text = textBox1.Text.Substring(1);
            }

        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";
        }
    }
}
