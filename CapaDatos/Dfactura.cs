using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class Dfactura
    {

        public void PostInsertFactura(Factura fact)
        {

            DataSetFacturaTableAdapters.FacturaTableAdapter insFac = new DataSetFacturaTableAdapters.FacturaTableAdapter();
            insFac.Insert(fact.NumFactura,fact.PrefijoFactura,DateTime.Now,fact.SubTotal,fact.Iva,fact.Total,fact.IdCliente);

        }


        public int NumeroFactura(string prefijo)
        {
            int dtNum;

            DataSetFacturaTableAdapters.FacturaTableAdapter adF =  new DataSetFacturaTableAdapters.FacturaTableAdapter();
            dtNum = (int)adF.NumFactura(prefijo);

            return dtNum;
        }


        public void PutUpdateFactura(Factura fact)
        {
            DataSetFacturaTableAdapters.FacturaTableAdapter upF = new DataSetFacturaTableAdapters.FacturaTableAdapter();
            upF.UpdateQueryFactura(fact.SubTotal,fact.Iva,fact.Total,fact.NumFactura,fact.PrefijoFactura);
        }


    }
}
