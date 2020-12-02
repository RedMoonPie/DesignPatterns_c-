using System;
namespace Factoryp
{
    public class CNYPizzaIngredientFactory : IPizzaIngredientFactory
    {
        public ICheese createCheese()
        {
            return new ReggianCheese();
        }

        public IClams createClam()
        {
            return new FreshClams();
        }

        public IDough createDough()
        {
            return new ThinCrustDOugh();
        }

        public ISauce createSauce()
        {
            return new MarinaraSauce();
        }

        public IVeggies[] createVeggies()
        {
            IVeggies []veggies = { new Garlic(), new Onion(), new Mushrrom() };
            return veggies;
        }
    }

    internal class Mushrrom : IVeggies
    {
        public string ingredient()
        {
            return "Mushroom";
        }
    }

    internal class Onion : IVeggies
    {
        public string ingredient()
        {
            return "Onion";
        }
    }

    internal class Garlic : IVeggies
    {
        public string ingredient()
        {
            return "Garlic";
        }
    }

    internal class MarinaraSauce : ISauce
    {
        public string ingredient()
        {
            return "MarinaraSauce";
        }
    }

    internal class ThinCrustDOugh : IDough
    {
        public string ingredient()
        {
            return "ThinCrustDOugh";
        }
    }

    internal class FreshClams : IClams
    {
        public string ingredient()
        {
            return "FreshClams";
        }
    }

    internal class ReggianCheese : ICheese
    {
        public string ingredient()
        {
            return "Reggian CHeese";
        }
    }
}
