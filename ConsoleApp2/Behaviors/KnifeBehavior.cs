using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Behaviors
{
    class KnifeBehavior : iWeaponBehavior
    {
        public void useWeapon()
        {
            Console.WriteLine("I beat the knife");
        }
    }
}
