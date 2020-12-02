using System;

namespace Factoryp
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            ACPizzaStore nyStore = new CNYPizzaStore();
            ACPizzaStore chicagoStore = new ChicagoPizzaStore();

            CPizza pizza = nyStore.orderPizza("cheese");
            Console.WriteLine("======================================");
            Console.WriteLine("Ethan ordered a {0} ", pizza.getName());
            Console.WriteLine("===============");



            pizza = chicagoStore.orderPizza("cheese");
            Console.WriteLine("======================================");
            Console.WriteLine("Joel ordered a {0} ", pizza.getName());
            Console.WriteLine("===============");


        }


    }
}
