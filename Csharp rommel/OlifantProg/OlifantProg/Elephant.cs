using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OlifantProg
{
    class Elephant
    {
        public string Name;
        public int EarSize;

        public void WhoAmI() {
             MessageBox.Show("My ears are " + EarSize + " inches tall.");
            }

        public void TellMe(string message, Elephant whoSaidIt)
        {
            MessageBox.Show(whoSaidIt.Name + " says: " + message);
        }

        public void SpeakTo(Elephant whoToTalkto, string message)
        {
            whoToTalkto.TellMe(message, this);
        }
    }
}
