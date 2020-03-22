using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppOverrideVirtualExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Owner owner = new Owner();
            Safe safe = new Safe();
            JewelThief jewelthief = new JewelThief();
            jewelthief.OpenSafe(safe, owner);

            Console.ReadKey(); // om te voorkomen dat het venster meteen sluit

        }
    }
}
