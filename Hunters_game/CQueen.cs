using System;
namespace Hunters_game
{
    public class CQueen:ACCharacter
    {
        
        public CQueen()
        {
            weapon = new Axebh();
        }
        public override void display()
        {
            Console.WriteLine("I'm the queen ");
        }

    }
}
