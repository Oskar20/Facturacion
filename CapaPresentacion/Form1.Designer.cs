namespace CapaPresentacion
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxCantidad = new System.Windows.Forms.TextBox();
            this.textBoxPrecio = new System.Windows.Forms.TextBox();
            this.labelPrecio = new System.Windows.Forms.Label();
            this.textBoxCodigoProducto = new System.Windows.Forms.TextBox();
            this.textBoxNombreProducto = new System.Windows.Forms.TextBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxNit = new System.Windows.Forms.TextBox();
            this.labelCantidad = new System.Windows.Forms.Label();
            this.labelNomProducto = new System.Windows.Forms.Label();
            this.labelProducto = new System.Windows.Forms.Label();
            this.labelCliente = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxTotal = new System.Windows.Forms.TextBox();
            this.textBoxIva = new System.Windows.Forms.TextBox();
            this.textBoxSubTotal = new System.Windows.Forms.TextBox();
            this.labelTotal = new System.Windows.Forms.Label();
            this.labelIva = new System.Windows.Forms.Label();
            this.labelSubTotal = new System.Windows.Forms.Label();
            this.dataGridViewFactura = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNroFactura = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonFinalizar = new System.Windows.Forms.Button();
            this.buttonAgregar = new System.Windows.Forms.Button();
            this.buttonBuscarProducto = new System.Windows.Forms.Button();
            this.buttonBuscarCliente = new System.Windows.Forms.Button();
            this.labelMensaje = new System.Windows.Forms.Label();
            this.timerGeneraFact = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFactura)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.labelMensaje);
            this.groupBox1.Controls.Add(this.textBoxNroFactura);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.buttonAgregar);
            this.groupBox1.Controls.Add(this.buttonBuscarProducto);
            this.groupBox1.Controls.Add(this.textBoxCantidad);
            this.groupBox1.Controls.Add(this.textBoxPrecio);
            this.groupBox1.Controls.Add(this.labelPrecio);
            this.groupBox1.Controls.Add(this.textBoxCodigoProducto);
            this.groupBox1.Controls.Add(this.textBoxNombreProducto);
            this.groupBox1.Controls.Add(this.buttonBuscarCliente);
            this.groupBox1.Controls.Add(this.textBoxNombre);
            this.groupBox1.Controls.Add(this.textBoxNit);
            this.groupBox1.Controls.Add(this.labelCantidad);
            this.groupBox1.Controls.Add(this.labelNomProducto);
            this.groupBox1.Controls.Add(this.labelProducto);
            this.groupBox1.Controls.Add(this.labelCliente);
            this.groupBox1.Location = new System.Drawing.Point(5, -1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(717, 167);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Encabezado";
            // 
            // textBoxCantidad
            // 
            this.textBoxCantidad.Location = new System.Drawing.Point(96, 104);
            this.textBoxCantidad.Name = "textBoxCantidad";
            this.textBoxCantidad.Size = new System.Drawing.Size(85, 20);
            this.textBoxCantidad.TabIndex = 11;
            // 
            // textBoxPrecio
            // 
            this.textBoxPrecio.Location = new System.Drawing.Point(403, 76);
            this.textBoxPrecio.Name = "textBoxPrecio";
            this.textBoxPrecio.Size = new System.Drawing.Size(70, 20);
            this.textBoxPrecio.TabIndex = 10;
            // 
            // labelPrecio
            // 
            this.labelPrecio.AutoSize = true;
            this.labelPrecio.Location = new System.Drawing.Point(360, 79);
            this.labelPrecio.Name = "labelPrecio";
            this.labelPrecio.Size = new System.Drawing.Size(37, 13);
            this.labelPrecio.TabIndex = 9;
            this.labelPrecio.Text = "Precio";
            // 
            // textBoxCodigoProducto
            // 
            this.textBoxCodigoProducto.Enabled = false;
            this.textBoxCodigoProducto.Location = new System.Drawing.Point(96, 48);
            this.textBoxCodigoProducto.Name = "textBoxCodigoProducto";
            this.textBoxCodigoProducto.Size = new System.Drawing.Size(100, 20);
            this.textBoxCodigoProducto.TabIndex = 8;
            // 
            // textBoxNombreProducto
            // 
            this.textBoxNombreProducto.Enabled = false;
            this.textBoxNombreProducto.Location = new System.Drawing.Point(96, 76);
            this.textBoxNombreProducto.Name = "textBoxNombreProducto";
            this.textBoxNombreProducto.Size = new System.Drawing.Size(253, 20);
            this.textBoxNombreProducto.TabIndex = 7;
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Enabled = false;
            this.textBoxNombre.Location = new System.Drawing.Point(198, 22);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(336, 20);
            this.textBoxNombre.TabIndex = 5;
            // 
            // textBoxNit
            // 
            this.textBoxNit.Enabled = false;
            this.textBoxNit.Location = new System.Drawing.Point(96, 22);
            this.textBoxNit.Name = "textBoxNit";
            this.textBoxNit.Size = new System.Drawing.Size(100, 20);
            this.textBoxNit.TabIndex = 4;
            // 
            // labelCantidad
            // 
            this.labelCantidad.AutoSize = true;
            this.labelCantidad.Location = new System.Drawing.Point(44, 106);
            this.labelCantidad.Name = "labelCantidad";
            this.labelCantidad.Size = new System.Drawing.Size(49, 13);
            this.labelCantidad.TabIndex = 3;
            this.labelCantidad.Text = "Cantidad";
            // 
            // labelNomProducto
            // 
            this.labelNomProducto.AutoSize = true;
            this.labelNomProducto.Location = new System.Drawing.Point(6, 76);
            this.labelNomProducto.Name = "labelNomProducto";
            this.labelNomProducto.Size = new System.Drawing.Size(90, 13);
            this.labelNomProducto.TabIndex = 2;
            this.labelNomProducto.Text = "Nombre Producto";
            // 
            // labelProducto
            // 
            this.labelProducto.AutoSize = true;
            this.labelProducto.Location = new System.Drawing.Point(43, 51);
            this.labelProducto.Name = "labelProducto";
            this.labelProducto.Size = new System.Drawing.Size(50, 13);
            this.labelProducto.TabIndex = 1;
            this.labelProducto.Text = "Producto";
            // 
            // labelCliente
            // 
            this.labelCliente.AutoSize = true;
            this.labelCliente.Location = new System.Drawing.Point(54, 26);
            this.labelCliente.Name = "labelCliente";
            this.labelCliente.Size = new System.Drawing.Size(39, 13);
            this.labelCliente.TabIndex = 0;
            this.labelCliente.Text = "Cliente";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.buttonFinalizar);
            this.groupBox2.Controls.Add(this.textBoxTotal);
            this.groupBox2.Controls.Add(this.textBoxIva);
            this.groupBox2.Controls.Add(this.textBoxSubTotal);
            this.groupBox2.Controls.Add(this.labelTotal);
            this.groupBox2.Controls.Add(this.labelIva);
            this.groupBox2.Controls.Add(this.labelSubTotal);
            this.groupBox2.Controls.Add(this.dataGridViewFactura);
            this.groupBox2.Location = new System.Drawing.Point(6, 164);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(716, 350);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detalle";
            // 
            // textBoxTotal
            // 
            this.textBoxTotal.Enabled = false;
            this.textBoxTotal.Location = new System.Drawing.Point(597, 272);
            this.textBoxTotal.Name = "textBoxTotal";
            this.textBoxTotal.Size = new System.Drawing.Size(100, 20);
            this.textBoxTotal.TabIndex = 6;
            // 
            // textBoxIva
            // 
            this.textBoxIva.Enabled = false;
            this.textBoxIva.Location = new System.Drawing.Point(597, 245);
            this.textBoxIva.Name = "textBoxIva";
            this.textBoxIva.Size = new System.Drawing.Size(100, 20);
            this.textBoxIva.TabIndex = 5;
            // 
            // textBoxSubTotal
            // 
            this.textBoxSubTotal.Enabled = false;
            this.textBoxSubTotal.Location = new System.Drawing.Point(597, 219);
            this.textBoxSubTotal.Name = "textBoxSubTotal";
            this.textBoxSubTotal.Size = new System.Drawing.Size(100, 20);
            this.textBoxSubTotal.TabIndex = 4;
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Location = new System.Drawing.Point(554, 276);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(31, 13);
            this.labelTotal.TabIndex = 3;
            this.labelTotal.Text = "Total";
            // 
            // labelIva
            // 
            this.labelIva.AutoSize = true;
            this.labelIva.Location = new System.Drawing.Point(563, 248);
            this.labelIva.Name = "labelIva";
            this.labelIva.Size = new System.Drawing.Size(22, 13);
            this.labelIva.TabIndex = 2;
            this.labelIva.Text = "Iva";
            // 
            // labelSubTotal
            // 
            this.labelSubTotal.AutoSize = true;
            this.labelSubTotal.Location = new System.Drawing.Point(535, 223);
            this.labelSubTotal.Name = "labelSubTotal";
            this.labelSubTotal.Size = new System.Drawing.Size(50, 13);
            this.labelSubTotal.TabIndex = 1;
            this.labelSubTotal.Text = "SubTotal";
            // 
            // dataGridViewFactura
            // 
            this.dataGridViewFactura.AllowUserToAddRows = false;
            this.dataGridViewFactura.AllowUserToDeleteRows = false;
            this.dataGridViewFactura.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridViewFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFactura.Location = new System.Drawing.Point(8, 29);
            this.dataGridViewFactura.Name = "dataGridViewFactura";
            this.dataGridViewFactura.ReadOnly = true;
            this.dataGridViewFactura.Size = new System.Drawing.Size(694, 176);
            this.dataGridViewFactura.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(585, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "N Factura";
            // 
            // textBoxNroFactura
            // 
            this.textBoxNroFactura.Location = new System.Drawing.Point(641, 23);
            this.textBoxNroFactura.Name = "textBoxNroFactura";
            this.textBoxNroFactura.ReadOnly = true;
            this.textBoxNroFactura.Size = new System.Drawing.Size(57, 20);
            this.textBoxNroFactura.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(501, 312);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Finalizar Factura";
            // 
            // buttonFinalizar
            // 
            this.buttonFinalizar.BackgroundImage = global::CapaPresentacion.Properties.Resources.Finish;
            this.buttonFinalizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonFinalizar.Location = new System.Drawing.Point(597, 298);
            this.buttonFinalizar.Name = "buttonFinalizar";
            this.buttonFinalizar.Size = new System.Drawing.Size(99, 41);
            this.buttonFinalizar.TabIndex = 7;
            this.buttonFinalizar.UseVisualStyleBackColor = true;
            this.buttonFinalizar.Click += new System.EventHandler(this.buttonFinalizar_Click);
            // 
            // buttonAgregar
            // 
            this.buttonAgregar.BackgroundImage = global::CapaPresentacion.Properties.Resources.add2;
            this.buttonAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonAgregar.Location = new System.Drawing.Point(567, 118);
            this.buttonAgregar.Name = "buttonAgregar";
            this.buttonAgregar.Size = new System.Drawing.Size(44, 41);
            this.buttonAgregar.TabIndex = 13;
            this.buttonAgregar.UseVisualStyleBackColor = true;
            this.buttonAgregar.Click += new System.EventHandler(this.buttonAgregar_Click);
            // 
            // buttonBuscarProducto
            // 
            this.buttonBuscarProducto.BackgroundImage = global::CapaPresentacion.Properties.Resources.find2;
            this.buttonBuscarProducto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonBuscarProducto.Location = new System.Drawing.Point(195, 48);
            this.buttonBuscarProducto.Name = "buttonBuscarProducto";
            this.buttonBuscarProducto.Size = new System.Drawing.Size(20, 21);
            this.buttonBuscarProducto.TabIndex = 12;
            this.buttonBuscarProducto.UseVisualStyleBackColor = true;
            this.buttonBuscarProducto.Click += new System.EventHandler(this.buttonBuscarProducto_Click);
            // 
            // buttonBuscarCliente
            // 
            this.buttonBuscarCliente.BackgroundImage = global::CapaPresentacion.Properties.Resources.find2;
            this.buttonBuscarCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonBuscarCliente.Location = new System.Drawing.Point(533, 21);
            this.buttonBuscarCliente.Name = "buttonBuscarCliente";
            this.buttonBuscarCliente.Size = new System.Drawing.Size(20, 22);
            this.buttonBuscarCliente.TabIndex = 6;
            this.buttonBuscarCliente.UseVisualStyleBackColor = true;
            this.buttonBuscarCliente.Click += new System.EventHandler(this.buttonBuscarCliente_Click);
            // 
            // labelMensaje
            // 
            this.labelMensaje.AutoSize = true;
            this.labelMensaje.Location = new System.Drawing.Point(93, 140);
            this.labelMensaje.Name = "labelMensaje";
            this.labelMensaje.Size = new System.Drawing.Size(0, 13);
            this.labelMensaje.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 515);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facturación";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFactura)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonBuscarProducto;
        private System.Windows.Forms.TextBox textBoxCantidad;
        private System.Windows.Forms.TextBox textBoxPrecio;
        private System.Windows.Forms.Label labelPrecio;
        private System.Windows.Forms.TextBox textBoxCodigoProducto;
        private System.Windows.Forms.TextBox textBoxNombreProducto;
        private System.Windows.Forms.Button buttonBuscarCliente;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxNit;
        private System.Windows.Forms.Label labelCantidad;
        private System.Windows.Forms.Label labelNomProducto;
        private System.Windows.Forms.Label labelProducto;
        private System.Windows.Forms.Label labelCliente;
        private System.Windows.Forms.TextBox textBoxTotal;
        private System.Windows.Forms.TextBox textBoxIva;
        private System.Windows.Forms.TextBox textBoxSubTotal;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label labelIva;
        private System.Windows.Forms.Label labelSubTotal;
        private System.Windows.Forms.DataGridView dataGridViewFactura;
        private System.Windows.Forms.Button buttonAgregar;
        private System.Windows.Forms.TextBox textBoxNroFactura;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonFinalizar;
        private System.Windows.Forms.Label labelMensaje;
        private System.Windows.Forms.Timer timerGeneraFact;
    }
}

