﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp2.Behaviors;

namespace ConsoleApp2.character
{
    public class Queen : Character
    {
        public override void display()
        {
            Console.WriteLine("I'm the queen");
        }

        public Queen()
        {
            iWB = new KnifeBehavior();
        }
     
        
    }
    
}
