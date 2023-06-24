using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lblresult.Text = "";
            txtnum1.Text = "";
            txtnum2.Text = "";
            txtop.Text = "";
        }

        private void txtop_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblresult_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            double num1, num2;
            string op;
            num1 = Convert.ToDouble(txtnum1.Text);
            op = txtop.Text;
            num2 = Convert.ToDouble(txtnum2.Text);
            switch (op)
            {
                case "+": lblresult.Text = Convert.ToString(num1 + num2);break;
                case "-": lblresult.Text = Convert.ToString(num1 - num2); break;
                case "*": lblresult.Text = Convert.ToString(num1 * num2); break;
                case "/": lblresult.Text = Convert.ToString(num1 / num2); break;
                default:lblresult.Text = "Invalid Input";break;
            }
          

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblresult_MouseMove(object sender, MouseEventArgs e)
        {
            lblresult.ForeColor = Color.Yellow;
        }

        private void lblresult_MouseLeave(object sender, EventArgs e)
        {
            lblresult.ForeColor = Color.Violet;
        }
    }
}
