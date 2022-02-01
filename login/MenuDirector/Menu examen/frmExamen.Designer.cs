namespace login
{
    partial class frmExamen
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
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.labelD = new System.Windows.Forms.Label();
            this.labelTipo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxDNI = new System.Windows.Forms.TextBox();
            this.dateTimePicker_Fecha = new System.Windows.Forms.DateTimePicker();
            this.buttonAñadir = new System.Windows.Forms.Button();
            this.comboBoxTipo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimeHORA = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(40, 48);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(637, 238);
            this.dataGridView1.TabIndex = 2;
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(68, 327);
            this.textBoxID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(132, 22);
            this.textBoxID.TabIndex = 3;
            // 
            // labelD
            // 
            this.labelD.AutoSize = true;
            this.labelD.Location = new System.Drawing.Point(36, 331);
            this.labelD.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelD.Name = "labelD";
            this.labelD.Size = new System.Drawing.Size(20, 16);
            this.labelD.TabIndex = 4;
            this.labelD.Text = "ID";
            // 
            // labelTipo
            // 
            this.labelTipo.AutoSize = true;
            this.labelTipo.Location = new System.Drawing.Point(23, 377);
            this.labelTipo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTipo.Name = "labelTipo";
            this.labelTipo.Size = new System.Drawing.Size(35, 16);
            this.labelTipo.TabIndex = 5;
            this.labelTipo.Text = "Tipo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(221, 331);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Fecha";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(221, 380);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Dni";
            // 
            // textBoxDNI
            // 
            this.textBoxDNI.Location = new System.Drawing.Point(272, 377);
            this.textBoxDNI.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxDNI.Name = "textBoxDNI";
            this.textBoxDNI.Size = new System.Drawing.Size(120, 22);
            this.textBoxDNI.TabIndex = 9;
            // 
            // dateTimePicker_Fecha
            // 
            this.dateTimePicker_Fecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_Fecha.Location = new System.Drawing.Point(279, 331);
            this.dateTimePicker_Fecha.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePicker_Fecha.Name = "dateTimePicker_Fecha";
            this.dateTimePicker_Fecha.Size = new System.Drawing.Size(113, 22);
            this.dateTimePicker_Fecha.TabIndex = 10;
            // 
            // buttonAñadir
            // 
            this.buttonAñadir.Location = new System.Drawing.Point(577, 330);
            this.buttonAñadir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonAñadir.Name = "buttonAñadir";
            this.buttonAñadir.Size = new System.Drawing.Size(100, 28);
            this.buttonAñadir.TabIndex = 12;
            this.buttonAñadir.Text = "Añadir";
            this.buttonAñadir.UseVisualStyleBackColor = true;
            this.buttonAñadir.Click += new System.EventHandler(this.buttonAñadir_Click);
            // 
            // comboBoxTipo
            // 
            this.comboBoxTipo.FormattingEnabled = true;
            this.comboBoxTipo.Items.AddRange(new object[] {
            "1) ORDINARIO",
            "2) PRIMERA OPCION",
            "3) DIRIMENCIA"});
            this.comboBoxTipo.Location = new System.Drawing.Point(68, 373);
            this.comboBoxTipo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxTipo.Name = "comboBoxTipo";
            this.comboBoxTipo.Size = new System.Drawing.Size(132, 24);
            this.comboBoxTipo.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(423, 300);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "Hora";
            // 
            // dateTimeHORA
            // 
            this.dateTimeHORA.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimeHORA.Location = new System.Drawing.Point(427, 334);
            this.dateTimeHORA.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimeHORA.Name = "dateTimeHORA";
            this.dateTimeHORA.Size = new System.Drawing.Size(103, 22);
            this.dateTimeHORA.TabIndex = 16;
            // 
            // frmExamen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 454);
            this.Controls.Add(this.dateTimeHORA);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxTipo);
            this.Controls.Add(this.buttonAñadir);
            this.Controls.Add(this.dateTimePicker_Fecha);
            this.Controls.Add(this.textBoxDNI);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelTipo);
            this.Controls.Add(this.labelD);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmExamen";
            this.Text = "frmExamen";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmExamen_FormClosing);
            this.Load += new System.EventHandler(this.frmExamen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label labelD;
        private System.Windows.Forms.Label labelTipo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxDNI;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Fecha;
        private System.Windows.Forms.Button buttonAñadir;
        private System.Windows.Forms.ComboBox comboBoxTipo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimeHORA;
    }
}