using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OlifantApp
{
    public partial class Form1 : Form
    {
        Olifant Lloyd = new Olifant { Naam = "Lloyd", OorGrootte = 20 };
        Olifant Lucinda = new Olifant { Naam = "Lucinda", OorGrootte = 33 };

        public Form1()
        {
            InitializeComponent();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Lloyd.wieBenIk();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Lucinda.wieBenIk();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //volgens mij heb je een temp instance nodig, omdat bij het swappen van de een naar de ander, de een verdwijnt...
            Olifant temp1 = Lloyd;
            Lloyd = Lucinda;
            Lucinda = temp1;

            MessageBox.Show("Swapped!");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Lloyd = Lucinda;
            Lloyd.OorGrootte = 450;
            Lloyd.wieBenIk();
        }
    }
}
