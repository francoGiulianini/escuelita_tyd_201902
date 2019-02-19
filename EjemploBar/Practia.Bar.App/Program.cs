using Practia.Bar.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practia.Bar.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Mesa mesa = new Mesa();
            mesa.Cubiertos = 8;
            mesa.Id = 2;

            string descripcion = mesa.Descripcion;

            // creo el bar
            Bar.Model.Bar bar = new Bar.Model.Bar();

            // agrego un mozo al bar
            //bar.Mozos.Add(new Mozo("Guille", "Filia", "26721601"));


            // reservar una mesa a las 22hs del 23/2/2019
            //mesa.Reserva = new Reserva();
            //mesa.Reserva.FechaYHora = new DateTime(2019, 2, 23, 22, 0, 0);
            //mesa.Reserva.Cliente = new Cliente();


            // imprimir el nombre del mozo que atiende a la mesa
            //System.Console.Write(mesa.MozoAsignado.Nombre);


            Mozo cliente = new Mozo("Ale", "Fraenkel", "45450650");
            var s = cliente.GetDescripcion();



        }
    }
}
