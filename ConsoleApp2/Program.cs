using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp2.character;
using ConsoleApp2.Behaviors;
namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Character> characters = new List<Character>();
            characters.AddRange(new Character[] {
                new King(),
                new Queen(),
                new Knight(),
                new Troll()
            });
            foreach (var charac in characters)
            {
                charac.display();
                charac.perfomeWeapon();
                
                Console.WriteLine("===============");
            }
        }
    }
}
