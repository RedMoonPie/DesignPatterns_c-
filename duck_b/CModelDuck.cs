using System;
namespace duck_b
{
    public class CModelDuck:CDuck
    {
        public CModelDuck()
        {
            flybehaviour = new FlyNoWay();
            quackbehaviour = new MuteQuack();

        }
        public override void display()
        {
            Console.WriteLine("i'm a model duck");
        }
    }
}
