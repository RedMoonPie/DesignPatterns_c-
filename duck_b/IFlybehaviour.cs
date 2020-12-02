using System;
namespace duck_b
{
    public interface IFlybehaviour
    {
         void Fly();
    }
    public class FlyWithwings : IFlybehaviour
    {
        public void Fly()
        {
            Console.WriteLine("I'm flying!");
        }
    }
    public class FlyNoWay : IFlybehaviour
    {
        public void Fly()
        {
            Console.WriteLine("can't fly ! ");
        }
    }
    public class RocketPowered : IFlybehaviour
    {
        public void Fly()
        {
            Console.WriteLine("BOooooom!");
        }
    }
}
