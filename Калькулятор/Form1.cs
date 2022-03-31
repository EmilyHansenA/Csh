using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace СShLesson
{

    public partial class Form1 : Form
    {
        float a, b;
        int count;
        bool znak = true;

        public Form1()
        {
            InitializeComponent();
        }
        private void calculate()
        {
            switch (count)
            {
                case 1:
                    b = a + float.Parse(tbAnswer.Text);
                    tbAnswer.Text = b.ToString();
                    break;
                case 2:
                    b = a - float.Parse(tbAnswer.Text);
                    tbAnswer.Text = b.ToString();
                    break;
                case 3:
                    b = a * float.Parse(tbAnswer.Text);
                    tbAnswer.Text = b.ToString();
                    break;
                case 4:
                    b = a / float.Parse(tbAnswer.Text);
                    tbAnswer.Text = b.ToString();
                    break;

                default:
                    break;
            }
        }

        //Числа. Начало

        private void btn0_Click(object sender, EventArgs e)
        {
            tbAnswer.Text += 0;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            tbAnswer.Text += 1;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            tbAnswer.Text += 2;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            tbAnswer.Text += 3;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            tbAnswer.Text += 4;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            tbAnswer.Text += 5;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            tbAnswer.Text += 6;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            tbAnswer.Text += 7;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            tbAnswer.Text += 8;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            tbAnswer.Text += 9;
        }

//Числа. Конец

        private void btnpoint_Click(object sender, EventArgs e)
        {
            tbAnswer.Text += ",";
        }

//Операции. Начало

        private void btnplus_Click(object sender, EventArgs e)
        {
            a = float.Parse(tbAnswer.Text);
            tbAnswer.Clear();
            count = 1;
            lbl.Text = a.ToString() + "+";
            znak = true;
        }

        private void btnminus_Click(object sender, EventArgs e)
        {
            a = float.Parse(tbAnswer.Text);
            tbAnswer.Clear();
            count = 2;
            lbl.Text = a.ToString() + "-";
            znak = true;
        }

        private void btnmultiply_Click(object sender, EventArgs e)
        {
            a = float.Parse(tbAnswer.Text);
            tbAnswer.Clear();
            count = 3;
            lbl.Text = a.ToString() + "*";
            znak = true;
        }

        private void btnsplit_Click(object sender, EventArgs e)
        {
            a = float.Parse(tbAnswer.Text);
            tbAnswer.Clear();
            count = 4;
            lbl.Text = a.ToString() + "/";
            znak = true;
        }

        private void btneq_Click(object sender, EventArgs e)
        {
            calculate();
            lbl.Text = "";
        }

//Функции Калькулятор
        private void btnclear_Click(object sender, EventArgs e)
        {
            tbAnswer.Text = "";
            lbl.Text = "";
        }

        private void btnerase_Click(object sender, EventArgs e)
        {
            int lenght = tbAnswer.Text.Length - 1;
            string text = tbAnswer.Text;
            tbAnswer.Clear();

            for (int i = 0; i < lenght; i++)
            {
                tbAnswer.Text += text[i];
            }
        }

        private void btndenial_Click(object sender, EventArgs e)
        {
            if (znak == true)
            {
                tbAnswer.Text = "-" + tbAnswer.Text;
                znak = false;
            }

            else if(znak == false)
            {
                tbAnswer.Text = tbAnswer.Text.Replace("-", "");
                znak = true;
            }
        }
    }
}
