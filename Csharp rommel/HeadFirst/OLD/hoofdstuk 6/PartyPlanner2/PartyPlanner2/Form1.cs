using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PartyPlanner2
{
    public partial class Form1 : Form
    {
        DinnerParty Dinner;
        BirthdayParty Birthday;

        public Form1()
        {
            InitializeComponent();

            Dinner = new DinnerParty((int) numericUpDown1.Value, false, false);
            ToonKosten();
            Birthday = new BirthdayParty((int) numericUpDown1.Value, false, "");
            ToonKostenBirthday();
        }

        // Dinner

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            Dinner.AantalMensen = (int) numericUpDown1.Value;
            ToonKosten();
        }

        private void gezondCheckbox_CheckedChanged_1(object sender, EventArgs e)
        {
            Dinner.Healthy = gezondCheckbox.Checked;
            ToonKosten();
        }

        private void fancyCheckbox_CheckedChanged_1(object sender, EventArgs e)
        {
            Dinner.Fancy = fancyCheckbox.Checked;
            ToonKosten();
        }

        public void ToonKosten()
        {
            kostenLabel.Text = Dinner.Kosten.ToString("c"); // maakt er currency van
        }

        // Birthday

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            Birthday.FancyShit = FancyShitCheckboxBirthday.Checked;
            ToonKostenBirthday();
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            Birthday.AantalMensen = (int)numericUpDown2.Value;
            //Console.WriteLine(Birthday.AantalMensen);
            ToonKostenBirthday();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Birthday.CakeWriting = textBox1.Text;
            ToonKostenBirthday();

        }

        private void ToonKostenBirthday()
        {
            TeLangLabel.Visible = Birthday.CakeWritingTeLang;
            decimal kosten = Birthday.Kosten;
            BirthdayKostenLabel.Text = kosten.ToString("c");
        }
    }
}
