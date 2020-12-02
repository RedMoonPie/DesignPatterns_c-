using System;
namespace Factoryp
{
    public abstract class ACPizzaStore
    {
        public CPizza orderPizza(string type)
        {
            CPizza pizza;
            pizza = createPizza(type);
            pizza.prepare();
            pizza.bake();
            pizza.cut();
            pizza.box();

            return pizza;

        }
        protected abstract CPizza createPizza(string item);
    }

    public class CNYPizzaStore : ACPizzaStore
    {
        //Factory patter (normal)
        //protected override CPizza createPizza(string item)
        //{
        //    if (item.Equals("cheese"))
        //    {
        //        return new CNYStyleCheesePizza();
        //    }
        //    else return null;
        //}
        //abstract

        protected override CPizza createPizza(string item)
        {
            CPizza pizza = null;
            IPizzaIngredientFactory ingredientFactory =
                new CNYPizzaIngredientFactory();

            if (item.Equals("cheese"))
            {
                pizza = new CheesePizza(ingredientFactory);
                pizza.setName("New York Style Cheese Pizza");
            }
            else if (item.Equals("clam"))
            {

                pizza = new ClamPizza(ingredientFactory);
                pizza.setName("New York Style Clam Pizza");

            }
            return pizza;

        }

    }
    public class ChicagoPizzaStore : ACPizzaStore
    {
        //protected override CPizza createPizza(string item)
        //{
        //    if (item.Equals("cheese"))
        //    {
        //        return new CChicagoStyleCheesePizza();
        //    }
        //    return null;
        //}
        protected override CPizza createPizza(string item)
        {
            CPizza pizza = null;
            IPizzaIngredientFactory ingredientFactory =
                new CChicagoPIzzaIngredientFActory();

            if (item.Equals("cheese"))
            {
                pizza = new CheesePizza(ingredientFactory);
                pizza.setName("Chicago Style Cheese Pizza");
            }
            else if (item.Equals("clam"))
            {

                pizza = new ClamPizza(ingredientFactory);
                pizza.setName("Chicago Style Clam Pizza");

            }
            return pizza;

        }
    }
}
