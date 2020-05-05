using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class Dproductos
    {
        List<Producto> ListaProductos(DataSetProductos.ProductoDataTable dbProd)
        {
            var listaProd = new List<Producto>();
            for (int i = 0; i < dbProd.Count; i++)
            {
               var prod = new Producto(dbProd[i].CodigoProducto, dbProd[i].NombreProducto, dbProd[i].PrecioProducto);
                listaProd.Add(prod);
            }

            return listaProd;
        }


        public List<Producto> getProducto()
        {

            DataSetProductosTableAdapters.ProductoTableAdapter dbP = new DataSetProductosTableAdapters.ProductoTableAdapter();
            DataSetProductos.ProductoDataTable prodt = dbP.GetData();

            return ListaProductos(prodt);
        }


        public List<Producto> getProductoBuscar(string codNomProducto)
        {
            DataSetProductosTableAdapters.ProductoTableAdapter adp = new DataSetProductosTableAdapters.ProductoTableAdapter();
            DataSetProductos.ProductoDataTable liPr = adp.GetDataByBuscarProducto(codNomProducto);

            return ListaProductos(liPr);

        }





















    }
}
