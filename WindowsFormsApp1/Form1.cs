using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private int clicks;
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal.TryParse(textBox1.Text, out decimal x);
            decimal.TryParse(textBox2.Text, out decimal y);
            decimal result = 0;

            if (radioButton1.Checked)
            {
                result = 5 * x + 10 / y;
            }
            else if (radioButton2.Checked)
            {
                result = 3 * (x*x) + y + 3;
                label2.Visible=true;
                button2.Visible=true;
                button3.Visible=true;
            }
            else if (radioButton3.Checked) 
            {
                result = (x + 10 * y) / 3;
                pictureBox2.Visible = true;
            }
            else if (radioButton4.Checked)
            {
                result = (x * y) / (x * y) + 1000;
            }

            label1.Text= result.ToString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            clicks += 1;
            if (clicks == 1)
            {
                label2.Text = "Выбрана не та кнопка";
            }
            else if(clicks == 2) 
            {
                label2.Text = "Ну опять не та";
            }
            else
            {
                label2.Text = "это было последнее предупреждение!!11!!";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Visible= false;
            button2.Visible = false;
            button3.Visible = false;
        }
    }
}
