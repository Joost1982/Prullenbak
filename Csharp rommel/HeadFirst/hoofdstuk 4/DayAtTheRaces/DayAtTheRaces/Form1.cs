using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace DayAtTheRaces
{
    public partial class Form1 : Form
    {
        Dier[] Diertjes = new Dier[4];
        public Random myRandomizer = new Random();
        public Persoon[] Wedders = new Persoon[3];
        public int Wedder = 0;
       
        public Form1()
        {
            InitializeComponent();

            Diertjes[0] = new Dier() { MijnPlaatje = pictureBox2, StartPositie = pictureBox2.Left, RacebaanLengte = pictureBox1.Width - pictureBox2.Width, Randomizer = myRandomizer }; //pictureBox1 = racebaan plaatje
            Diertjes[1] = new Dier() { MijnPlaatje = pictureBox3, StartPositie = pictureBox3.Left, RacebaanLengte = pictureBox1.Width - pictureBox3.Width, Randomizer = myRandomizer };
            Diertjes[2] = new Dier() { MijnPlaatje = pictureBox4, StartPositie = pictureBox4.Left, RacebaanLengte = pictureBox1.Width - pictureBox4.Width, Randomizer = myRandomizer };
            Diertjes[3] = new Dier() { MijnPlaatje = pictureBox5, StartPositie = pictureBox5.Left, RacebaanLengte = pictureBox1.Width - pictureBox5.Width, Randomizer = myRandomizer };

            Wedders[0] = new Persoon() { Naam = "Joost", Geld = 50, MijnWedje = new Wed(), MyLabel = label4, MyRadioButton = joostRadioButton };
            Wedders[1] = new Persoon() { Naam = "Geertje", Geld = 50, MijnWedje = new Wed(), MyLabel = label5, MyRadioButton = geertjeRadioButton };
            Wedders[2] = new Persoon() { Naam = "Piet", Geld = 50, MijnWedje = new Wed(), MyLabel = label6, MyRadioButton = PietRadioButton };

            minimaleInzetLabel.Text = "Minimale inzet: " + numericUpDown1.Minimum + " euro";

            for (int i = 0; i < Wedders.Length; i++)
            {
                Wedders[i].UpdateLabels();
            }

        }

        private void raceButton_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        public void ResetDogsPosition()
        {
            for (int i = 0; i < 4; i++)
            {
                Diertjes[i].TerugNaarStartPositie();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < Diertjes.Length; i++)
            {
                Diertjes[i].Ren();
                if (Diertjes[i].Ren())
                {   //er is een winnaar!
                    timer1.Stop();
                    ResetDogsPosition();
                    MessageBox.Show("Dier " + (i + 1) + " heeft gewonnen!");

                    // dit kan ook in een loop, maar het zijn er maar 3, dus ik doe het per regel
                    Wedders[0].Ingeld(i + 1);
                    Wedders[1].Ingeld(i + 1);
                    Wedders[2].Ingeld(i + 1);
                }
            }
        }

        private void wedButton_Click(object sender, EventArgs e)
        {
            //PlaatsWedje parameters zijn hoeveelheid en dier
            Wedders[Wedder].PlaatsWedje((int) numericUpDown1.Value, (int) numericUpDown2.Value);
            Wedders[Wedder].UpdateLabels();
        }

        private void joostRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            Wedder = 0;
            naam.Text = Wedders[Wedder].Naam;
        }

        private void geertjeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            Wedder = 1;
            naam.Text = Wedders[Wedder].Naam;
        }

        private void PietRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            Wedder = 2;
            naam.Text = Wedders[Wedder].Naam;
        }
    }
}
