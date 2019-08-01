using System;
using System.Windows.Forms;

namespace DinnerPartyApp
{
    public partial class Form1 : Form
    {
        DinnerParty Dinner;

        public Form1()
        {
            InitializeComponent();

            //Dinner = new DinnerParty() { AantalMensen = (int) numericUpDown1.Value};
            Dinner = new DinnerParty() { AantalMensen = (int) numericUpDown1.Value, gezondje = gezondCheckbox, fancy=fancyCheckbox};
            ToonKosten();

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            Dinner.AantalMensen = (int) numericUpDown1.Value;
            ToonKosten();
        }

        private void gezondCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            Dinner.SetHealthyOption();
            ToonKosten();
        }

        private void fancyCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            ToonKosten();
        }

        public void ToonKosten()
        {
            kostenLabel.Text = Dinner.BerekenKosten().ToString("c"); // maakt er currency van
        }

    }
}
