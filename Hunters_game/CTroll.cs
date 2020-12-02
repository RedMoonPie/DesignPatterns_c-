using System;
namespace Hunters_game
{
    public class CTroll:ACCharacter
    {
        public CTroll()
        {
            weapon = new BownArrowbh();
        }
        public override void display()
        {
            Console.WriteLine("I'm the troll gnraa ");
        }
    }
}
