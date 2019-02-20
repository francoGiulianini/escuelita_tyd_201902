using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practia.Bar.Model
{
    public class Factura
    {

        public Factura(int unaFecha, int unNúmero, int unMonto, Cliente unCliente, Mesa unaMesa, Mozo unMozo, int unaCantidadComensales)
        {
            this.Fecha = unaFecha;
            this.Número = unNúmero;
            this.Monto = unMonto;
            this.Cliente = unCliente;
            this.Mesa = unaMesa;
            this.Mozo = unMozo;
            this.CantidadComensales = unaCantidadComensales;
        }

        public int Fecha
        {
            get;
            set;
        }

        public int Número
        {
            get;
            set;
        }

        public int Monto
        {
            get;
            set;
        }

        public Cliente Cliente
        {
            get;
            set;
        }

        public Mozo Mozo
        {
            get;
            set;
        }

        public int CantidadComensales
        {
            get;
            set;
        }

        public Mesa Mesa
        {
            get;
            set;
        }

        public bool mesaBienAsiganada()
        {
            return this.CantidadComensales == this.Mesa.Cubiertos;
        }
    }
}
