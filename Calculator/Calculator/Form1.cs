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
        double resultvalue = 0;

        string OperationPerformed = "";

        bool isOperationPerformed = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnClick(object sender, EventArgs e)
        {
            if (txtDisplayResult.Text == "0" || isOperationPerformed)
                txtDisplayResult.Clear();
            isOperationPerformed = false;

            Button button = (Button)sender;

            if (button.Text == ".")
            {
                if (!txtDisplayResult.Text.Contains("."))
                    txtDisplayResult.Text += button.Text; 
            }
            else
            {
                txtDisplayResult.Text += button.Text;
            }



        }

        private void oprClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            OperationPerformed = button.Text;
            resultvalue = Double.Parse(txtDisplayResult.Text);
            lblCurrentOp.Text = resultvalue + " " + OperationPerformed;
            isOperationPerformed = true;

        }

        private void button14_Click(object sender, EventArgs e)
        {
            txtDisplayResult.Text = "0";
            resultvalue = 0;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            txtDisplayResult.Text = "0";

        }

        private void button13_Click(object sender, EventArgs e)
        {
            if(OperationPerformed == "+")
            {
                txtDisplayResult.Text = (resultvalue + double.Parse(txtDisplayResult.Text)).ToString();
            }
            else if (OperationPerformed == "-")
            {
                txtDisplayResult.Text = (resultvalue - double.Parse(txtDisplayResult.Text)).ToString();

            }
            else if (OperationPerformed == "X")
            {
                txtDisplayResult.Text = (resultvalue * double.Parse(txtDisplayResult.Text)).ToString();

            }
            else
            {
                txtDisplayResult.Text = (resultvalue / double.Parse(txtDisplayResult.Text)).ToString();

            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (txtDisplayResult.Text.Length > 0)
                txtDisplayResult.Text = txtDisplayResult.Text.Remove(txtDisplayResult.Text.Length - 1, 1);

            if (txtDisplayResult.Text == "")
                txtDisplayResult.Text = "0";

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
