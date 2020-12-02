using System;
namespace Factoryp
    //some abstract factory pattern 
{
    public interface IPizzaIngredientFactory
    {
        //for eeach item we define a create method
        IDough createDough();
        ISauce createSauce();
        ICheese createCheese();
        IVeggies [] createVeggies();
        IClams createClam();

        // if we'd had some common "machinery" to implement im each instance of factory we could have made this an abstract
        //class instead
    }
}
