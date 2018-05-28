using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp2.Behaviors;


namespace ConsoleApp2.character
{
    public abstract class Character
    {
        public iWeaponBehavior iWB;

        public abstract void display();

        public void setWeapon(iWeaponBehavior iWB)
        {
            this.iWB = iWB;
        }
        public void perfomeWeapon()
        {
            iWB.useWeapon();
        }
    }
}
