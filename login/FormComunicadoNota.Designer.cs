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
            this.lblComunicado.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComunicado.ForeColor = System.Drawing.Color.LightGray;
            this.lblComunicado.Location = new System.Drawing.Point(58, 155);
            this.lblComunicado.Name = "lblComunicado";
            this.lblComunicado.Size = new System.Drawing.Size(443, 73);
            this.lblComunicado.TabIndex = 2;
            this.lblComunicado.Text = "Su calificación no está disponible, vuelva más tarde.";
            // 
            // lblnota
            // 
            this.lblnota.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnota.ForeColor = System.Drawing.Color.LightGray;
            this.lblnota.Location = new System.Drawing.Point(208, 237);
            this.lblnota.Name = "lblnota";
            this.lblnota.Size = new System.Drawing.Size(138, 85);
            this.lblnota.TabIndex = 3;
            this.lblnota.Text = "00";
            // 
            // FormComunicadoNota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(560, 451);
            this.Controls.Add(this.lblnota);
            this.Controls.Add(this.lblComunicado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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