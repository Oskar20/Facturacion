using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Producto
    {
        public string CodProd { get; set; }
        public string NomProducto { get; set; }
        public double PrecioProducto { get; set; }


        public Producto()

        {
           
        }
        public Producto(string codProd, string NomProducto, double PrecioProducto)

        {
            this.CodProd = codProd;
            this.NomProducto = NomProducto;
            this.PrecioProducto = PrecioProducto;
        }
    }
}
