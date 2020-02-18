namespace PrjExemploKey
{
    partial class frmExemploKey
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_texto = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txt_texto
            // 
            this.txt_texto.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_texto.Location = new System.Drawing.Point(47, 63);
            this.txt_texto.Name = "txt_texto";
            this.txt_texto.Size = new System.Drawing.Size(163, 38);
            this.txt_texto.TabIndex = 0;
            this.txt_texto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_texto_KeyPress);
            this.txt_texto.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txt_texto_PreviewKeyDown);
            // 
            // frmExemploKey
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.txt_texto);
            this.Name = "frmExemploKey";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmExemploKey_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_texto;
    }
}

