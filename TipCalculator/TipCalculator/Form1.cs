using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TipCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ComputeButton_Click(object sender, EventArgs e)
        {

            double inputNumber = double.Parse(EnterTextBox.Text);
            double percentNumber = double.Parse(percentageAmount.Text);
            double tip = inputNumber * (percentNumber / 100);
            this.ComputeTextBox.Text = tip.ToString();
            double total = inputNumber + tip;
            this.totalTextBox.Text = total.ToString();


        }

        private Exception EventArgs(EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void ComputeTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void EnterTextBox_TextChanged(object sender, EventArgs e)
        {
            string test = EnterTextBox.Text;
            double inputNumber = 0;
            if (!double.TryParse(test, out inputNumber))
            {
                ComputeButton.Enabled = false;
            }
            if (double.TryParse(test, out inputNumber))
            {
                ComputeButton.Enabled = true;
            }
        }

        private void percentageLabel_Click(object sender, EventArgs e)
        {

        }

        private void percentageAmount_TextChanged(object sender, EventArgs e)
        {
            string test = EnterTextBox.Text;
            double inputNumber = 0;
            if (!double.TryParse(test, out inputNumber))
            {
                ComputeButton.Enabled = false;
            }
            if (double.TryParse(test, out inputNumber))
            {
                ComputeButton.Enabled = true;
            }
        }
    }
}
