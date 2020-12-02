using System;
using System.Collections;

namespace Mix_Pattern
{
    public class CCocina:ACCocina,ACSujeto
    {

        ACPlatos cPlato;
       

        public override void MeasurementsCHanged()
        {
            setChanged();
            NotificarObsevadores(cPlato,null);
        }

       

       
        public override void agregarPlato(ACPlatos plato)
        {
            cPlato = plato;
            MeasurementsCHanged();
        }

        public override void setChanged()
        {
            cambio = true;
        }

        public override int AbastecerPlatos(ACPlatos plato)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine(" Notificacion de Cocina : ");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Se reabastecieron 5 platos de {0} ",plato.GetDescription());
            Console.WriteLine("--------------------------------------------");

            Console.ForegroundColor = ConsoleColor.White;



            return 5;
        }
    }
}
