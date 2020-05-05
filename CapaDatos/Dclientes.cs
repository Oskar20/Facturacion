using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class Dclientes
    {
        //Creamos un metodo lista de tipo cliente para retornar todos los datos del cliente para cualquiere consulta
        // y de esta forma no tener que realizar el mismo proceso cada vez que se requiera consulta cliente o datos de algun cliente
        List<Cliente> ListaCliente(DataSetCliente.ClienteDataTable dataC)
         {
            var listacli = new List<Cliente>();

            for (int i = 0; i < dataC.Count; i++)
            {
                var clie = new Cliente(dataC[i].IdCliente, dataC[i].Nit, dataC[i].Nombre, dataC[i].Direccion, dataC[i].Telefono);
                listacli.Add(clie);
            }
            return listacli;
        }

        public List<Cliente> GetClientes()
        {
            DataSetClienteTableAdapters.ClienteTableAdapter ObtCliente = new DataSetClienteTableAdapters.ClienteTableAdapter();
            DataSetCliente.ClienteDataTable dataClie = ObtCliente.GetData();

            //****************forma directa *******************************
            //directamente recorremos el datatable que nos retorna la consulta y lo asignamos a la lista de tipo
            //cliente para obtener todos los valores correspondientes
            //var listacli = new List<Cliente>();
            //for (int i = 0; i < dataClie.Count; i++)
            //{

            //    var clie = new Cliente(dataClie[i].IdCliente, dataClie[i].Nit, dataClie[i].Nombre, dataClie[i].Direccion, dataClie[i].Telefono);
            //    listacli.Add(clie);

            //}
            //return listacli;
            //******************finaliza forma directa*********************
            return ListaCliente(dataClie); // llamo al metodo listar cliente y le paso el data table para que sea mas facil y si requiere usarse en otro metodo no tener que repetir codigo

        }


        public List<Cliente> GetClienteBuscar(string NombreNit)
        {

            DataSetClienteTableAdapters.ClienteTableAdapter obtCliente = new DataSetClienteTableAdapters.ClienteTableAdapter();
           DataSetCliente.ClienteDataTable adClieB = obtCliente.GetDataByCliente(NombreNit);

            return ListaCliente(adClieB);

        }




















    }
}
