using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace prjJogoInfantilDeSeiLáMatemática2
{
    public partial class JogoInfantilDeSeiLáMatemática : Form
    {
        public JogoInfantilDeSeiLáMatemática()
        {
            InitializeComponent();
        }

        double[] res = new double[11];
        double[] h = new double[11];
        double n1 = 0, n2 = 0, simb = 0;
        int i = 0;
        int g = 0;
        Random rdn = new Random();

        private void Form1_Load(object sender, EventArgs e)
        {
            n1 = rdn.Next(1, 11);
            n2 = rdn.Next(1, 11);
            simb = rdn.Next(1, 5);


            lbl1.Text = n1.ToString();
            lbl3.Text = n2.ToString();

            if (simb == 1)
            {
                lbl2.Text = ("+");
                h[g] = n1 + n2;
            }

            else
            {
                if (simb == 2)
                {
                    lbl2.Text = ("-");
                    h[g] = n1 - n2;
                }

                else
                {
                    if (simb == 3)
                    {
                        lbl2.Text = ("X");
                        h[g] = n1 * n2;
                    }
                    else
                    {
                        lbl2.Text = ("/");
                        h[g] = n1 / n2;
                    }
                }
            }
             

        }

        private void bt1_Click_1(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txt1.Text))
            {
                MessageBox.Show("Por favor preencha o campo da resposta.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

            else
            {
                if (double.TryParse(txt1.Text, out res[i]))
                {
                    res[i] = Convert.ToDouble(txt1.Text);

                    i = i + 1;
                    g = g + 1;

                    n1 = rdn.Next(1, 11);
                    n2 = rdn.Next(1, 11);
                    simb = rdn.Next(1, 5);


                    lbl1.Text = n1.ToString();
                    lbl3.Text = n2.ToString();

                    if (simb == 1)
                    {
                        lbl2.Text = ("+");

                        h[g] = n1 + n2;
                    }

                    else
                    {
                        if (simb == 2)
                        {
                            lbl2.Text = ("-");
                            h[g] = n1 - n2;
                        }

                        else
                        {
                            if (simb == 3)
                            {
                                lbl2.Text = ("X");
                                h[g] = n1 * n2;
                            }
                            else
                            {
                                lbl2.Text = ("/");
                                h[g] = n1 / n2;
                            }
                        }
                    }

                    if (i != 10)
                    {
                    }
                    else
                    {

                        int pont = 0;
                        lbl1.Text = "";
                        lbl2.Text = "";
                        lbl3.Text = "";
                        txt1.Clear();

                        g = -1;
                        i = -1;

                        do
                        {
                            g ++;
                            i ++;

                            if (res[i] == h[g])
                            {
                                pont ++;
                            }
                        }
                        while ((g != 10) && (i != 10));

                        MessageBox.Show("Parabéns, Você acertou " + pont.ToString() + " contas!", "Parabéns", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                else
                {
                    MessageBox.Show("Insira um número", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }

            }
        }
    }
}
