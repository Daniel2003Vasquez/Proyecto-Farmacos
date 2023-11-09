namespace ProyectoDroguería
{
    partial class FormBuscarProducto
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboCategoriaB = new System.Windows.Forms.ComboBox();
            this.txtSerialB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Serial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Foto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(23, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Serial";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(613, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Categoria";
            // 
            // comboCategoriaB
            // 
            this.comboCategoriaB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboCategoriaB.FormattingEnabled = true;
            this.comboCategoriaB.Items.AddRange(new object[] {
            "Analgésicos y antiinflamatorios",
            "Antibióticos",
            "Antivirales",
            "Antifúngicos",
            "Antiparasitarios",
            "Antieméticos",
            "Antipiréticos",
            "Anticoagulantes",
            "Antidiabéticos",
            "Anticonceptivos",
            "Antihipertensivos",
            "Broncodilatadores y corticosteroides inhalados",
            "Anticonvulsivos",
            "Ansiolíticos y antidepresivos",
            "Inmunosupresores",
            "Medicamentos hormonales",
            "Diuréticos",
            "Estimulantes",
            "Medicamentos gastrointestinales"});
            this.comboCategoriaB.Location = new System.Drawing.Point(617, 132);
            this.comboCategoriaB.Name = "comboCategoriaB";
            this.comboCategoriaB.Size = new System.Drawing.Size(309, 30);
            this.comboCategoriaB.TabIndex = 7;
            // 
            // txtSerialB
            // 
            this.txtSerialB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSerialB.Location = new System.Drawing.Point(27, 130);
            this.txtSerialB.Name = "txtSerialB";
            this.txtSerialB.Size = new System.Drawing.Size(123, 30);
            this.txtSerialB.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Forte", 40.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Teal;
            this.label6.Location = new System.Drawing.Point(186, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(502, 73);
            this.label6.TabIndex = 25;
            this.label6.Text = "Buscar Producto";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Serial,
            this.Categoria,
            this.Foto});
            this.dataGridView1.Location = new System.Drawing.Point(27, 192);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(899, 150);
            this.dataGridView1.TabIndex = 26;
            // 
            // Serial
            // 
            this.Serial.HeaderText = "Nombre";
            this.Serial.MinimumWidth = 6;
            this.Serial.Name = "Serial";
            this.Serial.Width = 125;
            // 
            // Categoria
            // 
            this.Categoria.HeaderText = "Gategoría";
            this.Categoria.MinimumWidth = 6;
            this.Categoria.Name = "Categoria";
            this.Categoria.Width = 125;
            // 
            // Foto
            // 
            this.Foto.HeaderText = "Foto";
            this.Foto.MinimumWidth = 6;
            this.Foto.Name = "Foto";
            this.Foto.Width = 125;
            // 
            // FormBuscarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 466);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboCategoriaB);
            this.Controls.Add(this.txtSerialB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "FormBuscarProducto";
            this.Text = "FormHola";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboCategoriaB;
        private System.Windows.Forms.TextBox txtSerialB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Serial;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Foto;
    }
}