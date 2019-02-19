using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practia.Bar.Model
{
    public class Mozo : Persona
    {

        public Mozo(string nombre, string apellido, string dni)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.DNI = dni;
        }



        public override string GetDescripcion()
        {
            return "Mozo " + this.Nombre + " " + this.Apellido;
        }
    }
}
