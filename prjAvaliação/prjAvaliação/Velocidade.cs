using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace prjAvaliação
{
    public partial class Velocidade : Form
    {
        public Velocidade()
        {
            InitializeComponent();
        }

        double a, vi, t, v;

        private void btn1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt1.Text) || string.IsNullOrEmpty(txt2.Text) || string.IsNullOrEmpty(txt3.Text))
            {
                MessageBox.Show("Por favor preencha os campos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                if (!double.TryParse(txt1.Text, out a) || !double.TryParse(txt2.Text, out vi) || !double.TryParse(txt3.Text, out t))
                {
                    MessageBox.Show("Por favor preencha os campos com números.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                else
                {
                    v = vi + a * t;

                    v = v * 3.6;

                    if (v <= 40)
                    {
                        MessageBox.Show("Veículo está muito lento, está a " + v.ToString() + "km/h", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    else
                    {
                        if (40 < v && v <= 60)
                        {
                            MessageBox.Show("Veículo está em velocidade permitida, está a " + v.ToString() + "km/h", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        else
                        {
                            if (60 < v && v <= 80)
                            {
                                MessageBox.Show("Veículo está em velocidade de cruzeiro, está a " + v.ToString() + "km/h", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }

                            else
                            {
                                if (80 < v && v <= 120)
                                {
                                    MessageBox.Show("Veículo está rápido, está a " + v.ToString() + "km/h", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }

                                else
                                {
                                    MessageBox.Show("Veículo está muito rápido, está a " + v.ToString() + "km/h", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
