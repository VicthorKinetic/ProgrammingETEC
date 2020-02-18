using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace prjJogoDaVelho
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int Jogador = 1;
        int [,] p;


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pic1.Enabled = false;

            if (Jogador == 1)
            {
                pic1.BackgroundImage = Properties.Resources.X;
                p[1, 1] = 1;
            }
            else
                if (Jogador == 2)
                {
                    pic1.BackgroundImage = Properties.Resources.O;
                    p[1, 1] = 2;
                }


            if (Jogador == 1)
                Jogador = 2;
            else
                if (Jogador == 2)
                    Jogador = 1;


            if ((p[0, 0] == 1 && p[0, 1] == 1 && p[0, 2] == 1) ||
               (p[1, 0] == 1 && p[1, 1] == 1 && p[1, 2] == 1) ||
               (p[2, 0] == 1 && p[2, 1] == 1 && p[2, 2] == 1) ||
               (p[0, 0] == 1 && p[1, 0] == 1 && p[2, 0] == 1) ||
               (p[0, 1] == 1 && p[1, 1] == 1 && p[2, 1] == 1) ||
               (p[2, 0] == 1 && p[2, 1] == 1 && p[2, 2] == 1) ||
               (p[0, 0] == 1 && p[1, 1] == 1 && p[2, 2] == 1) ||
               (p[2, 0] == 1 && p[1, 1] == 1 && p[0, 2] == 1))
            {
                if (Jogador == 1)
                {
                    MessageBox.Show("Jogador 2 Venceu!", "Vencedor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Jogador 1 Venceu!", "Vencedor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                if ((p[0, 0] == 2 && p[0, 1] == 2 && p[0, 2] == 2) ||
               (p[1, 0] == 2 && p[1, 1] == 2 && p[1, 2] == 2) ||
               (p[2, 0] == 2 && p[2, 1] == 2 && p[2, 2] == 2) ||
               (p[0, 0] == 2 && p[1, 0] == 2 && p[2, 0] == 2) ||
               (p[0, 1] == 2 && p[1, 1] == 2 && p[2, 1] == 2) ||
               (p[2, 0] == 2 && p[2, 1] == 2 && p[2, 2] == 2) ||
               (p[0, 0] == 2 && p[1, 1] == 2 && p[2, 2] == 2) ||
               (p[2, 0] == 2 && p[1, 1] == 2 && p[0, 2] == 2))
                {
                    lbl1.Visible = true;
                    if (Jogador == 1)
                    {
                        MessageBox.Show("Jogador 2 Venceu!", "Vencedor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Jogador 1 Venceu!", "Vencedor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    if ((pic1.Enabled == false) && (pic2.Enabled == false) && (pic3.Enabled == false)
                    && (pic4.Enabled == false) && (pic5.Enabled == false) && (pic6.Enabled == false)
                    && (pic7.Enabled == false) && (pic8.Enabled == false) && (pic9.Enabled == false))
                    {
                        MessageBox.Show("Deu Velha!", "Velha", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }
    
        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            pic1.BackColor = SystemColors.ActiveCaption;
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            pic8.Enabled = false;

            if (Jogador == 1)
            {
                pic8.BackgroundImage = Properties.Resources.X;
                p[0, 0] = 1;
            }
            else
                if (Jogador == 2)
                {
                    pic8.BackgroundImage = Properties.Resources.O;
                    p[0, 0] = 2;
                }

            if (Jogador == 1)
                Jogador = 2;
            else
                if (Jogador == 2)
                    Jogador = 1;


            if ((p[0, 0] == 1 && p[0, 1] == 1 && p[0, 2] == 1) ||
               (p[1, 0] == 1 && p[1, 1] == 1 && p[1, 2] == 1) ||
               (p[2, 0] == 1 && p[2, 1] == 1 && p[2, 2] == 1) ||
               (p[0, 0] == 1 && p[1, 0] == 1 && p[2, 0] == 1) ||
               (p[0, 1] == 1 && p[1, 1] == 1 && p[2, 1] == 1) ||
               (p[2, 0] == 1 && p[2, 1] == 1 && p[2, 2] == 1) ||
               (p[0, 0] == 1 && p[1, 1] == 1 && p[2, 2] == 1) ||
               (p[2, 0] == 1 && p[1, 1] == 1 && p[0, 2] == 1))
            {
                if (Jogador == 1)
                {
                    MessageBox.Show("Jogador 2 Venceu!", "Vencedor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Jogador 1 Venceu!", "Vencedor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            else
            {
                if ((p[0, 0] == 2 && p[0, 1] == 2 && p[0, 2] == 2) ||
               (p[1, 0] == 2 && p[1, 1] == 2 && p[1, 2] == 2) ||
               (p[2, 0] == 2 && p[2, 1] == 2 && p[2, 2] == 2) ||
               (p[0, 0] == 2 && p[1, 0] == 2 && p[2, 0] == 2) ||
               (p[0, 1] == 2 && p[1, 1] == 2 && p[2, 1] == 2) ||
               (p[2, 0] == 2 && p[2, 1] == 2 && p[2, 2] == 2) ||
               (p[0, 0] == 2 && p[1, 1] == 2 && p[2, 2] == 2) ||
               (p[2, 0] == 2 && p[1, 1] == 2 && p[0, 2] == 2))
                {
                    if (Jogador == 1)
                    {
                        MessageBox.Show("Jogador 2 Venceu!", "Vencedor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Jogador 1 Venceu!", "Vencedor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    if ((pic1.Enabled == false) && (pic2.Enabled == false) && (pic3.Enabled == false)
                    && (pic4.Enabled == false) && (pic5.Enabled == false) && (pic6.Enabled == false)
                    && (pic7.Enabled == false) && (pic8.Enabled == false) && (pic9.Enabled == false))
                    {
                        MessageBox.Show("Deu Velha!", "Velha", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
               
            }
        }

        private void pictureBox8_MouseHover(object sender, EventArgs e)
        {
            pic8.BackColor = SystemColors.ActiveCaption;
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            pic9.Enabled = false;

            if (Jogador == 1)
            {
                pic9.BackgroundImage = Properties.Resources.X;
                p[1, 0] = 1;
            }
            else
                if (Jogador == 2)
                {
                    pic9.BackgroundImage = Properties.Resources.O;
                    p[1, 0] = 2;
                }


            if (Jogador == 1)
                Jogador = 2;
            else
                if (Jogador == 2)
                    Jogador = 1;


            if ((p[0, 0] == 1 && p[0, 1] == 1 && p[0, 2] == 1) ||
               (p[1, 0] == 1 && p[1, 1] == 1 && p[1, 2] == 1) ||
               (p[2, 0] == 1 && p[2, 1] == 1 && p[2, 2] == 1) ||
               (p[0, 0] == 1 && p[1, 0] == 1 && p[2, 0] == 1) ||
               (p[0, 1] == 1 && p[1, 1] == 1 && p[2, 1] == 1) ||
               (p[2, 0] == 1 && p[2, 1] == 1 && p[2, 2] == 1) ||
               (p[0, 0] == 1 && p[1, 1] == 1 && p[2, 2] == 1) ||
               (p[2, 0] == 1 && p[1, 1] == 1 && p[0, 2] == 1))
            {
                if (Jogador == 1)
                {
                    MessageBox.Show("Jogador 2 Venceu!", "Vencedor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Jogador 1 Venceu!", "Vencedor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                if ((p[0, 0] == 2 && p[0, 1] == 2 && p[0, 2] == 2) ||
                (p[1, 0] == 2 && p[1, 1] == 2 && p[1, 2] == 2) ||
                (p[2, 0] == 2 && p[2, 1] == 2 && p[2, 2] == 2) ||
                (p[0, 0] == 2 && p[1, 0] == 2 && p[2, 0] == 2) ||
                (p[0, 1] == 2 && p[1, 1] == 2 && p[2, 1] == 2) ||
                (p[2, 0] == 2 && p[2, 1] == 2 && p[2, 2] == 2) ||
                (p[0, 0] == 2 && p[1, 1] == 2 && p[2, 2] == 2) ||
                (p[2, 0] == 2 && p[1, 1] == 2 && p[0, 2] == 2))
                {
                    if (Jogador == 1)
                    {
                        MessageBox.Show("Jogador 2 Venceu!", "Vencedor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Jogador 1 Venceu!", "Vencedor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    if ((pic1.Enabled == false) && (pic2.Enabled == false) && (pic3.Enabled == false)
                    && (pic4.Enabled == false) && (pic5.Enabled == false) && (pic6.Enabled == false)
                    && (pic7.Enabled == false) && (pic8.Enabled == false) && (pic9.Enabled == false))
                    {
                        MessageBox.Show("Deu Velha!", "Velha", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                
            }
        }

        private void pictureBox9_MouseHover(object sender, EventArgs e)
        {
            pic9.BackColor = SystemColors.ActiveCaption;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            pic7.Enabled = false;

            if (Jogador == 1)
            {
                pic7.BackgroundImage = Properties.Resources.X;
                p[2, 0] = 1;
            }
            else
                if (Jogador == 2)
                {
                    pic7.BackgroundImage = Properties.Resources.O;
                    p[2, 0] = 2;
                }


            if (Jogador == 1)
                Jogador = 2;
            else
                if (Jogador == 2)
                    Jogador = 1;


            if ((p[0, 0] == 1 && p[0, 1] == 1 && p[0, 2] == 1) ||
               (p[1, 0] == 1 && p[1, 1] == 1 && p[1, 2] == 1) ||
               (p[2, 0] == 1 && p[2, 1] == 1 && p[2, 2] == 1) ||
               (p[0, 0] == 1 && p[1, 0] == 1 && p[2, 0] == 1) ||
               (p[0, 1] == 1 && p[1, 1] == 1 && p[2, 1] == 1) ||
               (p[2, 0] == 1 && p[2, 1] == 1 && p[2, 2] == 1) ||
               (p[0, 0] == 1 && p[1, 1] == 1 && p[2, 2] == 1) ||
               (p[2, 0] == 1 && p[1, 1] == 1 && p[0, 2] == 1))
            {
                if (Jogador == 1)
                {
                    MessageBox.Show("Jogador 2 Venceu!", "Vencedor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Jogador 1 Venceu!", "Vencedor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                if ((p[0, 0] == 2 && p[0, 1] == 2 && p[0, 2] == 2) ||
                (p[1, 0] == 2 && p[1, 1] == 2 && p[1, 2] == 2) ||
                (p[2, 0] == 2 && p[2, 1] == 2 && p[2, 2] == 2) ||
                (p[0, 0] == 2 && p[1, 0] == 2 && p[2, 0] == 2) ||
                (p[0, 1] == 2 && p[1, 1] == 2 && p[2, 1] == 2) ||
                (p[2, 0] == 2 && p[2, 1] == 2 && p[2, 2] == 2) ||
                (p[0, 0] == 2 && p[1, 1] == 2 && p[2, 2] == 2) ||
                (p[2, 0] == 2 && p[1, 1] == 2 && p[0, 2] == 2))
                {
                    if (Jogador == 1)
                    {
                        MessageBox.Show("Jogador 2 Venceu!", "Vencedor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Jogador 1 Venceu!", "Vencedor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    if ((pic1.Enabled == false) && (pic2.Enabled == false) && (pic3.Enabled == false)
                    && (pic4.Enabled == false) && (pic5.Enabled == false) && (pic6.Enabled == false)
                    && (pic7.Enabled == false) && (pic8.Enabled == false) && (pic9.Enabled == false))
                    {
                        MessageBox.Show("Deu Velha!", "Velha", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
               
            }
        }

        private void pictureBox7_MouseHover(object sender, EventArgs e)
        {
            pic7.BackColor = SystemColors.ActiveCaption;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            pic4.Enabled = false;

            if (Jogador == 1)
            {
                pic4.BackgroundImage = Properties.Resources.X;
                p[2, 1] = 1;
            }
            else
                if (Jogador == 2)
                {
                    pic4.BackgroundImage = Properties.Resources.O;
                    p[2, 1] = 2;
                }


            if (Jogador == 1)
                Jogador = 2;
            else
                if (Jogador == 2)
                    Jogador = 1;


            if ((p[0, 0] == 1 && p[0, 1] == 1 && p[0, 2] == 1) ||
               (p[1, 0] == 1 && p[1, 1] == 1 && p[1, 2] == 1) ||
               (p[2, 0] == 1 && p[2, 1] == 1 && p[2, 2] == 1) ||
               (p[0, 0] == 1 && p[1, 0] == 1 && p[2, 0] == 1) ||
               (p[0, 1] == 1 && p[1, 1] == 1 && p[2, 1] == 1) ||
               (p[2, 0] == 1 && p[2, 1] == 1 && p[2, 2] == 1) ||
               (p[0, 0] == 1 && p[1, 1] == 1 && p[2, 2] == 1) ||
               (p[2, 0] == 1 && p[1, 1] == 1 && p[0, 2] == 1))
            {
                if (Jogador == 1)
                {
                    MessageBox.Show("Jogador 2 Venceu!", "Vencedor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Jogador 1 Venceu!", "Vencedor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                if ((p[0, 0] == 2 && p[0, 1] == 2 && p[0, 2] == 2) ||
                (p[1, 0] == 2 && p[1, 1] == 2 && p[1, 2] == 2) ||
                (p[2, 0] == 2 && p[2, 1] == 2 && p[2, 2] == 2) ||
                (p[0, 0] == 2 && p[1, 0] == 2 && p[2, 0] == 2) ||
                (p[0, 1] == 2 && p[1, 1] == 2 && p[2, 1] == 2) ||
                (p[2, 0] == 2 && p[2, 1] == 2 && p[2, 2] == 2) ||
                (p[0, 0] == 2 && p[1, 1] == 2 && p[2, 2] == 2) ||
                (p[2, 0] == 2 && p[1, 1] == 2 && p[0, 2] == 2))
                {
                    if (Jogador == 1)
                    {
                        MessageBox.Show("Jogador 2 Venceu!", "Vencedor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Jogador 1 Venceu!", "Vencedor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    if ((pic1.Enabled == false) && (pic2.Enabled == false) && (pic3.Enabled == false)
                    && (pic4.Enabled == false) && (pic5.Enabled == false) && (pic6.Enabled == false)
                    && (pic7.Enabled == false) && (pic8.Enabled == false) && (pic9.Enabled == false))
                    {
                        MessageBox.Show("Deu Velha!", "Velha", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

            }
        }

        private void pictureBox4_MouseHover(object sender, EventArgs e)
        {
            pic4.BackColor = SystemColors.ActiveCaption;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            pic5.Enabled = false;

            if (Jogador == 1)
            {
                pic5.BackgroundImage = Properties.Resources.X;
                p[0, 1] = 1;
            }
            else
                if (Jogador == 2)
                {
                    pic5.BackgroundImage = Properties.Resources.O;
                    p[0, 1] = 2;
                }


            if (Jogador == 1)
                Jogador = 2;
            else
                if (Jogador == 2)
                    Jogador = 1;


            if ((p[0, 0] == 1 && p[0, 1] == 1 && p[0, 2] == 1) ||
               (p[1, 0] == 1 && p[1, 1] == 1 && p[1, 2] == 1) ||
               (p[2, 0] == 1 && p[2, 1] == 1 && p[2, 2] == 1) ||
               (p[0, 0] == 1 && p[1, 0] == 1 && p[2, 0] == 1) ||
               (p[0, 1] == 1 && p[1, 1] == 1 && p[2, 1] == 1) ||
               (p[2, 0] == 1 && p[2, 1] == 1 && p[2, 2] == 1) ||
               (p[0, 0] == 1 && p[1, 1] == 1 && p[2, 2] == 1) ||
               (p[2, 0] == 1 && p[1, 1] == 1 && p[0, 2] == 1))
            {
                if (Jogador == 1)
                {
                    MessageBox.Show("Jogador 2 Venceu!", "Vencedor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Jogador 1 Venceu!", "Vencedor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                if ((p[0, 0] == 2 && p[0, 1] == 2 && p[0, 2] == 2) ||
                (p[1, 0] == 2 && p[1, 1] == 2 && p[1, 2] == 2) ||
                (p[2, 0] == 2 && p[2, 1] == 2 && p[2, 2] == 2) ||
                (p[0, 0] == 2 && p[1, 0] == 2 && p[2, 0] == 2) ||
                (p[0, 1] == 2 && p[1, 1] == 2 && p[2, 1] == 2) ||
                (p[2, 0] == 2 && p[2, 1] == 2 && p[2, 2] == 2) ||
                (p[0, 0] == 2 && p[1, 1] == 2 && p[2, 2] == 2) ||
                (p[2, 0] == 2 && p[1, 1] == 2 && p[0, 2] == 2))
                {
                    if (Jogador == 1)
                    {
                        MessageBox.Show("Jogador 2 Venceu!", "Vencedor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Jogador 1 Venceu!", "Vencedor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    if ((pic1.Enabled == false) && (pic2.Enabled == false) && (pic3.Enabled == false)
                    && (pic4.Enabled == false) && (pic5.Enabled == false) && (pic6.Enabled == false)
                    && (pic7.Enabled == false) && (pic8.Enabled == false) && (pic9.Enabled == false))
                    {
                        MessageBox.Show("Deu Velha!", "Velha", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void pictureBox5_MouseHover(object sender, EventArgs e)
        {
            pic5.BackColor = SystemColors.ActiveCaption;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pic2.Enabled = false;

            if (Jogador == 1)
            {
                pic2.BackgroundImage = Properties.Resources.X;
                p[0, 2] = 1;
            }
            else
                if (Jogador == 2)
                {
                    pic2.BackgroundImage = Properties.Resources.O;
                    p[0, 2] = 2;
                }


            if (Jogador == 1)
                Jogador = 2;
            else
                if (Jogador == 2)
                    Jogador = 1;


            if ((p[0, 0] == 1 && p[0, 1] == 1 && p[0, 2] == 1) ||
               (p[1, 0] == 1 && p[1, 1] == 1 && p[1, 2] == 1) ||
               (p[2, 0] == 1 && p[2, 1] == 1 && p[2, 2] == 1) ||
               (p[0, 0] == 1 && p[1, 0] == 1 && p[2, 0] == 1) ||
               (p[0, 1] == 1 && p[1, 1] == 1 && p[2, 1] == 1) ||
               (p[2, 0] == 1 && p[2, 1] == 1 && p[2, 2] == 1) ||
               (p[0, 0] == 1 && p[1, 1] == 1 && p[2, 2] == 1) ||
               (p[2, 0] == 1 && p[1, 1] == 1 && p[0, 2] == 1))
            {
                if (Jogador == 1)
                {
                    MessageBox.Show("Jogador 2 Venceu!", "Vencedor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Jogador 1 Venceu!", "Vencedor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                if ((p[0, 0] == 2 && p[0, 1] == 2 && p[0, 2] == 2) ||
                (p[1, 0] == 2 && p[1, 1] == 2 && p[1, 2] == 2) ||
                (p[2, 0] == 2 && p[2, 1] == 2 && p[2, 2] == 2) ||
                (p[0, 0] == 2 && p[1, 0] == 2 && p[2, 0] == 2) ||
                (p[0, 1] == 2 && p[1, 1] == 2 && p[2, 1] == 2) ||
                (p[2, 0] == 2 && p[2, 1] == 2 && p[2, 2] == 2) ||
                (p[0, 0] == 2 && p[1, 1] == 2 && p[2, 2] == 2) ||
                (p[2, 0] == 2 && p[1, 1] == 2 && p[0, 2] == 2))
                {
                    if (Jogador == 1)
                    {
                        MessageBox.Show("Jogador 2 Venceu!", "Vencedor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Jogador 1 Venceu!", "Vencedor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    if ((pic1.Enabled == false) && (pic2.Enabled == false) && (pic3.Enabled == false)
                    && (pic4.Enabled == false) && (pic5.Enabled == false) && (pic6.Enabled == false)
                    && (pic7.Enabled == false) && (pic8.Enabled == false) && (pic9.Enabled == false))
                    {
                        MessageBox.Show("Deu Velha!", "Velha", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                
            }
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            pic2.BackColor = SystemColors.ActiveCaption;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            pic3.Enabled = false;

            if (Jogador == 1)
            {
                pic3.BackgroundImage = Properties.Resources.X;
                p[1, 2] = 1;
            }
            else
                if (Jogador == 2)
                {
                    pic3.BackgroundImage = Properties.Resources.O;
                    p[1, 2] = 2;
                }


            if (Jogador == 1)
                Jogador = 2;
            else
                if (Jogador == 2)
                    Jogador = 1;


            if ((p[0, 0] == 1 && p[0, 1] == 1 && p[0, 2] == 1) ||
               (p[1, 0] == 1 && p[1, 1] == 1 && p[1, 2] == 1) ||
               (p[2, 0] == 1 && p[2, 1] == 1 && p[2, 2] == 1) ||
               (p[0, 0] == 1 && p[1, 0] == 1 && p[2, 0] == 1) ||
               (p[0, 1] == 1 && p[1, 1] == 1 && p[2, 1] == 1) ||
               (p[2, 0] == 1 && p[2, 1] == 1 && p[2, 2] == 1) ||
               (p[0, 0] == 1 && p[1, 1] == 1 && p[2, 2] == 1) ||
               (p[2, 0] == 1 && p[1, 1] == 1 && p[0, 2] == 1))
            {
                if (Jogador == 1)
                {
                    MessageBox.Show("Jogador 2 Venceu!", "Vencedor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Jogador 1 Venceu!", "Vencedor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                if ((p[0, 0] == 2 && p[0, 1] == 2 && p[0, 2] == 2) ||
                (p[1, 0] == 2 && p[1, 1] == 2 && p[1, 2] == 2) ||
                (p[2, 0] == 2 && p[2, 1] == 2 && p[2, 2] == 2) ||
                (p[0, 0] == 2 && p[1, 0] == 2 && p[2, 0] == 2) ||
                (p[0, 1] == 2 && p[1, 1] == 2 && p[2, 1] == 2) ||
                (p[2, 0] == 2 && p[2, 1] == 2 && p[2, 2] == 2) ||
                (p[0, 0] == 2 && p[1, 1] == 2 && p[2, 2] == 2) ||
                (p[2, 0] == 2 && p[1, 1] == 2 && p[0, 2] == 2))
                {
                    if (Jogador == 1)
                    {
                        MessageBox.Show("Jogador 2 Venceu!", "Vencedor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Jogador 1 Venceu!", "Vencedor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    if ((pic1.Enabled == false) && (pic2.Enabled == false) && (pic3.Enabled == false)
                    && (pic4.Enabled == false) && (pic5.Enabled == false) && (pic6.Enabled == false)
                    && (pic7.Enabled == false) && (pic8.Enabled == false) && (pic9.Enabled == false))
                    {
                        MessageBox.Show("Deu Velha!", "Velha", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
            pic3.BackColor = SystemColors.ActiveCaption;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            pic6.Enabled = false;

            if (Jogador == 1)
            {
                pic6.BackgroundImage = Properties.Resources.X;
                p[2, 2] = 1;
            }
            else
                if (Jogador == 2)
                {
                    pic6.BackgroundImage = Properties.Resources.O;
                    p[2, 2] = 2;
                }


            if (Jogador == 1)
                Jogador = 2;
            else
                if (Jogador == 2)
                    Jogador = 1;


            if ((p[0, 0] == 1 && p[0, 1] == 1 && p[0, 2] == 1) ||
               (p[1, 0] == 1 && p[1, 1] == 1 && p[1, 2] == 1) ||
               (p[2, 0] == 1 && p[2, 1] == 1 && p[2, 2] == 1) ||
               (p[0, 0] == 1 && p[1, 0] == 1 && p[2, 0] == 1) ||
               (p[0, 1] == 1 && p[1, 1] == 1 && p[2, 1] == 1) ||
               (p[2, 0] == 1 && p[2, 1] == 1 && p[2, 2] == 1) ||
               (p[0, 0] == 1 && p[1, 1] == 1 && p[2, 2] == 1) ||
               (p[2, 0] == 1 && p[1, 1] == 1 && p[0, 2] == 1))
            {
                if (Jogador == 1)
                {
                    MessageBox.Show("Jogador 2 Venceu!", "Vencedor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Jogador 1 Venceu!", "Vencedor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                if ((p[0, 0] == 2 && p[0, 1] == 2 && p[0, 2] == 2) ||
                 (p[1, 0] == 2 && p[1, 1] == 2 && p[1, 2] == 2) ||
                 (p[2, 0] == 2 && p[2, 1] == 2 && p[2, 2] == 2) ||
                 (p[0, 0] == 2 && p[1, 0] == 2 && p[2, 0] == 2) ||
                 (p[0, 1] == 2 && p[1, 1] == 2 && p[2, 1] == 2) ||
                 (p[2, 0] == 2 && p[2, 1] == 2 && p[2, 2] == 2) ||
                 (p[0, 0] == 2 && p[1, 1] == 2 && p[2, 2] == 2) ||
                 (p[2, 0] == 2 && p[1, 1] == 2 && p[0, 2] == 2))
                {
                    if (Jogador == 1)
                    {
                        MessageBox.Show("Jogador 2 Venceu!", "Vencedor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Jogador 1 Venceu!", "Vencedor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    if ((pic1.Enabled == false) && (pic2.Enabled == false) && (pic3.Enabled == false)
                    && (pic4.Enabled == false) && (pic5.Enabled == false) && (pic6.Enabled == false)
                    && (pic7.Enabled == false) && (pic8.Enabled == false) && (pic9.Enabled == false))
                    {
                        MessageBox.Show("Deu Velha!", "Velha", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void pictureBox6_MouseHover(object sender, EventArgs e)
        {
            pic6.BackColor = SystemColors.ActiveCaption;
        }

        private void pic8_MouseLeave(object sender, EventArgs e)
        {
            pic8.BackColor = Color.Transparent;
        }

        private void pic9_MouseLeave(object sender, EventArgs e)
        {
            pic9.BackColor = Color.Transparent;
        }

        private void pic7_MouseLeave(object sender, EventArgs e)
        {
            pic7.BackColor = Color.Transparent;
        }

        private void pic5_MouseLeave(object sender, EventArgs e)
        {
            pic5.BackColor = Color.Transparent;
        }

        private void pic1_MouseLeave(object sender, EventArgs e)
        {
            pic1.BackColor = Color.Transparent;
        }

        private void pic4_MouseLeave(object sender, EventArgs e)
        {
            pic4.BackColor = Color.Transparent;
        }

        private void pic2_MouseLeave(object sender, EventArgs e)
        {
            pic2.BackColor = Color.Transparent;
        }

        private void pic3_MouseLeave(object sender, EventArgs e)
        {
            pic3.BackColor = Color.Transparent;
        }

        private void pic6_MouseLeave(object sender, EventArgs e)
        {
            pic6.BackColor = Color.Transparent;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            p = new int[3, 3];
        }
    }
}
