namespace prjPalíndromo
{
    partial class Palíndromo
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
            this.btn_Veri = new System.Windows.Forms.Button();
            this.txt_pergunta = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_Veri
            // 
            this.btn_Veri.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Veri.ForeColor = System.Drawing.Color.Black;
            this.btn_Veri.Location = new System.Drawing.Point(126, 270);
            this.btn_Veri.Name = "btn_Veri";
            this.btn_Veri.Size = new System.Drawing.Size(197, 68);
            this.btn_Veri.TabIndex = 0;
            this.btn_Veri.Text = "Verificar";
            this.btn_Veri.UseVisualStyleBackColor = true;
            this.btn_Veri.Click += new System.EventHandler(this.btn_Veri_Click);
            // 
            // txt_pergunta
            // 
            this.txt_pergunta.Font = new System.Drawing.Font("Comic Sans MS", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pergunta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txt_pergunta.Location = new System.Drawing.Point(89, 96);
            this.txt_pergunta.Name = "txt_pergunta";
            this.txt_pergunta.Size = new System.Drawing.Size(269, 56);
            this.txt_pergunta.TabIndex = 1;
            // 
            // Palíndromo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 397);
            this.Controls.Add(this.txt_pergunta);
            this.Controls.Add(this.btn_Veri);
            this.Name = "Palíndromo";
            this.Text = "Palíndromo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Veri;
        private System.Windows.Forms.TextBox txt_pergunta;
    }
}

