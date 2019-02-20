using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practia.Bar.Model
{
    public class Bar
    {

        public List<Factura> Facturas
        {
            get;
            set;
        }

        public List<Mesa> Mesas
        {
            get;
            set;
        }

        public List<Mozo> Mozos
        {
            get;
            set;
        }

        public int Reservar(int cubiertos, DateTime fecha, string nombreReserva, string dni)
        {
            return -1; 
        }

        public void CancelarReserva(string nombreReserva, string dni, DateTime fecha)
        {
            throw new System.NotImplementedException();
        }

        private int aciertosDeAsignacion()
        {
            return Facturas.Where(unaFactura => unaFactura.mesaBienAsiganada()).ToList().Count;
        }

        public double eficienciaDistribucionDelDia()
        {
            return (double)this.aciertosDeAsignacion() / this.Facturas.Count;
        }
    }
}
