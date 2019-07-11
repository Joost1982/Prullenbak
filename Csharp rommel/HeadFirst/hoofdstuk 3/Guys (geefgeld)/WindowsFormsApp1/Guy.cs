using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    class Guy
    {
        public string Naam;
        public int Geld;

        public int GeefGeld(int hoeveelheid)
        {
            if (hoeveelheid <= Geld && hoeveelheid > 0)
            {
                Geld -= hoeveelheid;
                return hoeveelheid;
            }
            else
            {
                MessageBox.Show(Naam + " heeft niet genoeg geld om " + hoeveelheid + " euro te geven");
                return 0;
            }
        }

        public int OntvangGeld (int hoeveelheid)
            {
                if (hoeveelheid > 0)
                {
                    Geld += hoeveelheid;
                    return hoeveelheid;
                }
                else
                {
                    MessageBox.Show(hoeveelheid + " neem ik niet aan " + Naam);
                    return 0;
                }
                
            }

    }
}
