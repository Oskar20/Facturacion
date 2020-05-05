using CapaDatos;
using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaNegocio
{
    public class NFactura
    {
        private List<TextBox> listTextBox;
        private DataGridView _dataGridView;
        private List<Button> _listbuttons;
        private List<Label> _listLabel;
        private Timer _timer;

        public NFactura(List<TextBox> listTextBox, DataGridView _dataGridView,List<Button> _listbuttons,List<Label> _listLabel, Timer _timer)
        {
            this.listTextBox = listTextBox;
            this._dataGridView = _dataGridView;
            this._listbuttons = _listbuttons;
            this._listLabel = _listLabel;
            this._timer = _timer;
        }

        public void GuardarFactura(Factura fact)
        {

            var datosFactura = new Dfactura();
            datosFactura.PostInsertFactura(fact);

        }

        public void saveEncabezado()
        {
            var objFact = new Factura
            {
                NumFactura = int.Parse(listTextBox[9].Text),
                PrefijoFactura = "FE",
                SubTotal = double.Parse(listTextBox[6].Text),
                Iva = double.Parse(listTextBox[7].Text),
                Total = double.Parse(listTextBox[8].Text),
                IdCliente = int.Parse(listTextBox[0].Text)
            };

            GuardarFactura(objFact);

        }

        public void saveDetalle()
        {
            var objDetFactura = new DetalleFactura
            {
                Precio = double.Parse(listTextBox[4].Text),
                Cantidad = int.Parse(listTextBox[5].Text),
                Total = double.Parse(listTextBox[4].Text) * int.Parse(listTextBox[5].Text),
                Facturas = new Factura
                {
                    NumFactura = int.Parse(listTextBox[9].Text),
                    PrefijoFactura = "FE",
                    SubTotal = double.Parse(listTextBox[6].Text),
                    Iva = double.Parse(listTextBox[7].Text),
                    Total = double.Parse(listTextBox[8].Text),
                    IdCliente = int.Parse(listTextBox[0].Text)
                },
                Productos = new Producto
                   (
                      listTextBox[2].Text,
                       listTextBox[3].Text,
                       double.Parse(listTextBox[4].Text)
                   )
            };

            GuardarDetalleFactura(objDetFactura, _dataGridView.RowCount + 1);
        }

        public void GuardarDetalleFactura(DetalleFactura DetFact, int cons)
        {

            var datosDetFactura = new DdetalleFactura();
            datosDetFactura.InsertDetFactura(DetFact, cons);

        }


        public void InsertarFactura()
        {

            if ((listTextBox[0].Text == "") || (listTextBox[2].Text == "") || (listTextBox[4].Text == "") || (listTextBox[5].Text == ""))
            {
                _listLabel[0].Text = "Porfavor llenar todos los campos";
                _listLabel[0].ForeColor = Color.Red;
            }
            else if((listTextBox[4].Text == "0") || (listTextBox[5].Text == "0"))
            {
                _listLabel[0].Text = "Favor verificar que el valor en cantidad y precio no sea Cero(0)";
                _listLabel[0].ForeColor = Color.Red;
            }
            else
            {
                _listLabel[0].Text = "";

                if (_dataGridView.RowCount > 0)
                {


                    saveDetalle();
                    ObtenerDetalle(int.Parse(listTextBox[9].Text), "FE");
                    SumarTotales();
                    bloquearBotones();
                }
                else
                {
                    saveEncabezado();
                    saveDetalle();
                    ObtenerDetalle(int.Parse(listTextBox[9].Text), "FE");
                    SumarTotales();
                    bloquearBotones();
                }

            }

            
        }

        public void ObtenerDetalle(int NroFactura, string PrefijoFactura)
        {
            var detaF = new DdetalleFactura();
            var listDetF = detaF.ObtenerDetelle(NroFactura, PrefijoFactura);

            //_dataGridView.DataSource = listDetF.ToList();

            DataTable dt = new DataTable();
            dt.Columns.Add("PrefijoFactura", typeof(string));
            dt.Columns.Add("NumFactura", typeof(int));
            dt.Columns.Add("Consecutivo", typeof(int));
            dt.Columns.Add("CodigoProducto", typeof(string));
            dt.Columns.Add("NombreProducto", typeof(string));
            dt.Columns.Add("Cantidad", typeof(int));
            dt.Columns.Add("Precio", typeof(double));
            dt.Columns.Add("Total", typeof(double));

            for (int i = 0; i < listDetF.Count; i++)
            {
                dt.Rows.Add(listDetF[i].Facturas.PrefijoFactura, listDetF[i].Facturas.NumFactura, listDetF[i].Consecutivo, listDetF[i].Productos.CodProd,
                    listDetF[i].Productos.NomProducto, listDetF[i].Cantidad, listDetF[i].Precio, listDetF[i].Total);
            }
            _dataGridView.DataSource = dt;



        }

        public int NumeroFactura()
        {
            var Dfact = new Dfactura();
            var numero = Dfact.NumeroFactura("FE");

            return numero;
        }

        public void SumarTotales()
        {
            double subTotal = 0, iva=0, total=0;

            foreach (DataGridViewRow fila in _dataGridView.Rows)
            {
                subTotal += Convert.ToInt32(fila.Cells[7].Value);
            }

            iva = subTotal * 0.19;
            total = subTotal + iva;

            listTextBox[6].Text = subTotal.ToString();
            listTextBox[7].Text = iva.ToString();
            listTextBox[8].Text = total.ToString();



        }

        public void ActualizarEncabezadoFactura(Factura fact)
        {
            try
            {
                var actFact = new Dfactura();
                actFact.PutUpdateFactura(fact);
                MessageBox.Show("Factura generada correctamente");
            }
            catch (Exception ex)
            {

              
            }
          
        }

        public void actulizarFactura()
        {
            var cFact = new Factura
            {
                NumFactura = int.Parse(listTextBox[9].Text),
                PrefijoFactura = "FE",
                SubTotal = double.Parse(listTextBox[6].Text),
                Iva = double.Parse(listTextBox[7].Text),
                Total = double.Parse(listTextBox[8].Text),
                IdCliente = int.Parse(listTextBox[0].Text)

            };

            ActualizarEncabezadoFactura(cFact);
            LimpiarBotones();
            NumeroFactura();



        }

        public void bloquearBotones()
        {
            _listbuttons[0].Enabled = false;
            listTextBox[2].Text = "";
            listTextBox[3].Text = "";
            listTextBox[4].Text = "";
            listTextBox[5].Text = "";

        }

        public void LimpiarBotones()
        {
            _listbuttons[0].Enabled = true;
            listTextBox[0].Text = "";
            listTextBox[1].Text = "";
            listTextBox[2].Text = "";
            listTextBox[3].Text = "";
            listTextBox[4].Text = "";
            listTextBox[5].Text = "";
            listTextBox[6].Text = "0";
            listTextBox[7].Text = "0";
            listTextBox[8].Text = "0";
            _dataGridView.DataSource = "";
        }


       








    }
}
