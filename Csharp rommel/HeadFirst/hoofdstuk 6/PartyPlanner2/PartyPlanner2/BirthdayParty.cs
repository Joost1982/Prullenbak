using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartyPlanner2
{
    class BirthdayParty
    {
        public const int KostenVoedselPP = 25;
        public int AantalMensen { get; set; }
        public bool FancyShit { get; set; }
        public string CakeWriting { get; set; }

        //constructor
        public BirthdayParty(int aantalMensen, bool fancyShit, string cakeWriting)
        {
            AantalMensen = aantalMensen;
            FancyShit = fancyShit;
            CakeWriting = cakeWriting;

        }

        //properties

        private int Grootte
        {
            get
            {
                // bij single-line blocks hoef je geen curly brackets te gebruiken!
                if (CakeWriting.Length > MaximaleSchrijflengte())
                    return MaximaleSchrijflengte();
                else
                    return CakeWriting.Length;
            }
        }

        public bool CakeWritingTeLang
        {
            get
            {
                if (CakeWriting.Length > MaximaleSchrijflengte())
                    return true;
                else
                    return false;
            }
        }

        public decimal Kosten
        {
            get
            {
                decimal TotaleKosten = BerekenDecoratieKosten();
                TotaleKosten += KostenVoedselPP * AantalMensen;
                decimal CakeKosten;
                if (AantalMensen <= 4)
                    CakeKosten = 40M + Grootte * .25M;
                else
                    CakeKosten = 75M + Grootte * .25M;

                Console.WriteLine(CakeKosten);
                return TotaleKosten + CakeKosten;
            }

         }

        //methods

        private int MaximaleSchrijflengte()
        {
            if (AantalMensen <= 4)
                return 16;
            else
                return 40;
        }

        private decimal BerekenDecoratieKosten()
        {
            decimal DecoratieKosten;
            if (FancyShit)
                DecoratieKosten = (AantalMensen * 15.00M) + 50M;
            else
                DecoratieKosten = (AantalMensen * 7.50M) + 30M;
            return DecoratieKosten;                       
        }



    }
}
