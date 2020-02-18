using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PrjSmashQuiz
{
    public partial class Quiz : Form
    {
        public Quiz()
        {
            InitializeComponent();
        }

        int pont = 0;
        int perg = 0;

        private void btn_Resp_Click_1(object sender, EventArgs e)
        {

            if (perg == 0)
            {
                if (!rdB1.Checked)
                    if (rdB2.Checked)
                        pont = pont + 1;
                    else
                        if (!rdB3.Checked)
                            if (rdB4.Checked)
                            {
                            }
            }

            else
            {

                if (perg == 1)
                {
                    if (!rdB1.Checked)
                        if (!rdB2.Checked)
                            if (!rdB3.Checked)
                                if (rdB4.Checked)
                                    pont = pont + 1;
                }

                else
                {
                    if (perg == 2)
                    {
                        if (!rdB1.Checked)
                            if (!rdB2.Checked)
                                if (rdB3.Checked)
                                 pont = pont + 1;
                                else
                                    if (rdB4.Checked)
                                    { 
                                    }
                    }

                    else
                    {
                        if (perg == 3)
                        {
                            if (rdB1.Checked)
                                pont = pont + 1;
                            else
                                if (!rdB2.Checked)
                                    if (!rdB3.Checked)
                                        if (rdB4.Checked)
                                        {
                                        }
                        }

                        else
                        {
                            if (perg == 4)
                            {
                                if (!rdB1.Checked)
                                    if (!rdB2.Checked)
                                        if (rdB3.Checked)
                                            pont = pont + 1;
                                        else
                                            if (rdB4.Checked)
                                            {
                                            }
                            }
                        }

                    }
                }
            }

            perg++;

            if (perg == 1)
            {
                lbl1.Text = "Qual o nome desse personagem?";
                rdB1.Text = "Corrin";
                rdB2.Text = "Bowser";
                rdB3.Text = "Zelda";
                rdB4.Text = "Roy";

                hehehe.Visible = false;
                royzão.Visible = true;
            }
            else
            {
                if (perg == 2)
                {
                    lbl1.Text = "Qual desses personagens é de dlc?";
                    rdB1.Text = "Olimar";
                    rdB2.Text = "Lucina";
                    rdB3.Text = "Lucas";
                    rdB4.Text = "Meta Knight";

                    royzão.Visible = false;
                    oliobar.Visible = true;
                    lutika.Visible = true;
                    lucas.Visible = true;
                    meta.Visible = true;
                }
                else
                {
                    if (perg == 3)
                    {
                        lbl1.Text = "Desses personagens, quem é o de tier mais alto?";
                        rdB1.Text = "Sheik";
                        rdB2.Text = "Mii Fighter";
                        rdB3.Text = "Diddy Kong";
                        rdB4.Text = "Cloud";

                        oliobar.Visible = false;
                        lutika.Visible = false;
                        lucas.Visible = false;
                        meta.Visible = false;
                        idk.Visible = true;
                    }

                    else
                    {
                        if (perg == 4)
                        {
                            lbl1.Text = "Quantos Falcon Punches esse personagem pode levar?";
                            rdB1.Text = "5";
                            rdB2.Text = "2";
                            rdB3.Text = "3";
                            rdB4.Text = "4";

                            idk.Visible = false;
                            jigglynightmare.Visible = true;

                        }
                        if (perg >= 5)
                        {
                            jigglynightmare.Visible = false;
                            lbl1.Text = "";
                            rdB1.Text = "";
                            rdB2.Text = "";
                            rdB3.Text = "";
                            rdB4.Text = "";
                            if (pont == 0)
                                MessageBox.Show("Você acertou " + pont.ToString() + " perguntas, você não sabe de nada, inocente","Pontuação",MessageBoxButtons.OK,MessageBoxIcon.Information);
                            else
                                if (pont == 1)
                                    MessageBox.Show("Você acertou " + pont.ToString() + " perguntas, você pode melhorar.", "Pontuação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                else
                                    if (pont == 2)
                                        MessageBox.Show("Você acertou " + pont.ToString() + " perguntas, você foi bem.", "Pontuação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    else
                                        if (pont == 3)
                                            MessageBox.Show("Você acertou " + pont.ToString() + " perguntas, você entende de Gaims.", "Pontuação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        else
                                            if (pont == 4)
                                                MessageBox.Show("Você acertou " + pont.ToString() + " perguntas, você é muito bom!", "Pontuação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            else
                                            MessageBox.Show("Você acertou " + pont.ToString() + " perguntas, você é praticamente o Gabriel!", "Pontuação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
        }

        private void Quiz_Load(object sender, EventArgs e)
        {

            lbl1.Text = "De que jogo esse personagem pertence?";
            rdB1.Text = "Street Fighter";
            rdB2.Text = "Super Mario Bros.";
            rdB3.Text = "Fire Emblem";
            rdB4.Text = "Legend of Zelda";

        }

    }
}
