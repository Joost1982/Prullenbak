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

            Dinner = new DinnerParty() { AantalMensen = (int) numericUpDown1.Value};
            ToonKosten();

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            Dinner.AantalMensen = (int) numericUpDown1.Value;
            ToonKosten();
        }

        private void gezondCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            Dinner.SetHealthyOption(gezondCheckbox.Checked);
            ToonKosten();
        }

        private void fancyCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            Dinner.SetDecoratieType(fancyCheckbox.Checked);
            ToonKosten();
        }

        public void ToonKosten()
        {
            kostenLabel.Text = Dinner.BerekenKosten().ToString("c"); // maakt er currency van
        }

    }
}
