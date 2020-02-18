namespace PrjExeProcFunc
{
    partial class frmExemplo
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
            this.btnFunction = new System.Windows.Forms.Button();
            this.btnProcedure = new System.Windows.Forms.Button();
            this.btnString = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFunction
            // 
            this.btnFunction.Location = new System.Drawing.Point(26, 25);
            this.btnFunction.Name = "btnFunction";
            this.btnFunction.Size = new System.Drawing.Size(75, 23);
            this.btnFunction.TabIndex = 0;
            this.btnFunction.Text = "Função";
            this.btnFunction.UseVisualStyleBackColor = true;
            this.btnFunction.Click += new System.EventHandler(this.btnFunction_Click);
            // 
            // btnProcedure
            // 
            this.btnProcedure.Location = new System.Drawing.Point(122, 25);
            this.btnProcedure.Name = "btnProcedure";
            this.btnProcedure.Size = new System.Drawing.Size(106, 23);
            this.btnProcedure.TabIndex = 1;
            this.btnProcedure.Text = "Procedimento";
            this.btnProcedure.UseVisualStyleBackColor = true;
            this.btnProcedure.Click += new System.EventHandler(this.btnProcedure_Click);
            // 
            // btnString
            // 
            this.btnString.Location = new System.Drawing.Point(26, 84);
            this.btnString.Name = "btnString";
            this.btnString.Size = new System.Drawing.Size(75, 23);
            this.btnString.TabIndex = 2;
            this.btnString.Text = "String";
            this.btnString.UseVisualStyleBackColor = true;
            this.btnString.Click += new System.EventHandler(this.btnString_Click);
            // 
            // frmExemplo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 261);
            this.Controls.Add(this.btnString);
            this.Controls.Add(this.btnProcedure);
            this.Controls.Add(this.btnFunction);
            this.Name = "frmExemplo";
            this.Text = "Exemplo Procedure e Function";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFunction;
        private System.Windows.Forms.Button btnProcedure;
        private System.Windows.Forms.Button btnString;
    }
}

