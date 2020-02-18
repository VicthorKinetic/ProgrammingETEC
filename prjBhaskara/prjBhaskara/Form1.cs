using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace prjBhaskara
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label6.Text = ("");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label6.Text = ("");
            label4.Text = ("");
            label5.Text = ("");
            double a, b, c, d, x1, x2;
            a = 0; b = 0; c = 0; d = 0; x1 = 0; x2 = 0;

            if ((string.IsNullOrEmpty(textBox1.Text)) || (string.IsNullOrEmpty(textBox2.Text)) || (string.IsNullOrEmpty(textBox3.Text)))
            {
                label6.Text = ("Campos vazios!");
            }
            else
            {
                if (double.TryParse(textBox1.Text, out a))
                {
                    if (double.TryParse(textBox2.Text, out b))
                    {
                        if (double.TryParse(textBox3.Text, out c))
                        {
                            a = Convert.ToDouble(textBox1.Text);
                            b = Convert.ToDouble(textBox2.Text);
                            c = Convert.ToDouble(textBox3.Text);

                            d = (b * b) - 4 * a * c;

                            d = Math.Sqrt(d);

                            x1 = (-b + d) / (2 * a);
                            x2 = (-b - d) / (2 * a);

                            label4.Text = ("X1 = " + x1.ToString());
                            label5.Text = ("X2 = " + x2.ToString());
                        }
                        else
                        {
                            label6.Text = ("É necessário números para esse processo");
                        }
                    }

                    else
                    {
                        label6.Text = ("É necessário números para esse processo");
                    }
                }

                else
                {
                    label6.Text = ("É necessário números para esse processo");
                }
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }   
    }
}
