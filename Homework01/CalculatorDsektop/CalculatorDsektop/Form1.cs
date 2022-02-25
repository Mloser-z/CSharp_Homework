using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorDsektop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double fir = System.Convert.ToDouble(textBox1.Text);
            double sec = System.Convert.ToDouble(textBox2.Text);
            if (radioButton4.Checked && sec == 0)
            {
                textBox3.Text = "InputError!";
            }

            if (radioButton1.Checked)
            {
                textBox3.Text = Convert.ToString(fir + sec);
            }
            if (radioButton2.Checked)
            {
                textBox3.Text = Convert.ToString(fir - sec);
            }
            if (radioButton3.Checked)
            {
                textBox3.Text = Convert.ToString(fir * sec);
            }
            if (radioButton4.Checked)
            {
                if (sec == 0)
                {
                    textBox3.Text = "InputError!";
                }
                else
                {
                    textBox3.Text = Convert.ToString(fir / sec);
                }
                
            }
        }
    }
}