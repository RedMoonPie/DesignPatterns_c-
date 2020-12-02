using System;

namespace Mix_Pattern
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            ACPlatos plato1 = new CLasana();
            ACCocina cocina1 = new CCocina();
            CRestaurante rest = new CRestaurante(cocina1);

            cocina1.agregarPlato(plato1);

           

            ACPlatos plato2 = new CLasana();
            cocina1.agregarPlato(plato2);


            ACPlatos plato3 = new CLasana();
            cocina1.agregarPlato(plato2);


            ACPlatos plato4 = new CLasana();
            cocina1.agregarPlato(plato2);

            cocina1.AbastecerPlatos(plato1);

            Console.WriteLine(plato2.GetDescription() + "$" + plato2.cost());




           
            plato1 = new PapaFrita(plato1);
            plato1 = new JugoCasa(plato1);
            plato1 = new Aguacate(plato1);
            Console.WriteLine(plato1.GetDescription() + "$" + plato1.cost());

        }
    }
}
