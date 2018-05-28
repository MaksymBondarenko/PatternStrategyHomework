using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Behaviors
{
    public class BowAndArrowBehavior : iWeaponBehavior
    {
        public void useWeapon()
        {
            Console.WriteLine("Shooting from the bow");
        }
    }
}
