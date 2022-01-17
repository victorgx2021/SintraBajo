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
            this.tabPDP = new System.Windows.Forms.TabPage();
            this.tabPRE = new System.Windows.Forms.TabPage();
            this.tabPNota = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPDP);
            this.tabControl1.Controls.Add(this.tabPRE);
            this.tabControl1.Controls.Add(this.tabPNota);
            this.tabControl1.Location = new System.Drawing.Point(1, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(550, 447);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPDP
            // 
            this.tabPDP.Location = new System.Drawing.Point(4, 22);
            this.tabPDP.Name = "tabPDP";
            this.tabPDP.Padding = new System.Windows.Forms.Padding(3);
            this.tabPDP.Size = new System.Drawing.Size(542, 421);
            this.tabPDP.TabIndex = 0;
            this.tabPDP.Text = "Datos Personales";
            this.tabPDP.UseVisualStyleBackColor = true;
            // 
            // tabPRE
            // 
            this.tabPRE.Location = new System.Drawing.Point(4, 22);
            this.tabPRE.Name = "tabPRE";
            this.tabPRE.Padding = new System.Windows.Forms.Padding(3);
            this.tabPRE.Size = new System.Drawing.Size(542, 421);
            this.tabPRE.TabIndex = 1;
            this.tabPRE.Text = "Rendir Examen";
            this.tabPRE.UseVisualStyleBackColor = true;
            // 
            // tabPNota
            // 
            this.tabPNota.Location = new System.Drawing.Point(4, 22);
            this.tabPNota.Name = "tabPNota";
            this.tabPNota.Padding = new System.Windows.Forms.Padding(3);
            this.tabPNota.Size = new System.Drawing.Size(542, 421);
            this.tabPNota.TabIndex = 2;
            this.tabPNota.Text = "Ver Nota";
            this.tabPNota.UseVisualStyleBackColor = true;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Home";
            this.Text = "Home";
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPDP;
        private System.Windows.Forms.TabPage tabPRE;
        private System.Windows.Forms.TabPage tabPNota;
    }
}