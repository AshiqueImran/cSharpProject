using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public static double num1 = 0;
        public static double num2 = 0;
        public static String operation= null;


        public Form1()
        {
            InitializeComponent();
            textBox1.Text = num1.ToString();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (operation == "add")
            {
                num1 = num2 + num1;
                textBox1.Text = num1.ToString();
            }
            else if (operation == "sub")
            {
                num1 = num2 - num1;
                textBox1.Text = num1.ToString();
            }
            else if (operation == "mult")
            {
                num1 = num2 * num1;
                textBox1.Text = num1.ToString();
            }
            else if (operation == "div")
            {
                num1 = num2 / num1;
                textBox1.Text = num1.ToString();
            }
            else
            {
                num1 = 0;
                textBox1.Text = num1.ToString();
            }
            operation = null;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            num1 = num1 * 10 + 1;
            textBox1.Text = num1.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            num1 = num1 * 10 + 2;
            textBox1.Text = num1.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            num1 = num1 * 10 + 3;
            textBox1.Text = num1.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            num1 = num1 * 10 + 4;
            textBox1.Text = num1.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            num1 = num1 * 10 + 5;
            textBox1.Text = num1.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            num1 = num1 * 10 + 6;
            textBox1.Text = num1.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            num1 = num1 * 10 + 7;
            textBox1.Text = num1.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            num1 = num1 * 10 + 8;
            textBox1.Text = num1.ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            num1 = num1 * 10 + 9;
            textBox1.Text = num1.ToString();
        }

        private void add_Click(object sender, EventArgs e)
        {
            num2 = num1;
            num1 = 0;
            operation = "add";

        }

        private void sub_Click(object sender, EventArgs e)
        {
            num2 = num1;
            num1 = 0;
            operation = "sub";
        }

        private void mult_Click(object sender, EventArgs e)
        {
            num2 = num1;
            num1 = 0;
            operation = "mult";
        }

        private void div_Click(object sender, EventArgs e)
        {
            num2 = num1;
            num1 = 0;
            operation = "div";
        }

        private void ac_Click(object sender, EventArgs e)
        {
            num1 = 0;
            num2 = 0;
            textBox1.Text = num1.ToString();
        }

        private void button0_Click(object sender, EventArgs e)
        {
            num1 = num1 * 10;
            textBox1.Text = num1.ToString();
        }
    }
}
