using System;
namespace Factoryp
{
    public class CChicagoPIzzaIngredientFActory : IPizzaIngredientFactory
    {
        public ICheese createCheese()
        {
            return new MozzarellaCheese();
        }

        public IClams createClam()
        {
            return new FrozenClams();
        }

        public IDough createDough()
        {
            return new ThickCrustDough();
        }

        public ISauce createSauce()
        {
            return new PlumTomatoSauce();
        }

        public IVeggies[] createVeggies()
        {
            IVeggies[] veggies = {new Spinach(),new SlicedPepperony(),new BlackOlives() };
            return veggies;

        }
    }

    internal class BlackOlives : IVeggies
    {
        public string ingredient()
        {
            return "Blackolives";
        }

    }

    internal class SlicedPepperony : IVeggies
    {
        public string ingredient()
        {
            return "SlicedPepperony";
        }
    }

    internal class Spinach : IVeggies
    {
        public string ingredient()
        {
            return "Spinach";
        }
    }

    internal class PlumTomatoSauce : ISauce
    {
        public string ingredient()
        {
            return "PlumTomatoSauce";
        }
    }

    internal class ThickCrustDough : IDough
    {
        
        public string ingredient()
        {
            return "ThickCrustDOugh";
        }
    }

    internal class FrozenClams : IClams
    {
        public string ingredient()
        {
            return "FrozenClams";
        }
    }

    internal class MozzarellaCheese : ICheese
    {
        public string ingredient()
        {
            return "MozzarellaCheese";
        }
    }
}
