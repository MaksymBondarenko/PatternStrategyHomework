using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Behaviors
{
    class AxeBehavior : iWeaponBehavior
    {
        public void useWeapon()
        {
            Console.WriteLine("I beat with an axe");
        }
    }
}
