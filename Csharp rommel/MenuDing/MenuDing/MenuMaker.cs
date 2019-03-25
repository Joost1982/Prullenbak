using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuDing
{
    class MenuMaker
    {
        //public Random Randomizer;
        public Random Randomizer = new Random();
        string[] Meats = { "Ham", "Gehakt", "Kalkoen", "Eend", "Duif" };
        string[] Saus = { "mayonaise", "curry", "ketchup", "mosterd", "chilisaus", "joppiesaus" };
        string[] Brood = { "zacht bolletje", "croissant", "stokbrood", "bruine boterham", "ontbijtkoek" };
    
        public string GetMenuItem()
        {
            string randomMeat = Meats[Randomizer.Next(Meats.Length)];
            string randomSaus = Saus[Randomizer.Next(Saus.Length)];
            string randomBrood = Brood[Randomizer.Next(Brood.Length)];
            return randomMeat + " met " + randomSaus + " op een " + randomBrood;
        }
    }
}
