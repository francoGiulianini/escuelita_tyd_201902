using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practia.Bar.Model
{
    public abstract class Persona
    {
        public abstract string GetDescripcion();

        public string Nombre
        {
            get;
            protected set;
        }

        public string Apellido
        {
            get;
            protected set;
        }

        public string DNI
        {
            get;
            protected set;
        }

        public bool EstaVivo()
        {
            return true;
        }
    }
}
