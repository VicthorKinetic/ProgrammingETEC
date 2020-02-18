using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace prjAtividade
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        int nr;
       
       

        private void Form1_Load(object sender, EventArgs e)
        {
            Random rdn = new Random();
            nr = rdn.Next(2, 100);
         
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int n, min, max;
            n = 0; min = 0; max = 0;

            if (textBox1.Text == "")
            {
                label7.Text = ("Digite um número.");

            }
            else
            {
                if (int.TryParse(textBox1.Text, out n))
                {


                    label7.Text = ("");
                    if (n != nr)
                    {



                        min = Convert.ToInt32(label4.Text);
                        max = Convert.ToInt32(label6.Text);




                        if (n < nr)
                        {
                            if (n > min)
                                {
                                    label4.Text = textBox1.Text;
                                    textBox1.Clear();
                                    if (label1.ForeColor == Color.Yellow)
                                    {
                                        label2.ForeColor = Color.Yellow;
                                        label1.ForeColor = SystemColors.ActiveBorder;
                                    }
                                    else
                                    {
                                        label1.ForeColor = Color.Yellow;
                                        label2.ForeColor = SystemColors.ActiveBorder;
                                    }
                                }

                                else
                                {
                                    label7.Text = ("Digite um número válido.");

                                }
                            
                        }
                        else
                        {
                            if (n > nr)
                            {
                                    if (n < max)
                                    {
                                        label6.Text = textBox1.Text;
                                        textBox1.Clear();
                                        if (label1.ForeColor == Color.Yellow)
                                        {
                                            label2.ForeColor = Color.Yellow;
                                            label1.ForeColor = SystemColors.ActiveBorder;
                                        }
                                        else
                                        {
                                            label1.ForeColor = Color.Yellow;
                                            label2.ForeColor = SystemColors.ActiveBorder;
                                        }
                                    }
                                else
                            {
                                label7.Text = ("Digite um número válido.");

                            }
                                }
                                
                            }

                            

                        }
                    

                    else
                    {
                        button1.Text = ("Você perdeu!");
                    }
                }
                else
                {
                    label7.Text = ("Digite números, não letras.");
                }     
            }
        }      
    }
}
