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
        string num1;
        string num2;
        string op;
        
        public Form1()
        {
            InitializeComponent();
            num1 = "";
            num2 = "";
            op = " ";
            textBox1.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (num1.Length == 0) {
                textBox1.Text = "1";
                num1 = "1";
            } 
            else if (textBox1.Text.Length > 0)
            {
                if (textBox1.Text.IndexOf(Convert.ToChar(op)) < 0)
                {
                    textBox1.Text = textBox1.Text + "1";
                    num1 = num1 + "1";
                }
                else {
                    if (num2.Length == 0)
                    {
                        textBox1.Text = textBox1.Text + "1";
                        num2 = "1";
                    }
                    else {
                        textBox1.Text = textBox1.Text + "1";
                        num2 = num2 + "1";
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (num1.Length == 0)
            {
                textBox1.Text = "2";
                num1 = "2";
            }
            else if (textBox1.Text.Length > 0)
            {
                if (textBox1.Text.IndexOf(Convert.ToChar(op)) < 0)
                {
                    textBox1.Text = textBox1.Text + "2";
                    num1 = num1 + "2";
                }
                else
                {
                    if (num2.Length == 0)
                    {
                        textBox1.Text = textBox1.Text + "2";
                        num2 = "2";
                    }
                    else
                    {
                        textBox1.Text = textBox1.Text + "2";
                        num2 = num2 + "2";
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (num1.Length == 0)
            {
                textBox1.Text = "3";
                num1 = "3";
            }
            else if (textBox1.Text.Length > 0)
            {
                if (textBox1.Text.IndexOf(Convert.ToChar(op)) < 0)
                {
                    textBox1.Text = textBox1.Text + "3";
                    num1 = num1 + "3";
                }
                else
                {
                    if (num2.Length == 0)
                    {
                        textBox1.Text = textBox1.Text + "3";
                        num2 = "3";
                    }
                    else
                    {
                        textBox1.Text = textBox1.Text + "3";
                        num2 = num2 + "3";
                    }
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (num1.Length == 0)
            {
                textBox1.Text = "4";
                num1 = "4";
            }
            else if (textBox1.Text.Length > 0)
            {
                if (textBox1.Text.IndexOf(Convert.ToChar(op)) < 0)
                {
                    textBox1.Text = textBox1.Text + "4";
                    num1 = num1 + "4";
                }
                else
                {
                    if (num2.Length == 0)
                    {
                        textBox1.Text = textBox1.Text + "4";
                        num2 = "4";
                    }
                    else
                    {
                        textBox1.Text = textBox1.Text + "4";
                        num2 = num2 + "4";
                    }
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (num1.Length == 0)
            {
                textBox1.Text = "5";
                num1 = "5";
            }
            else if (textBox1.Text.Length > 0)
            {
                if (textBox1.Text.IndexOf(Convert.ToChar(op)) < 0)
                {
                    textBox1.Text = textBox1.Text + "5";
                    num1 = num1 + "5";
                }
                else
                {
                    if (num2.Length == 0)
                    {
                        textBox1.Text = textBox1.Text + "5";
                        num2 = "5";
                    }
                    else
                    {
                        textBox1.Text = textBox1.Text + "5";
                        num2 = num2 + "5";
                    }
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (num1.Length == 0)
            {
                textBox1.Text = "6";
                num1 = "6";
            }
            else if (textBox1.Text.Length > 0)
            {
                if (textBox1.Text.IndexOf(Convert.ToChar(op)) < 0)
                {
                    textBox1.Text = textBox1.Text + "6";
                    num1 = num1 + "6";
                }
                else
                {
                    if (num2.Length == 0)
                    {
                        textBox1.Text = textBox1.Text + "6";
                        num2 = "6";
                    }
                    else
                    {
                        textBox1.Text = textBox1.Text + "6";
                        num2 = num2 + "6";
                    }
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (num1.Length == 0)
            {
                textBox1.Text = "7";
                num1 = "7";
            }
            else if (textBox1.Text.Length > 0)
            {
                if (textBox1.Text.IndexOf(Convert.ToChar(op)) < 0)
                {
                    textBox1.Text = textBox1.Text + "7";
                    num1 = num1 + "7";
                }
                else
                {
                    if (num2.Length == 0)
                    {
                        textBox1.Text = textBox1.Text + "7";
                        num2 = "7";
                    }
                    else
                    {
                        textBox1.Text = textBox1.Text + "7";
                        num2 = num2 + "7";
                    }
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (num1.Length == 0)
            {
                textBox1.Text = "8";
                num1 = "8";
            }
            else if (textBox1.Text.Length > 0)
            {
                if (textBox1.Text.IndexOf(Convert.ToChar(op)) < 0)
                {
                    textBox1.Text = textBox1.Text + "8";
                    num1 = num1 + "8";
                }
                else
                {
                    if (num2.Length == 0)
                    {
                        textBox1.Text = textBox1.Text + "8";
                        num2 = "8";
                    }
                    else
                    {
                        textBox1.Text = textBox1.Text + "8";
                        num2 = num2 + "8";
                    }
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (num1.Length == 0)
            {
                textBox1.Text = "9";
                num1 = "9";
            }
            else if (textBox1.Text.Length > 0)
            {
                if (textBox1.Text.IndexOf(Convert.ToChar(op)) < 0)
                {
                    textBox1.Text = textBox1.Text + "9";
                    num1 = num1 + "9";
                }
                else
                {
                    if (num2.Length == 0)
                    {
                        textBox1.Text = textBox1.Text + "9";
                        num2 = "9";
                    }
                    else
                    {
                        textBox1.Text = textBox1.Text + "9";
                        num2 = num2 + "9";
                    }
                }
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (num1.Length == 0)
            {
                textBox1.Text = "0";
                num1 = "0";
            }
            else if (textBox1.Text.Length > 0)
            {
                if (textBox1.Text.IndexOf(Convert.ToChar(op)) < 0)
                {
                    textBox1.Text = textBox1.Text + "0";
                    num1 = num1 + "0";
                }
                else
                {
                    if (num2.Length == 0)
                    {
                        textBox1.Text = textBox1.Text + "0";
                        num2 = "0";
                    }
                    else
                    {
                        textBox1.Text = textBox1.Text + "0";
                        num2 = num2 + "0";
                    }
                }
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (num1.Length == 0)
            {
                textBox1.Text = "0.";
                num1 = "0.";
            }
            else
            {
                if (textBox1.Text.IndexOf(Convert.ToChar(op)) < 0)
                {
                    if (num1.IndexOf('.') < 0) {
                        textBox1.Text = textBox1.Text + ".";
                        num1 = num1 + ".";
                    }
                }
                else
                {
                    if (num2.Length == 0)
                    {
                        textBox1.Text = textBox1.Text + "0.";
                        num2 = "0.";
                    }
                    else
                    {
                        if (num2.IndexOf('.') < 0) {
                            textBox1.Text = textBox1.Text + ".";
                            num2 = num2 + ".";
                        }
                    }
                }
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (num1.Length > 0 && num2.Length > 0 && op.Length > 0) {
                switch (op)
                {
                    case "+":
                        num1 = Convert.ToString(Convert.ToDecimal(num1) + Convert.ToDecimal(num2));
                        textBox1.Text = num1;
                        num2 = "";
                        op = " ";
                        break;
                    case "-":
                        num1 = Convert.ToString(Convert.ToDecimal(num1) - Convert.ToDecimal(num2));
                        textBox1.Text = num1;
                        num2 = "";
                        op = " ";
                        break;
                    case "*":
                        num1 = Convert.ToString(Convert.ToDecimal(num1) * Convert.ToDecimal(num2));
                        textBox1.Text = num1;
                        num2 = "";
                        op = " ";
                        break;
                    case "/":
                        if (num2 == "0")
                        {
                            textBox1.Text = "Cannot divide by 0";
                            num1 = "";
                            num2 = "";
                            op = " ";
                        }
                        else {
                            num1 = Convert.ToString(Convert.ToDecimal(num1) / Convert.ToDecimal(num2));
                            textBox1.Text = num1;
                            num2 = "";
                            op = " ";
                        }
                        break;
                    case "%":
                        num1 = Convert.ToString(Convert.ToDecimal(num1) % Convert.ToDecimal(num2));
                        textBox1.Text = num1;
                        num2 = "";
                        op = " ";
                        break;
                    default:
                        break;
                }
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (num1.Length == 0)
            {
                textBox1.Text = "0+";
                num1 = "0";
                op = "+";
            }
            else if (textBox1.Text.IndexOf(Convert.ToChar(op)) < 0) {
                textBox1.Text = textBox1.Text + "+";
                op = "+";
            } else if (textBox1.Text.IndexOf(Convert.ToChar(op)) >= 0) {
                if (num2.Length > 0)
                {
                    button18_Click(sender, e);
                    if (num1.Length != 0)
                    {
                        textBox1.Text = textBox1.Text + "+";
                        op = "+";
                    }
                }
                else {
                    textBox1.Text = textBox1.Text.Replace(op, "+");
                    op = "+";
                }
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (num1.Length == 0)
            {
                textBox1.Text = "0-";
                num1 = "0";
                op = "-";
            }
            else if (textBox1.Text.IndexOf(Convert.ToChar(op)) < 0)
            {
                textBox1.Text = textBox1.Text + "-";
                op = "-";
            }
            else if (textBox1.Text.IndexOf(Convert.ToChar(op)) >= 0)
            {
                if (num2.Length > 0)
                {
                    button18_Click(sender, e);
                    if (num1.Length != 0)
                    {
                        textBox1.Text = textBox1.Text + "-";
                        op = "-";
                    }
                }
                else
                {
                    textBox1.Text = textBox1.Text.Replace(op, "-");
                    op = "-";
                }
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (num1.Length == 0)
            {
                textBox1.Text = "0*";
                num1 = "0";
                op = "*";
            }
            else if (textBox1.Text.IndexOf(Convert.ToChar(op)) < 0)
            {
                textBox1.Text = textBox1.Text + "*";
                op = "*";
            }
            else if (textBox1.Text.IndexOf(Convert.ToChar(op)) >= 0)
            {
                if (num2.Length > 0)
                {
                    button18_Click(sender, e);
                    if (num1.Length != 0)
                    {
                        textBox1.Text = textBox1.Text + "*";
                        op = "*";
                    }
                }
            }
            else
            {
                textBox1.Text = textBox1.Text.Replace(op, "*");
                op = "*";
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (num1.Length == 0)
            {
                textBox1.Text = "0/";
                num1 = "0";
                op = "/";
            }
            else if (textBox1.Text.IndexOf(Convert.ToChar(op)) < 0)
            {
                textBox1.Text = textBox1.Text + "/";
                op = "/";
            }
            else if (textBox1.Text.IndexOf(Convert.ToChar(op)) >= 0)
            {
                if (num2.Length > 0)
                {
                    button18_Click(sender, e);
                    if (num1.Length != 0)
                    {
                        textBox1.Text = textBox1.Text + "/";
                        op = "/";
                    }
                }
                else
                {
                    textBox1.Text = textBox1.Text.Replace(op, "/");
                    op = "/";
                }
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (num1.Length == 0)
            {
                textBox1.Text = "0%";
                num1 = "0";
                op = "%";
            }
            else if (textBox1.Text.IndexOf(Convert.ToChar(op)) < 0)
            {
                textBox1.Text = textBox1.Text + "%";
                op = "%";
            }
            else if (textBox1.Text.IndexOf(Convert.ToChar(op)) >= 0)
            {
                if (num2.Length > 0)
                {
                    button18_Click(sender, e);
                    if (num1.Length != 0)
                    {
                        textBox1.Text = textBox1.Text + "%";
                        op = "%";
                    }
                }
                else
                {
                    textBox1.Text = textBox1.Text.Replace(op, "%");
                    op = "%";
                }
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            num1 = "";
            num2 = "";
            op = " ";
            textBox1.Text = "";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (op != " ")
            {
                if (num2 != "")
                {
                    textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length-1);
                    num2 = num2.Substring(0, num2.Length - 1);
                }
                else { 
                    textBox1.Text = textBox1.Text.Substring(0,textBox1.Text.Length-1);
                    op = " ";
                }
            }
            else if (num1 != "") {
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
                num1 = num1.Substring(0, num1.Length - 1);
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            button10_Click(sender, e);
        }
    }
}
