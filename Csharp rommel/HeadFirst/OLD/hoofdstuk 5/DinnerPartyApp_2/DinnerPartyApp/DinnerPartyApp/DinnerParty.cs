// zo had ik hem eerst opgebouwd en dat werkte zonder fouten
// de opzet die het boek kiest is anders en wel met fouten om je te leren dat je snel een fout maakt.... DOH!

using System.Windows.Forms;
using System;


namespace DinnerPartyApp
{
    public class DinnerParty
    {
        public int AantalMensen;
        public const int KostenEtenPP = 25; // const betekent dat een een var is die niet wijzigt
        public int KostenDrankjesPP = 20;
        public decimal KostenDecoraties;

        public CheckBox gezondje;
        public CheckBox fancy;

        public void SetHealthyOption()
        {
            if (gezondje.Checked)
            {
                KostenDrankjesPP = 5;
            }
            else
            {
                KostenDrankjesPP = 20;
            }
        }

        public decimal BerekenKosten()
        {



            if (fancy.Checked)
            {
                KostenDecoraties = (AantalMensen * 15) + 50;
            }
            else
            {
                KostenDecoraties = (AantalMensen * 7.50M) + 30;
            }

            ///// debug
            Console.WriteLine("AantalMensen: " + AantalMensen);
            Console.WriteLine("KostenDrankjesPP: " + KostenDrankjesPP);
            Console.WriteLine("KostenEtenPP: " + KostenEtenPP);
            Console.WriteLine("KostenDecoratie: " + KostenDecoraties);
            Console.WriteLine("------------");

            if (AantalMensen == 0)
            {
                return 0;
            } else
            {
                return (AantalMensen * KostenEtenPP) + (AantalMensen * KostenDrankjesPP) + KostenDecoraties;
            }
           
        }
                       
    }
}
