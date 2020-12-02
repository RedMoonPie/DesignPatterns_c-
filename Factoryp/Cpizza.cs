using System;
using System.Collections;
namespace Factoryp
{
    public abstract class CPizza
    {
        protected string name;
        protected IDough dough;
        protected ISauce sauce;
        protected IVeggies []veggies;
        protected ICheese cheese;
        protected IClams clams;

        //THis is where we are going to collect the ingredients needed for the pizza, which of course will come from the ingredient factory

        public abstract void prepare();

        //NOrmal factory pattern
        // public virtual void prepare()
        //{
        //    Console.WriteLine("Preparing.." + name);
        //    Console.WriteLine("Tossing dough");
        //    Console.WriteLine("Adding sauce...");
        //    Console.WriteLine("Adding toppings: ");
        //    foreach( string topi in toppings)
        //    {
        //        Console.WriteLine("   " + topi);
        //    }
        //}

        public virtual void bake()
        {
            Console.WriteLine("Bake for 25 minutes at 350");
        }
        public virtual void cut()
        {
            Console.WriteLine("Cutting the pizza into diagonal slices");
        }
        public virtual void box()
        {
            Console.WriteLine("Plazce pizza in official PizzaStore box");
        }
        public virtual string getName()
        {
            return name;
        }
        public void setName(string pname)
        {
            name = pname;
        }
    }
    //Another pizza styles

    // we no longer need two classes for pizza since the ingredient factory already handles the regional differences
    //public class CNYStyleCheesePizza : CPizza
    //{
    //    public CNYStyleCheesePizza()
    //    {
    //        name = "Ny Style Sauce and CHeese Pizza";
    //        dough = "Thin crust DOugh";
    //        sauce = "Mariana Sauce";
    //        toppings.Add("Freated Reggiano CHeese");

    //    }
    //}

    //public class CChicagoStyleCheesePizza : CPizza
    //{
    //    public CChicagoStyleCheesePizza()
    //    {
    //        name = "Chicago Style Deep Dish CHeese Pizza";
    //        dough = "Extra Thick Crust Dough";
    //        sauce = "Plum TOmato Sauce";

    //        toppings.Add("Shredded Mozzarella Cheese");
    //    }
    //    public override void cut()
    //    {
    //        Console.WriteLine("Cutting the pizza into square slices");
    //    }
    //}
    public class CheesePizza: CPizza
    {
        IPizzaIngredientFactory ingredientFactory;


        public CheesePizza(IPizzaIngredientFactory ingredientFactory)
        {
            this.ingredientFactory = ingredientFactory;
        }

        public override void prepare ()
        {
            Console.WriteLine("Preparing" + name);
            dough = ingredientFactory.createDough();
            Console.WriteLine(ingredientFactory.createDough().ingredient());
            Console.WriteLine("======================================");
            sauce = ingredientFactory.createSauce();
            Console.WriteLine(ingredientFactory.createSauce().ingredient());
            Console.WriteLine("======================================");
            cheese = ingredientFactory.createCheese();
            Console.WriteLine(ingredientFactory.createCheese().ingredient());
            Console.WriteLine("======================================");
        }

    }
    public class ClamPizza : CPizza
    {
        IPizzaIngredientFactory ingredientFactory;


        public ClamPizza(IPizzaIngredientFactory ingredientFactory)
        {
            this.ingredientFactory = ingredientFactory;
        }

        public override void prepare()
        {
            Console.WriteLine("Preparing" + name);
            dough = ingredientFactory.createDough();
            sauce = ingredientFactory.createSauce();
            cheese = ingredientFactory.createCheese();
        }

    }




}
