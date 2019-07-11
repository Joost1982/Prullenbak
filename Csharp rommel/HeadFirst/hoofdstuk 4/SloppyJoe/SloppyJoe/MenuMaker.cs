using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SloppyJoe
{
    class MenuMaker
    {
        //public Random Randomizer;
        public Random Randomizer = new Random();

        string[] Meats = { "Ham", "Worst", "Salami", "Gehakt", "Kalkoen" };
        string[] Condiments = { "mosterd", "ketchup", "mayonaise", "curry", "chilisaus", "appelmoes" };
        string[] Breads = { "een wit bolletje", "oerbrood", "een pita broodje",
                            "een italiaans bol", "een bruine boterham", "ciabatta",
                            "stokbrood"};


        public string GetMenuItem()
        {
            //de .Next() method van de class Rando genereert een random getal
            // .Next(7) genereert een getal tussen de 0 en 7
            // we gaan dus de lengte van de array erin stoppen

            string randomMeat = Meats[Randomizer.Next(Meats.Length)];
            string randomCondiment = Condiments[Randomizer.Next(Condiments.Length)];
            string randomBread = Breads[Randomizer.Next(Breads.Length)];

            return randomMeat + " met " + randomCondiment + " op " + randomBread;
        }


    }
}
