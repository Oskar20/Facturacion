using CapaDatos.DataSetFacturaTableAdapters;
using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DdetalleFactura
    {

        public List<DetalleFactura> listaDetalleFactura(DataSetFactura.DetFacturaDataTable df)
        {
            var listDetalle = new List<DetalleFactura>();

            for (int i = 0; i < df.Count; i++)
            {
                var objDet = new DetalleFactura(df[i].PrefijoFactura, df[i].NumFactura,df[i].Consecutivo, df[i].CodigoProducto, df[i].NombreProducto, df[i].Cantidad, df[i].Precio, df[i].Total);
                listDetalle.Add(objDet);
            }
            return listDetalle;
        }

        public void InsertDetFactura(DetalleFactura dfe, int cons)
        {
            DataSetFacturaTableAdapters.DetalleFacturaTableAdapter detf = new DataSetFacturaTableAdapters.DetalleFacturaTableAdapter();
            detf.Insert(dfe.Facturas.NumFactura, dfe.Facturas.PrefijoFactura, cons, dfe.Productos.CodProd, dfe.Precio, dfe.Cantidad, dfe.Total);
        }



        public List<DetalleFactura> ObtenerDetelle(int NroFactura, string PrefijoFactura)
        {
            DataSetFacturaTableAdapters.DetFacturaTableAdapter dtFac = new DataSetFacturaTableAdapters.DetFacturaTableAdapter();
            DataSetFactura.DetFacturaDataTable facD = dtFac.GetDataByConsultaDetalle(NroFactura,PrefijoFactura);

            return listaDetalleFactura(facD);
        }












    }
}
