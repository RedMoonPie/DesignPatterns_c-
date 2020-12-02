using System;
namespace Hunters_game
{
    public class CKing:ACCharacter
    {
        public CKing()
        {
            weapon = new  Knifebh();
        }
        public override void display()
        {
            Console.WriteLine("I'm {0}", nameof(ACCharacter));
        }
    }
}
