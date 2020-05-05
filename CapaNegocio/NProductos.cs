using CapaDatos;
using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaNegocio
{
    public class NProductos
    {
        private DataGridView _datagridProducto;



        public NProductos(DataGridView _datagridProducto)
        {
            this._datagridProducto = _datagridProducto;
        }
        public void cargarProductos()
        {
           var product = new Dproductos();
       
           var listProduct = product.getProducto();

            _datagridProducto.DataSource = listProduct;

        }

        public void cargarProductoByIdNombre(string codigoNombre)
        {
         
            
            if (codigoNombre == "")
            {
                cargarProductos();
            }
            else
            {
                var productbyId = new Dproductos();
                var listaproductobyId = productbyId.getProductoBuscar(codigoNombre);

                _datagridProducto.DataSource = listaproductobyId.ToList();
            }

        }



























    }
}
