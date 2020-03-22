using System;
using System.Windows.Forms;

namespace DayAtTheRaces
{
    public class Dier
    {
        public int StartPositie;
        public int RacebaanLengte;
        public PictureBox MijnPlaatje = null;
        public int Lokatie = 0;
        public Random Randomizer;
        
        public bool Ren()
        {
            
            //naar voren met random snelheid
            Lokatie =  Randomizer.Next(1,15);
            
            //update positie van PictureBox op the form
            MijnPlaatje.Left += Lokatie;
                              
            if (MijnPlaatje.Left >= RacebaanLengte)
            {
                return true; // gewonnen!
            }

            return false; // nog niet gewonnen...
            
        }

        public void TerugNaarStartPositie()
        {
            // reset Locatie PictureBox weer op de startpositie
            MijnPlaatje.Left = StartPositie;
        }

    }
}
