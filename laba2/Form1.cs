﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace laba2
{
    public partial class Form1 : Form
    {
        private decimal valueFirst = 0.0m;
        private decimal valueSecond = 0.0m;
        private decimal Result = 0.0m;
        private string operators = string.Empty;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ZeroBtn_Click(object sender, EventArgs e)
        {
            if (TextBox.Text == "0") { }
            else
            {
                TextBox.Text += "0";
            }
        }

        private void PointBtn_Click(object sender, EventArgs e)
        {
            if (!TextBox.Text.Contains("."))
            {
                TextBox.Text += ".";
            }
        }

        private void OneBtn_Click(object sender, EventArgs e)
        {
            if (TextBox.Text == "0")  {
                TextBox.Text = "1";
            }
            else { 
                TextBox.Text += "1";
            }
        }

        private void TwoBtn_Click(object sender, EventArgs e)
        {
            if (TextBox.Text == "0")
            {
                TextBox.Text = "2";
            }
            else
            {
                TextBox.Text += "2";
            }
        }

        private void ThreeBtn_Click(object sender, EventArgs e)
        {
            if (TextBox.Text == "0")
            {
                TextBox.Text = "3";
            }
            else
            {
                TextBox.Text += "3";
            }
        }

        private void FourBtn_Click(object sender, EventArgs e)
        {
            if (TextBox.Text == "0")
            {
                TextBox.Text = "4";
            }
            else
            {
                TextBox.Text += "4";
            }
        }

        private void FiveBtn_Click(object sender, EventArgs e)
        {
            if (TextBox.Text == "0")
            {
                TextBox.Text = "5";
            }
            else
            {
                TextBox.Text += "5";
            }
        }

        private void SixBtn_Click(object sender, EventArgs e)
        {
            if (TextBox.Text == "0")
            {
                TextBox.Text = "6";
            }
            else
            {
                TextBox.Text += "6";
            }
        }

        private void SevenBtn_Click(object sender, EventArgs e)
        {
            if (TextBox.Text == "0")
            {
                TextBox.Text = "7";
            }
            else
            {
                TextBox.Text += "7";
            }
        }

        private void EightBtn_Click(object sender, EventArgs e)
        {
            if (TextBox.Text == "0")
            {
                TextBox.Text = "8";
            }
            else
            {
                TextBox.Text += "8";
            }
        }

        private void NineBtn_Click(object sender, EventArgs e)
        {
            if (TextBox.Text == "0")
            {
                TextBox.Text = "9";
            }
            else
            {
                TextBox.Text += "9";
            }
        }

        private void MinusBtn_Click(object sender, EventArgs e)
        {
            valueFirst = decimal.Parse(TextBox.Text);
            TextBox.Clear();
            operators = "-";
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            valueFirst = decimal.Parse(TextBox.Text);
            TextBox.Clear();
            operators = "+";
        }

        private void DivBtn_Click(object sender, EventArgs e)
        {
            valueFirst = decimal.Parse(TextBox.Text);
            TextBox.Clear();
            operators = "/";
        }

        private void MulBtn_Click(object sender, EventArgs e)
        {
            valueFirst = decimal.Parse(TextBox.Text);
            TextBox.Clear();
            operators = "*";
        }

        private void CosBtn_Click(object sender, EventArgs e)
        {
            valueFirst = decimal.Parse(TextBox.Text);
            operators = "cos";
        }

        private void XoneBtn_Click(object sender, EventArgs e)
        {
            valueFirst = decimal.Parse(TextBox.Text);
            operators = "1/x";
        }

        private void EqualBtn_Click(object sender, EventArgs e)
        {
            switch (operators)
            {
                case "+":
                    valueSecond = decimal.Parse(TextBox.Text);
                    Result = valueFirst + valueSecond;
                    TextBox.Text = Result.ToString();
                    break;
                case "-":
                    valueSecond = decimal.Parse(TextBox.Text);
                    Result = valueFirst - valueSecond;
                    TextBox.Text = Result.ToString();
                    break;
                case "*":
                    valueSecond = decimal.Parse(TextBox.Text);
                    Result = valueFirst * valueSecond;
                    TextBox.Text = Result.ToString();
                    break;
                case "/":
                    valueSecond = decimal.Parse(TextBox.Text);
                    if (valueSecond != 0)
                    {
                        Result = valueFirst / valueSecond;
                        TextBox.Text = Result.ToString();
                    }
                    else
                        TextBox.Text = "Error";
                    break;
                case "cos":
                    Result = (decimal)Math.Cos((double)valueFirst);
                    TextBox.Text = Result.ToString();
                    break;
                case "1/x":
                    if (valueFirst != 0)
                    {
                        Result = 1 / valueFirst;
                        TextBox.Text = Result.ToString();
                    }
                    else
                    {
                        TextBox.Text = "Error";
                    }
                    
                    break;
            }
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            TextBox.Text = "0";
        }
    }
}
