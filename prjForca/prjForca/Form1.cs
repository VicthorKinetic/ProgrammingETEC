using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace prjForca
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        int erros = 0;
        string palavra = "";
        int errou = 0;
        int pos = 0;
        bool cosa = true;

        private void Form1_Load(object sender, EventArgs e)
        {
            lbl_Letra.Visible = false;
            txt_Letra.Visible = false;
            btn_Letra.Visible = false;
            lbl_ExibeErros.Visible = false;
            lbl_ExibePalavra.Visible = false;
            lbl_ExibeErros.Text = "Erros:";
            lbl_boneco1.Visible = false;
            lbl_boneco2.Visible = false;
            lbl_boneco3.Visible = false;
            lbl_boneco4.Visible = false;
            lbl_boneco5.Visible = false;
            lbl_boneco6.Visible = false;

        }

        private void btn_Palavra_Click_1(object sender, EventArgs e)
        {
            for (int i = 0; i < txt_Palavra.Text.Length; i++)
            {
                if ((txt_Palavra.Text[i].ToString() == " ") || (txt_Palavra.Text[i].ToString() == ","))
                {
                    txt_Palavra.Clear();
                    lbl_Letra.Visible = false;
                    txt_Letra.Visible = false;
                    btn_Letra.Visible = false;
                    lbl_ExibeErros.Visible = false;
                    lbl_ExibePalavra.Visible = false;
                    txt_Palavra.Visible = true;
                    lbl_Palavra.Visible = true;
                    btn_Palavra.Visible = true;

                    MessageBox.Show("Digite somente uma palavra!");

                    break;

                }

                else
                {
                    lbl_Letra.Visible = true;
                    txt_Letra.Visible = true;
                    txt_Palavra.Visible = false;
                    lbl_Palavra.Visible = false;
                    lbl_ExibePalavra.Visible = true;
                    lbl_ExibeErros.Visible = true;
                    btn_Palavra.Visible = false;
                    btn_Letra.Visible = true;

                    palavra = txt_Palavra.Text.ToString();
                }
            }


            palavra = "";
            for (int i = 0; i < txt_Palavra.Text.Length; i++)
            {
                palavra += "_";
                
            }

            lbl_ExibePalavra.Text = palavra;

        }

        private void btn_Letra_Click(object sender, EventArgs e)
        {
            
            

            for (int i = 0; i < txt_Letra.Text.Length; i++)
            {
                if ((txt_Letra.Text[i].ToString() == " ") || (txt_Letra.Text[i].ToString() == ",") || (txt_Letra.Text.Length >= 2))
                {
                    MessageBox.Show("Digite somente uma letra");
                    txt_Letra.Clear();
                    cosa = false;
                    break;
                }
                else
                {
                    cosa = true;
                    break;
                }
            }
            if (cosa)
            {
                palavra = lbl_ExibePalavra.Text;
                lbl_ExibePalavra.Text = "";


                for (int i = 0; i < palavra.Length; i++)
                {
                    if (palavra[i].ToString() == "_")
                    {
                        if (txt_Letra.Text[0].ToString() == txt_Palavra.Text[i].ToString())
                        {
                            lbl_ExibePalavra.Text += txt_Letra.Text.ToString();

                        }
                        else
                        {
                            errou++;
                            lbl_ExibePalavra.Text += "_";
                            
                         }
                       
                    }
                    else
                    {


                        if (palavra[i].ToString() != txt_Letra.Text.ToString())
                        {
                            errou++;
                            lbl_ExibePalavra.Text += palavra[i].ToString();
                        }
                        else
                        {

                        }

                        if (pos != 6)
                        {

                            pos++;
                        }
                        else
                        {
                            MessageBox.Show("Você Perdeu");
                            //PERDEu
                        }

                    }
                }
                
            }

            if (errou >= palavra.Length)
            {
                errou = 0;
                erros++;
                lbl_ExibeErros.Text += txt_Letra.Text;
            
               
               
            }
            txt_Letra.Clear();
            txt_Letra.Focus();
            if (erros == 1)
                lbl_boneco1.Visible = true;
            if (erros == 2)
                lbl_boneco2.Visible = true;
            if (erros == 3)
                lbl_boneco3.Visible = true;
            if (erros == 4)
                lbl_boneco4.Visible = true;
            if (erros == 5)
                lbl_boneco5.Visible = true;
            if (erros == 6)
                lbl_boneco6.Visible = true;
            
            
            
            errou = 0;
            
        }

    }
}

                        //                             ("_")
                        //                            d--|--b
                        //                               |
                        //                             _/ \_