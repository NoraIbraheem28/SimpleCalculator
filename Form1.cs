using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
        double resultValue = 0;
        String operation = " ";
        bool isOperationPerformed = false;
        public Form1()
        {
            InitializeComponent();
        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button_Click(object sender, EventArgs e)
        {
            isOperationPerformed = false;

            Button btn = (Button)sender;
            if (btn.Text == "C" || (isOperationPerformed))
            {
                textBox_result.Clear();
                labelCurrentOperation.Text = " ";
            }
            else if (btn.Text == "CE")
            {
                textBox_result.Text = "0";
                labelCurrentOperation.Text = " ";
            }
            else if ((textBox_result.Text == "0") || (isOperationPerformed))
            {
                textBox_result.Clear();

            }
            else
            {
                textBox_result.Text = textBox_result.Text + btn.Text;
            }
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            operation = btn.Text;
            resultValue = Double.Parse(textBox_result.Text);
            labelCurrentOperation.Text = resultValue + " " + operation;
            isOperationPerformed = true;
            textBox_result.Clear();


        }
        private void button19_Click(object sender, EventArgs e)
        {
            switch (operation)
            {
                case "+":

                    labelCurrentOperation.Text += textBox_result.Text;
                    textBox_result.Text = (resultValue + Double.Parse(textBox_result.Text)).ToString();
                    break;
                case "-":
                    labelCurrentOperation.Text += textBox_result.Text;
                    textBox_result.Text = (resultValue - Double.Parse(textBox_result.Text)).ToString();

                    break;
                case "X":
                    labelCurrentOperation.Text += textBox_result.Text;
                    textBox_result.Text = (resultValue * Double.Parse(textBox_result.Text)).ToString();

                    break;
                case "/":
                    labelCurrentOperation.Text += textBox_result.Text;
                    textBox_result.Text = (resultValue / Double.Parse(textBox_result.Text)).ToString();

                    break;
                default:
                    break;


            }
            
        }


    }
}

