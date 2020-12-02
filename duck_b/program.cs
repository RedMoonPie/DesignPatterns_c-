using System;
namespace duck_b
{
    public class MainClass
    {
        public static void Main (string[] args)
        {
            CDuck poky = new CMallarsduck();
            poky.performquack();
            poky.performfly();

            CDuck roky = new CModelDuck();
            roky.performfly();
            roky.Flybehaviour = new RocketPowered();
            roky.performfly();
        }
    }
}
