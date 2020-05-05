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
    public partial class FormBuscarCliente : Form
    {
        private NClientes cliente;
        public IClientes contractCliente { get; set; } //agregamos propiedad tipo icliente para poder invocar el metodo de la interface




        public FormBuscarCliente()
        {
            InitializeComponent();
                        
            cliente = new NClientes(dataGridViewCliente);
            cliente.cargarDatos();

        }

        private void FormBuscarCliente_Load(object sender, EventArgs e)
        {
           
        }

        private void textBoxBuscarCliente_TextChanged(object sender, EventArgs e)
        {
            cliente.cargarDatosByNombreOrNit(textBoxBuscarCliente.Text);
        }

        private void dataGridViewCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var grid = (DataGridView)sender;
            var rowToEdit = grid.Rows[e.RowIndex];

            var dclient = new Cliente(
                (int)rowToEdit.Cells[0].Value,
                (int)rowToEdit.Cells[1].Value,
                (string)rowToEdit.Cells[2].Value,
                 rowToEdit.Cells[3].Value.ToString(),
                 (int)rowToEdit.Cells[4].Value);
      
            contractCliente.obtenerCliente(dclient);
            this.Close();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
