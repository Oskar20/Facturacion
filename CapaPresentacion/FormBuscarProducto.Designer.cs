namespace CapaPresentacion
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
            this.dataGridViewBuscarProducto = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxBuscarProducto = new System.Windows.Forms.TextBox();
            this.labelProductoBuscar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBuscarProducto)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewBuscarProducto
            // 
            this.dataGridViewBuscarProducto.AllowUserToAddRows = false;
            this.dataGridViewBuscarProducto.AllowUserToDeleteRows = false;
            this.dataGridViewBuscarProducto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewBuscarProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBuscarProducto.Location = new System.Drawing.Point(7, 65);
            this.dataGridViewBuscarProducto.Name = "dataGridViewBuscarProducto";
            this.dataGridViewBuscarProducto.ReadOnly = true;
            this.dataGridViewBuscarProducto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewBuscarProducto.Size = new System.Drawing.Size(440, 195);
            this.dataGridViewBuscarProducto.TabIndex = 0;
            this.dataGridViewBuscarProducto.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewBuscarProducto_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.textBoxBuscarProducto);
            this.groupBox1.Controls.Add(this.labelProductoBuscar);
            this.groupBox1.Controls.Add(this.dataGridViewBuscarProducto);
            this.groupBox1.Location = new System.Drawing.Point(5, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(453, 260);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Producto";
            // 
            // textBoxBuscarProducto
            // 
            this.textBoxBuscarProducto.Location = new System.Drawing.Point(161, 26);
            this.textBoxBuscarProducto.Name = "textBoxBuscarProducto";
            this.textBoxBuscarProducto.Size = new System.Drawing.Size(201, 20);
            this.textBoxBuscarProducto.TabIndex = 2;
            this.textBoxBuscarProducto.TextChanged += new System.EventHandler(this.textBoxBuscarProducto_TextChanged);
            // 
            // labelProductoBuscar
            // 
            this.labelProductoBuscar.AutoSize = true;
            this.labelProductoBuscar.Location = new System.Drawing.Point(69, 29);
            this.labelProductoBuscar.Name = "labelProductoBuscar";
            this.labelProductoBuscar.Size = new System.Drawing.Size(86, 13);
            this.labelProductoBuscar.TabIndex = 1;
            this.labelProductoBuscar.Text = "Buscar Producto";
            // 
            // FormBuscarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 270);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormBuscarProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Busqueda Producto";
            this.Load += new System.EventHandler(this.FormBuscarProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBuscarProducto)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewBuscarProducto;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxBuscarProducto;
        private System.Windows.Forms.Label labelProductoBuscar;
    }
}