using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class Cliente
    {
        public int IdCliente { get; set; }
        public int Nit { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public int Telefono { get; set; }


        public Cliente(int IdCliente, int Nit, string Nombre, string Direccion, int Telefono)
        {
            this.IdCliente = IdCliente;
            this.Nit = Nit;
            this.Nombre = Nombre;
            this.Direccion = Direccion;
            this.Telefono = Telefono;



        }
    }
}
