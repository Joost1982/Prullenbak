using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DayAtTheRaces
{
    public class Persoon
    {
        public string Naam;
        public Wed MijnWedje;
        public int Geld;

        // GIU controls
        public RadioButton MyRadioButton;
        public Label MyLabel;


        public void UpdateLabels()
        {
            //set label to bet's description and label radiobutton to show my cash ("Pietje heeft 43 euro")

            if (MijnWedje.Hoeveelheid > 0) {
                //MyLabel.Text = Naam + " heeft " + MijnWedje.Hoeveelheid + " ingezet op dier #" + MijnWedje.Dier + ".";
                MyLabel.Text = MijnWedje.GeefOmschrijving();
                //Geld -= MijnWedje.Hoeveelheid;

            } else
            {
                MyLabel.Text = Naam + " heeft nog niet ingezet.";
            }

            MyRadioButton.Text = Naam + " heeft " + Geld + " euro.";
        }

        public void ClearBet()
        {
            // reset het wedje naar 0
            MijnWedje.Hoeveelheid = 0;
            
        }

        public bool PlaatsWedje(int WedHoeveelheid, int WedDier)
        {
            //plaats wedje en sla op in bet veld ('MijnWedje')
            MijnWedje = new Wed() { Hoeveelheid = WedHoeveelheid, Dier = WedDier, Wedder = this };
            //return true als Persoon genoeg geld heeft voor het wedje
            if (WedHoeveelheid <= Geld) {
                
                //update labels

                return true;
            } else
            {
                MessageBox.Show("Fout! Te weinig geld voor deze wed!");
                ClearBet();
                return false;
            }

        }

        public void Ingeld(int Winnaar)
        {
            // pay out van het wedje, reset wedje naar 0 en update labels
            Geld += MijnWedje.PayOut(Winnaar);
            
            MijnWedje = new Wed();
            UpdateLabels();
        }

    }
}
