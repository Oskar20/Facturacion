using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Factura
    {
        public int NumFactura { get; set; }
        public string PrefijoFactura { get; set; }
        public DateTime FechaGnerada { get; set; }
        public double SubTotal { get; set; }
        public double Iva { get; set; }
        public double Total { get; set; }

        public int IdCliente { get; set; }
        public Cliente Clientes { get; set; }


        public Factura()
        {
            
        }
        public Factura(int NumFactura, string PrefijoFactura, DateTime FechaGnerada, double SubTotal, double Iva, double Total)
        {
            this.NumFactura = NumFactura;
            this.PrefijoFactura = PrefijoFactura;
            this.FechaGnerada = FechaGnerada;
            this.SubTotal = SubTotal;
            this.Iva = Iva;
            this.Total = Total;
        }
    }
}
