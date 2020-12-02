using System;
namespace duck_b
{
    public interface IQuackbehaviour
    {
        void Quack();
    }
    public class Qquack : IQuackbehaviour
    {
        public void Quack()
        {
            Console.WriteLine("quack!");
        }

    }
    public class MuteQuack : IQuackbehaviour
    {
        public void Quack()
        {
            Console.WriteLine("*(*#@(!_");
        }
    }
    public class squeak : IQuackbehaviour
    {
        public void Quack()
        {
            Console.WriteLine("squeak! ");
        }
    }
}
