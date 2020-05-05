using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaNegocio
{

    public class NClientes
    {
        private DataGridView _dataGridView;
        //private List<TextBox> _listTextBox;


        public NClientes(DataGridView _dataGridView)
        {
            this._dataGridView = _dataGridView;
            //this._listTextBox = _listTextBox;
        }

        public void cargarDatos()
        {
            var cargaDatosCliente = new Dclientes();
            var ListClient = cargaDatosCliente.GetClientes();

            _dataGridView.DataSource = ListClient.ToList();

        }

        public void cargarDatosByNombreOrNit(string NombreNit)
        {
            var cargaDatosCliente = new Dclientes();
          

            if (NombreNit == "")
            {
                cargarDatos();
            }
            else
            {
                var listClienteBuscar = cargaDatosCliente.GetClienteBuscar(NombreNit);
                _dataGridView.DataSource = listClienteBuscar.ToList();
            }

            
        }




       















    }

   
}
