using System;
using System.Collections;

namespace Mix_Pattern
{
    public class CLasana:ACPlatos
    {
        private string nombre = "lasana";
        private int cantidad_disponible = 5;
        public CLasana()
        {
            descripcion = " Lasana basica ";
            cantidad_disponible -= 1;
         
        }

        public override double cost()
        {
            return 6500;
        }


        public override string GetDescription()
        {
            return descripcion;
        }
        public string Nombre { get { return nombre; } set { nombre = value; } }



    }
    public class CCarneParrilla : ACPlatos
    {
        private string nombre = "CarneParrilla";
        private int cantidad_disponible = 5;

        public CCarneParrilla()
        {
          
            descripcion = " Carne Parrilla ";
            cantidad_disponible -= 1;
        }
        public override double cost()
        {
            return 8000;
        }
        public override string GetDescription()
        {
            return descripcion;
        }
        public string Nombre { get { return nombre; } set { nombre = value; } }

    }
    public class CPolloPlancha : ACPlatos
    {
        private string nombre = "PolloPlancha";


        public CPolloPlancha()
        {
           
           
            descripcion = " PolloPlancha ";
           
        }
        public override double cost()
        {
            return 7500;
        }

        public override string GetDescription()
        {
            return descripcion;
        }
        public string Nombre { get { return nombre; } set { nombre = value; } }
    }

    public class CPlatoCasa:ACPlatos
    {
        private string nombre = "PlatoCasa";
        private int cantidad_disponible = 5;

        public CPlatoCasa()
        {
            
           
            descripcion = " PlatoCasa ";
            cantidad_disponible -= 1;

    }
    public override double cost()
        {
            return 10000;
        }

    

    public override string GetDescription()
    {
        return descripcion;
    }

    public string Nombre { get { return nombre; } set { nombre = value; } }
}
}
