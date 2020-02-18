namespace prjProva
{
    partial class Form1
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
            this.lbl_Design = new System.Windows.Forms.Label();
            this.btn_Demonstrar = new System.Windows.Forms.Button();
            this.lbl_num = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_Design
            // 
            this.lbl_Design.AutoSize = true;
            this.lbl_Design.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Design.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Design.ForeColor = System.Drawing.Color.White;
            this.lbl_Design.Location = new System.Drawing.Point(247, 9);
            this.lbl_Design.Name = "lbl_Design";
            this.lbl_Design.Size = new System.Drawing.Size(203, 30);
            this.lbl_Design.TabIndex = 1;
            this.lbl_Design.Text = "Série de Fibonacci";
            // 
            // btn_Demonstrar
            // 
            this.btn_Demonstrar.BackColor = System.Drawing.Color.Transparent;
            this.btn_Demonstrar.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Demonstrar.ForeColor = System.Drawing.Color.Fuchsia;
            this.btn_Demonstrar.Location = new System.Drawing.Point(284, 49);
            this.btn_Demonstrar.Name = "btn_Demonstrar";
            this.btn_Demonstrar.Size = new System.Drawing.Size(133, 23);
            this.btn_Demonstrar.TabIndex = 2;
            this.btn_Demonstrar.Text = "Demonstrar Série";
            this.btn_Demonstrar.UseVisualStyleBackColor = false;
            this.btn_Demonstrar.Click += new System.EventHandler(this.btn_Demonstrar_Click);
            // 
            // lbl_num
            // 
            this.lbl_num.AutoSize = true;
            this.lbl_num.BackColor = System.Drawing.Color.Black;
            this.lbl_num.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_num.Location = new System.Drawing.Point(2, 161);
            this.lbl_num.Name = "lbl_num";
            this.lbl_num.Size = new System.Drawing.Size(43, 13);
            this.lbl_num.TabIndex = 3;
            this.lbl_num.Text = "lbl_num";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(678, 412);
            this.Controls.Add(this.lbl_num);
            this.Controls.Add(this.btn_Demonstrar);
            this.Controls.Add(this.lbl_Design);
            this.Name = "Form1";
            this.Text = "Série de Fibonacci";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Design;
        private System.Windows.Forms.Button btn_Demonstrar;
        private System.Windows.Forms.Label lbl_num;
    }
}

