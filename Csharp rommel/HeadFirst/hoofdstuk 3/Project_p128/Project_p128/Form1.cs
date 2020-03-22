using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_p128
{
    public partial class Form1 : Form
    {

        Guy joe;
        Guy bob;
        int bank = 100;

        public Form1()
        {
            InitializeComponent();
            
            joe = new Guy() { Name = "joe", Cash = 50 };
            bob = new Guy() { Name = "bob", Cash = 100 };


            /*
            joe = new Guy();
            joe.Name = "Joe";
            joe.Cash = 50;
            bob = new Guy();
            bob.Name = "Bob";
            bob.Cash = 100;
            */

            UpdateForm();
        }

        public void UpdateForm()
        {
            joesCashLabel.Text = joe.Name + " has $" + joe.Cash;
            bobsCashLabel.Text = bob.Name + " has $" + bob.Cash;
            bankLabel.Text = "The bank has $" + bank;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (bank >= 10)
            {
                bank -= joe.ReceiveCash(10);
                UpdateForm();
            } else
            {
                MessageBox.Show("The bank is out of monwey!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bank += bob.GiveCash(5);
            UpdateForm();
        }

        private void joeGivesToBob_Click(object sender, EventArgs e)
        {
            //Joe gives $10 to Bob

            /****
            if (joe.Cash >= 10 )
            {
                bob.ReceiveCash(10);
            }
            joe.GiveCash(10);
            ****/

            //efficienter:
            bob.ReceiveCash(joe.GiveCash(10));  // de return value van de GiveCash method als parameter gebruiken in de ReceiveCash method

            UpdateForm();

        }

        private void bobGivesToJoe_Click(object sender, EventArgs e)
        {
            //Bob gives $5 to Joe

            /****
            if (bob.Cash >= 5)
            {
                joe.ReceiveCash(5);
            }
            bob.GiveCash(5);
            ****/

            joe.ReceiveCash(bob.GiveCash(5));

            UpdateForm();
        }
    }
}
