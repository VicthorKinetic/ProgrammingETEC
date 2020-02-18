using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace prjProva
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Calculo calculo = new Calculo();

        private void btn_Demonstrar_Click(object sender, EventArgs e)
        {
            lbl_num.Text = "";
            lbl_num.Visible = true;

            calculo.Calc();
            for (int i = 0; i < 50; i++)
            {
                if (i == 29 || i == 42)
                {
                  lbl_num.Text = lbl_num.Text + "\n\n";
                }
                  lbl_num.Text = lbl_num.Text + calculo.num[i].ToString();
                  lbl_num.Text = lbl_num.Text + " ";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbl_num.Visible = false;
        }
    }
}
