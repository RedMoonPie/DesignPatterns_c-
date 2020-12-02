using System;
using System.Collections;

namespace Mix_Pattern
{
    public class CRestaurante:ACObserver,ACMostrar
    {
        private int cLasana = 5;
        private int cCarne = 5;
        private int cPollo  = 5;
        private int cPlatocasa = 5;
        private ACSujeto subs_las ;
     

        public CRestaurante(ACSujeto s1)
        {

            this.subs_las = s1;
            subs_las.RegistrarObservador(this);
          


        }
      
        public void mostrar(string plato,int cantidad)
        {
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine(" Notificacion de Restaurante : ");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("La cantidad de platos de {0} actualmente es de {1}",plato,cantidad);
            Console.WriteLine("--------------------------------------------");

        }

        public void update(ACPlatos obs, object arg)
        {
            if (obs is CLasana)
            {
                CLasana p1 = (CLasana)obs;
                this.cLasana -= 1;
                mostrar(p1.Nombre,cLasana);

                if(cLasana < 3)
                {
                    alertaPocosPlatos(p1.Nombre);
                    
                    
                }

            }
            if (obs is CCarneParrilla)
            {
                CCarneParrilla p1 = (CCarneParrilla)obs;
                this.cCarne -= 1;
                mostrar(p1.Nombre, cCarne);

                if (cCarne < 3)
                {
                    alertaPocosPlatos(p1.Nombre);
                }
            }
            if (obs is CPolloPlancha)
            {
                CPolloPlancha p1 = (CPolloPlancha)obs;
                this.cPollo -= 1;
                mostrar(p1.Nombre, cPollo);

                if (cPollo< 3)
                {
                    alertaPocosPlatos(p1.Nombre);
                }
            }
            if (obs is CPlatoCasa)
            {
                CPlatoCasa p1 = (CPlatoCasa)obs;
                this.cPlatocasa -= 1;
                mostrar(p1.Nombre, cPlatocasa);

                if (cPlatocasa < 3)
                {
                    alertaPocosPlatos(p1.Nombre);
                }
            }
        }

        public void alertaPocosPlatos(string pNombrePlato)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine(" Quedan pocos platos de {0} !!! ", pNombrePlato);
            Console.WriteLine("--------------------------------------------");
            Console.ForegroundColor = ConsoleColor.White;


        }
    }
}
