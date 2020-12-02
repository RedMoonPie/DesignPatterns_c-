using System;
namespace duck_b
{
    public class CMallarsduck:CDuck
    {
        public CMallarsduck()
        {
            quackbehaviour = new Qquack();
            flybehaviour = new FlyWithwings();
        }
        public override void display()
        {
            Console.WriteLine("i am a mallard duck");
        }
    }
}
