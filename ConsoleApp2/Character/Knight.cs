using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp2.Behaviors;

namespace ConsoleApp2.character
{
    public class Knight : Character
    {
        public override void display()
        {
            Console.WriteLine("I'm the knight");
        }
        public Knight()
        {
            iWB = new BowAndArrowBehavior();
        }
    }
}
