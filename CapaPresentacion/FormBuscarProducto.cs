
using CapaEntidades;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FormBuscarProducto : Form
    {

        private NProductos nproducto;
        public IProductos contratoProducto { get; set; }

        public FormBuscarProducto()
        {
            InitializeComponent();

            nproducto = new NProductos(dataGridViewBuscarProducto);
            nproducto.cargarProductos();
    }

        private void FormBuscarProducto_Load(object sender, EventArgs e)
        {

        }

        private void textBoxBuscarProducto_TextChanged(object sender, EventArgs e)
        {
            nproducto.cargarProductoByIdNombre(textBoxBuscarProducto.Text);
        }

        private void dataGridViewBuscarProducto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            var datosPro = dataGridViewBuscarProducto.Rows[e.RowIndex].Cells[0].Value;
            var grid = (DataGridView)sender;
            var rowProd = grid.Rows[e.RowIndex];

            var newProd = new Producto((string)rowProd.Cells[0].Value,(string)rowProd.Cells[1].Value,(double)rowProd.Cells[2].Value);

            contratoProducto.obtenerProducto(newProd);
            this.Close();

        }
    }
}
