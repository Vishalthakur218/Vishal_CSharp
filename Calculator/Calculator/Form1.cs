using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
       
    {
        double num1, num2, result;
        string sign;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            num1 = double.Parse(textBox1.Text); // stores value appearted on tb in varabial
            sign = "+";
            textBox1.Text = ""; // to clear 
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";
        }

        private void b7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";
        }

        private void b4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";
        }

        private void b8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";
        }

        private void bsub_Click(object sender, EventArgs e)
        {
            num1 = double.Parse(textBox1.Text); // stores value appearted on tb in varabial
            sign = "-";
            textBox1.Text = ""; // to clear 
        }

        private void bMulti_Click(object sender, EventArgs e)
        {
            num1 = double.Parse(textBox1.Text); // stores value appearted on tb in varabial
            sign = "x";
            textBox1.Text = ""; // to clear 
        }

        private void bdivide_Click(object sender, EventArgs e)
        {
            num1 = double.Parse(textBox1.Text); // stores value appearted on tb in varabial
            sign = "/";
            textBox1.Text = ""; // to clear 
        }

        private void bClear_Click(object sender, EventArgs e)
        {
            //clear and reset 0
            textBox1.Text = "";
            sign = "";
            num1 = 0;
            num2 = 0;
        }

        private void bequals_Click(object sender, EventArgs e)
        {
            //equals
            //operations
            if (sign == "+")
            {
                num2=double.Parse(textBox1.Text);
                result = num1 + num2;
                textBox1.Text = result.ToString(); // display result in tb
            }
            else if (sign == "-")
            {
                num2 = double.Parse(textBox1.Text);
                result = num1 - num2;
                textBox1.Text = result.ToString(); // display result in tb
            }
            else if (sign == "x")
            {
                num2 = double.Parse(textBox1.Text);
                result = num1 * num2;
                textBox1.Text = result.ToString(); // display result in tb
            }
            else if (sign == "/")
            {
                num2 = double.Parse(textBox1.Text);
                result = num1 / num2;
                textBox1.Text = result.ToString(); // display result in tb
            }
        }

        private void b9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";
        }

        private void b0_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
        }
    }
}
