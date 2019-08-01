using System;
using System.Windows.Forms;

namespace CowCalculator
{
    public partial class Form1 : Form
    {
        Farmer farmer;
        public Form1()
        {
            InitializeComponent();
            farmer = new Farmer(15,30);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("I need {0} bags of feed for {1} cows", farmer.BagsofFeed, farmer.NumberOfCows);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            farmer.NumberOfCows = (int)numericUpDown1.Value;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //farmer.BagsofFeed = 5;
            //  bovenstaande code werkt nu niet meer omdat ik een property heb gemaakt van BagsofFeed ipv een field
            //  de waarde is vanuit hier nog wel uitleesbaar; zie:
            Console.WriteLine(farmer.BagsofFeed);


        }

    }
}
