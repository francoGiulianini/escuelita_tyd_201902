using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practia.Bar.Model
{
    public class Cliente : Persona
    {

        public override string GetDescripcion()
        {
            return "Cliente " + this.Nombre + " " + this.Apellido;
        }
    }
}
