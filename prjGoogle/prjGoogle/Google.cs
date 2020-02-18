using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace prjGoogle
{
    public partial class Google : Form
    {
        public Google()
        {
            InitializeComponent();
        }

        private void txt1_PreviewKeyDown_1(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                lbl2.Visible = true;
            }
        }

        private void txt1_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (Control.ModifierKeys == Keys.Shift)
            {
                e.Handled = true;
                lbl1.Text = e.KeyChar.ToString();
                lbl2.Text = lbl2.Text + lbl1.Text;
            }

            else
            {
                e.Handled = false;
            }

        }

        private void Google_Load(object sender, EventArgs e)
        {

        }

    }
}
