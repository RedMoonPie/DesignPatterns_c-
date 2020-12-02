using System;

namespace Decorator_pattern
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            ACBeverage beverage = new HouseBlend();
            beverage.setSize("lg");
            beverage = new whip(beverage);
            Console.WriteLine(beverage.GetDescription() + "$" + beverage.cost());

            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++");


            ACBeverage beverage2 = new HouseBlend();
            beverage2 = new large(beverage2);
            beverage2 = new whip(beverage2);
            Console.WriteLine(beverage2.GetDescription() + "$" + beverage2.cost());
        }
    }
}
