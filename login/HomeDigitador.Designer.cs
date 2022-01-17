namespace login
{
    partial class Home
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPListPostulantes = new System.Windows.Forms.TabPage();
            this.tabPRegisterNulled = new System.Windows.Forms.TabPage();
            this.tabPUploadTest = new System.Windows.Forms.TabPage();
            this.buttonUploadTest = new System.Windows.Forms.Button();
            this.tabPNotas = new System.Windows.Forms.TabPage();
            this.buttonPublicar = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPUploadTest.SuspendLayout();
            this.tabPNotas.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPListPostulantes);
            this.tabControl1.Controls.Add(this.tabPRegisterNulled);
            this.tabControl1.Controls.Add(this.tabPUploadTest);
            this.tabControl1.Controls.Add(this.tabPNotas);
            this.tabControl1.Location = new System.Drawing.Point(2, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(797, 445);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPListPostulantes
            // 
            this.tabPListPostulantes.Location = new System.Drawing.Point(4, 22);
            this.tabPListPostulantes.Name = "tabPListPostulantes";
            this.tabPListPostulantes.Padding = new System.Windows.Forms.Padding(3);
            this.tabPListPostulantes.Size = new System.Drawing.Size(789, 419);
            this.tabPListPostulantes.TabIndex = 0;
            this.tabPListPostulantes.Text = "Lista de postulantes";
            this.tabPListPostulantes.UseVisualStyleBackColor = true;
            // 
            // tabPRegisterNulled
            // 
            this.tabPRegisterNulled.Location = new System.Drawing.Point(4, 22);
            this.tabPRegisterNulled.Name = "tabPRegisterNulled";
            this.tabPRegisterNulled.Padding = new System.Windows.Forms.Padding(3);
            this.tabPRegisterNulled.Size = new System.Drawing.Size(789, 419);
            this.tabPRegisterNulled.TabIndex = 1;
            this.tabPRegisterNulled.Text = "Anulación de registros";
            this.tabPRegisterNulled.UseVisualStyleBackColor = true;
            // 
            // tabPUploadTest
            // 
            this.tabPUploadTest.Controls.Add(this.buttonUploadTest);
            this.tabPUploadTest.Location = new System.Drawing.Point(4, 22);
            this.tabPUploadTest.Name = "tabPUploadTest";
            this.tabPUploadTest.Padding = new System.Windows.Forms.Padding(3);
            this.tabPUploadTest.Size = new System.Drawing.Size(789, 419);
            this.tabPUploadTest.TabIndex = 2;
            this.tabPUploadTest.Text = "Examen";
            this.tabPUploadTest.UseVisualStyleBackColor = true;
            // 
            // buttonUploadTest
            // 
            this.buttonUploadTest.Location = new System.Drawing.Point(707, 6);
            this.buttonUploadTest.Name = "buttonUploadTest";
            this.buttonUploadTest.Size = new System.Drawing.Size(75, 23);
            this.buttonUploadTest.TabIndex = 0;
            this.buttonUploadTest.Text = "Subir Examen";
            this.buttonUploadTest.UseVisualStyleBackColor = true;
            // 
            // tabPNotas
            // 
            this.tabPNotas.Controls.Add(this.buttonPublicar);
            this.tabPNotas.Location = new System.Drawing.Point(4, 22);
            this.tabPNotas.Name = "tabPNotas";
            this.tabPNotas.Padding = new System.Windows.Forms.Padding(3);
            this.tabPNotas.Size = new System.Drawing.Size(789, 419);
            this.tabPNotas.TabIndex = 3;
            this.tabPNotas.Text = "Notas";
            this.tabPNotas.UseVisualStyleBackColor = true;
            // 
            // buttonPublicar
            // 
            this.buttonPublicar.Location = new System.Drawing.Point(694, 390);
            this.buttonPublicar.Name = "buttonPublicar";
            this.buttonPublicar.Size = new System.Drawing.Size(88, 23);
            this.buttonPublicar.TabIndex = 0;
            this.buttonPublicar.Text = "Publicar Notas";
            this.buttonPublicar.UseVisualStyleBackColor = true;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Home";
            this.Text = "HomeDigitador";
            this.tabControl1.ResumeLayout(false);
            this.tabPUploadTest.ResumeLayout(false);
            this.tabPNotas.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPListPostulantes;
        private System.Windows.Forms.TabPage tabPRegisterNulled;
        private System.Windows.Forms.TabPage tabPUploadTest;
        private System.Windows.Forms.Button buttonUploadTest;
        private System.Windows.Forms.TabPage tabPNotas;
        private System.Windows.Forms.Button buttonPublicar;
    }
}