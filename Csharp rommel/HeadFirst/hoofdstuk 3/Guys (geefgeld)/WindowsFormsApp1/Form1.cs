using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
               
    {

        Guy joost;
        Guy geertje;
        int bank = 100;


        public void UpdateForm()
        {
            joostCashLabel.Text = joost.Naam + " heeft " + joost.Geld + " euro";
            geertjeCashLabel.Text = geertje.Naam + " heeft " + geertje.Geld + " euro";
            bankCashLabel.Text = "De bank heeft " + bank + " euro";
        }


        public Form1()
        {
            InitializeComponent();

            joost = new Guy() { Naam = "Joost", Geld = 50 };
            geertje = new Guy() { Naam = "Geertje", Geld = 300 };

            UpdateForm();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (bank >= 10)
            {
                bank -= geertje.OntvangGeld(10);
                UpdateForm();

            } else
            {
                MessageBox.Show("De bank heeft geen geld meer!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bank += joost.GeefGeld(5);
            UpdateForm();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //joost.OntvangGeld(10);
            //geertje.GeefGeld(10);
            // of zo kan het ook:
            joost.OntvangGeld(geertje.GeefGeld(10));
            UpdateForm();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            joost.GeefGeld(5);
            geertje.OntvangGeld(5);
            UpdateForm();
        }
    }
}
