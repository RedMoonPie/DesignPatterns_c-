using System;

namespace Hunters_game
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            ACCharacter Leonidas = new CKnight();

            Leonidas.fight();
            Leonidas.ChangeWeapon = new Axebh();
            Leonidas.fight();
        }
    }
}
