using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clac
{
    public partial class Form1 : Form
    {
        Double resultValue = 0;
        String operationPerformed = "";
        bool isOperationPerformed = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (resultValue != 0)
            {
                button15.PerformClick();
                operationPerformed = button.Text;
                labelCurrentOperation.Text = resultValue + " " + operationPerformed;
                isOperationPerformed = true;
            }
            else
            {

                operationPerformed = button.Text;
                resultValue = Double.Parse(textBox1.Text);
                labelCurrentOperation.Text = resultValue + " " + operationPerformed;
                isOperationPerformed = true;
            }
        }



        private void menuItem3_Click(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.WhiteSmoke;
        }

        private void menuItem10_Click(object sender, EventArgs e)
        {
            AboutBox1 about = new AboutBox1();
            about.Show();
        }

        private void menuItem6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void menuItem4_Click(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.Color.DimGray;
        }

        private void ButtonClickNum(object sender, EventArgs e)
        {
            if ((textBox1.Text == "0") || (isOperationPerformed))
                textBox1.Clear();
            if (textBox1.Text == "No Operation Selected!")
            {
                textBox1.Clear();
            }

            isOperationPerformed = false;
            Button button = (Button)sender;
            if (button.Text == ".")
            {
                if (!textBox1.Text.Contains("."))
                    textBox1.Text = textBox1.Text + button.Text;
            }
            else
                textBox1.Text = textBox1.Text + button.Text;
        }

        private void menuItem12_Click(object sender, EventArgs e)
        {
            DialogResult dialog = fontDialog1.ShowDialog();
            if(dialog == DialogResult.OK)
            {
                button1.Font = fontDialog1.Font;
                button2.Font = fontDialog1.Font;
                button3.Font = fontDialog1.Font;
                button4.Font = fontDialog1.Font;
                button5.Font = fontDialog1.Font;
                button6.Font = fontDialog1.Font;
                button7.Font = fontDialog1.Font;
                button8.Font = fontDialog1.Font;
                button9.Font = fontDialog1.Font;
                button10.Font = fontDialog1.Font;
                button11.Font = fontDialog1.Font;
                button12.Font = fontDialog1.Font;
                button13.Font = fontDialog1.Font;
                button14.Font = fontDialog1.Font;
                button15.Font = fontDialog1.Font;
                textBox1.Font = fontDialog1.Font;
                labelCurrentOperation.Font = fontDialog1.Font;
            }

        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            resultValue = 0;
        }

        private void button15_Click(object sender, EventArgs e)
        {   
                switch (operationPerformed)
                {
                    case "+":
                        textBox1.Text = (resultValue + Double.Parse(textBox1.Text)).ToString();
                        break;
                    case "-":
                        textBox1.Text = (resultValue - Double.Parse(textBox1.Text)).ToString();
                        break;
                    case "*":
                        textBox1.Text = (resultValue * Double.Parse(textBox1.Text)).ToString();
                        break;
                    case "/":
                        textBox1.Text = (resultValue / Double.Parse(textBox1.Text)).ToString();
                        break;
                    default:
                        break;
                }
                resultValue = Double.Parse(textBox1.Text);
                labelCurrentOperation.Text = "";
            
        }

    }
}

