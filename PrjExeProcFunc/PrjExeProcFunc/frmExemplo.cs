using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PrjExeProcFunc
{
    public partial class frmExemplo : Form
    {
        public frmExemplo()
        {
            InitializeComponent();
        }

        public string Funcao(string nome)
        {
            return "Olá, " + nome + " isso é uma função!";
        }

        private void btnFunction_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Funcao("Juliana"));
        }

        public void Procedimento(string nome)
        {
            MessageBox.Show("Olá, " + nome + " isso é um procedimento!");
        }

        private void btnProcedure_Click(object sender, EventArgs e)
        {
            Procedimento("Juliana");
        }

        private void btnString_Click(object sender, EventArgs e)
        {
            #region string
            string nome = "Juliana";

            for (int i = 0; i < nome.Length; i++)
            {
                MessageBox.Show(nome[i].ToString().ToUpper());
            }
            #endregion
        }
    }
}
