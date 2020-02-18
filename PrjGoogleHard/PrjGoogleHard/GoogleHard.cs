using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PrjGoogleHard
{
    public partial class GoogleHard : Form
    {
        public GoogleHard()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txt1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                lbl2.Visible = true;
            }
        }

        private void txt1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "/")
            {
                lbl3.Text = "/";
                e.Handled = true;
            }

                if (lbl3.Text == "/" && e.KeyChar.ToString() != "/")
                {
                    e.Handled = true;
                    lbl1.Text = e.KeyChar.ToString();
                    lbl2.Text = lbl2.Text + lbl1.Text;
                }

            if (e.KeyChar.ToString() == ".")
            {
                lbl3.Text = " ";
                txt1.Clear();
            }

        }

        private void txt1_TextChanged(object sender, EventArgs e)
        {

        }           
    }
}
