using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace prjJogoDaMemória
{
    public partial class JogoMemória : Form
    {
        public JogoMemória()
        {
            InitializeComponent();
        }

        int[,] pos;
        bool[] acertos;
        int jogadas;

        private void JogoMemória_Load(object sender, EventArgs e)
        {
            jogadas = 0;
            pos = new int[4, 4];
            acertos = new bool[8];

            pos[0, 0] = 1;
            pos[1, 0] = 2;
            pos[2, 0] = 3;
            pos[3, 0] = 4;
            pos[0, 1] = 5;
            pos[1, 1] = 6;
            pos[2, 1] = 7;
            pos[3, 1] = 8;
            pos[0, 2] = 9;
            pos[1, 2] = 10;
            pos[2, 2] = 11;
            pos[3, 2] = 12;
            pos[0, 3] = 13;
            pos[1, 3] = 14;
            pos[2, 3] = 15;
            pos[3, 3] = 16;

            img00.Image = Properties.Resources.Card_Back;
            img01.Image = Properties.Resources.Card_Back;
            img02.Image = Properties.Resources.Card_Back;
            img03.Image = Properties.Resources.Card_Back;
            img10.Image = Properties.Resources.Card_Back;
            img11.Image = Properties.Resources.Card_Back;
            img12.Image = Properties.Resources.Card_Back;
            img13.Image = Properties.Resources.Card_Back;
            img20.Image = Properties.Resources.Card_Back;
            img21.Image = Properties.Resources.Card_Back;
            img22.Image = Properties.Resources.Card_Back;
            img23.Image = Properties.Resources.Card_Back;
            img30.Image = Properties.Resources.Card_Back;
            img31.Image = Properties.Resources.Card_Back;
            img32.Image = Properties.Resources.Card_Back;
            img33.Image = Properties.Resources.Card_Back;


            img00.Enabled = true;
            img01.Enabled = true;
            img02.Enabled = true;
            img03.Enabled = true;
            img10.Enabled = true;
            img11.Enabled = true;
            img12.Enabled = true;
            img13.Enabled = true;
            img20.Enabled = true;
            img21.Enabled = true;
            img22.Enabled = true;
            img23.Enabled = true;
            img30.Enabled = true;
            img31.Enabled = true;
            img32.Enabled = true;
            img33.Enabled = true;
        }

        private void Resetar()
        {
            jogadas = 0;
            if (acertos[0] == true)
            {
                pos[1, 0] = 2;
                pos[2, 0] = 3;
                pos[3, 0] = 4;
                pos[0, 1] = 5;
                pos[1, 1] = 6;
                pos[2, 1] = 7;
                pos[3, 1] = 8;
                pos[0, 2] = 9;
                pos[2, 2] = 11;
                pos[3, 2] = 12;
                pos[0, 3] = 13;
                pos[1, 3] = 14;
                pos[2, 3] = 15;
                pos[3, 3] = 16;

                img01.Enabled = true;
                img02.Enabled = true;
                img03.Enabled = true;
                img10.Enabled = true;
                img11.Enabled = true;
                img13.Enabled = true;
                img20.Enabled = true;
                img21.Enabled = true;
                img22.Enabled = true;
                img23.Enabled = true;
                img30.Enabled = true;
                img31.Enabled = true;
                img32.Enabled = true;
                img33.Enabled = true;
            }
            if (acertos[1] == true)
            {
                pos[0, 0] = 1;
                pos[2, 0] = 3;
                pos[3, 0] = 4;
                pos[0, 1] = 5;
                pos[1, 1] = 6;
                pos[2, 1] = 7;
                pos[3, 1] = 8;
                pos[0, 2] = 9;
                pos[1, 2] = 10;
                pos[2, 2] = 11;
                pos[3, 2] = 12;
                pos[1, 3] = 14;
                pos[2, 3] = 15;
                pos[3, 3] = 16;

                img00.Enabled = true;
                img01.Enabled = true;
                img02.Enabled = true;
                img11.Enabled = true;
                img12.Enabled = true;
                img13.Enabled = true;
                img20.Enabled = true;
                img21.Enabled = true;
                img22.Enabled = true;
                img23.Enabled = true;
                img30.Enabled = true;
                img31.Enabled = true;
                img32.Enabled = true;
                img33.Enabled = true;
            }
                if (acertos[2] == true)
                {
                    pos[0, 0] = 1;
                    pos[1, 0] = 2;
                    pos[3, 0] = 4;
                    pos[1, 1] = 6;
                    pos[2, 1] = 7;
                    pos[3, 1] = 8;
                    pos[0, 2] = 9;
                    pos[1, 2] = 10;
                    pos[2, 2] = 11;
                    pos[3, 2] = 12;
                    pos[0, 3] = 13;
                    pos[1, 3] = 14;
                    pos[2, 3] = 15;
                    pos[3, 3] = 16;

                    img00.Enabled = true;
                    img02.Enabled = true;
                    img03.Enabled = true;
                    img10.Enabled = true;
                    img11.Enabled = true;
                    img12.Enabled = true;
                    img13.Enabled = true;
                    img21.Enabled = true;
                    img22.Enabled = true;
                    img23.Enabled = true;
                    img30.Enabled = true;
                    img31.Enabled = true;
                    img32.Enabled = true;
                    img33.Enabled = true;
                }
                if (acertos[3] == true)
                    {
                        pos[0, 0] = 1;
                        pos[1, 0] = 2;
                        pos[2, 0] = 3;
                        pos[0, 1] = 5;
                        pos[1, 1] = 6;
                        pos[2, 1] = 7;
                        pos[3, 1] = 8;
                        pos[0, 2] = 9;
                        pos[1, 2] = 10;
                        pos[3, 2] = 12;
                        pos[0, 3] = 13;
                        pos[1, 3] = 14;
                        pos[2, 3] = 15;
                        pos[3, 3] = 16;

                        img00.Enabled = true;
                        img01.Enabled = true;
                        img02.Enabled = true;
                        img03.Enabled = true;
                        img10.Enabled = true;
                        img11.Enabled = true;
                        img12.Enabled = true;
                        img13.Enabled = true;
                        img20.Enabled = true;
                        img21.Enabled = true;
                        img23.Enabled = true;
                        img31.Enabled = true;
                        img32.Enabled = true;
                        img33.Enabled = true;
                    }
                if (acertos[4] == true)
                        {
                            pos[0, 0] = 1;
                            pos[1, 0] = 2;
                            pos[2, 0] = 3;
                            pos[3, 0] = 4;
                            pos[0, 1] = 5;
                            pos[2, 1] = 7;
                            pos[3, 1] = 8;
                            pos[0, 2] = 9;
                            pos[1, 2] = 10;
                            pos[2, 2] = 11;
                            pos[3, 2] = 12;
                            pos[0, 3] = 13;
                            pos[1, 3] = 14;
                            pos[3, 3] = 16;

                            img00.Enabled = true;
                            img01.Enabled = true;
                            img02.Enabled = true;
                            img03.Enabled = true;
                            img10.Enabled = true;
                            img12.Enabled = true;
                            img13.Enabled = true;
                            img20.Enabled = true;
                            img21.Enabled = true;
                            img22.Enabled = true;
                            img30.Enabled = true;
                            img31.Enabled = true;
                            img32.Enabled = true;
                            img33.Enabled = true;
                        }
                            if (acertos[5] == true)
                            {
                                pos[0, 0] = 1;
                                pos[1, 0] = 2;
                                pos[2, 0] = 3;
                                pos[3, 0] = 4;
                                pos[0, 1] = 5;
                                pos[1, 1] = 6;
                                pos[0, 2] = 9;
                                pos[1, 2] = 10;
                                pos[2, 2] = 11;
                                pos[3, 2] = 12;
                                pos[0, 3] = 13;
                                pos[1, 3] = 14;
                                pos[2, 3] = 15;
                                pos[3, 3] = 16;

                                img00.Enabled = true;
                                img01.Enabled = true;
                                img02.Enabled = true;
                                img03.Enabled = true;
                                img10.Enabled = true;
                                img11.Enabled = true;
                                img12.Enabled = true;
                                img13.Enabled = true;
                                img20.Enabled = true;
                                img22.Enabled = true;
                                img23.Enabled = true;
                                img30.Enabled = true;
                                img32.Enabled = true;
                                img33.Enabled = true;
                            }
                                if (acertos[6] == true)
                                {
                                    pos[0, 0] = 1;
                                    pos[1, 0] = 2;
                                    pos[2, 0] = 3;
                                    pos[3, 0] = 4;
                                    pos[0, 1] = 5;
                                    pos[1, 1] = 6;
                                    pos[2, 1] = 7;
                                    pos[3, 1] = 8;
                                    pos[1, 2] = 10;
                                    pos[2, 2] = 11;
                                    pos[3, 2] = 12;
                                    pos[0, 3] = 13;
                                    pos[1, 3] = 14;
                                    pos[2, 3] = 15;

                                    img00.Enabled = true;
                                    img01.Enabled = true;
                                    img03.Enabled = true;
                                    img10.Enabled = true;
                                    img11.Enabled = true;
                                    img12.Enabled = true;
                                    img13.Enabled = true;
                                    img20.Enabled = true;
                                    img21.Enabled = true;
                                    img22.Enabled = true;
                                    img23.Enabled = true;
                                    img30.Enabled = true;
                                    img31.Enabled = true;
                                    img32.Enabled = true;
                                }
                                    if (acertos[7] == true)
                                    {
                                        pos[0, 0] = 1;
                                        pos[1, 0] = 2;
                                        pos[2, 0] = 3;
                                        pos[3, 0] = 4;
                                        pos[0, 1] = 5;
                                        pos[1, 1] = 6;
                                        pos[2, 1] = 7;
                                        pos[3, 1] = 8;
                                        pos[0, 2] = 9;
                                        pos[1, 2] = 10;
                                        pos[2, 2] = 11;
                                        pos[0, 3] = 13;
                                        pos[2, 3] = 15;
                                        pos[3, 3] = 16;

                                        img00.Enabled = true;
                                        img01.Enabled = true;
                                        img02.Enabled = true;
                                        img03.Enabled = true;
                                        img10.Enabled = true;
                                        img11.Enabled = true;
                                        img12.Enabled = true;
                                        img20.Enabled = true;
                                        img21.Enabled = true;
                                        img22.Enabled = true;
                                        img23.Enabled = true;
                                        img30.Enabled = true;
                                        img31.Enabled = true;
                                        img33.Enabled = true;
                                    }
        }

        private void img00_Click(object sender, EventArgs e)
        {
             if (jogadas != 2)
            {
                
                jogadas++;
                img00.Enabled = false;
                img00.Image = Properties.Resources.Pakumen;
                pos[0, 0] = 17;

                if (pos[0, 0] == pos[1, 2])
                {
                    img00.Enabled = false;
                    img12.Enabled = false;
                    acertos[0] = true;
                }
            }
            else
                {
                    Resetar();
                    img00.Image = Properties.Resources.Card_Back;
                    img12.Image = Properties.Resources.Card_Back;
                }
            }

        private void img10_Click(object sender, EventArgs e)
        {
            if (jogadas != 2)
            {
                jogadas++;
                img10.Enabled = false;
                img10.Image = Properties.Resources.Hazama;
                pos[1, 0] = 18;

                if (pos[1, 0] == pos[0, 3])
                {
                    img10.Enabled = false;
                    img03.Enabled = false;
                    acertos[1] = true;
                }
            }
                else
                {
                        Resetar();
                        img10.Image = Properties.Resources.Card_Back;
                        img03.Image = Properties.Resources.Card_Back;
                    }
                }

        private void img20_Click(object sender, EventArgs e)
        {
            if (jogadas != 2)
            {
                jogadas++;
                img20.Enabled = false;
                img20.Image = Properties.Resources.Jin;
                pos[2, 0] = 19;
                if (pos[2, 0] == pos[0, 1])
                {
                    img20.Enabled = false;
                    img01.Enabled = false;
                    acertos[2] = true;
                }
            }
                else
                {
                        Resetar();
                        img20.Image = Properties.Resources.Card_Back;
                        img01.Image = Properties.Resources.Card_Back;
                    }
                }

        private void img30_Click(object sender, EventArgs e)
        {
            if (jogadas != 2)
            {
                jogadas++;
                img30.Enabled = false;
                img30.Image = Properties.Resources.Rachael;
                pos[3, 0] = 20;

                if (pos[3, 0] == pos[2, 2])
                {
                    img30.Enabled = false;
                    img22.Enabled = false;
                    acertos[3] = true;
                }
}
                else
                {
                        Resetar();
                        img30.Image = Properties.Resources.Card_Back;
                        img22.Image = Properties.Resources.Card_Back;
                    }
                }

        private void img01_Click(object sender, EventArgs e)
        {
            if (jogadas != 2)
            {
                jogadas++;
                img01.Enabled = false;
                img01.Image = Properties.Resources.Jin;
                pos[0, 1] = 19;
                if (pos[2, 0] == pos[0, 1])
                {
                    img20.Enabled = false;
                    img01.Enabled = false;
                    acertos[2] = true;
                }
            }
                else
                {
                        Resetar();
                        img20.Image = Properties.Resources.Card_Back;
                        img01.Image = Properties.Resources.Card_Back;
                    }
                }

        private void img11_Click(object sender, EventArgs e)
        {
            if (jogadas != 2)
            {
                jogadas++;
                img11.Enabled = false;
                img11.Image = Properties.Resources.Ragna;
                pos[1, 1] = 21;
                if (pos[1, 1] == pos[2, 3])
                {
                    img11.Enabled = false;
                    img23.Enabled = false;
                    acertos[4] = true;
                }
            }
            else
            {
                Resetar();
                img11.Image = Properties.Resources.Card_Back;
                img23.Image = Properties.Resources.Card_Back;
            }
                }

        private void img21_Click(object sender, EventArgs e)
        {
            if (jogadas != 2)
            {
                jogadas++;
                img21.Enabled = false;
                img21.Image = Properties.Resources.Taokaka;
                pos[2, 1] = 22;
                if (pos[2, 1] == pos[3, 1])
                {
                    img21.Enabled = false;
                    img31.Enabled = false;
                    acertos[5] = true;
                }
            }
            else
            {
                Resetar();
                img21.Image = Properties.Resources.Card_Back;
                img31.Image = Properties.Resources.Card_Back;
            }
                }

        private void img31_Click(object sender, EventArgs e)
        {
            if (jogadas != 2)
            {
                jogadas++;
                img31.Enabled = false;
                img31.Image = Properties.Resources.Taokaka;
                pos[3, 1] = 22;
                if (pos[2, 1] == pos[3, 1])
                {
                    img21.Enabled = false;
                    img31.Enabled = false;
                    acertos[5] = true;
                }
            }
            else
            {
                Resetar();
                img21.Image = Properties.Resources.Card_Back;
                img31.Image = Properties.Resources.Card_Back;
            }
                }

        private void img12_Click(object sender, EventArgs e)
        {
            if (jogadas != 2)
            {
                jogadas++;
                img12.Enabled = false;
                img12.Image = Properties.Resources.Pakumen;
                pos[1, 2] = 17;
                if (pos[0, 0] == pos[1, 2])
                {
                    img00.Enabled = false;
                    img12.Enabled = false;
                    acertos[0] = true;
                }
            }
            else
            {
                Resetar();
                img00.Image = Properties.Resources.Card_Back;
                img12.Image = Properties.Resources.Card_Back;
            }
                }

        private void img02_Click(object sender, EventArgs e)
        {
            if (jogadas != 2)
            {
                jogadas++;
                img02.Enabled = false;
                img02.Image = Properties.Resources.Terumi;
                pos[0, 2] = 23;
                if (pos[0, 2] == pos[3, 3])
                {
                    img02.Enabled = false;
                    img33.Enabled = false;
                    acertos[6] = true;
                }
            }
            else
            {
                Resetar();
                img02.Image = Properties.Resources.Card_Back;
                img33.Image = Properties.Resources.Card_Back;
            }
            }

        private void img22_Click(object sender, EventArgs e)
        {
            if (jogadas != 2)
            {
                jogadas++;
                img22.Enabled = false;
                img22.Image = Properties.Resources.Rachael;
                pos[2, 2] = 22;

                if (pos[3, 0] == pos[2, 2])
                {
                    img30.Enabled = false;
                    img22.Enabled = false;
                    acertos[3] = true;
                }
            }
            else
            {
                Resetar();
                img30.Image = Properties.Resources.Card_Back;
                img22.Image = Properties.Resources.Card_Back;
            }
                }

        private void img32_Click(object sender, EventArgs e)
        {
            if (jogadas != 2)
            {
                jogadas++;
                img32.Enabled = false;
                img32.Image = Properties.Resources.Hakumen;
                pos[3, 2] = 24;
                if (pos[3, 2] == pos[1, 3])
                {
                    img32.Enabled = false;
                    img13.Enabled = false;
                    acertos[7] = true;
                }
            }
            else
            {
                Resetar();
                img32.Image = Properties.Resources.Card_Back;
                img13.Image = Properties.Resources.Card_Back;
            }
                }

        private void img03_Click(object sender, EventArgs e)
        {
            if (jogadas != 2)
            {
                jogadas++;
                img03.Enabled = false;
                img03.Image = Properties.Resources.Hazama;
                pos[0, 3] = 18;
                if (pos[1, 0] == pos[0, 3])
                {
                    img10.Enabled = false;
                    img03.Enabled = false;
                    acertos[1] = true;
                }
            }
            else
            {
                Resetar();
                img10.Image = Properties.Resources.Card_Back;
                img03.Image = Properties.Resources.Card_Back;
            }
                }

        private void img13_Click(object sender, EventArgs e)
        {
            if (jogadas != 2)
            {
                jogadas++;
                img13.Enabled = false;
                img13.Image = Properties.Resources.Hakumen;
                pos[1, 3] = 24;
                if (pos[3, 2] == pos[1, 3])
                {
                    img32.Enabled = false;
                    img13.Enabled = false;
                    acertos[7] = true;
                }
            }
            else
            {
                Resetar();
                img32.Image = Properties.Resources.Card_Back;
                img13.Image = Properties.Resources.Card_Back;
            }
                }

        private void img23_Click(object sender, EventArgs e)
        {
            if (jogadas != 2)
            {
                jogadas++;
                img23.Enabled = false;
                img23.Image = Properties.Resources.Ragna;
                pos[2, 3] = 21;
                if (pos[1, 1] == pos[2, 3])
                {
                    img11.Enabled = false;
                    img23.Enabled = false;
                    acertos[4] = true;
                }
            }
            else
            {
                Resetar();
                img11.Image = Properties.Resources.Card_Back;
                img23.Image = Properties.Resources.Card_Back;
            }
                }

        private void img33_Click(object sender, EventArgs e)
        {
            if (jogadas != 2)
            {
                jogadas++;
                img33.Enabled = false;
                img33.Image = Properties.Resources.Terumi;
                pos[3, 3] = 23;
                if (pos[0, 2] == pos[3, 3])
                {
                    img02.Enabled = false;
                    img33.Enabled = false;
                    acertos[6] = true;
                }
            }
            else
            {
                Resetar();
                img02.Image = Properties.Resources.Card_Back;
                img33.Image = Properties.Resources.Card_Back;
            }
            }
    }
}
