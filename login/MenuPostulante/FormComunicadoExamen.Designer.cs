namespace login
{
    partial class FormComunicadoExamen
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
            this.SuspendLayout();
            // 
            // lblComunicado
            // 
            this.lblComunicado.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComunicado.ForeColor = System.Drawing.Color.DarkGray;
            this.lblComunicado.Location = new System.Drawing.Point(89, 233);
            this.lblComunicado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblComunicado.Name = "lblComunicado";
            this.lblComunicado.Size = new System.Drawing.Size(568, 90);
            this.lblComunicado.TabIndex = 1;
            this.lblComunicado.Text = "Ya ingresó su examen, visualize su nota en el apartado \"Ver Nota\"";
            this.lblComunicado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormComunicadoExamen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(747, 555);
            this.Controls.Add(this.lblComunicado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormComunicadoExamen";
            this.Text = "FormComunicadoExamen";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblComunicado;
    }
}