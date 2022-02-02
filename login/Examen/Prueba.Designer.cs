namespace login.Examen
{
    partial class Prueba
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dgvExamenes = new System.Windows.Forms.DataGridView();
            this.dataSet1 = new login.DataSet1();
            this.dataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bdAdmisionDataSet = new login.bdAdmisionDataSet();
            this.pRUEBABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pRUEBATableAdapter = new login.bdAdmisionDataSetTableAdapters.PRUEBATableAdapter();
            this.opcion1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.idPruebaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dNIdigitadorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExamenes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdAdmisionDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRUEBABindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(163, 197);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Atras";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(386, 197);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "continuar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dgvExamenes
            // 
            this.dgvExamenes.AutoGenerateColumns = false;
            this.dgvExamenes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExamenes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.opcion1,
            this.idPruebaDataGridViewTextBoxColumn,
            this.tipoDataGridViewTextBoxColumn,
            this.fechaDataGridViewTextBoxColumn,
            this.horaDataGridViewTextBoxColumn,
            this.dNIdigitadorDataGridViewTextBoxColumn});
            this.dgvExamenes.DataSource = this.pRUEBABindingSource;
            this.dgvExamenes.Location = new System.Drawing.Point(12, 28);
            this.dgvExamenes.Name = "dgvExamenes";
            this.dgvExamenes.Size = new System.Drawing.Size(640, 127);
            this.dgvExamenes.TabIndex = 2;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSet1BindingSource
            // 
            this.dataSet1BindingSource.DataSource = this.dataSet1;
            this.dataSet1BindingSource.Position = 0;
            // 
            // bdAdmisionDataSet
            // 
            this.bdAdmisionDataSet.DataSetName = "bdAdmisionDataSet";
            this.bdAdmisionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pRUEBABindingSource
            // 
            this.pRUEBABindingSource.DataMember = "PRUEBA";
            this.pRUEBABindingSource.DataSource = this.bdAdmisionDataSet;
            // 
            // pRUEBATableAdapter
            // 
            this.pRUEBATableAdapter.ClearBeforeFill = true;
            // 
            // opcion1
            // 
            this.opcion1.HeaderText = "opcion";
            this.opcion1.Name = "opcion1";
            // 
            // idPruebaDataGridViewTextBoxColumn
            // 
            this.idPruebaDataGridViewTextBoxColumn.DataPropertyName = "IdPrueba";
            this.idPruebaDataGridViewTextBoxColumn.HeaderText = "IdPrueba";
            this.idPruebaDataGridViewTextBoxColumn.Name = "idPruebaDataGridViewTextBoxColumn";
            // 
            // tipoDataGridViewTextBoxColumn
            // 
            this.tipoDataGridViewTextBoxColumn.DataPropertyName = "Tipo";
            this.tipoDataGridViewTextBoxColumn.HeaderText = "Tipo";
            this.tipoDataGridViewTextBoxColumn.Name = "tipoDataGridViewTextBoxColumn";
            // 
            // fechaDataGridViewTextBoxColumn
            // 
            this.fechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha";
            this.fechaDataGridViewTextBoxColumn.HeaderText = "Fecha";
            this.fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            // 
            // horaDataGridViewTextBoxColumn
            // 
            this.horaDataGridViewTextBoxColumn.DataPropertyName = "Hora";
            this.horaDataGridViewTextBoxColumn.HeaderText = "Hora";
            this.horaDataGridViewTextBoxColumn.Name = "horaDataGridViewTextBoxColumn";
            // 
            // dNIdigitadorDataGridViewTextBoxColumn
            // 
            this.dNIdigitadorDataGridViewTextBoxColumn.DataPropertyName = "DNIdigitador";
            this.dNIdigitadorDataGridViewTextBoxColumn.HeaderText = "DNIdigitador";
            this.dNIdigitadorDataGridViewTextBoxColumn.Name = "dNIdigitadorDataGridViewTextBoxColumn";
            // 
            // Prueba
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 268);
            this.Controls.Add(this.dgvExamenes);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Prueba";
            this.Text = "Prueba";
            this.Load += new System.EventHandler(this.Prueba_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvExamenes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdAdmisionDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRUEBABindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dgvExamenes;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource dataSet1BindingSource;
        private bdAdmisionDataSet bdAdmisionDataSet;
        private System.Windows.Forms.BindingSource pRUEBABindingSource;
        private bdAdmisionDataSetTableAdapters.PRUEBATableAdapter pRUEBATableAdapter;
        private System.Windows.Forms.DataGridViewCheckBoxColumn opcion1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPruebaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dNIdigitadorDataGridViewTextBoxColumn;
    }
}