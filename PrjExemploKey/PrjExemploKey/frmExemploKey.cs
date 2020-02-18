using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PrjExemploKey
{
    public partial class frmExemploKey : Form
    {
        public frmExemploKey()
        {
            InitializeComponent();
        }


        private void txt_texto_KeyPress(object sender, KeyPressEventArgs e)
        {
            MessageBox.Show(e.KeyChar.ToString());

            e.Handled = true;
        }

        private void txt_texto_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
          //MessageBox.Show(e.KeyValue.ToString());
        }

        private void frmExemploKey_Load(object sender, EventArgs e)
        {

        }
    }
}
