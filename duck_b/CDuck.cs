using System;
namespace duck_b
{
    public abstract class CDuck
    {
        protected IFlybehaviour flybehaviour;
        protected IQuackbehaviour quackbehaviour;
        public CDuck()
        {
        }
        public abstract void display();

        public void performfly()
        {
            flybehaviour.Fly();
        }
        public void performquack()
        {
            quackbehaviour.Quack();
        }
        public void swim()
        {
            Console.WriteLine("All the ducks float! even decoys!");
        }

        public IFlybehaviour Flybehaviour { set { flybehaviour = value; } get { return flybehaviour; } }
        public IQuackbehaviour Quackbehaviour { set { quackbehaviour = value; } get { return quackbehaviour; } }

    }
}
