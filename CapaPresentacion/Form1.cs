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
    public partial class Form1 : Form, IClientes, IProductos
    {
        int codcliente = 0;
        private NFactura encabezadoFactura;
        
        public Form1()
        {
            InitializeComponent();

           


            var listTextBox = new List<TextBox>();
            listTextBox.Add(textBoxNit);
            listTextBox.Add(textBoxNombre);
            listTextBox.Add(textBoxCodigoProducto);
            listTextBox.Add(textBoxNombreProducto);
            listTextBox.Add(textBoxPrecio);
            listTextBox.Add(textBoxCantidad);
            listTextBox.Add(textBoxSubTotal);
            listTextBox.Add(textBoxIva);
            listTextBox.Add(textBoxTotal);
            listTextBox.Add(textBoxNroFactura);

            var listButton = new List<Button>();
            listButton.Add(buttonBuscarCliente);
            listButton.Add(buttonBuscarProducto);
            listButton.Add(buttonAgregar);
            listButton.Add(buttonFinalizar);

            var listLabel = new List<Label>();
            listLabel.Add(labelMensaje);



            encabezadoFactura = new NFactura(listTextBox,dataGridViewFactura, listButton, listLabel,timerGeneraFact);
      
            textBoxNroFactura.Text = encabezadoFactura.NumeroFactura().ToString();

        }

        public void obtenerCliente(Cliente cli)
        {
            textBoxNit.Text = cli.Nit.ToString();
            textBoxNombre.Text = cli.Nombre;
            codcliente = cli.IdCliente;
        }

        public void obtenerProducto(Producto pro)
        {
            textBoxCodigoProducto.Text = pro.CodProd;
            textBoxNombreProducto.Text = pro.NomProducto;
            textBoxPrecio.Text = pro.PrecioProducto.ToString();
        }

        #region
        //El formulario hijo no tiene el mecanismo para hacer referencia hacia
        //el objeto que lo invocó, sin embargo cuando instanciamos el objeto hijo
        //le asignamos a la propiedad contractCliente el valor this, este le pasa la
        //referencia del objeto que lo está invocando o llamando.

        //La interfaz por su parte crea una especie de contrato entre ambos objetos,
        //lo cual le permite al objeto hijo invocar los métodos que contiene la interfaz,
        //pero desde la clase padre, ya que el objeto de tipo interfaz fue inicializado con 
        //la referencia de la clase padre.
        #endregion

        private void buttonBuscarCliente_Click(object sender, EventArgs e)
        {
            FormBuscarCliente frmC = new FormBuscarCliente();
            frmC.contractCliente = this; // paso de referencia
            frmC.ShowDialog();


        }

        private void buttonBuscarProducto_Click(object sender, EventArgs e)
        {
            FormBuscarProducto frmP = new FormBuscarProducto();
            frmP.contratoProducto = this;
            frmP.ShowDialog();
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            encabezadoFactura.InsertarFactura();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBoxTotal.Text = "0";
            textBoxSubTotal.Text = "0";
            textBoxIva.Text = "0";
        }

        private void buttonFinalizar_Click(object sender, EventArgs e)
        {
            encabezadoFactura.actulizarFactura();
        }
    }
}
