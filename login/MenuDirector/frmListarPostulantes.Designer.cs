namespace login
{
    partial class frmListarPostulantes
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnDNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnDNI,
            this.ColumnAP,
            this.ColumnAM,
            this.ColumnN});
            this.dataGridView1.Location = new System.Drawing.Point(12, 87);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(711, 359);
            this.dataGridView1.TabIndex = 0;
            // 
            // ColumnDNI
            // 
            this.ColumnDNI.HeaderText = "DNI";
            this.ColumnDNI.MinimumWidth = 6;
            this.ColumnDNI.Name = "ColumnDNI";
            this.ColumnDNI.Width = 125;
            // 
            // ColumnAP
            // 
            this.ColumnAP.HeaderText = "Apellido Paterno";
            this.ColumnAP.MinimumWidth = 6;
            this.ColumnAP.Name = "ColumnAP";
            this.ColumnAP.Width = 125;
            // 
            // ColumnAM
            // 
            this.ColumnAM.HeaderText = "Apellido Materno";
            this.ColumnAM.MinimumWidth = 6;
            this.ColumnAM.Name = "ColumnAM";
            this.ColumnAM.Width = 125;
            // 
            // ColumnN
            // 
            this.ColumnN.HeaderText = "Nombre(s)";
            this.ColumnN.MinimumWidth = 6;
            this.ColumnN.Name = "ColumnN";
            this.ColumnN.Width = 125;
            // 
            // frmListarPostulantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(748, 503);
            this.Controls.Add(this.dataGridView1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmListarPostulantes";
            this.Text = "frmListarPostulantes";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDNI;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAP;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAM;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnN;
    }
}