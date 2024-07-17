using System;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {

        private int valor1;


        public Form1()
        {
            InitializeComponent();
            valor1 = 0;
            num.Text = "";
            num2.Text = "";
            Resu.Text = "";
            ope.Visible = false;
            ope.Text = "";

            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Result.Enabled = false;


        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (ope.Visible == false)
            {
                num.Text += "1";


            }

            else if (ope.Visible == true)
            {
                num2.Text += "1";
            }

        }

        private void N2_Click(object sender, EventArgs e)
        {
            if (ope.Visible == false)
            {
                num.Text += "2";


            }

            else if (ope.Visible == true)
            {
                num2.Text += "2";
            }

        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            if (ope.Visible == false)
            {
                num.Text += "3";


            }

            else if (ope.Visible == true)
            {
                num2.Text += "3";
            }
        }
        private void N4_Click(object sender, EventArgs e)
        {
            if (ope.Visible == false)
            {
                num.Text += "4";


            }

            else if (ope.Visible == true)
            {
                num2.Text += "4";
            }
        }
        private void N5_Click(object sender, EventArgs e)
        {
            if (ope.Visible == false)
            {
                num.Text += "5";


            }

            else if (ope.Visible == true)
            {
                num2.Text += "5";
            }
        }

        private void N6_Click(object sender, EventArgs e)
        {
            if (ope.Visible == false)
            {
                num.Text += "6";


            }

            else if (ope.Visible == true)
            {
                num2.Text += "6";
            }
        }
        private void N7_Click(object sender, EventArgs e)
        {
            if (ope.Visible == false)
            {
                num.Text += "7";


            }

            else if (ope.Visible == true)
            {
                num2.Text += "7";
            }
        }
        private void N8_Click(object sender, EventArgs e)
        {
            if (ope.Visible == false)
            {
                num.Text += "8";


            }

            else if (ope.Visible == true)
            {
                num2.Text += "8";
            }
        }
        private void N9_Click(object sender, EventArgs e)
        {
            if (ope.Visible == false)
            {
                num.Text += "9";


            }

            else if (ope.Visible == true)
            {
                num2.Text += "9";
            }
        }
        private void button9_Click(object sender, EventArgs e)
        {
            ope.Visible = true;
            ope.Text = "+";


        }
        private void button10_Click(object sender, EventArgs e)
        {
            ope.Visible = true;
            ope.Text = "-";
        }
        private void button11_Click(object sender, EventArgs e)
        {
            ope.Visible = true;
            ope.Text = "*";
        }
        private void button12_Click(object sender, EventArgs e)
        {
            ope.Visible = true;
            ope.Text = "/";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            valor1 += 1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int valorf1 = int.Parse(num.Text);
            int valorf2 = int.Parse(num2.Text);
            if (ope.Text == "+")
            {
                valor1 = valorf1 + valorf2;
            }
            if (ope.Text == "-")
            {
                valor1 = valorf1 - valorf2;
            }
            if (ope.Text == "*")
            {
                valor1 = valorf1 * valorf2;
            }
            if (ope.Text == "/")
            {
                valor1 = valorf1 / valorf2;

            }


            Resu.Text = valor1.ToString();



        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {

            num.Text = "";
            num2.Text = "";
            ope.Visible = false;
            Resu.Text = "";

        }
    }
}
