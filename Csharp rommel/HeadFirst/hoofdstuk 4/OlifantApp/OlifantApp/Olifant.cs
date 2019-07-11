using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OlifantApp
{
    class Olifant
    {

        public string Naam;
        public int OorGrootte;

        public void wieBenIk()
        {
            //print iets
            MessageBox.Show("Mijn naam is: " + Naam + " en mijn oren zijn " + OorGrootte + " groot.");
        }

    }
}
