using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp2.Behaviors;

namespace ConsoleApp2.character
{
    public class King : Character
    {
        public override void display()
        {
            Console.WriteLine("I'm the king");
        }
        public King()
        {
            iWB = new SwordBehavior();
        }
    }
}
