namespace PartyPlanner2

{

    // de initiele class leverde problemen op omdat er niet ge-incapsulated is (zie pagina 208 van het boek) - bij het veranderen van het aantal mensen werden de "tussen"kosten (vd decoratie) niet goed doorberekend
    // hieronder de fix door het veranderen van fields naar properties (get/set)
    //
    // de truuk zit hem erin om steeds alle kosten opnieuw te laten bereken als de 'costs' opgevraagd / ge-GET worden (costs - de method Kosten - moet dus een property worden)

    public class DinnerParty
    {
        public int AantalMensen { get; set; }
        public bool Fancy { get; set; }
        public bool Healthy { get; set; }

        //constructor
        public DinnerParty(int aantalmensen, bool healthy, bool fancy)
        {
            this.AantalMensen = aantalmensen;
            this.Fancy = fancy;
            this.Healthy = healthy;
        }


        // Methods

        private decimal KostenDecoratie()
        {
            if (Fancy)
            {
                return (AantalMensen * 15) + 50;
            }
            else
            {
                return (AantalMensen * 7.50M) + 30;
            }
        }

        private decimal KostenDrankjesPP()
        {
            if (Healthy)
            {
                return 5;
            }
            else
            {
                return 20;
            }

        }


        public decimal Kosten
        { get
            {
                if (AantalMensen == 0)
                {
                    return 0;
                }

                return (AantalMensen * KostenDrankjesPP()) + KostenDecoratie() + (AantalMensen * 25);

            }
        }
                       
    }
}
