using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace prjPalíndromo
{
    public partial class Palíndromo : Form
    {
        public Palíndromo()
        {
            InitializeComponent();
        }

        string veri = "";
        string atras = "";
        bool corno = false;

        private void btn_Veri_Click(object sender, EventArgs e)
        {
            for (int i = txt_pergunta.Text.Length - 1; i > -1; i--)
            {
                if (txt_pergunta.Text[i].ToString().ToUpper() != " ")
                {
                    veri = veri.ToUpper() + txt_pergunta.Text[i].ToString().ToUpper();
                }
            }


            for (int i = 0; i < txt_pergunta.Text.Length; i++)
            {
                if (txt_pergunta.Text[i].ToString().ToUpper() != " ")
                {
                    atras = atras.ToUpper() + txt_pergunta.Text[i].ToString().ToUpper();
                }
            }

            VeriPali();

            atras = "";
            txt_pergunta.Text = "";
            veri = "";
            corno = false;
              
        }

        private void VeriPali()
        {

            for (int a = atras.Length - 1; a > -1; a--)
            {
                if (atras[a].ToString().ToUpper() != veri[a].ToString().ToUpper())
                {
                    corno = true;
                }
            }

            if (corno != true)
            {
                MessageBox.Show("É um Palíndromo");
            }
            else
            {
                if (corno != false)
                {
                    MessageBox.Show("Não é um Palíndromo");
                }
            }
        }
    }
}
