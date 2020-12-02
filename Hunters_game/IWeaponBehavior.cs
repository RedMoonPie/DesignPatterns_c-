using System;
namespace Hunters_game
{
    public interface IWeaponBehavior
    {
        void UseWeapon();
        
    }
    public class Axebh:IWeaponBehavior
    {
        public void UseWeapon()
        {
            Console.WriteLine("I got the Axe !");
        }
    }
    public class Swordbh : IWeaponBehavior
    {
        public void UseWeapon()
        {
            Console.WriteLine("I got the Sword !");
        }
    }
    public class Knifebh : IWeaponBehavior
    {
        public void UseWeapon()
        {
            Console.WriteLine("I got the Knife !");
        }
    }
    public class BownArrowbh : IWeaponBehavior
    {
        public void UseWeapon()
        {
            Console.WriteLine("I got the Arrow and bow !");
        }
    }
}
