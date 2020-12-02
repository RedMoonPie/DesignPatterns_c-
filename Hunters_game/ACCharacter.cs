using System;
namespace Hunters_game
{
    public abstract class ACCharacter
    {
        protected IWeaponBehavior weapon;

        public abstract void display();
        public void fight()
        {
            weapon.UseWeapon();
            display();
        }
        public IWeaponBehavior ChangeWeapon { set { weapon = value; } }
    }
}
