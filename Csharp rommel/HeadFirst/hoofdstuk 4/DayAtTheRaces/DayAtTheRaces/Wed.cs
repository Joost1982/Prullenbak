using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayAtTheRaces
{
    public class Wed
    {
        public int Hoeveelheid;
        public int Dier;
        public Persoon Wedder;

        public string GeefOmschrijving()
        {
            // e.g. "Pietje wedt 5 euro op dier 2."
            // e.g. "Joost heeft niet ingezet."
            return Wedder.Naam + " heeft " + Hoeveelheid + " ingezet op #" + Dier + ".";
        }

        public int PayOut(int Winnaar)
        {
            //parameter is de winnaar; als zijn/haar dier gewonnen heeft, pay out anders de negatieve waarde van de inzet returnen

            if (Dier == Winnaar)
            {
                return Hoeveelheid;
            }
            else {
                return 0 - Hoeveelheid;
            }
        }

    }
}
