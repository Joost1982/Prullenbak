
namespace DinnerPartyApp
{
    public class DinnerParty
    {
        public int AantalMensen;
        public const int KostenEtenPP = 25; // const betekent dat een een var is die niet wijzigt
        public int KostenDrankjesPP = 20;
        public decimal KostenDecoraties = 0;

        public void SetHealthyOption(bool gezond)
        {
            if (gezond)
            {
                KostenDrankjesPP = 5;
            }
            else
            {
                KostenDrankjesPP = 20;
            }
        }

        public void SetDecoratieType(bool fancy)
        {
            if (fancy)
            {
                KostenDecoraties = (AantalMensen * 15) + 50;
            } else
            {
                KostenDecoraties = (AantalMensen * 7.50M) + 30;
            }
        }


        public void BerekenDecoratieKosten()
        {
            // doe iets
        }

        public decimal BerekenKosten()
        {

            ///// debug
            //Console.WriteLine("AantalMensen: " + AantalMensen);
            //Console.WriteLine("KostenDrankjesPP: " + KostenDrankjesPP);
            //Console.WriteLine("KostenEtenPP: " + KostenEtenPP);
            //Console.WriteLine("KostenDecoratiePP: " + KostenDecoratiesPP);
            //Console.WriteLine("KostenDecoratie: " + KostenDecoraties);
            //Console.WriteLine("------------");
                                   
            if (AantalMensen == 0)
            {
                return 0;
            }

            return (AantalMensen * KostenEtenPP) + (AantalMensen * KostenDrankjesPP) + KostenDecoraties;
        }

                       
    }
}
