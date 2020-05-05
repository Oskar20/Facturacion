using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class DetalleFactura
    {
        public double Precio { get; set; }
        public int Cantidad { get; set; }
        public double Total { get; set; }

        //public string CodigoProducto { get; set; }

        //public int NumFactura { get; set; }
        //public string PrefijoFactura { get; set; }
        public int Consecutivo { get; set; }

        public Factura Facturas { get; set; }
        public Producto Productos { get; set; }


        public DetalleFactura()
        {
            
        }
        public DetalleFactura(String PrefijoFactura,int NumFactura, int Consecutivo, string CodigoProducto,
            string NombreProducto, int Cantidad,double Precio,  double Total )
        {
            Productos = new Producto();
            Facturas = new Factura();

            this.Precio = Precio;
            this.Cantidad = Cantidad;
            this.Total = Total;
            //this.CodigoProducto = CodigoProducto;
            //this.NumFactura = NumFactura;
            //this.PrefijoFactura = PrefijoFactura;
            //this.Consecutivo = Consecutivo;.
            this.Productos.CodProd = CodigoProducto;
            this.Productos.NomProducto = NombreProducto;
            this.Facturas.NumFactura = NumFactura;
            this.Facturas.PrefijoFactura = PrefijoFactura;
            this.Consecutivo = Consecutivo;
        }




    }



}
