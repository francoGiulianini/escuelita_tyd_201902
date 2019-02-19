using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practia.Bar.Model
{
    public class Mesa
    {
        private int _cubiertos;
        private int _id;
        private EstadoMesa _estadoMesa;
        private Reserva _reserva;

        private const string MESA_DESCRIPTCION_TEMPLATE = "Mesa número ";

        public Reserva Reserva
        {
            get { return _reserva; }
            set { _reserva = value; }
        }

        public EstadoMesa Estado
        {
            get { return _estadoMesa; }
            set { _estadoMesa = value; }
        }

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public int Cubiertos
        {
            get 
            {
                return _cubiertos;
            }
            set
            {
                if (value < 10 && value > 0)
                    _cubiertos = value;
                else
                    throw new Exception("Cubiertos cannot be greater than 10 and less than 0!.");

            }
        }

        public string Descripcion
        { 
            get
            {
                return MESA_DESCRIPTCION_TEMPLATE + this.Id.ToString();
            }
        }

        public Mozo MozoAsignado
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public Decimal Cerrar()
        {
            this.Estado = EstadoMesa.PendienteFacturacion;
            return 0;
        }

        public void Ocupar()
        {
            this.Estado = EstadoMesa.Ocupado;
        }
    }
}
