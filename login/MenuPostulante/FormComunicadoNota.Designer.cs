namespace login
{
    partial class FormComunicadoNota
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
            this.lblComunicado = new System.Windows.Forms.Label();
            this.lblnota = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblComunicado
            // 
            this.lblComunicado.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComunicado.ForeColor = System.Drawing.Color.Silver;
            this.lblComunicado.Location = new System.Drawing.Point(76, 185);
            this.lblComunicado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblComunicado.Name = "lblComunicado";
            this.lblComunicado.Size = new System.Drawing.Size(591, 90);
            this.lblComunicado.TabIndex = 2;
            this.lblComunicado.Text = "Su calificación no está disponible, vuelva más tarde.";
            this.lblComunicado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblnota
            // 
            this.lblnota.Font = new System.Drawing.Font("Century Gothic", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnota.ForeColor = System.Drawing.Color.Silver;
            this.lblnota.Location = new System.Drawing.Point(265, 285);
            this.lblnota.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblnota.Name = "lblnota";
            this.lblnota.Size = new System.Drawing.Size(208, 131);
            this.lblnota.TabIndex = 3;
            this.lblnota.Text = "00";
            this.lblnota.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormComunicadoNota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(747, 555);
            this.Controls.Add(this.lblnota);
            this.Controls.Add(this.lblComunicado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormComunicadoNota";
            this.Text = "FormComunicadoNota";
            this.Load += new System.EventHandler(this.FormComunicadoNota_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblComunicado;
        private System.Windows.Forms.Label lblnota;
    }
}