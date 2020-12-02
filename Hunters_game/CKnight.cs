using System;
namespace Hunters_game
{
    public class CKnight:ACCharacter
    {
        public CKnight()
        {
            weapon = new Swordbh();
        }
        public override void display()
        {
            Console.WriteLine("I'm a knight");
        }
    }
}
